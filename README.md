E5R.AspNet.WebApi.Owin
======================

Microsoft.AspNet.WebApi.Owin Skeleton

```xml
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <webapiOnly>
    <spec>
      <dependency id="Microsoft.AspNet.WebApi" version="5.2.0" />
      <dependency id="Microsoft.AspNet.WebApi.Owin" version="5.2.0" />
    </spec>
    <install>
      <package id="Microsoft.AspNet.WebApi" version="5.2.0" targetFramework="net45" />
      <package id="Microsoft.AspNet.WebApi.Client" version="5.2.0" targetFramework="net45" />
      <package id="Microsoft.AspNet.WebApi.Core" version="5.2.0" targetFramework="net45" />
      <package id="Microsoft.AspNet.WebApi.Owin" version="5.2.0" targetFramework="net45" />
      <package id="Microsoft.AspNet.WebApi.WebHost" version="5.2.0" targetFramework="net45" />
      <package id="Microsoft.Owin" version="2.1.0" targetFramework="net45" />
      <package id="Newtonsoft.Json" version="4.5.11" targetFramework="net45" />
      <package id="Owin" version="1.0" targetFramework="net45" />
    </install>
  </webapiOnly>
  <webapiWithMvc>
    <spec>
      <dependency id="Microsoft.AspNet.Mvc" version="5.2.0" />
    </spec>
    <install>
      <package id="Microsoft.AspNet.Mvc" version="5.2.0" targetFramework="net45" />
      <package id="Microsoft.AspNet.Razor" version="3.2.0" targetFramework="net45" />
      <package id="Microsoft.Web.Infrastructure" version="1.0.0.0" targetFramework="net45" />
      <package id="Microsoft.AspNet.WebPages" version="3.2.0" targetFramework="net45" />
    </install>
  </webapiWithMvc>
  
  <webapiOnlySelfHost>
    <todo />
  </webapiOnlySelfHost>
  
  <webapiOnlySystemWeb>
    <todo />
  </webapiOnlySystemWeb>
  
  <webapiWithMvcSelfHost>
    <todo />
  <webapiWithMvcSelfHost>
  
  <webapiWithMvcSystemWeb>
    <package id="Microsoft.Owin.Host.SystemWeb" version="2.1.0" targetFramework="net45" />
    <framework id="System.Web" version="todo" />
  <webapiWithMvcSystemWeb>
</packages>
```