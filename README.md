# super-duper-engine
A simple Test, using C#, xUnit, and Selenium.

## Requirements ##

**Title:**

Convert Fahrenheit to Celsius for Cooking Recipes

**As a:**

Brazilian amateur cook

**I want to:**

Convert Fahrenheit temperatures to Celsius

**So that:**

I can accurately follow NY Times Cooking recipes using my oven and thermometer which are in Celsius

**Description:**

Maria, a Brazilian amateur cook, enjoys trying out new recipes from the NY Times Cooking website. However, she often finds herself confused when it comes to temperature settings, as the recipes are in Fahrenheit and her kitchen appliances use Celsius. She needs a simple and reliable way to convert Fahrenheit temperatures to Celsius so she can follow the recipes accurately without the hassle of manual calculations.

**Acceptance Criteria:**

1.	Input Field for Fahrenheit:
-	Maria can enter the temperature in Fahrenheit into an input field.
2.	Convert Button:
-	After entering the temperature, Maria can click a “Convert” button to trigger the conversion.
3.	Output Field for Celsius:
-	The converted temperature in Celsius is displayed in an output field.
4.	Accurate Conversion Formula:
-	The conversion uses the correct formula: $Celsius = \frac{(Fahrenheit - 32) \times 5}{9}$
5.	User-Friendly Interface:
-	The interface is simple and intuitive, allowing Maria to perform conversions quickly and easily while cooking.

**Example Scenario:**

Maria, a Brazilian amateur cook, enjoys trying out new recipes from the NY Times Cooking website. However, she often finds herself confused when it comes to temperature settings, as the recipes are in Fahrenheit and her kitchen appliances use Celsius. She needs a simple and reliable way to convert Fahrenheit temperatures to Celsius instantly as she types the Fahrenheit value, so she can follow the recipes accurately without the hassle of manual calculations.

**Mockup of User Interface:**

```
+-------------------------------------------+
|                                           |
|    Fahrenheit to Celsius Converter        |
|                                           |
|    Enter Temperature in Fahrenheit:       |
|    [          350           ]             |
|                                           |
|    Temperature in Celsius:                |
|    [         176.67         ]             |
|                                           |
+-------------------------------------------+
```
OR
![1](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/masmangan/uml-activity-object-flow/main/figure-15-01.puml)

## Test Plan for Temperature Conversion Project ##

### 1. Introduction ##

The objective of this test plan is to ensure that the temperature conversion application functions correctly and meets the end-user’s needs. This plan will be executed whenever there is a new release or when a user reports a bug. The focus of the test will be to verify the accuracy of the temperature conversions from Fahrenheit to Celsius and ensure that the user interface is intuitive and responsive.

### 2. Scope and Objectives ### 

2.1 Scope

	•	Test the functionality of temperature conversion.
	•	Verify the accuracy of conversions.
	•	Ensure the user interface responds correctly to inputs.
	•	Test the application on different browsers and devices.
	•	Retest the application upon new releases or reported bugs.

2.2 Objectives

	•	Ensure that conversions from Fahrenheit to Celsius are accurate.
	•	Ensure the application responds instantly to user inputs.
	•	Verify the application’s compatibility with different browsers and devices.
	•	Identify and fix any bugs or usability issues.
	•	Validate fixes and improvements after a new release or bug fix.

