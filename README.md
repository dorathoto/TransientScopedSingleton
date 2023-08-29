# Transient, Scoped, Singleton In ASP.NET Core

## Transient
Um serviço registrado como Transient é criado toda vez que é solicitado. Isso significa que uma nova instância é fornecida sempre que alguém solicita esse serviço. Cada solicitação de serviço gera uma nova instância independente. Isso é útil para serviços efêmeros que têm um curto tempo de vida e não precisam ser compartilhados entre diferentes partes da aplicação.

**Exemplo de registro:**

```
services.AddTransient<IMyService, MyService>();
```


## Scoped
Um serviço registrado como Scoped é criado uma vez para cada solicitação HTTP em uma aplicação web. Isso significa que, durante o processamento de uma única solicitação HTTP, a mesma instância do serviço é usada sempre que ele é solicitado. No entanto, diferentes solicitações HTTP receberão instâncias separadas. Isso é útil para serviços que precisam manter um estado durante o processamento de uma solicitação, como um serviço de banco de dados.

**Exemplo de registro:**
```
services.AddScoped<IMyService, MyService>();
```


Singleton
Um serviço registrado como Singleton é criado apenas uma vez durante o ciclo de vida da aplicação. Isso significa que a mesma instância é compartilhada entre todas as solicitações e partes da aplicação que solicitam esse serviço. É importante ter cuidado ao usar Singleton, pois ele mantém o estado global e pode levar a problemas de concorrência se não for usado corretamente.

**Exemplo de registro:**
```
services.AddSingleton<IMyService, MyService>();
```


--------


Lembre-se de escolher o tipo de tempo de vida adequado com base nas necessidades do seu serviço e na forma como ele será usado na aplicação. O ASP.NET Core oferece essas opções para garantir um gerenciamento flexível e eficiente de instâncias de serviços em sua aplicação.