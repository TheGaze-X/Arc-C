using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012DD RID: 4829
	[Token(Token = "0x20012DD")]
	public class SandboxV2BuildingNodeScoreData
	{
		// Token: 0x0600725A RID: 29274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2BuildingNodeScoreData()
		{
		}

		// Token: 0x04006AA5 RID: 27301
		[Token(Token = "0x4006AA5")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04006AA6 RID: 27302
		[Token(Token = "0x4006AA6")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04006AA7 RID: 27303
		[Token(Token = "0x4006AA7")]
		[FieldOffset(Offset = "0x1C")]
		public int limitScore;
	}
}
