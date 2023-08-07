import customtkinter as ctk
from PIL import Image, ImageTk

root  =  ctk.CTk()  # create root window
root.title("Basic GUI Layout with Grid")
root.maxsize(900,  600)  # width x height


original_photo = Image.open("C:\\Users\\jemartinez\\Downloads\\bg_gradient.jpg")
#original_photo.thumbnail((150, 150))

bg_label = ctk.CTkLabel(master=root, image=original_photo)
bg_label.grid(row=0, column=0)

# Create left and right frames
left_frame  =  ctk.CTkFrame(root,  width=200,  height=  400)
left_frame.grid(row=0,  column=0,  padx=10,  pady=5)

right_frame  =  ctk.CTkFrame(root,  width=650,  height=400)
right_frame.grid(row=0,  column=1,  padx=10,  pady=5)

# Create frames and labels in left_frame
"""
Label(left_frame,  text="Original Image",  relief=RAISED).grid(row=0,  column=0,  padx=5,  pady=5)
image  =  PhotoImage(file="C:\\Users\\jemartinez\\Downloads\\bg_gradient.jpg")  # edit the file name to use a different image
original_image  =  image.subsample(3,3)
"""

#Label(left_frame,  image=original_image).grid(row=1,  column=0,  padx=5,  pady=5)
#Label(right_frame,  image=image,  bg='grey').grid(row=0,  column=0,  padx=5,  pady=5)

tool_bar  =  ctk.CTkFrame(left_frame,  width=180,  height=185)
tool_bar.grid(row=2,  column=0,  padx=5,  pady=5)

def clicked():
    '''if button is clicked, display message'''
    print("Clicked.")

# Example labels that serve as placeholders for other widgets
ctk.CTkLabel(tool_bar,  text="Tools").grid(row=0,  column=0,  padx=5,  pady=3,  ipadx=10)
ctk.CTkLabel(tool_bar,  text="Filters").grid(row=0,  column=1,  padx=5,  pady=3,  ipadx=10)

# For now, when the buttons are clicked, they only call the clicked() method. We will add functionality later.
ctk.CTkButton(tool_bar,  text="Select",  command=clicked).grid(row=1,  column=0,  padx=5,  pady=5,  sticky='w'+'e'+'n'+'s')
ctk.CTkButton(tool_bar,  text="Crop",  command=clicked).grid(row=2,  column=0,  padx=5,  pady=5,  sticky='w'+'e'+'n'+'s')
ctk.CTkButton(tool_bar,  text="Rotate &amp; Flip",  command=clicked).grid(row=3,  column=0,  padx=5,  pady=5,  sticky='w'+'e'+'n'+'s')
ctk.CTkButton(tool_bar,  text="Resize",  command=clicked).grid(row=4,  column=0,  padx=5,  pady=5,  sticky='w'+'e'+'n'+'s')
ctk.CTkButton(tool_bar,  text="Black &amp; White",  command=clicked).grid(row=1,  column=1,  padx=5,  pady=5,  sticky='w'+'e'+'n'+'s')
root.mainloop()