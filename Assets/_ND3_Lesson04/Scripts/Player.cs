using UnityEngine;
using UnityEngine.InputSystem;

// === 操作キャラクラス === //
public class Player : MonoBehaviour
{
    [Header("* * * Magic Factory * * *")]
    public MagicFactory magicFactory;

    void Start()
    {
        
    }

    void Update()
    {
        if(Keyboard.current.digit1Key.wasPressedThisFrame)
        {   // [1キー] で炎魔法を生成してもらう
            magicFactory.CreateMagic(
                MagicType.Fire,         // 炎タイプ
                transform.position,     // 自身(Player)の座標
                Vector3.zero,           // 向きベクトル
                Quaternion.identity,    // 回転
                null,                   // 親は無し(null)
                5f);                    // 生存時間 5.0秒
        }

        if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {   // [2キー] で氷魔法を生成してもらう
            magicFactory.CreateMagic(
                MagicType.Ice,          // 氷タイプ
                transform.position,     // 自身(Player)の座標
                Vector3.zero,           // 向きベクトル
                Quaternion.identity,    // 回転
                null,                   // 親は無し(null)
                5f);                    // 生存時間 5.0秒
        }

        if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {   // [3キー] で雷魔法を生成してもらう
            magicFactory.CreateMagic(
                MagicType.Thunder,      // 雷タイプ
                transform.position,     // 自身(Player)の座標
                Vector3.zero,           // 向きベクトル
                Quaternion.identity,    // 回転
                null,                   // 親は無し(null)
                5f);                    // 生存時間 5.0秒
        }
    }
}
