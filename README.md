# Unity3D-soomla-IAP
Implementation of the soomla plugin in unity3D demo project.

<h4>Steps</h4>
1. Import the above package in you game. <br>
2. Drag the coreevent and storeevent prefabs from Assets\Soomla\Prefabs folder to the initial scene of your game. <br>
3. Also drag the UndestroyableObject for the Assets\Prefabs folder to your first scene. <br>
4. Do all the changes in your ExampleAssets.cs and ExampleWindow.cs and leave everything as it is. <br>
5. Define you all IAP in the ExampleAssets.cs script and call define all the function to make purchase in the ExampleWindow.cs. <br>
6. When taking refrence of ExampleWindow.cs in another script use namespace i.e using Soomla.Store.Example. <br>

That's it read carefully what the function do inside the <b>ExampleWindow.cs</b> script and implement your <b>StoreEvent.cs</b>. <br>

<h4>Note*** </h4>
1. Go to menu bar in your unity Window//Soomla and change the soomla secret key and make it as complex as you can for security purpose.<br>

<h4>For Android:</h4>
if you are building for android then in the window/soomla check the android chekbox and don't forget to paste you SHA Key from the IAP and Service from the developer console.

<h4>For IOS:</h4>
simply just enable the ios checkbox.

<h4>Cheers!</h4>
