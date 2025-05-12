# Unity RPG Game – Proof of Concept

This is a technical prototype of a Fantasy RPG Game, developed in Unity as a **proof of concept** inspired by a structured game development course. The goal was to implement core RPG systems and demonstrate skills in **C# programming**, **game architecture**, and **UI/UX design**.

> This is not a full game. It is a technical demonstration of key RPG mechanics.

## Features Implemented

- Terrain and world layout using Unity's Terrain tools
- Inventory system with item pickup and UI slot management
- Mini-map overlay synced to player movement
- Basic shop system for buying ingredients
- Potion mixing (crafting) system to create magic attacks
- Enemy AI with NavMesh navigation and basic combat
- Player melee and ranged magic attacks
- Save/load system using PlayerPrefs and serialized data

## Project Structure

Assets/

- Scripts/ Core gameplay logic (Inventory, Combat, AI, UI)
- Prefabs/ Player, enemies, interactables
- Scenes/ Main demo scene
- UI/ Canvas-based menus and HUDs
- Resources/ Item data, icons, potion recipes

## How to Run

1. Open the project in **Unity 2021.3 LTS** or newer
2. Load the main scene located at `Scenes/MainRPG.unity`
3. Press **Play** to launch the prototype

## Technical Goals

- Write clean and modular C# code
- Demonstrate data-driven systems using ScriptableObjects
- Use Unity UI to drive gameplay interaction
- Show basic AI pathfinding and state logic using NavMesh

## Known Limitations

- No full gameplay loop or quest progression
- Placeholder assets and models (free or default Unity assets)
- No performance optimization or mobile testing

## Credits

Based on concepts and structure from the Udemy course _"Create an RPG Game in Unity"_ by Pete Jepson.

---

## Author

Developed by **Abba David**  
Software Engineer | Game Dev Enthusiast | Unity & Senior .NET Developer
