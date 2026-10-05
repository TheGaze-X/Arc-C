using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[Flags]
	internal enum RenderHints
	{
		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		None = 0,
		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		GroupTransform = 1,
		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		BoneTransform = 2,
		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		ClipWithScissors = 4,
		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		MaskContainer = 8,
		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		DynamicColor = 16,
		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		DirtyOffset = 5,
		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		DirtyGroupTransform = 32,
		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		DirtyBoneTransform = 64,
		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		DirtyClipWithScissors = 128,
		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		DirtyMaskContainer = 256,
		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		DirtyDynamicColor = 512,
		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		DirtyAll = 992
	}
}
