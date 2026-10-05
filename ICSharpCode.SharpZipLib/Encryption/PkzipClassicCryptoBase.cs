using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	internal class PkzipClassicCryptoBase
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x4A40C50", Offset = "0x4A3F850", VA = "0x184A40C50")]
		protected byte TransformByte()
		{
			return 0;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x4A40A60", Offset = "0x4A3F660", VA = "0x184A40A60")]
		protected void SetKeys(byte[] keyData)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x4A40C90", Offset = "0x4A3F890", VA = "0x184A40C90")]
		protected void UpdateKeys(byte ch)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x4A40A10", Offset = "0x4A3F610", VA = "0x184A40A10")]
		protected void Reset()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PkzipClassicCryptoBase()
		{
		}

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x10")]
		private uint[] keys;
	}
}
