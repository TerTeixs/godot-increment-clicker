# Godot Increment Clicker (C#)
### A game inspired by Cookie clicker
### Every Script is written in C#
#### This repo is missing art and sounds
#### Video URL : https://youtu.be/faRa9erpM9c
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
## Fonts Folder
#### Replace font-family within this game to minecraft fonts
## Arts Folder
#### Contain image of icon, texture, background
## Sounds Folder
#### Contain sound effect of clicking steak and buy worker
## &#x1F4C4; .tscn File
#### Contain configuration of each Godot scece 