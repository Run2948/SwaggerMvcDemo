# 使用Swagger生成API文档

## 1.[使用 Swagger UI 与 Swashbuckle 创建 RESTful Web API 帮助文件](https://www.jianshu.com/p/da47846421f8)
## 2.[RESTful Web API Help Documentation using Swagger UI and Swashbuckle](https://www.codeproject.com/Articles/1078249/RESTful-Web-API-Help-Documentation-using-Swagger-U)
## 3.[ASP.NET Web API 使用Swagger使用笔记](https://www.cnblogs.com/lhbshg/p/8711604.html)
## 4.[ASP.NET WebApi 文档Swagger中度优化](https://www.cnblogs.com/tdws/p/6100126.html)
## 5.[使用Swagger 搭建高可读性ASP.Net WebApi文档](https://www.cnblogs.com/xyb0226/p/9500633.html)

### 3.1 Adding Swashbuckle to our Web API

* 1.转到“管理NuGet包...”并在线搜索“Swashbuckle”。从列表中选择Richard Morris使用5.2.2版创建的“Swashbuckle  -  Swagger for Web API”，然后单击Install
* ![](https://www.codeproject.com/KB/aspnet/1078249/20.png) ![](https://www.codeproject.com/KB/aspnet/1078249/21.png)
* 2.这将在检查其依赖项之后向我们的项目添加对“Swashbuckle  -  Swagger for Web API”以及“Swashbuckle.Core  -  Swagger for Web API”的引用。同样会在packages.config文件中显示为..
``` xml
<package id="Swashbuckle" version="5.2.2" targetFramework="net45" />
<package id="Swashbuckle.Core" version="5.2.2" targetFramework="net45" />
```
* 3.安装成功后，我们看到App_Start文件夹中有一个新的“SwaggerConfig.cs”配置文件。这是我们设置所有Swagger相关配置的地方。
* ![](https://www.codeproject.com/KB/aspnet/1078249/22.png) 
* 为了直接链接到我们的Swagger API接口，以下所有操作都链接到“_Layout.cshtml”页面中的顶部导航。
``` xml
  <li>@Html.ActionLink("Swagger Help", "", "Swagger", new { area = "" }, null)</li>
```
* ![](https://www.codeproject.com/KB/aspnet/1078249/34.PNG)
* 4.现在构建并运行应用程序。从顶部导航单击“Swagger帮助”。它将把我们带到Swagger用户界面。命中列表操作以查看所有交互式操作操作及其相应的动词。
* ![](https://www.codeproject.com/KB/aspnet/1078249/23.png)
* 单击操作将向我们显示响应类。单击“试一试！”按钮将显示其他详细信息，如请求URL，响应正文，响应代码和响应标头。

### 3.2 To include XML comments in the help document

* 1.转到项目属性，在“构建”选项卡下，选择“输出”部分中的“XML文档文件：”复选框，您将看到保存文件的Bin文件夹中的XML路径。
* ![](https://www.codeproject.com/KB/aspnet/1078249/29.png)
* 2.现在打开Swagger Config文件，添加“IncludeXmlComments”语句，该函数返回bin文件夹中XML文件的路径。
``` c# 
private static string GetXmlCommentsPath()
{
    return String.Format(@"{0}\bin\SwaggerUi.XML", System.AppDomain.CurrentDomain.BaseDirectory);
}
```
* 3.这是SwaggerConfig.cs中静态方法启用全局配置的方法
``` c#
public static void Register()
{
    var thisAssembly = typeof(SwaggerConfig).Assembly;

    GlobalConfiguration.Configuration
        .EnableSwagger(c =>
        {
            c.SingleApiVersion("v1", "SwaggerUi");
            c.IncludeXmlComments(GetXmlCommentsPath());
        })
        .EnableSwaggerUi(c =>
        {
        });
}
```
* 4.要检查XML注释是否正在工作...编辑控制器获取方法，其中包含一些注释
* ![](https://www.codeproject.com/KB/aspnet/1078249/30.png)
* 运行应用程序并从顶部导航导航到Swagger帮助页面。您可以看到添加到Swagger帮助页面的xml注释。
* ![](https://www.codeproject.com/KB/aspnet/1078249/31.png)
* 5.更多配置，可查看链接1和2


# JWT 的ASP.NET WebApi身份验证
## 1.[jwt的ASP.NET MVC 身份验证](https://www.cnblogs.com/xiaobai123/p/9242828.html)
## 2.