using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007508 RID: 29960
	[Token(Token = "0x2007508")]
	public class Act25sideResearchFloatInfoStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602A3AE RID: 172974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3AE")]
		[Address(RVA = "0x25E39B0", Offset = "0x25E25B0", VA = "0x1825E39B0")]
		public Act25sideResearchFloatInfoStateBean()
		{
		}

		// Token: 0x0403CAF0 RID: 248560
		[Token(Token = "0x403CAF0")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403CAF1 RID: 248561
		[Token(Token = "0x403CAF1")]
		[FieldOffset(Offset = "0x18")]
		public Act25sideResearchFloatInfoStateBean.InfoType infoType;

		// Token: 0x0403CAF2 RID: 248562
		[Token(Token = "0x403CAF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007509 RID: 29961
		[Token(Token = "0x2007509")]
		public enum InfoType
		{
			// Token: 0x0403CAF4 RID: 248564
			[Token(Token = "0x403CAF4")]
			NONE,
			// Token: 0x0403CAF5 RID: 248565
			[Token(Token = "0x403CAF5")]
			RESERACH_TOKEN,
			// Token: 0x0403CAF6 RID: 248566
			[Token(Token = "0x403CAF6")]
			HARVEST_RULE
		}
	}
}
