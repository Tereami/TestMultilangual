#Multilangual WindowsForms Revit plugin

The sample of multilangual Revit plugin using WindowsForms, resx-files and the Form's property "Localizable".


To launch Revit with you desirable language write the key in the shortcut's properties:
"C:\Program Files\Autodesk\Revit 2021\Revit.exe" /language FRA

Then you need to create resources files for each language. The name of file must contains the code of the culture.
Here are all the keys and codes:

|LanguageType|.resx|Shortcut Key|
|-|-|-|
|English_USA|en-US|ENU|
|German|de-DE|DEU|
|Spanish|es-ES|ESP|
|French|fr-FR|FRA|
|Italian|it-IT|ITA|
|Chinese_Simplified|zh-CHS|CHS|
|Chinese_Traditional|zh-CHT|CHT|
|Japanese|ja-JP|JPN|
|Korean|ko-KR|KOR|
|Russian|ru-RU|RUS|
|Czech|cs-CZ|CSY|
|Polish|pl-PL|PLK|
|Brazilian_Portuguese|pt-BR|PTB|

Resources files for form's content are created automatically.
You only need to set "Localizable - True" in form's properties.
Fill all the content on the form with English texts.
Then set "Language - Russian (Russia)" and fill the contents with russian language.
WARNING: do not use "Language - Russian"! It mean that it will not match with Revit's language.
The name of resx-file must looks like "Form1.ru-RU.resx" as like as in the table above.
Then you can change "Language" in the same time with programming and check how it looks like.

You also need to show some messages or create button on Revit's ribbon.
In this way you need to create resources files manually.
Just create file MyStrings.resx and fill it in with key of phrases and values in English.
Set "Access modifier - Internal" for this file.
Then replace all the texts in your code with this:
*TaskDialog.Show(MyString.Title, MyString.Message + doc.Title)*
Then copy this file and set name MyStrings.ru-Ru.resx.
Set "Access modifier - No". 
And replace all the values with russian values.
Please be careful the code in the name of the file have to match the table above.

As you know the program wiil chose the relevant Resouces baes on a thread's Culture,
but the Culture of Revit's process may not match the language of Revit's interface.
But as I noticed it's unushual situation.
The property "CurrentUICulture" usually matches the Revit's language.
And if you are trying to get your plugin's Thread and set the Culture
it will be applied fot the entire Revit process too because plugins work in the same thread with Revit.
Maybe it will be useful to set the desirable Culture for the entire Thread in the beginning of your code,
but the outcome may be unpredictable.
If you need to check the current revit's language use this:
*LanguageType lang = application.ControlledApplication.Language;*

Enjoy!