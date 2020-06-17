# UniDebugLogDisabler

Debug.Log を無効化するクラス  

## 使い方

![2020-06-17_210244](https://user-images.githubusercontent.com/6134875/84895861-f1d8ce00-b0dd-11ea-9f3b-f65f38f9ca88.png)

Scripting Define Symbols に `DISABLE_DEBUG_LOG` を追加することで  
Debug.Log を無効化できます  

## 注意点

Debug.Log を呼び出す時に `UnityEngine.Debug.Log` のように  
名前空間付きで呼び出している場合は無効化できません  
