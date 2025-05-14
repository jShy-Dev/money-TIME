# money|TIME
### Visualize your MONEY.OVER.TIME
Budgeting application focused on Monthly due dates and budget category adherence.
Written in Javascript & C# with OAuth & Plaid Integrations
Alpha Functionality: A basic UI, OAuth login endpoints, Plaid integration for bank linking, and a minimal calendar and budget overlay system.
![Wireframe_1_moneyTIME](https://github.com/user-attachments/assets/1527b41b-09d3-4885-b160-38a143b5df68)

Attempting to solve for organization of budgets into categories and due dates into a visual model that can be overlayed on a calendar. The app enables linking of financial accounts to analyze and organize actual expenses charged and compare budget adherence. Each day tile on the calendar can be zoomed in to see each expense and compare with the toggled overlay to visualize daily spend vs budget. The focus is a seamless blend of everyday budgeting month by month that can zoom out to view yearly budget adherence by category. The target audience is individuals and families who struggle to visualize their budget with other solutions.

### Frontend: Vanilla JavaScript, HTML, CSS
### Backend: .NET (ASP.NET Core) with PostgreSQL
### Security: TLS 1.2 encryption for data in transit and at rest
### Integrations: OAuth SSO (Apple, Microsoft, Google) & Plaid API for bank account linking

### Deployment Steps
1. Clone/fork this repo
2. Configure your environment: – Update the appsettings.json with your actual database connection strings and OAuth/Plaid credentials.
3. Set up the database: – Run the init.sql script with PostgreSQL to create your tables and optionally load data using seed.sql.
4. Build and run the backend: – Use the .NET CLI (e.g., dotnet run in the server folder) to start your API.
5. Launch the frontend: – Use a lightweight server (like live-server or any static server) to open index.html in your browser.

The app is written with TLS1.2 in mind, but can be adjusted as needed in source.
As you iterate, you can enhance the UI/UX, add detailed budgeting logic, and further secure your endpoints.
