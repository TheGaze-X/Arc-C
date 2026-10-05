using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079EC RID: 31212
	[Token(Token = "0x20079EC")]
	public class Act13sideDailyMissionPoolStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602BC04 RID: 179204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC04")]
		[Address(RVA = "0x279A170", Offset = "0x2798D70", VA = "0x18279A170")]
		public Act13sideDailyMissionPoolStateBean()
		{
		}

		// Token: 0x0403F4C7 RID: 259271
		[Token(Token = "0x403F4C7")]
		[FieldOffset(Offset = "0x10")]
		public bool showRefreshAnim;

		// Token: 0x0403F4C8 RID: 259272
		[Token(Token = "0x403F4C8")]
		[FieldOffset(Offset = "0x18")]
		public Act13sideDailyMissionPoolProperty property;

		// Token: 0x0403F4C9 RID: 259273
		[Token(Token = "0x403F4C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
