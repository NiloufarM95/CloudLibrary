using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.AzureViewModels
{
    public class CreateAzureViewModel : CreateViewModel
    {
        public override CreateCloudServiceProviderModel ToModel(CreateViewModel model)
        {
            model.CloudProvider = CloudServiceProvidersEnum.Azure;
            return base.ToModel(model);
        }
    }
}
