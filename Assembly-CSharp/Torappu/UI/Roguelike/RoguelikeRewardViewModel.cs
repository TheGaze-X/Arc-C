using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005412 RID: 21522
	[Token(Token = "0x2005412")]
	public class RoguelikeRewardViewModel : IHotfixable
	{
		// Token: 0x17004A2D RID: 18989
		// (get) Token: 0x0601FA85 RID: 129669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A2D")]
		public RoguelikeDungeonNode curNode
		{
			[Token(Token = "0x601FA85")]
			[Address(RVA = "0x19653D0", Offset = "0x1963FD0", VA = "0x1819653D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FA86 RID: 129670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA86")]
		[Address(RVA = "0x1965070", Offset = "0x1963C70", VA = "0x181965070")]
		public void LoadData(string topicId, RoguelikeDungeonGeneSpZonePluginBase geneSpZonePlugin)
		{
		}

		// Token: 0x0601FA87 RID: 129671 RVA: 0x000B2A10 File Offset: 0x000B0C10
		[Token(Token = "0x601FA87")]
		[Address(RVA = "0x1965010", Offset = "0x1963C10", VA = "0x181965010")]
		public bool IsUseSpExpStyle()
		{
			return default(bool);
		}

		// Token: 0x0601FA88 RID: 129672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA88")]
		[Address(RVA = "0x1965340", Offset = "0x1963F40", VA = "0x181965340")]
		public RoguelikeRewardViewModel()
		{
		}

		// Token: 0x0402AAE4 RID: 174820
		[Token(Token = "0x402AAE4")]
		[FieldOffset(Offset = "0x10")]
		public int curDepth;

		// Token: 0x0402AAE5 RID: 174821
		[Token(Token = "0x402AAE5")]
		[FieldOffset(Offset = "0x14")]
		public int curIndex;

		// Token: 0x0402AAE6 RID: 174822
		[Token(Token = "0x402AAE6")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeReward> rewards;

		// Token: 0x0402AAE7 RID: 174823
		[Token(Token = "0x402AAE7")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeStageEarn earn;

		// Token: 0x0402AAE8 RID: 174824
		[Token(Token = "0x402AAE8")]
		[FieldOffset(Offset = "0x28")]
		public string showCharInstId;

		// Token: 0x0402AAE9 RID: 174825
		[Token(Token = "0x402AAE9")]
		[FieldOffset(Offset = "0x30")]
		public int battleResultState;

		// Token: 0x0402AAEA RID: 174826
		[Token(Token = "0x402AAEA")]
		[FieldOffset(Offset = "0x34")]
		public int battleIsPerfect;

		// Token: 0x0402AAEB RID: 174827
		[Token(Token = "0x402AAEB")]
		[FieldOffset(Offset = "0x38")]
		public RoguelikeDungeonZone curZone;

		// Token: 0x0402AAEC RID: 174828
		[Token(Token = "0x402AAEC")]
		[FieldOffset(Offset = "0x40")]
		public string topicId;

		// Token: 0x0402AAED RID: 174829
		[Token(Token = "0x402AAED")]
		[FieldOffset(Offset = "0x48")]
		public int initPredefinedStyle;

		// Token: 0x0402AAEE RID: 174830
		[Token(Token = "0x402AAEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curNode;

		// Token: 0x0402AAEF RID: 174831
		[Token(Token = "0x402AAEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402AAF0 RID: 174832
		[Token(Token = "0x402AAF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsUseSpExpStyle;

		// Token: 0x0402AAF1 RID: 174833
		[Token(Token = "0x402AAF1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
