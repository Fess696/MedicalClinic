# MedicalClinic
Для вирішення домашнього завдання я вирішив вибрати "Фабричний Метод" паттерну проектування. Цей метод спрощує додавання нових продуктів бізнесу до програми.

Створено обʼєкти ( у данному випадку консультації різних спеціалістів) які поєднанні між собою єдиним інтерфейсом (Domain/IConsultation), який виконує методи:
"Ім'я", "Прайс", "Спеціалізація" та "Послуги".
Наступний крок створення абстрактного класу з логікою (ConsultationFactory), яка має дочірні класи з методами створення специфічного "продукту" ( у данному випадку конкретних консультацій).

Ідея для створення консольного додатку "MedicalClinic". Клієнту (оператору) через консоль буде задано питання який тип консультації він бажає обрати.
Після обрання клієнтом бажаної консультації за допомогою консольного введення додаток буде звертатися до  так званої "Фабрики", яка створить необхідний тип консультації та виведе інформацію у консоль. 