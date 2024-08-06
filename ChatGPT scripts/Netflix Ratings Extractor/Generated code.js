// Select the unordered list with the class names 'structural', 'retable', and 'stdHeight'
const unorderedList = document.querySelector('ul.structural.retable.stdHeight');

// Initialize an empty array called 'data' to store objects containing 'date', 'title', and 'icon'
const data = [];

// Check if the unordered list is found
if (unorderedList) {
  // Select all list items within the unordered list with the class name 'retableRow'
  const listItems = unorderedList.querySelectorAll('li.retableRow');
  
  // Loop through each list item
  listItems.forEach((listItem) => {
    // Select the 'div' element with the class name 'col date nowrap' to get the date
    const dateDiv = listItem.querySelector('div.col.date.nowrap');
    
    // Select the 'div' element with the class name 'col title' to get the title
    const titleDiv = listItem.querySelector('div.col.title');
    
    // Select the 'div' element with the class name 'col rating nowrap' to get the rating
    const ratingDiv = listItem.querySelector('div.col.rating.nowrap');
    
    // Check if all three elements (date, title, and rating divs) are found
    if (dateDiv && titleDiv && ratingDiv) {
      // Get the text content of the date and title 'div' elements
      const date = dateDiv.textContent.trim();
      const title = titleDiv.textContent.trim();
      
      // Select all 'button' elements within the rating 'div'
      const buttons = ratingDiv.querySelectorAll('button');
      
      // Initialize a variable 'iconName' to store the icon name
      let iconName = '';
      
      // Loop through each 'button'
      buttons.forEach((button) => {
        // Select all 'svg' elements within the button
        const svgs = button.querySelectorAll('svg');
        
        // Loop through each 'svg' element
        svgs.forEach((svg) => {
          // Get the value of the 'data-icon' attribute
          const dataIcon = svg.getAttribute('data-icon');
          
          // Check if the 'data-icon' attribute contains the text "Fill"
          if (dataIcon && dataIcon.includes('Fill')) {
            iconName = dataIcon;
          }
        });
      });
      
      // Create an object with 'date', 'title', and 'iconName', and push it to the 'data' array
      data.push({ date, title, icon: iconName });
    }
  });
  
  // Log the resulting 'data' array to the console
  console.log(data);
} else {
  // Log an error message to the console stating that the unordered list was not found
  console.error('Unordered list with the specified class names was not found.');
}
