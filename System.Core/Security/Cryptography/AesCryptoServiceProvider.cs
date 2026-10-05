using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public sealed class AesCryptoServiceProvider : Aes
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4F1B3F0", Offset = "0x4F19FF0", VA = "0x184F1B3F0")]
		public AesCryptoServiceProvider()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4F1B390", Offset = "0x4F19F90", VA = "0x184F1B390", Slot = "27")]
		public override void GenerateIV()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4F1B3C0", Offset = "0x4F19FC0", VA = "0x184F1B3C0", Slot = "26")]
		public override void GenerateKey()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4F1B100", Offset = "0x4F19D00", VA = "0x184F1B100", Slot = "25")]
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4F1B240", Offset = "0x4F19E40", VA = "0x184F1B240", Slot = "23")]
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
		{
			return null;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000007")]
		public override byte[] IV
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x4F1B450", Offset = "0x4F1A050", VA = "0x184F1B450", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x4F1B480", Offset = "0x4F1A080", VA = "0x184F1B480", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000008")]
		public override byte[] Key
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x4F1B460", Offset = "0x4F1A060", VA = "0x184F1B460", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x4F1B4A0", Offset = "0x4F1A0A0", VA = "0x184F1B4A0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000009")]
		public override int KeySize
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x4F1B490", Offset = "0x4F1A090", VA = "0x184F1B490", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000A")]
		public override int FeedbackSize
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x4F1B470", Offset = "0x4F1A070", VA = "0x184F1B470", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000020E8 File Offset: 0x000002E8
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000B")]
		public override CipherMode Mode
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80", Slot = "18")]
			get
			{
				return (CipherMode)0;
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x4F1B4B0", Offset = "0x4F1A0B0", VA = "0x184F1B4B0", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000C")]
		public override PaddingMode Padding
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220", Slot = "20")]
			get
			{
				return (PaddingMode)0;
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x4F1B520", Offset = "0x4F1A120", VA = "0x184F1B520", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4B4F5C0", Offset = "0x4B4E1C0", VA = "0x184B4F5C0", Slot = "24")]
		public override ICryptoTransform CreateDecryptor()
		{
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4B4F670", Offset = "0x4B4E270", VA = "0x184B4F670", Slot = "22")]
		public override ICryptoTransform CreateEncryptor()
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4F1B380", Offset = "0x4F19F80", VA = "0x184F1B380", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}
	}
}
