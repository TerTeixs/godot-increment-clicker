# Godot Increment Clicker (C#)
### A game inspired by Cookie clicker
#### This repo is missing art and sounds
#### Game File : https://drive.google.com/file/d/1XIpL8vKr0WDi8Wrt2yPdMwj8nEkhw5kk/view?usp=drive_link
#### Video Demo : https://youtu.be/faRa9erpM9c
## How to run
1. Download zip file from google drive
2. Unzip godot-increment-clicker file
3. Run Increment Clicker.exe file
## How to play
#### Click on steak image to gain steak (On left side)
#### Click on store to buy worker cursor, chef, farm  (On Right side)
## Description
#### Godot Increment Clicker is a game that allow player to click on steak and rewarding player each time player click on steak
#### Player can use steak to buy worker (cursor, chef, farm) to increase steak production per second rinse and repeat
#### This game rewarding system is number go up
#### Image and sound effect is from Minecraft 
#### This game was developed using Visual studio code and Godot engine
### Every Script is written in C#
## Why Godot ?
#### Godot is open-source game engine i want to familar with this software and its free! 
## Why C# instead of GDScript?
#### I want to get familar of writing code in C# and want to see how much different between C# and C
## Platform
### Window 64-bits
#### I want this game to be playable on website but since i use C# as main langauge Godot unable to compile this game for website (sadge!)
## Scripts Folder
### &#x1F4C4; Hud.cs 
#### Contain function and GUI of displaying total player steak, Steak produce per sec, calling toast function when player doesn't have enough steak to buy worker
#### GUI for store function when player buy worker decrease player steak and update produce per sec
### &#x1F4C4; Main.cs 
#### Contain function initialize timer of production (50ms) and calculate production per second with timer 
### &#x1F4C4; PlayerStats.cs 
#### Contain globals variable for storing player data and produce function (Steak Per Click, Produce per sec, Update Produce Per sec)
### &#x1F4C4; Steak.cs 
#### Contain function for clicking steak and animation/sound of steak when clicked
### &#x1F4C4; Toast.cs 
#### Contain function for displaying and animation of fading message when player doesn't enough steak to buy worker
## &#x1F4C4; .tscn File
#### Contain configuration of each Godot scece
## main.tscn file
#### Main scene for combine every other scene to display game 
## steak.tscn file
#### Scene of steak and signal to connect function to C# file (Steak.cs)
## hud.tscn file
#### Scene of HUD and signal to connect function to C# file (Hud.cs)
## Fonts Folder
#### Replace font-family within this game to minecraft fonts
## Arts Folder
#### Contain image of icon, texture, background
## Sounds Folder
#### Contain sound effect of clicking steak and buy worker