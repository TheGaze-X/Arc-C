using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006506 RID: 25862
	[Token(Token = "0x2006506")]
	public class AutoChessBattleUIPingPanel : AutoChessBattleUIPanelBase, AutoChessBattleUIController.IPanelWithTick
	{
		// Token: 0x060252D6 RID: 152278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252D6")]
		[Address(RVA = "0x201FDA0", Offset = "0x201E9A0", VA = "0x18201FDA0", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x060252D7 RID: 152279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252D7")]
		[Address(RVA = "0x201FC50", Offset = "0x201E850", VA = "0x18201FC50", Slot = "8")]
		public void OnTick()
		{
		}

		// Token: 0x060252D8 RID: 152280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252D8")]
		[Address(RVA = "0x201FEB0", Offset = "0x201EAB0", VA = "0x18201FEB0")]
		private void _InitIfNot(AutoChessBattleUIViewModel viewModel)
		{
		}

		// Token: 0x060252D9 RID: 152281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252D9")]
		[Address(RVA = "0x201FF70", Offset = "0x201EB70", VA = "0x18201FF70")]
		public AutoChessBattleUIPingPanel()
		{
		}

		// Token: 0x04034237 RID: 213559
		[Token(Token = "0x4034237")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtPing;

		// Token: 0x04034238 RID: 213560
		[Token(Token = "0x4034238")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x04034239 RID: 213561
		[Token(Token = "0x4034239")]
		[FieldOffset(Offset = "0x30")]
		private List<PingCond> m_cachedPingConds;

		// Token: 0x0403423A RID: 213562
		[Token(Token = "0x403423A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403423B RID: 213563
		[Token(Token = "0x403423B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403423C RID: 213564
		[Token(Token = "0x403423C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403423D RID: 213565
		[Token(Token = "0x403423D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
