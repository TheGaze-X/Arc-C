using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007935 RID: 31029
	[Token(Token = "0x2007935")]
	public class Act1ArcadeBadgeBookStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602B897 RID: 178327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B897")]
		[Address(RVA = "0x276D350", Offset = "0x276BF50", VA = "0x18276D350")]
		public Act1ArcadeBadgeBookStateBean()
		{
		}

		// Token: 0x0403EF48 RID: 257864
		[Token(Token = "0x403EF48")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403EF49 RID: 257865
		[Token(Token = "0x403EF49")]
		[FieldOffset(Offset = "0x18")]
		public string focusZoneId;

		// Token: 0x0403EF4A RID: 257866
		[Token(Token = "0x403EF4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
