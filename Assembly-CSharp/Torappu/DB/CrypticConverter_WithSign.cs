using System;
using System.IO;
using Il2CppDummyDll;

namespace Torappu.DB
{
	// Token: 0x02001688 RID: 5768
	[Token(Token = "0x2001688")]
	public class CrypticConverter_WithSign : CrypticConverter_A
	{
		// Token: 0x0600923F RID: 37439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600923F")]
		[Address(RVA = "0x2B283E0", Offset = "0x2B26FE0", VA = "0x182B283E0")]
		public CrypticConverter_WithSign()
		{
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x00038F58 File Offset: 0x00037158
		[Token(Token = "0x6009240")]
		[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "22")]
		protected virtual CrypticConverter_WithSign.CodeOpt EnableCodeOpts()
		{
			return CrypticConverter_WithSign.CodeOpt.NONE;
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x00038F70 File Offset: 0x00037170
		[Token(Token = "0x6009241")]
		[Address(RVA = "0x2B30090", Offset = "0x2B2EC90", VA = "0x182B30090")]
		private bool _CheckIfEnabled(CrypticConverter_WithSign.CodeOpt opt)
		{
			return default(bool);
		}

		// Token: 0x06009242 RID: 37442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009242")]
		[Address(RVA = "0x2B2FE70", Offset = "0x2B2EA70", VA = "0x182B2FE70", Slot = "16")]
		protected override byte[] EncodeInternal(byte[] src)
		{
			return null;
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009243")]
		[Address(RVA = "0x2B30020", Offset = "0x2B2EC20", VA = "0x182B30020")]
		private byte[] _BaseEncodeInternalToEncrypt(byte[] src)
		{
			return null;
		}

		// Token: 0x06009244 RID: 37444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009244")]
		[Address(RVA = "0x2B2FCD0", Offset = "0x2B2E8D0", VA = "0x182B2FCD0", Slot = "17")]
		protected override void DecodeInternal(Stream src, Stream dst)
		{
		}

		// Token: 0x06009245 RID: 37445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009245")]
		[Address(RVA = "0x2B300F0", Offset = "0x2B2ECF0", VA = "0x182B300F0")]
		private void _CheckIfSignMatchOrThrow(Stream src)
		{
		}

		// Token: 0x06009246 RID: 37446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009246")]
		[Address(RVA = "0x2B2FF30", Offset = "0x2B2EB30", VA = "0x182B2FF30")]
		private void _BaseDecodeInternalToDecrypt(Stream src, Stream dst)
		{
		}

		// Token: 0x06009247 RID: 37447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009247")]
		[Address(RVA = "0x2B2FED0", Offset = "0x2B2EAD0", VA = "0x182B2FED0", Slot = "21")]
		protected override byte[] ReadContentBytes(Stream src)
		{
			return null;
		}

		// Token: 0x0400881A RID: 34842
		[Token(Token = "0x400881A")]
		private const int SIGN_HEADER_LENGTH = 128;

		// Token: 0x0400881B RID: 34843
		[Token(Token = "0x400881B")]
		[FieldOffset(Offset = "0x28")]
		private string m_signPubKey;

		// Token: 0x02001689 RID: 5769
		[Token(Token = "0x2001689")]
		protected enum CodeOpt
		{
			// Token: 0x0400881D RID: 34845
			[Token(Token = "0x400881D")]
			NONE,
			// Token: 0x0400881E RID: 34846
			[Token(Token = "0x400881E")]
			CRYPTO,
			// Token: 0x0400881F RID: 34847
			[Token(Token = "0x400881F")]
			SIGN,
			// Token: 0x04008820 RID: 34848
			[Token(Token = "0x4008820")]
			ALL
		}
	}
}
