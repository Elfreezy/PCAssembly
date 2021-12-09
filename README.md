Порядок выполнения миграции в ASP .NET
0.	dotnet tool install --global dotnet-ef
1. dotnet ef migrations add <name>
	To undo this action, use 'ef migrations remove'
2. dotnet ef database update


Строка подключение к БД в appsettings.json
Data Source=LAPTOP-3GEEMDMF; Database=MyCompany; Persist Security Info=false; User ID='sa'; Password='sa'; MultipleActiveResultSets=True; Trusted_Connection=False;