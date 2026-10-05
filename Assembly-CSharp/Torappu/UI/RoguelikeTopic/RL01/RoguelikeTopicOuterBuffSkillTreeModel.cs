using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004665 RID: 18021
	[Token(Token = "0x2004665")]
	public class RoguelikeTopicOuterBuffSkillTreeModel : IHotfixable
	{
		// Token: 0x0601B5D4 RID: 112084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5D4")]
		[Address(RVA = "0x14BF170", Offset = "0x14BDD70", VA = "0x1814BF170")]
		public void LoadData(string topic)
		{
		}

		// Token: 0x0601B5D5 RID: 112085 RVA: 0x000A4F28 File Offset: 0x000A3128
		[Token(Token = "0x601B5D5")]
		[Address(RVA = "0x14BEDD0", Offset = "0x14BD9D0", VA = "0x1814BEDD0")]
		public bool CanNodeUpgrade(string buffId)
		{
			return default(bool);
		}

		// Token: 0x0601B5D6 RID: 112086 RVA: 0x000A4F40 File Offset: 0x000A3140
		[Token(Token = "0x601B5D6")]
		[Address(RVA = "0x14BF0B0", Offset = "0x14BDCB0", VA = "0x1814BF0B0")]
		public bool IsNodeUpgraded(string buffId)
		{
			return default(bool);
		}

		// Token: 0x0601B5D7 RID: 112087 RVA: 0x000A4F58 File Offset: 0x000A3158
		[Token(Token = "0x601B5D7")]
		[Address(RVA = "0x14BF030", Offset = "0x14BDC30", VA = "0x1814BF030")]
		public bool IsNodeSelected(string buffId)
		{
			return default(bool);
		}

		// Token: 0x0601B5D8 RID: 112088 RVA: 0x000A4F70 File Offset: 0x000A3170
		[Token(Token = "0x601B5D8")]
		[Address(RVA = "0x14BF690", Offset = "0x14BE290", VA = "0x1814BF690")]
		public bool SetNodeSelected(string buffId)
		{
			return default(bool);
		}

		// Token: 0x0601B5D9 RID: 112089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5D9")]
		[Address(RVA = "0x14BF740", Offset = "0x14BE340", VA = "0x1814BF740")]
		public RoguelikeTopicOuterBuffSkillTreeModel()
		{
		}

		// Token: 0x040235C7 RID: 144839
		[Token(Token = "0x40235C7")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x040235C8 RID: 144840
		[Token(Token = "0x40235C8")]
		[FieldOffset(Offset = "0x18")]
		public string selectedBuffId;

		// Token: 0x040235C9 RID: 144841
		[Token(Token = "0x40235C9")]
		[FieldOffset(Offset = "0x20")]
		public bool currentInExploration;

		// Token: 0x040235CA RID: 144842
		[Token(Token = "0x40235CA")]
		[FieldOffset(Offset = "0x24")]
		public int currOuterBuffToken;

		// Token: 0x040235CB RID: 144843
		[Token(Token = "0x40235CB")]
		[FieldOffset(Offset = "0x28")]
		public string outerBuffItemId;

		// Token: 0x040235CC RID: 144844
		[Token(Token = "0x40235CC")]
		[FieldOffset(Offset = "0x30")]
		public string outerBuffItemName;

		// Token: 0x040235CD RID: 144845
		[Token(Token = "0x40235CD")]
		[FieldOffset(Offset = "0x38")]
		public bool allCompleted;

		// Token: 0x040235CE RID: 144846
		[Token(Token = "0x40235CE")]
		[FieldOffset(Offset = "0x40")]
		public string focusedOuterBuffItem;

		// Token: 0x040235CF RID: 144847
		[Token(Token = "0x40235CF")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, RoguelikeTopicOuterBuffSkillTreeNodeModel> nodes;

		// Token: 0x040235D0 RID: 144848
		[Token(Token = "0x40235D0")]
		[FieldOffset(Offset = "0x50")]
		public bool isInit;

		// Token: 0x040235D1 RID: 144849
		[Token(Token = "0x40235D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040235D2 RID: 144850
		[Token(Token = "0x40235D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CanNodeUpgrade;

		// Token: 0x040235D3 RID: 144851
		[Token(Token = "0x40235D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsNodeUpgraded;

		// Token: 0x040235D4 RID: 144852
		[Token(Token = "0x40235D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsNodeSelected;

		// Token: 0x040235D5 RID: 144853
		[Token(Token = "0x40235D5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetNodeSelected;

		// Token: 0x040235D6 RID: 144854
		[Token(Token = "0x40235D6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
