using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055C9 RID: 21961
	[Token(Token = "0x20055C9")]
	public class RL05ExpeditionCharCardView : RoguelikeExpeditionCharCardViewBase
	{
		// Token: 0x060203E6 RID: 132070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203E6")]
		[Address(RVA = "0x1A5E4D0", Offset = "0x1A5D0D0", VA = "0x181A5E4D0", Slot = "4")]
		protected override void RenderChar(RoguelikeExpeditionCharCardViewModel viewModel, string selectingCharId, bool fastMode)
		{
		}

		// Token: 0x060203E7 RID: 132071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203E7")]
		[Address(RVA = "0x1A5E630", Offset = "0x1A5D230", VA = "0x181A5E630")]
		public RL05ExpeditionCharCardView()
		{
		}

		// Token: 0x0402B9C0 RID: 178624
		[Token(Token = "0x402B9C0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _candledPanel;

		// Token: 0x0402B9C1 RID: 178625
		[Token(Token = "0x402B9C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderChar;

		// Token: 0x0402B9C2 RID: 178626
		[Token(Token = "0x402B9C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
