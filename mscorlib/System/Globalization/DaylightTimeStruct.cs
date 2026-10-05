using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000568 RID: 1384
	[Token(Token = "0x2000568")]
	internal readonly struct DaylightTimeStruct
	{
		// Token: 0x06002915 RID: 10517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002915")]
		[Address(RVA = "0x4C2F060", Offset = "0x4C2DC60", VA = "0x184C2F060")]
		public DaylightTimeStruct(System.DateTime start, System.DateTime end, System.TimeSpan delta)
		{
		}

		// Token: 0x0400174E RID: 5966
		[Token(Token = "0x400174E")]
		[FieldOffset(Offset = "0x0")]
		public readonly System.DateTime Start;

		// Token: 0x0400174F RID: 5967
		[Token(Token = "0x400174F")]
		[FieldOffset(Offset = "0x8")]
		public readonly System.DateTime End;

		// Token: 0x04001750 RID: 5968
		[Token(Token = "0x4001750")]
		[FieldOffset(Offset = "0x10")]
		public readonly System.TimeSpan Delta;
	}
}
