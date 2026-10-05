using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	[System.Serializable]
	public class UTF8Encoding : Encoding
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001697")]
		[Address(RVA = "0x4B0A840", Offset = "0x4B09440", VA = "0x184B0A840")]
		public UTF8Encoding()
		{
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001698")]
		[Address(RVA = "0x4B0A870", Offset = "0x4B09470", VA = "0x184B0A870")]
		public UTF8Encoding(bool encoderShouldEmitUTF8Identifier)
		{
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001699")]
		[Address(RVA = "0x4B0A7D0", Offset = "0x4B093D0", VA = "0x184B0A7D0")]
		public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes)
		{
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x4B0A5E0", Offset = "0x4B091E0", VA = "0x184B0A5E0", Slot = "5")]
		internal override void SetDefaultFallbacks()
		{
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000106E0 File Offset: 0x0000E8E0
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x4B073C0", Offset = "0x4B05FC0", VA = "0x184B073C0", Slot = "13")]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return 0;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000106F8 File Offset: 0x0000E8F8
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x4B06B70", Offset = "0x4B05770", VA = "0x184B06B70", Slot = "12")]
		public override int GetByteCount(string chars)
		{
			return 0;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00010710 File Offset: 0x0000E910
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x4B07580", Offset = "0x4B06180", VA = "0x184B07580", Slot = "14")]
		[System.CLSCompliant(false)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			return 0;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00010728 File Offset: 0x0000E928
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x4B08340", Offset = "0x4B06F40", VA = "0x184B08340", Slot = "20")]
		public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00010740 File Offset: 0x0000E940
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x4B08640", Offset = "0x4B07240", VA = "0x184B08640", Slot = "18")]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00010758 File Offset: 0x0000E958
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x4B08200", Offset = "0x4B06E00", VA = "0x184B08200", Slot = "22")]
		[System.CLSCompliant(false)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			return 0;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00010770 File Offset: 0x0000E970
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x4B08FD0", Offset = "0x4B07BD0", VA = "0x184B08FD0", Slot = "23")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00010788 File Offset: 0x0000E988
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x4B08EC0", Offset = "0x4B07AC0", VA = "0x184B08EC0", Slot = "24")]
		[System.CLSCompliant(false)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			return 0;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x000107A0 File Offset: 0x0000E9A0
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x4B09190", Offset = "0x4B07D90", VA = "0x184B09190", Slot = "28")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000107B8 File Offset: 0x0000E9B8
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x4B09DA0", Offset = "0x4B089A0", VA = "0x184B09DA0", Slot = "29")]
		[System.CLSCompliant(false)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			return 0;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x4B0A3D0", Offset = "0x4B08FD0", VA = "0x184B0A3D0", Slot = "37")]
		public override string GetString(byte[] bytes, int index, int count)
		{
			return null;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000107D0 File Offset: 0x0000E9D0
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x4B06C40", Offset = "0x4B05840", VA = "0x184B06C40", Slot = "15")]
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
		{
			return 0;
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x000107E8 File Offset: 0x0000E9E8
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x4B0A5D0", Offset = "0x4B091D0", VA = "0x184B0A5D0")]
		private unsafe static int PtrDiff(char* a, char* b)
		{
			return 0;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00010800 File Offset: 0x0000EA00
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x4B0A5C0", Offset = "0x4B091C0", VA = "0x184B0A5C0")]
		private unsafe static int PtrDiff(byte* a, byte* b)
		{
			return 0;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00010818 File Offset: 0x0000EA18
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x4B0A5B0", Offset = "0x4B091B0", VA = "0x184B0A5B0")]
		private static bool InRange(int ch, int start, int end)
		{
			return default(bool);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00010830 File Offset: 0x0000EA30
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x4B07900", Offset = "0x4B06500", VA = "0x184B07900", Slot = "21")]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
		{
			return 0;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00010848 File Offset: 0x0000EA48
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x4B08920", Offset = "0x4B07520", VA = "0x184B08920", Slot = "25")]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			return 0;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00010860 File Offset: 0x0000EA60
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x4B09470", Offset = "0x4B08070", VA = "0x184B09470", Slot = "30")]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			return 0;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00010878 File Offset: 0x0000EA78
		[Token(Token = "0x60016AD")]
		[Address(RVA = "0x4B06AD0", Offset = "0x4B056D0", VA = "0x184B06AD0")]
		private unsafe bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget)
		{
			return default(bool);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00010890 File Offset: 0x0000EA90
		[Token(Token = "0x60016AE")]
		[Address(RVA = "0x4B06A60", Offset = "0x4B05660", VA = "0x184B06A60")]
		private unsafe int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback)
		{
			return 0;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016AF")]
		[Address(RVA = "0x4B07690", Offset = "0x4B06290", VA = "0x184B07690")]
		private unsafe byte[] GetBytesUnknown(ref byte* pSrc, int ch)
		{
			return null;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x4B09EE0", Offset = "0x4B08AE0", VA = "0x184B09EE0", Slot = "32")]
		public override Decoder GetDecoder()
		{
			return null;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x4B09F40", Offset = "0x4B08B40", VA = "0x184B09F40", Slot = "33")]
		public override Encoder GetEncoder()
		{
			return null;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x000108A8 File Offset: 0x0000EAA8
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x4B0A040", Offset = "0x4B08C40", VA = "0x184B0A040", Slot = "34")]
		public override int GetMaxByteCount(int charCount)
		{
			return 0;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x000108C0 File Offset: 0x0000EAC0
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x4B0A1C0", Offset = "0x4B08DC0", VA = "0x184B0A1C0", Slot = "35")]
		public override int GetMaxCharCount(int byteCount)
		{
			return 0;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x4B0A340", Offset = "0x4B08F40", VA = "0x184B0A340", Slot = "6")]
		public override byte[] GetPreamble()
		{
			return null;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x000108D8 File Offset: 0x0000EAD8
		[Token(Token = "0x17000240")]
		public override System.ReadOnlySpan<byte> Preamble
		{
			[Token(Token = "0x60016B5")]
			[Address(RVA = "0x4B0A8A0", Offset = "0x4B094A0", VA = "0x184B0A8A0", Slot = "7")]
			get
			{
				return default(System.ReadOnlySpan<byte>);
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x000108F0 File Offset: 0x0000EAF0
		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x4B06940", Offset = "0x4B05540", VA = "0x184B06940", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00010908 File Offset: 0x0000EB08
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x4B09FA0", Offset = "0x4B08BA0", VA = "0x184B09FA0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly UTF8Encoding.UTF8EncodingSealed s_default;

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly byte[] s_preamble;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		[FieldOffset(Offset = "0x38")]
		internal readonly bool _emitUTF8Identifier;

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0x39")]
		private bool _isThrowException;

		// Token: 0x020002AB RID: 683
		[Token(Token = "0x20002AB")]
		internal sealed class UTF8EncodingSealed : UTF8Encoding
		{
			// Token: 0x060016B9 RID: 5817 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016B9")]
			[Address(RVA = "0x4B1D4F0", Offset = "0x4B1C0F0", VA = "0x184B1D4F0")]
			public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier)
			{
			}

			// Token: 0x17000241 RID: 577
			// (get) Token: 0x060016BA RID: 5818 RVA: 0x00010920 File Offset: 0x0000EB20
			[Token(Token = "0x17000241")]
			public override System.ReadOnlySpan<byte> Preamble
			{
				[Token(Token = "0x60016BA")]
				[Address(RVA = "0x4B1D550", Offset = "0x4B1C150", VA = "0x184B1D550", Slot = "7")]
				get
				{
					return default(System.ReadOnlySpan<byte>);
				}
			}
		}

		// Token: 0x020002AC RID: 684
		[Token(Token = "0x20002AC")]
		[System.Serializable]
		private sealed class UTF8Encoder : EncoderNLS
		{
			// Token: 0x060016BB RID: 5819 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016BB")]
			[Address(RVA = "0x4AF8D20", Offset = "0x4AF7920", VA = "0x184AF8D20")]
			public UTF8Encoder(UTF8Encoding encoding)
			{
			}

			// Token: 0x060016BC RID: 5820 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016BC")]
			[Address(RVA = "0x4B1D490", Offset = "0x4B1C090", VA = "0x184B1D490", Slot = "4")]
			public override void Reset()
			{
			}

			// Token: 0x17000242 RID: 578
			// (get) Token: 0x060016BD RID: 5821 RVA: 0x00010938 File Offset: 0x0000EB38
			[Token(Token = "0x17000242")]
			internal override bool HasState
			{
				[Token(Token = "0x60016BD")]
				[Address(RVA = "0x4B1D4E0", Offset = "0x4B1C0E0", VA = "0x184B1D4E0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04000C46 RID: 3142
			[Token(Token = "0x4000C46")]
			[FieldOffset(Offset = "0x38")]
			internal int surrogateChar;
		}

		// Token: 0x020002AD RID: 685
		[Token(Token = "0x20002AD")]
		[System.Serializable]
		private sealed class UTF8Decoder : DecoderNLS
		{
			// Token: 0x060016BE RID: 5822 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016BE")]
			[Address(RVA = "0x4AF5DA0", Offset = "0x4AF49A0", VA = "0x184AF5DA0")]
			public UTF8Decoder(UTF8Encoding encoding)
			{
			}

			// Token: 0x060016BF RID: 5823 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016BF")]
			[Address(RVA = "0x4B1D430", Offset = "0x4B1C030", VA = "0x184B1D430", Slot = "4")]
			public override void Reset()
			{
			}

			// Token: 0x17000243 RID: 579
			// (get) Token: 0x060016C0 RID: 5824 RVA: 0x00010950 File Offset: 0x0000EB50
			[Token(Token = "0x17000243")]
			internal override bool HasState
			{
				[Token(Token = "0x60016C0")]
				[Address(RVA = "0x4B1D480", Offset = "0x4B1C080", VA = "0x184B1D480", Slot = "14")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04000C47 RID: 3143
			[Token(Token = "0x4000C47")]
			[FieldOffset(Offset = "0x30")]
			internal int bits;
		}
	}
}
