# WPF_Application
A WPF application created for my midterm assignment using C# and .NET technologies. 

It contains 4 pages.

The first page contains 
- a status bar, 
- a button, 
- a check box, and 
- a textbox. 
The status bar at the bottom of the page contains 2 labels, one displaying the check status of the checkbox, and the other containing the current text in the textbox.
The button and the checkbox are always centered and never resized. 
The textbox resizes as the window resizes and does not allow the characters ‘Q’, ‘q’, ‘Y’, ‘y’, ‘Z’ or ‘z’.

The second page contains a text block and text with decorations.

The third page contains expander controls that cannot be open at the same time. 
The first expander control contains a slider and its label.
The second expander control contains an image. When the mouse is not hovering over the image, it’s height matches exactly that of the expander’s grid height, regardless of the grid width. When the mouse is hovering over the image, it’s width matches exactly that of the expander’s grid width, regardless of the grid height.

The fourth page contains two buttons that open a parent and a child window (WPF forms).
When the user clicks the button to open a child Window,
- If a parent window does not exist, show an error message; and
- If a parent and a child window already exist show an error message.
