using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200031B RID: 795
	[Token(Token = "0x200031B")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		// Token: 0x06001A53 RID: 6739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RSAOAEPKeyExchangeFormatter()
		{
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x4B451F0", Offset = "0x4B43DF0", VA = "0x184B451F0")]
		public RSAOAEPKeyExchangeFormatter(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001A56 RID: 6742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D5")]
		public byte[] Parameter
		{
			[Token(Token = "0x6001A55")]
			[Address(RVA = "0x4B45580", Offset = "0x4B44180", VA = "0x184B45580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A56")]
			[Address(RVA = "0x4B45600", Offset = "0x4B44200", VA = "0x184B45600")]
			set
			{
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002D6")]
		public override string Parameters
		{
			[Token(Token = "0x6001A57")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D7")]
		public RandomNumberGenerator Rng
		{
			[Token(Token = "0x6001A58")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A59")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x4B45060", Offset = "0x4B43C60", VA = "0x184B45060", Slot = "5")]
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x4B44DE0", Offset = "0x4B439E0", VA = "0x184B44DE0", Slot = "6")]
		public override byte[] CreateKeyExchange(byte[] rgbData)
		{
			return null;
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x4B45010", Offset = "0x4B43C10", VA = "0x184B45010", Slot = "7")]
		public override byte[] CreateKeyExchange(byte[] rgbData, System.Type symAlgType)
		{
			return null;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x00012150 File Offset: 0x00010350
		[Token(Token = "0x170002D8")]
		private bool OverridesEncrypt
		{
			[Token(Token = "0x6001A5D")]
			[Address(RVA = "0x4B45370", Offset = "0x4B43F70", VA = "0x184B45370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private byte[] ParameterValue;

		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RSA _rsaKey;

		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool? _rsaOverridesEncrypt;

		// Token: 0x04000E30 RID: 3632
		[Token(Token = "0x4000E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RandomNumberGenerator RngValue;
	}
}
