using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002E7 RID: 743
	[Token(Token = "0x20002E7")]
	public class SignatureLoader
	{
		// Token: 0x0600379F RID: 14239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379F")]
		[Address(RVA = "0x344DBF0", Offset = "0x344C7F0", VA = "0x18344DBF0")]
		public SignatureLoader(string publicKey, LuaEnv.CustomLoader loader)
		{
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x344DD20", Offset = "0x344C920", VA = "0x18344DD20")]
		private byte[] load_and_verify(ref string filepath)
		{
			return null;
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A1")]
		[Address(RVA = "0x344DF10", Offset = "0x344CB10", VA = "0x18344DF10")]
		public static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader)
		{
			return null;
		}

		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		[FieldOffset(Offset = "0x10")]
		private LuaEnv.CustomLoader userLoader;

		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		[FieldOffset(Offset = "0x18")]
		private RSACryptoServiceProvider rsa;

		// Token: 0x04000D8F RID: 3471
		[Token(Token = "0x4000D8F")]
		[FieldOffset(Offset = "0x20")]
		private SHA1 sha;
	}
}
