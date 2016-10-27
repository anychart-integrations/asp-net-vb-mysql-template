[<img src="https://cdn.anychart.com/images/logo-transparent-segoe.png?2" width="234px" alt="AnyChart - Robust JavaScript/HTML5 Chart library for any project">](https://anychart.com)
ASP.NET VB.NET basic template
=========================

This example shows how to use Anychart library with the Visual Basic .NET programming language using ASP.NET and MySQL database.

## Running
This example uses .NET framework 4.6.1, ASP.NET 4.0.30319, ASP.NET MVC 5.2, Visual Studio 2015 Community, MySQL 5.6 and MySQL Connector/NET 6.9.9.0 - ADO.NET driver for MySQL. 
To check your installations, please, use Windows Control Panel -> Programs and features.
If you miss some installations, please, visit:<br />
https://dev.mysql.com/downloads/installer/ and http://dev.mysql.com/doc/refman/5.7/en/installing.html to install MySQL<br />
https://www.visualstudio.com/downloads/ to install Visual Studio, .NET framework and ASP.NET <br />
https://dev.mysql.com/downloads/connector/net/6.9.html to install MySQL Connector/NET<br />

To start this example run commands listed below.

Clone the repository from github.com to your working directory:
```
$ git clone git@github.com:anychart-integrations/asp-net-vb-mysql-template.git
```

Open cmd console in 'asp-net-vb-mysql-template' folder and set up MySQL database, use -u -p flags to provide username and password:
```
$  "[YOUR_PATH_TO_MYSQL]\bin\mysql.exe" < database_backup.sql
e.g:  
$  "C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql.exe" -uroot -ppassword < database_backup.sql
```

Open project in Visual Studio using AspNetVBMysqlTemplate.sln solution file

Run application using Run button or press F5

If you have some problems with MySQL connection, ensure that MySql.Data.Entity.EF6 in References has correct path to MySql.Data.Entity.EF6.dll

## Workspace
Your workspace should look like:
```
AspNetVBMysqlTemplate/
    App_Start/
		RouteConfig.vb			# app routes
	Controllers/
		ChartController.vb		# main controller
    css/
		style.css				# main css file
    Models/
		fruit.vb				# Entity framework model for MySQL
		FruitDBContext.vb		# DB data provider
	Views/
		Chart/
			Index.vbhtml		# html template
		web.config
	Global.asax
	packages.config
	Web.config					# main ASP.NET project settings
```

## Technologies
Language - [VB.NET](https://msdn.microsoft.com/en-us/library/aa903378(v=vs.71).aspx)<br />
Web framework - [ASP.NET](https://www.asp.net)<br />
Database Mapping - [Entity Framework](https://www.asp.net/entity-framework)<br />
HTML Tepmlate - [Razor](https://www.asp.net/web-pages/overview/getting-started/introducing-razor-syntax-c)<br />
Database - [MySQL](https://www.mysql.com/)<br />

## Further Learning
* [Documentation](https://docs.anychart.com)
* [JavaScript API Reference](https://api.anychart.com)
* [Code Playground](https://playground.anychart.com)
* [Technical Support](https://anychart.com/support)

## License
[© AnyChart.com - JavaScript charts](http://www.anychart.com). Released under the [Apache 2.0 License](https://github.com/anychart-integrations/asp-net-vb-mysql-template/blob/master/LICENSE).
