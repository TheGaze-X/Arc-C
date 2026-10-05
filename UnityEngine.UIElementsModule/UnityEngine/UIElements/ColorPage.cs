using System;
using Il2CppDummyDll;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x0200020A RID: 522
	[Token(Token = "0x200020A")]
	internal struct ColorPage
	{
		// Token: 0x06000DE8 RID: 3560 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x5B036B0", Offset = "0x5B022B0", VA = "0x185B036B0")]
		public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc)
		{
			return default(ColorPage);
		}

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x0")]
		public bool isValid;

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x4")]
		public Color32 pageAndID;
	}
}
