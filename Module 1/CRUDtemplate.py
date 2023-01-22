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