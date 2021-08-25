# RecipeApp

## Notes
This is the first version of the program, it is buggy and its not always behaving as expedted. It's also my first C# program so the code is certainly not good,
but it was a fun project. 
the main screens and features are presented below, but generally its used for:
- Saving recipes and their ingredients
- Make a menu for the week of a selection of the recipes above
- making a automated "shopping list" for the ingredients/items needed for these recipes
- Save this list to a .CSV file or uploading to MySQL server 

## current Issues/limitations 

- if something else than american region setting is used in windows settings, the output can look wierd. this is becouse this setting controls whether "," or "." is used for decimals
- when a new ingredient is added in the Recipe pages, the list of ingredients may not be updated. sometimes a refresh of the page is needed ( which defeats the purpose of that button)
- there are very few error checks in the textfields, be careful when used
- in the menu page, if a recipe is choosed for one day there is no option to make it empty again. 



## First screen
First screen of loading the app, does nothing useful really
![Screenshot 2021-08-25 110211](https://user-images.githubusercontent.com/66086794/130761933-15966e2d-12b1-4f95-8ae3-9a437fc56b8d.jpg)

## Server Login
Used if a Mysql server has been setup. When edited and the button "log in" is clicked, the resulting menu's ingredients will be pushed to a MySQL database. 
It's optionally to use this. If not used, a csv file will be used instead. 

![Screenshot 2021-08-25 110311](https://user-images.githubusercontent.com/66086794/130762185-b3a98979-4ab8-40ad-be52-94d1bb9cf711.jpg)

## Recipe Page
Is used to add recipes to the database, but to be able to use it, Ingredients need to be added already. Tags can be added, but they do nothing useful for now. 

![Screenshot 2021-08-25 110330](https://user-images.githubusercontent.com/66086794/130762275-a62b4523-62dd-4fb3-8717-f97e81ae9c5f.jpg)

## Ingredient Page
The ingredients of the database is listed and a simple menu to add or remove ingredients. 
![Screenshot 2021-08-25 110236](https://user-images.githubusercontent.com/66086794/130762346-eedecd4c-839a-4fd4-9139-ba0501a70664.jpg)

## Menu Page
This is the page where one chooses or randomizes which recipes to add to the menu of the current week. when the button "check" is clicked, the right pane shows all the ingredients
and one will be able to edit the amount (maybe one already have the particular item at home) or remove it entierly. Its also possible to add unrelated ingredients/items to the shopping list. 
When "Create menu" is clicked, the items are made into a csv file and if the login option is used, uploaded to the specified MySQL server.

![Screenshot 2021-08-25 110301](https://user-images.githubusercontent.com/66086794/130762390-84207268-3991-46fb-8dcd-60721619b37f.jpg)
