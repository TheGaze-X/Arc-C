using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A38 RID: 10808
	[Token(Token = "0x2002A38")]
	public class UIBattleDouququNpcItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011F18 RID: 73496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F18")]
		[Address(RVA = "0x9D1910", Offset = "0x9D0510", VA = "0x1809D1910")]
		public void SetData(Act5FunNpcData npcData)
		{
		}

		// Token: 0x06011F19 RID: 73497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F19")]
		[Address(RVA = "0x9D19C0", Offset = "0x9D05C0", VA = "0x1809D19C0")]
		public UIBattleDouququNpcItem()
		{
		}

		// Token: 0x040143BC RID: 82876
		[Token(Token = "0x40143BC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x040143BD RID: 82877
		[Token(Token = "0x40143BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040143BE RID: 82878
		[Token(Token = "0x40143BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
