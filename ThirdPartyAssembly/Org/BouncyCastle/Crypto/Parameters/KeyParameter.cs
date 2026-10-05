using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002E3 RID: 739
	[Token(Token = "0x20002E3")]
	public class KeyParameter : ICipherParameters
	{
		// Token: 0x06001907 RID: 6407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001907")]
		[Address(RVA = "0x528F030", Offset = "0x528DC30", VA = "0x18528F030")]
		public KeyParameter(byte[] key)
		{
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001908")]
		[Address(RVA = "0x528EE70", Offset = "0x528DA70", VA = "0x18528EE70")]
		public KeyParameter(byte[] key, int keyOff, int keyLen)
		{
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001909")]
		[Address(RVA = "0x528EDF0", Offset = "0x528D9F0", VA = "0x18528EDF0")]
		public byte[] GetKey()
		{
			return null;
		}

		// Token: 0x04000D36 RID: 3382
		[Token(Token = "0x4000D36")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] key;
	}
}
