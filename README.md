# UniDebugLogDisabler

Debug.Log を無効化するクラス  

## 使い方

Scripting Define Symbols に `DISABLE_DEBUG_LOG` を追加することで  
Debug.Log を無効化できます  

## 注意点

Debug.Log を呼び出す時に `UnityEngine.Debug.Log` のように  
名前空間付きで呼び出している場合は無効化できません  
