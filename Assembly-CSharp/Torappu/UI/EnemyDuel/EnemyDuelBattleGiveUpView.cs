using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FF1 RID: 20465
	[Token(Token = "0x2004FF1")]
	public class EnemyDuelBattleGiveUpView : DataBinder<EnemyDuelBattleGiveUpProperty>
	{
		// Token: 0x0601E60F RID: 124431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E60F")]
		[Address(RVA = "0x1810DB0", Offset = "0x180F9B0", VA = "0x181810DB0", Slot = "7")]
		public override void OnValueChanged(EnemyDuelBattleGiveUpProperty property)
		{
		}

		// Token: 0x0601E610 RID: 124432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E610")]
		[Address(RVA = "0x1810E70", Offset = "0x180FA70", VA = "0x181810E70")]
		public EnemyDuelBattleGiveUpView()
		{
		}

		// Token: 0x040289D7 RID: 166359
		[Token(Token = "0x40289D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _text;

		// Token: 0x040289D8 RID: 166360
		[Token(Token = "0x40289D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040289D9 RID: 166361
		[Token(Token = "0x40289D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
