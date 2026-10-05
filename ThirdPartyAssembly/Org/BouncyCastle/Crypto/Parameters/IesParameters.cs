using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002DF RID: 735
	[Token(Token = "0x20002DF")]
	public class IesParameters : ICipherParameters
	{
		// Token: 0x060018FC RID: 6396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x4BD7FE0", Offset = "0x4BD6BE0", VA = "0x184BD7FE0")]
		public IesParameters(byte[] derivation, byte[] encoding, int macKeySize)
		{
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		public byte[] GetDerivationV()
		{
			return null;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		public byte[] GetEncodingV()
		{
			return null;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x0000C378 File Offset: 0x0000A578
		[Token(Token = "0x17000378")]
		public int MacKeySize
		{
			[Token(Token = "0x60018FF")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000D2F RID: 3375
		[Token(Token = "0x4000D2F")]
		[FieldOffset(Offset = "0x10")]
		private byte[] derivation;

		// Token: 0x04000D30 RID: 3376
		[Token(Token = "0x4000D30")]
		[FieldOffset(Offset = "0x18")]
		private byte[] encoding;

		// Token: 0x04000D31 RID: 3377
		[Token(Token = "0x4000D31")]
		[FieldOffset(Offset = "0x20")]
		private int macKeySize;
	}
}
