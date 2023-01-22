# this file will render the pages for the App

from tkinter import *


##########################################################
# Sign in Window
# my_window = Tk()
my_window.title("School Database Proj")

my_window.geometry("400x300+250+100")

frame_1 = Frame(my_window, bg="light grey", width=400, height=300, padx=10, pady=10)
frame_1.grid(row=0, column=0)


head_label = Label(frame_1, bg="white", fg="black", font=("Times New Roman", 25), text="SIGN IN" )
head_label.grid(row=0, columnspan=2)

frame_1.grid_propagate(0)
frame_1.grid_columnconfigure(0, weight=4)

email_label = Label(frame_1,bg="light grey", fg="black", font=("Arial italic", 10), text="Email")
email_label.grid(row=1, columnspan=2, pady=10)
email = Entry(frame_1, width=25, font=("arial", 15) )
email.grid(row=2, columnspan=2, pady=10)

password_label = Label(frame_1,bg="light grey", fg="black", font=("Arial italic", 10), text="Password")
password_label.grid(row=3, columnspan=2, pady=10)
password = Entry(frame_1, width=25, font=("arial", 15), textvariable="password", show='*' )
password.grid(row=4, columnspan=2, pady=10)

######################################################################





my_window.mainloop()

#layout
#1 Welcome page with possible authentication
#2 Options for functions
#3