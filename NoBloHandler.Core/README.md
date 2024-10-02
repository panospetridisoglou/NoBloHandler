Mediator without bloat :)

To use add the `INoBloHandler<request,response>` to your Handler class

and then on your minimal api / fast endpoints implementation inject the handler and excecute
with ` handler.HandleAsync(request)`

That simple 

Source:
https://github.com/panospetridisoglou/NoBloHandler