using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005487 RID: 21639
	[Token(Token = "0x2005487")]
	public class RoguelikeSelectCharStashTicketButton : RoguelikeSelectCharStashTicketButtonBase
	{
		// Token: 0x0601FD6A RID: 130410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD6A")]
		[Address(RVA = "0x19FD2F0", Offset = "0x19FBEF0", VA = "0x1819FD2F0", Slot = "4")]
		public override void Render(RoguelikeSelectCharStashTicketButtonBase.Input input)
		{
		}

		// Token: 0x0601FD6B RID: 130411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD6B")]
		[Address(RVA = "0x19FD1A0", Offset = "0x19FBDA0", VA = "0x1819FD1A0", Slot = "5")]
		public override void EventOnClickStash()
		{
		}

		// Token: 0x0601FD6C RID: 130412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD6C")]
		[Address(RVA = "0x19FD5D0", Offset = "0x19FC1D0", VA = "0x1819FD5D0")]
		public RoguelikeSelectCharStashTicketButton()
		{
		}

		// Token: 0x0601FD6D RID: 130413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD6D")]
		[Address(RVA = "0x19FD5A0", Offset = "0x19FC1A0", VA = "0x1819FD5A0")]
		private void <>xLuaBaseProxy_Render(RoguelikeSelectCharStashTicketButtonBase.Input P0)
		{
		}

		// Token: 0x0601FD6E RID: 130414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD6E")]
		[Address(RVA = "0x19FCF40", Offset = "0x19FBB40", VA = "0x1819FCF40")]
		private void <>xLuaBaseProxy_EventOnClickStash()
		{
		}

		// Token: 0x0402AE47 RID: 175687
		[Token(Token = "0x402AE47")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelStashedFull;

		// Token: 0x0402AE48 RID: 175688
		[Token(Token = "0x402AE48")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelFx;

		// Token: 0x0402AE49 RID: 175689
		[Token(Token = "0x402AE49")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textStashedCount;

		// Token: 0x0402AE4A RID: 175690
		[Token(Token = "0x402AE4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AE4B RID: 175691
		[Token(Token = "0x402AE4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClickStash;

		// Token: 0x0402AE4C RID: 175692
		[Token(Token = "0x402AE4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
