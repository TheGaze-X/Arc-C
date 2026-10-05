using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054EB RID: 21739
	[Token(Token = "0x20054EB")]
	public class RoguelikeGameShopStatusViewModel : IHotfixable
	{
		// Token: 0x17004AF8 RID: 19192
		// (get) Token: 0x0601FF9E RID: 130974 RVA: 0x000B40F0 File Offset: 0x000B22F0
		// (set) Token: 0x0601FF9F RID: 130975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004AF8")]
		public RoguelikeGameShopStatusEnum shopStatus
		{
			[Token(Token = "0x601FF9E")]
			[Address(RVA = "0x1A1A840", Offset = "0x1A19440", VA = "0x181A1A840")]
			get
			{
				return RoguelikeGameShopStatusEnum.NONE;
			}
			[Token(Token = "0x601FF9F")]
			[Address(RVA = "0x1A1A8A0", Offset = "0x1A194A0", VA = "0x181A1A8A0")]
			set
			{
			}
		}

		// Token: 0x17004AF9 RID: 19193
		// (get) Token: 0x0601FFA0 RID: 130976 RVA: 0x000B4108 File Offset: 0x000B2308
		[Token(Token = "0x17004AF9")]
		public RoguelikeGameShopStatusEnum lastNormalStatus
		{
			[Token(Token = "0x601FFA0")]
			[Address(RVA = "0x1A1A7E0", Offset = "0x1A193E0", VA = "0x181A1A7E0")]
			get
			{
				return RoguelikeGameShopStatusEnum.NONE;
			}
		}

		// Token: 0x0601FFA1 RID: 130977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFA1")]
		[Address(RVA = "0x1A1A780", Offset = "0x1A19380", VA = "0x181A1A780")]
		public RoguelikeGameShopStatusViewModel()
		{
		}

		// Token: 0x0402B250 RID: 176720
		[Token(Token = "0x402B250")]
		[FieldOffset(Offset = "0x10")]
		private RoguelikeGameShopStatusEnum m_shopStatus;

		// Token: 0x0402B251 RID: 176721
		[Token(Token = "0x402B251")]
		[FieldOffset(Offset = "0x14")]
		private RoguelikeGameShopStatusEnum m_lastNormalStatus;

		// Token: 0x0402B252 RID: 176722
		[Token(Token = "0x402B252")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shopStatus;

		// Token: 0x0402B253 RID: 176723
		[Token(Token = "0x402B253")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_shopStatus;

		// Token: 0x0402B254 RID: 176724
		[Token(Token = "0x402B254")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lastNormalStatus;

		// Token: 0x0402B255 RID: 176725
		[Token(Token = "0x402B255")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
