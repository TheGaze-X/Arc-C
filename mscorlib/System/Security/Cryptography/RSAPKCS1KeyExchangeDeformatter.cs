using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200031C RID: 796
	[Token(Token = "0x200031C")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		// Token: 0x06001A5E RID: 6750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RSAPKCS1KeyExchangeDeformatter()
		{
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x4B45AD0", Offset = "0x4B446D0", VA = "0x184B45AD0")]
		public RSAPKCS1KeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D9")]
		public RandomNumberGenerator RNG
		{
			[Token(Token = "0x6001A60")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A61")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DA")]
		public override string Parameters
		{
			[Token(Token = "0x6001A62")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A63")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x4B456D0", Offset = "0x4B442D0", VA = "0x184B456D0", Slot = "7")]
		public override byte[] DecryptKeyExchange(byte[] rgbIn)
		{
			return null;
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x4B45940", Offset = "0x4B44540", VA = "0x184B45940", Slot = "6")]
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00012168 File Offset: 0x00010368
		[Token(Token = "0x170002DB")]
		private bool OverridesDecrypt
		{
			[Token(Token = "0x6001A66")]
			[Address(RVA = "0x4B45C50", Offset = "0x4B44850", VA = "0x184B45C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000E31 RID: 3633
		[Token(Token = "0x4000E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RSA _rsaKey;

		// Token: 0x04000E32 RID: 3634
		[Token(Token = "0x4000E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool? _rsaOverridesDecrypt;

		// Token: 0x04000E33 RID: 3635
		[Token(Token = "0x4000E33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RandomNumberGenerator RngValue;
	}
}
