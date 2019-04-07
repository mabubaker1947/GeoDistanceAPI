# GeoDistanceAPI
A web API built in .Net core that takes in geo coordinates of two different cities/locations and reverts back with a distance in between both.


# How it Works:

GeoDistanceAPI is built on .Net Core. Given the coordinates of two cities:

53.297975, -6.372663

41.385101, -81.440440
Application receives this information as input and returns the distance between these two cities/points in Km.


# PostMan Invocation:
As you run the application in IIS Express or Google Chrome it would be running on a port that is made available by OS: for-example port 63234 was made available for me by my OS at the time of development.
http://localhost:63234/api/Geodistanceapi

and pass the body as a JSON object in a POST request:

{  
   "locationA":{"Latitude": 53.297975,  "Longitude": -6.372663},
   "locationB":{"Latitude": 41.385101,  "Longitude": -81.440440}
}

## output:
The output for these cordinates is 5536.33868226669 km.
