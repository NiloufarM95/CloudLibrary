using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.GoogleViewModels
{
    public class DeleteGoogleViewModel : DeleteViewModel
    {
        public override DeleteCloudServiceProviderModel ToModel(DeleteViewModel model)
        {
            model.CloudProvider = CloudServiceProvidersEnum.Google;
            return base.ToModel(model);
        }
    }
}
