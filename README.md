# Sample GRPC service and client for connectivity testing in Kubernetes

## Functionality

Built from Microsoft Greeter examples. 

## Usage

- Build service and client from Dockerfiles.
- Deploy to Kubernetes using YML deployment files.
- From inside the client, run `./GrpcClient http://<POD_IP>`: the client should make a few call to the service.