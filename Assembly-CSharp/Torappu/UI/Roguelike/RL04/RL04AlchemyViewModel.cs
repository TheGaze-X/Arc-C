using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200566C RID: 22124
	[Token(Token = "0x200566C")]
	public class RL04AlchemyViewModel : IRoguelikeAlchemyViewModel, IHotfixable
	{
		// Token: 0x06020774 RID: 132980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020774")]
		[Address(RVA = "0x1AA0750", Offset = "0x1A9F350", VA = "0x181AA0750", Slot = "4")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x06020775 RID: 132981 RVA: 0x000B61A8 File Offset: 0x000B43A8
		[Token(Token = "0x6020775")]
		[Address(RVA = "0x1AA06F0", Offset = "0x1A9F2F0", VA = "0x181AA06F0", Slot = "5")]
		public bool CheckIfShowMenuStatusBar()
		{
			return default(bool);
		}

		// Token: 0x06020776 RID: 132982 RVA: 0x000B61C0 File Offset: 0x000B43C0
		[Token(Token = "0x6020776")]
		[Address(RVA = "0x1AA0690", Offset = "0x1A9F290", VA = "0x181AA0690", Slot = "6")]
		public bool CheckIfShowMenuBottomBar()
		{
			return default(bool);
		}

		// Token: 0x06020777 RID: 132983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020777")]
		[Address(RVA = "0x1AA0960", Offset = "0x1A9F560", VA = "0x181AA0960")]
		public RL04AlchemyViewModel()
		{
		}

		// Token: 0x0402BF81 RID: 180097
		[Token(Token = "0x402BF81")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeAlchemyImplViewModelProperty viewProperty;

		// Token: 0x0402BF82 RID: 180098
		[Token(Token = "0x402BF82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BF83 RID: 180099
		[Token(Token = "0x402BF83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfShowMenuStatusBar;

		// Token: 0x0402BF84 RID: 180100
		[Token(Token = "0x402BF84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIfShowMenuBottomBar;

		// Token: 0x0402BF85 RID: 180101
		[Token(Token = "0x402BF85")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
