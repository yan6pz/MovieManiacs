# MovieManiacs

<h3><b>How to set up the project?</b></h3>

The project contains two parts front-end(angular.js) and back-end C# part. 
First of all, after cloning the repo from git, try to build the whole solution.
If the build succeed after restoring all of the needed packeges, you are lucky :).
If the restoring of missing packages do not start check Tools->Options-> NuGet Package Manager
the two checkboxes should be checked. If they are not check them and try rebuilding the solution. 

<h4>Restoring of packeges is stil not running?</h4> 
Check if you have <b>packeges</b> folder in current directory of the solution?
If yes delete it and try rebuilding. If no... pray God for help.

Also restore needed database<b>(MovieManiacs.bak)</b>, and if your
sql server has different name
than '.' set every datasource attribute
(placed in connection string tag in all Web.config and app.config files)
with <i>"YOURMACHINENAME\YOURSERVERNAME"</i>.

The first project-<b>MoviesProject</b> may be hosted separately on IIS or can be ran from Visual Studio 2015.
Every instance of it contains angular based requests to Web API(MovieManiacs project).
After successful build of the solution try start MovieManiacs from VS (or host and start it) ,
start WCFDatabaseProvider too. Then you might be able to use the functionalities provided in the client,
which sends requests to the REST api ,which uses WCF Service(SOAP) to access
and execute CRUD operations to the database. 



