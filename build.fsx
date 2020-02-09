#r "paket:
nuget Fake.DotNet.MSBuild
nuget Fake.DotNet.Testing.XUnit2
nuget Fake.IO.FileSystem
nuget Fake.Core.Target //"

#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.DotNet.Testing.XUnit2
open Fake.DotNet



let buildDir = "./out/this/"
let testDir = "./out/tests/"

// Target Definitions

Target.create "Clean" (fun _ ->
  Shell.cleanDir buildDir
)

Target.create "BuildThis" (fun _ ->
  !! "src/**/*.csproj"
    |> MSBuild.runRelease id buildDir "Build"
    |> Trace.logItems "ThisBuild-Output: "
)

Target.create "BuildTest" (fun _ ->
  !! "tests/**/*.csproj"
    |> MSBuild.runDebug id testDir "Build"
    |> Trace.logItems "TestBuild-Output: "
)

Target.create "Test" (fun _ ->
    !! (testDir + "Tests*.dll")
    |> run (fun p -> { p with HtmlOutputPath = Some (testDir + "results.html") })
)

Target.create "Default" (fun _ ->
  Trace.trace "Hello World from FAKE"
)

// Dependencies

open Fake.Core.TargetOperators

"Clean"
 ==> "BuildThis"
 ==> "BuildTest"
 ==> "Test"
 ==> "Default"

// start build
Target.runOrDefault "Default"