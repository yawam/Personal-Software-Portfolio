import pyrebase  # Importing pyrebase which is a PIP module used to connect to a realtime database created in firebase
import json # Importing json module to allow imports from json
from dotenv import load_dotenv
import os

load_dotenv(".env")

info = os.environ.get("api_key")

#configuration with database reference from firebase (registering app)
config = {"apiKey": {info},
          "authDomain": "cloud-database-project-4b590.firebaseapp.com",
          "projectId": "cloud-database-project-4b590",
          "databaseURL":"https://cloud-database-project-4b590-default-rtdb.firebaseio.com/",
          "storageBucket": "cloud-database-project-4b590.appspot.com",
          "messagingSenderId": "640799059614",
          "appId": "1:640799059614:web:23ceac95959e599e09d58f",
          "measurementId": "G-LV163E8S6P"}

firebase = pyrebase.initialize_app(config)
database = firebase.database()
# This is a school database, where a user can Create, Read, Modify, and Delete student's records.. either as a whole or 
# will be importing Tkinter later for the GUI

#Layout
#1 Authentication
#2 Function options
#2 -Create/Add function
#  -Read function
#  -Update/Modify function
#  -Delete Students
#3 particular function page
#4 End of Program

def add(id,name, age, Major):

    data = {"Student-id": id, "Name":name, "Age":age, "Major":Major}
    database.child("Students").child(id).set(data)

def load_from_file(file_name):
    with open(file_name) as file:
        data = json.load(file)
        for item in data:
            for key,value in item.items():

                id = item["id"]
                name =item["Name"]
                age = item["Age"]
                major = item["Major"]

            add(id,name,age,major)



def read(id):

    student = database.child("Students").child(id).get()
    print(student.val())


def update_name(id, name):

    database.child("Students").child(id).update({"Name":name})

def update_age(id, age):

    database.child("Students").child(id).update({"Age":age})

def update_major(id, major):

    database.child("Students").child(id).update({"Major":major})

def delete_record(id):
    database.child("Students").child(id).remove()
