using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeEntry
{
	// Token: 0x02004471 RID: 17521
	[Token(Token = "0x2004471")]
	public class RoguelikeEntryViewModel : IHotfixable
	{
		// Token: 0x0601AC82 RID: 109698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC82")]
		[Address(RVA = "0x13EDDB0", Offset = "0x13EC9B0", VA = "0x1813EDDB0")]
		public void LoadData()
		{
		}

		// Token: 0x0601AC83 RID: 109699 RVA: 0x000A3518 File Offset: 0x000A1718
		[Token(Token = "0x601AC83")]
		[Address(RVA = "0x13EDC70", Offset = "0x13EC870", VA = "0x1813EDC70")]
		public bool CheckIfTopicAccessible(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601AC84 RID: 109700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC84")]
		[Address(RVA = "0x13EE360", Offset = "0x13ECF60", VA = "0x1813EE360")]
		public void SetFocusTopic(string topicId)
		{
		}

		// Token: 0x0601AC85 RID: 109701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC85")]
		[Address(RVA = "0x13EE580", Offset = "0x13ED180", VA = "0x1813EE580")]
		public RoguelikeEntryViewModel()
		{
		}

		// Token: 0x040223EB RID: 140267
		[Token(Token = "0x40223EB")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeEntryItemViewModel> itemList;

		// Token: 0x040223EC RID: 140268
		[Token(Token = "0x40223EC")]
		[FieldOffset(Offset = "0x18")]
		public string focusTopicId;

		// Token: 0x040223ED RID: 140269
		[Token(Token = "0x40223ED")]
		[FieldOffset(Offset = "0x20")]
		public int focusIndex;

		// Token: 0x040223EE RID: 140270
		[Token(Token = "0x40223EE")]
		[FieldOffset(Offset = "0x24")]
		public int entrySequenceId;

		// Token: 0x040223EF RID: 140271
		[Token(Token = "0x40223EF")]
		[FieldOffset(Offset = "0x28")]
		public bool hasOnBattleTheme;

		// Token: 0x040223F0 RID: 140272
		[Token(Token = "0x40223F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040223F1 RID: 140273
		[Token(Token = "0x40223F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfTopicAccessible;

		// Token: 0x040223F2 RID: 140274
		[Token(Token = "0x40223F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetFocusTopic;

		// Token: 0x040223F3 RID: 140275
		[Token(Token = "0x40223F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
