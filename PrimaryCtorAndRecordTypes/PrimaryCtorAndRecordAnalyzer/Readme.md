# Roslyn Analyzers for Primary Constructors and Named Parameters for Records

Two analyzers to enhance the use of Primary Constructors and Record types in C# 12 

## Content
### PrimaryCtorAndRecordTypes
A .NET Standard project with implementations of two analyzers.
**You must build this project to see the results (warnings) in the IDE.**

- [DoNotReassignPrimaryConstructorParameterAnalyzer.cs](DoNotReassignPrimaryConstructorParameterAnalyzer.cs): An analyzer that marks reassignment of parameters in pctor as errors.
- [RecordTypesMustHaveNamedParametersAnalyzer.cs](RecordTypesMustHaveNamedParametersAnalyzer.cs): An analyzer that warns if positional arguments are used when constructing records.

### PrimaryCtorAndRecordTypes.Sample
A project that references the analyzers. Note the parameters of `ProjectReference` in [PrimaryCtorAndRecordTypes.Sample.csproj](../PrimaryCtorAndRecordTypes.Sample/PrimaryCtorAndRecordTypes.Sample.csproj), they make sure that the project is referenced as a set of analyzers. 

## How To?
### How to debug?
- Use the [launchSettings.json](Properties/launchSettings.json) profile.

### How can I determine which syntax nodes I should expect?
Consider installing the Roslyn syntax tree viewer plugin [Rossynt](https://plugins.jetbrains.com/plugin/16902-rossynt/).

### Learn more about wiring analyzers
The complete set of information is available at [roslyn github repo wiki](https://github.com/dotnet/roslyn/blob/main/docs/wiki/README.md).