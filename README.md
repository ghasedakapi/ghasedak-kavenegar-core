# Ghasedak Kavenegar Dot Net Standard Client
A cross-platform library for the ghasedak sms web service; written in C#.
.Net Standard migration library from Kavenegar to Ghasedak

## Installation
The package can be installed via [nuget](https://www.nuget.org/packages/Ghasedak.Kavenegar.Core/1.0.1):

##### Nuget Package Manager
```
Install-Package Ghasedak.Kavenegar.Core -Version 1.0.1
```
##### .NET CLI
```
dotnet add package Ghasedak.Kavenegar.Core --version 1.0.1
```

## Usage
Send SMS Example:

```c#
Console.OutputEncoding = Encoding.UTF8;
try
{
	var receptors = new List<string> { "<ReceptorNumber>" };

	var api = new KavenegarApi("<ApiKey>");

	var result = await api.Send("<SenderNumber>", receptors, "<Message>");

	foreach (var r in result)
	{
		Console.Write($"{r.Messageid.ToString()}");
	}

}
catch (ApiException ex)
{
	// در صورتی که خروجی وب سرویس 200 نباشد این خطارخ می دهد.
	Console.Write("Message : " + ex.Message);
}
catch (HttpException ex)
{
	// در زمانی که مشکلی در برقرای ارتباط با وب سرویس وجود داشته باشد این خطا رخ می دهد
	Console.Write("Message : " + ex.Message);
}
```





<hr>
<div dir='rtl'>
	
## راهنما

### معرفی سرویس پیام کوتاه قاصدک

قاصدک یک وب سرویس ارسال و دریافت پیامک و تماس صوتی است که به راحتی میتوانید از آن استفاده نمایید.

### مستندات

برای مشاهده اطلاعات کامل مستندات  به صفحه [مستندات وب سرویس](https://ghasedak.me/developers) مراجعه نمایید.
 
### اطالاعات بیشتر
برای مطالعه بیشتر به صفحه 
[مهاجرت از کاوه نگار به قاصدک](https://ghasedak.me/kavenegar)
مراجعه نمایید .


##
![https://ghasedak.me](https://ghasedak.me/img/logo.png)		

[https://ghasedak.me](https://ghasedak.me)	

</div>



