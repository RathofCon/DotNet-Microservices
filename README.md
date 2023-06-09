Les wrote his application in .Net 5. This version has been updated for .Net 7
At this point, the CommandService and PlatformService has been created and working together.
The Docker file and Kubenetes files have been created but not tested

Eventually the In Memory database will be replaced by SQL Server or Oracle instance.

.NET Microservices
Les Jackson
Youtube video: https://www.youtube.com/watch?v=DgVjEo3OGBI&t=6079s

In this step-by-step tutorial I take you through an introduction on building microservices using .NET. As the name suggests we build everything completely from start to finish –with the full scope of the course outlined in the time-stamp section below. However, at a high-level we’ll cover:

• Building two .NET Microservices using the REST API pattern
• Working with dedicated persistence layers for both services
• Deploying our services to Kubernetes cluster
• Employing the API Gateway pattern to route to our services
• Building Synchronous messaging between services (HTTP & gRPC)
• Building Asynchronous messaging between services using an Event Bus (RabbitMQ)
