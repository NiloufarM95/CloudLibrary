using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.AWSViewModels
{
    public class DeleteAWSViewModel : DeleteViewModel
    {
        public override DeleteCloudServiceProviderModel ToDeleteCloudServiceProviderModel()
        {
            return new DeleteCloudServiceProviderModel(CloudServiceProvidersEnum.AWS, InfrastructureName);
        }

    }
}
