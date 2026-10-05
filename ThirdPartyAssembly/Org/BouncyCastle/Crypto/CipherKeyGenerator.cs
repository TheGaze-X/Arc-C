using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	public class CipherKeyGenerator
	{
		// Token: 0x060012F4 RID: 4852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x50C1E60", Offset = "0x50C0A60", VA = "0x1850C1E60")]
		public CipherKeyGenerator()
		{
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x5222F60", Offset = "0x5221B60", VA = "0x185222F60")]
		internal CipherKeyGenerator(int defaultStrength)
		{
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x170002A2")]
		public int DefaultStrength
		{
			[Token(Token = "0x60012F6")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x5222EC0", Offset = "0x5221AC0", VA = "0x185222EC0")]
		public void Init(KeyGenerationParameters parameters)
		{
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x5223050", Offset = "0x5221C50", VA = "0x185223050", Slot = "4")]
		protected virtual void engineInit(KeyGenerationParameters parameters)
		{
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x5222D60", Offset = "0x5221960", VA = "0x185222D60")]
		public byte[] GenerateKey()
		{
			return null;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x5222FF0", Offset = "0x5221BF0", VA = "0x185222FF0", Slot = "5")]
		protected virtual byte[] engineGenerateKey()
		{
			return null;
		}

		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		[FieldOffset(Offset = "0x10")]
		protected internal SecureRandom random;

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		[FieldOffset(Offset = "0x18")]
		protected internal int strength;

		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		[FieldOffset(Offset = "0x1C")]
		private bool uninitialised;

		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x400095F")]
		[FieldOffset(Offset = "0x20")]
		private int defaultStrength;
	}
}
