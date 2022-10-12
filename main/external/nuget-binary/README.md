 Temporary repo to hold nuget binaries for use with DotDevelop  
 
License: Apache License 2.0 (see NuGet-LICENSE.txt for details)  

This folder was initially an external repo as described above, and was forked into DotDevelop from the original MonoDevelop one at https://github.com/mono/nuget-binary.  

Since MonoDevelop was archived there have been no commits since 1-Dec-2018, and there seems to be no reason to continue keeping the contents as a submodule of DotDevelop.  

The advantage of changing it to a standard folder would then allow any changes to its contents - for example, updates to later releases of NuGet.Client (https://github.com/nuget/nuget.client) to be under the version control of the main  DotDevelop repo.  
It is being retained in the `main/external/nuget-binary` to minimise changes to the rest of the DotDevelop repo.
