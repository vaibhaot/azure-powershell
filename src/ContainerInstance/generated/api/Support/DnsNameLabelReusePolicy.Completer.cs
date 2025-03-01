// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support
{

    /// <summary>
    /// The value representing the security enum. The 'Unsecure' value is the default value if not selected and means the object's
    /// domain name label is not secured against subdomain takeover. The 'TenantReuse' value is the default value if selected
    /// and means the object's domain name label can be reused within the same tenant. The 'SubscriptionReuse' value means the
    /// object's domain name label can be reused within the same subscription. The 'ResourceGroupReuse' value means the object's
    /// domain name label can be reused within the same resource group. The 'NoReuse' value means the object's domain name label
    /// cannot be reused within the same resource group, subscription, or tenant.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.DnsNameLabelReusePolicyTypeConverter))]
    public partial struct DnsNameLabelReusePolicy :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Unsecure".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Unsecure'", "Unsecure", global::System.Management.Automation.CompletionResultType.ParameterValue, "Unsecure");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TenantReuse".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'TenantReuse'", "TenantReuse", global::System.Management.Automation.CompletionResultType.ParameterValue, "TenantReuse");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SubscriptionReuse".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SubscriptionReuse'", "SubscriptionReuse", global::System.Management.Automation.CompletionResultType.ParameterValue, "SubscriptionReuse");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceGroupReuse".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ResourceGroupReuse'", "ResourceGroupReuse", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceGroupReuse");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Noreuse".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Noreuse'", "Noreuse", global::System.Management.Automation.CompletionResultType.ParameterValue, "Noreuse");
            }
        }
    }
}