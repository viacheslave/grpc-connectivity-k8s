# Sample GRPC service and client for connectivity testing in Kubernetes

## Purpose

To test gRPC client-server connectivity in Kubernetes clusters.

## Functionality

Built from Microsoft Greeter examples.
.NET Core 3.1.

## Usage

- Build service and client from Dockerfiles.
- Deploy to Kubernetes using YML deployment files.
- From inside the client, run `./GrpcClient http://<POD_IP>`: the client should make a few call to the service.
