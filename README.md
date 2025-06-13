# ASP.Net-Core---HelloRazerPage
ASP.NET Core User Management with Razor Pages
===
🔹 Проект: Простое веб-приложение для управления пользователями на ASP.NET Core Razor Pages. <br />
🔹 Цель: Демонстрация базового CRUD-функционала (Create, Read, Update, Delete) с использованием Razor Pages и взаимодействием с базой данных. <br />
🔹 Ключевые технологии: <br />
Backend: ASP.NET Core 6+ <br />
Frontend: Razor Pages, Bootstrap 5 <br />
База данных: не используется, легко интегрируется  <br />

🔹 Дополнительно:
- AJAX для динамических операций (удаление, выбор пользователя)
- Валидация форм на стороне сервера и клиента
- Работа с RequestVerificationToken для защиты от CSRF

🔹 Функционал: <br>
✅ Просмотр списка пользователей в табличном формате <br>
✅ Добавление/редактирование пользователей (логин + пароль) <br>
✅ Удаление с подтверждением через JavaScript <br>
✅ Сброс формы кнопкой "Очистить" <br>
✅ Динамическое обновление интерфейса без перезагрузки страницы <br>

🔹 Структура проекта: <br>
/Pages/Users/UsersPage.cshtml         – Razor-страница с интерфейсом <br />
/Pages/Users/UsersPage.cshtml.cs      – логика обработчиков (Save, Delete) <br />
/Data/User.cs                         – модель пользователя <br />
appsettings.json                      – конфигурация БД, если необходимо <br />

🔹 Возможные улучшения:
- Добавление авторизации (Identity)
- Пагинация списка пользователей
- Шифрование паролей
    
🔹 Скриншот интерфейса:
![image](https://github.com/user-attachments/assets/e85bfc02-46e5-4fba-8a39-74f45b9f12b8)

![image](https://github.com/user-attachments/assets/bf5fb65c-a889-4e69-a7ea-949f6479a6ca)


