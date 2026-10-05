using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FEF RID: 20463
	[Token(Token = "0x2004FEF")]
	public class EnemyDuelBattleGiveUpDialog : UICompDialog<EnemyDuelBattleGiveUpDialog.Options>
	{
		// Token: 0x0601E609 RID: 124425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E609")]
		[Address(RVA = "0x1810850", Offset = "0x180F450", VA = "0x181810850", Slot = "18")]
		protected override void OnRender(EnemyDuelBattleGiveUpDialog.Options input)
		{
		}

		// Token: 0x0601E60A RID: 124426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E60A")]
		[Address(RVA = "0x1810990", Offset = "0x180F590", VA = "0x181810990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E60B RID: 124427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E60B")]
		[Address(RVA = "0x18106D0", Offset = "0x180F2D0", VA = "0x1818106D0")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601E60C RID: 124428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E60C")]
		[Address(RVA = "0x1810790", Offset = "0x180F390", VA = "0x181810790")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0601E60D RID: 124429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E60D")]
		[Address(RVA = "0x1810A30", Offset = "0x180F630", VA = "0x181810A30")]
		public EnemyDuelBattleGiveUpDialog()
		{
		}

		// Token: 0x040289CF RID: 166351
		[Token(Token = "0x40289CF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private EnemyDuelBattleGiveUpView _view;

		// Token: 0x040289D0 RID: 166352
		[Token(Token = "0x40289D0")]
		[FieldOffset(Offset = "0x78")]
		private readonly EnemyDuelBattleGiveUpProperty m_prop;

		// Token: 0x040289D1 RID: 166353
		[Token(Token = "0x40289D1")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x040289D2 RID: 166354
		[Token(Token = "0x40289D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040289D3 RID: 166355
		[Token(Token = "0x40289D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040289D4 RID: 166356
		[Token(Token = "0x40289D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x040289D5 RID: 166357
		[Token(Token = "0x40289D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x040289D6 RID: 166358
		[Token(Token = "0x40289D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FF0 RID: 20464
		[Token(Token = "0x2004FF0")]
		public class Options
		{
			// Token: 0x0601E60E RID: 124430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E60E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}
		}
	}
}
