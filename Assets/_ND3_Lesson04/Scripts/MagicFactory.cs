using UnityEngine;

public class MagicFactory : MonoBehaviour
{
    // === 変数 === //
    public BaseMagic[] magicList;   // 全ての魔法の配列

    // === 魔法生成メソッド === //
    public BaseMagic CreateMagic (
        MagicType type,         // 引数1: (MagicType)  魔法の種類
        Vector3 position,       // 引数2: (Vector3)    出現座標
        Vector3 direction,      // 引数3: (Vector3)    向きベクトル
        Quaternion rotation,    // 引数4: (Quaternion) 回転
        Transform parent,       // 引数5: (Transform)  親オブジェクト
        float lifeTime )        // 引数6: (flaot)      生存時間
    {
        // 👇魔法生成処理
        if(magicList == null)
        {
            // 魔法リストが空(null)の時は強制終了
            Debug.Log("魔法リストが空です...");
            return null;
        }

        // 魔法リストから目的の魔法を取得する
        BaseMagic prefab = GetMagicPrefab(type);
        BaseMagic instance = Instantiate(prefab, position, rotation, parent);

        // 一定時間でオブジェクトを破棄するように設定
        Destroy(instance, lifeTime);

        // 生成した魔法を返却
        return instance;
    }

    // === 魔法検索メソッド === //
    // 引数1 : (MagicType) 魔法の種類
    // 戻り値: (BaseMagic) 魔法のプレハブ
    public BaseMagic GetMagicPrefab(MagicType type)
    {
        // 魔法配列を繰り返して種類が "同一ならば" 検索結果を返却する
        for (int i = 0; i < magicList.Length; i++)
        {
            if (magicList[i].magicType == type)
            {
                return magicList[i];    // 検索結果がヒット
            }
        }

        Debug.Log("指定された魔法が見つかりませんでした...");
        return null;                    // 見つからなかった(null)
    }
}
