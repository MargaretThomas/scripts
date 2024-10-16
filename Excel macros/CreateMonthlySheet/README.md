### How to Use the Macro

1.  **Open Excel**: Open the workbook where you want to add this macro.
2.  **Access VBA Editor**: Press `ALT + F11`.
3.  **Insert Module**: Right-click on any item in the Project Explorer, choose `Insert`, then `Module`.
4.  **Copy the Code**: Paste the code into the module window.
5.  **Run the Macro**: Press `F5` in the editor or return to Excel, press `ALT + F8`, select `CreateMonthlyTaskSheet`, and click `Run`.

### Breakdown of the Code

1.  **Sheet Name**: The worksheet is named with the current month and year (formatted as "Month Year").
2.  **Existence Check**: The code checks if a sheet with that name already exists. If it does, a message box appears, and the macro exits.
3.  **Table Setup**:
    -   **Headers**: The first row contains "Date" and "Task".
    -   **Date Population**: For each day of the month, five rows are created:
        -   The first row has the formatted date (e.g., "Monday 01-Jan-2024") and is aligned to the right.
        -   The next four rows are left empty for task entries.
4.  **Table Creation**: A table is created over the defined range with the specified style.
5.  **Column Widths**: The width of the columns is adjusted for readability.