#!/bin/bash
azure group create Cloud-Migration-Group "West Europe" 

azure group deployment create Cloud-Migration-Group WebSite-Net-Deployment -y Microsoft.WebSite.0.2.5-preview -e "website-net-parameters.json"
azure group deployment create Cloud-Migration-Group WebSite-Java-Deployment -y Microsoft.WebSite.0.2.5-preview -e "website-java-parameters.json"
azure group deployment create Cloud-Migration-Group WebSite-Node-Deployment -y Microsoft.WebSite.0.2.5-preview -e "website-node-parameters.json"
azure group list