using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000273 RID: 627
	[Token(Token = "0x2000273")]
	public class ServerDHParams
	{
		// Token: 0x0600152B RID: 5419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x524EF00", Offset = "0x524DB00", VA = "0x18524EF00")]
		public ServerDHParams(DHPublicKeyParameters publicKey)
		{
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F6")]
		public virtual DHPublicKeyParameters PublicKey
		{
			[Token(Token = "0x600152C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152D")]
		[Address(RVA = "0x524EBF0", Offset = "0x524D7F0", VA = "0x18524EBF0", Slot = "5")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152E")]
		[Address(RVA = "0x524ED60", Offset = "0x524D960", VA = "0x18524ED60")]
		public static ServerDHParams Parse(Stream input)
		{
			return null;
		}

		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4000BDA")]
		[FieldOffset(Offset = "0x10")]
		protected readonly DHPublicKeyParameters mPublicKey;
	}
}
