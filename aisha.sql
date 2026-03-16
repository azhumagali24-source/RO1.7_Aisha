-- CREATE DATABASE
CREATE DATABASE hospital_db;
USE hospital_db;

-- TABLE 1: DOCTOR
CREATE TABLE Doctor (
    Dr_ID INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    specialization VARCHAR(100) NOT NULL,
    phone VARCHAR(20) UNIQUE,
    email VARCHAR(100) UNIQUE
);

-- TABLE 2: PATIENT
CREATE TABLE Patient (
    Patient_ID INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(25) NOT NULL,
    last_name VARCHAR(25) NOT NULL,
    date_of_birth DATE NOT NULL,
    gender VARCHAR(10) CHECK (gender IN ('Male','Female')),
    phone VARCHAR(12) UNIQUE,
    email VARCHAR(50) UNIQUE
);

-- TABLE 3: APPOINTMENT
CREATE TABLE Appointment (
    Appointment_ID INT PRIMARY KEY AUTO_INCREMENT,
    Patient_ID INT NOT NULL,
    Dr_ID INT NOT NULL,
    appointment_date DATE NOT NULL,
    status VARCHAR(20) DEFAULT 'Scheduled',

    FOREIGN KEY (Patient_ID) REFERENCES Patient(Patient_ID),
    FOREIGN KEY (Dr_ID) REFERENCES Doctor(Dr_ID)
);

-- ===================================
-- ALTER TABLE statements (3 required)
-- ===================================

-- 1 Add new column
ALTER TABLE Patient
ADD address VARCHAR(255) NOT NULL;

-- 2 Modify column
ALTER TABLE Doctor
MODIFY phone VARCHAR(25);

-- 3 Rename column
ALTER TABLE Appointment
RENAME COLUMN appointment_date TO appointment_datetime;

-- ===================================
-- INSERT DATA (5 records each table)
-- ===================================

INSERT INTO Doctor(first_name,last_name,specialization,phone,email) VALUES
('John','Smith','Cardiology','111111111','john@hospital.com'),
('Emma','Brown','Neurology','222222222','emma@hospital.com'),
('David','Lee','Pediatrics','333333333','david@hospital.com'),
('Sophia','Taylor','Dermatology','444444444','sophia@hospital.com'),
('Michael','Clark','Orthopedics','555555555','michael@hospital.com');


INSERT INTO Patient(first_name,last_name,date_of_birth,gender,phone,email,address) VALUES
('Alice','Green','1998-03-10','Female','777111','alice@mail.com','Street 1'),
('Bob','White','1995-07-21','Male','777222','bob@mail.com','Street 2'),
('Charlie','Black','2000-01-15','Male','777333','charlie@mail.com','Street 3'),
('Diana','Stone','1999-09-09','Female','777444','diana@mail.com','Street 4'),
('Ethan','Hall','1997-11-11','Male','777555','ethan@mail.com','Street 5');


INSERT INTO Appointment(Patient_ID,Dr_ID,appointment_datetime,status) VALUES
(1,1,'2025-05-01','Scheduled'),
(2,2,'2025-05-02','Completed'),
(3,3,'2025-05-03','Scheduled'),
(4,1,'2025-05-04','Cancelled'),
(5,4,'2025-05-05','Scheduled');

-- ===================================
-- SELECT QUERIES
-- ===================================

-- Show all tables
SHOW TABLES;

-- Show patients
SELECT * FROM Patient;

-- Show doctors
SELECT * FROM Doctor;

-- Show appointments with relationships
SELECT 
    Patient.first_name AS Patient,
    Doctor.first_name AS Doctor,
    Appointment.appointment_datetime,
    Appointment.status
FROM Appointment
JOIN Patient ON Appointment.Patient_ID = Patient.Patient_ID
JOIN Doctor ON Appointment.Dr_ID = Doctor.Dr_ID;
