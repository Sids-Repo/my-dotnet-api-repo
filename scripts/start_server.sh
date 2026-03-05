#!/bin/bash

echo "Starting application"

cd /home/ec2-user/app

nohup dotnet sample-api.dll --urls=http://0.0.0.0:5000 > app.log 2>&1 &
