using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E7B RID: 3707
	[Token(Token = "0x2000E7B")]
	public class ActivityKVSwitchData
	{
		// Token: 0x06006B46 RID: 27462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B46")]
		[Address(RVA = "0x1FFC6E0", Offset = "0x1FFB2E0", VA = "0x181FFC6E0")]
		public ActivityKVSwitchData()
		{
		}

		// Token: 0x04004E11 RID: 19985
		[Token(Token = "0x4004E11")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, KVSwitchInfo> kvSwitchInfo;
	}
}
