/*
	App usage data is kept in the following table:
	
	TABLE sessions
		id INTEGER PRIMARY KEY,
		userId INTEGER NOT NULL,
		duration DECIMAL NOT NULL
		
	Write a query that selects userId and average session duration for each user who has more than one session.
*/

select userId, avg(duration) as avg 
from sessions where userId in (select userId from sessions group by userId having count(*) > 1)
group by userId