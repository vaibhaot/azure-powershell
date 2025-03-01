# Upcoming breaking changes in Azure PowerShell

## Az.Accounts

### `Resolve-AzError`

- Cmdlet breaking-change will happen to all parameter set
  - The `Resolve-Error` alias will be removed in a future release.  Please change any scripts that use this alias to use `Resolve-AzError` instead.

## Az.AnalysisServices

### `Add-AzAnalysisServicesAccount`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

## Az.ApiManagement

### `New-AzApiManagementOperation`

- Parameter breaking-change will happen to all parameter sets
  - `-Request`
    - Change Request.Representations.Sample to Request.Representations.Example
  - `-Responses`
    - Change Responses.Representations.Sample to Responses.Representations.Example

### `Set-AzApiManagementOperation`

- Parameter breaking-change will happen to all parameter sets
  - `-Request`
    - Change Request.Representations.Sample Request.Representations.Example
  - `-Responses`
    - Change Responses.Representations.Sample to Responses.Representations.Example

### `Update-AzApiManagementRegion`

- Parameter breaking-change will happen to all parameter sets
  - `-Sku`
    - The parameter : 'Sku' is changing.
    The type of the parameter is changing from 'Microsoft.Azure.Commands.ApiManagement.Models.PsApiManagementSku' to 'String'.

## Az.Batch

### `Get-AzBatchAccountKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzBatchAccountKeys alias will be removed in an upcoming breaking change release

### `Get-AzBatchJobStatistic`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzBatchJobStatistics alias will be removed in an upcoming breaking change release

### `Get-AzBatchLocationQuota`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzBatchLocationQuotas alias will be removed in an upcoming breaking change release

### `Get-AzBatchPoolNodeCount`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzBatchPoolNodeCounts alias will be removed in an upcoming breaking change release

### `Get-AzBatchPoolStatistic`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzBatchPoolStatistics alias will be removed in an upcoming breaking change release

### `Get-AzBatchPoolUsageMetric`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzBatchPoolUsageMetrics alias will be removed in an upcoming breaking change release

### `Get-AzBatchRemoteLoginSetting`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzBatchRemoteLoginSettings alias will be removed in an upcoming breaking change release

### `Get-AzBatchTaskCount`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzBatchTaskCounts alias will be removed in an upcoming breaking change release

### `New-AzBatchPool`

- Parameter breaking-change will happen to all parameter sets
  - `-TaskSlotsPerNode`
    - The parameter : 'MaxTasksPerComputeNode' is changing.

## Az.Billing

### `Get-AzBillingPeriod`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

## Az.CognitiveServices

### `Get-AzCognitiveServicesAccountSku`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzCognitiveServicesAccountSkus alias will be removed in an upcoming breaking change release

## Az.Compute

### `Get-AzVM`

- Cmdlet breaking-change will happen to all parameter set
  - In the June 2023 Powershell release, the NextLink parameter set will be removed. Powershell by default loops through the list of VMs returned, so the user no longer has to use this parameter set.

### `New-AzDisk`

- Cmdlet breaking-change will happen to all parameter set
  - Starting in May 2023 the "New-AzDisk" cmdlet will deploy with the Trusted Launch configuration by default. This includes defaulting the "HyperVGeneration" parameter to "v2". To know more about Trusted Launch, please visit https://learn.microsoft.com/en-us/azure/virtual-machines/trusted-launch

### `New-AzVM`

- Cmdlet breaking-change will happen to all parameter set
  - Consider using the image alias including the version of the distribution you want to use in the "-Image" parameter of the "New-AzVM" cmdlet. On April 30, 2023, the image deployed using `UbuntuLTS` will reach its end of life. In October 2023, the aliases `UbuntuLTS`, `CentOS`, `Debian`, and `RHEL` will be removed.
  - Starting in May 2023 the "New-AzVM" cmdlet will deploy with the Trusted Launch configuration by default. To know more about Trusted Launch, please visit https://docs.microsoft.com/en-us/azure/virtual-machines/trusted-launch
  - It is recommended to use parameter "-PublicIpSku Standard" in order to create a new VM with a Standard public IP.Specifying zone(s) using the "-Zone" parameter will also result in a Standard public IP.If "-Zone" and "-PublicIpSku" are not specified, the VM will be created with a Basic public IP instead.Please note that the Standard SKU IPs will become the default behavior for VM creation in the future

### `New-AzVmss`

- Cmdlet breaking-change will happen to all parameter set
  - Starting May 2023, the "New-AzVmss" cmdlet will default to Trusted Launch VMSS. For more info, visit https://aka.ms/trustedLaunchVMSS.
  - Starting November 2023, the "New-AzVmss" cmdlet will use new defaults: Flexible orchestration mode and enable NATv2 configuration for Load Balancer. To learn more about Flexible Orchestration modes, visit https://aka.ms/orchestrationModeVMSS.
  - Consider using the image alias including the version of the distribution you want to use in the "-ImageName" parameter of the "New-AzVmss" cmdlet. On April 30, 2023, the image deployed using `UbuntuLTS` will reach its end of life. In October 2023, the aliases `UbuntuLTS`, `CentOS`, `Debian`, and `RHEL` will be removed.

## Az.ContainerRegistry

### `Get-AzContainerRegistry`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Get-AzContainerRegistryCredential`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

### `Get-AzContainerRegistryReplication`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Get-AzContainerRegistryUsage`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

### `Get-AzContainerRegistryWebhook`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-IncludeConfiguration`
    - Parameter is being deprecated without being replaced
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Get-AzContainerRegistryWebhookEvent`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `New-AzContainerRegistry`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

### `New-AzContainerRegistryNetworkRule`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'New-AzContainerRegistryIPRuleObject' is replacing this cmdlet.

### `New-AzContainerRegistryReplication`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `New-AzContainerRegistryWebhook`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Remove-AzContainerRegistry`

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Remove-AzContainerRegistryReplication`

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Remove-AzContainerRegistryWebhook`

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Set-AzContainerRegistryNetworkRuleSet`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

### `Test-AzContainerRegistryNameAvailability`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

### `Test-AzContainerRegistryWebhook`

- Cmdlet breaking-change will happen to all parameter set
  - The output type is changing from the existing type :'Microsoft.Azure.Commands.ContainerRegistry.PSContainerRegistryEventInfo' to the new type :'String'

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Update-AzContainerRegistry`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-NetworkRuleSet`
    - Parameter is being deprecated without being replaced
  - `-ResourceId`
    - Parameter is being deprecated without being replaced
  - `-StorageAccountName`
    - Parameter is being deprecated without being replaced

### `Update-AzContainerRegistryCredential`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Update-AzContainerRegistryWebhook`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

## Az.DataLakeStore

### `Export-AzDataLakeStoreChildItemProperty`

- Cmdlet breaking-change will happen to all parameter set
  - Export-AzDataLakeStoreChildItemProperties alias will be removed in an upcoming breaking change release

### `Export-AzDataLakeStoreItem`

- Cmdlet breaking-change will happen to all parameter set
  - For store side export failures, Export-AzDataLakeStoreItem will throw exception instead of printing message on screen

### `Import-AzDataLakeStoreItem`

- Cmdlet breaking-change will happen to all parameter set
  - For store side import failures, Import-AzDataLakeStoreItem will throw exception instead of printing message on screen

## Az.DataShare

### `Get-AzDataShare`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareAccount`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareDataSet`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareDataSetMapping`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareInvitation`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareProviderShareSubscription`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareReceivedInvitation`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareSourceDataSet`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareSubscription`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareSubscriptionSynchronization`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareSubscriptionSynchronizationDetail`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareSynchronization`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareSynchronizationDetail`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareSynchronizationSetting`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Get-AzDataShareTrigger`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Grant-AzDataShareSubscriptionAccess`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `New-AzDataShare`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `New-AzDataShareAccount`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `New-AzDataShareDataSet`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `New-AzDataShareDataSetMapping`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `New-AzDataShareInvitation`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `New-AzDataShareSubscription`

- Cmdlet breaking-change will happen to all parameter set
  - Parameter SourceShareLocation is mandatory to support cross region share subscription creation.
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `New-AzDataShareSynchronizationSetting`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `New-AzDataShareTrigger`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Remove-AzDataShare`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Remove-AzDataShareAccount`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Remove-AzDataShareDataSet`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Remove-AzDataShareDataSetMapping`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Remove-AzDataShareInvitation`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Remove-AzDataShareSubscription`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Remove-AzDataShareSynchronizationSetting`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Remove-AzDataShareTrigger`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Revoke-AzDataShareSubscriptionAccess`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Set-AzDataShare`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Start-AzDataShareSubscriptionSynchronization`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

### `Stop-AzDataShareSubscriptionSynchronization`

- Cmdlet breaking-change will happen to all parameter set
  - DataShare APIs cmdlets will bump up API version which may introduce breaking change. Please contact us for more information.

## Az.EventHub

### `Add-AzEventHubIPRule`

- Cmdlet breaking-change will happen to all parameter set
  - This cmdlet would be deprecated in a future release. Please use Set-AzEventHubNetworkRuleSet.

### `Add-AzEventHubVirtualNetworkRule`

- Cmdlet breaking-change will happen to all parameter set
  - This cmdlet would be deprecated in a future release. Please use Set-AzEventHubNetworkRuleSet.

### `Get-AzEventHubNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEhNamespace`. This cmdlet would henceforth be alias cmdlet with Get-AzEventHubNamespaceV2.

### `New-AzEventHub`

- Parameter breaking-change will happen to all parameter sets
  - `-MessageRetentionInDays`
    - The parameter : 'MessageRetentionInDays' is changing.
    - The change is expected to take effect from the version : '4.0.0'

### `New-AzEventHubEncryptionConfig`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.KeyVaultProperties`.

### `New-AzEventHubNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEhNamespace`. This cmdlet would henceforth be alias cmdlet with New-AzEventHubNamespaceV2.

- Parameter breaking-change will happen to all parameter sets
  - `-EnableKafka`
    - This parameter would be removed in version Az 10.0
  - `-EncryptionConfig`
    - The parameter : 'EncryptionConfig' is being replaced by parameter : 'KeyVaultProperty'.
    The type of the parameter is changing from 'Microsoft.Azure.Commands.EventHub.Models.PSEncryptionConfigAttributes[]' to 'Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202210Preview.IKeyVaultProperties[]'.
  - `-IdentityId`
    - The parameter : 'IdentityId' is being replaced by parameter : 'UserAssignedIdentityId'.
  - `-MaximumThroughputUnits`
    - The parameter : 'MaximumThroughputUnits' is being replaced by parameter : 'MaximumThroughputUnit'.

### `Remove-AzEventHubIPRule`

- Cmdlet breaking-change will happen to all parameter set
  - This cmdlet would be deprecated in a future release. Please use Set-AzEventHubNetworkRuleSet.

### `Remove-AzEventHubNamespace`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - The type of the `-InputObject` parameter would change to `Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEhNamespace`.
  - `-ResourceId`
    - This parameter would be removed. Henceforth, resource Id's can be provided as input to `-InputObject` parameter.

### `Remove-AzEventHubNetworkRuleSet`

- Cmdlet breaking-change will happen to all parameter set
  - This cmdlet would be deprecated in a future release. Please use Set-AzEventHubNetworkRuleSet.

### `Remove-AzEventHubVirtualNetworkRule`

- Cmdlet breaking-change will happen to all parameter set
  - This cmdlet would be deprecated in a future release. Please use Set-AzEventHubNetworkRuleSet.

### `Set-AzEventHub`

- Parameter breaking-change will happen to all parameter sets
  - `-MessageRetentionInDays`
    - The parameter : 'MessageRetentionInDays' is changing.
    - Change description : -MessageRetentionInDays would be deprecated and would be replaced by -RetentionTimeInHours 
    - The change is expected to take effect from the version : '4.0.0'

### `Set-AzEventHubNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEhNamespace`. This cmdlet would henceforth be alias cmdlet with Set-AzEventHubNamespaceV2.

- Parameter breaking-change will happen to all parameter sets
  - `-EnableKafka`
    - This parameter would be removed in version Az 10.0
  - `-EncryptionConfig`
    - The parameter : 'EncryptionConfig' is being replaced by parameter : 'KeyVaultProperty'.
    The type of the parameter is changing from 'Microsoft.Azure.Commands.EventHub.Models.PSEncryptionConfigAttributes[]' to 'Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202210Preview.IKeyVaultProperties[]'.
  - `-IdentityId`
    - The parameter : 'IdentityId' is being replaced by parameter : 'UserAssignedIdentityId'.
  - `-MaximumThroughputUnits`
    - The parameter : 'MaximumThroughputUnits' is being replaced by parameter : 'MaximumThroughputUnit'.

## Az.HDInsight

### `New-AzHDInsightCluster`

- Parameter breaking-change will happen to all parameter sets
  - `-RdpAccessExpiry`
    - This parameter is being deprecated.
  - `-RdpCredential`
    - This parameter is being deprecated.

## Az.KeyVault

### `Invoke-AzKeyVaultKeyOperation`

- Cmdlet breaking-change will happen to all parameter set
  - The encoded/decoded way between string and bytes will change to UTF8.

## Az.LogicApp

### `New-AzIntegrationAccountMap`

- Parameter breaking-change will happen to all parameter sets
  - `-ContentType`
    - ContentType is being deprecated without being replaced. It will be inferred from MapType

### `Set-AzIntegrationAccountMap`

- Parameter breaking-change will happen to all parameter sets
  - `-ContentType`
    - ContentType is being deprecated without being replaced. It will be inferred from MapType

## Az.MachineLearning

### `Get-AzMlWebServiceKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzMlWebServiceKeys alias will be removed in an upcoming breaking change release

## Az.Media

### `Get-AzMediaServiceKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzMediaServiceKeys alias will be removed in an upcoming breaking change release

### `Sync-AzMediaServiceStorageKey`

- Cmdlet breaking-change will happen to all parameter set
  - Sync-AzMediaServiceStorageKeys alias will be removed in an upcoming breaking change release

## Az.NetAppFiles

### `New-AzNetAppFilesVolume`

- Parameter breaking-change will happen to all parameter sets
  - `-Snapshot`
    - Snapshot invalid and preserved for compatibility. Parameter SnapshotPolicyId should be used instead
  - `-UnixPermission`
    - Parameter Alias UnixPermissions will be removed, please use UnixPermission.

## Az.Network

### `Add-AzApplicationGatewayBackendHttpSetting`

- Cmdlet breaking-change will happen to all parameter set
  - Add-AzApplicationGatewayBackendHttpSettings alias will be removed in an upcoming breaking change release

### `Add-AzExpressRouteCircuitAuthorization`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Add-AzExpressRouteCircuitConnectionConfig`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Add-AzExpressRouteCircuitPeeringConfig`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Add-AzVirtualHubRoute`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'New-AzVHubRoute' is replacing this cmdlet.

### `Add-AzVirtualHubRouteTable`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'New-AzVHubRouteTable' is replacing this cmdlet.

### `Add-AzVirtualNetworkSubnetConfig`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - Update Property Name
  - `-ResourceId`
    - Update Property Name

### `Add-AzVirtualRouterPeer`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Add-AzRouteServerPeer' is replacing this cmdlet.

### `Get-AzApplicationGatewayAvailableSslOption`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzApplicationGatewayAvailableSslOptions alias will be removed in an upcoming breaking change release

### `Get-AzApplicationGatewayAvailableWafRuleSet`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzApplicationGatewayAvailableWafRuleSets alias will be removed in an upcoming breaking change release

### `Get-AzApplicationGatewayBackendHttpSetting`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzApplicationGatewayBackendHttpSettings alias will be removed in an upcoming breaking change release

### `Get-AzExpressRouteCircuit`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Get-AzExpressRouteCircuitAuthorization`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Get-AzExpressRouteCircuitPeeringConfig`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Get-AzExpressRouteCircuitStat`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzExpressRouteCircuitStats alias will be removed in an upcoming breaking change release

### `Get-AzPrivateEndpointConnection`

- Parameter breaking-change will happen to all parameter sets
  - `-Description`
    - Parameter is being deprecated without being replaced

### `Get-AzVirtualHubRouteTable`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Get-AzVHubRouteTable' is replacing this cmdlet.

### `Get-AzVirtualRouter`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Get-AzRouteServer' is replacing this cmdlet.

### `Get-AzVirtualRouterPeer`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Get-AzRouteServerPeer' is replacing this cmdlet.

### `Get-AzVirtualRouterPeerAdvertisedRoute`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Get-AzRouteServerPeerAdvertisedRoute' is replacing this cmdlet.

### `Get-AzVirtualRouterPeerLearnedRoute`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Get-AzRouteServerPeerLearnedRoute' is replacing this cmdlet.

### `Move-AzExpressRouteCircuit`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `New-AzApplicationGateway`

- Parameter breaking-change will happen to all parameter sets
  - `-UserAssignedIdentityId`
    - The parameter : 'UserAssignedIdentityId' is being replaced by parameter : 'Identity'.

### `New-AzApplicationGatewayBackendHttpSetting`

- Cmdlet breaking-change will happen to all parameter set
  - New-AzApplicationGatewayBackendHttpSettings alias will be removed in an upcoming breaking change release

### `New-AzExpressRouteCircuit`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `New-AzFirewall`

- Parameter breaking-change will happen to all parameter sets
  - `-PublicIpName`
    - This parameter will be removed in an upcoming breaking change release. After this point the Public IP Address will be provided as a list of one or more objects instead of a string.
  - `-VirtualNetworkName`
    - This parameter will be removed in an upcoming breaking change release. After this point the Virtual Network will be provided as an object instead of a string.

### `New-AzFirewallPolicyApplicationRule`

- Parameter breaking-change will happen to all parameter sets
  - `-SourceAddress`
    - This parameter is becoming optional as SourceIpGroup can be provided without this.

### `New-AzFirewallPolicyNetworkRule`

- Parameter breaking-change will happen to all parameter sets
  - `-SourceAddress`
    - This parameter is becoming optional as SourceIpGroup can be provided without this.

### `New-AzLoadBalancer`

- Cmdlet breaking-change will happen to all parameter set
  - It is recommended to use parameter '-Sku Standard' to create new Load Balancer. Please note that it will become the default behavior for Load Balancer creation in the future.

### `New-AzLoadBalancerFrontendIpConfig`

- Cmdlet breaking-change will happen to all parameter set
  - Default behaviour of Zone will be changed

### `New-AzPrivateLinkServiceIpConfig`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSPrivateLinkServiceIpConfiguration' is changing
  - The following properties in the output type are being deprecated : 'PublicIPAddress'
  - The following properties are being added to the output type : 'Primary'

- Parameter breaking-change will happen to all parameter sets
  - `-PublicIpAddress`
    - Parameter is being deprecated without being replaced

### `New-AzPublicIpAddress`

- Cmdlet breaking-change will happen to all parameter set
  - Default behaviour of Zone will be changed
  - It is recommended to use parameter '-Sku Standard' to create new IP address. Please note that it will become the default behavior for IP address creation in the future.

### `New-AzPublicIpPrefix`

- Cmdlet breaking-change will happen to all parameter set
  - Default behaviour of Zone will be changed

### `New-AzVirtualHub`

- Parameter breaking-change will happen to all parameter sets
  - `-HubVnetConnection`
    - HubVnetConnection parameter is deprecated. Use *VirtualHubVnetConnection* commands
  - `-PreferredRoutingGateway`
    - PreferredRoutingGateway parameter is deprecated. Use *HubRoutingPreference* property
  - `-RouteTable`
    - Parameter is being deprecated without being replaced. Use *VHubRouteTable* commands.

### `New-AzVirtualHubRoute`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'New-AzVHubRoute' is replacing this cmdlet.

### `New-AzVirtualHubRouteTable`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'New-AzVHubRouteTable' is replacing this cmdlet.

### `New-AzVirtualHubVnetConnection`

- Parameter breaking-change will happen to all parameter sets
  - `-EnableInternetSecurity`
    - The parameter : 'EnableInternetSecurity' is changing.
    The type of the parameter is changing from 'System.Management.Automation.SwitchParameter' to 'EnableInternetSecurityFlag'.

### `New-AzVirtualNetworkSubnetConfig`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - Update Property Name
  - `-ResourceId`
    - Update Property Name

### `New-AzVirtualRouter`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'New-AzRouteServer' is replacing this cmdlet.

### `Remove-AzApplicationGatewayBackendHttpSetting`

- Cmdlet breaking-change will happen to all parameter set
  - Remove-AzApplicationGatewayBackendHttpSettings alias will be removed in an upcoming breaking change release

### `Remove-AzExpressRouteCircuitAuthorization`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Remove-AzExpressRouteCircuitConnectionConfig`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Remove-AzExpressRouteCircuitPeeringConfig`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Remove-AzPrivateEndpointConnection`

- Parameter breaking-change will happen to all parameter sets
  - `-Description`
    - Parameter is being deprecated without being replaced

### `Remove-AzVirtualHubRouteTable`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Remove-AzVHubRouteTable' is replacing this cmdlet.

### `Remove-AzVirtualRouter`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Remove-AzRouteServer' is replacing this cmdlet.

### `Remove-AzVirtualRouterPeer`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Remove-AzRouteServerPeer' is replacing this cmdlet.

### `Set-AzApplicationGatewayBackendHttpSetting`

- Cmdlet breaking-change will happen to all parameter set
  - Set-AzApplicationGatewayBackendHttpSettings alias will be removed in an upcoming breaking change release

### `Set-AzExpressRouteCircuit`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Set-AzExpressRouteCircuitConnectionConfig`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Set-AzExpressRouteCircuitPeeringConfig`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Network.Models.PSExpressRouteCircuit' is changing
  - The following properties in the output type are being deprecated : 'AllowGlobalReach'

### `Set-AzVirtualHub`

- Parameter breaking-change will happen to all parameter sets
  - `-RouteTable`
    - Parameter is being deprecated without being replaced. Use *VHubRouteTable* commands.

### `Set-AzVirtualNetworkSubnetConfig`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - Update Property Name
  - `-ResourceId`
    - Update Property Name

### `Update-AzVirtualHub`

- Parameter breaking-change will happen to all parameter sets
  - `-HubVnetConnection`
    - HubVnetConnection parameter is deprecated. Use *VirtualHubVnetConnection* commands
  - `-PreferredRoutingGateway`
    - PreferredRoutingGateway parameter will be deprecated. Use *HubRoutingPreference* parameter
  - `-RouteTable`
    - Parameter is being deprecated without being replaced. Use *VHubRouteTable* commands.

### `Update-AzVirtualRouter`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Update-AzRouteServer' is replacing this cmdlet.

### `Update-AzVirtualRouterPeer`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'Update-AzRouteServerPeer' is replacing this cmdlet.

## Az.NotificationHubs

### `Get-AzNotificationHubAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzNotificationHubAuthorizationRules alias will be removed in an upcoming breaking change release

### `Get-AzNotificationHubListKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzNotificationHubListKeys alias will be removed in an upcoming breaking change release

### `Get-AzNotificationHubPNSCredential`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzNotificationHubPNSCredentials alias will be removed in an upcoming breaking change release

### `Get-AzNotificationHubsNamespaceAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzNotificationHubsNamespaceAuthorizationRules alias will be removed in an upcoming breaking change release

### `Get-AzNotificationHubsNamespaceListKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzNotificationHubsNamespaceListKeys alias will be removed in an upcoming breaking change release

### `New-AzNotificationHubAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - New-AzNotificationHubAuthorizationRules alias will be removed in an upcoming breaking change release

### `New-AzNotificationHubsNamespaceAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - New-AzNotificationHubsNamespaceAuthorizationRules alias will be removed in an upcoming breaking change release

### `Remove-AzNotificationHubAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Remove-AzNotificationHubAuthorizationRules alias will be removed in an upcoming breaking change release

### `Remove-AzNotificationHubsNamespaceAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Remove-AzNotificationHubsNamespaceAuthorizationRules alias will be removed in an upcoming breaking change release

### `Set-AzNotificationHubAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Set-AzNotificationHubAuthorizationRules alias will be removed in an upcoming breaking change release

### `Set-AzNotificationHubsNamespaceAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Set-AzNotificationHubsNamespaceAuthorizationRules alias will be removed in an upcoming breaking change release

## Az.OperationalInsights

### `Get-AzOperationalInsightsCluster`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.OperationalInsights.Models.PSCluster' is changing
  - The following properties in the output type are being deprecated : 'NextLink' 'Sku'

### `Get-AzOperationalInsightsIntelligencePack`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzOperationalInsightsIntelligencePacks alias will be removed in an upcoming breaking change release

### `Get-AzOperationalInsightsWorkspaceManagementGroup`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzOperationalInsightsWorkspaceManagementGroups alias will be removed in an upcoming breaking change release

### `Get-AzOperationalInsightsWorkspaceSharedKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzOperationalInsightsWorkspaceSharedKeys alias will be removed in an upcoming breaking change release

### `New-AzOperationalInsightsCluster`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.OperationalInsights.Models.PSCluster' is changing
  - The following properties in the output type are being deprecated : 'NextLink' 'Sku'

### `Update-AzOperationalInsightsCluster`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.OperationalInsights.Models.PSCluster' is changing
  - The following properties in the output type are being deprecated : 'NextLink' 'Sku'

## Az.PowerBIEmbedded

### `Get-AzPowerBIWorkspace`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

### `Get-AzPowerBIWorkspaceCollection`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

### `Get-AzPowerBIWorkspaceCollectionAccessKey`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

### `New-AzPowerBIWorkspaceCollection`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

### `Remove-AzPowerBIWorkspaceCollection`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

### `Reset-AzPowerBIWorkspaceCollectionAccessKey`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

## Az.RecoveryServices

### `Get-AzRecoveryServicesVaultSettingsFile`

- Parameter breaking-change will happen to all parameter sets
  - `-Certificate`
    - Parameter is being deprecated without being replaced

## Az.RedisCache

### `Remove-AzRedisCacheDiagnostic`

- Cmdlet breaking-change will happen to all parameter set
  - Remove-AzRedisCacheDiagnostics alias will be removed in an upcoming breaking change release

### `Set-AzRedisCacheDiagnostic`

- Cmdlet breaking-change will happen to all parameter set
  - Set-AzRedisCacheDiagnostics alias will be removed in an upcoming breaking change release

## Az.Relay

### `Get-AzRelayOperation`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzRelayOperation will be removed in an upcoming breaking change release. Please use 'Get-AzProviderOperation Microsoft.Relay/*'

### `Set-AzRelayNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Set-AzRelayNamespace will be removed in an upcoming breaking change release, you can use Update-AzRelayNamespace in a future release

## Az.Resources

### `Export-AzResourceGroup`

- Parameter breaking-change will happen to all parameter sets
  - `-ApiVersion`
    - Parameter is being deprecated without being replaced. Using the lastest possible API version will become the default behavior.

### `Get-AzManagementGroup`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `Get-AzManagementGroupHierarchySetting`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `Get-AzManagementGroupNameAvailability`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `Get-AzManagementGroupSubscription`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `Get-AzPolicyAssignment`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyAssignment' is changing
  - The following properties are being added to the output type : 'Identity'

### `New-AzManagementGroup`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `New-AzManagementGroupHierarchySetting`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `New-AzManagementGroupSubscription`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `New-AzPolicyAssignment`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyAssignment' is changing
  - The following properties are being added to the output type : 'Identity'

- Parameter breaking-change will happen to all parameter sets
  - `-AssignIdentity`
    - Parameter AssignIdentity is deprecated and will be removed in future releases. Please use the 'IdentityType' parameter instead.

### `Remove-AzManagementGroup`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `Remove-AzManagementGroupHierarchySetting`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `Remove-AzManagementGroupSubscription`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `Set-AzPolicyAssignment`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.Policy.PsPolicyAssignment' is changing
  - The following properties are being added to the output type : 'Identity'

- Parameter breaking-change will happen to all parameter sets
  - `-AssignIdentity`
    - Parameter AssignIdentity is deprecated and will be removed in future releases. Please use the 'IdentityType' parameter instead.

### `Update-AzManagementGroup`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

### `Update-AzManagementGroupHierarchySetting`

- Parameter breaking-change will happen to all parameter sets
  - `-GroupName`
    - We will replace GroupName with GroupId to make it more clear.

## Az.Security

### `Get-AzSecurityAlert`

- Cmdlet breaking-change will happen to all parameter set
  - The output type is changing from the existing type :'Microsoft.Azure.Commands.Security.Models.Alerts.PSSecurityAlert' to the new type :'PSSecurityAlertV3'

### `Set-AzSecurityAlert`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - The parameter : 'InputObject' is changing.
    The type of the parameter is changing from 'Microsoft.Azure.Commands.Security.Models.Alerts.PSSecurityAlert' to 'PSSecurityAlertV3'.

## Az.ServiceBus

### `Add-AzServiceBusIPRule`

- Cmdlet breaking-change will happen to all parameter set
  - This cmdlet would be deprecated in a future release. Please use Set-AzServiceBusNetworkRuleSet.

### `Add-AzServiceBusVirtualNetworkRule`

- Cmdlet breaking-change will happen to all parameter set
  - This cmdlet would be deprecated in a future release. Please use Set-AzServiceBusNetworkRuleSet.

### `Get-AzServiceBusNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbNamespace`. This cmdlet would henceforth be alias cmdlet with Get-AzServiceBusNamespaceV2.

### `New-AzServiceBusEncryptionConfig`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202210Preview.KeyVaultProperties`.

### `New-AzServiceBusNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbNamespace`. This cmdlet would henceforth be alias cmdlet with New-AzServiceBusNamespaceV2.

- Parameter breaking-change will happen to all parameter sets
  - `-EncryptionConfig`
    - The parameter : 'EncryptionConfig' is being replaced by parameter : 'KeyVaultProperty'.
    The type of the parameter is changing from 'Microsoft.Azure.Commands.ServiceBus.Models.PSEncryptionConfigAttributes[]' to 'Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202210Preview.IKeyVaultProperties[]'.
  - `-IdentityId`
    - The parameter : 'IdentityId' is being replaced by parameter : 'UserAssignedIdentityId'.

### `Remove-AzServiceBusIPRule`

- Cmdlet breaking-change will happen to all parameter set
  - This cmdlet would be deprecated in a future release. Please use Set-AzServiceBusNetworkRuleSet.

### `Remove-AzServiceBusNamespace`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - The type of the `-InputObject` parameter would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202210Preview.ISbNamespace`.
  - `-ResourceId`
    - This parameter would be removed. Henceforth, resource Id's can be provided as input to `-InputObject` parameter.

### `Remove-AzServiceBusNetworkRuleSet`

- Cmdlet breaking-change will happen to all parameter set
  - This cmdlet would be deprecated in a future release. Please use Set-AzServiceBusNetworkRuleSet.

### `Remove-AzServiceBusVirtualNetworkRule`

- Cmdlet breaking-change will happen to all parameter set
  - This cmdlet would be deprecated in a future release. Please use Set-AzServiceBusNetworkRuleSet.

### `Set-AzServiceBusNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbNamespace`. This cmdlet would henceforth be alias cmdlet with Set-AzServiceBusNamespaceV2.

- Parameter breaking-change will happen to all parameter sets
  - `-EncryptionConfig`
    - The parameter : 'EncryptionConfig' is being replaced by parameter : 'KeyVaultProperty'.
    The type of the parameter is changing from 'Microsoft.Azure.Commands.ServiceBus.Models.PSEncryptionConfigAttributes[]' to 'Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202210Preview.IKeyVaultProperties[]'.
  - `-IdentityId`
    - The parameter : 'IdentityId' is being replaced by parameter : 'UserAssignedIdentityId'.

## Az.SignalR

### `Get-AzSignalR`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.SignalR.Models.PSSignalRResource' is changing
  - The following properties in the output type are being deprecated : 'HostNamePrefix'

### `New-AzSignalR`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.SignalR.Models.PSSignalRResource' is changing
  - The following properties in the output type are being deprecated : 'HostNamePrefix'

### `Update-AzSignalR`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.SignalR.Models.PSSignalRResource' is changing
  - The following properties in the output type are being deprecated : 'HostNamePrefix'

## Az.Sql

### `Get-AzSqlDatabase`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.Database.Model.AzureSqlDatabaseModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `Get-AzSqlDatabaseReplicationLink`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.Replication.Model.AzureReplicationLinkModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `Get-AzSqlInstance`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.ManagedInstance.Model.AzureSqlManagedInstanceModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `New-AzSqlDatabase`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.Database.Model.AzureSqlDatabaseModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `New-AzSqlDatabaseCopy`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.Replication.Model.AzureSqlDatabaseCopyModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `New-AzSqlDatabaseSecondary`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.Replication.Model.AzureReplicationLinkModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `New-AzSqlInstance`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.ManagedInstance.Model.AzureSqlManagedInstanceModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `Remove-AzSqlDatabase`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.Database.Model.AzureSqlDatabaseModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `Remove-AzSqlDatabaseSecondary`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.Replication.Model.AzureReplicationLinkModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `Remove-AzSqlInstance`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.ManagedInstance.Model.AzureSqlManagedInstanceModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `Set-AzSqlDatabase`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.Database.Model.AzureSqlDatabaseModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `Set-AzSqlDatabaseSecondary`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.Replication.Model.AzureReplicationLinkModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

### `Set-AzSqlInstance`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.Sql.ManagedInstance.Model.AzureSqlManagedInstanceModel' is changing
  - The following properties in the output type are being deprecated : 'BackupStorageRedundancy'
  - The following properties are being added to the output type : 'CurrentBackupStorageRedundancy' 'RequestedBackupStorageRedundancy'

## Az.SqlVirtualMachine

### `Get-AzAvailabilityGroupListener`

- Parameter breaking-change will happen to all parameter sets
  - `-SqlVMGroupObject`
    - SqlVMGroupObject parameter is being deprecated without being replaced.

### `Get-AzSqlVM`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.SqlVirtualMachine.SqlVirtualMachine.Model.AzureSqlVMModel' is changing
  - The following properties in the output type are being deprecated : 'SqlManagementType'

### `New-AzAvailabilityGroupListener`

- Parameter breaking-change will happen to all parameter sets
  - `-SqlVMGroupObject`
    - SqlVMGroupObject parameter is being deprecated without being replaced.

### `New-AzSqlVM`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.SqlVirtualMachine.SqlVirtualMachine.Model.AzureSqlVMModel' is changing
  - The following properties in the output type are being deprecated : 'SqlManagementType'

- Parameter breaking-change will happen to all parameter sets
  - `-SqlVM`
    - SqlManagementType parameter is being deprecated

### `New-AzSqlVMConfig`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

### `Remove-AzAvailabilityGroupListener`

- Parameter breaking-change will happen to all parameter sets
  - `-SqlVMGroupObject`
    - SqlVMGroupObject parameter is being deprecated without being replaced.

### `Remove-AzSqlVM`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.SqlVirtualMachine.SqlVirtualMachine.Model.AzureSqlVMModel' is changing
  - The following properties in the output type are being deprecated : 'SqlManagementType'

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - InputObject parameter alias 'SqlVM' will be removed.

### `Remove-AzSqlVMGroup`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - InputObject parameter alias 'SqlVMGroup' will be removed.

### `Set-AzSqlVMConfigGroup`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

### `Update-AzAvailabilityGroupListener`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

- Parameter breaking-change will happen to all parameter sets
  - `-SqlVMGroupObject`
    - SqlVMGroupObject parameter is being deprecated without being replaced.

### `Update-AzSqlVM`

- Cmdlet breaking-change will happen to all parameter set
  - The output type 'Microsoft.Azure.Commands.SqlVirtualMachine.SqlVirtualMachine.Model.AzureSqlVMModel' is changing
  - The following properties in the output type are being deprecated : 'SqlManagementType'

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - InputObject parameter alias 'SqlVM' will be removed.
  - `-SqlManagementType`
    - SqlManagementType parameter is being deprecated

### `Update-AzSqlVMGroup`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - InputObject parameter alias 'SqlVMGroup' will be removed.

## Az.Storage

### `Get-AzStorageBlob`

- Parameter breaking-change will happen to all parameter sets
  - `-Blob`
    - Leading and trailing slashes will not be trimmed in a future release.

### `New-AzStorageAccount`

- Cmdlet breaking-change will happen to all parameter set
  - Default value of AllowBlobPublicAccess will be changed from True to False in a future release. When AllowBlobPublicAccess is False on a storage account, it is not permitted to configure container ACLs to allow anonymous access to blobs within the storage account.

- Parameter breaking-change will happen to all parameter sets
  - `-EnableLargeFileShare`
    - EnableLargeFileShare parameter will be deprecated in a future release.

### `Set-AzStorageAccount`

- Parameter breaking-change will happen to all parameter sets
  - `-EnableLargeFileShare`
    - EnableLargeFileShare parameter will be deprecated in a future release.

## Az.StorageSync

### `Set-AzStorageSyncServerEndpoint`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - Alias RegisteredServer is invalid and preserved for compatibility. Alias ServerEndpoint should be used instead

## Az.Synapse

### `New-AzSynapseSparkPool`

- Parameter breaking-change will happen to all parameter sets
  - `-SparkConfigFilePath`
    - The parameter : 'SparkConfigFilePath' is being replaced by parameter : 'SparkConfiguration'.

### `Update-AzSynapseSparkPool`

- Parameter breaking-change will happen to all parameter sets
  - `-SparkConfigFilePath`
    - The parameter : 'SparkConfigFilePath' is being replaced by parameter : 'SparkConfiguration'.

## Az.Websites

### `New-AzWebAppContainerPSSession`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

