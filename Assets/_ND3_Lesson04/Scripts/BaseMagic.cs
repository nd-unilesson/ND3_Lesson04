using UnityEngine;

// === 魔法の基底クラス（スーパークラス） === //
// Interface継承 : IMagic
// ※ 魔法クラスはこのスクリプトを継承して生成される
public class BaseMagic : MonoBehaviour, IMagic
{
    // === 継承される変数 === //
    public MagicType magicType;
    public Vector3 position;
    public Vector3 direction;

    // === 初期化処理 === //
    // ※Interfaceで実装しなければならないメソッド
    public void Initialize(MagicType type, Vector3 position, Vector3 direction)
    {
        // 👇初期化処理
    }
}
