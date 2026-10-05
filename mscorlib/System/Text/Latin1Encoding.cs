using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	[System.Serializable]
	internal class Latin1Encoding : EncodingNLS, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060015FA RID: 5626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x4AFBE40", Offset = "0x4AFAA40", VA = "0x184AFBE40")]
		public Latin1Encoding()
		{
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x4AFBDF0", Offset = "0x4AFA9F0", VA = "0x184AFBDF0")]
		internal Latin1Encoding(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x4AFBC10", Offset = "0x4AFA810", VA = "0x184AFBC10", Slot = "40")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00010110 File Offset: 0x0000E310
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x4AFB120", Offset = "0x4AF9D20", VA = "0x184AFB120", Slot = "15")]
		internal unsafe override int GetByteCount(char* chars, int charCount, EncoderNLS encoder)
		{
			return 0;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00010128 File Offset: 0x0000E328
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x4AFB3D0", Offset = "0x4AF9FD0", VA = "0x184AFB3D0", Slot = "21")]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			return 0;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x374A890", Offset = "0x3749490", VA = "0x18374A890", Slot = "25")]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			return 0;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00010158 File Offset: 0x0000E358
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x4AFB890", Offset = "0x4AFA490", VA = "0x184AFB890", Slot = "30")]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			return 0;
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00010170 File Offset: 0x0000E370
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x4AFB910", Offset = "0x4AFA510", VA = "0x184AFB910", Slot = "34")]
		public override int GetMaxByteCount(int charCount)
		{
			return 0;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00010188 File Offset: 0x0000E388
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x4AFBA90", Offset = "0x4AFA690", VA = "0x184AFBA90", Slot = "35")]
		public override int GetMaxCharCount(int byteCount)
		{
			return 0;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x4AFB0D0", Offset = "0x4AF9CD0", VA = "0x184AFB0D0", Slot = "38")]
		internal override char[] GetBestFitUnicodeToBytesData()
		{
			return null;
		}

		// Token: 0x04000C17 RID: 3095
		[Token(Token = "0x4000C17")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Latin1Encoding s_default;

		// Token: 0x04000C18 RID: 3096
		[Token(Token = "0x4000C18")]
		[FieldOffset(Offset = "0x8")]
		private static readonly char[] arrayCharBestFit;
	}
}
