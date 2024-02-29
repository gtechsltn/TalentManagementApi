This repository houses the .NET Core C# Web API source code, an integral part of the [Building a Talent Management SPA with Angular 17 and .NET Core 8 Tutorial Series](https://medium.com/scrum-and-coke/building-a-talent-management-spa-with-angular-17-and-net-core-8-tutorial-series-f28f0edc9069).  It's designed to provide a comprehensive guide for developing a Single Page Application (SPA) focused on talent management. The source code and instructions within are tailored for those who wish to learn or enhance their skills in modern web application development using these technologies.

# Prerequisites
Visual Studio 2022: The project is developed and tested in Visual Studio 2022. Ensure you have this version installed to guarantee compatibility.
.NET Core 8 SDK: This is required to build and run the .NET Core Web API.

# Installation and Setup

## Clone the Repository
Start by cloning this repository to your local machine.

## Open the Project
Open the cloned project in Visual Studio 2022.

## Restore Dependencies
Use the built-in NuGet Package Manager to restore any missing dependencies.

## Build the Solution
Compile the solution to ensure everything is set up correctly.

## Run the API
Start the Web API to begin serving requests.

# Features
The project includes several key features, demonstrating the capabilities of a modern SPA in talent management:

## Employee Management 
Implements functionalities for listing, searching, sorting, and paginating employees.

## Position Management 
Tools for managing various positions within an organization.

## Responsive UI 

A front-end designed with Angular 17, showcasing a responsive and user-friendly interface.

## API Integration 
Demonstrates effective communication between the Angular frontend and the .NET Core backend.

# Contributing
Contributions to enhance the project are welcome. Please follow the standard fork-and-pull request workflow. Make sure to adhere to coding standards and provide adequate documentation for your contributions.

# Deploy

## Application Pool
+ Name: Angular17
+ Physical Path: C:\inetpub\wwwroot\Angular17
+ .NET CLR version: No Managed Code
+ Managed pipeline mode: Integrated
+ Start application pool immediately: Checked
+ IIS Web Deploy: IISProfile.pubxml

## Website
+ Server: localhost
+ IIS application: Angular17
+ User: ADMIN
+ Pass: Password

### IISProfile.pubxml

+ File Path: ..\TalentManagementApi.WebApi\Properties\PublishProfiles\IISProfile.pubxml
+ File Content

```
<?xml version="1.0" encoding="utf-8"?>
<!--
https://go.microsoft.com/fwlink/?LinkID=208121.
-->
<Project>
  <PropertyGroup>
    <WebPublishMethod>MSDeploy</WebPublishMethod>
    <LaunchSiteAfterPublish>true</LaunchSiteAfterPublish>
    <LastUsedBuildConfiguration>Release</LastUsedBuildConfiguration>
    <LastUsedPlatform>Any CPU</LastUsedPlatform>
    <SiteUrlToLaunchAfterPublish>https://localhost</SiteUrlToLaunchAfterPublish>
    <ExcludeApp_Data>false</ExcludeApp_Data>
    <ProjectGuid>ee4fa804-d46e-494b-bc03-82678da2eb7e</ProjectGuid>
    <SelfContained>false</SelfContained>
    <MSDeployServiceURL>localhost</MSDeployServiceURL>
    <DeployIisAppPath>Angular17</DeployIisAppPath>
    <RemoteSitePhysicalPath />
    <SkipExtraFilesOnServer>true</SkipExtraFilesOnServer>
    <MSDeployPublishMethod>InProc</MSDeployPublishMethod>
    <EnableMSDeployBackup>false</EnableMSDeployBackup>
    <EnableMsDeployAppOffline>true</EnableMsDeployAppOffline>
    <UserName>ADMIN</UserName>
    <_SavePWD>true</_SavePWD>
    <_TargetId>IISWebDeploy</_TargetId>
  </PropertyGroup>
</Project>
```

![Publish WebApi](https://github.com/gtechsltn/TalentManagementApi/assets/87538251/d8b1dba8-0274-4136-8075-c1a70e2cb506)


## HTTP Error 500.24 – Internal Server Error

https://www.rocktonsoftware.com/knowledge-base/http-error-500-24-internal-server-error/

https://forums.ivanti.com/s/article/Unable-to-access-portal-HTTP-Error-500-24-Internal-Server-Error?language=en_US

# References
+ [Angular 17 and .NET Core 8: CQRS and Mediator Pattern for CRUD Operations in REST API](https://medium.com/scrum-and-coke/angular-17-and-net-core-8-cqrs-and-mediator-pattern-for-crud-operations-in-rest-api-8af8995d2671)
+ [Create Dynamic Sorting in Your .NET API in 5 minutes](https://medium.com/bina-nusantara-it-division/create-dynamic-sorting-in-your-net-api-in-5-minutes-17a0c8c625c8)
+ [EF Core order by string column name](https://dev.to/karenpayneoregon/ef-core-order-by-string-column-name-4549)
