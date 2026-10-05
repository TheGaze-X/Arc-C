using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A37 RID: 10807
	[Token(Token = "0x2002A37")]
	public class UIBattleDouququEnemyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011F16 RID: 73494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F16")]
		[Address(RVA = "0x9D16E0", Offset = "0x9D02E0", VA = "0x1809D16E0")]
		public void SetData(string originId, int count)
		{
		}

		// Token: 0x06011F17 RID: 73495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F17")]
		[Address(RVA = "0x9D18B0", Offset = "0x9D04B0", VA = "0x1809D18B0")]
		public UIBattleDouququEnemyItem()
		{
		}

		// Token: 0x040143B7 RID: 82871
		[Token(Token = "0x40143B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x040143B8 RID: 82872
		[Token(Token = "0x40143B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _cntBg;

		// Token: 0x040143B9 RID: 82873
		[Token(Token = "0x40143B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _cnt;

		// Token: 0x040143BA RID: 82874
		[Token(Token = "0x40143BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040143BB RID: 82875
		[Token(Token = "0x40143BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
