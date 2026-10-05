using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002DE RID: 734
	[Token(Token = "0x20002DE")]
	public class Gost3410ValidationParameters
	{
		// Token: 0x060018F4 RID: 6388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x3629A50", Offset = "0x3628650", VA = "0x183629A50")]
		public Gost3410ValidationParameters(int x0, int c)
		{
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x36F22A0", Offset = "0x36F0EA0", VA = "0x1836F22A0")]
		public Gost3410ValidationParameters(long x0L, long cL)
		{
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		[Token(Token = "0x17000374")]
		public int C
		{
			[Token(Token = "0x60018F6")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x17000375")]
		public int X0
		{
			[Token(Token = "0x60018F7")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x17000376")]
		public long CL
		{
			[Token(Token = "0x60018F8")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x17000377")]
		public long X0L
		{
			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x528E920", Offset = "0x528D520", VA = "0x18528E920", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0000C360 File Offset: 0x0000A560
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x528E9E0", Offset = "0x528D5E0", VA = "0x18528E9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D2B RID: 3371
		[Token(Token = "0x4000D2B")]
		[FieldOffset(Offset = "0x10")]
		private int x0;

		// Token: 0x04000D2C RID: 3372
		[Token(Token = "0x4000D2C")]
		[FieldOffset(Offset = "0x14")]
		private int c;

		// Token: 0x04000D2D RID: 3373
		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x18")]
		private long x0L;

		// Token: 0x04000D2E RID: 3374
		[Token(Token = "0x4000D2E")]
		[FieldOffset(Offset = "0x20")]
		private long cL;
	}
}
