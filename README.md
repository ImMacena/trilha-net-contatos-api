# CRUD de Agenda - ASP.NET Core Web API

Este projeto é uma atividade prática de um Bootcamp da [DIO](https://www.dio.me), onde foi implementado um CRUD (Create, Read, Update, Delete) para uma agenda de contatos utilizando ASP.NET Core Web API.

## 📚 Descrição

O sistema consiste em uma API para gerenciar contatos em uma agenda. Ele permite adicionar, listar, atualizar e remover contatos da tabela `Contatos`. Cada contato possui as seguintes informações:

### Estrutura da Tabela `Contatos`:

| Campo      | Tipo             | Descrição               |
|------------|------------------|-------------------------|
| `id`       | `integer($int32)` | Identificador único do contato |
| `nome`     | `string`          | Nome do contato  |
| `telefone` | `string`          | Telefone do contato |
| `ativo`    | `boolean`         | Indica se o contato está ativo |

## 🛠️ Tecnologias Utilizadas

- **ASP.NET Core 8.0**: Framework para construção da Web API.
- **Entity Framework Core**: Para manipulação do banco de dados de forma mais simples e com Migrations.
- **Swagger**: Documentação interativa para a API.
- **SQL Server**: Banco de dados utilizado para armazenar os contatos.

## 🔧 Funcionalidades

A API possui os seguintes endpoints para realizar o CRUD de contatos:

- **GET /contatos/{id}**: Retorna um contato específico pelo seu ID.
- **GET /contatos/GetByName**: Retorna uma lista de contatos que contém o nome que foi passado.
- **POST /contatos**: Cria um novo contato.
- **PUT /contatos/{id}**: Atualiza as informações de um contato existente.
- **DELETE /contatos/{id}**: Remove um contato da agenda pelo seu ID.

![Screenshot_2](https://github.com/user-attachments/assets/79b072f5-9072-4f25-9be1-7b55017209f8)

## 🚀 Como Rodar o Projeto

1. **Pré-requisitos**:
   - Instale o .NET SDK 8.0 ou superior.
   - SQL Server ou outro banco de dados compatível.
   - Editor de código como Visual Studio ou VS Code.

2. **Clone o repositório**:
   ```bash
   git clone https://github.com/ImMacena/trilha-net-contatos-api
