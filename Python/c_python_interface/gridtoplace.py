import ctypes
import customtkinter as ctk
# import tkinter as tk
from tkinter import ttk, filedialog, messagebox
from PIL import ImageTk, Image
import os

# C:\\Users\\jemartinez\\Downloads\\bg_gradient.jpg

# Tk Main window
ctk.set_appearance_mode("dark")  # Modes: system (default), light, dark
ctk.set_default_color_theme("blue")
root = ctk.CTk()
root.title("Filter More")
root.geometry("1280x720")


bg_image = Image.open("C:\\Users\\jemartinez\\Downloads\\bg_gradient.jpg").resize([1280,720])
# bg_image.thumbnail(size='1280x720')
bg_label = ctk.CTkLabel(root)
bg_image = ImageTk.PhotoImage(bg_image)
bg_label.configure(image=bg_image)
bg_label.place(x=0, y =0)


ogImg_Label = ctk.CTkLabel(root, text="Original Image")
ogImg_Label.place(x=0, y =0)


left_frame  =  ctk.CTkFrame(root,  width=200,  height=  200)
left_frame.place(x = 50, y = 400)

button_grayscale = ctk.CTkButton(root, text="Grayscale", border_spacing=20)
button_grayscale.place(x = 55, y = 410)


root.mainloop()
