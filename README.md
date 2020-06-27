# NETCore3.1-Udemy-MicroservicesRabbitMQ

## Course
Udemy Course
https://www.udemy.com/course/getting-started-net-core-microservices-rabbitmq/learn/lecture/15857804?start=0

## Objective
Develop a microservice project with .NetCore using Clean-Architecture, CQRS and RabbitMQ.


## Structure Folder
- Domain
  - Bus
  - Commands
  - Events  
- Infra.Bus
  - * RabbitMQBus (Class)
- Infra.IoC
  - * Dependency Container(class)
- Microservices
  - Banking (Service 1)
    - DDD with Clean Code Project
      - API
      - Application
      - Data
      - Domain
  - Transfer (Service 2)
    - DDD with Clean Code Project
      - API
      - Application
      - Data
      - Domain
- Presentation
  - Services (Proxy)
  - Controllers
  - Views
  - Models (ViewModel and DTO)
  
  
  
## Setup RabbitMQ
* This project was deeloped on Linux Mint 19.3

## Tutorial used to install RabbitMQ on Linux Mint 19.3
https://www.fosslinux.com/6339/how-to-install-rabbitmq-server-on-ubuntu-18-04-lts.htm

### Installation Steps:

> #### update ubuntu repositories
> $ sudo apt-get update
> #### add signing key
> $ wget -O - "https://github.com/rabbitmq/signing-keys/releases/download/2.0/rabbitmq-release-signing-key.asc" | sudo apt-key add -
> #### create rabbitmq repository file.
> $ sudo vim /etc/apt/sources.list.d/bintray.rabbitmq.list
> #### add following repositories to file(edit-file).
> deb https://dl.bintray.com/rabbitmq-erlang/debian bionic erlang
> deb https://dl.bintray.com/rabbitmq/debian bionic main
> #### run Repository Update.
> $ sudo apt-get update
> #### install RabbitMQ Server.
> $ sudo apt-get install rabbitmq-server
> #### check RabbitMQ Server Status.
> $ sudo systemctl status rabbitmq-server.service
> #### if RabbitMQ is not running, then start service with this command:
> $ sudo systemctl start rabbitmq-server.service
> #### enable RabbitMQ service on system boot.
> $ sudo systemctl enable rabbitmq-server


### Allow RabbitMQ Management UI Through Firewall:

> #### RabbitMQ management console runs on port 15672 and it needs to be granted permission via the firewall.
> $ sudo ufw allow 15672
> #### take a look at all the RabbitMQ plugins that are available.
> $ sudo rabbitmq-plugins list
> #### enable the RabbitMQ Management plugin
> $ sudo rabbitmq-plugins enable rabbitmq_management
> #### create and add a new Admin user to access Management 
> #### Here we create a user with username ‘admin’ and password is also ‘admin’. But I would recommend using a strong password for security.
> $ sudo rabbitmqctl add_user admin admin
> #### tag our user ‘admin’ as ‘administrator’
> $ sudo  rabbitmqctl set_user_tags admin administrator

### Services
> #### restart RabbitMQ service
> $ sudo systemctl restart rabbitmq-server.service
> #### check the ports on the server
> $ sudo netstat -tunlp
> 
> #### access the dashboard http://localhost:15672 or http://13.236.85.236:15672
> 
> #### stop rabbitmq
> $ sudo rabbitmqctl stop_app
> #### reset rabbitmq
> $ sudo rabbitmqctl reset
> #### start rabbitmq
> $ sudo rabbitmqctl start_app
-----------------------------

### User
> #### add user and password
> $ sudo rabbitmqctl add_user test test
> #### set tag [administrator]
> $ sudo rabbitmqctl set_user_tags test administrator
> #### set permmissions read and write
> $ sudo rabbitmqctl set_permissions -p / test ".*" ".*"

