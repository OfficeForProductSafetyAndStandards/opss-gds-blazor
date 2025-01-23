# Opss.DesignSystem.Frontend.Blazor.Components

## About
GOV.UK Blazor Frontend contains the components you need to start building a user interface for government platforms and services in Blazor.

It is based on: 
- the [GOV.UK Design System](https://design-system.service.gov.uk/), and, 
- the [MOJ Design System](https://design-patterns.service.justice.gov.uk/).

## Dependencies
Beyond the .NET dependencies (which you can find in the relevant section of the nuget page) this component also uses the following node packages (contained within):
- govuk-frontend: 5.7.1
- @ministryofjustice/frontend: 3.0.3

## Usage

1. Add the following namespace to your `_Imports.razor` file:

    ```razor
    @using Opss.DesignSystem.Frontend.Blazor.Components
    ```

2. You can now use the components in your Blazor pages. For example:

    ```razor
    <GdsButton Text="Click me" />
    ```

Please refer to the [showcase project](https://github.com/OfficeForProductSafetyAndStandards/opss-gds-blazor/tree/develop/Opss.DesignSystem.Frontend.Blazor.Showcase) for examples of how to use the components.

## Components
For a full list of components please refer to the [components project](https://github.com/OfficeForProductSafetyAndStandards/opss-gds-blazor/tree/develop/Opss.DesignSystem.Frontend.Blazor.Components) on Github.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request.