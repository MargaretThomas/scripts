Prompt:

Please write JavaScript code that performs the following tasks:

1. Select an unordered list with the class names `structural`, `retable`, and `stdHeight`.
2. Initialize an empty array called `data` to store objects containing `date`, `title`, and `icon` properties.
3. Check if the unordered list is found:
   - If found:
     - Select all list items within the unordered list with the class name `retableRow`.
     - Loop through each list item and perform the following:
       - Select a `div` element with the class name `col date nowrap` to get the date.
       - Select a `div` element with the class name `col title` to get the title.
       - Select a `div` element with the class name `col rating nowrap` to get the rating.
       - Check if all three elements (date, title, and rating divs) are found:
         - Get the text content of the date and title `div` elements.
         - Select all `button` elements within the rating `div`.
         - Initialize a variable `iconName` to store the icon name.
         - Loop through each `button` and perform the following:
           - Select all `svg` elements within the button.
           - Loop through each `svg` element and perform the following:
             - Get the value of the `data-icon` attribute.
             - Check if the `data-icon` attribute contains the text "Fill". If it does, set `iconName` to the icon name.
         - Create an object with `date`, `title`, and `iconName`, and push it to the `data` array.
     - Log the resulting `data` array to the console.
   - If the unordered list is not found, log an error message to the console stating that the unordered list was not found.
