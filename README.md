# MovieManiacs

<h3><b>How to set up the project?</b></h3>

The project contains two parts front-end(angular.js) and back-end C# part. 
First of all, after cloning the repo from git, try to build the whole solution.
If the build succeed after restoring all of the needed packages, you are lucky :).
If the restoring of missing packages do not start check Tools->Options-> NuGet Package Manager
the two checkboxes should be checked. If they are not check them and try rebuilding the solution. 

<h4>Restoring of packages is still not running?</h4> 
Check if you have <b>packages</b> folder in current directory of the solution?
If yes delete it and try rebuilding. 

Also restore needed database<b>(MovieManiacs.bak)</b>, and if your
sql server has different name
than '.' set every datasource attribute
(placed in connection string tag in all Web.config and app.config files)
with <i>"YOURMACHINENAME\YOURSERVERNAME"</i>.

The first project-<b>MoviesProject</b> may be hosted separately on IIS or can be run from Visual Studio 2015.
Every instance of it contains angular based requests to Web API(MovieManiacs project).
After successful build of the solution try starting <b>MovieManiacs</b> from VS (or host and start it) ,
start <b>WCFDatabaseProvider</b> too. Then you might be able to use the functionalities provided in the client,
which sends requests to the <b>REST api</b> ,which uses <b>WCF Service(SOAP)</b> to access
and execute CRUD operations to the database. 

Another API (MovieManiacs.Notifier) is used for sending and scheduling notifications via <b>smtp.gmail</b> service. It uses WCFDataProvider to iterate with the database.

<h4>Hosting in IIS</h4>
The WCF and the Notifier should be hosted as new Websites with application pools identity: NetworkService. Also if you do not have sql server login with <b>NT AUTHORITY\NETWORK SERVICE</b> you should create one with usermapping property of the database you use set to db owner. The WebUI(angular based site) and the Web API(REST) should be hosted with app pool identity set to ApplicationPoolIdentity(the default one). All of the four websites shoul be configured to use .NetFramework 4.0.

