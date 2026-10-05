using System;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x0200022D RID: 557
	[Token(Token = "0x200022D")]
	public struct BinaryData
	{
		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x0")]
		public string fileName;

		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x8")]
		public byte[] fileBytes;

		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		[FieldOffset(Offset = "0x10")]
		public string contentType;

		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		[FieldOffset(Offset = "0x18")]
		public string fieldName;
	}
}
