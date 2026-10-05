using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	public class TeeInputStream : BaseInputStream
	{
		// Token: 0x0600077A RID: 1914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x546A960", Offset = "0x5469560", VA = "0x18546A960")]
		public TeeInputStream(Stream input, Stream tee)
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x546A7A0", Offset = "0x54693A0", VA = "0x18546A7A0", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000055B0 File Offset: 0x000037B0
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x546A8B0", Offset = "0x54694B0", VA = "0x18546A8B0", Slot = "32")]
		public override int Read(byte[] buf, int off, int len)
		{
			return 0;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000055C8 File Offset: 0x000037C8
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x546A810", Offset = "0x5469410", VA = "0x18546A810", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x30")]
		private readonly Stream input;

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x38")]
		private readonly Stream tee;
	}
}
