// Copyright (c) Microsoft Corporation. All rights reserved.
// BraftonExample12_Brief_Writer_With_Human.cs

using AutoGen;
using AutoGen.BasicSample;
using FluentAssertions;



public partial class BraftonExample12_Brief_Writer_With_Human
{

    public static async Task RunAsync()
    {


        #region breif template

        var briefTemplate = @"
        - TONE OF VOICE: Provide 3 detailed tips with instructions on how to mimic the tone of voice in the sample copy. Also, provide 3 adjectives that describe the tone of voice in the sample copy.

        - WRITING STYLE: Provide 3 detailed tips with instructions on how to mimic the writing style in the sample copy. Also, provide 3 adjectives that describe the writing style in the sample copy.

        - WORD CHOICE: Provide 3 highly detailed tips with instructions on how to mimic the word choice in the sample copy. Also, provide 3 adjectives that describe word choice in the sample copy.

        - METHOD OF DISCUSSING FACTS: Provide 3 detailed tips with instructions on how to mimic the way facts are presented in the sample copy. 

        - LEVEL OF FORMALITY: Provide 3 detailed tips with instructions on how to mimic the degree of formality or conversationality in the sample copy when composing a new piece of writing. Also, provide 3 adjectives that describe the level of formality or informality in the sample copy.

        - SENTENCE STRUCTURE AND VARIETY: Provide 2 detailed tips with instructions on how to mimic the variety and structure of sentences in the sample copy.

        - METHOD OF INCORPORATING OUTSIDE SOURCES: Provide 2 detailed tips with instructions on how to mimic how outside sources are incorporated and referenced in the sample copy. If there are no outside sources in teh provided sample copy then just say 'N/A - no outside sources in the sample copy'.

        - PRESENTATION OF IDEAS: Provide 1 detailed tip with instructions on how to mimic the presentation of ideas in the sample copy.

        - GRAMMATICAL POINT OF VIEW: Provide 1 tip with instructions on how to use the same point of view (i.e., first-, second-, or third-person point of view) as the sample copy.

        - PARAGRAPH LENGTH: One short clear sentence.

        - LANGUAGE CODE: Name the IETF language code in the sample copy. If unsure, default to en-US.
          ";
        #endregion 

        //, and reduce the suggested sentence lengths by half - so if you find 4 to 6 sentences, report 2 to 3 sentences.


        #region sample copy variables
        IList<string> copyListPaul = new List<string>();
        IList<string> copyListBrafton = new List<string>();
        IList<string> fluffyBunny = new List<string>();
        IList<string> copyListDonaldDuck = new List<string>{
    "​Hey, [Player]! Today's the day your fishing rival--that's me--will test you on your fishing ability. Ha ha ha! C'mon, it'll be fun! Just bring what I ask for and you'll pass. But see, the thing I ask for? You can only get it--if you're lucky--when you're reeling in a really rare fish. Whaddya say? You'll do it, right?",
    "​Great! Then it's settled! Now hurry up and bring it back to me, got it? If you take too long, you automatically fail!",
    "Didja catch that fish yet?",
    "​​Well? WAK! You did it! Congratulations! I always knew you had it in ya! Yep, I gotta hand it to ya--you've got real talent! You're a bona fide master angler!",
    "Hi again! I see you're bursting with enthusiasm like always! Pretty impressive, [Player]... but you'll never beat me! WAAAK!",
    "Woohoo! How cool is that?",
    "It's about time you got here! My name's Donald Duck. You're going to have a great time!"
};


        copyListPaul.Add(@"Alien Truth

October 2022

If there were intelligent beings elsewhere in the universe, they'd share certain truths in common with us. The truths of mathematics would be the same, because they're true by definition. Ditto for the truths of physics; the mass of a carbon atom would be the same on their planet. But I think we'd share other truths with aliens besides the truths of math and physics, and that it would be worthwhile to think about what these might be.

For example, I think we'd share the principle that a controlled experiment testing some hypothesis entitles us to have proportionally increased belief in it. It seems fairly likely, too, that it would be true for aliens that one can get better at something by practicing. We'd probably share Occam's razor. There doesn't seem anything specifically human about any of these ideas.

We can only guess, of course. We can't say for sure what forms intelligent life might take. Nor is it my goal here to explore that question, interesting though it is. The point of the idea of alien truth is not that it gives us a way to speculate about what forms intelligent life might take, but that it gives us a threshold, or more precisely a target, for truth. If you're trying to find the most general truths short of those of math or physics, then presumably they'll be those we'd share in common with other forms of intelligent life.

Alien truth will work best as a heuristic if we err on the side of generosity. If an idea might plausibly be relevant to aliens, that's enough. Justice, for example. I wouldn't want to bet that all intelligent beings would understand the concept of justice, but I wouldn't want to bet against it either.

The idea of alien truth is related to Erdos's idea of God's book. He used to describe a particularly good proof as being in God's book, the implication being (a) that a sufficiently good proof was more discovered than invented, and (b) that its goodness would be universally recognized. If there's such a thing as alien truth, then there's more in God's book than math.

What should we call the search for alien truth? The obvious choice is ""philosophy."" Whatever else philosophy includes, it should probably include this. I'm fairly sure Aristotle would have thought so. One could even make the case that the search for alien truth is, if not an accurate description of philosophy, a good definition for it. I.e. that it's what people who call themselves philosophers should be doing, whether or not they currently are. But I'm not wedded to that; doing it is what matters, not what we call it.

We may one day have something like alien life among us in the form of AIs. And that may in turn allow us to be precise about what truths an intelligent being would have to share with us. We might find, for example, that it's impossible to create something we'd consider intelligent that doesn't use Occam's razor. We might one day even be able to prove that. But though this sort of research would be very interesting, it's not necessary for our purposes, or even the same field; the goal of philosophy, if we're going to call it that, would be to see what ideas we come up with using alien truth as a target, not to say precisely where the threshold of it is. Those two questions might one day converge, but they'll converge from quite different directions, and till they do, it would be too constraining to restrict ourselves to thinking only about things we're certain would be alien truths. Especially since this will probably be one of those areas where the best guesses turn out to be surprisingly close to optimal. (Let's see if that one does.)

Whatever we call it, the attempt to discover alien truths would be a worthwhile undertaking. And curiously enough, that is itself probably an alien truth.");


        copyListPaul.Add(@"Orthodox Privilege

July 2020

""Few people are capable of expressing with equanimity opinions which differ from the prejudices of their social environment. Most people are even incapable of forming such opinions.""

— Einstein


There has been a lot of talk about privilege lately. Although the concept is overused, there is something to it, and in particular to the idea that privilege makes you blind — that you can't see things that are visible to someone whose life is very different from yours.

But one of the most pervasive examples of this kind of blindness is one that I haven't seen mentioned explicitly. I'm going to call it orthodox privilege: The more conventional-minded someone is, the more it seems to them that it's safe for everyone to express their opinions.

It's safe for them to express their opinions, because the source of their opinions is whatever it's currently acceptable to believe. So it seems to them that it must be safe for everyone. They literally can't imagine a true statement that would get you in trouble.

And yet at every point in history, there were true things that would get you in trouble to say. Is ours the first where this isn't so? What an amazing coincidence that would be.

Surely it should at least be the default assumption that our time is not unique, and that there are true things you can't say now, just as there have always been. You would think. But even in the face of such overwhelming historical evidence, most people will go with their gut on this one.

In the most extreme cases, people suffering from orthodox privilege will not only deny that there's anything true that you can't say, but will accuse you of heresy merely for saying there is. Though if there's more than one heresy current in your time, these accusations will be weirdly non-deterministic: you must either be an xist or a yist.

Frustrating as it is to deal with these people, it's important to realize that they're in earnest. They're not pretending they think it's impossible for an idea to be both unorthodox and true. The world really looks that way to them.

Indeed, this is a uniquely tenacious form of privilege. People can overcome the blindness induced by most forms of privilege by learning more about whatever they're not. But they can't overcome orthodox privilege just by learning more. They'd have to become more independent-minded. If that happens at all, it doesn't happen on the time scale of one conversation.

It may be possible to convince some people that orthodox privilege must exist even though they can't sense it, just as one can with, say, dark matter. There may be some who could be convinced, for example, that it's very unlikely that this is the first point in history at which there's nothing true you can't say, even if they can't imagine specific examples.

But in general I don't think it will work to say ""check your privilege"" about this type of privilege, because those in its demographic don't realize they're in it. It doesn't seem to conventional-minded people that they're conventional-minded. It just seems to them that they're right. Indeed, they tend to be particularly sure of it.

Perhaps the solution is to appeal to politeness. If someone says they can hear a high-pitched noise that you can't, it's only polite to take them at their word, instead of demanding evidence that's impossible to produce, or simply denying that they hear anything. Imagine how rude that would seem. Similarly, if someone says they can think of things that are true but that cannot be said, it's only polite to take them at their word, even if you can't think of any yourself.");

        copyListPaul.Add(@"The Acceleration of Addictiveness

July 2010

What hard liquor, cigarettes, heroin, and crack have in common is that they're all more concentrated forms of less addictive predecessors. Most if not all the things we describe as addictive are. And the scary thing is, the process that created them is accelerating.

We wouldn't want to stop it. It's the same process that cures diseases: technological progress. Technological progress means making things do more of what we want. When the thing we want is something we want to want, we consider technological progress good. If some new technique makes solar cells x% more efficient, that seems strictly better. When progress concentrates something we don't want to want — when it transforms opium into heroin — it seems bad. But it's the same process at work. [1]

No one doubts this process is accelerating, which means increasing numbers of things we like will be transformed into things we like too much. [2]

As far as I know there's no word for something we like too much. The closest is the colloquial sense of ""addictive."" That usage has become increasingly common during my lifetime. And it's clear why: there are an increasing number of things we need it for. At the extreme end of the spectrum are crack and meth. Food has been transformed by a combination of factory farming and innovations in food processing into something with way more immediate bang for the buck, and you can see the results in any town in America. Checkers and solitaire have been replaced by World of Warcraft and FarmVille. TV has become much more engaging, and even so it can't compete with Facebook.

The world is more addictive than it was 40 years ago. And unless the forms of technological progress that produced these things are subject to different laws than technological progress in general, the world will get more addictive in the next 40 years than it did in the last 40.

The next 40 years will bring us some wonderful things. I don't mean to imply they're all to be avoided. Alcohol is a dangerous drug, but I'd rather live in a world with wine than one without. Most people can coexist with alcohol; but you have to be careful. More things we like will mean more things we have to be careful about.

Most people won't, unfortunately. Which means that as the world becomes more addictive, the two senses in which one can live a normal life will be driven ever further apart. One sense of ""normal"" is statistically normal: what everyone else does. The other is the sense we mean when we talk about the normal operating range of a piece of machinery: what works best.

These two senses are already quite far apart. Already someone trying to live well would seem eccentrically abstemious in most of the US. That phenomenon is only going to become more pronounced. You can probably take it as a rule of thumb from now on that if people don't think you're weird, you're living badly.

Societies eventually develop antibodies to addictive new things. I've seen that happen with cigarettes. When cigarettes first appeared, they spread the way an infectious disease spreads through a previously isolated population. Smoking rapidly became a (statistically) normal thing. There were ashtrays everywhere. We had ashtrays in our house when I was a kid, even though neither of my parents smoked. You had to for guests.

As knowledge spread about the dangers of smoking, customs changed. In the last 20 years, smoking has been transformed from something that seemed totally normal into a rather seedy habit: from something movie stars did in publicity shots to something small huddles of addicts do outside the doors of office buildings. A lot of the change was due to legislation, of course, but the legislation couldn't have happened if customs hadn't already changed.

It took a while though—on the order of 100 years. And unless the rate at which social antibodies evolve can increase to match the accelerating rate at which technological progress throws off new addictions, we'll be increasingly unable to rely on customs to protect us. [3] Unless we want to be canaries in the coal mine of each new addiction—the people whose sad example becomes a lesson to future generations—we'll have to figure out for ourselves what to avoid and how. It will actually become a reasonable strategy (or a more reasonable strategy) to suspect everything new.

In fact, even that won't be enough. We'll have to worry not just about new things, but also about existing things becoming more addictive. That's what bit me. I've avoided most addictions, but the Internet got me because it became addictive while I was using it. [4]

Most people I know have problems with Internet addiction. We're all trying to figure out our own customs for getting free of it. That's why I don't have an iPhone, for example; the last thing I want is for the Internet to follow me out into the world. [5] My latest trick is taking long hikes. I used to think running was a better form of exercise than hiking because it took less time. Now the slowness of hiking seems an advantage, because the longer I spend on the trail, the longer I have to think without interruption.

Sounds pretty eccentric, doesn't it? It always will when you're trying to solve problems where there are no customs yet to guide you. Maybe I can't plead Occam's razor; maybe I'm simply eccentric. But if I'm right about the acceleration of addictiveness, then this kind of lonely squirming to avoid it will increasingly be the fate of anyone who wants to get things done. We'll increasingly be defined by what we say no to.");

        copyListBrafton.Add(@"Content marketing is a proven powerhouse strategy that works wonders across all sorts of industries, from tech startups to health care giants. But in the manufacturing world, it’s a different beast altogether. This blog is your practical guide to mastering your branding in the unique and challenging field of manufacturing. 

We’re here to help you unlock its potential and turn content marketing into a winning strategy for your manufacturing business. 

Why Manufacturing Content Marketing Is Essential
Content marketing plays a crucial role in the manufacturing sector, especially given its B2B focus and central position in the supply chain. Unlike in the B2C realm, where engaging the end consumer is key, content marketing for manufacturing companies caters to a different audience: businesses and industry professionals. This demographic craves content that’s rich in detail, technically accurate and relevant — making content marketing essential for success in this industry.

At the core of the supply chain, manufacturing companies need to communicate their complex processes, technological innovations and industry insights effectively. Here, content marketing isn’t about flashy consumer ads; it’s about delivering substantial, in-depth content that resonates with businesses and experts in the manufacturing field. 

Implementing this approach is vital for building trust, establishing credibility and positioning your company as a thought leader in the manufacturing community.

Here’s a quick look at what makes a robust content marketing strategy in manufacturing:

Understanding your audience.
Demonstrating technical expertise.
Maintaining relevance and consistency.
Integrating with digital marketing.
So, what do manufacturing companies gain from diving into content marketing? The advantages are pretty impressive and cover a lot of ground, from how they’re seen in the industry to how they connect with their audience:

Brand awareness: Ramping up your company’s profile in a busy market.
Standing out: Highlighting what’s special about your manufacturing methods or the innovative tech you use.
Quality insights: Offering a look at the nitty-gritty of your operations and the care that goes into your products.
Business growth: Attracting new clients and building strong, lasting partnerships.
Becoming an industry leader: Setting your brand up as the go-to expert in the manufacturing world.
Teaching the market: Showing potential customers why your products are top-notch.
Generating leads: Turning interest into solid leads and potential sales.
Keeping customers coming back: Engaging your existing customers with content that keeps them interested.
In short, content marketing is a game-changer for manufacturing businesses, helping them market better and grow and evolve in their industry.

8 Types of Content Marketing for Manufacturers
Next up, let’s talk about how manufacturers can leverage various content marketing types to communicate effectively with potential customers and partners:

1. White Papers
White papers are in-depth reports that provide expert insights on specific industry topics, establishing a company’s authority and expertise. For instance, a manufacturing company might release a white paper discussing how robotics can contribute to improved manufacturing efficiency. A paper in this field would explore cutting-edge robotic technologies, demonstrating the business’s leadership in manufacturing innovation and attracting potential partners interested in advanced automation solutions.

2. Infographics
Infographics are powerful visual tools that distill complex data into easily digestible, engaging graphics. In the manufacturing sector, a company could use an infographic to illustrate the lifecycle of a product. This would visually depict each stage, from sourcing raw materials, through the manufacturing process, to final distribution. This approach not only highlights the company’s efficiency and attention to detail but also helps potential clients and partners understand the intricacies of their production methods.

3. Blog Posts
​​Blog posts are an excellent medium for sharing insights and expertise. In the manufacturing sector, a company could write a series of blog posts about the role of sustainable practices in modern manufacturing. These posts could delve into topics like eco-friendly materials, energy-efficient production methods or waste reduction strategies. This series would highlight the company’s commitment to sustainability, showcasing its role in promoting environmentally responsible manufacturing and engaging with readers who value green initiatives in the industry.

4. Social Media Marketing
Social media marketing allows manufacturing companies to connect directly with their audience in a dynamic way. For example, a company could use social media platforms to share behind-the-scenes glimpses of their factory operations or the product creation process. This approach humanizes the brand and demystifies the manufacturing process, engaging followers with a real-time look at how products are made, the technology used and the people involved in the production. Applying this strategy boosts transparency and customer engagement, and strengthens the company’s image as an accessible and open manufacturer.

5. Email Marketing
Email marketing is a direct and personalized way for manufacturing companies to keep their audience informed and engaged. For instance, they could send out regular newsletters that update subscribers on the latest industry trends, new technologies or important company news. This approach keeps the audience in the loop about advancements in manufacturing and the company’s ongoing developments, fostering a sense of community and engagement.

6. Video Marketing
Video marketing offers an engaging way to showcase a company’s expertise and products. A manufacturing company could create instructional or educational videos that explain various manufacturing techniques or provide product demonstrations. These videos can help demystify complex processes and showcase the company’s products in action, enhancing customer understanding and interest.

7. Case Studies
Case studies are a powerful tool to demonstrate a company’s expertise and the real-world impact of its solutions. Manufacturing companies can create detailed case studies that highlight successful projects or partnerships, focusing on the challenges they faced and the results they achieved. These case studies not only illustrate the company’s problem-solving capabilities but also build credibility and trust with potential clients.");

        copyListBrafton.Add(@"As creators, marketers, storytellers and members of a global society, consuming information is a huge part of our everyday lives. But what can happen when we put down the phones, switch off the screens and let inspiration find us instead of the other way around?

That’s part of what makes Ramiro Gonzalez, Director of Sales and Account Management here at Brafton, consistently able to “pass the vibe check.” Here’s how he does it!

Life in the Fast Lane (Sort Of)
Growing up, Ramiro says he was the “typical kid” who wanted to be an astronaut or a race car driver. His interests in moving fast and shooting for the stars didn’t land him in the literal fast lane, but they’ve taken him pretty far in his career.

“I’ve always been involved in sales and marketing somehow,” he says. “As a kid, I was constantly selling things. I’d buy skateboarding stuff and resell it at a profit. Then, as a bartender and server, I was still doing some kind of selling.” 

After selling skateboards and snacks, Ramiro jumped into the fashion scene. He started a local clothing company, complete with a website, graphics, distributor relationships and more. Once again, his aptitude for sales and marketing was front and center. “I don’t give up. I question absolutely everything, and I don’t take no for an answer.”


Next, Ramiro moved into the digital marketing space as a freelancer. He worked with companies in his home state of Florida, sharpening his skills and building his community at the same time. 

Everything was going great — and then COVID-19 changed the world.

“Most of my clients were small local businesses heavily impacted by the pandemic,” says Ramiro. “It was pretty tough. I rode it out for a while, but at some point, I figured I could transfer my skills.”

Lucky for us, the metaphorical fast lane brought him here to Brafton. He started in November 2021 as a Sales Development Representative. Within 2 weeks, he was promoted to Director of Sales and Account Management — and now he’s an integral part of our team.

Same Skills, Bigger Stories
Ramiro’s background as a freelance marketer and entrepreneur made him creative, determined and confident that he could get things done on his own (If you’re a creator of any kind, you can probably relate.) But now that he’s at Brafton, he says he’s far more comfortable depending on a team of smart, talented co-workers. 

He says he’s thrilled to be working with talented individuals across different areas of expertise. “The continuous education factor is something I really appreciate.” Here’s what he has to say about just a few teams here at Brafton:

Editorial: “I take a lot from copywriters. Copy that sells and resonates with people — that’s an invaluable skill that sets a lot of creatives apart.”
Design: “I’m learning just how important user experience really is in terms of standing out. We’re always trying to provide the best experience for our clients.”
Strategy: “I love seeing how Content Management Strategists manage accounts and keep our clients happy.”
Before Brafton, Ramiro says he had to learn everything on his own. Now, we’ve all got his back — and he has ours.");

        fluffyBunny.Add(@"9 Better-for-You Halloween Candy Alternatives

Is it possible to find healthy Halloween candy alternatives without being that house on the block that hands out apples and carrot sticks? You want people to come back next year, not run away in fear of a dreary candy alternative. 

Honestly, it’s scary how much sugar trick-or-treaters consume every year. It’s OK to have the occasional splurge — balance is key — but surely there’s a better way. We’ve rounded up some of our favorite candy alternative options. But what makes these treats healthier, exactly? It’s all about the ingredient lists. Many of the following brands make balanced nutrition and organic sourcing a top priority. For you, that means you can worry less about scary side effects of high sugar intake. 

Whether it’s fruit snacks, organic dark chocolates or our signature bars, there’s a better-for-you option that won’t have your neighbors crashing from a sugar rush the morning after Halloween night. 

Like Sweets? Try Handing These Out Instead
Nothing says Halloween quite like a pumpkin pail full of yummy candy. The only problem is, that collection of treats has a spooky side. While it’s not bad to eat a few pieces here and there, too much of a good thing can end in a sour stomach or even worse results for your kids and neighbors. 

Want to be the cool house that hands out the best healthy Halloween treats without any of the tricks? Swap out your current confectionary for these sweets that won’t creep up on you: 

YumEarth Organic Halloween Candy
For a treat with no dyes, peanuts, tree nuts, soy, dairy, sesame, egg, gluten, shellfish, or fish, look no further than YumEarth Organic Halloween Candy. The variety pack comes with gummy fruits, lollipops, and chewy candy bites that will delight any costume-clad kid (or adult, for that matter). 

For other gluten-free snack options, check out this article. 

Peanut Butter Shortbread Cookies With Pressed Flowers
If you want to take our beloved Peanut Butter Perfect Bar to the next level, try using this recipe to create beautiful shortbread cookies to hand out to visitors. With most of the work already being done by using our bars, you’ll have these out of the oven and into Halloween pails in no time. 

All you need for ingredients are:

2 cups of all-purpose flour or gluten-free all-purpose flour
1/2 cup cornstarch
1 cup unsalted butter, room temperature
2 Peanut Butter Perfect Bar, room temperature
1/2 tsp sea salt
1/2 cup granulated cane sugar
2 tsp vanilla bean paste or pure vanilla extract
1 cup edible flowers for decorating, such as violas, pansies, nasturtiums, and blue borage
Fine sanding or casting sugar, for sprinkling

Almond Butter & Chocolate Bar
Ditch the Snickers bar and instead make a healthier alternative. With our Almond Butter Perfect Bar as a base, add caramel topping (made with dates), chopped almonds, and melted dark chocolate for a mouth-watering treat. To make these almond butter and chocolate bars, you’ll need:

Almond Butter Perfect Bar
Caramel Topping
3/4 cup pitted dates
2 tbsp almond butter
1/4 tsp vanilla extract
A pinch of salt
1/4 cup of water
Chopped almonds
Melted dark chocolate

Annie’s Organic Bunny Grahams
Annie’s has been making healthy and organic food for over 30 years, and these snacks are no exception. Whether you purchase their variety pack with cheddar squares, cheddar bunny grahams, or chocolate bunny grahams or opt for a larger pack of your favorite of the three, you won’t be let down. These  healthy Halloween treats are made with organic wheat flour and have one gram of protein in every serving, making them a tasty option you can trust. 

Mummy and Spider Web Peanut Butter Cups
Another DIY treat you can create are the cutest mummy and spider web peanut butter cups, using our dark chocolate Refrigerated Peanut Butter Cups as a base. If you’re in a hurry but still want to create a (slightly) creepy snack for trick-or-treaters, this quick recipe will fit the bill. 

Here’s what you’ll need to have handy to make 24 pieces:

Twelve (1.4 oz) packs Perfect Snacks Dark Chocolate with Sea Salt Peanut Butter Cups
4 -oz white chocolate baking chips
2 tbsp candy eyeballs, for decorating
2 tbsp pretzels, (optional – for making peanut butter cup spiders

Solely Organic Whole Fruit Gummies
You know what kids love? Fruit snacks. But parents don’t love the artificial sugars and flavors used in many of the leading brands. Well, Solely created a tasty alternative that’s packed with real fruit and vitamin C and free from unnecessary additives. They have delicious flavors like mango, guava, and passion fruit, options that you and your kids will both adore. 

Snack Size Perfect Bar Tombstone Dirt Cups
Another small goody that Halloween lovers will adore are these Snack Size Perfect Bar tombstone dirt cups, with a surprise ingredient: avocados! These small morsels are a healthier take on a beloved chocolate pudding dish, made easily with very little assembly. 

Add these ingredients to your shopping list so you can make this treat ASAP:

4 small ripe avocados
½ cup unsweetened cacao powder
2/3 cup oat milk, or milk of choice
2/3 cup + 1 tbsp maple syrup
6 ounces 55% dark chocolate, melted
1 tsp pure vanilla extract
¼ tsp sea salt
2 cups chocolate cream sandwich cookies (about 16 to 18 cookies), crushed
2 ounces dark chocolate, melted for writing on tombstones
12 whole Peanut Butter Snack Size Perfect Bar
1 cup of regular or sour gummy worms, optional

Joyride Red Licorice Twists
For the chewy candy lovers, there’s a better way to get a fill of your favorite red candy. Joyride makes bite-sized licorice pieces that have zero sugar, sugar alcohols, and synthetic colors, are plant-based, and a good source of fiber. This candy is also vegan and contains no gelatin, IMO, maltitol, artificial sweeteners, and preservatives. They also taste great, meaning you don’t have to sacrifice flavor for quality.

SmartSweets Caramels
For a fun twist on the toffee-flavored sweets, add SmartSweets Caramels to your cart this Halloween. With only one gram of sugar, 140 calories, and no artificial sweeteners, this candy option won’t haunt you or any witches and warlocks on All Hallows’ Eve. On top of that, these caramels are gluten-free, plant-based, and naturally flavored. 

Frightening Ingredients To Keep an Eye On
While it’s OK to indulge in a high-in-sugar candy bar every so often, there’s a reason we suggest finding other options when needing a sweet treat on a regular basis: There are a lot of harmful ingredients found in these snacks that you should be aware of.

Artificial Colors
Blue 1, Yellow 5, Yellow 6, and Red 40 have all been linked to cancers and can cause hyperactivity — particularly in children. These are some of the most commonly used food dyes in many popular candies, and they contain potentially dangerous substances, such as 4-aminobiphenyl, 4-aminoazobenzene, and benzidine. 

Tertiary-Butylhydroquinone
Tertiary-Butylhydroquinone — TBHQ for short — is a synthetic antioxidant that’s designed to keep food from spoiling. While it’s FDA approved, it’s still not a great element to consume. It’s used in vegetable oils, animal fats, snack crackers, noodles, fast and frozen foods, and candy. A study done by the Centers for Science in the Public Interest found that this additive increased the incidence of tumors in the rats being used for testing.

High Fructose Corn Syrup
Manufactured from corn starch sourced from genetically-modified crops, this sugar replacement is linked to obesity, heart issues, arthritis, diabetes, and insulin resistance. According to Shore Gastroenterology Associates, it is associated with fatty liver disease, which can impact your weight and heart health. It also can increase the risk of heart and cardiovascular diseases. 

Camauba Wax
This chemical is used to give bubble gum its (mostly) long-lasting flavor and consistency, but it’s thought to be linked to cancerous tumors when eaten in large amounts. It can also cause allergic reactions in certain people that are sensitive to this type of wax. 

Have the Perfect Halloween With Perfect Bar
You don’t have to be the house that kids skip or pretend not to take notice of. Be the house every trick-or-treater gets excited to stop by with these delicious and healthy alternatives. With great ingredients and amazing taste to boot, parents can rest easy on Halloween night knowing that they’ve handed out a snack that won’t disappoint. 

Try our bars for yourself today to see what all the hype is about. 
            ");

        #endregion 

        var functions = new BraftonExample12_Brief_Writer_With_Human();

        var gpt4Config = LLMConfiguration.GetOpenAIGPT4(); //LLMConfigAPI.GetOpenAIConfigList(openAIKey, new[] { "gpt-4-turbo-preview" });

        var perfectBriefAvgScore = "9.5";

        #region brief_writer
        // ref: process definitonId: 65b931284c5312a863a24102
        var briefWriter = new AssistantAgent(
        name: "brief_writer",
        systemMessage: $@"You are a world-class expert in analyzing and emulating the tone and style of a piece of writing. You have a highly advanced understanding of language and writing. You are skilled in detecting language code. You only reply with the requested content; you don't reply conversationally. You provide direct instructions, not explanations or analysis. Do not include anything other than the brief in your reply.

        Provide specific instructions for how to mimic the following elements in the provided sample copy that is delimited by the <sample-copy> tags. Provide the mimic instructions detailed in each of the points in the brief template below delimited by the <brief-template> tag. Your response instructions should be direct instruction to me on how to mimic each aspect of the writing, rather than an analysis of explanation. Provide your response within <brief></brief> tags.
        <brief-template>
        {briefTemplate}
        </brief-template>
        ",
        llmConfig: new ConversableAgentConfig
        {
            Temperature = 0.3f,
            ConfigList = [gpt4Config],
            MaxTokens = 4000,
        })
        .RegisterPrintFormatMessageHook();
        #endregion

        #region brief_scorer
        var briefScorer = new AssistantAgent(
        name: "brief_scorer",
        systemMessage: $@"You are a world class writing brief scoring engine. 
                        You take a piece of sample copy and a set of writing rules in the <brief>. The idea is that the rules perfectly describe how to mimic the writing of the <sample-copy>.
                        1. Follow these steps for each rule in the <brief>:

                            1.1. Score how well the <brief> reflects the <sample-copy> out of 10, for example '7/10'. You are very critical and only score 10 if something is perfect.
                            1.2. If the score for the rule is '10/10' then say [ALL GOOD] and nothing else.
                            1.3. If the score is less than '10/10', provide specific clear suggestions to improve the brief rule such that the <sample-copy> when checked against the updated <brief> again would score a '10/10'.

                        2. Then after all of the rules have been scored:

                            2.1. Include an [OVERALL SCORE] as an average across all of the brief rule scores.
                            2.2. Don't modify any of the <sample-copy> at all.
                            2.3. If the [OVERALL SCORE] is greater than or equal to {perfectBriefAvgScore} say [PERFECT] otherwise say [IMPROVE].
         ",
        llmConfig: new ConversableAgentConfig
        {
            Temperature = 0.3f,
            ConfigList = [gpt4Config],
        })
        .RegisterPrintFormatMessageHook();
        #endregion


        #region brief_editor
        var briefEditor = new AssistantAgent(
            name: "brief_editor",
            systemMessage: $@"You are a world class brief editor. You make improvements to the brief based on the priveded suggestions. Every section must score at least 9 and the overall score must be greater than {perfectBriefAvgScore}. You change the brief directly. You don't explain the changes in any way. Provide your response within <brief></brief> tags.",

            llmConfig: new ConversableAgentConfig
            {
                Temperature = 0.3f,
                ConfigList = [gpt4Config],
                MaxTokens = 4000
            })
            .RegisterPrintFormatMessageHook();
        #endregion

        #region create_admin
        var admin = new AssistantAgent(
            name: "admin",
            systemMessage: "You are group admin. You help coordinate the group. Start by making sure the task is clear to each person in the group. Terminate the group chat once the task is completed successfully by saying [TERMINATE]",
            llmConfig: new ConversableAgentConfig
            {
                Temperature = 0.2f,
                ConfigList = [gpt4Config],
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
        #endregion create_admin

        #region human_checker
        var humanChecker = new UserProxyAgent(
            name: "human_checker",
            humanInputMode: HumanInputMode.ALWAYS
            )
            .RegisterPrintFormatMessageHook();
        #endregion

        #region create_group_chat
        var groupChat = new GroupChat(
            admin: admin,
            members: [admin, briefWriter, briefEditor, briefScorer, humanChecker]
            );

        admin.AddInitializeMessage("Welcome to my group, work together to resolve my task. Remember <improve> means iterate on the brief based on the given feedback. When the brief is <perfect> hand over to human_checker. The task is complete successfully only when the human_checker says so.", groupChat);
        briefWriter.AddInitializeMessage("I will analyze sample copy and write an advanced brief based on the sample copy. I always pass what I write to the brief_scorer.", groupChat);
        briefScorer.AddInitializeMessage($"I will score a brief based on how well it captures the essence of the sample copy provided. I provide suggested improvements to the brief rules to achieve a score of 10. I hand over to brief_editor if the average overall score is below {perfectBriefAvgScore}. When the score is perfect I hand over to human_checker", groupChat);
        briefEditor.AddInitializeMessage("I will improve a brief based on the suggestions from brief_scorer and human_checker. I always give the updated brief to brief_scorer to rechecked.", groupChat);
        humanChecker.AddInitializeMessage("I'm a proxy for human_checker. I will relay feedback from a human.", groupChat);

        var groupChatManager = new GroupChatManager(groupChat);
        #endregion create_group_chat

        #region start_group_chat
        var p = $@"Write a brief based on one of the sample copy below.
                <sample-copy>{copyListBrafton[0]}</sample-copy>
                <sample-copy>{copyListBrafton[1]}</sample-copy>    
                ";
        var p2 = $@"Write a brief based on the sample copy below delimited by <sample-copy> tags.
                <sample-copy>{fluffyBunny[0]}</sample-copy>   
                ";
        var conversationHistory = await admin.InitiateChatAsync(groupChatManager, p2, maxRound: 25);

        // the last message is from admin, which is the termination message
        var lastMessage = conversationHistory.Last();
        lastMessage.From.Should().Be("admin");
        lastMessage.IsGroupChatTerminateMessage().Should().BeTrue();
        #endregion start_group_chat



    }
}


