from datetime import datetime, timedelta
import random

class Student:
    def __init__(self, group, year, first_name, last_name):
        self.group = group
        self.year = year
        self.first_name = first_name
        self.last_name = last_name
        self.marks = []

    def add_mark(self, mark):
        self.marks.append(mark)

class Mark:
    def __init__(self, date, estimation):
        self.date = date
        self.estimation = estimation

# Генерация случайной оценки или пропуска (по уважительной причине или нет)
def get_random_estimation():
    n = random.randint(0, 4)
    if n == 0:
        return "2"
    elif n == 1:
        return "3"
    elif n == 2:
        return "4"
    elif n == 3:
        return "5"
    else:
        return "болезнь"

# Генерация оценок и посещаемости на 10 дней вперед для каждого студента
def generate_marks(students):
    current_date = datetime.today()
    for student in students:
        for i in range(10):
            date = current_date + timedelta(days=i)
            estimation = get_random_estimation()
            mark = Mark(date, estimation)
            student.add_mark(mark)

# Добавление студента в группу
def add_student_to_group(group, year, first_name, last_name, students):
    student = Student(group, year, first_name, last_name)
    students.append(student)

# Создание списка студентов
students = []
add_student_to_group("Группа 1", 2021, "Иван", "Иванов", students)
add_student_to_group("Группа 1", 2021, "Петр", "Петров", students)
add_student_to_group("Группа 2", 2020, "Александр", "Сидоров", students)

# Генерация оценок и посещаемости на 10 дней вперед для каждого студента
generate_marks(students)

# Вывод оценок и посещаемости для каждого студента
for student in students:
    print(f"{student.group} {student.year}, {student.first_name} {student.last_name}")
    for mark in student.marks:
        print(f"{mark.date.date()} - {mark.estimation}")
    print()
