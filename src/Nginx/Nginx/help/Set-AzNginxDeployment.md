---
external help file: Az.Nginx-help.xml
Module Name: Az.Nginx
online version: https://learn.microsoft.com/powershell/module/az.nginx/set-aznginxdeployment
schema: 2.0.0
---

# Set-AzNginxDeployment

## SYNOPSIS
Create or update the NGINX deployment

## SYNTAX

```
Set-AzNginxDeployment -Name <String> -ResourceGroupName <String> [-SubscriptionId <String>] -Location <String>
 -NetworkProfile <INginxNetworkProfile> -SkuName <String> [-EnableDiagnosticsSupport]
 [-IdentityType <IdentityType>] [-IdentityUserAssignedIdentity <Hashtable>] [-ManagedResourceGroup <String>]
 [-ScalingPropertyCapacity <Int32>] [-StorageAccountContainerName <String>] [-StorageAccountName <String>]
 [-Tag <Hashtable>] [-UserProfilePreferredEmail <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create or update the NGINX deployment

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

### EXAMPLE 2
```
{{ Add code here }}
```

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableDiagnosticsSupport
.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityType
.

```yaml
Type: IdentityType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityUserAssignedIdentity
Dictionary of \<UserIdentityProperties\>

```yaml
Type: Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedResourceGroup
The managed resource group to deploy VNet injection related network resources.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of targeted NGINX deployment

```yaml
Type: String
Parameter Sets: (All)
Aliases: DeploymentName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkProfile
.
To construct, see NOTES section for NETWORKPROFILE properties and create a hash table.

```yaml
Type: INginxNetworkProfile
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScalingPropertyCapacity
.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuName
Name of the SKU.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageAccountContainerName
.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageAccountName
.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Dictionary of \<string\>

```yaml
Type: Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserProfilePreferredEmail
The preferred support contact email address of the user used for sending alerts and notification.
Can be an empty string or a valid email address.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeployment
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

NETWORKPROFILE \<INginxNetworkProfile\>: .
  \[FrontEndIPConfiguration \<INginxFrontendIPConfiguration\>\]: 
    \[PrivateIPAddress \<INginxPrivateIPAddress\[\]\>\]: 
      \[PrivateIPAddress \<String\>\]: 
      \[PrivateIPAllocationMethod \<NginxPrivateIPAllocationMethod?\>\]: 
      \[SubnetId \<String\>\]: 
    \[PublicIPAddress \<INginxPublicIPAddress\[\]\>\]: 
      \[Id \<String\>\]: 
  \[NetworkInterfaceConfiguration \<INginxNetworkInterfaceConfiguration\>\]: 
    \[SubnetId \<String\>\]:

## RELATED LINKS

[https://learn.microsoft.com/powershell/module/az.nginx/set-aznginxdeployment](https://learn.microsoft.com/powershell/module/az.nginx/set-aznginxdeployment)

