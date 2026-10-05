using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004662 RID: 18018
	[Token(Token = "0x2004662")]
	public class RoguelikeTopicOuterBuffListModel : IHotfixable
	{
		// Token: 0x0601B5D0 RID: 112080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5D0")]
		[Address(RVA = "0x14BE790", Offset = "0x14BD390", VA = "0x1814BE790")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601B5D1 RID: 112081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5D1")]
		[Address(RVA = "0x14BEC70", Offset = "0x14BD870", VA = "0x1814BEC70")]
		public RoguelikeTopicOuterBuffListModel()
		{
		}

		// Token: 0x040235B7 RID: 144823
		[Token(Token = "0x40235B7")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeTopicOuterBuffListItemModel> items;

		// Token: 0x040235B8 RID: 144824
		[Token(Token = "0x40235B8")]
		[FieldOffset(Offset = "0x18")]
		public string outerBuffItemId;

		// Token: 0x040235B9 RID: 144825
		[Token(Token = "0x40235B9")]
		[FieldOffset(Offset = "0x20")]
		public string outerBuffItemName;

		// Token: 0x040235BA RID: 144826
		[Token(Token = "0x40235BA")]
		[FieldOffset(Offset = "0x28")]
		public bool isInit;

		// Token: 0x040235BB RID: 144827
		[Token(Token = "0x40235BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040235BC RID: 144828
		[Token(Token = "0x40235BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
