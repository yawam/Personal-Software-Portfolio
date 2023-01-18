# Importing pyrebase which is a PIP module used to connect to a realtime database created in firebase
import pyrebase



#configuration with database reference from firebase (registering app)
config = {"apiKey": "AIzaSyDfoSivmPWp78Ayft7vHyxzENdVqm2DdTo",
          "authDomain": "cloud-database-project-4b590.firebaseapp.com",
          "projectId": "cloud-database-project-4b590",
          "databaseURL":"https://cloud-database-project-4b590-default-rtdb.firebaseio.com/",
          "storageBucket": "cloud-database-project-4b590.appspot.com",
          "messagingSenderId": "640799059614",
          "appId": "1:640799059614:web:23ceac95959e599e09d58f",
          "measurementId": "G-LV163E8S6P"}

# simple CRUD operation tests

firebase = pyrebase.initialize_app(config)
database = firebase.database()

#firebase holds data in json(NOsql... key value pairs)

data = {"Age": 51 , "Name": "Gabriel", "Likes Pizza": "False"}

#_____________________________________________________________________________________
#adding(create data) to database

# database.push(data)

#database.child("Users").child("firstPerson").set(data)

#__________________________________________________________________________________
#reading data from the database

# gabriel = database.child("Users").child("firstPerson").get()
# print(gabriel.val())

#__________________________________________________________________________________
#Update Data

# database.child("Users").child("firstPerson").update({"Name":"John"})

#__________________________________________________________________________________
#Remove Data

# Deleting One Value
# database.child("Users").child("firstPerson").child("Age").remove()

#Deleting whole Node

# database.child("Users").child("firstPerson").remove()