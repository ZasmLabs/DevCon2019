# Multi-container Microservices Enterprise Application Development using .Net Core 3.0

Most applications today are monoliths. Moving to containers is not about creating Docker images and deploying them on to the cloud. It's about diving code into smaller chunks of logically separate pieces of code. By applying multiple application architecture principles and code refactoring techniques we'll divide the monoliths into separate services. We'll then create separate docker images for each of these pieces of code and along the way learn how to create enterprise-grade applications.

# Why Docker?
Docker is a platform for developers and sysadmins to build, share, and run applications with containers. The use of containers to deploy applications is called containerization. Containers are not new, but their use for easily deploying applications is.

# Why Kubernetes
Containers are a good way to bundle and run your applications. In a production environment, you need to manage the containers that run the applications and ensure that there is no downtime. For example, if a container goes down, another container needs to start. Wouldn’t it be easier if this behavior was handled by a system?

That’s how Kubernetes comes to the rescue! Kubernetes provides you with a framework to run distributed systems resiliently. It takes care of scaling and failover for your application, provides deployment patterns, and more. For example, Kubernetes can easily manage a canary deployment for your system.

### Minikube
Minikube is a tool that makes it easy to run Kubernetes locally.

### Kubectl
Kubectl is a command line interface for running commands against Kubernetes clusters.

# Report Issue
If you find any issue feel free to write to <a href="mailto:opensource@zasmlabs.com">opensource@zasmlabs.com</a>.
