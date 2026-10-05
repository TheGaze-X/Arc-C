using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	internal class ShaderInfoStorageRGBA32 : ShaderInfoStorage<Color32>
	{
		// Token: 0x060012C4 RID: 4804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C4")]
		[Address(RVA = "0x5B42C00", Offset = "0x5B41800", VA = "0x185B42C00")]
		public ShaderInfoStorageRGBA32(int initialSize = 64, int maxSize = 4096)
		{
		}

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Func<Color, Color32> s_Convert;
	}
}
