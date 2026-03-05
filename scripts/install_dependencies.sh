#!/bin/bash

echo "Installing .NET runtime"

sudo rpm -Uvh https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm

sudo yum install -y dotnet-runtime-6.0
