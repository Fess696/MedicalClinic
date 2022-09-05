# <h2>MedicalClinic .Net</h2>
<h3>Для вирішення домашнього завдання я вирішив вибрати "Фабричний Метод" паттерну проектування. Цей метод спрощує додавання нових продуктів бізнесу до програми.</h3>

<h3>Створено обʼєкти ( у данному випадку консультації різних спеціалістів) які поєднанні між собою єдиним інтерфейсом (Domain/IConsultation), який виконує методи:</h3>
<ul>
  <li>Ім'я </li>
  <li>Прайс</li> 
  <li>Спеціалізація </li>
  <li>Послуги</li>
  </ul>
<img src="https://user-images.githubusercontent.com/75900532/188337314-44208667-9bec-4ce1-b6d2-7b68b34783f5.png" alt="list of obj">


  
Наступний крок створення абстрактного класу з логікою (ConsultationFactory), яка має дочірні класи з методами створення специфічного "продукту" ( у данному випадку конкретних консультацій).

<img src="https://user-images.githubusercontent.com/75900532/188337515-a7e39960-1856-4e19-89fa-41be9a2d865f.png" alt="list of fabrics">

<h3>Ідея для створення консольного додатку "MedicalClinic". Клієнту (оператору) через консоль буде задано питання який тип консультації він бажає обрати.</h3>
<img src="https://user-images.githubusercontent.com/75900532/188337561-2356ad98-3db1-4ef0-8101-fe85d404fe72.png" alt="console">


<h3>Після обрання клієнтом бажаної консультації за допомогою консольного введення додаток буде звертатися до  так званої "Фабрики", яка створить необхідний тип консультації та виведе інформацію у консоль.</h3>

<img src="https://user-images.githubusercontent.com/75900532/188337607-051ef12e-8bea-4cfd-ade3-dc423dcf7c83.png" alt="console answer">
