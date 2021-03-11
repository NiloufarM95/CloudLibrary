using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.GoogleViewModels
{
    public class CreateGoogleViewModel : CreateViewModel
    {
        public override CreateCloudServiceProviderModel ToModel(CreateViewModel model)
        {
            model.CloudProvider = CloudServiceProvidersEnum.Google;
            return base.ToModel(model);
        }
    }
}
