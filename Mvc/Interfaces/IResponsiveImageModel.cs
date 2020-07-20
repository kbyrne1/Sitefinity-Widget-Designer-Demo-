using SitefinityWebApp.MVC.Models.ViewModels;
using System;

namespace SitefinityWebApp.MVC.Interfaces
{
    public interface IResponsiveImageModel
    {
        Guid DesktopImageId
        {
            get;
            set;
        }
        Guid MobileImageId
        {
            get;
            set;
        }
        string ImageProviderName
        {
            get;
            set;
        }
        ResponsiveImageViewModel ResponsiveImageModel { get; }
    }
}