using SitefinityWebApp.Code;
using System;
using Telerik.Sitefinity.Libraries.Model;

namespace SitefinityWebApp.MVC.Models.ViewModels
{
    public class ResponsiveImageViewModel
    {
        public ResponsiveImageViewModel(Guid desktopImageId, Guid mobileImageId, string imageProviderName)
        {
            if (desktopImageId != Guid.Empty)
            {
                Image desktopImage = ImageHelper.GetImage(desktopImageId, imageProviderName);
                if (desktopImage != null)
                {
                    this.DesktopImageUrl = ImageHelper.GetImageUrl(desktopImage);
                    this.ImageAlternativeText = desktopImage.AlternativeText;
                    this.ImageTitle = desktopImage.Title;
                    Image mobileImage = ImageHelper.GetImage(mobileImageId, imageProviderName);
                    if (mobileImage != null)
                    {
                        this.MobileImageUrl = ImageHelper.GetImageUrl(mobileImage);
                    }
                }
            }
        }
        public string ImageAlternativeText
        {
            get;
            set;
        }

        public string ImageTitle
        {
            get;
            set;
        }

        public string DesktopImageUrl
        {
            get;
            set;
        }
        public string MobileImageUrl
        {
            get;
            set;
        }
    }
}