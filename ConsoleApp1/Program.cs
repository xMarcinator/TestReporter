// See https://aka.ms/new-console-template for more information

using Notion.Client;

var client = NotionClientFactory.Create(new ClientOptions
{
    AuthToken = "secret_5C6k4fjTf6ivRefbxDUJf4v1TdiQOp6YB8ycXMjpBDj"
});

string databaseID = "dcebedc738634c3f93d58eb1cd81418b";

var usersList = await client.Users.ListAsync();

foreach (var user in usersList.Results)
{
    Console.WriteLine(user.Name + (user.Bot != null ? " is a bot" : ""));
}

Database db = await client.Databases.RetrieveAsync(databaseID);

foreach (var property in db.Properties)
{
    Console.WriteLine(property.Key + ":" + property.Value);
}