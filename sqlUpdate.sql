CREATE TABLE User (
  UID int primary key,
  fName varchar(20),
  lName varchar(20),
  uName varchar(20),
  password varchar(30),
  email varchar(40)
);

CREATE TABLE Task (
  TID int primary key,
  shortDesc varchar(max),
  longDesc  varchar(max),
  devBranch varchar(40),
  dateCreated date,
  dueDate date,
  completed bit,
  UID int not null,
  foreign key (UID) references User(UID)
);

CREATE TABLE Entry (
  EID int not null,
  UID int not null,
  TID int not null,
  description varchar(max),
  dateCreated date,
  timeCreated time,
  foreign key (UID) references User(UID),
  foreign key (TID) references Task(TID),
  primary key (EID, UID, TID)
);
