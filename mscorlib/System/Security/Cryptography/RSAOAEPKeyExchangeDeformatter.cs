using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200031A RID: 794
	[Token(Token = "0x200031A")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		// Token: 0x06001A4C RID: 6732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RSAOAEPKeyExchangeDeformatter()
		{
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x4B44A50", Offset = "0x4B43650", VA = "0x184B44A50")]
		public RSAOAEPKeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D3")]
		public override string Parameters
		{
			[Token(Token = "0x6001A4E")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A4F")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x4B44650", Offset = "0x4B43250", VA = "0x184B44650", Slot = "7")]
		public override byte[] DecryptKeyExchange(byte[] rgbData)
		{
			return null;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x4B448C0", Offset = "0x4B434C0", VA = "0x184B448C0", Slot = "6")]
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x00012138 File Offset: 0x00010338
		[Token(Token = "0x170002D4")]
		private bool OverridesDecrypt
		{
			[Token(Token = "0x6001A52")]
			[Address(RVA = "0x4B44BD0", Offset = "0x4B437D0", VA = "0x184B44BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000E2B RID: 3627
		[Token(Token = "0x4000E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RSA _rsaKey;

		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool? _rsaOverridesDecrypt;
	}
}
