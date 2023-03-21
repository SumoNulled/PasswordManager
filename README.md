# PasswordManager
![image](https://user-images.githubusercontent.com/46579169/226492809-f2f17703-913e-4cf3-b98b-e76e99e94379.png)

### What does this application do?
* Allows you to locally store passwords using an embedded database.
* Allows you to customize and generate secure passwords

### Development Motivation
* Amid the many leaks happening with cloud based password managers, this solution was created.

## Getting Started
#### Pre-requisites:
* Microsoft SQL Server Compact 4.0 SP1 (https://www.microsoft.com/en-us/download/details.aspx?id=30709)
* If downloading the program as a .zip, you must extract all files first and open/build the .csproj file.

----
* When you first run the program, you will be prompted to create a pin.

![image](https://user-images.githubusercontent.com/46579169/226492621-4cf89697-034f-4967-9814-79b8e1464669.png)
* Subsequent logins will require you to enter this pin to access your passwords.

![image](https://user-images.githubusercontent.com/46579169/226492714-ac752e81-1d25-4adb-bab2-92afdcbedef0.png)

* Dashboard

![image](https://user-images.githubusercontent.com/46579169/226492809-f2f17703-913e-4cf3-b98b-e76e99e94379.png)

* Generating Passwords - All acount/generated passwords are encrypted before being stored. Even though this data is stored locally, storage of plaintext poses unneccessary risks.

![image](https://user-images.githubusercontent.com/46579169/226493384-976cf849-7add-4b01-9e3c-f770f50793fc.png)

* Add Account

![image](https://user-images.githubusercontent.com/46579169/226493603-f14b0f00-a03c-4204-ba44-4dbd367cc342.png)

* View Accounts - Double clicking a row will edit, copy username, or copy password.

![image](https://user-images.githubusercontent.com/46579169/226493795-8ad38518-d760-4575-9199-06da4372d973.png)

* Edit Accounts

![image](https://user-images.githubusercontent.com/46579169/226493891-eb54a659-723f-4b4f-b282-77156f3f18f7.png)

* Resetting data - This is a permanent action. It cannot be undone.

![image](https://user-images.githubusercontent.com/46579169/226494054-63ea4bdb-91ff-498b-8ccb-49c04c57be1a.png)

