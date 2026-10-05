using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200540F RID: 21519
	[Token(Token = "0x200540F")]
	public class RoguelikeRewardListViewModel : IHotfixable
	{
		// Token: 0x17004A2C RID: 18988
		// (get) Token: 0x0601FA7C RID: 129660 RVA: 0x000B29C8 File Offset: 0x000B0BC8
		[Token(Token = "0x17004A2C")]
		public bool itemFinishFlag
		{
			[Token(Token = "0x601FA7C")]
			[Address(RVA = "0x1959DF0", Offset = "0x19589F0", VA = "0x181959DF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601FA7D RID: 129661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA7D")]
		[Address(RVA = "0x1959D40", Offset = "0x1958940", VA = "0x181959D40")]
		public RoguelikeRewardListViewModel()
		{
		}

		// Token: 0x0402AADA RID: 174810
		[Token(Token = "0x402AADA")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeRewardItemViewModel> itemList;

		// Token: 0x0402AADB RID: 174811
		[Token(Token = "0x402AADB")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402AADC RID: 174812
		[Token(Token = "0x402AADC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemFinishFlag;

		// Token: 0x0402AADD RID: 174813
		[Token(Token = "0x402AADD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
