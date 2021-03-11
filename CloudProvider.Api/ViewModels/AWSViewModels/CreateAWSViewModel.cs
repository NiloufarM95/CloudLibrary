using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.AWSViewModels
{
    public class CreateAWSViewModel : CreateViewModel
    {
        public override CreateCloudServiceProviderModel ToModel(CreateViewModel model)
        {
            model.CloudProvider = CloudServiceProvidersEnum.AWS;
            return base.ToModel(model);
        }
    }
}
