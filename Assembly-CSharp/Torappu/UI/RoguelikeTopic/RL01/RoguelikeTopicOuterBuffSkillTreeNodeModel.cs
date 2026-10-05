using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004664 RID: 18020
	[Token(Token = "0x2004664")]
	public class RoguelikeTopicOuterBuffSkillTreeNodeModel : IHotfixable
	{
		// Token: 0x0601B5D3 RID: 112083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5D3")]
		[Address(RVA = "0x14BF7A0", Offset = "0x14BE3A0", VA = "0x1814BF7A0")]
		public RoguelikeTopicOuterBuffSkillTreeNodeModel()
		{
		}

		// Token: 0x040235BD RID: 144829
		[Token(Token = "0x40235BD")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x040235BE RID: 144830
		[Token(Token = "0x40235BE")]
		[FieldOffset(Offset = "0x18")]
		public string buffName;

		// Token: 0x040235BF RID: 144831
		[Token(Token = "0x40235BF")]
		[FieldOffset(Offset = "0x20")]
		public string buffIcon;

		// Token: 0x040235C0 RID: 144832
		[Token(Token = "0x40235C0")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeTopicDevNodeType nodeType;

		// Token: 0x040235C1 RID: 144833
		[Token(Token = "0x40235C1")]
		[FieldOffset(Offset = "0x30")]
		public List<string> frontNodeList;

		// Token: 0x040235C2 RID: 144834
		[Token(Token = "0x40235C2")]
		[FieldOffset(Offset = "0x38")]
		public string buffTypeName;

		// Token: 0x040235C3 RID: 144835
		[Token(Token = "0x40235C3")]
		[FieldOffset(Offset = "0x40")]
		public List<RoguelikeTopicDisplayItem> buffDisplayInfo;

		// Token: 0x040235C4 RID: 144836
		[Token(Token = "0x40235C4")]
		[FieldOffset(Offset = "0x48")]
		public int tokenCost;

		// Token: 0x040235C5 RID: 144837
		[Token(Token = "0x40235C5")]
		[FieldOffset(Offset = "0x4C")]
		public bool isUpgraded;

		// Token: 0x040235C6 RID: 144838
		[Token(Token = "0x40235C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
