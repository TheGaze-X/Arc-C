using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002C0 RID: 704
	[Token(Token = "0x20002C0")]
	internal struct BMPAlloc
	{
		// Token: 0x0600131A RID: 4890 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x600131A")]
		[Address(RVA = "0x5A51F90", Offset = "0x5A50B90", VA = "0x185A51F90")]
		public bool Equals(BMPAlloc other)
		{
			return default(bool);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00009FD8 File Offset: 0x000081D8
		[Token(Token = "0x600131B")]
		[Address(RVA = "0x5A51FB0", Offset = "0x5A50BB0", VA = "0x185A51FB0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600131C")]
		[Address(RVA = "0x5A51FC0", Offset = "0x5A50BC0", VA = "0x185A51FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BMPAlloc Invalid;

		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x0")]
		public int page;

		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4000AAA")]
		[FieldOffset(Offset = "0x4")]
		public ushort pageLine;

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		[FieldOffset(Offset = "0x6")]
		public byte bitIndex;

		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4000AAC")]
		[FieldOffset(Offset = "0x7")]
		public OwnedState ownedState;
	}
}
