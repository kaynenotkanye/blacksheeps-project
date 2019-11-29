#!/bin/sh
while true
do
        echo "Press CTRL+C to stop the script execution"
        sleep 0.1
        curl -X POST \
          http://localhost:5555/api/playlists \
          -H 'Cache-Control: no-cache' \
          -H 'Content-Type: application/json' \
          -H 'Postman-Token: a025f464-3501-4fbc-a556-51ed1f4abe0c' \
          -d '{
            "Artist": "Maroon 5",
            "Song": "Sugar"
        }'
done
