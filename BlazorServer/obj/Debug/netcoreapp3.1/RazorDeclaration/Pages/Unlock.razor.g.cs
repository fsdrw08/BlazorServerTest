#pragma checksum "/workspaces/BlazorServerTest/BlazorServer/Pages/Unlock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6a880b97f8d026d085cbe3e7a88e18858f4a259"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/workspaces/BlazorServerTest/BlazorServer/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/workspaces/BlazorServerTest/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/workspaces/BlazorServerTest/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/workspaces/BlazorServerTest/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/workspaces/BlazorServerTest/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/workspaces/BlazorServerTest/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/workspaces/BlazorServerTest/BlazorServer/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/workspaces/BlazorServerTest/BlazorServer/_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/workspaces/BlazorServerTest/BlazorServer/_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/workspaces/BlazorServerTest/BlazorServer/Pages/Unlock.razor"
using BlazorServer.Data.UnlockAccount;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/workspaces/BlazorServerTest/BlazorServer/Pages/Unlock.razor"
using BlazorServer.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/unlock")]
    public partial class Unlock : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/workspaces/BlazorServerTest/BlazorServer/Pages/Unlock.razor"
       
    private Extra_vars extraVars = new Extra_vars{
        user = "",
    };

    private async void HandleValidSubmit()
    {
        await service.Unlock(extraVars);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApiService service { get; set; }
    }
}
#pragma warning restore 1591
