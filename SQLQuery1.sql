select  MiddleName, count(*)
from Person.Person
group by MiddleName
having count(*) > 20;
