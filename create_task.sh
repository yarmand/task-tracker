#!/bin/bash

# example usage:
# user=yarmand task='test task'  time=$(date +%Y-%m-%d %H-%M-%S) tags="['test']" ./create_task.sh

curl -i \
     -H 'Accept: application/json' \
     -H 'X-HTTP-Method-Override: PUT' \
     -H 'content-type: application/json' \
     -X POST \
     -d "{ \
     \"user\": \"${user}\", \
     \"task\": \"${task}\", \
     \"time\": \"${time}\", \
     \"tags\": \"${tags}\" \
   }" \
   'https://ttracker.azurewebsites.net/api/createTask?code=W2cuVKYwDijvvAhE/FZQf71huFJbsSrmmfXYatMBJ4Ny/YUVxKSgyQ=='

