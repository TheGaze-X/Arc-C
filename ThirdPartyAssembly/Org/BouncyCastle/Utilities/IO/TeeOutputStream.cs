using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	public class TeeOutputStream : BaseOutputStream
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x546ABB0", Offset = "0x54697B0", VA = "0x18546ABB0")]
		public TeeOutputStream(Stream output, Stream tee)
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x546A9E0", Offset = "0x54695E0", VA = "0x18546A9E0", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x546AAE0", Offset = "0x54696E0", VA = "0x18546AAE0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x546AA50", Offset = "0x5469650", VA = "0x18546AA50", Slot = "37")]
		public override void WriteByte(byte b)
		{
		}

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0x30")]
		private readonly Stream output;

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x38")]
		private readonly Stream tee;
	}
}
