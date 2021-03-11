using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.GoogleViewModels
{
    public class DeleteGoogleViewModel : DeleteViewModel
    {
        public override DeleteCloudServiceProviderModel ToDeleteCloudServiceProviderModel()
        {
            return new DeleteCloudServiceProviderModel(CloudServiceProvidersEnum.Google, InfrastructureName);
        }
    }
}
