# Farm Management System

This repository contains the code for a Farm Management System, called SmartCrop providing various functionalities to help farmers manage their farms effectively. Below is an overview of the features and user interactions within the system.

### Farm Management Api

#### User Interactions:
1. **Update Farm Information:**
   - Users can update the information related to their farm, such as farm name, location, size, and type of produce.
   - Upon clicking the "Update" button, users are presented with a form pre-filled with existing farm information, allowing them to make changes.
   - Form validation ensures that required fields are filled and data is in the correct format.
   - After submitting the updated information, users receive a confirmation message.

2. **Delete Farm:**
   - Users have the option to delete their farm from the system.
   - Clicking the "Delete" button triggers a confirmation prompt to ensure the user intends to proceed.
   - Upon confirmation, the farm record is removed from the database, and users receive a confirmation message.

3. ** Maybe New Farm:**
	- New User can add there farms 
	- Users have the abilty to add an address 

### Nearest City to Farm SelectFarmsByCity API

#### User Interactions:
1. **Display Nearest City:**
   - Users enters a city and are presented with information about the nearest city to their farm location.
   - The page utilizes the farm's coordinates to calculate the nearest city using a geographic algorithm.
   - Users can view details such as city name, distance from the farm, and relevant demographic or market information.
   - An interactive map may accompany the information to provide visual context.


### Farm Weather Forecast API GetWeatherByID

#### User Interactions:
1. **Display Weather Forecast:**
	- Users enters a ID and are presented with information weather data for the farm's location
   - Utilizing the NOAA API, the page fetches real-time weather data for the farm's location.
   - Users can view current weather conditions, temperature, humidity, wind speed, and precipitation forecast.
   - The weather forecast is presented in an easily understandable format, possibly with graphical representations.
   - Users have the option to toggle between hourly, daily, or weekly forecasts for planning purposes.

2. **Weather Alert Notifications:**
   - Users receive weather alert notifications for severe weather conditions that may affect their farm operations.
   - Alerts are displayed prominently on the page with recommended actions for mitigation.
   - Users can also choose to receive alert notifications via email or SMS for immediate attention.

#### Homepage

### User Interactions:
1. **Welcome Message:**
   - The homepage welcomes users to the platform with a brief overview of its purpose and features.
   - A visually appealing layout and design elements enhance user engagement and navigation.

2. **Navigation Menu:**
   - A clear and intuitive navigation menu allows users to access different sections of the website easily.
   - Menu options include links to dynamic pages such as Farm Management, Nearest City, Farm Weather Forecast, Weather Dashboard, and User Profile.
   - Additionally, there may be links to About Us and Contact pages for more information and support.

### Weather Dashboard

A dynamic page displaying real-time weather information using an external weather API.
- Users can view current weather conditions, temperature, humidity, and other relevant data.
- Interactive elements for users to search for weather information of specific locations.
- Option to view weather forecasts for the upcoming days.

### User Profile

A dynamic page displaying user-specific information and activity.
- Users can view and edit/delete their submitted observations if needed.
- Profile customization options such as changing profiles or updating personal information.

## Two Branches 
There are two branches there is the main branch and two different branches Logan's branch and Ahmed's branch. 

## Installation

To run this Farm Management System locally, follow these steps: use logan's branch

1. Clone this repository to your local machine. https://github.com/Logan-Kranis/Assignment-4-Creating-APIs
2. For mock data and my procedures there is folder called SQL
3. RUN DatabaseCreation.sql
4. RUN Farmseeddata.sql
5. RUN Farmseeddata.sql
6. RUN LoganKranisSP.sql


## Resources
1. https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.defaulthttpcontextfactory?view=aspnetcore-5.0
2. https://stackoverflow.com/questions/1260952/how-to-execute-a-stored-procedure-within-c-sharp-program
3. https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection
4. ChatGTP The prompt 'make mock data for my tables' as weell as debugging
5. For the map and js for the map https://leafletjs.com/
6. map from https://www.openstreetmap.org/copyright
## Contributors

- Logan Kranis
- Ahmed Ismail


## Pages assigment5
Logan Kranis made the Weather,Home,Privacy, and Farm pages.
