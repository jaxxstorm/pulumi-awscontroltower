module github.com/jaxxstorm/pulumi-awscontroltower/provider

go 1.16

require (
	github.com/idealo/terraform-provider-controltower/shim v0.0.0
	github.com/pulumi/pulumi-terraform-bridge/v3 v3.19.0
	github.com/pulumi/pulumi/sdk/v3 v3.37.2
)

replace (
	github.com/hashicorp/terraform-plugin-sdk/v2 => github.com/pulumi/terraform-plugin-sdk/v2 v2.0.0-20211019194827-62530c6537a4
	github.com/idealo/terraform-provider-controltower/shim => ./shim
)
