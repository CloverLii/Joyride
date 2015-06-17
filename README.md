
![](https://raw.githubusercontent.com/glorylo/Joyride/develop/Assets/images/icon_joyride.png)


# Motivation

You have the same mobile application across ios and android.  You want to write automated acceptance tests and ensure feature parity between the two.  With Joyride you can write near identical specs for both apps sharing much of the underlying code,   

You can also leverage shared code between the two test suites.  The typical use cases include sharing business models, user profiles, and so on thereby simplifying much of the duplicated work had you worked with two separate projects.  

Joyride attempts to supply much of the boilerplate code with "good defaults" to get you quickly started.  

Get excited and jump start you automation efforts!  

# Overview

Joyride follows the same tried-and-true "pageobjects" pattern adopted for mobile.  It supplies basic touch gestures in interacting with native and hybrid mobile applications.  This is built on top of [Appium](http://appium.io). 

Combined with Joyride.Specflow, the Behaviour Driven Development (BDD) binding layer, your human readable specs fully come to life with the use of gherkin syntax.  Joyride.Specflow also supplies a stock of useful steps for common actions and gestures (swipe, scroll, tap, etc).

You can then overlay any screen with application specific features via interfaces.  For example, you have an android and ios app, and you have a login screen.  You create a shared interface called ILogin like so:

```csharp
    public interface ILogin
    {
        Screen LoginAs(string name, string password);
    }
```   

You then create an *LoginScreen* for both andriod and ios implementing the *ILogin* interface.  Create a custom step that binds to use the method to this interface like so:

```csharp
        [Given(@"I login as user ""([^""]*)"" with password ""([^""]*)"")]
        [When(@"I login as user ""([^""]*)"" with password ""([^""]*)"")]
        public void GivenILogin(string username, string password)
        {
            Context.MobileApp.Do<ILogin>(i => i.LoginAs(username, password));
        }
```

Your specs for Android look like so:
```gherkin
Scenario: Should Login in successfully 
Given I launch the "My Cool Android App" mobile application
And I login as user "tommy" with password "secret"
...
  
```

Your specs for iOS look like so:

```gherkin
Scenario: Should Login in successfully 
Given I launch the "My Cool iOS App" mobile application
And I login as user "tommy" with password "secret"
...
  
```

# Features

Here are some of the features included with Joyride

- Built-in starter configuration to quickly get you up and running.
- Support for mostly native actions for ios and android.  Currently hybrid apps have limited support thus far.
- Handling of collection of elements
- Smart element and collection mappings
- Predefined steps for interacting with different widgets such as checkboxes, entering text, etc.
- Handling of modal dialogs
- Detection of modal dialogs and screens
- Predefined debugging steps 
- Predefined gestures steps
- Screen captures on error
- ios and android specific steps.  For example, android has a "back" button.
- And more...

# Examples 



Add the appropriate tag to add platform specific steps

```gherkin
# Comment out and add the appropriate tag for your platform
# @android or @ios
Feature: My First Feature
	In order to do usercase on my app
	As a user
	I want to be do X
```

Here are some examples of the specifications you can write, all using Joyride's predefined steps:

```gherkin
Scenario: Should be able to tap the item by index in a collection
Given I tap the "App" button
And I tap the "Fragment" button
And I tap the "Context Menu" button
And I tap the "Long Press" button and hold for "4" seconds
When I tap the "2nd" item in the "Menu" collection
Then I should be on the "Context Menu" screen
```

```gherkin
Scenario: Should see title containing text in modal dialog
Given I tap the "App" button
And I tap the "Alert Dialogs" button
When I tap the "Ok Cancel Dialog" button
Then I should see the "Lorem Ipsum" modal dialog containing title text "Plloaso mako nuto siwuf"

```

```gherkin
Scenario: Should be able to double tap 
Given I tap the "Animation" button
And I tap the "Default Layout Animations" button
When I double tap the "Add Button" button
Then I should see "2" items in "Buttons" collection
```

See a listing of the [Predefined Steps](https://github.com/glorylo/Joyride/blob/develop/docs/PredefinedSteps.md)

# Installation

You can install the packages via nuget's Package Manager Console

```
PM> Install-Package Joyride
PM> Install-Package Joyride.Specflow
```

### Current Versions

Joyride:  ![#](https://img.shields.io/nuget/v/Joyride.svg?style=flat)</div><br/>
Joyride.Specflow:  ![#](https://img.shields.io/nuget/v/Joyride.Specflow.svg?style=flat)</div><br/>

### Dependencies

* Humanizer
* PredicateParser
* HandyConfig
* Appium.WebDriver
* Selenium.WebDriver
* Selenium.Support
* Newtonsoft.Json
* NUnit
* SpecFlow
* SpecFlow.NUnit



# Resources

- [Getting Started](https://github.com/glorylo/Joyride/blob/develop/docs/GettingStarted.md)
- [Creating Your First Screen](https://github.com/glorylo/Joyride/blob/develop/docs/CreatingYourFirstScreen.md)
- [Predefined Steps](https://github.com/glorylo/Joyride/blob/develop/docs/PredefinedSteps.md)
- [Ios Predefined Steps](https://github.com/glorylo/Joyride/blob/develop/docs/IosPredefinedSteps.md)
- [Android Predefined Steps](https://github.com/glorylo/Joyride/blob/develop/docs/AndroidPredefinedSteps.md)
- [Webview Predefined Steps](https://github.com/glorylo/Joyride/blob/develop/docs/WebviewPredefinedSteps.md)
- [Element And Collection Mappings](https://github.com/glorylo/Joyride/blob/develop/docs/ElementAndCollectionMappings.md)
- [Handling Modal Dialogs](https://github.com/glorylo/Joyride/blob/develop/docs/HandlingModalDialogs.md)
- [Gestures](https://github.com/glorylo/Joyride/blob/develop/docs/Gestures.md)
- [Creating Shared Custom Steps](https://github.com/glorylo/Joyride/blob/develop/docs/CreatingSharedCustomSteps.md)

# License

Joyride uses the BSD License.



Have fun! 

Glory