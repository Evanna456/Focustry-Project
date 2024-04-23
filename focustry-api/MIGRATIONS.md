### TEMP-MIGRATIONS

CREATE TABLE users(
   id BIGINT UNSIGNED AUTO_INCREMENT,  
   role_id INT UNSIGNED,
   firstname VARCHAR(100),
   lastname VARCHAR(100),
   username VARCHAR(15),
   password VARCHAR(255),
   remember_token VARCHAR(20),
   remember_token_expiry TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
   primary key(id)
);

CREATE TABLE sessions(
   username VARCHAR(15),
   token VARCHAR(100),
   created_at TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE = MEMORY;


CREATE TABLE groups(
   id BIGINT UNSIGNED AUTO_INCREMENT,  
   name VARCHAR(100),
   primary key(id)
);

CREATE TABLE groups_members(
   id BIGINT UNSIGNED AUTO_INCREMENT,  
   name VARCHAR(100),
   primary key(id)
);


CREATE TABLE threads(
   id BIGINT UNSIGNED AUTO_INCREMENT,  
   group_id INT UNSIGNED,
   thread 
   foreign key (group_id) REFERENCES groups(id)
   primary key(id)
);