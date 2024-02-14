create database Countries;
use Countries
create table Information(
	Id int primary key identity(1,1),
	Name nvarchar(50),
	Capital nvarchar(50),
	NumberOfInhabitants int,
	Area float,
	Continent nvarchar(50)
)
insert into Information (Name, Capital, NumberOfInhabitants, Area, Continent)
values('Ukraine', 'Kyiv', 44000000, 603700, 'Europe'),
    ('USA', 'Washington', 331000000, 9834000, 'North America'),
    ('China', 'Beijing', 1403000000, 9597000, 'Asia'),
    ('India', 'New Delhi', 1371000000, 3287000, 'Asia'),
    ('United Kingdom', 'London', 66400000, 242495, 'Europe'),
    ('Canada', 'Ottawa', 37590000, 9985000, 'North America'),
    ('Brazil', 'Brasília', 212600000, 8516000, 'South America'),
    ('Australia', 'Canberra', 25600000, 7692000, 'Australia and Oceania'),
    ('Germany', 'Berlin', 83100000, 357000, 'Europe'),
    ('France', 'Paris', 67060000, 551695, 'Europe'),
    ('Spain', 'Madrid', 46800000, 505992, 'Europe'),
    ('Italy', 'Rome', 60480000, 301340, 'Europe'),
    ('Japan', 'Tokyo', 126500000, 377975, 'Asia'),
    ('Argentina', 'Buenos Aires', 44940000, 2780400, 'South America'),
    ('South Korea', 'Seoul', 51850000, 100210, 'Asia'),
    ('Mexico', 'Mexico City', 126200000, 1967138, 'North America'),
    ('Sweden', 'Stockholm', 10380000, 450295, 'Europe'),
    ('Netherlands', 'Amsterdam', 17410000, 41526, 'Europe'),
    ('Switzerland', 'Bern', 8550000, 41285, 'Europe'),
    ('Ireland', 'Dublin', 4921000, 70273, 'Europe');