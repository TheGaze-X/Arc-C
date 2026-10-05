using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E7C RID: 3708
	[Token(Token = "0x2000E7C")]
	public class ActivityDynEntrySwitchData
	{
		// Token: 0x06006B47 RID: 27463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B47")]
		[Address(RVA = "0x1FFBDD0", Offset = "0x1FFA9D0", VA = "0x181FFBDD0")]
		public ActivityDynEntrySwitchData()
		{
		}

		// Token: 0x04004E12 RID: 19986
		[Token(Token = "0x4004E12")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, DynEntrySwitchInfo> entrySwitchInfo;

		// Token: 0x04004E13 RID: 19987
		[Token(Token = "0x4004E13")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, DynEntrySwitchInfo> randomEntrySwitchInfo;
	}
}
