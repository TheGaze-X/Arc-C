using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Checksums
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public sealed class Adler32 : IChecksum
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x1700000F")]
		public long Value
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x4A31A30", Offset = "0x4A30630", VA = "0x184A31A30")]
		public Adler32()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x4A31680", Offset = "0x4A30280", VA = "0x184A31680", Slot = "5")]
		public void Reset()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x4A319E0", Offset = "0x4A305E0", VA = "0x184A319E0", Slot = "6")]
		public void Update(int value)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x4A31960", Offset = "0x4A30560", VA = "0x184A31960", Slot = "7")]
		public void Update(byte[] buffer)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x4A31690", Offset = "0x4A30290", VA = "0x184A31690", Slot = "8")]
		public void Update(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		private const uint BASE = 65521U;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x10")]
		private uint checksum;
	}
}
