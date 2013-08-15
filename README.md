scriptcs-sample-module
======================

sample scriptcs module

Illustrates a basic scriptcs module which configures a custom file system.

# Testing my fork of scriptcs and the module

## Installing
* Install scriptcs
* Clone this repo.
* Open the solution and build it.
* From the command line create a package: `nuget pack -version 0.1.0-alpha`
* In VS edit your Nuget package sources and add the folder where the package lives.
* Install the package globally: `scripts -install scriptcs.samplemodule -g -pre`
 
## Forcing the module to load using the REPL.
* Run scriptcs forcing the module to load: `scriptcs -loglevel debug -modules csx`
* Check the log output for the messages "Sample module initialized" and "TestFileSystem created".

## Loading the module automatically based on extension.
* Create a boilerplace start.csx i.e. Console.WriteLine("Hello");
* Run scriptcs with your file: `scriptcs start.csx -loglevel debug"
* Check the log output for the messages "Sample module initialized" and "TestFileSystem created".

Note: 
* The "Sample module initialized" is outputted by the module 
* "TestFileSystem created" is outputted by the TestFileSystem override which the module configures. This happens when it is created during resolution.
