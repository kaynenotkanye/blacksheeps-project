#!/bin/bash
while true
do
        echo "Press CTRL+C to stop the script execution"
        sleep 0.1
        curl -X GET \
          http://localhost:5555/api/playlists \
          -H 'Cache-Control: no-cache' \
          -H 'Postman-Token: 40bbcadd-c5fe-43da-8c4f-fb89bc63f9b8'
done
