# aspnetcore-redis-docker

## Introduction
This is mostly a clean Razor Pages application (created with ```dotnet new razor```), with some additions. Most notably ```services.AddDistributedRedisCache(...)``` in ```ConfigureServices```. A new page ```CachingDemo``` was added to demonstrate basic use of Redis chaching.
Required nuget packages are 
* ```Microsoft.Extensions.Caching.Abstractions```
* ```Microsoft.Extensions.Caching.Redis```

## Prerequisites
The following must be installed:
* git
* docker
* docker-compose

## Steps to run
* Build: ```docker build -t redis-tryout .```
* Run: ```docker-compose up``` or ```docker-compose up -d```
* In a web browser, go to ```server-name:5000``` e.g. ```localhost:5000```
