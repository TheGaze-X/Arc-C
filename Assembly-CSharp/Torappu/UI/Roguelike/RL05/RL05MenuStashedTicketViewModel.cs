using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055F6 RID: 22006
	[Token(Token = "0x20055F6")]
	public class RL05MenuStashedTicketViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x17004BA8 RID: 19368
		// (get) Token: 0x060204D3 RID: 132307 RVA: 0x000B5440 File Offset: 0x000B3640
		[Token(Token = "0x17004BA8")]
		public int stashedTicketCount
		{
			[Token(Token = "0x60204D3")]
			[Address(RVA = "0x1A67E10", Offset = "0x1A66A10", VA = "0x181A67E10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004BA9 RID: 19369
		// (get) Token: 0x060204D4 RID: 132308 RVA: 0x000B5458 File Offset: 0x000B3658
		[Token(Token = "0x17004BA9")]
		public bool needShow
		{
			[Token(Token = "0x60204D4")]
			[Address(RVA = "0x1A67D80", Offset = "0x1A66980", VA = "0x181A67D80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060204D5 RID: 132309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204D5")]
		[Address(RVA = "0x1A67550", Offset = "0x1A66150", VA = "0x181A67550", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x060204D6 RID: 132310 RVA: 0x000B5470 File Offset: 0x000B3670
		[Token(Token = "0x60204D6")]
		[Address(RVA = "0x1A679F0", Offset = "0x1A665F0", VA = "0x181A679F0")]
		private int _GetCandleHolderCount(string topicId)
		{
			return 0;
		}

		// Token: 0x060204D7 RID: 132311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204D7")]
		[Address(RVA = "0x1A67CD0", Offset = "0x1A668D0", VA = "0x181A67CD0")]
		public RL05MenuStashedTicketViewModel()
		{
		}

		// Token: 0x060204D8 RID: 132312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204D8")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402BB7C RID: 179068
		[Token(Token = "0x402BB7C")]
		[FieldOffset(Offset = "0x18")]
		public int candleHolderCount;

		// Token: 0x0402BB7D RID: 179069
		[Token(Token = "0x402BB7D")]
		[FieldOffset(Offset = "0x1C")]
		public int stashedTicketMaxCount;

		// Token: 0x0402BB7E RID: 179070
		[Token(Token = "0x402BB7E")]
		[FieldOffset(Offset = "0x20")]
		public List<RL05MenuStashedTicketItemViewModel> stashedTickets;

		// Token: 0x0402BB7F RID: 179071
		[Token(Token = "0x402BB7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stashedTicketCount;

		// Token: 0x0402BB80 RID: 179072
		[Token(Token = "0x402BB80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needShow;

		// Token: 0x0402BB81 RID: 179073
		[Token(Token = "0x402BB81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BB82 RID: 179074
		[Token(Token = "0x402BB82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetCandleHolderCount;

		// Token: 0x0402BB83 RID: 179075
		[Token(Token = "0x402BB83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
