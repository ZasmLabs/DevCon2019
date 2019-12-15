# Commands used
#### Pull Docker Image - .Net Core Runtime
```pull docker images
$ docker pull mcr.microsoft.com/dotnet/core/runtime
```

#### Check running docker containers
```docker containers
$ docker ps
````

#### Check exited/completed docker containers
```check exited docker containers
$ docker ps -a
```

##### Build docker images
```
$ docker build .
```

#### Build docker images and tag them
``` images with tags
$ docker build -t zasmlabs/consoleapp .
```

#### Build docker images from a custom Dockerfile
````custom dockerfile
$ docker build -f Dockerfile.frontend -t zasmlabs/consoleapp .
````

#### Start run a custom command in docker
````
$ docker exec mcr.microsoft.com/dotnet/core/runtime echo hello, world
````

#### Start a shell inside docker image
````
$ docker exec -i -t alpine sh
````

#### Check docker images available locally
````
$ docker images
````

#### Docker-compose file
````
version: "3"
services:
   consoleapp:
      build: 
        context: .
        dockerfile: ./Dockerfile.frontend
````


#### Multi-container docker file
````
version: "3"
services:
   webapi:
      build: 
        context: .
        dockerfile: ./Dockerfile.backend
      ports:
         - "8080:80"
   consoleapp:
      build: 
        context: .
        dockerfile: ./Dockerfile.frontend
````

#### Start multi-container docker-compose file
````
$ docker-compose up
````

#### Stop multi-container docker-compose file
````
$ docker-compose down
````

#### Start a kubernetes cluster
```
$ minikube start
````

#### Stop a kubernetes cluster
````
$ minikube stop
````

#### Get IP of the kubernetes cluster
````
$ minikube ip
````

#### Get cluster information
````
$ kubectl cluster-info
````

#### Setup an environment
````
$ kubectl apply -f webapi.yaml
````

#### Desribe Kubernetes cluster
````
$ kubectl describe deployments --all
````

#### View Pods
````
$ kubectl get pods
````

#### View Network
````
$ kubectl get svc
````

#### View Pods and Serivces
````
$ kubectl get pods,svc
````

#### Delete Kubernetes deployment
````
$ kubectl delete deployment --all
````

#### Delete kubernetes pods
````
$ kubectl delete pods --all
````

#### Delete kubernetes services
````
$ kubectl delete svc --all
````