﻿using MediatR;
using NetCoreCMS.Framework.Core.Events.Theme;

namespace NetCoreCMS.HelloWorld.Hooks
{
    public class OnSectionRenderHandler : IRequestHandler<OnThemeSectionRender, ThemeSection>
    {    
        public ThemeSection Handle(OnThemeSectionRender message)
        {
            if(message.Data.Name == ThemeSection.Sections.Head)
            {
                message.Data.Content = "<meta name=\"Framework\" content=\"NetCoreCMS\" />" + message.Data.Content;
            }
            if (message.Data.Name == ThemeSection.Sections.Body)
            {
                message.Data.Content = "--- Hook on body content start from hallo world module" + message.Data.Content + "Hook on body content ends -----<br/> ViewFile: " + message.Data.ViewFileName;
            }
            return message.Data;
        }     
    }
}
