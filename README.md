# NBA-Project


To run the projects please:
- for backend set up the Scoreboard.API as Startup project and run it. It will provide access to the following endpoint http://localhost:5116/api/v1/Game
- for frontend open the terminal and use the command ng serve and open the page http://localhost:4200/


The code does not contain all the required features and may be somewhat ambiguous, especially for the Infrastructure part for the following reasons:

- initially I wanted to collect all the data provided by the api in the request and store them in a sql server database and then use them.
- I thought that maybe this is not the purpose of the request, and that I should use the data only through the API
- the api does not contain the possibility order the data, is limited to filters for seasons and the limit of entities brought per request is a maximum of 25.
- an idea to be able to manipulate the data in order to solve the requirements would have been a constant variable on the application that would keep a list of all the games. To create this variable, a first request would have been needed to obtain the number of pages, after which I would accumulate all the data through an iteration where at each step I would obtain 25 elements. (maximum allowed by api). I don't know if I was too tired last night when I worked, but it didn't seem like a good idea to implement and I abandoned it.
- improvements: taking into account that the matches took place in final seasons that cannot be altered, the most efficient method for display would be a cache containing the first 10 teams (sorted according to the requirement that seemed a bit ambiguous to me, or was it me too tired) for each season with additional information.
- other things I think are missing, interceptions on the front-end, error-handling on the front-end, an api gateway for communication....
