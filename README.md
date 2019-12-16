# Book Store Web Application

## Back End Source Code

The backend is implemented by using asp.net core 3.0.
It provides Api to get the books and buy book

 1. Api Get Books: this api support to get the data from multiple reources like : restful api, json, csv so, I create IBookEnquiryService interface and 3 concrete class BookEnquiryApiService, BookEnquiryCSVService, 
BookEnquiryCSVService to implement this interface. This design follow Single Responsibility Principle and Open/Closed Principle. Now the problem is that when I use DI, I cannot select the right service to get the books. To resolve that, I created ServiceProvider to select the right service to get the books.
2. Api buy book: this api is used to create random information of delivery.

## Front End
- The front end code is totally implemented by using Vuejs. I thinks VueJS mixes the Best of Angular + React. 
- This source code is kept in separate from backend code because it's in development period. 
- To run this project, you can follow the readme inside the folder bookstore-client.
- Please note that you must run the project backend first and then run the front end project.
- You should use VSCode to open the front end project.
