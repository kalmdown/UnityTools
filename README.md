# UnityTools
Scripts I have created to solve issues I have in Unity. 

## Objects Ring
Evenly distributes a set of objects around another object.
![Object Ring](/images/ObjectRing.png)

1) Create an object in the in Hierarchy - Ex. an *Empty*.  
2) Rename to something useful - Ex. "ObjectRing".
3) Add ObjectRing.cs script to **ObjectRing** *GameObject*.
4) Add objects to **ObjectRing**.

The order of the objects in the hierarchy determines the order around the ring.

### Inspector
Radius - distance from parent object.
Begin Angle - 0-360 - From Top view, sets 1st object angle.
End Angle - 360-0 - From Top view, sets last object angle.
Flip - Flips which end faces center. Most useful for text. 
Orientation - Sets whether object has default orientation or towards center.

*Issue* - Adding objects does not immediatly update. Have to move a slider to get objects to upate.
*Issue* - Need to create on Orientation inspector.

## Switch Cameras
Framework to puts a *Switch Cameras* menu in the Editor.

File requires editing to match the cameras in your scene. 

## Create New Prefab
Just making: https://docs.unity3d.com/ScriptReference/PrefabUtility.html into a menu item.

Puts an item in a *Tool* menu called **Create New Prefab** that allows user to turn multiple objects in Hierarchy into individual Prefabs. 






