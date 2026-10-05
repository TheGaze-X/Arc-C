using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public sealed class PkzipClassicManaged : PkzipClassic
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002640 File Offset: 0x00000840
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public override int BlockSize
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x4A415C0", Offset = "0x4A401C0", VA = "0x184A415C0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x1700002C")]
		public override KeySizes[] LegalKeySizes
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x4A414F0", Offset = "0x4A400F0", VA = "0x184A414F0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "27")]
		public override void GenerateIV()
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x1700002D")]
		public override KeySizes[] LegalBlockSizes
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x4A41420", Offset = "0x4A40020", VA = "0x184A41420", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public override byte[] Key
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x4A41370", Offset = "0x4A3FF70", VA = "0x184A41370", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x4A41630", Offset = "0x4A40230", VA = "0x184A41630", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x4A412B0", Offset = "0x4A3FEB0", VA = "0x184A412B0", Slot = "26")]
		public override void GenerateKey()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4A41200", Offset = "0x4A3FE00", VA = "0x184A41200", Slot = "23")]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4A41150", Offset = "0x4A3FD50", VA = "0x184A41150", Slot = "25")]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4A41360", Offset = "0x4A3FF60", VA = "0x184A41360")]
		public PkzipClassicManaged()
		{
		}

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x48")]
		private byte[] key_;
	}
}
