# ToDoApi-octo-garbanzo

![Travis CI build status](https://travis-ci.org/githubismicrosoft/ToDoApi-octo-garbanzo.svg?branch=master)


[![Quality gate](https://sonarcloud.io/api/project_badges/quality_gate?project=githubismicrosoft_ToDoApi-octo-garbanzo)](https://sonarcloud.io/dashboard?id=githubismicrosoft_ToDoApi-octo-garbanzo)


```
# CI
dotnet sonarscanner begin /d:sonar.login={token} /d:sonar.host.url="https://sonarcloud.io" /k:githubismicrosoft_ToDoApi-octo-garbanzo /o:githubismicrosoft 

dotnet build .

dotnet sonarscanner end  /d:sonar.login={token}


# Local dev messy boilerplate To-do CRUD on localhost:5000. ...
dotnet watch run



```
