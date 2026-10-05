using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public class PemWriter
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x5468650", Offset = "0x5467250", VA = "0x185468650")]
		public PemWriter(TextWriter writer)
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CF")]
		public TextWriter Writer
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x5467960", Offset = "0x5466560", VA = "0x185467960")]
		public int GetOutputSize(PemObject obj)
		{
			return 0;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x5467E50", Offset = "0x5466A50", VA = "0x185467E50")]
		public void WriteObject(PemObjectGenerator objGen)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x5467D40", Offset = "0x5466940", VA = "0x185467D40")]
		private void WriteEncoded(byte[] bytes)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x54685B0", Offset = "0x54671B0", VA = "0x1854685B0")]
		private void WritePreEncapsulationBoundary(string type)
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x5468510", Offset = "0x5467110", VA = "0x185468510")]
		private void WritePostEncapsulationBoundary(string type)
		{
		}

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		private const int LineLength = 64;

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0x10")]
		private readonly TextWriter writer;

		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		[FieldOffset(Offset = "0x18")]
		private readonly int nlLength;

		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		[FieldOffset(Offset = "0x20")]
		private char[] buf;
	}
}
