using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x0200462E RID: 17966
	[Token(Token = "0x200462E")]
	public class RL02OuterBuffListRawTextGroupItemModel : IHotfixable
	{
		// Token: 0x0601B4B2 RID: 111794 RVA: 0x000A4D48 File Offset: 0x000A2F48
		[Token(Token = "0x601B4B2")]
		[Address(RVA = "0x149E460", Offset = "0x149D060", VA = "0x18149E460")]
		public int GetUnlockNodeCount()
		{
			return 0;
		}

		// Token: 0x0601B4B3 RID: 111795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4B3")]
		[Address(RVA = "0x149E540", Offset = "0x149D140", VA = "0x18149E540")]
		public RL02OuterBuffListRawTextGroupItemModel()
		{
		}

		// Token: 0x040233DB RID: 144347
		[Token(Token = "0x40233DB")]
		[FieldOffset(Offset = "0x10")]
		public List<RL02OuterBuffListRawTextItemModel> nodeList;

		// Token: 0x040233DC RID: 144348
		[Token(Token = "0x40233DC")]
		[FieldOffset(Offset = "0x18")]
		public bool useLevelMark;

		// Token: 0x040233DD RID: 144349
		[Token(Token = "0x40233DD")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x040233DE RID: 144350
		[Token(Token = "0x40233DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetUnlockNodeCount;

		// Token: 0x040233DF RID: 144351
		[Token(Token = "0x40233DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
