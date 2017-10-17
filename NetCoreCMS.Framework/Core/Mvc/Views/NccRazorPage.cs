﻿using System;
using System.IO;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using NetCoreCMS.Framework.Core.Events.Theme;
using MediatR;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace NetCoreCMS.Framework.Core.Mvc.Views
{
    public abstract class NccRazorPage<TModel> : RazorPage<TModel>
    {
        public string Title {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_TITLE", out val);                
                return (string)val??"";
            }
            set{
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_TITLE"] = value;
            }
        }
        public string SubTitle
        {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_SUB_TITLE", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_SUB_TITLE"] = value;
            }
        }
        public string SiteName
        {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_SITE_NAME", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_SITE_NAME"] = value;
            }
        }
        public string SiteSlogan
        {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_SITE_SLOGAN", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_SITE_SLOGAN"] = value;
            }
        }
        public string SiteLogo
        {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_SITE_LOGO", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_SITELOGO"] = value;
            }
        }
        public string Favicon
        {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_FAVICON", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_FAVICON"] = value;
            }
        }
        public string CurrentLayout {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_CURRENT_LAYOUT", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_CURRENT_LAYOUT"] = value;
            }
        }
        public string CurrentLanguage {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_CURRENT_LANGUAGE", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_CURRENT_LANGUAGE"] = value;
            }
        }
        public bool HasLeftColumn {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_HAS_LEFT_COLUMN", out val);
                return val == null ? false : (bool)val;
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_HAS_LEFT_COLUMN"] = value;
            }
        }
        public float LeftColumnWidth
        {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_LEFT_COLUMN_WIDTH", out val);
                return val == null ? 0 : (float)val;
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_LEFT_COLUMN_WIDTH"] = value;
            }
        }
        public bool HasRightColumn {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_HAS_RIGHT_COLUMN", out val);
                return val == null ? false : (bool)val;
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_HAS_RIGHT_COLUMN"] = value;
            }
        }
        public float RightColumnWidth
        {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_RIGHT_COLUMN_WIDTH", out val);
                return val == null ? 0 : (float)val;
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_RIGHT_COLUMN_WIDTH"] = value;
            }
        }
        public float BodyWidth {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_BODY_WIDTH", out val);
                return val == null ? 0 : (float)val;
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_BODY_WIDTH"] = value;
            }
        }
        public bool HasFooter
        {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_HAS_FOOTER", out val);
                return val == null ? false : (bool)val;
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_HAS_FOOTER"] = value;
            }
        }
        public string Breadcrumb
        {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_BREADCRUMB", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_LEFT_COLUMN_BREADCRUMB"] = value;
            }
        }
        public string MetaDescription
        {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_META_DESCRIPTION", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_META_DESCRIPTION"] = value;
            }
        }
        public string MetaKeyword {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_META_KEYWORD", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_META_KEYWORD"] = value;
            }
        }
        public string MetaAuthor {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_META_AUTHOR", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_META_AUTHOR"] = value;
            }
        }
        public string MetaGenerator {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_META_GENERATOR", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_META_GENERATOR"] = value;
            }
        }
        public string MetaApplicationName {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_META_APPLICATION_NAME", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_META_APPLICATION_NAME"] = value;
            }
        }
        public string Copyright {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_COPY_RIGHT", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_COPY_RIGHT"] = value;
            }
        }
        public string PoweredBy {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_POWERED_BY", out val);
                return (string)val??"";
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_POWERED_BY"] = value;
            }
        }

        private IMediator _mediator;

        public Dictionary<string,object> PageProperty {
            get
            {
                object val;
                Context.Items.TryGetValue("NCC_RAZOR_PAGE_PROPERTY_DICTIONARY", out val);
                if (val == null)
                {
                    val = new Dictionary<string, object>();
                    PageProperty = (Dictionary<string, object>)val;
                }   
                return (Dictionary<string, object>)val;
            }
            set
            {
                Context.Items["NCC_RAZOR_PAGE_PROPERTY_DICTIONARY"] = value;
            }
        }

        public void SetProperty(string key, object value)
        {
            var property = PageProperty;
            if (property.ContainsKey(key))
            {
                property[key] = value;
            }
            else
            {
                property.Add(key, value);
            }
            PageProperty = property;
        }

        public object GetProperty(string key)
        {
            var property = PageProperty;
            if (property.ContainsKey(key))
            {
                return property[key];
            }
            else
            {
                return null;
            }            
        }

        private ThemeSection FireEvent(string name, string headViewFile, string content, TModel model)
        {
            var themeSection = new ThemeSection()
            {
                Name = name,
                Content = content,
                Model = Model,
                ViewFileName = headViewFile
            };
            if(_mediator == null)
            {
                _mediator = (IMediator) ViewContext.HttpContext.RequestServices.GetService(typeof(IMediator));
            }
            themeSection = _mediator.Send(new OnThemeSectionRender(themeSection)).Result;
            return themeSection;
        }

        public async Task<string> RenderToStringAsync(string viewName, object model)
        {
            var ac = new ActionContext(Context, ViewContext.RouteData, ViewContext.ActionDescriptor);
            var actionContext = new ControllerContext(ac);
            var razorViewEngine = (IRazorViewEngine) Context.RequestServices.GetService(typeof(IRazorViewEngine));
            var viewResult = razorViewEngine.FindView(actionContext, viewName, false);

            if (viewResult.View == null)
            {
                throw new ArgumentNullException($"{viewName} does not match any available view");
            }

            var viewContent = "";
            using (var sw = new StringWriter())
            {
                var viewContext = new ViewContext(
                    actionContext,
                    viewResult.View,
                    ViewData,
                    TempData,
                    sw,
                    new HtmlHelperOptions()
                );
                viewContext.RouteData = ViewContext.RouteData;
                await viewResult.View.RenderAsync(viewContext);
                viewContent = sw.GetStringBuilder().ToString();
            }
            
            return viewContent;
        }

        public string NccRenderPertial(string partialViewFileName, object model)
        {
            var content = RenderToStringAsync(partialViewFileName, model).Result;
            var themeSection = FireEvent(ThemeSection.Sections.PartialView, partialViewFileName, content, Model);
            content = themeSection.Content;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        }

        public string NccRenderHead(string headViewFile = "Parts/_Head")
        {
            var content = RenderToStringAsync(headViewFile, Model).Result;
            var themeSection = FireEvent(ThemeSection.Sections.Head,headViewFile, content, Model);
            content = themeSection.Content;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        } 

        public string NccRenderHeaderCss(string headCssViewFile = "Parts/_HeaderCss")
        {
            var content = RenderToStringAsync(headCssViewFile, Model).Result;
            var themeSection = FireEvent(ThemeSection.Sections.HeaderCss, headCssViewFile, content, Model);
            content = themeSection.Content;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        }

        public string NccRenderHeaderScripts(string headCssViewFile = "Parts/_HeaderScripts")
        {
            var content = RenderToStringAsync(headCssViewFile, Model).Result;
            var themeSection = FireEvent(ThemeSection.Sections.HeaderScripts, headCssViewFile, content, Model);
            content = themeSection.Content;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        } 

        public string NccRenderHeader(string headerViewFile = "Parts/_Header")
        {
            var content =  RenderToStringAsync(headerViewFile, Model).Result;
            var themeSection = FireEvent(ThemeSection.Sections.Header, headerViewFile, content, Model);
            content = themeSection.Content;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        }

        public string NccRenderNavigation(string navigationViewFile = "Parts/_Navigation")
        {
            var content = RenderToStringAsync(navigationViewFile, Model).Result;
            var themeSection = FireEvent(ThemeSection.Sections.Navigation, navigationViewFile, content, Model);
            content = themeSection.Content;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        }

        public string NccRenderFeaturedSection(string featuredViewFile = "Parts/_Featured")
        {
            var content = RenderToStringAsync(featuredViewFile, Model).Result;
            var themeSection = FireEvent(ThemeSection.Sections.Featured, featuredViewFile, content, Model);
            content = themeSection.Content;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        }

        public string NccRenderLeftColumn(string leftColumnViewFile = "Parts/_LeftColumn")
        {
            var content = RenderToStringAsync(leftColumnViewFile, Model).Result;
            var themeSection = FireEvent(ThemeSection.Sections.LeftColumn, leftColumnViewFile, content, Model);
            content = themeSection.Content;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        }
        
        public IHtmlContent NccRenderBody()
        {
            var bodyBuff = (ViewBuffer)RenderBody();
            var content = "";
            using(var sw = new StringWriter())
            {
                bodyBuff.WriteTo(sw, HtmlEncoder);
                content = sw.GetStringBuilder().ToString();
            }            
            var themeSection = FireEvent(ThemeSection.Sections.Body, ViewContext.View.Path, content, Model);
            bodyBuff.Clear();
            bodyBuff.SetHtmlContent(themeSection.Content);
            return bodyBuff;
        }

        public string NccRenderRightColumn(string rightColumnViewFile = "Parts/_RightColumn")
        {
            var content = RenderToStringAsync(rightColumnViewFile, Model).Result;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        }

        public string NccRenderFooter(string footerViewFile = "Parts/_Footer")
        {
            var content = RenderToStringAsync(footerViewFile, Model).Result;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        }

        public string NccRenderFooterCss(string footerCssViewFile = "Parts/_FooterCss")
        {
            var content = RenderToStringAsync(footerCssViewFile, Model).Result;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        }

        public string NccRenderFooterScripts(string footerScriptsViewFile = "Parts/_FooterScripts")
        {
            var content = RenderToStringAsync(footerScriptsViewFile, Model).Result;
            ViewContext.Writer.WriteLine(content);
            return string.Empty;
        }

        public string NccRenderLoadingMaskContainer()
        {
            var loadingMaskDiv = "<div id=\"loadingMask\" class=\"loader loader - double\"></div>";
            ViewContext.Writer.WriteLine(loadingMaskDiv);
            return string.Empty;
        }

        public string NccRenderGlobalMessageContainer()
        {
            var globalMessageContainer = "<div id=\"globalMessageContainer\" class=\"ncc-global-message\"></div>";
            ViewContext.Writer.WriteLine(globalMessageContainer);
            return string.Empty;            
        }
    }
}
