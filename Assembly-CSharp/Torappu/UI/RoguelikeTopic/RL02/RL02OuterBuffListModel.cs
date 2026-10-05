using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x0200462F RID: 17967
	[Token(Token = "0x200462F")]
	public class RL02OuterBuffListModel : IHotfixable
	{
		// Token: 0x0601B4B4 RID: 111796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4B4")]
		[Address(RVA = "0x149D920", Offset = "0x149C520", VA = "0x18149D920")]
		public void LoadData()
		{
		}

		// Token: 0x0601B4B5 RID: 111797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4B5")]
		[Address(RVA = "0x149E300", Offset = "0x149CF00", VA = "0x18149E300")]
		public RL02OuterBuffListModel()
		{
		}

		// Token: 0x040233E0 RID: 144352
		[Token(Token = "0x40233E0")]
		[FieldOffset(Offset = "0x10")]
		public List<RL02OuterBuffListMergedItemModel> mergedItems;

		// Token: 0x040233E1 RID: 144353
		[Token(Token = "0x40233E1")]
		[FieldOffset(Offset = "0x18")]
		public List<RL02OuterBuffListRawTextGroupItemModel> rawTextGroup;

		// Token: 0x040233E2 RID: 144354
		[Token(Token = "0x40233E2")]
		[FieldOffset(Offset = "0x20")]
		public string topicId;

		// Token: 0x040233E3 RID: 144355
		[Token(Token = "0x40233E3")]
		[FieldOffset(Offset = "0x28")]
		public int buffCount;

		// Token: 0x040233E4 RID: 144356
		[Token(Token = "0x40233E4")]
		[FieldOffset(Offset = "0x2C")]
		public int unlockCount;

		// Token: 0x040233E5 RID: 144357
		[Token(Token = "0x40233E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040233E6 RID: 144358
		[Token(Token = "0x40233E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
