using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012CE RID: 4814
	[Token(Token = "0x20012CE")]
	public class SandboxV2RiftMainTargetData
	{
		// Token: 0x06007248 RID: 29256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007248")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RiftMainTargetData()
		{
		}

		// Token: 0x04006A61 RID: 27233
		[Token(Token = "0x4006A61")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006A62 RID: 27234
		[Token(Token = "0x4006A62")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04006A63 RID: 27235
		[Token(Token = "0x4006A63")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04006A64 RID: 27236
		[Token(Token = "0x4006A64")]
		[FieldOffset(Offset = "0x28")]
		public string storyDesc;

		// Token: 0x04006A65 RID: 27237
		[Token(Token = "0x4006A65")]
		[FieldOffset(Offset = "0x30")]
		public int targetDayCount;

		// Token: 0x04006A66 RID: 27238
		[Token(Token = "0x4006A66")]
		[FieldOffset(Offset = "0x34")]
		public SandboxV2RiftMainTargetType targetType;

		// Token: 0x04006A67 RID: 27239
		[Token(Token = "0x4006A67")]
		[FieldOffset(Offset = "0x38")]
		public string questIconId;

		// Token: 0x04006A68 RID: 27240
		[Token(Token = "0x4006A68")]
		[FieldOffset(Offset = "0x40")]
		public string questIconName;
	}
}
