using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.IGSViewModels
{
    public class CreateIGSViewModel: CreateViewModel
    {
        public override CreateCloudServiceProviderModel ToModel(CreateViewModel model)
        {
            model.CloudProvider = CloudServiceProvidersEnum.IGS;
            return base.ToModel(model);
        }
    }
}
