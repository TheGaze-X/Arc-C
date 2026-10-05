using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Assist
{
	// Token: 0x02001E0B RID: 7691
	[Token(Token = "0x2001E0B")]
	public class AssistReportShopView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BDD7 RID: 48599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD7")]
		[Address(RVA = "0x33C1BB0", Offset = "0x33C07B0", VA = "0x1833C1BB0")]
		public void Render(Dictionary<string, BuildingTradingReport> tradingReport)
		{
		}

		// Token: 0x0600BDD8 RID: 48600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD8")]
		[Address(RVA = "0x33C2130", Offset = "0x33C0D30", VA = "0x1833C2130")]
		public AssistReportShopView()
		{
		}

		// Token: 0x0400BE8F RID: 48783
		[Token(Token = "0x400BE8F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _diamondIncome;

		// Token: 0x0400BE90 RID: 48784
		[Token(Token = "0x400BE90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _diamondCount;

		// Token: 0x0400BE91 RID: 48785
		[Token(Token = "0x400BE91")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _diamondText;

		// Token: 0x0400BE92 RID: 48786
		[Token(Token = "0x400BE92")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _goldIncome;

		// Token: 0x0400BE93 RID: 48787
		[Token(Token = "0x400BE93")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _goldCount;

		// Token: 0x0400BE94 RID: 48788
		[Token(Token = "0x400BE94")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _goldText;

		// Token: 0x0400BE95 RID: 48789
		[Token(Token = "0x400BE95")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400BE96 RID: 48790
		[Token(Token = "0x400BE96")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
