// Copyright (c) Microsoft Corporation. All rights reserved.
// BraftonExample14_Agent_FunctionCall.cs

using AutoGen;
using AutoGen.BasicSample;
using FluentAssertions;

public class SomeDataStruct
{
    int Id { get; set; }
    string Name { get; set; }

    string Title { get; set; }

    public SomeDataStruct(int id, string name, string title)
    {
        Id = id;
        Name = name;
        Title = title;
    }
}

/// <summary>
/// This example shows how to add type-safe function call to an agent.
/// </summary>
public partial class BraftonExample14_Agent_FunctionCall
{
    /// <summary>
    /// upper case the message when asked.
    /// </summary>
    /// <param name="message"></param>
    [Function]
    public async Task<string> UpperCase(string message)
    {
        return message.ToUpper();
    }

    /// <summary>
    /// Concatenate strings.
    /// </summary>
    /// <param name="strings">strings to concatenate</param>
    [Function]
    public async Task<string> ConcatString(string[] strings)
    {
        return string.Join(" ", strings);
    }

    /// <summary>
    /// calculate tax
    /// </summary>
    /// <param name="price">price, should be an integer</param>
    /// <param name="taxRate">tax rate, should be in range (0, 1)</param>
    [Function]
    public async Task<string> CalculateTax(int price, float taxRate)
    {
        return $"tax is {price * taxRate}";
    }

    /// <summary>
    /// Coverts to a Something data structrue.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="title"></param>
    /// <returns></returns>
    [Function]
    public async Task<string> ConvertToSomething(int id, string name, string title)
    {
        return ""; new SomeDataStruct(id, name, title);
    }

    public static async Task RunAsync()
    {
        var instance = new BraftonExample14_Agent_FunctionCall();
        var gpt35 = LLMConfiguration.GetOpenAIGPT3_5_Turbo();

        // AutoGen makes use of AutoGen.SourceGenerator to automatically generate FunctionDefinition and FunctionCallWrapper for you.
        // The FunctionDefinition will be created based on function signature and XML documentation.
        // The return type of type-safe function needs to be Task<string>. And to get the best performance, please try only use primitive types and arrays of primitive types as parameters.
        var config = new ConversableAgentConfig
        {
            Temperature = 0,
            ConfigList = [gpt35],
            FunctionContracts = new[]
            {
                //instance.ConcatStringFunctionContract,
                //instance.UpperCaseFunctionContract,
                instance.CalculateTaxFunctionContract,
                instance.ConvertToSomethingFunctionContract,

            },
        };

        var agent = new AssistantAgent(
            name: "agent",
            systemMessage: "You are a helpful AI assistant",
            llmConfig: config,
            functionMap: new Dictionary<string, Func<string, Task<string>>>
            {
                { nameof(ConcatString), instance.ConcatStringWrapper },
                { nameof(UpperCase), instance.UpperCaseWrapper },
                { nameof(CalculateTax), instance.CalculateTaxWrapper },
                { nameof(ConvertToSomething), instance.ConvertToSomethingWrapper }
            })
            .RegisterPrintFormatMessageHook();

        // talk to the assistant agent
        var upperCase = await agent.SendAsync("convert to upper case: hello world");
        upperCase.GetContent()?.Should().Be("HELLO WORLD");
        upperCase.Should().BeOfType<AggregateMessage<ToolCallMessage, ToolCallResultMessage>>();
        upperCase.GetToolCalls().Should().HaveCount(1);
        upperCase.GetToolCalls().First().FunctionName.Should().Be(nameof(UpperCase));

        var concatString = await agent.SendAsync("concatenate strings: a, b, c, d, e");
        concatString.GetContent()?.Should().Be("a b c d e");
        concatString.Should().BeOfType<AggregateMessage<ToolCallMessage, ToolCallResultMessage>>();
        concatString.GetToolCalls().Should().HaveCount(1);
        concatString.GetToolCalls().First().FunctionName.Should().Be(nameof(ConcatString));

        var calculateTax = await agent.SendAsync("calculate tax: 100, 0.1");
        calculateTax.GetContent().Should().Be("tax is 10");
        calculateTax.Should().BeOfType<AggregateMessage<ToolCallMessage, ToolCallResultMessage>>();
        calculateTax.GetToolCalls().Should().HaveCount(1);
        calculateTax.GetToolCalls().First().FunctionName.Should().Be(nameof(CalculateTax));
    }
}
