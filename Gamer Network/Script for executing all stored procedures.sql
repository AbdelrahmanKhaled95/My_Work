
---------------------------------------Members----------------------------------------------------------------------
--1
exec signUp1 'hazem.279@hotmail.com','fifa1234','RPGs'
exec insertNormalUser 'Hazem','Elessawy','1995-7-17','hazem.279@hotmail.com'
exec signUp1 'hazem.280@hotmail.com','fifa1234','RPGs'
exec insertVerifiedReviewer 'Ahmed','Hazem',8,'hazem.280@hotmail.com'
exec signUp1 'Abdo.281@hotmail.com','fifa1234','Sports'
exec insertDevelopmentTeam 'Kamehameha','EA','2010-8-20','Abdo.281@hotmail.com'
--2
exec searchGame 'FIFA 15'
exec searchCommunity 'Arab_boys'
exec searchConference 'Mahraggan El sh3abb'
exec searchDevelopmentTeam 'Kamehameha'
exec searchVerifiedReviewer 'Ahmed','Hazem'
--3
exec gameViewinformation 'Assassins Creed Syndicate'
--4
exec rateGame 4,5,6,7,8,'hazem.279@hotmail.com'
--5
exec average 6
--6
exec viewRate 'Mousa666@hotmail.com'
--7
exec conferenceView 3
--8
exec insertConferenceAttend 'hazem.279@hotmail.com', 2
--9
exec insertConferenceReview 'good conference','2010-8-17',2,'hazem.279@hotmail.com'
--10
exec deleteConference 3,'Rana@hotmail.com'
--11
exec joinCommunity 'abdokhaled30@hotmail.com','theme4'
--12
exec viewCommunity 'theme4'
--13
exec postTopic 'I am very happy to join you here ?','i was very lonly','theme3','belal@hotmail.com'
--14
exec deleteTopic 'Rana@hotmail.com','theme4',3
--15
exec ADDcommconfrence 'it was boring',3,2,'abdokhaled30@hotmail.com'
exec ADDcommGameReviews 'waste of time',15,6
exec ADDcomTopic 'useless','2015-12-7','theme2',1,'abdokhaled30@hotmail.com'
--16
exec List_of_Conreview 1
exec List_of_gamereview 13
exec List_of_topicreview 1
--17
exec List_of_delconrew 'Heba@hotmail.com',2
exec List_of_delgamerew 'abdokhaled30@hotmail.com',7
exec List_of_deltopicrew  'Nada@hotmail.com', 2
--18
select * from toop5
--19
exec top10_recommendation 'José@hotmail.com'
              --OR
exec top10_recommendation 'Rana@hotmail.com'


-------------------------------------------------Normal User procdure---------------------
--1
exec Updatemyinformationnormal 'Rana@hotmail.com','Roro','Rary','1995-2-1'
--2
exec Send_friendship_requests 'abdokhaled30@hotmail.com' ,'Hatem@hotmail.com'
--3 
exec Search_the_members 'abdokhaled30@hotmail.com' 
--4 
exec Pending_friends 'Elissa@hotmail.com'
--5
exec Accept_Reject 1,'abdokhaled30@hotmail.com','José@hotmail.com'
--6
exec myfriends 'Silm@hotmail.com' 
--7
exec Friend_profile 'Nazih@hotmail.com','Hazam_ayman@hotmail.com' 
--8
exec sendandrecieve '02-Feb-15','where are you ?','Mousa666@hotmail.com','shakira@hotmail.com'
--9
exec My_thread_messages 'Rustom@hotmail.com'
--10
exec Recommendgame 'abdokhaled30@hotmail.com','Mousa666@hotmail.com',7
--11
exec Recommendations 'abdokhaled30@hotmail.com'
--12
exec createcomm 'theme5','Mousa666@hotmail.com'

------------------------------------------------verified reviewer procdure---------------------
--1
exec pdatemyinformationvirified 'Merna@hotmail.com','Mono','short',1
--2
exec addgamereview 'we7shaa','5-Jan-95',4,'Heba@hotmail.com'
--3
exec delete_message 3,'Maha@hotmail.com'
--4
exec top_reviews 'tarek@hotmail.com'



------------------------------------------------development team procdure---------------------
--1
exec Updatemyinformationdevelplment 'Egoooo','Egypsdsd','2005-6-9','SquareEinx@hotmail.com'
--2
exec add_game 'GTA V', '2015-3-1','Ubisoft@hotmail.com',9,1,10
--3
exec addscreenshots 'PathScreenshot','2009-12-10',12
exec addvideos 'PathVideo','2003-12-10',11
--4
exec addcon 1,'naughtdog@hotmail.com',12
----------------------------------------------------Adminsitrator------------------------------------------
--1
SELECT * FROM  requests
--2
exec Accept_or_reject_community 'Thedsfw','Hedsflo','fosdftting',1
--3
exec verify_verified_reviewers 1,1,'elsisi@hotmail.com'
exec verify_development_teams 0,1,'SquareEinx@hotmail.com'
--4
exec  create_conference 'Egy_con','2015-11-25','2015-11-30','roxy'
--5
exec create_game'kickboss','2016-1-2',18
--6
exec delete_conference 1
exec delete_game 7
exec delete_communtity 'theme2'