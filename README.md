# Note Taking Application

Welcome to the Note Taking Application README! This application allows users to create, view, and delete notes stored in a SQL Server database. It's a simple yet effective tool for organizing your thoughts and ideas.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Add Note**: Enter a title and content for your note, then save it to the database.
- **View Note**: Retrieve and display the content of a note based on its title.
- **Delete Note**: Remove a note from the database using its title.

## Getting Started

### Prerequisites

Before running the Note Taking Application, ensure you have the following installed:

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. Clone this repository to your local machine using `git clone`.
2. Open the solution file (`NoteTakingApp.sln`) in Visual Studio.
3. Build the solution to restore NuGet packages and compile the project.
4. Set up a SQL Server database named `NoteDB`.
5. Run the SQL scripts provided in the `SQL_Scripts` directory to create the necessary table and populate it with sample data.

## Usage

1. Launch the application by running the project in Visual Studio.
2. Enter a title and content for your note.
3. Click the **Add** button to save the note to the database.
4. To view a note, enter its title in the designated field and click the **View** button.
5. To delete a note, enter its title in the designated field and click the **Delete** button.

## Contributing

Contributions are welcome! If you'd like to enhance the Note Taking Application, feel free to fork this repository and submit a pull request. Please adhere to the [code of conduct](CODE_OF_CONDUCT.md).

## License

This project is licensed under the [MIT License](LICENSE).
