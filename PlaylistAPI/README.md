Playlist API
========

### Build
To build the containers:
```bash
cd PlaylistAPI
./build.sh
```

### Deploy
To deploy/run the containers:
```bash
cd PlaylistAPI
./startup.sh
```

### Generating load to the containers
To generate load to the API, there are a couple helper scripts. The `POST` script will generate writes to the database. The `GET` script will generate reads to the database.
```bash
cd PlaylistAPI
./keepGetting-PlaylistAPI.sh
./keepPosting-PlaylistAPI.sh
```

### Cleanup
WARNING: This cleanup script will clean up all docker containers and volumes on your host. (This may not be intended if you have other docker containers running on your system.  When you are all done with testing and want to perform some cleanup for Docker, run the `docker-cleanup.sh` script.  The assumption here is that you want to clean up all Docker stuff on the host.
