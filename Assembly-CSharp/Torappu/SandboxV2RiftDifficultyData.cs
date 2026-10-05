using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012D3 RID: 4819
	[Token(Token = "0x20012D3")]
	public class SandboxV2RiftDifficultyData
	{
		// Token: 0x0600724D RID: 29261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RiftDifficultyData()
		{
		}

		// Token: 0x04006A79 RID: 27257
		[Token(Token = "0x4006A79")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006A7A RID: 27258
		[Token(Token = "0x4006A7A")]
		[FieldOffset(Offset = "0x18")]
		public string riftId;

		// Token: 0x04006A7B RID: 27259
		[Token(Token = "0x4006A7B")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04006A7C RID: 27260
		[Token(Token = "0x4006A7C")]
		[FieldOffset(Offset = "0x28")]
		public int difficultyLevel;

		// Token: 0x04006A7D RID: 27261
		[Token(Token = "0x4006A7D")]
		[FieldOffset(Offset = "0x30")]
		public string rewardGroupId;
	}
}
