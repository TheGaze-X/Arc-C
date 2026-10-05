using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Checksums
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class StrangeCRC : IChecksum
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4A42200", Offset = "0x4A40E00", VA = "0x184A42200")]
		public StrangeCRC()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x487A5B0", Offset = "0x48791B0", VA = "0x18487A5B0", Slot = "5")]
		public void Reset()
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x17000011")]
		public long Value
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x4A42220", Offset = "0x4A40E20", VA = "0x184A42220", Slot = "4")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x4A41DC0", Offset = "0x4A409C0", VA = "0x184A41DC0", Slot = "6")]
		public void Update(int value)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4A41E60", Offset = "0x4A40A60", VA = "0x184A41E60", Slot = "7")]
		public void Update(byte[] buffer)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4A41EE0", Offset = "0x4A40AE0", VA = "0x184A41EE0", Slot = "8")]
		public void Update(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] crc32Table;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x10")]
		private int globalCrc;
	}
}
