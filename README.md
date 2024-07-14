# Exchange Rates Website

This project consists of a client-side application built with React and a server-side application built with ASP.NET Core.

## Prerequisites

Before you begin, ensure you have the following installed on your machine:

- Node.js and npm
- Vite (for React)
- ASP.NET Core SDK

1. **Node.js and npm:**

   - Install Node.js:
     ```bash
     sudo apt-get install -y nodejs
     ```

   - Check your Node.js and npm versions:
     ```bash
     node -v
     npm -v
     ```

   - Update Node.js if necessary:
     ```bash
     npm install -g npm@latest
     ```

2. **React with Vite:**

   - Install Vite globally:
     ```bash
     npm install -g create-vite
     ```

## Client (React)

If you are interested in building the project yourself
###  To create a New React App
Create a new React app using Vite:

```bash
mkdir Exchange-Rates-Website-Client
cd Exchange-Rates-Website-Client
npm create vite@latest exchange-rates-website -- --template react
cd exchange-rates-website
```

###  Install Dependencies
  - Install project dependencies:
    ```bash
    npm install
    ```
### Open the Project in VS Code

  ```bash
code .
```

3. **Run the Client**
    - Start the development server:
  ```bash
  npm run dev
  ```

4. **Connect to Server**
    -Install Axios to connect to the server:

```bash
npm install axios
```

## Backend (ASP.NET Core)

1. **Build the Backend**
  
2. **Create a New ASP.NET Core Project**
  - Create a new ASP.NET Core web project:

  ```bash
mkdir Exchange-Rates-Website-Server
cd Exchange-Rates-Website-Server
dotnet new web -n Exchange-Rates-Website-Server
cd Exchange-Rates-Website-Server
```

3.  **Run the Server**
  - Run the backend server:

```bash
dotnet run
```

### Connect to Server
- To connect the React client to the ASP.NET Core server, install Axios:

```bash
npm install axios
```


## Running the Project
#### Client (React) - To start the React client:

```bash
npm run dev
```

#### Backend (ASP.NET Core) - To start the ASP.NET Core server:
```bash
dotnet run
```


### Server Information
- The server runs by default at http://localhost:5002.
  
