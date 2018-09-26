# ʹ��Swagger����API�ĵ�

## 1.[ʹ�� Swagger UI �� Swashbuckle ���� RESTful Web API �����ļ�](https://www.jianshu.com/p/da47846421f8)
## 2.[RESTful Web API Help Documentation using Swagger UI and Swashbuckle](https://www.codeproject.com/Articles/1078249/RESTful-Web-API-Help-Documentation-using-Swagger-U)
## 3.[ASP.NET Web API ʹ��Swaggerʹ�ñʼ�](https://www.cnblogs.com/lhbshg/p/8711604.html)
## 4.[ASP.NET WebApi �ĵ�Swagger�ж��Ż�](https://www.cnblogs.com/tdws/p/6100126.html)
## 5.[ʹ��Swagger ��߿ɶ���ASP.Net WebApi�ĵ�](https://www.cnblogs.com/xyb0226/p/9500633.html)

### 3.1 Adding Swashbuckle to our Web API

* 1.ת��������NuGet��...��������������Swashbuckle�������б���ѡ��Richard Morrisʹ��5.2.2�洴���ġ�Swashbuckle  -  Swagger for Web API����Ȼ�󵥻�Install
* ![](https://www.codeproject.com/KB/aspnet/1078249/20.png) ![](https://www.codeproject.com/KB/aspnet/1078249/21.png)
* 2.�⽫�ڼ����������֮�������ǵ���Ŀ��Ӷԡ�Swashbuckle  -  Swagger for Web API���Լ���Swashbuckle.Core  -  Swagger for Web API�������á�ͬ������packages.config�ļ�����ʾΪ..
``` xml
<package id="Swashbuckle" version="5.2.2" targetFramework="net45" />
<package id="Swashbuckle.Core" version="5.2.2" targetFramework="net45" />
```
* 3.��װ�ɹ������ǿ���App_Start�ļ�������һ���µġ�SwaggerConfig.cs�������ļ�������������������Swagger������õĵط���
* ![](https://www.codeproject.com/KB/aspnet/1078249/22.png) 
* Ϊ��ֱ�����ӵ����ǵ�Swagger API�ӿڣ��������в��������ӵ���_Layout.cshtml��ҳ���еĶ���������
``` xml
  <li>@Html.ActionLink("Swagger Help", "", "Swagger", new { area = "" }, null)</li>
```
* ![](https://www.codeproject.com/KB/aspnet/1078249/34.PNG)
* 4.���ڹ���������Ӧ�ó��򡣴Ӷ�������������Swagger�����������������Ǵ���Swagger�û����档�����б�����Բ鿴���н���ʽ��������������Ӧ�Ķ��ʡ�
* ![](https://www.codeproject.com/KB/aspnet/1078249/23.png)
* ������������������ʾ��Ӧ�ࡣ��������һ�ԣ�����ť����ʾ������ϸ��Ϣ��������URL����Ӧ���ģ���Ӧ�������Ӧ��ͷ��

### 3.2 To include XML comments in the help document

* 1.ת����Ŀ���ԣ��ڡ�������ѡ��£�ѡ������������еġ�XML�ĵ��ļ�������ѡ���������������ļ���Bin�ļ����е�XML·����
* ![](https://www.codeproject.com/KB/aspnet/1078249/29.png)
* 2.���ڴ�Swagger Config�ļ�����ӡ�IncludeXmlComments����䣬�ú�������bin�ļ�����XML�ļ���·����
``` c# 
private static string GetXmlCommentsPath()
{
    return String.Format(@"{0}\bin\SwaggerUi.XML", System.AppDomain.CurrentDomain.BaseDirectory);
}
```
* 3.����SwaggerConfig.cs�о�̬��������ȫ�����õķ���
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
* 4.Ҫ���XMLע���Ƿ����ڹ���...�༭��������ȡ���������а���һЩע��
* ![](https://www.codeproject.com/KB/aspnet/1078249/30.png)
* ����Ӧ�ó��򲢴Ӷ�������������Swagger����ҳ�档�����Կ�����ӵ�Swagger����ҳ���xmlע�͡�
* ![](https://www.codeproject.com/KB/aspnet/1078249/31.png)
* 5.�������ã��ɲ鿴����1��2


# JWT ��ASP.NET WebApi�����֤
## 1.[jwt��ASP.NET MVC �����֤](https://www.cnblogs.com/xiaobai123/p/9242828.html)
## 2.