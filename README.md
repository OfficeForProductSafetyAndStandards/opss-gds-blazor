# GOV.UK Design System Frontend Razor Components

## About
GOV.UK Blazor Frontend contains the components you need to start building a user interface for government platforms and services in Blazor.

It is based on: 
- the [GOV.UK Design System](https://design-system.service.gov.uk/), and, 
- the [MOJ Design System](https://design-patterns.service.justice.gov.uk/).

## Installation
Nuget package: [Opss.DesignSystem.Frontend.Blazor.Components](https://www.nuget.org/packages/Opss.DesignSystem.Frontend.Blazor.Components/)

Please refer to the nuget package page for installation instructions.

## Dependencies
Currently, the components are compatible with
- .NET 8.0
- and the following node packages:
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

Please refer to the [showcase project](/Opss.DesignSystem.Frontend.Blazor.Showcase) for examples of how to use the components.

## Components
For a full list of components please refer to the [components project](/Opss.DesignSystem.Frontend.Blazor.Components) on Github.

## Tests
The components are tested using the [BUnit](https://bunit.dev/) testing framework. The tests can be found in the [test project](/Opss.DesignSystem.Frontend.Blazor.UnitTests).

## Contributing
Contributions are welcome! Please open an issue or submit a pull request.
