
# react-native-badminton-training

## Getting started

`$ npm install react-native-badminton-training --save`

### Mostly automatic installation

`$ react-native link react-native-badminton-training`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-badminton-training` and add `RNBadmintonTraining.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBadmintonTraining.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBadmintonTrainingPackage;` to the imports at the top of the file
  - Add `new RNBadmintonTrainingPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-badminton-training'
  	project(':react-native-badminton-training').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-badminton-training/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-badminton-training')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBadmintonTraining.sln` in `node_modules/react-native-badminton-training/windows/RNBadmintonTraining.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Badminton.Training.RNBadmintonTraining;` to the usings at the top of the file
  - Add `new RNBadmintonTrainingPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBadmintonTraining from 'react-native-badminton-training';

// TODO: What to do with the module?
RNBadmintonTraining;
```
  