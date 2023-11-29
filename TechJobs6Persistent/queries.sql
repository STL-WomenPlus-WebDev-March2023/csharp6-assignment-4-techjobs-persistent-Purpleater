-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.
 
-- __ANSWER__
-- id (INT)
-- name (VARCHAR(255))
-- employer (VARCHAR(255)
-- employerId (INT)


--Part 2: Write a query to list the names of the employers in St. Louis City.

-- __ANSWER__
-- SELECT name 
-- FROM techjobs.employers
-- WHERE location = "St. Louis";

--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.

-- __ANSWER__

-- SOMETHING SOMETHING MANY-TO-MANY RELATIONSHIP