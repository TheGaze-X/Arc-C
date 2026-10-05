using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CB2 RID: 3250
	[Token(Token = "0x2000CB2")]
	public class Act1VHalfIdleGachaPoolTypeData
	{
		// Token: 0x06006992 RID: 27026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006992")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleGachaPoolTypeData()
		{
		}

		// Token: 0x0400424F RID: 16975
		[Token(Token = "0x400424F")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleGachaPoolType poolType;

		// Token: 0x04004250 RID: 16976
		[Token(Token = "0x4004250")]
		[FieldOffset(Offset = "0x18")]
		public string typeName;

		// Token: 0x04004251 RID: 16977
		[Token(Token = "0x4004251")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04004252 RID: 16978
		[Token(Token = "0x4004252")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;
	}
}
