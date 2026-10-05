using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200028B RID: 651
	[Token(Token = "0x200028B")]
	public class TlsDeflateCompression : TlsCompression
	{
		// Token: 0x060015B1 RID: 5553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x5259110", Offset = "0x5257D10", VA = "0x185259110")]
		public TlsDeflateCompression()
		{
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x5259030", Offset = "0x5257C30", VA = "0x185259030")]
		public TlsDeflateCompression(int level)
		{
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B3")]
		[Address(RVA = "0x5258EF0", Offset = "0x5257AF0", VA = "0x185258EF0", Slot = "6")]
		public virtual Stream Compress(Stream output)
		{
			return null;
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x5258F90", Offset = "0x5257B90", VA = "0x185258F90", Slot = "7")]
		public virtual Stream Decompress(Stream output)
		{
			return null;
		}

		// Token: 0x04000C15 RID: 3093
		[Token(Token = "0x4000C15")]
		public const int LEVEL_NONE = 0;

		// Token: 0x04000C16 RID: 3094
		[Token(Token = "0x4000C16")]
		public const int LEVEL_FASTEST = 1;

		// Token: 0x04000C17 RID: 3095
		[Token(Token = "0x4000C17")]
		public const int LEVEL_SMALLEST = 9;

		// Token: 0x04000C18 RID: 3096
		[Token(Token = "0x4000C18")]
		public const int LEVEL_DEFAULT = -1;

		// Token: 0x04000C19 RID: 3097
		[Token(Token = "0x4000C19")]
		[FieldOffset(Offset = "0x10")]
		protected readonly ZStream zIn;

		// Token: 0x04000C1A RID: 3098
		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x18")]
		protected readonly ZStream zOut;

		// Token: 0x0200028C RID: 652
		[Token(Token = "0x200028C")]
		protected class DeflateOutputStream : ZOutputStream
		{
			// Token: 0x060015B5 RID: 5557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60015B5")]
			[Address(RVA = "0x5249AB0", Offset = "0x52486B0", VA = "0x185249AB0")]
			public DeflateOutputStream(Stream output, ZStream z, bool compress)
			{
			}

			// Token: 0x060015B6 RID: 5558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60015B6")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
			public override void Flush()
			{
			}
		}
	}
}
