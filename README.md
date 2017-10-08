# Understanding Unit testing #

## Language: C#

## Frameworks: Microsoft Unit Test Framework & Microsoft Fakes ##

## Approach: ## 
The different sessions for the training are divided as branches in this repo. The below tries to explain what is the purpose of each of the branch.

## Pre-requisites: ##
1. Install Visual Studio 
2. Install Microsoft Unit Test framework if not already installed
3. Install Git tools for Visual Studio
4. Install Git for Windows command line client (Optional)
5. Create a GitHub account (if not already created)
6. Fork this repo
7. Clone to your dev box and follow the instructions!

## Branch details: ##

### Basics: ###
1. UnitTestBasics1 : Starting of with unit tests - DLLs and how to reference the DLL under test
2. UnitTestBasics2 : Beyond the obvious cases - searching for extremes, red-refactor-green pattern
3. UnitTestBasicsDIY: **Do It Yourself** - Students will write the code to complete this exercise as per instructions. *TODO* statements in the code will identify what is to be performed.

### Scenario Based Example: ###
1. UnitTest3 : Explain the student class scenario. Data model discussion. Data source identification. Setting up basic unit tests and limitations in the current scenario due to external dependencies.
2. UnitTest4-Refactored : Dependency injection. Interfaces establishing contract for dependencies.
3. UnitTest4-BusinessLogicsAndClientLayerUpdated : Interaction between business layer and data layer via interfaces. Updates to the console client to inject the dependency.
4. UnitTest4-FactoryPattern : Introduce factory for the data store logics to relieve the client from instantiating data store objects.
5. UnitTest4-Fakes : Using Microsoft Fakes framework to isolate code under test. Purpose of the refactoring.
6. UnitTest4-DIY : **Do It Yourself** - Students will write the code to complete this exercise as per instructions. *TODO* statements in the code will identify what is to be performed. Integration with Azure Table storage will be performed and so an Azure account with usage credit is required to complete this exercise.
