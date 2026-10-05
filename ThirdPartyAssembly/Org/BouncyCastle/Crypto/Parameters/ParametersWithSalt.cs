using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002E8 RID: 744
	[Token(Token = "0x20002E8")]
	public class ParametersWithSalt : ICipherParameters
	{
		// Token: 0x0600191B RID: 6427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x5294230", Offset = "0x5292E30", VA = "0x185294230")]
		public ParametersWithSalt(ICipherParameters parameters, byte[] salt)
		{
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x5294180", Offset = "0x5292D80", VA = "0x185294180")]
		public ParametersWithSalt(ICipherParameters parameters, byte[] salt, int saltOff, int saltLen)
		{
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		public byte[] GetSalt()
		{
			return null;
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000382")]
		public ICipherParameters Parameters
		{
			[Token(Token = "0x600191E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D40 RID: 3392
		[Token(Token = "0x4000D40")]
		[FieldOffset(Offset = "0x10")]
		private byte[] salt;

		// Token: 0x04000D41 RID: 3393
		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x18")]
		private ICipherParameters parameters;
	}
}
