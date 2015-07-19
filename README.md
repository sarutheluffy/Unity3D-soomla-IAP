# Unity3D-soomla-IAP
Implementation of the soomla plugin in unity3D demo project
Steps
1. import the above package in you game 
2. drag the coreevent and storeevent prefabs from Assets\Soomla\Prefabs folder to the initial scene of your game
3.Also drag the UndestroyableObject for the Assets\Prefabs folder to your first scene
4. Do all the changes in your ExampleAssets.cs and ExampleWindow.cs and leave everything as it is 
5.Define you all IAP in the ExampleAssets.cs script and call define all the function to make purchase in the exampleWindow.cs
6.when taking refrence of ExampleWindow.cs in another script use namespace i.e using Soomla.Store.Example
that's it read carefully what the function do inside the exampleWindow script and implement your storeevent

Note*** 
1. Go to menu bar in your unity Window//Soomla and change the soomla sectret key and make it as complex as you can

for Android:
if you are building for android then in the window/soomla check the android chekbox and don't forget to paste you SHA Key from the IAP and SErvice from the 
developer console.

for IOS:
simmpli just checkt the ios checkbox.


That's all 
Thanks
Regards
Rinku saru 
Game Dev.
