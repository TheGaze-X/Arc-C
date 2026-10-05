using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000261 RID: 609
	[Token(Token = "0x2000261")]
	public class HeartbeatExtension
	{
		// Token: 0x060014D2 RID: 5330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x524A470", Offset = "0x5249070", VA = "0x18524A470")]
		public HeartbeatExtension(byte mode)
		{
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[Token(Token = "0x170002DE")]
		public virtual byte Mode
		{
			[Token(Token = "0x60014D3")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x524A330", Offset = "0x5248F30", VA = "0x18524A330", Slot = "5")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x524A390", Offset = "0x5248F90", VA = "0x18524A390")]
		public static HeartbeatExtension Parse(Stream input)
		{
			return null;
		}

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x10")]
		protected readonly byte mMode;
	}
}
