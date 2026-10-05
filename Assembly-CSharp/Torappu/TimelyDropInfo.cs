using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200135C RID: 4956
	[Token(Token = "0x200135C")]
	[Serializable]
	public class TimelyDropInfo
	{
		// Token: 0x06007325 RID: 29477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007325")]
		[Address(RVA = "0x2215BD0", Offset = "0x22147D0", VA = "0x182215BD0")]
		public TimelyDropInfo()
		{
		}

		// Token: 0x04006E09 RID: 28169
		[Token(Token = "0x4006E09")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, StageData.StageDropInfo> dropInfo;
	}
}
