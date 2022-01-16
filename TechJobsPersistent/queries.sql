--Part 1
--list  columns and data types in the Jobs table
--  ID is an integer, Name is a VARCHAR, EmployerId is also an Int

--Part 2
--SQL TASK: write a query to list the names of the employers in St. Louis City
SELECT Name
FROM Employers
WHERE Location="St. Louis";
--Part 3

--SQL TASK:write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order. 
--If a skill does not have a job listed, it should not be included in the results of this query. make use of "is not null"
SELECT Name, Description
FROM skills
INNER JOIN jobskills 
ON jobskills.skillId = skills.Id
ORDER BY Name;
