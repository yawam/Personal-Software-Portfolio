from Basic_funcs import *


def App():

    running = True

    print("Welcome to a simple School Database App \n Where you can create records in a database, update the records and delete the records ")
    print("=================================================================================")

    while running == True:
        print("")
        print("What do you want to do today? (choose a number)")
        print("--------------------------------")
        user_input = int(input("1. Add a student \n2.Load students with file \n3. View a Student \n4. Update Student Records \n5. Delete Record \n6. Quit \n"))

        if user_input == 1:
            print("")
            print("--------------------------------------")
            id = int(input("ID: "))
            name = str(input("Name: "))
            age = int(input("Age: "))
            major = str(input("Major: "))

            add(id, name, age, major)
            print("Student has been added to the database")
            print("==================================================")

        if user_input == 2:
            file_name = input("Put in the file name: ")
            load_from_file(file_name)
            print("Students have been added to the database")

        
        if user_input == 3:
            print("")
            print("--------------------------------------")
            id = int(input("Enter the ID of the student you want to view "))
            read(id)

        if user_input == 4:
            print("")
            print("--------------------------------------")
            update_choice = int(input("1. Update Name \n2. Update Age \n3. Update Major \n"))
            if update_choice == 1:
                id = int(input("Enter the ID of the student you want to update: "))
                name = str(input("Put in the new name: "))

                update_name(id,name)
                print(f"Student {id}'s name has been updated in the data base")

            if update_choice == 2:
                id = int(input("Enter the ID of the student you want to update: "))
                age = int(input("Put in the new age: "))

                update_age(id,age)
                print(f"Student {id}'s age has been updated in the data base")
            
            if update_choice == 3:
                id = int(input("Enter the ID of the student you want to update: "))
                major = input("Enter the new major: ")

                update_major(id,major)
                print(f"Student {id}'s major has been updated in the data base")
        
        if user_input == 5:
            print("")
            print("--------------------------------------")
            id = int(input("Enter the ID of the student you want to delete: "))

            delete_record(id)
            print(f"Student {id}'s record has been deleted from the data base")

        if user_input == 6:
            running = False

            print("Database closed")
            