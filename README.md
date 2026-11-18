
# 🚀 Hola Mundo API – C# | ASP.NET Core Web API

<p align="center">
  <img src="https://img.shields.io/badge/C%23-.NET%2010-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt="C# .NET 10">
  <img src="https://img.shields.io/badge/ASP.NET%20Core-Web%20API-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt="ASP.NET Core Web API">
  <img src="https://img.shields.io/badge/HTTP-REST-00599C?style=for-the-badge" alt="REST API">
</p>

<p align="center">
  API REST básica desarrollada con C# y ASP.NET Core Web API.
</p>

---

## 📋 Descripción del proyecto

**HolaMundoAPI** es una aplicación web que implementa un servicio REST mediante ASP.NET Core Web API. Su propósito es demostrar la creación de un proyecto desde cero, la implementación de un endpoint HTTP y la verificación de su funcionamiento.

La API devuelve un mensaje de bienvenida en formato JSON con información sobre el lenguaje y el framework utilizados.

## 🎯 Objetivos

- Configurar el entorno de desarrollo con C# y .NET.
- Crear una API REST utilizando ASP.NET Core Web API.
- Implementar un endpoint HTTP GET.
- Generar respuestas en formato JSON.
- Ejecutar y probar el servicio en un servidor local.
- Verificar las respuestas HTTP mediante navegador y Postman.

## 🛠️ Tecnologías y herramientas

| Tecnología | Utilización |
|---|---|
| C# | Lenguaje de programación |
| .NET 10 SDK | Plataforma de desarrollo |
| ASP.NET Core Web API | Framework para construir la API REST |
| Visual Studio Code | Editor de código |
| C# Dev Kit | Extensión para C# |
| Postman | Pruebas HTTP |
| Git | Control de versiones |
| GitHub | Alojamiento del repositorio |

## ⚙️ Características de la API

- Implementación mediante Minimal API.
- Endpoint de tipo GET.
- Respuesta en formato JSON.
- Código HTTP `200 OK`.
- Ejecución en un servidor local.

## 🔌 Endpoint disponible

| Método HTTP | Ruta | Descripción |
|---|---|---|
| `GET` | `/api/hola` | Retorna un mensaje de bienvenida. |

**URL local:**

```text
http://localhost:5000/api/hola
```

### 📦 Respuesta JSON

```json
{
  "mensaje": "Hola Mundo",
  "lenguaje": "C#",
  "framework": "ASP.NET Core Web API"
}
```

**Código de respuesta esperado:** `200 OK`.

## 📁 Estructura del proyecto

```text
HolaMundoAPI/
│
├── Controllers/
├── Properties/
├── .gitignore
├── appsettings.Development.json
├── appsettings.json
├── HolaMundoAPI.csproj
├── HolaMundoAPI.http
├── Program.cs
├── WeatherForecast.cs
└── README.md
```

## 💻 Instalación y ejecución

### 1. Requisitos previos

- Windows 10 o superior.
- .NET 10 SDK.
- Visual Studio Code.
- Extensión C# Dev Kit.
- Postman para realizar pruebas.

### 2. Restaurar las dependencias

Desde la terminal, dentro de la carpeta del proyecto:

```bash
dotnet restore
```

### 3. Compilar el proyecto

```bash
dotnet build
```

### 4. Ejecutar la aplicación

```bash
dotnet run --no-launch-profile --urls "http://localhost:5000"
```

Cuando el servidor se inicie correctamente, estará disponible en:

```text
http://localhost:5000
```

### 5. Probar el endpoint

Abrir el navegador o Postman y realizar una solicitud GET a:

```text
http://localhost:5000/api/hola
```

La respuesta esperada es el mensaje de bienvenida en formato JSON con código HTTP `200 OK`.

Para detener el servidor desde la terminal, presionar `Ctrl + C`.

## 🧠 Explicación técnica del código

El archivo principal es `Program.cs`, donde se configura y ejecuta la aplicación.

- `WebApplication.CreateBuilder(args)`: crea el constructor de la aplicación.
- `builder.Build()`: construye la aplicación web.
- `app.MapGet("/api/hola", ...)`: define la ruta y el método HTTP GET.
- `Results.Ok(...)`: devuelve una respuesta HTTP 200 con los datos en formato JSON.
- `app.Run()`: inicia el servidor y permite recibir solicitudes.

## 🧪 Pruebas realizadas

La API fue comprobada mediante:

- Navegador web: consulta directa del endpoint.
- Postman: solicitud GET a la ruta `/api/hola`.
- Resultado esperado: `200 OK`.
- Respuesta: objeto JSON con el mensaje Hola Mundo.

## 👩‍💻 Autora

**Yaritza Cristhel Mora Quijije**

## 🎓 Información académica

- **Institución:** Universidad Técnica Estatal de Quevedo (UTEQ).
- **Carrera:** Ingeniería en Sistemas de Información.
- **Asignatura:** Bases de la Programación Web.
- **Unidad:** Unidad 1.
- **Actividad:** Desarrollo de una API REST Hola Mundo.
- **Lenguaje:** C#.
- **Framework:** ASP.NET Core Web API.
- **Año:** 2026.

---

<p align="center">
  <strong>🚀 Aprendiendo, desarrollando y construyendo soluciones web.</strong>
</p>

<p align="center">
  <em>Proyecto académico desarrollado con fines educativos.</em>
</p>
