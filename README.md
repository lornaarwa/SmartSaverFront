# SmartSaver Front-End


**SmartSaver** is a lightweight financial tracker front-end built with **Blazor WebAssembly**. It allows users to track income, expenses, and financial goals using a sleek dark-themed UI with neon-green accents.

---
## Live Demo

[![Live Site](https://img.shields.io/badge/Live-App-Netlify-brightgreen)](https://marvelous-choux-c1697b.netlify.app/)




---

## **Features**

- **Home Page**
  - Welcome message and app description
  - Add transactions and goals
  - View recent transactions

- **Transactions Page**
  - Add and view transactions
  - Dark-themed tables with neon-green text
  - Alternating row colors and hover effects

- **Goals Page**
  - Add and view financial goals
  - Consistent dark theme with neon accents

- **Navigation**
  - Collapsible sidebar
  - Active page highlighted
  - Responsive design

---

## **Technologies Used**

| Technology | Purpose |
|------------|---------|
| Blazor WebAssembly | Front-end framework using C# |
| .NET SDK | Build and run the app |
| HTML & CSS | UI structure and styling |
| Git & GitHub Pages | Version control and hosting |
| Visual Studio / VS Code | Development environment |

---

## **Installation & Local Development**

1. Install [.NET SDK 7+](https://dotnet.microsoft.com/download).
2. Clone the repository:
   ```bash
   git clone https://github.com/<YourGitHubUsername>/SmartSaverFront.git
   cd SmartSaverFront
3. Restore dependencies:

   dotnet restore


4. Run the app:

   dotnet run


5. Open the browser at the displayed URL (usually https://localhost:5001).

## **Hosting on GitHub Pages**

Publish the app:

dotnet publish -c Release -o publish


Push the contents of publish/wwwroot to a GitHub repository.

Enable GitHub Pages in repository settings.

Access the live app:

https://<YourGitHubUsername>.github.io/<RepositoryName>/

## **File Structure**

<pre>
SmartSaverFront/
├── wwwroot/
│   ├── css/
│   └── js/
├── Pages/
│   ├── Home.razor
│   ├── Transactions.razor
│   └── Goals.razor
├── Shared/
│   └── NavMenu.razor
└── Program.cs
</pre>


## **Data Models**
record Tx(DateTime Date, string Type, string Description, decimal Amount);
record Goal(string Name, decimal Target, decimal Current);


Transactions and goals are stored locally in memory.

Data is not persisted; it resets on page refresh.


## **Design Choices**

Dark Theme: Modern look, reduces eye strain.

Neon Green Accents: Highlights UI elements.

Tables: Alternating row colors, hover effects, readable fonts.

Responsive Layout: Collapsible sidebar for small screens.

Component-Based: Pages separated by function (Home, Transactions, Goals).


## **Limitations**

Front-end only; no backend API.

No authentication or multi-user support.

Data resets on page reload.

No export/import functionality.


## **License**

This project is for educational purposes.


Developed with ❤️ using Blazor WebAssembly and .NET
