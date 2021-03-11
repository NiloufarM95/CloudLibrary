using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.AzureViewModels
{
    public class DeleteAzureViewModel : DeleteViewModel
    {
        public override DeleteCloudServiceProviderModel ToModel(DeleteViewModel model)
        {
            model.CloudProvider = CloudServiceProvidersEnum.Azure;
            return base.ToModel(model);
        }
    }
}
