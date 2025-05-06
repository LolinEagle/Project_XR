# XR
A prototype featuring two interactive XR menus :
- Main Menu (Menu A) : Gaze-following distant-pointable UI
- Secondary Menu (Menu B) : Hand-manipulable contextual panel
## Features :
### Menu A (Main Menu)
Dynamically generates activity buttons Configurable button count via Inspector
Smooth head-gaze following behavior Ray-interactable buttons using XR
Interaction Toolkit
### Menu B (Context Menu)
Appears when a Menu A button is selected

Physical interactions :
- Grab & move
- Rotate

Displays :
- Activity description
- Sound playback button (activity-specific SFX)
Auto-updates when new Menu A selection is made

## Technical Implementation :
Core Components:
- Meta SDK (Base XR platform)
- XR Interaction Toolkit (Ray interaction & grab mechanics)
- World Space UI (Canvas setup)
- Modular Prefabs (MenuA.prefab, MenuB.prefab)
- ScriptableObjects (Activity data container)

## Setup :
1. Clone repository
2. Open in Unity 2022.3.9f1
3. Ensure Meta XR SDK is installed
4. Play in Editor (XR Simulator)
