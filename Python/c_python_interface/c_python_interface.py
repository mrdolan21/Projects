import ctypes
from ftplib import B_CRLF
import customtkinter as ctk
# import tkinter as tk
from tkinter import ttk, filedialog, messagebox
from PIL import ImageTk, Image
import os

c_library = ctypes.CDLL("clib.so")

# Ctypes Data Structure
class Data(ctypes.Structure):
    _fields_ = [
        ("ch", ctypes.c_char),
        ("str", ctypes.c_char_p),
        ("str2", ctypes.c_char_p),
    ]

def resize_image(image_path, width, height):
    image = Image.open(image_path)
    resized_image = image.resize((width, height))
    return resized_image

def open_image():
    global file_path
    file_path = filedialog.askopenfilename(
        filetypes=[("Image files", "*.bmp;*.png;*.jpg;*.jfif;*.jpeg")]
    )
    if file_path:
        show_input_image(file_path)

def show_input_image(image_path):
    original_image = Image.open(image_path).resize([240,240])

    original_photo = ImageTk.PhotoImage(original_image)

    DisplayOG_Img_Label.configure(image=original_photo)
    DisplayOG_Img_Label.image = original_photo

def show_output_image():
    output_image = Image.open(outImg_Path).resize([480,480])

    output_photo = ImageTk.PhotoImage(output_image)

    DisplayFil_Img_Label.configure(image=output_photo)
    DisplayFil_Img_Label.image = output_photo


def apply_filter(ch, path2):
    if file_path[-3:] != "bmp":
        path = file_path[:-4]
        path = path + ".bmp"
        Image.open(file_path).convert("RGB").save(path)
    else:
        path = file_path

    path = path.encode("utf-8")
    path2 = path2.encode("utf-8")

    # Call the resize_image function
    resized_image = resize_image(path, 600, 400)

    # Save the resized image to a temporary file
    resized_image_path = "resized.bmp"
    resized_image.save(resized_image_path)

    # Access the C function
    apply_c_filter = c_library.c_filter

    # Define the argument and return types of the function
    apply_c_filter.argtypes = [ctypes.POINTER(Data)]
    apply_c_filter.restype = None

    # Call the C function
    data = Data()
    data.ch = ch.encode("utf-8")
    data.str = resized_image_path.encode("utf-8")
    data.str2 = path2
    apply_c_filter(ctypes.byref(data))

    # Remove the temporary resized image file
    resized_image.close()
    os.remove(resized_image_path)

global allPaths
allPaths = list()

def grayscale():
    global outImg_Path
    outImg_Path = file_path[:-4]
    outImg_Path = outImg_Path + "_out_g.bmp"
    allPaths.append(outImg_Path)
    apply_filter("g", outImg_Path)
    show_output_image()

def reflect():
    global outImg_Path
    outImg_Path = file_path[:-4]
    outImg_Path = outImg_Path + "_out_r.bmp"
    allPaths.append(outImg_Path)
    apply_filter("r", outImg_Path)
    show_output_image()

def blur():
    global outImg_Path
    outImg_Path = file_path[:-4]
    outImg_Path = outImg_Path + "_out_b.bmp"
    allPaths.append(outImg_Path)
    apply_filter("b", outImg_Path)
    show_output_image()

def edges():
    global outImg_Path
    outImg_Path = file_path[:-4]
    outImg_Path = outImg_Path + "_out_e.bmp"
    allPaths.append(outImg_Path)
    apply_filter("e", outImg_Path)
    
    show_output_image()

def sepia():
    global outImg_Path
    outImg_Path = file_path[:-4]
    outImg_Path = outImg_Path + "_out_s.bmp"
    allPaths.append(outImg_Path)
    apply_filter("s", outImg_Path)

    show_output_image()

def removeImg():
    if outImg_Path:
        os.remove(outImg_Path)
        print("Removed succesfully.")
    else: 
        print("Removed unsuccesfully.")

def removeAll():
    if allPaths:
        for item in allPaths:
            os.remove(item)
            allPaths.clear()
            print("Removed succesfully.")
            
    else: 
        print("Removed unsuccesfully.")

def close_window():
    if messagebox.askokcancel("Quit", "Do you want to quit?"):
        if allPaths:
            if messagebox.askyesno("Delete Files", "Do you want to erease all data?"):
                root.destroy()
                removeAll()
            else:
                root.destroy()
        else:
            root.destroy()

# Tk Main window
ctk.set_appearance_mode("dark")  # Modes: system (default), light, dark
ctk.set_default_color_theme("blue")
root = ctk.CTk()
root.title("Filter More")
root.geometry("1280x700")
root.configure(bg="gray70")

root.wm_attributes('-transparentcolor', '#ab23ff')

ogImg_Label = ctk.CTkLabel(root, text="Original Image",font=("Helvetica", 28, "bold"))
ogImg_Label.place(x = 180, y = 10)

filtImg_Label = ctk.CTkLabel(root, text="Filtered Image",font=("Helvetica", 28, "bold"))
filtImg_Label.place(x = 870, y = 10)

def left():
    # bg frame
    buttons_frame  =  ctk.CTkFrame(root,  width=180,  height=150, fg_color="#000000")
    buttons_frame.place(x = 25, y = 480)

    functions_label = ctk.CTkLabel(root,text = "Functions", font=("Helvetica", 16, "bold"), bg_color="#000000")
    functions_label.place(x = 35, y = 480)

    # Buttons
        # Open image
    button_open = ctk.CTkButton(root, text="Open Image", command=open_image)
    button_open.place(x = 35, y = 510)
        # Delete image
    button_del = ctk.CTkButton(root, text="Delete Current Image", command=removeImg)
    button_del.place(x = 35, y = 550)
        # Delete all filtered images
    button_delAll = ctk.CTkButton(root, text="Delete all created images", command=removeAll)
    button_delAll.place(x = 35, y = 590)

def line():
    separator = ctk.CTkFrame(root,width=10,height=720,fg_color="gray80")
    separator.place(x=640,y=0)

def right():
    filters_frame  =  ctk.CTkFrame(root,  width=330,  height=150, fg_color="#000000")
    filters_frame.place(x = 230, y = 480)

    filters_label = ctk.CTkLabel(root,text = "Filters", font=("Helvetica", 16, "bold"), bg_color="#000000")
    filters_label.place(x = 240, y = 480)

    button_grayscale = ctk.CTkButton(root, text="Grayscale", command=grayscale)
    button_grayscale.place(x = 240, y = 510)

    button_reflect = ctk.CTkButton(root, text="Reflect", command=reflect)
    button_reflect.place(x = 240, y = 550)

    button_blur = ctk.CTkButton(root, text="Blur", command=blur)
    button_blur.place(x = 410, y = 510)

    button_edges = ctk.CTkButton(root, text="Edges", command=edges)
    button_edges.place(x = 410, y = 550)

    button_sepia = ctk.CTkButton(root, text="Sepia", command=sepia)
    button_sepia.place(x = 330, y = 590)

# Labels for the images
DisplayOG_Img_Label = ctk.CTkLabel(root,text= "")
DisplayOG_Img_Label.place(x = 160, y = 80)

DisplayFil_Img_Label = ctk.CTkLabel(root,text= "")
DisplayFil_Img_Label.place(x = 730, y = 150)


root.protocol("WM_DELETE_WINDOW", close_window)
left()
line()
right()
# show_bg_image()
root.mainloop()
