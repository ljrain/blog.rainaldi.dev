// The following environment variables need to be set for Publish target:
// NETLIFY_TOKEN

#tool "nuget:https://api.nuget.org/v3/index.json?package=Wyam&version=2.0.0"
#addin "nuget:https://api.nuget.org/v3/index.json?package=Cake.Wyam&version=2.0.0"


//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Build")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Recipe = "Blog",
            Theme = "CleanBlog",
            UpdatePackages = true
        });        
    });
    
Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Recipe = "Blog",
            Theme = "CleanBlog",
            UpdatePackages = true,
            Preview = true,
            Watch = true
        });        
    });

Task("Debug")
    .Does(() =>
    {
        DotNetCoreBuild("../Wyam/tests/integration/Wyam.Examples.Tests/Wyam.Examples.Tests.csproj");        
        DotNetCoreExecute("../Wyam/tests/integration/Wyam.Examples.Tests/bin/Debug/netcoreapp2.1/Wyam.dll",
            "-a \"../Wyam/tests/integration/Wyam.Examples.Tests/bin/Debug/netcoreapp2.1/**/*.dll\" -r \"blog -i\" -t \"../Wyam/themes/Blog/CleanBlog\" -p");
    });

    
//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Preview");    
    
Task("BuildServer")
    .IsDependentOn("Build");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
