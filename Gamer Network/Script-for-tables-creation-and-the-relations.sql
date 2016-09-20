create table Members(
email varchar(50) primary key ,
password_user varchar(20),
preferred_game_genre varchar(20)
);

create table Normal_Users(
primary key (email),
first_name varchar(30),
last_name varchar(30),
date_of_birth date not null,
age as (year(current_timestamp)-year(date_of_birth)),
email varchar(50) foreign key references Members on update cascade on delete cascade
);

create table Normal_Users_add_friend_Normal_Users(
primary key (email1,email2),
accept bit,
email1 varchar(50) foreign key references Normal_Users ,
email2 varchar(50) foreign key references Normal_Users ,

);

create table Normal_Users_Message_between_Users_Normal_Users(
primary key(message_id, sender, reciever),
message_id int identity,
date_sent smalldatetime not null,
content varchar(100),
sender varchar(50) foreign key references Normal_Users ,
reciever varchar(50) foreign key references Normal_Users 
);

create table Development_Teams(
primary key (email),
team_name varchar(50),
company varchar(20),
formation_date date,
email varchar(50) foreign key references Members on update cascade on delete cascade
);

create table Verified_Reviewers(
primary key (email),
first_name varchar(50),
last_name varchar(50),
years_of_experience int,
email varchar(50) foreign key references Members on update cascade on delete cascade
);

create table Communities(
Theme varchar(30) primary key,
name varchar(30),
description_of_theme varchar(100)
);

create table Communities_create_Normal_Users(
primary key(theme,normal_user),
accept bit,
theme varchar(30) foreign key references Communities on update cascade on delete cascade,
normal_user varchar(50) foreign key references Normal_Users on update cascade on delete cascade
);

create table Communities_join_Members(
primary key(theme,normal_user),
theme varchar(30) foreign key references Communities on update cascade on delete cascade,
normal_user varchar(50) foreign key references Members on update cascade on delete cascade
);

create table Comunities_Topic_Members(
primary key(topic_id,theme),
topic_id int identity,
Title varchar(50),
description_text varchar(50),
theme varchar(30) foreign key references Communities on update cascade on delete cascade,
member_id varchar(50) foreign key references Members on update cascade on delete cascade
);

create table Members_Topic_Comment_Topic(
primary key(comment_id,theme,topic_id),
comment_id int identity,
content varchar(50),
date_of_comment date,
theme varchar(30),
topic_id int,
foreign key(topic_id,theme) references Comunities_Topic_Members(topic_id,theme),
member_id varchar(50) foreign key references Members 
);

create table Conferences(
conference_id int primary key identity,
name varchar(50),
startdate date, 
enddate date,
duration_of_conference AS datediff(hh,startdate,enddate),
venue varchar(50)
);

create table Conferences_Attend_Members(
primary key(email,conference_id),
email varchar(50) foreign key references Members on update cascade on delete cascade,
conference_id int foreign key references Conferences on update cascade on delete cascade
);

create table Conferences_Conference_Reviews_Members(
primary key (conference_review_id,conference_id),
conference_review_id int identity ,
title varchar(50),
contents varchar(50),
date_of_review date,
conference_id int foreign key references Conferences on update cascade on delete cascade,
email varchar(50) foreign key references Members on update cascade on delete cascade
);

create table Conference_Review_Conference_Reviews_Comment_Members(
primary key (conference_review_comment_id,conference_review_ID,conference_ID),
conference_review_comment_id int identity,
content varchar(50),
conference_ID int ,
conference_review_ID int ,
foreign key (conference_ID,conference_review_ID)references Conferences_Conference_Reviews_Members(conference_review_id,conference_id) ,
email varchar(50) foreign key references Members on update cascade on delete cascade
);

create  table Games(
game_id int primary key identity,
name varchar(50) ,
release_date date,
rating int,
age_limit int,
development_team_email varchar(50) foreign key references Development_Teams on update cascade on delete cascade,
release_conference int foreign key references Conferences on update cascade on delete cascade
);

create table Screenshots(
primary key(screenshot_id,game_id),
screenshot_id int identity,
description_text varchar(50),
date_of_screenshot date,
game_id int foreign key references Games on update cascade on delete cascade,
);

create table Videos(
primary key(video_id,game_id),
video_id int identity,
description_text varchar(50),
date_of_video date,
game_id int foreign key references Games on update cascade on delete cascade,
);

create table Action_Games(
primary key (game),
sub_genre varchar(50),
game int foreign key references Games on update cascade on delete cascade
);

create table Strategy_Games(
primary key (game),
Real_time bit,
game int foreign key references Games on update cascade on delete cascade
);

create table Sport(
primary key (game),
type_of_sport varchar(50),
game int foreign key references Games on update cascade on delete cascade
);

create table RPG(
primary key (game),
story_line varchar(100),
PvP bit,
game int foreign key references Games on update cascade on delete cascade
);
create table Games_Rate_Members(
primary key (rate_id,game_id),
rate_id int identity,
graphics int,
interactivity int,
uniqueness int,
level_design int,
check(graphics >=0 and graphics<=10),
check(interactivity >=0 and interactivity<=10),
check(uniqueness >=0 and uniqueness<=10),
check(level_design >=0 and level_design<=10),
total_rate as (graphics+interactivity+uniqueness+level_design)/4,
game_id int foreign key references Games ,
member_email varchar(50) foreign key references Members on update cascade on delete cascade
);

create table Games_Game_Reviews_Verified_Reviewers(
game_review_id int identity,
content varchar(50),
date_of_review date,
game int foreign key references Games,
veirified_reviewer varchar(50) foreign key references Verified_Reviewers on update cascade on delete cascade,
primary key(game_review_id,game),
); 

create table Game_Reviews_Game_Review_Comments_Members(
comment_id int identity,
content varchar(50),
game_review int,
game_id int,
foreign key(game_review,game_id) references Games_Game_Reviews_Verified_Reviewers(game_review_id,game),
primary key(comment_id,game_review),
);

create table Conferences_Presents_Development_Teams_Games(
primary key (development_team_ID,conference_id),
conference_id int foreign key references Conferences,
development_team_ID varchar(50) foreign key references Development_Teams ,
game_id int foreign key references Games on update cascade on delete cascade  
);

create table Games_Recommended_Normal_Users(
primary key (normal_user_id1,normal_user_id2,game_id),
normal_user_id1 varchar(50) foreign key references Normal_Users ,
normal_user_id2 varchar(50) foreign key references Normal_Users ,
game_id int foreign key references Games on update cascade on delete cascade, 
);

create table System_Administrators(
Admin_id int primary key identity,
email varchar(50),
first_name varchar(50),
last_name varchar(50)
);

create table Development_Teams_Verify_System_Administrators(
primary key(admin_id,users_id),
verify bit,
admin_id int foreign key references System_Administrators on update cascade on delete cascade,
users_id varchar(50) foreign key references Development_Teams on update cascade on delete cascade
);

create table System_Administrators_Verify_Verified_Reviewers(
primary key(admin_id,users_id),
verify bit,
admin_id int foreign key references System_Administrators on update cascade on delete cascade,
users_id varchar(50) foreign key references Verified_Reviewers on update cascade on delete cascade
);




