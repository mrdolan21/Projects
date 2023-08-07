import customtkinter as ctk
from PIL import Image, ImageTk

root  =  ctk.CTk()  # create root window
root.title("Basic GUI Layout with Grid")



bg_label = ctk.CTkLabel(master=root)
bg_label.grid(row=0, column=0,sticky='w'+'e'+'n'+'s')





original_image = Image.open()
#original_image.thumbnail((700, 700))
original_photo = ImageTk.PhotoImage(original_image)
bg_label.configure(image=original_photo)
bg_label.image = original_photo

root.mainloop()