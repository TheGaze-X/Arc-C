using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005570 RID: 21872
	[Token(Token = "0x2005570")]
	public class RL05ChoiceSPZoneAPHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x0602025B RID: 131675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602025B")]
		[Address(RVA = "0x1A333D0", Offset = "0x1A31FD0", VA = "0x181A333D0", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x0602025C RID: 131676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602025C")]
		[Address(RVA = "0x1A335F0", Offset = "0x1A321F0", VA = "0x181A335F0")]
		private string _GenHintForSPZoneAP()
		{
			return null;
		}

		// Token: 0x0602025D RID: 131677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602025D")]
		[Address(RVA = "0x1A337B0", Offset = "0x1A323B0", VA = "0x181A337B0")]
		public RL05ChoiceSPZoneAPHintModel()
		{
		}

		// Token: 0x0402B6C7 RID: 177863
		[Token(Token = "0x402B6C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402B6C8 RID: 177864
		[Token(Token = "0x402B6C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForSPZoneAP;

		// Token: 0x0402B6C9 RID: 177865
		[Token(Token = "0x402B6C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
