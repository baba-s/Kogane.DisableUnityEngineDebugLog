# Kogane Disable Unity Engine Debug Log

Debug.Log を無効化するクラス

## 使い方

![2022-08-28_100630](https://user-images.githubusercontent.com/6134875/187053353-7f108a65-d131-47cd-8b40-def14a9d3992.png)

Scripting Define Symbols に `KOGANE_DISABLE_DEBUG_LOG` を追加することで  
Debug.Log を無効化できます

## 注意点

Debug.Log を呼び出す時に `UnityEngine.Debug.Log` のように  
名前空間付きで呼び出している場合は無効化できません  
