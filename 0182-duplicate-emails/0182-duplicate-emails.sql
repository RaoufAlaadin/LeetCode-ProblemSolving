/* Write your T-SQL query statement below */


select email 
from Person
group by email 
Having Count(email)> 1

-- Draft 

/*
        1- all emails are lower-case. 
        2- email field is not null
*/




