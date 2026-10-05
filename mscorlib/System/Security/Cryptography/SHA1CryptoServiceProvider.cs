using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200033E RID: 830
	[Token(Token = "0x200033E")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class SHA1CryptoServiceProvider : SHA1
	{
		// Token: 0x06001B8F RID: 7055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x4B66E10", Offset = "0x4B65A10", VA = "0x184B66E10")]
		public SHA1CryptoServiceProvider()
		{
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x4B5F9B0", Offset = "0x4B5E5B0", VA = "0x184B5F9B0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x4B66BB0", Offset = "0x4B657B0", VA = "0x184B66BB0", Slot = "13")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B92")]
		[Address(RVA = "0x4B66BC0", Offset = "0x4B657C0", VA = "0x184B66BC0", Slot = "18")]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x4B66CF0", Offset = "0x4B658F0", VA = "0x184B66CF0", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x4B66DF0", Offset = "0x4B659F0", VA = "0x184B66DF0", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SHA1Internal sha;
	}
}
