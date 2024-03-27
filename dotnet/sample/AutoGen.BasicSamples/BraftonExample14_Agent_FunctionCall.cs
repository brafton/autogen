// Copyright (c) Microsoft Corporation. All rights reserved.
// BraftonExample14_Agent_FunctionCall.cs

using System.Text.Json;
using AutoGen;
using AutoGen.BasicSample;
using FluentAssertions;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.DotNet.Interactive.Formatting;


public class BraftonBrief
{
    public string Name { get; set; }

    public string Title { get; set; }

    public string Keywords { get; set; }

    public string StyleTone { get; set; }

    //public BraftonBrief(string name, string title, string keywords, string styleTone)
    //{
    //    this.Name = name;
    //    this.Title = title;
    //    this.Keywords = keywords;
    //    this.StyleTone = styleTone;
    //}
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
    /// mathamatical sum of numbers `a` and `b` 
    /// </summary>
    /// <param name="a">a number</param>
    /// <param name="b">another number</param>
    /// <returns>the sum of numbers a and b</returns>
    [Function]
    public async Task<string> add(int a, int b)
    {
        return (a + b).ToString();
    }

    /// <summary>
    /// mathematical multiplication of two number `a` and `b`
    /// </summary>
    /// <param name="a">a number</param>
    /// <param name="b">another number</param>
    /// <returns>multiplication of a and b</returns>
    [Function]
    public async Task<string> multi(int a, int b)
    {
        return (a * b).ToString();
    }


    /// <summary>
    /// Creaets a editorial brief in Brafton brief format.
    /// </summary>
    /// <param name="name">name of the brief</param>
    /// <param name="title">title of the brief</param>
    /// <param name="keywords">keywords in the brief</param>
    /// <returns></returns>
    [Function]
    public async Task<string> CreateBraftonBrief(string name, string title, string keywords, string styleTone)
    {
        var t = new BraftonBrief
        {
            Name = name,
            Title = title,
            Keywords = keywords,
            StyleTone = styleTone,
        };

        var JsonStr = JsonSerializer.Serialize(t);
        return JsonStr;
    }

    public static async Task RunAsync()
    {
        var instance = new BraftonExample14_Agent_FunctionCall();
        //var gpt35 = LLMConfiguration.GetOpenAIGPT3_5_Turbo();
        var gpt4 = LLMConfiguration.GetOpenAIGPT4();

        // AutoGen makes use of AutoGen.SourceGenerator to automatically generate FunctionDefinition and FunctionCallWrapper for you.
        // The FunctionDefinition will be created based on function signature and XML documentation.
        // The return type of type-safe function needs to be Task<string>. And to get the best performance, please try only use primitive types and arrays of primitive types as parameters.
        var config = new ConversableAgentConfig
        {
            Temperature = 0,
            ConfigList = [gpt4],
            FunctionContracts = new[]
            {
                //instance.CreateBraftonBriefFunctionContract,
                instance.addFunctionContract,
                instance.multiFunctionContract
            },
        };

        var agent = new AssistantAgent(
            name: "agent",
            systemMessage: "You are a helpful AI Assistant",
            llmConfig: config,
            functionMap: new Dictionary<string, Func<string, Task<string>>>
            {
                //{ nameof(ConcatString), instance.ConcatStringWrapper },
                //{ nameof(UpperCase), instance.UpperCaseWrapper },
                //{ nameof(CalculateTax), instance.CalculateTaxWrapper },
                //{ nameof(CreateBraftonBrief), instance.CreateBraftonBriefWrapper }
                { nameof(add), instance.addWrapper },
                { nameof(multi), instance.multiWrapper }
            })
            .RegisterPostProcess(async (_, reply, _) =>
            {
                if (reply.GetContent()?.ToLower().Contains("terminate") is true)
                {
                    return new TextMessage(Role.Assistant, GroupChatExtension.TERMINATE, from: reply.From);
                }
                return reply;
            })
            .RegisterPrintFormatMessageHook();

        var user = new UserProxyAgent(
                       name: "user",
                                  humanInputMode: HumanInputMode.NEVER)
            .RegisterPrintFormatMessageHook();

        var groupAdmin = new AssistantAgent(name: "groupAdmin", systemMessage: "You are the admin of the group chat");

        var groupChat = new GroupChat(
                admin: groupAdmin,
                members: [agent, user]
                );

        agent.AddInitializeMessage("I'm the assistant.", groupChat);
        user.AddInitializeMessage("I'm the user.", groupChat);

        var groupChatManager = new GroupChatManager(groupChat);
        var conversationHistory = await user.InitiateChatAsync(groupChatManager, "Add 1 and 3 then multiply the result by 4", maxRound: 15);



        // talk to the assistant agent

        //var braftonBrief = await agent.SendAsync("Add 1 and 3 then multiply the result by 4");


        //var upperCase = await agent.SendAsync("convert to upper case: hello world");
        //upperCase.GetContent()?.Should().Be("HELLO WORLD");
        //upperCase.Should().BeOfType<AggregateMessage<ToolCallMessage, ToolCallResultMessage>>();
        //upperCase.GetToolCalls().Should().HaveCount(1);
        //upperCase.GetToolCalls().First().FunctionName.Should().Be(nameof(UpperCase));

        //var concatString = await agent.SendAsync("concatenate strings: a, b, c, d, e");
        //concatString.GetContent()?.Should().Be("a b c d e");
        //concatString.Should().BeOfType<AggregateMessage<ToolCallMessage, ToolCallResultMessage>>();
        //concatString.GetToolCalls().Should().HaveCount(1);
        //concatString.GetToolCalls().First().FunctionName.Should().Be(nameof(ConcatString));

        //var calculateTax = await agent.SendAsync("calculate tax: 100, 0.1");
        //calculateTax.GetContent().Should().Be("tax is 10");
        //calculateTax.Should().BeOfType<AggregateMessage<ToolCallMessage, ToolCallResultMessage>>();
        //calculateTax.GetToolCalls().Should().HaveCount(1);
        //calculateTax.GetToolCalls().First().FunctionName.Should().Be(nameof(CalculateTax));
    }
}
