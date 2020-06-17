# UniDebugLogDisabler

Debug.Log を無効化するクラス  

## 使い方

![2020-06-17_210415](https://user-images.githubusercontent.com/6134875/84896011-25b3f380-b0de-11ea-9c62-f6cf710d3b13.png)

Scripting Define Symbols に `DISABLE_DEBUG_LOG` を追加することで  
Debug.Log を無効化できます  

## 注意点

Debug.Log を呼び出す時に `UnityEngine.Debug.Log` のように  
名前空間付きで呼び出している場合は無効化できません  
