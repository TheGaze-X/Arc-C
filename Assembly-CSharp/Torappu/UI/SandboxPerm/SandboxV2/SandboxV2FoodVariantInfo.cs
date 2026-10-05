using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200441A RID: 17434
	[Token(Token = "0x200441A")]
	public struct SandboxV2FoodVariantInfo
	{
		// Token: 0x04021F15 RID: 139029
		[Token(Token = "0x4021F15")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04021F16 RID: 139030
		[Token(Token = "0x4021F16")]
		[FieldOffset(Offset = "0x8")]
		public string usage;

		// Token: 0x04021F17 RID: 139031
		[Token(Token = "0x4021F17")]
		[FieldOffset(Offset = "0x10")]
		public int duration;

		// Token: 0x04021F18 RID: 139032
		[Token(Token = "0x4021F18")]
		[FieldOffset(Offset = "0x14")]
		public SandboxV2FoodVariantType variantType;

		// Token: 0x04021F19 RID: 139033
		[Token(Token = "0x4021F19")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2FoodVariantShowType variantShowType;

		// Token: 0x04021F1A RID: 139034
		[Token(Token = "0x4021F1A")]
		[FieldOffset(Offset = "0x20")]
		public List<SandboxV2FoodAttribute> mainAttrib;

		// Token: 0x04021F1B RID: 139035
		[Token(Token = "0x4021F1B")]
		[FieldOffset(Offset = "0x28")]
		public List<SandboxV2FoodAttribute> subAttrib;
	}
}
