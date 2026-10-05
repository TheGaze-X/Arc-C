using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200031D RID: 797
	[Token(Token = "0x200031D")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		// Token: 0x06001A67 RID: 6759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RSAPKCS1KeyExchangeFormatter()
		{
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x4B46340", Offset = "0x4B44F40", VA = "0x184B46340")]
		public RSAPKCS1KeyExchangeFormatter(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002DC")]
		public override string Parameters
		{
			[Token(Token = "0x6001A69")]
			[Address(RVA = "0x4B466D0", Offset = "0x4B452D0", VA = "0x184B466D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DD")]
		public RandomNumberGenerator Rng
		{
			[Token(Token = "0x6001A6A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A6B")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x4B461B0", Offset = "0x4B44DB0", VA = "0x184B461B0", Slot = "5")]
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x4B45E60", Offset = "0x4B44A60", VA = "0x184B45E60", Slot = "6")]
		public override byte[] CreateKeyExchange(byte[] rgbData)
		{
			return null;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x4B45010", Offset = "0x4B43C10", VA = "0x184B45010", Slot = "7")]
		public override byte[] CreateKeyExchange(byte[] rgbData, System.Type symAlgType)
		{
			return null;
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x00012180 File Offset: 0x00010380
		[Token(Token = "0x170002DE")]
		private bool OverridesEncrypt
		{
			[Token(Token = "0x6001A6F")]
			[Address(RVA = "0x4B464C0", Offset = "0x4B450C0", VA = "0x184B464C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RandomNumberGenerator RngValue;

		// Token: 0x04000E35 RID: 3637
		[Token(Token = "0x4000E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RSA _rsaKey;

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool? _rsaOverridesEncrypt;
	}
}
