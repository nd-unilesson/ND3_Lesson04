using UnityEngine;

// === 魔法クラスの実装ルール(Interface) === //
// ※ 魔法クラスのインターフェース
//    魔法クラスはこのスクリプトに書かれた機能（メソッド）を必ず実装しなければならない！
public interface IMagic
{
    // === 初期化処理 === //
    public void Initialize(MagicType type, Vector3 position, Vector3 direction);
}

// === 列挙型：魔法の種類(Type) === //
public enum MagicType
{
    Fire,       // 炎魔法タイプ
    Ice,        // 氷魔法タイプ
    Thunder     // 雷魔法タイプ
}