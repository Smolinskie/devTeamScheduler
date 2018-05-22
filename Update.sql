CREATE TABLE if not exists User (
  UID int auto_increment primary key,
  fName varchar(20),
  lName varchar(20),
  uName varchar(20),
  password varchar(30),
  email varchar(40)
);

CREATE TABLE if not exists Task (
  TID int auto_increment primary key,
  shortDesc varchar(300),
  longDesc  varchar(1000),
  devBranch varchar(40),
  dateCreated date,
  dueDate date,
  completed bit,
  UID int not null,
  foreign key (UID) references User(UID)
);

CREATE TABLE if not exists Entry (
  EID int not null auto_increment,
  UID int not null,
  TID int not null,
  description varchar(1000),
  dateCreated date,
  timeCreated time,
  foreign key (UID) references User(UID),
  foreign key (TID) references Task(TID),
  primary key (EID, UID, TID)
);
