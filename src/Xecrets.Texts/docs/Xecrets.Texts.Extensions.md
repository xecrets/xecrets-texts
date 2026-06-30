#### [Xecrets.Texts](index.md 'index')
### [Xecrets.Texts](Xecrets.Texts.md 'Xecrets.Texts')

## Extensions Class

Extensions and helpers for URL rewriting and string formatting used across Xecrets assemblies.

```csharp
public static class Extensions
```

Inheritance [System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System.Object') → Extensions
### Methods

<a name='Xecrets.Texts.Extensions.FormatUi(thisMicrosoft.Extensions.Localization.LocalizedString,object[])'></a>

## Extensions.FormatUi(this LocalizedString, object[]) Method

Formats a [Microsoft.Extensions.Localization.LocalizedString](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.localization.localizedstring 'Microsoft.Extensions.Localization.LocalizedString') using [System.Globalization.CultureInfo.CurrentCulture](https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.currentculture 'System.Globalization.CultureInfo.CurrentCulture').

```csharp
public static string FormatUi(this Microsoft.Extensions.Localization.LocalizedString format, params object[] args);
```
#### Parameters

<a name='Xecrets.Texts.Extensions.FormatUi(thisMicrosoft.Extensions.Localization.LocalizedString,object[]).format'></a>

`format` [Microsoft.Extensions.Localization.LocalizedString](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.localization.localizedstring 'Microsoft.Extensions.Localization.LocalizedString')

<a name='Xecrets.Texts.Extensions.FormatUi(thisMicrosoft.Extensions.Localization.LocalizedString,object[]).args'></a>

`args` [System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System.Object')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')

Format arguments passed to [System.String.Format(System.IFormatProvider,System.String,System.Object[])](https://learn.microsoft.com/en-us/dotnet/api/system.string.format#system-string-format(system-iformatprovider-system-string-system-object[]) 'System.String.Format(System.IFormatProvider,System.String,System.Object[])').

#### Returns
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System.String')  
The formatted string.

<a name='Xecrets.Texts.Extensions.MenuToLabelText(thisMicrosoft.Extensions.Localization.LocalizedString)'></a>

## Extensions.MenuToLabelText(this LocalizedString) Method

Strips accelerator underscores and trailing ellipsis from a localized menu label.

```csharp
public static string MenuToLabelText(this Microsoft.Extensions.Localization.LocalizedString menuText);
```
#### Parameters

<a name='Xecrets.Texts.Extensions.MenuToLabelText(thisMicrosoft.Extensions.Localization.LocalizedString).menuText'></a>

`menuText` [Microsoft.Extensions.Localization.LocalizedString](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.localization.localizedstring 'Microsoft.Extensions.Localization.LocalizedString')

The raw localized menu string.

#### Returns
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System.String')  
The cleaned label text.

<a name='Xecrets.Texts.Extensions.PluralFormatUi(thisMicrosoft.Extensions.Localization.LocalizedString,int,object[])'></a>

## Extensions.PluralFormatUi(this LocalizedString, int, object[]) Method

Formats a pipe-delimited plural [Microsoft.Extensions.Localization.LocalizedString](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.localization.localizedstring 'Microsoft.Extensions.Localization.LocalizedString') by selecting the segment matching [n](Xecrets.Texts.Extensions.md#Xecrets.Texts.Extensions.PluralFormatUi(thisMicrosoft.Extensions.Localization.LocalizedString,int,object[]).n 'Xecrets.Texts.Extensions.PluralFormatUi(this Microsoft.Extensions.Localization.LocalizedString, int, object[]).n')/>.

```csharp
public static string PluralFormatUi(this Microsoft.Extensions.Localization.LocalizedString format, int n, params object[] args);
```
#### Parameters

<a name='Xecrets.Texts.Extensions.PluralFormatUi(thisMicrosoft.Extensions.Localization.LocalizedString,int,object[]).format'></a>

`format` [Microsoft.Extensions.Localization.LocalizedString](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.localization.localizedstring 'Microsoft.Extensions.Localization.LocalizedString')

<a name='Xecrets.Texts.Extensions.PluralFormatUi(thisMicrosoft.Extensions.Localization.LocalizedString,int,object[]).n'></a>

`n` [System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System.Int32')

The count that selects the plural form. Negative values return an empty string.

<a name='Xecrets.Texts.Extensions.PluralFormatUi(thisMicrosoft.Extensions.Localization.LocalizedString,int,object[]).args'></a>

`args` [System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System.Object')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')

Additional format arguments.

#### Returns
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System.String')  
The formatted plural string, or [System.String.Empty](https://learn.microsoft.com/en-us/dotnet/api/system.string.empty 'System.String.Empty') when [n](Xecrets.Texts.Extensions.md#Xecrets.Texts.Extensions.PluralFormatUi(thisMicrosoft.Extensions.Localization.LocalizedString,int,object[]).n 'Xecrets.Texts.Extensions.PluralFormatUi(this Microsoft.Extensions.Localization.LocalizedString, int, object[]).n') is negative.