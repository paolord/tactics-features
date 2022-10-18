# Getting Started

### Creating a Character Type in the Unity Editor
1. In the Project view
2. Open the `Scriptable Objects` directory
3. Open the `Monsters` directory
4. Right-Click and select `Create` then select `Scriptable Objects` then select `Monster`
5. Look for the previously created monster, this the one with highest number in the filename
6. Rename the file with the format `<number>_<name>` with the next number from the last monster.
7. Go to the Inspector Panel, fill out the `Monster Name`, `Attack` and `Defense` values.
8. If the Sprite is prepared before hand, it should be in the `Assets\Sprites` directory
9. In the Sprite selector, search for the prepared sprite and select it.

> **NOTE:** Make sure the sprite PPU matches the rest of the project

### Creating an Encounter
1. In the Project view
2. Open the `Scriptable Objects` directory
3. Open the `Encounters` directory
4. Right-Click and select `Create` then select `Scriptable Objects` then select `Encounter`
5. Rename it with the format `<Arc>_<Chapter>_<Description Name>`.
6. Go to the Inspector Panel, `Enemies` is for CPU controlled units.

### Creating a Battle Area Formation
Formations are loaded at the start of the scene, it depends on the story progression before the encounter.

If the Good guys were sneaky and managed to surprise the enemies, they have advantages spawn positions.

If the good guys get ambushed, the enemies will have the advantage. In the end it depends on the designer's discretion.

1. In the Project view
2. Open the `Scriptable Objects` directory
3. Open the `Formations` directory
4. Right-Click and select `Create` then select `Scriptable Objects` then select `Formation`
5. Rename it with discriptive a name in Camel case format.
6. Go to the Inspector Panel, Add a short description of the scenario in `Description`
7. `Player Positions` is for player controlled units, Maximum of **6** vector2 elements only.
8. `Enemy Positions` is for CPU controlled units.

### Creating a Battle Area
TBD