# JWT Key Generator
This easy to use app generates a highly secure **Symmetric Key** that can be used for signing **JSON Web Tokens (JWTs)**. It's built using **.NET 8** with an MVC (Mode-View-Controller) architecture and **Razor** views.<br/> 
[![Live Demo Link](https://img.shields.io/badge/Live%20Demo%20Link-3178c6)](https://keygenerator.evanmalherbe.com)<br/>
### Technologies
![.NET 8](https://img.shields.io/badge/.NET%208-275779) 
![Razor](https://img.shields.io/badge/Razor-bc2545)
![Javascript](https://img.shields.io/badge/Javascript-06b6d4)
![HTML5](https://img.shields.io/badge/HTML5-green)
![CSS3](https://img.shields.io/badge/CSS3-3178c6)
![Bootstrap](https://img.shields.io/badge/Bootstrap%205-339933)

## Table of Contents
- [Key Features](#key-features)
- [Description](#description)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Credits](#credits)

## Key Features
* **Highly Secure:** Keys are generated using a Cryptographically Strong Pseudo-Random Number Generator (CSPRNG).
* **Optimal Strength:** Generates a **64-byte (512-bit)** Symmetric Key.
* **JWT Standards:** Perfect for use with common HMAC algorithms like **HS256** and **HS512**.
* **Easy to Use:** Simple, two-click interface with a copy-to-clipboard function.
* **Tech Stack:** Built on the robust **.NET 8** framework.

## Description
This is a **.NET 8 MVC** web app with **Razor** views (deployed with [Railway](https://railway.com)). I wanted to create a quick little website that could generate a secure **secret key** that I could use for my coding projects that require authentication using **JSON Web Tokens (JWT)**. I figured that since I might need this tool semi-regularly, why not put it online for others to use as well. See screenshot of the homepage below.<br/><br/>
![Key Generator homepage](https://image-store.premiumasp.net/images/key-generator-home.png)

## Getting Started
To run this app outside of Visual Studio, you'll need the **.NET 8 SDK** installed on your machine (the version that is compatible with this project - 8.0). 

1. **Get the code (cloning the repository)** - You'll first need to get the code from Github. Follow these steps from your command line interface (CLI), such as Command Prompt, Powershell or Bash:<br/>
`git clone https://github.com/evanmalherbe/KeyGenerator.git`
2. **Navigate to project directory** - Now use the `cd` command to move into the directory that contains the project's `.csproj` file.<br/>
`cd KeyGenerator`
3. **Restore dependencies (optional but recommended):** Run the following command to download any necessary packages and dependencies. This is often done automatically, but this makes sure everything is in place.<br/>
`dotnet restore`
4. **Run the application:** Execute the project using the `dotnet run` command. <br/>`dotnet run`
5. **Access the application:** Once the application starts, the console output will show the urls where the app is listening. Usually, it will be something like `http://localhost:5000` or `http://localhost:5001`. Open your web browser (E.g. Microsoft Edge, Google Chrome etc) and type that address into your browser address bar to view the app.

## Usage
Once you open the project in your browser `http://localhost:5000` (or similar), you will see the homepage of the key generator. Take note of the **technical information** about the type of key being created, if that is of interest to you and then click the **Generate Key** button. See image below.<br/><br/>
![Key Generator homepage](https://image-store.premiumasp.net/images/key-generator1.png)<br/>

You will then be taken to the next page where you are given your new **64-byte (512-bit) key** to use as you see fit. Click the **Copy Key** button to copy it to your clipboard for pasting elsewhere or click the **Go Back to Generator** button to return to the homepage where you can create a new key, if you want to. See image below.<br /><br/>
![Key Generator key page](https://image-store.premiumasp.net/images/key-generator2.png)<br/>

## 🤝 Contributing
Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement" or "bug".

1.  Fork the Project
2.  Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3.  Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4.  Push to the Branch (`git push origin feature/AmazingFeature`)
5.  Open a Pull Request

## License
Distributed under the **MIT License**. See **[LICENSE](LICENSE)** for more information.

## Credits
This project was created by Evan Malherbe - November 2025 - [GitHub profile](https://github.com/evanmalherbe)
