using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x020057A9 RID: 22441
	[Token(Token = "0x20057A9")]
	public class RL02SubTransDiceView : RoguelikeTransitionView.SubTransitionBase<string>
	{
		// Token: 0x06020D32 RID: 134450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D32")]
		[Address(RVA = "0x1B2A3C0", Offset = "0x1B28FC0", VA = "0x181B2A3C0", Slot = "9")]
		protected override string GetParam(RoguelikeTransitionView.TransOptions transOptions)
		{
			return null;
		}

		// Token: 0x06020D33 RID: 134451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D33")]
		[Address(RVA = "0x1B2A500", Offset = "0x1B29100", VA = "0x181B2A500", Slot = "10")]
		protected override void SetParam(string param)
		{
		}

		// Token: 0x06020D34 RID: 134452 RVA: 0x000B7798 File Offset: 0x000B5998
		[Token(Token = "0x6020D34")]
		[Address(RVA = "0x1B2A440", Offset = "0x1B29040", VA = "0x181B2A440", Slot = "11")]
		public override RoguelikeTransitionView.SubTransType GetTransType()
		{
			return RoguelikeTransitionView.SubTransType.NONE;
		}

		// Token: 0x06020D35 RID: 134453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D35")]
		[Address(RVA = "0x1B2A580", Offset = "0x1B29180", VA = "0x181B2A580", Slot = "12")]
		public override IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x06020D36 RID: 134454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D36")]
		[Address(RVA = "0x1B2A4A0", Offset = "0x1B290A0", VA = "0x181B2A4A0", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06020D37 RID: 134455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D37")]
		[Address(RVA = "0x1B2A630", Offset = "0x1B29230", VA = "0x181B2A630")]
		public RL02SubTransDiceView()
		{
		}

		// Token: 0x0402C9A2 RID: 182690
		[Token(Token = "0x402C9A2")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;

		// Token: 0x0402C9A3 RID: 182691
		[Token(Token = "0x402C9A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetParam;

		// Token: 0x0402C9A4 RID: 182692
		[Token(Token = "0x402C9A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetParam;

		// Token: 0x0402C9A5 RID: 182693
		[Token(Token = "0x402C9A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTransType;

		// Token: 0x0402C9A6 RID: 182694
		[Token(Token = "0x402C9A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402C9A7 RID: 182695
		[Token(Token = "0x402C9A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402C9A8 RID: 182696
		[Token(Token = "0x402C9A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
