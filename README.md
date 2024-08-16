# TPDataStructures

TPDataStructures is a Unity package for managing a collection of heterogeneous data. It provides methods to add, remove, and retrieve data in a safe and typed manner.

## Features

- Add data to the collection with a specific name.
- Retrieve data from the collection in a typed manner.
- Safe type handling.

## Installation

To install this package in your Unity project, follow these steps:

1. Open your Unity project.
2. Go to `Window` > `Package Manager`.
3. Click on the `+` button and select `Add package from git URL...`.
4. Enter the URL of the repository and click `Add`.

## Usage

Here is an example of how to use the `DataCollection` class in a Unity script:

```csharp
using com.trashpandaboy.datastructures;
using UnityEngine;

public class Example : MonoBehaviour
{
    void Start()
    {
        DataCollection dataCollection = new DataCollection();

        // Add data to the collection
        dataCollection.AddData("username", "trashpandaboy");
        dataCollection.AddData("age", 25);

        // Retrieve data from the collection
        if (dataCollection.TryGetData<string>("username", out string username))
        {
            Debug.Log($"Username: {username}");
        }

        if (dataCollection.TryGetData<int>("age", out int age))
        {
            Debug.Log($"Age: {age}");
        }
    }
}
```

## Contributing

If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a branch for your feature (`git checkout -b feature/feature-name`).
3. Commit your changes (`git commit -am 'Add a new feature'`).
4. Push the branch (`git push origin feature/feature-name`).
5. Open a Pull Request.

## License

This project is licensed under the Unlicense License. See the license file for more details.
