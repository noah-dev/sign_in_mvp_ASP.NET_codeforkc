# sign_in_mvp_ASP.NET_codeforkc

Based on a [standalone AngularJS app](https://github.com/noah-dev/sign_in_mvp_codeforkc/tree/master), this app a modified version of the AngularJS app and integrates it into an ASP.NET project. ASP.NET will serve the app, and posses a Web API to interact with the front-end. A demo is shown below, showing the app and it's interaction with the databases.*

![](https://github.com/noah-dev/sign_in_mvp_ASP.NET_codeforkc/blob/master/demo.gif)

As shown above, the app is able to pull records from the Members table and then records sign ins to the SignIns table. 


## *Wait, why two databases? 
Because I am very inexperienced with ASP.NET; database migrations are still on the learning list. As consequence, this issue is just one among several; the project's C# code is sloppy, and the Front-end had to incorporate ugly work-arounds to hook up to the backend. 

But that is to be expected for my first project; I started with knowing nothing about C# and this is just a warm up. Between this and other responsibilities, I am satisfied with my first ASP.NET project.
