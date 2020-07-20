using System;
using Telerik.Sitefinity.Modules.Libraries;
using System.Linq;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.Modules;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Services;

namespace SitefinityWebApp.Code
{
    public static class ImageHelper
    {
        public static Image GetImage(Guid imageId, string imageProviderName)
        {
            return (
                from i in LibrariesManager.GetManager(imageProviderName).GetImages()
                where i.Id == imageId
                select i).Where<Image>(PredefinedFilters.PublishedItemsFilter<Image>()).FirstOrDefault<Image>();
        }

        public static string GetImageUrl(Image image)
        {
            if (image.Id == Guid.Empty)
            {
                return string.Empty;
            }
            bool generateAbsoluteUrls = Config.Get<SystemConfig>().SiteUrlSettings.GenerateAbsoluteUrls;
            return image.ResolveMediaUrl(generateAbsoluteUrls, null);
        }
    }
}