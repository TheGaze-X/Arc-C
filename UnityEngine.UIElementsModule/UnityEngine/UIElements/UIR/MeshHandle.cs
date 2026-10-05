using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002C5 RID: 709
	[Token(Token = "0x20002C5")]
	internal class MeshHandle : LinkedPoolItem<MeshHandle>
	{
		// Token: 0x06001347 RID: 4935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001347")]
		[Address(RVA = "0x5A58C90", Offset = "0x5A57890", VA = "0x185A58C90")]
		public MeshHandle()
		{
		}

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x18")]
		internal Alloc allocVerts;

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0x30")]
		internal Alloc allocIndices;

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0x48")]
		internal uint triangleCount;

		// Token: 0x04000AD7 RID: 2775
		[Token(Token = "0x4000AD7")]
		[FieldOffset(Offset = "0x50")]
		internal Page allocPage;

		// Token: 0x04000AD8 RID: 2776
		[Token(Token = "0x4000AD8")]
		[FieldOffset(Offset = "0x58")]
		internal uint allocTime;

		// Token: 0x04000AD9 RID: 2777
		[Token(Token = "0x4000AD9")]
		[FieldOffset(Offset = "0x5C")]
		internal uint updateAllocID;
	}
}
