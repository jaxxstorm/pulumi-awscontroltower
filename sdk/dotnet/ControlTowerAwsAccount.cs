// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Awscontroltower
{
    [AwscontroltowerResourceType("awscontroltower:index/controlTowerAwsAccount:controlTowerAwsAccount")]
    public partial class ControlTowerAwsAccount : Pulumi.CustomResource
    {
        /// <summary>
        /// ID of the AWS account.
        /// </summary>
        [Output("accountId")]
        public Output<string> AccountId { get; private set; } = null!;

        /// <summary>
        /// Root email of the account.
        /// </summary>
        [Output("email")]
        public Output<string> Email { get; private set; } = null!;

        /// <summary>
        /// Name of the account.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Name of the Organizational Unit under which the account resides.
        /// </summary>
        [Output("organizationalUnit")]
        public Output<string> OrganizationalUnit { get; private set; } = null!;

        /// <summary>
        /// Name of the service catalog product that is provisioned. Defaults to a slugified version of the account name.
        /// </summary>
        [Output("provisionedProductName")]
        public Output<string> ProvisionedProductName { get; private set; } = null!;

        /// <summary>
        /// Assigned SSO user settings.
        /// </summary>
        [Output("sso")]
        public Output<Outputs.ControlTowerAwsAccountSso> Sso { get; private set; } = null!;

        /// <summary>
        /// Key-value map of resource tags for the account.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a ControlTowerAwsAccount resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ControlTowerAwsAccount(string name, ControlTowerAwsAccountArgs args, CustomResourceOptions? options = null)
            : base("awscontroltower:index/controlTowerAwsAccount:controlTowerAwsAccount", name, args ?? new ControlTowerAwsAccountArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ControlTowerAwsAccount(string name, Input<string> id, ControlTowerAwsAccountState? state = null, CustomResourceOptions? options = null)
            : base("awscontroltower:index/controlTowerAwsAccount:controlTowerAwsAccount", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/jaxxstorm/pulumi-awscontroltower/releases/download/${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ControlTowerAwsAccount resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ControlTowerAwsAccount Get(string name, Input<string> id, ControlTowerAwsAccountState? state = null, CustomResourceOptions? options = null)
        {
            return new ControlTowerAwsAccount(name, id, state, options);
        }
    }

    public sealed class ControlTowerAwsAccountArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Root email of the account.
        /// </summary>
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        /// <summary>
        /// Name of the account.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Name of the Organizational Unit under which the account resides.
        /// </summary>
        [Input("organizationalUnit", required: true)]
        public Input<string> OrganizationalUnit { get; set; } = null!;

        /// <summary>
        /// Name of the service catalog product that is provisioned. Defaults to a slugified version of the account name.
        /// </summary>
        [Input("provisionedProductName")]
        public Input<string>? ProvisionedProductName { get; set; }

        /// <summary>
        /// Assigned SSO user settings.
        /// </summary>
        [Input("sso", required: true)]
        public Input<Inputs.ControlTowerAwsAccountSsoArgs> Sso { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value map of resource tags for the account.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ControlTowerAwsAccountArgs()
        {
        }
    }

    public sealed class ControlTowerAwsAccountState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the AWS account.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// Root email of the account.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        /// <summary>
        /// Name of the account.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Name of the Organizational Unit under which the account resides.
        /// </summary>
        [Input("organizationalUnit")]
        public Input<string>? OrganizationalUnit { get; set; }

        /// <summary>
        /// Name of the service catalog product that is provisioned. Defaults to a slugified version of the account name.
        /// </summary>
        [Input("provisionedProductName")]
        public Input<string>? ProvisionedProductName { get; set; }

        /// <summary>
        /// Assigned SSO user settings.
        /// </summary>
        [Input("sso")]
        public Input<Inputs.ControlTowerAwsAccountSsoGetArgs>? Sso { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value map of resource tags for the account.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ControlTowerAwsAccountState()
        {
        }
    }
}
