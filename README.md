scriptcs-sample-module
======================

sample scriptcs module

Illustrates a basic scriptcs module which configures a custom file system.

# Testing my fork of scriptcs and the module

## Installing
* Install scriptcs from my fork (https://github.com/glennblock/scriptcs) and pull from branch 346.
* Run the build script.
* Open VS and add your "scriptcs/artifacts/debug" folder to your sources.
* Clone this repo.
* Open the solution and build it.
* From the command line create a package: `nuget pack -version 0.1.0-alpha`
* Copy the created package 'Scriptcs.SampleModule.0.1.0-alpha.nupkg' into "scriptcs/artifacts/debug"
* Install the package globally: `scripts -install scriptcs.samplemodule -g -pre`
 
## Forcing the module to load using the REPL.
* Run scriptcs forcing the module to load: `scriptcs -loglevel debug -modules csx`
* Check the log output for the messages "Sample module loaded" and "Sample module created".

## Loading the module automatically based on extension.
* Create a boilerplace start.csx i.e. Console.WriteLine("Hello");
* Run scriptcs with your file: `scriptcs start.csx -loglevel debug"
* Check the log output for the messages "Sample module loaded" and "Sample module created".
