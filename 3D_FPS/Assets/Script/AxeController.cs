using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeController : CloseWeaponController
{

    //활성화 여부
    public static bool isActivate = false;



    public override void CloseWeaponChange(CloseWeapon _closeWeapon)
    {
        base.CloseWeaponChange(_closeWeapon); //공통분모
        isActivate = true; //추가사항
    }

    protected override IEnumerator HitCoroutine()
    {
        while (isSwing)
        {
            if (CheckObject())
            {
                isSwing = false;
                Debug.Log(hitInfo.transform.name);
            }
            yield return null;
        }
    }

    void Update()
    {
        if (isActivate)
        {
            TryAttack();

        }

    }
}
