# ASP.Net-Core---HelloRazerPage
ASP.NET Core User Management with Razor Pages
===
🔹 Проект: Простое веб-приложение для управления пользователями на ASP.NET Core Razor Pages. <br />
🔹 Цель: Демонстрация базового CRUD-функционала (Create, Read, Update, Delete) с использованием Razor Pages и взаимодействием с базой данных. <br />
🔹 Ключевые технологии: <br />
Backend: ASP.NET Core 6+ <br />
Frontend: Razor Pages, Bootstrap 5 <br />
База данных: не используется <br />

🔹 Дополнительно:
AJAX для динамических операций (удаление, выбор пользователя)
Валидация форм на стороне сервера и клиента
Работа с RequestVerificationToken для защиты от CSRF

🔹 Функционал: <br>
✅ Просмотр списка пользователей в табличном формате
✅ Добавление/редактирование пользователей (логин + пароль)
✅ Удаление с подтверждением через JavaScript
✅ Сброс формы кнопкой "Очистить"
✅ Динамическое обновление интерфейса без перезагрузки страницы

🔹 Как запустить:
Клонировать репозиторий:

bash
git clone https://github.com/VladimirRepp/ASP.Net-Core---HelloRazerPage.git
Восстановить зависимости:

bash
dotnet restore
Запустить приложение:

bash
dotnet run
Открыть в браузере:

text
https://localhost:5001/Users/UsersPage
🔹 Структура проекта:
/Pages/Users/UsersPage.cshtml – Razor-страница с интерфейсом

/Pages/Users/UsersPage.cshtml.cs – логика обработчиков (Save, Delete)

/Data/User.cs – модель пользователя

appsettings.json – конфигурация SQLite

🔹 Скриншот интерфейса:
(Можно добавить изображение из README.md)

🔹 Возможные улучшения:
Добавление авторизации (Identity)

Пагинация списка пользователей

Шифрование паролей
    
UseCase:
===
![image](https://github.com/user-attachments/assets/e85bfc02-46e5-4fba-8a39-74f45b9f12b8)

![image](https://github.com/user-attachments/assets/bf5fb65c-a889-4e69-a7ea-949f6479a6ca)


