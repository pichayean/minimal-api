var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<TodoService>(new TodoService());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();

app.MapPost("/todo", (Item item, TodoService todoService) => {
    var response = todoService.Add(item);
    return Results.Ok(response);
});

app.MapGet("/todos", (TodoService todoService) => {
    return Results.Ok(todoService.GetAll());
});

app.MapGet("/todo/{id}", (string id, TodoService todoService) => {
    var response = todoService.Get(id);
    return Results.Ok(response);
});

app.UseSwaggerUI();

app.Run();
