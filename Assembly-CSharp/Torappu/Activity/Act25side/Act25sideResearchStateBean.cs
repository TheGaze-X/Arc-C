using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200750C RID: 29964
	[Token(Token = "0x200750C")]
	public class Act25sideResearchStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602A3B1 RID: 172977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3B1")]
		[Address(RVA = "0x25E5980", Offset = "0x25E4580", VA = "0x1825E5980")]
		public Act25sideResearchStateBean()
		{
		}

		// Token: 0x0403CAFB RID: 248571
		[Token(Token = "0x403CAFB")]
		[FieldOffset(Offset = "0x10")]
		public Act25sideResearchProperty researchProp;

		// Token: 0x0403CAFC RID: 248572
		[Token(Token = "0x403CAFC")]
		[FieldOffset(Offset = "0x18")]
		public int addCount;

		// Token: 0x0403CAFD RID: 248573
		[Token(Token = "0x403CAFD")]
		[FieldOffset(Offset = "0x20")]
		public string finishedMissionId;

		// Token: 0x0403CAFE RID: 248574
		[Token(Token = "0x403CAFE")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> dailyItems;

		// Token: 0x0403CAFF RID: 248575
		[Token(Token = "0x403CAFF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
