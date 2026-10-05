using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000285 RID: 645
	[Token(Token = "0x2000285")]
	[System.Serializable]
	public class ASCIIEncoding : Encoding
	{
		// Token: 0x06001526 RID: 5414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001526")]
		[Address(RVA = "0x4ADA670", Offset = "0x4AD9270", VA = "0x184ADA670")]
		public ASCIIEncoding()
		{
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001527")]
		[Address(RVA = "0x4ADA570", Offset = "0x4AD9170", VA = "0x184ADA570", Slot = "5")]
		internal override void SetDefaultFallbacks()
		{
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x4AD8530", Offset = "0x4AD7130", VA = "0x184AD8530", Slot = "13")]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return 0;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x4AD86F0", Offset = "0x4AD72F0", VA = "0x184AD86F0", Slot = "12")]
		public override int GetByteCount(string chars)
		{
			return 0;
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x4AD80A0", Offset = "0x4AD6CA0", VA = "0x184AD80A0", Slot = "14")]
		[System.CLSCompliant(false)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			return 0;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0000F810 File Offset: 0x0000DA10
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x4AD9100", Offset = "0x4AD7D00", VA = "0x184AD9100", Slot = "20")]
		public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0000F828 File Offset: 0x0000DA28
		[Token(Token = "0x600152C")]
		[Address(RVA = "0x4AD8E20", Offset = "0x4AD7A20", VA = "0x184AD8E20", Slot = "18")]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x600152D")]
		[Address(RVA = "0x4AD8CE0", Offset = "0x4AD78E0", VA = "0x184AD8CE0", Slot = "22")]
		[System.CLSCompliant(false)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			return 0;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0000F858 File Offset: 0x0000DA58
		[Token(Token = "0x600152E")]
		[Address(RVA = "0x4AD9400", Offset = "0x4AD8000", VA = "0x184AD9400", Slot = "23")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0000F870 File Offset: 0x0000DA70
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x4AD95C0", Offset = "0x4AD81C0", VA = "0x184AD95C0", Slot = "24")]
		[System.CLSCompliant(false)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			return 0;
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0000F888 File Offset: 0x0000DA88
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x4AD9C90", Offset = "0x4AD8890", VA = "0x184AD9C90", Slot = "28")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x4AD9860", Offset = "0x4AD8460", VA = "0x184AD9860", Slot = "29")]
		[System.CLSCompliant(false)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			return 0;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x4ADA390", Offset = "0x4AD8F90", VA = "0x184ADA390", Slot = "37")]
		public override string GetString(byte[] bytes, int byteIndex, int byteCount)
		{
			return null;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x4AD81B0", Offset = "0x4AD6DB0", VA = "0x184AD81B0", Slot = "15")]
		internal unsafe override int GetByteCount(char* chars, int charCount, EncoderNLS encoder)
		{
			return 0;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x4AD87C0", Offset = "0x4AD73C0", VA = "0x184AD87C0", Slot = "21")]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			return 0;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x4AD96D0", Offset = "0x4AD82D0", VA = "0x184AD96D0", Slot = "25")]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			return 0;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0000F900 File Offset: 0x0000DB00
		[Token(Token = "0x6001536")]
		[Address(RVA = "0x4AD99A0", Offset = "0x4AD85A0", VA = "0x184AD99A0", Slot = "30")]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			return 0;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0000F918 File Offset: 0x0000DB18
		[Token(Token = "0x6001537")]
		[Address(RVA = "0x4ADA090", Offset = "0x4AD8C90", VA = "0x184ADA090", Slot = "34")]
		public override int GetMaxByteCount(int charCount)
		{
			return 0;
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0000F930 File Offset: 0x0000DB30
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x4ADA210", Offset = "0x4AD8E10", VA = "0x184ADA210", Slot = "35")]
		public override int GetMaxCharCount(int byteCount)
		{
			return 0;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x4AD9F70", Offset = "0x4AD8B70", VA = "0x184AD9F70", Slot = "32")]
		public override Decoder GetDecoder()
		{
			return null;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x4ADA030", Offset = "0x4AD8C30", VA = "0x184ADA030", Slot = "33")]
		public override Encoder GetEncoder()
		{
			return null;
		}

		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4000BDC")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly ASCIIEncoding.ASCIIEncodingSealed s_default;

		// Token: 0x02000286 RID: 646
		[Token(Token = "0x2000286")]
		internal sealed class ASCIIEncodingSealed : ASCIIEncoding
		{
			// Token: 0x0600153C RID: 5436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600153C")]
			[Address(RVA = "0x4AD8050", Offset = "0x4AD6C50", VA = "0x184AD8050")]
			public ASCIIEncodingSealed()
			{
			}
		}
	}
}
