      /*---1 Sign up by providing my email, password, preﬀered game genre and the type of my membership (normal user, veriﬁed reviewer or a development team)*/
--1
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
CREATE PROC signUp1
@email varchar(50),
@password varchar(20),
@preferredgame varchar(20)
AS
INSERT INTO Members(email,password_user,preferred_game_genre)
VALUES(@email,@password,@preferredgame)

create proc insertNormalUser
@first varchar(30),
@last varchar(30),
@date date,
@email varchar(50)
as
insert into Normal_Users (first_name,last_name,date_of_birth,email) values(@first,@last,@date,@email)

create proc insertVerifiedReviewer
@first varchar(50),
@last varchar(50),
@exp int,
@email varchar(50)
as
insert into Verified_Reviewers(first_name,last_name,years_of_experience,email)values(@first,@last,@exp,@email)

                          
create proc insertDevelopmentTeam
@name varchar(50),
@company varchar(20),
@date date,
@email varchar(50)
as
insert into Development_Teams (team_name,company,formation_date,email)values (@name,@company,@date,@email)


          ---/*2 Search by name for diﬀerent games, conferences, communities, veriﬁed reviewers and development teams*/  
--2
create proc searchGame
@name varchar(50),
@count int output
as
select @count=count(*)
from Games
where [name]=@name


create proc searchConference
@name varchar(50),
@count int output
as
select @count=count(*)
from Conferences
where [name]=@name


create proc searchCommunity
@name varchar(50),
@count int output
as
select @count=count(*)
from Communities
where [name]=@name



create proc searchVerifiedReviewer
@email varchar(50),
@count int output
as
select @count=count(*)
from Verified_Reviewers
where email=@email


create proc searchDevelopmentTeam
@email varchar(50),
@count int output
as
select @count=count(*)
from Development_Teams
where email=@email
 


                                     /*3 View a game and preview its information */



create proc gameViewinformation
@name varchar(50)
as
select g.name,g.release_date,g.age_limit,d.team_name,ss.description_text as 'screen shot',v.description_text as 'video',gr.content,sg.Real_time,ag.sub_genre,s.type_of_sport,rpg.story_line,rpg.PvP
from Games g inner join Development_Teams d on g.development_team_email=d.email
left outer join Screenshots ss on g.name=ss.game_id
left outer join Videos v on v.game_id =g.name
left outer join Games_Game_Reviews_Verified_Reviewers gr on g.name=gr.game
left outer join Strategy_Games sg on sg.game=g.name
left outer join Action_Games ag on ag.game=g.name
left outer join Sport s on s.game=g.name
left outer join RPG rpg on rpg.game=g.name
where g.name=@name


-



-----/*4 Rate a game based on the following criteria: graphics, interactivity, uniqueness, and level design. */


create proc rateGame
@graphics int,
@interactivity int,
@uniquness int,
@level int,
@game varchar(50),
@member varchar(50)
as
insert into Games_Rate_Members values(@graphics,@interactivity,@uniquness,@level,@game,@member)


 ----/*5 View the overall rating of a game */
                         
create proc average
@id decimal
as
select AVG(total_rate)
from Games_Rate_Members
where game_id=@id
group by game_id

                                  ----/*6 View a list of reviews */

create proc viewRate
@me varchar(50)
as
select * 
from Games_Game_Reviews_Verified_Reviewers r
inner join Games g2 on g2.name=r.game
inner join Verified_Reviewers v on v.email=r.veirified_reviewer
inner join Games_Rate_Members g on g.name=r.game
where g.member_email=@me 

                                 ----/*7 View a conference*/

create proc conferenceView
@con_id varchar(50)
as

select c.conference_id,c.name,c.startdate,c.venue,d.company,g.name as'Game Name'
from Conferences c
inner join Conferences_Presents_Development_Teams_Games cp on c.conference_id=cp.conference_id
inner join Development_Teams d on d.email=cp.development_team_ID
inner join Games g on g.game_id=cp.game_id
where c.name=@con_id





---------/*8 Add a conference to my list of attended conferences*/

create proc insertConferenceAttend
@email varchar(50),
@conf int
as
insert into Conferences_Attend_Members values(@email,@conf)


--------------/*9 Add a conference review to a conference that I have attended*/

create proc insertConferenceReview
@title varchar(50),
@contents varchar(50),
@date date,
@conferenceid int,
@email varchar(50)
as
insert into Conferences_Conference_Reviews_Members values (@title,@contents,@date,@conferenceid,@email)


-------------------/*10 Delete a conference review that I have written*/
create proc deleteConference
@id int,
@email varchar(50)
as
delete 
from Conferences_Conference_Reviews_Members
where @email=email and conference_review_id=@id


--------------------/*11 Join a community*/
create proc joinCommunity
@name varchar(50),
@theme varchar(30)
as
insert into Communities_join_Members values (@theme,@name)


----------------/*12 View a community that I have joined error */


create proc viewCommunity
@theme varchar(50)
as
select C.description_of_theme,C.name,NU.first_name,NU.last_name,CTM.Title 
from Communities C inner join Communities_join_Members CJM on C.Theme=CJM.theme
inner join Comunities_Topic_Members CTM on CTM.theme=C.Theme
inner join Normal_Users NU on CJM.normal_user=NU.email
where @theme=C.Theme


-----------------/*13 Post a topic on a community that I have joined*/

create proc postTopic
@Title varchar(50),
@description_text varchar(50),
@theme varchar(30),
@email varchar(50)
as

insert into Comunities_Topic_Members(Title,description_text,theme,member_id)
values (@Title,@description_text,@theme,@email)

-----------------/*14 Delete a topic that I have posted*/
create proc deleteTopic
@email varchar(50),
@theme varchar(30),
@Topic_id int
as
delete
from Comunities_Topic_Members
where @email=member_id and @theme=theme and @Topic_id=topic_id
    
						  
	/*15 Add a comment on a conference review, a game review, or a topic posted in a community that I have joined*/

	create proc ADDcommconfrence
	@content varchar(50),
	@con_id int,
	@con_review_id int,
	@email varchar(50)
	AS
	insert into Conference_Review_Conference_Reviews_Comment_Members values(@content,@con_id,@con_review_id,@email)

	create proc ADDcommGameReviews
	@content varchar(50),
	@game_review int,
	@game_id varchar(50)
	AS
	insert into Game_Reviews_Game_Review_Comments_Members values(@content,@game_review,@game_id)

	create proc ADDcomTopic
	@content varchar(50),
	@date_of_comment date,
	@theme varchar(50),
	@topic_id varchar(50),
	@me varchar(50)
	AS
	insert Members_Topic_Comment_Topic values(@content,@date_of_comment,@theme,@topic_id,@me)




			           
				/*16 View the list of comments on a conference review, a game review or a topic posted on a community that I have joined*/
--for confrences reviews comments:
create proc List_of_Conreview
@conrew_id int
AS
select content
from Conference_Review_Conference_Reviews_Comment_Members 
where conference_ID=@conrew_id
--for game review comments:
create proc  List_of_gamereview
@gamerew_id int
as
select content
from Game_Reviews_Game_Review_Comments_Members
where game_review=@gamerew_id
--for topic comments:
create proc List_of_topicreview
@topic_id int
as
select content
from Members_Topic_Comment_Topic
where topic_id=@topic_id

  /*17 Delete a comment that I have posted on a conference review, a game review or a topic posted on a community that I have joined*/
  -- delete from confrence review a comment:					  				  
create proc List_of_delconrew
@email varchar(50),
@comment int
AS
delete from Conference_Review_Conference_Reviews_Comment_Members  where email=@email and conference_review_comment_id=@comment
--delete from game review comment:
create proc List_of_delgamerew
@game_id varchar(50),
@comment int
AS
delete from Game_Reviews_Game_Review_Comments_Members where game_id=@game_id and comment_id=@comment
--delete from topic comment:
create proc List_of_deltopicrew
@email varchar(50),
@comment int
AS
delete from Members_Topic_Comment_Topic where member_id=@email and comment_id=@comment 
 
					  /*18 Show top 5 members with the most attended conferences in common with me*/
create view toop5

AS

select  top 5 count(a.conference_id) as 'Number_of_conferene',m.email
from Members m
inner join Conferences_Attend_Members a on a.email=m.email
Group By m.email
order by Number_of_conferene desc


				/*19 Show top 10 game recommendations based on how many times they have been recommended by other members of the system*/
						 
create proc top10_recommendation
@me varchar(50)
AS
select top 10 count(rec.game_id) as 'number_of_recommendations',g.name
from Games_Recommended_Normal_Users rec
inner join Games g on g.name=rec.game_id
inner join Games_Rate_Members r on r.game_id=g.name
where rec.normal_user_id1<>@me or r.member_email<>@me
group by g.name
Order by number_of_recommendations	desc
	
			/*---------------------------Normal_user should be able to ......------------------------------------*/
		  
		    /*1 Update my account information by providing my ﬁrst name, last name and date of birth*/
create proc Updatemyinformationnormal
@email varchar(50),
@fname varchar(50),
@lname varchar(50),
@birth date
as
update Normal_Users
set first_name=@fname,last_name=@lname,date_of_birth=@birth
where @email=email
	 
	                       /*2 Send friendship requests to other members of the system*/

create proc Send_friendship_requests
@me varchar(50),
@email varchar(50)


AS

insert into Normal_Users_add_friend_Normal_Users(email1,email2,accept) values (@me,@email,null)

                              /*3 Search the members of the network to ﬁnd friends*/
create proc Search_the_members
@me varchar(50)
AS
select email
from Normal_Users
where email<>@me 
except 

(
select n.email
from Normal_Users n
left outer join Normal_Users_add_friend_Normal_Users a on a.email2=n.email
where accept=1 and a.email1=@me
union
select n.email
from Normal_Users n
left outer join Normal_Users_add_friend_Normal_Users a on a.email1=n.email
where accept=1 and a.email2=@me
)


                             /*4 View a list of pending friendship requests*/

create proc Pending_friends
@me varchar(50)
AS
select n.first_name,n.Last_name,n.email,a.accept
from Normal_Users n
inner join Normal_Users_add_friend_Normal_Users a on a.email1=n.email
where a.accept IS NULL and a.email1<>a.email2 and email2=@me


                                   /*5 AcceptorReject the friendship request of other normal users*/

create proc Accept 
@me varchar(50),
@normal2 varchar(50)
AS
update Normal_Users_add_friend_Normal_Users
set accept=1
where email1=@normal2 and email2=@me

create proc Reject 
@me varchar(50),
@normal2 varchar(50)
AS
update Normal_Users_add_friend_Normal_Users
set accept=0
where email1=@normal2 and email2=@me
 


                                    /*6 View my friend list*/
create proc myfriends
@me varchar(50)
AS

select n.first_name,n.last_name
from Normal_Users n
left outer join Normal_Users_add_friend_Normal_Users a on a.email2=n.email
where accept=1 and a.email1=@me
union
select n.first_name,n.last_name
from Normal_Users n
left outer join Normal_Users_add_friend_Normal_Users a on a.email1=n.email
where accept=1 and a.email2=@me



                                   /*7 View a friend’s proﬁle*/

create proc Friend_profile
@me varchar(50),
@friend varchar(50)
AS
select n.first_name,n.Last_name,n.age,c.name,g.name,r.total_rate,r.graphics,r.interactivity,r.level_design,r.uniqueness
from Normal_Users_add_friend_Normal_Users a
inner join Normal_Users n on n.email=a.email2
inner join Conferences_Attend_Members at on at.email=a.email2
inner join Conferences c on c.conference_id=at.conference_id
inner join Games_Rate_Members r on r.member_email=a.email2
inner join Games g on g.name=r.game_id
where a.email1=@me and a.email2=@friend and accept=1

                       /*8 Send and receive multiple messages through threads with my friends*/

create proc sendandrecieve
@date date,
@content varchar(100),
@emailsender varchar(50),
@emailreciever varchar(50)

AS
insert into Normal_Users_Message_between_Users_Normal_Users(date_sent,content,sender,reciever) values (@date,@content,@emailsender,@emailreciever)

                                /*9 View my diﬀerent thread messages*/

create proc My_thread_messages
@me varchar(50),
@email varchar(50)
AS 
select date_sent,content,sender,reciever
from Normal_Users_Message_between_Users_Normal_Users 
where sender=@me and reciever=@email and sender<>reciever
union
select date_sent,content,sender,reciever
from Normal_Users_Message_between_Users_Normal_Users 
where sender=@email and reciever=@me and sender<>reciever

                                /*10 Recommend a game to another normal user*/

create proc Recommendgame
@me varchar(50),
@friend varchar(50),
@game varchar(50)
AS
insert into Games_Recommended_Normal_Users(normal_user_id1,normal_user_id2,game_id)values (@me,@friend,@game)


                         /*11 View the recommendations for diﬀerent games that I have recieved*/


create proc Recommendations
@me varchar(50)
AS
select n.first_name,n.last_name,r.game_id
from Games_Recommended_Normal_Users r
inner join Normal_Users n on  r.normal_user_id2=n.email
inner join Games g on g.name=r.game_id
where r.normal_user_id1<>r.normal_user_id2 and r.normal_user_id1=@me

               /*12 Request to create a community providing its name and description*/

create proc createcomm
@theme varchar(30),
@email varchar(50)

AS
insert into Communities_create_Normal_Users(theme,normal_user,accept) values (@theme,@email,0)


       /*-------------------------------------verified_reviewer should be able to .........------------------------*/


	   /*1 Update my account information by providing my ﬁrst name, last name and years of experience*/
create proc Updatemyinformationvirified
@email varchar(50),
@fname varchar(50),
@lname varchar(50),
@exp int
as
update Verified_Reviewers
set first_name=@fname,last_name=@lname,years_of_experience=@exp
where @email=email

	                                             /*2 Add a game review*/


create proc addgamereview
@content varchar(100),
@date date,
@game_id varchar(50),
@verified_reviewer varchar(50)

AS
insert into Games_Game_Reviews_Verified_Reviewers(content,date_of_review,game,veirified_reviewer) values (@content,@date,@game_id,@verified_reviewer)



	                               /*3 Delete a game review that I have written*/



create proc delete_message
@my_game varchar(50),
@me varchar(50)
AS
delete  from Games_Game_Reviews_Verified_Reviewers where veirified_reviewer=@me and game=@my_game



	                  /*4 View my top 10 game reviews based on the number of comments on them*/

create proc top_reviews
@me varchar(50)
AS
select top 10 count(comment_id)as 'Number_of_comments',game_review
from Game_Reviews_Game_Review_Comments_Members c
inner join Games_Game_Reviews_Verified_Reviewers r on r.game_review_id=c.game_review
where veirified_reviewer=@me
Group By game_review
order By Number_of_comments desc




/*---------------------------------------Development team should be able to----------------------------------------*/


                        /*1 Update our account’s information by providing our team name, date of formation and company we work for*/
create proc Updatemyinformationdevelplment
@team varchar(50),
@company varchar(50),
@date date,
@mail varchar(50)
as
update Development_teams
set team_name=@team,company=@company,formation_date=@date
where email=@mail 


	                          /*2 Add a game to the list of games that we have developed*/

create proc add_game
@game_name varchar(50),
@relase_date date,
@email varchar(50),
@rating varchar(50),
@relase_con varchar(50),
@age_limit int
AS
insert into Games values (@game_name,@relase_date,@rating,@age_limit,@email,@relase_con)



	                             /*3 Add screenshots and videos to a game that we have developed*/
create proc addscreenshots
@desS varchar(100),
@date date,
@game varchar(50)
as
insert into Screenshots values (@desS,@date,@game)


create proc addvideos
@desV varchar(100),
@date date,
@game varchar(50)
as
insert into Videos values(@desV,@date,@game)


 /*4 Add a conference to the list of conferences that we have presented in. We should also be able to add the game(s) that we presented in that conference*/

 create proc addcon
 @con_id int,
 @teamemail varchar(50),
 @game_id varchar(50)
 as
 insert into Conferences_Presents_Development_Teams_Games values(@con_id,@teamemail,@game_id)



    /*---------------------------------System Administrator should be able to---------------------------------------*/

	                    /*1 View a list of requests to form communities*/
create view requests 
as
select theme, normal_user, accept
from Communities_create_Normal_Users 
where accept=0 or accept=null 

    /*2 Accept0rReject a request to create a community. In case of acceptance, the community should be created with the provided information (name and description)*/

create proc Accept_or_reject_community
@theme varchar(30),
@name varchar(30),
@description_of_theme varchar(100),
@accept bit
as
if (@accept=1) 
insert into Communities(Theme,name,description_of_theme)
values(@theme,@name,@description_of_theme)



                                /*3 Verify members who signed up as veriﬁed reviewers or development teams*/

create proc verify_verified_reviewers
@verify bit,
@admin_id int,
@users_id varchar(50)
as
insert into System_Administrators_Verify_Verified_Reviewers(verify,admin_id,users_id)
values(@verify,@admin_id,@users_id)

create proc verify_development_teams
@verify bit,
@admin_id int,
@users_id varchar(50)
as
insert into Development_Teams_Verify_System_Administrators(verify,admin_id,users_id)
values(@verify,@admin_id,@users_id)


                                /*4 Create a conference with its information (names, start date, end date, duration and venue)*/
create proc create_conference
@name varchar(50),
@startdate date, 
@enddate date,
@venue varchar(50)
as 
insert into Conferences(name,startdate,enddate,venue)
values(@name,@startdate,@enddate,@venue)

                            

                 /*5 Create a game with its information (name, release date, age limit, and an intial rating equals to 0)*/
                                       
create proc create_game
@name varchar(50),
@release_date date,
@age_limit int
as
insert into Games(name,release_date,age_limit,rating)values(@name,@release_date,@age_limit,0)

                          /*6 Delete a community, a conference, or a game*/
create proc delete_conference
@conference_id int
as
delete
from Conferences
where conference_id=@conference_id

                            
create proc delete_game
@game_id varchar(50)
as
delete
from Games
where name=@game_id

create proc delete_communtity
@theme varchar(50)
as
delete
from Communities 
where Theme=@theme

---------------EXTRA PROCDURIES---------------
create proc login
@email varchar(50),
@pass varchar(50),
@count int output

AS
select @count=count(*)
from Members
where email=@email and password_user=@pass


create proc loginproc
@email varchar(50),
@count int output

AS
select @count=count(*)
from Members
where email=@email 




create proc iamnormal
@email varchar(50),
@count int output
as
select @count=count(*)
from Normal_Users
where email=@email

create proc iamverified
@email varchar(50),
@count int output
as
select @count=count(*)
from Verified_Reviewers
where email=@email


create proc iamdevelop
@email varchar(50),
@count int output
as
select @count=count(*)
from Development_Teams
where email=@email


create proc findmedevelop
@email varchar(50)
as
select *
from Development_Teams
where email=@email


create proc findmeverified
@email varchar(50)
as
select *
from Verified_Reviewers
where email=@email


create proc findmenormal
@email varchar(50)
as
select *
from Normal_Users
where email=@email

create proc countmembers
@number int output
AS
select @number=count(*)
from Members


create proc searchVerifiedReviewerall
@email varchar(50)
as
select v.first_name,v.last_name,v.years_of_experience,g.game,g.content,g.date_of_review
from Verified_Reviewers v
inner join Games_Game_Reviews_Verified_Reviewers g on g.veirified_reviewer=v.email
where v.email=@email

create proc searchdevelop
@email varchar(50)
as
select d.team_name,d.company,d.formation_date,c.name,g.name
from Development_Teams d
inner join Conferences_Presents_Development_Teams_Games p on p.development_team_ID=d.email
inner join Games g on g.name=p.game_id
inner join Conferences c on c.conference_id=p.conference_id
where d.email=@email

create proc pending2
@me varchar(50)
as
select n.first_name,n.Last_name,n.email
from Normal_Users n
inner join Normal_Users_add_friend_Normal_Users a on a.email2=n.email
where a.accept IS NULL and a.email1<>a.email2 and a.email1=@me

create proc myfriends2
@me varchar(50)
AS

select n.first_name,n.last_name,n.email
from Normal_Users n
left outer join Normal_Users_add_friend_Normal_Users a on a.email2=n.email
where accept=1 and a.email1=@me
union
select n.first_name,n.last_name,n.email
from Normal_Users n
left outer join Normal_Users_add_friend_Normal_Users a on a.email1=n.email
where accept=1 and a.email2=@me


create proc mycon
@me varchar(50)
as
select c.name
from Conferences_Attend_Members ca
inner join Conferences c on c.conference_id=ca.conference_id 
where ca.email=@me

///////////////////////////////////////////////////////////

create proc joinCommunity
@name varchar(50),
@theme varchar(30),
@out int output
as
begin
if(exists(select * from Communities_join_Members where normal_user=@name and theme=@theme))
begin
set @out= 0;
return @out;
end
else
begin
insert into Communities_join_Members values (@theme,@name)
set @out= 1;
return @out;
end
end

/////////////////////////////////////////////////
create proc createcomm
@theme varchar(30),
@email varchar(50),
@name varchar(30),
@des varchar(30),
@accept int output
AS
begin
if(not exists(select * from Communities where Theme=@theme ))
begin
    if(exists(select * from Normal_Users where email=@email ))
     begin
     insert into Communities values(@theme,@name,@des)
     insert into Communities_create_Normal_Users(theme,normal_user,accept) values (@theme,@email,1)
	 exec joinCommunity @email,@theme;
     set @accept=1;
     return @accept;
     end
	 else
	 begin
	  set @accept=2;
     return @accept;
	 end
end
else 
begin
   if(exists(select * from Normal_Users where email=@email))
   begin
     if(exists(select * from Communities_create_Normal_Users where theme=@theme and normal_user=@email))
      begin
       set @accept=0;
       return @accept;
       end
      else
	   begin
       insert into Communities_create_Normal_Users(theme,normal_user,accept) values (@theme,@email,0)
      set @accept=0;
      return @accept;
	  end
	end
  else
	begin
	set @accept=2
	return @accept;
	end
end


end
/////////////////////////////////////////////////////////////////////////////////////
create proc checkjoinned
@theme varchar(30),
@email varchar(30)
as
declare @out int;
begin
if(exists(select * from Communities_join_Members where theme=@theme and normal_user=@email))
begin
set @out=1;
return @out;
end
else
begin
set @out=0;
return @out;
end
end
///////////////////////////////////////////////////////

create proc postTopic
@Title varchar(50),
@description_text varchar(50),
@theme varchar(30),
@email varchar(50)
as

insert into Comunities_Topic_Members(Title,description_text,theme,member_id)
values (@Title,@description_text,@theme,@email)

//////////////////////////////////////////////////////////////////////
create proc getcomm
@theme varchar(30),
@name varchar(30) out,
@des varchar(100) out
as
select @name=name ,@des=description_of_theme 
from Communities
where Theme=@theme
////////////////////////////////////////////////////
create proc deleteTopic
@email varchar(50),
@theme varchar(30),
@Topic_id int
as
delete from Members_Topic_Comment_Topic
where  @Topic_id=topic_id
delete
from Comunities_Topic_Members
where @email=member_id and @theme=theme and @Topic_id=topic_id
\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
create proc gettopic
@theme varchar(30),
@mail varchar(30)
as
select Title,topic_id from Comunities_Topic_Members where theme=@theme and member_id=@mail
\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
create proc changetype
@t varchar(10)
as
declare @r int;
select cast(@t  as int) from Comunities_Topic_Members where topic_id=@t
set @r=@t
return @r
//////////////////////////////////////////////////////////////////
create proc getdesc
@topic int,
@title varchar(50) output,
@des varchar(50) output
as
select @title=Title , @des=description_text from Comunities_Topic_Members where topic_id=@topic
/////////////////////////////////////////////////////////////////////
create proc ADDcomTopic
	@content varchar(50),
	@date_of_comment date,
	@theme varchar(50),
	@topic_id varchar(50),
	@me varchar(50)
	AS
	insert Members_Topic_Comment_Topic values(@content,@date_of_comment,@theme,@topic_id,@me)

/////////////////////////////////////////////////////////
create proc deletecomment
@id int
as
delete from Members_Topic_Comment_Topic where comment_id=@id


create proc conf
@me varchar(50)
as
select conference_id,name
from Conferences
except
select c.conference_id,c.name
from Conferences c
inner join Conferences_Attend_Members a on a.conference_id=c.conference_id
where a.email=@me



ALTER proc joinCommunity
@name varchar(50),
@theme varchar(30)
as
declare @out int;
begin
if(exists(select * from Communities_join_Members where normal_user=@name and theme=@theme))
begin
set @out= 0;
return @out;
end
else
begin
insert into Communities_join_Members values (@theme,@name)
set @out= 1;
return @out;
end
end

////////////////////////////////////

CREATE proc conreviews
@conf_id varchar(50)
as
select CC.conference_ID,CC.conference_review_ID,CC.content, CC.email as'Users comments', CR.title,CR.contents,CR.email as'User Reviews'
from Conferences_Conference_Reviews_Members CR 
inner join Conference_Review_Conference_Reviews_Comment_Members CC on CC.conference_ID=CR.conference_id and CC.conference_review_ID=CR.conference_review_id
inner join Conferences C on C.conference_id=CC.conference_ID
where @conf_id=C.name

CREATE proc ConferenceReview 
@emal varchar(50),
@conf_id int,
@title varchar(50),
@date date,
@content varchar(50)
as
insert into Conferences_Conference_Reviews_Members(title,contents,date_of_review,conference_id,email) values(@title,@content,@date,@conf_id,@emal)


create proc deletecomment
@comment_id int 
as 
delete
from Conference_Review_Conference_Reviews_Comment_Members
where @comment_id=conference_review_comment_id



create proc rateGame
@graphics int,
@interactivity int,
@uniquness int,
@level int,
@game int,
@member varchar(50)
as
insert into Games_Rate_Members values(@graphics,@interactivity,@uniquness,@level,@game,@member)
create proc Recommendgame
@me varchar(50),
@friend varchar(50),
@game int
AS
insert into Games_Recommended_Normal_Users(normal_user_id1,normal_user_id2,game_id)values (@me,@friend,@game)



create proc addgamereview
@content varchar(100),
@date date,
@game_id int,
@verified_reviewer varchar(50),
@inserted int output
AS
begin
if(Exists(select * from Verified_Reviewers where email=@verified_reviewer))
begin
insert into Games_Game_Reviews_Verified_Reviewers(content,date_of_review,game,veirified_reviewer) values (@content,@date,@game_id,@verified_reviewer)
set @inserted = 1;
return @inserted;
end
else
begin
set @inserted=0;
return @inserted;
end
end


alter proc gameViewinformation
@name varchar(50)
as
select g.name,g.release_date,g.age_limit,d.team_name,ss.description_text as 'screen shot',v.description_text as 'video',gr.content,sg.Real_time,ag.sub_genre,s.type_of_sport,rpg.story_line,rpg.PvP
from Games g inner join Development_Teams d on g.development_team_email=d.email
left outer join Screenshots ss on g.game_id=ss.game_id
left outer join Videos v on v.game_id =g.game_id
left outer join Games_Game_Reviews_Verified_Reviewers gr on g.game_id=gr.game
left outer join Strategy_Games sg on sg.game=g.game_id
left outer join Action_Games ag on ag.game=g.game_id
left outer join Sport s on s.game=g.game_id
left outer join RPG rpg on rpg.game=g.game_id
where g.name=@name