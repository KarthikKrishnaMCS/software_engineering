# A08 | SOLID - Interface Segregation Principle |  Office Equipment Capabilities

## Project Overview
This project models various office equipments (printers,scanners, and multifunction devices) to demonstrate the **Interface Segregation Principle**. The architecture ensures that device classes are never forced to implement capabilities they do not support.

## Architecture & Capabilities

The system is broken down into two function specific interfaces rather than a single interface.

*   **`IPrinter`**: Exposes only the `Print(string document)` capability.
*   **`IScanner`**: Exposes only the `Scan()` capability.

### Device Implementations
1.  **`SimplePrinter`**: Implements *only* `IPrinter`.
2.  **`SimpleScanner`**: Implements *only* `IScanner`.
3.  **`MultiFunctionDevice`**: Implements *both* `IPrinter` and `IScanner`.

![UML_Diagram](UML_Diagram.png)

## Composition of Capabilities
To prevent duplicate code, the `MultiFunctionDevice` utilizes **Composition**. Rather than defining its own printing and scanning logic from scratch, it acts as a composite class. It takes in an `IPrinter` and an `IScanner` component via its constructor and simply assigns the tasks to those dedicated internal components when its methods are invoked.


