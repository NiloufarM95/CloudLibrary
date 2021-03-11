using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.IGSViewModels
{
    public class DeleteIGSViewModel : DeleteViewModel
    {
        public override DeleteCloudServiceProviderModel ToDeleteCloudServiceProviderModel()
        {
            return new DeleteCloudServiceProviderModel(CloudServiceProvidersEnum.IGS,InfrastructureName);
        }
    }
}
