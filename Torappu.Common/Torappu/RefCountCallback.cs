using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class RefCountCallback
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x54EB190", Offset = "0x54E9D90", VA = "0x1854EB190")]
		public bool DecAndInvoke()
		{
			return default(bool);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x54EB1D0", Offset = "0x54E9DD0", VA = "0x1854EB1D0")]
		public static void Reset(RefCountCallback inst)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RefCountCallback()
		{
		}

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x10")]
		public Action callback;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x18")]
		public int refCnt;
	}
}
