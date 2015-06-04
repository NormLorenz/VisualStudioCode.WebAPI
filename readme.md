## Synopsis

This is a Visual Studio Code (VSCode) WebAPI project using ASP.Net 5, MVC 6 and Entity Framework 7.

## Starting up the service

After starting the server using dnx:web (Microsoft.AspNet.Hosting) 

- [For example, call the values controller - all values](http://localhost:5000/api/values) 
- [For example, call the values controller - api/values/5](http://localhost:5000/api/values/1)

## Web API construction and camel casing 

- [Create a Web API in MVC 6](http://www.asp.net/vnext/overview/aspnet-vnext/create-a-web-api-with-mvc-6)
- [Migrating from Web API 2](http://docs.asp.net/en/latest/mvc/migration/migratingfromwebapi2.html)

## Entity framework

- [ASP.NET 5 and EF 7](http://www.dotnetcurry.com/showarticle.aspx?ID=1128)
- [A look at ASP.NET 5 ](http://wildermuth.com/2015/03/17/A_Look_at_ASP_NET_5_Part_3_-_EF7)
- [Getting started with ASP.NET 5](http://bitoftech.net/2014/11/18/getting-started-asp-net-5-mvc-6-web-api-entity-framework-7/)
- [ASP.NET 5 Entity Framework 7](http://stephenwalther.com/archive/2015/01/17/asp-net-5-and-angularjs-part-4-using-entity-framework-7)
- [EF7 in Traditional .NET Applications](https://github.com/aspnet/EntityFramework/wiki/Using-EF7-in-Traditional-.NET-Applications)
- [EF7 Migrations: DNX Commands](http://www.bricelam.net/2014/09/14/migrations-on-k.html)
- Initial migration steps

<pre><code>	dnu restore	
	cd src\MyProject	
	dnx . ef		
	dnx . ef migration add initialMigration	
	dnx . ef migration apply
</code></pre>

## Things to Do

- Fix the app.UseWelcomePage splash page - <font color='green'>done</font>
- Hook in the Entity Framework - <font color='green'>done</font>
- Initiate migrations - <font color='green'>done</font>
- Figure out how to seed the  database
- Create a Sales database with Products and Codes tables - <font color='green'>done</font>
- Figure out how to use the config.json instead of hardcoding the connection string
- Modify the ember project to call this web api
- Build out a CodeController 