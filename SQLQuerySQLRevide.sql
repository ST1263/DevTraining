INSERT INTO StudentMaster (Name, Email, Mobile, Gender, Education, DateOfBirth,IsActive,Id,CreatedDate)
VALUES ('Shreyas', 'shreyast@gmail.com', 9503661263, 'Male', 'MCA','1-Sep-1997',1,101,GETUTCDATE());

INSERT INTO StudentMaster (Name, Email, Mobile, Gender, Education, DateOfBirth,IsActive,Id,CreatedDate)
VALUES ('Rutuja', 'rutuja@gmail.com', 9011098261, 'Female', 'MCA','7-Jul-1998',1,102,GETUTCDATE());
INSERT INTO StudentMaster (Name, Email, Mobile, Gender, Education, DateOfBirth,IsActive,Id,CreatedDate)
VALUES ('Shruti', 'shruti@gmail.com', 8669811646, 'Female', 'MCA','20-Jun-1998',1,105,GETUTCDATE());
INSERT INTO StudentMaster (Name, Email, Mobile, Gender, Education, DateOfBirth,IsActive,Id,CreatedDate)
VALUES ('Aishwarya', 'aishwarya@gmail.com', 7385667644, 'Female', 'MCA','28-Dec-1999',1,104,GETUTCDATE());
INSERT INTO StudentMaster (Name, Email, Mobile, Gender, Education, DateOfBirth,IsActive,Id,CreatedDate)
VALUES ('Piyush', 'piyush@gmail.com', 9691821850, 'Male', 'MCA','20-Jul-1999',1,103,GETUTCDATE());


INSERT INTO StudentAddress(StudentId, Address, Tashil, District, Zipcode)
VALUES (101, 'Kurduwadi', 'Madha', 'Solapur', 413208);

INSERT INTO StudentAddress(StudentId, Address, Tashil, District, Zipcode)
VALUES (102, 'Pune', 'Dhyari', 'Pune', 411041);
INSERT INTO StudentAddress(StudentId, Address, Tashil, District, Zipcode)
VALUES (103, 'Indore', 'Indore', 'Indore', 452005);
INSERT INTO StudentAddress(StudentId, Address, Tashil, District, Zipcode)
VALUES (104, 'Solpaur', 'Solapur', 'Solapur', 413001);
INSERT INTO StudentAddress(StudentId, Address, Tashil, District, Zipcode)
VALUES (105, 'Nagar', 'Nagar', 'Nagar', 414006);


INSERT INTO StudentMarks(StudentId, Subject, Marks, Percentage, Grade)
VALUES (101, 'ASP', 80, 80.2, 'A');

INSERT INTO StudentMarks(StudentId, Subject, Marks, Percentage, Grade)
VALUES (102, 'C#', 90, 84.2, 'A');
INSERT INTO StudentMarks(StudentId, Subject, Marks, Percentage, Grade)
VALUES (103, 'PHP', 60, 70.82, 'B');
INSERT INTO StudentMarks(StudentId, Subject, Marks, Percentage, Grade)
VALUES (104, 'ANgular', 65, 68.5, 'C');
INSERT INTO StudentMarks(StudentId, Subject, Marks, Percentage, Grade)
VALUES (105, 'C', 70, 64.00 ,'D');


UPDATE StudentMaster
SET  Name= 'Shrutii'
WHERE Id = 105;

SELECT StudentMaster.Name,StudentMaster.Email,StudentMaster.Mobile, StudentAddress.Address, StudentAddress.Tashil, StudentAddress.District, StudentAddress.Zipcode
FROM StudentMaster
INNER JOIN StudentAddress ON StudentMaster.Id = StudentAddress.StudentId;

Select StudentMaster.Name,StudentMaster.Email,StudentMaster.Mobile, StudentMarks.Marks
FROM StudentMaster
INNER JOIN StudentMarks ON StudentMaster.Id = StudentMarks.StudentId;





Select StudentMaster.Name, StudentMarks.Percentage
FROM StudentMaster
INNER JOIN StudentMarks ON StudentMaster.Id = StudentMarks.StudentId where Percentage > 50;



UPDATE StudentMarks
SET  Marks= 210
WHERE StudentId = 105;


Select StudentMaster.Name, StudentMarks.Marks
FROM StudentMaster
INNER JOIN StudentMarks ON StudentMaster.Id = StudentMarks.StudentId where Marks > 200;

Select StudentMaster.Name, StudentMarks.Marks
FROM StudentMaster
INNER JOIN StudentMarks ON StudentMaster.Id = StudentMarks.StudentId ORDER BY Marks DESC;


