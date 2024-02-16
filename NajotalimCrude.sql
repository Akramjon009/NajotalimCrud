create table student 
(
	id serial primary key,
	fullname text,	
	age int,
	phone_number text,
	course_id int  references course(id)
	
)

create table course
(
	id serial primary key,
	course_name text,
	teacher_id int  references theacher(id),
	duration text,
	price text,
	student_count int
)

create table teacher
(
	id serial primary key,
	fullname text,
	age int,
	phon_number text,
	experience int ,
	group_count int
)


INSERT INTO student (fullname, age, phone_number, course_id) 
VALUES 
    ('John Doe', 20, '123-456-7890', 1),
    ('Jane Smith', 22, '987-654-3210', 2),
    ('Michael Johnson', 21, '555-555-5555', 1),
    ('Emily Davis', 19, '111-222-3333', 3),
    ('Robert Brown', 20, '444-444-4444', 2),
    ('Sarah Wilson', 23, '777-888-9999', 1),
    ('James Taylor', 20, '666-666-6666', 2),
    ('Amanda Clark', 21, '999-999-9999', 3),
    ('Daniel Martinez', 22, '123-123-1234', 1),
    ('Olivia Anderson', 20, '321-321-3210', 2),
    ('William Lee', 21, '555-123-4567', 1),
    ('Sophia White', 22, '987-654-9876', 3),
    ('Ethan Harris', 19, '111-222-3333', 2),
    ('Isabella Young', 20, '444-555-6666', 1),
    ('Mason King', 23, '777-888-1111', 2),
    ('Abigail Scott', 20, '666-555-4444', 1),
    ('Logan Adams', 21, '999-111-2222', 3),
    ('Grace Evans', 22, '123-555-7777', 1),
    ('Jackson Baker', 20, '321-987-6543', 2),
    ('Charlotte Hall', 21, '555-321-7890', 1);
	

INSERT INTO course (course_name, teacher_id, duration, price, student_count)
VALUES 
    ('DotNet', 1, '5 months', '$200', 25),
    ('Go', 2, '5 months', '$200', 30),
    ('Flutter', 3, '5 months', '$200', 20),
	('Full Stack', 4, '8 months', '$210', 20);

INSERT INTO teacher (fullname, age, phon_number, experience, group_count)
VALUES 
	('Muhammadabdullox', 22, '987-654-3210', 3, 2),
	('Michael Williams', 40, '555-555-5555', 5, 4),
	('Emily Brown', 33, '111-222-3333', 8, 3),
	('John Smith', 35, '123-456-7890', 10, 3);
	

