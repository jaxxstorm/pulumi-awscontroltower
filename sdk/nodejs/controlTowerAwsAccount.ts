// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export class ControlTowerAwsAccount extends pulumi.CustomResource {
    /**
     * Get an existing ControlTowerAwsAccount resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ControlTowerAwsAccountState, opts?: pulumi.CustomResourceOptions): ControlTowerAwsAccount {
        return new ControlTowerAwsAccount(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'awscontroltower:index/controlTowerAwsAccount:controlTowerAwsAccount';

    /**
     * Returns true if the given object is an instance of ControlTowerAwsAccount.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ControlTowerAwsAccount {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ControlTowerAwsAccount.__pulumiType;
    }

    /**
     * ID of the AWS account.
     */
    public /*out*/ readonly accountId!: pulumi.Output<string>;
    /**
     * Root email of the account.
     */
    public readonly email!: pulumi.Output<string>;
    /**
     * Name of the account.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Name of the Organizational Unit under which the account resides.
     */
    public readonly organizationalUnit!: pulumi.Output<string>;
    /**
     * Name of the service catalog product that is provisioned. Defaults to a slugified version of the account name.
     */
    public readonly provisionedProductName!: pulumi.Output<string>;
    /**
     * Assigned SSO user settings.
     */
    public readonly sso!: pulumi.Output<outputs.ControlTowerAwsAccountSso>;
    /**
     * Key-value map of resource tags for the account.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;

    /**
     * Create a ControlTowerAwsAccount resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ControlTowerAwsAccountArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ControlTowerAwsAccountArgs | ControlTowerAwsAccountState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ControlTowerAwsAccountState | undefined;
            resourceInputs["accountId"] = state ? state.accountId : undefined;
            resourceInputs["email"] = state ? state.email : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["organizationalUnit"] = state ? state.organizationalUnit : undefined;
            resourceInputs["provisionedProductName"] = state ? state.provisionedProductName : undefined;
            resourceInputs["sso"] = state ? state.sso : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as ControlTowerAwsAccountArgs | undefined;
            if ((!args || args.email === undefined) && !opts.urn) {
                throw new Error("Missing required property 'email'");
            }
            if ((!args || args.organizationalUnit === undefined) && !opts.urn) {
                throw new Error("Missing required property 'organizationalUnit'");
            }
            if ((!args || args.sso === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sso'");
            }
            resourceInputs["email"] = args ? args.email : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["organizationalUnit"] = args ? args.organizationalUnit : undefined;
            resourceInputs["provisionedProductName"] = args ? args.provisionedProductName : undefined;
            resourceInputs["sso"] = args ? args.sso : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["accountId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ControlTowerAwsAccount.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering controlTowerAwsAccount resources.
 */
export interface ControlTowerAwsAccountState {
    /**
     * ID of the AWS account.
     */
    accountId?: pulumi.Input<string>;
    /**
     * Root email of the account.
     */
    email?: pulumi.Input<string>;
    /**
     * Name of the account.
     */
    name?: pulumi.Input<string>;
    /**
     * Name of the Organizational Unit under which the account resides.
     */
    organizationalUnit?: pulumi.Input<string>;
    /**
     * Name of the service catalog product that is provisioned. Defaults to a slugified version of the account name.
     */
    provisionedProductName?: pulumi.Input<string>;
    /**
     * Assigned SSO user settings.
     */
    sso?: pulumi.Input<inputs.ControlTowerAwsAccountSso>;
    /**
     * Key-value map of resource tags for the account.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a ControlTowerAwsAccount resource.
 */
export interface ControlTowerAwsAccountArgs {
    /**
     * Root email of the account.
     */
    email: pulumi.Input<string>;
    /**
     * Name of the account.
     */
    name?: pulumi.Input<string>;
    /**
     * Name of the Organizational Unit under which the account resides.
     */
    organizationalUnit: pulumi.Input<string>;
    /**
     * Name of the service catalog product that is provisioned. Defaults to a slugified version of the account name.
     */
    provisionedProductName?: pulumi.Input<string>;
    /**
     * Assigned SSO user settings.
     */
    sso: pulumi.Input<inputs.ControlTowerAwsAccountSso>;
    /**
     * Key-value map of resource tags for the account.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
