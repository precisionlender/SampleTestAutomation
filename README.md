# SampleTestAutomation
This repository contains 2 projects that are structured similar to our own internal test solution.
The projects also utilize the same packages we utilize: Selenium, SpecFlow, Boa.Constrictor.
The included sample feature file contains several scenarios that test behaviors on a [simple calculator site](https://www.theonlinecalculator.com/).


## Instructions
1. Install the latest stable ChromeDriver in `C:\WebDriver\bin` or update the path in `Hooks` to target your installation directory.
2. Install the VS SpecFlow plugin (links below).
3. Navigate to `Calculator.feature` and review the existing Gherkin steps and their step definitions (`CalculatorSteps.cs`).
4. Follow the instructions in the provided Test Automation Technical Screening.


## Documentation
[ChromeDriver](https://chromedriver.chromium.org/downloads)


[Selenium](https://www.selenium.dev/documentation/)

Selenium documentation will provide specifics regarding the usage of the WebDriver interface.
Don't worry about the WebDriver specifics. Boa Constrictor (below) handles all the WebDriver interactions you will need.


[SpecFlow](https://docs.specflow.org/projects/specflow/en/latest/)

[SpecFlow for Visual Studio 2019](https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio)

When working with the included projects, you will want to have the SpecFlow Visual Studio plugin installed.
If you are on VS2022, you should be able to find it on the extension marketplace.
(Note: Plugin for VS2022 is an early version, it includes a disclaimer regarding possible bugs)


[Gherkin Reference](https://docs.specflow.org/projects/specflow/en/latest/Gherkin/Gherkin-Reference.html)

The Gherkin reference site provides useful documentation regarding Gherking syntax.
Gherkin is English-y, meant to be shared between the stakeholders involved in producing software.
Not all of the stakeholders are developers, thus the language is readable and each line
is implemented in the background with C# (regex maps the C# methods to the Gherkin steps).


[Boa Constrictor](https://q2ebanking.github.io/boa-constrictor/)

Boa Constrictor is a C# implementation of the Screenplay Pattern.


[Automation Panda BDD Reference](https://automationpanda.com/bdd/)

Former team lead, Andy Knight, runs a blog dedicated to test automation.
This is a great starting point for a huge amount of helpful info on various BDD topics.


[Web Locators](https://automationpanda.com/2019/01/15/web-element-locators-for-test-automation/)

A reference for writing web locators.


## Contact
If you run into issues getting the solution to run feel free to email us:


[Jeff Wolf, Manager](mailto:jeff.wolf@Q2.com)

[Steve Hernandez, Senior SET](mailto:steve.hernandez@Q2.com)

[Sarah Watkins, SET](mailto:sarah.watkins@Q2.com)


## Tips
You may notice that the `Hooks` file contains an `AfterScenario` hook to quit the WebDriver.
WebDriver instances are somewhat notorious for sticking around and causing issues.
If you get stuck while debugging/running new tests locally, look for zombie instances leftover from past test runs (kill chromedriver.exe from Task Manager).

Powershell Hint:
`Get-Process chromedriver | Stop-Process`