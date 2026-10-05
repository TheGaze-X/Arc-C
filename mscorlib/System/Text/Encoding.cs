using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public abstract class Encoding : System.ICloneable
	{
		// Token: 0x060016EE RID: 5870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x4B108F0", Offset = "0x4B0F4F0", VA = "0x184B108F0")]
		protected Encoding()
		{
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x4B10940", Offset = "0x4B0F540", VA = "0x184B10940")]
		protected Encoding(int codePage)
		{
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x4B104C0", Offset = "0x4B0F0C0", VA = "0x184B104C0", Slot = "5")]
		internal virtual void SetDefaultFallbacks()
		{
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x4B10300", Offset = "0x4B0EF00", VA = "0x184B10300")]
		internal void OnDeserializing()
		{
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x4B102A0", Offset = "0x4B0EEA0", VA = "0x184B102A0")]
		internal void OnDeserialized()
		{
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x4B10300", Offset = "0x4B0EF00", VA = "0x184B10300")]
		[System.Runtime.Serialization.OnDeserializing]
		private void OnDeserializing(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x4B102A0", Offset = "0x4B0EEA0", VA = "0x184B102A0")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x3698D80", Offset = "0x3697980", VA = "0x183698D80")]
		[System.Runtime.Serialization.OnSerializing]
		private void OnSerializing(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x4B0D570", Offset = "0x4B0C170", VA = "0x184B0D570")]
		internal void DeserializeEncoding(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x4B10340", Offset = "0x4B0EF40", VA = "0x184B10340")]
		internal void SerializeEncoding(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000248")]
		private static object InternalSyncObject
		{
			[Token(Token = "0x60016F8")]
			[Address(RVA = "0x4B10CC0", Offset = "0x4B0F8C0", VA = "0x184B10CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x4B0F1C0", Offset = "0x4B0DDC0", VA = "0x184B0F1C0")]
		public static Encoding GetEncoding(int codepage)
		{
			return null;
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x4B0EE40", Offset = "0x4B0DA40", VA = "0x184B0EE40")]
		public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			return null;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x4B0F130", Offset = "0x4B0DD30", VA = "0x184B0F130")]
		public static Encoding GetEncoding(string name)
		{
			return null;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x4B0FE80", Offset = "0x4B0EA80", VA = "0x184B0FE80", Slot = "6")]
		public virtual byte[] GetPreamble()
		{
			return null;
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00010B90 File Offset: 0x0000ED90
		[Token(Token = "0x17000249")]
		public virtual System.ReadOnlySpan<byte> Preamble
		{
			[Token(Token = "0x60016FD")]
			[Address(RVA = "0x4B10E30", Offset = "0x4B0FA30", VA = "0x184B10E30", Slot = "7")]
			get
			{
				return default(System.ReadOnlySpan<byte>);
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x4B0EC20", Offset = "0x4B0D820", VA = "0x184B0EC20")]
		private void GetDataItem()
		{
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700024A")]
		public virtual string EncodingName
		{
			[Token(Token = "0x60016FF")]
			[Address(RVA = "0x4B10C70", Offset = "0x4B0F870", VA = "0x184B10C70", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700024B")]
		public virtual string HeaderName
		{
			[Token(Token = "0x6001700")]
			[Address(RVA = "0x4B10C80", Offset = "0x4B0F880", VA = "0x184B10C80", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700024C")]
		public virtual string WebName
		{
			[Token(Token = "0x6001701")]
			[Address(RVA = "0x4B111F0", Offset = "0x4B0FDF0", VA = "0x184B111F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024D")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public EncoderFallback EncoderFallback
		{
			[Token(Token = "0x6001702")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001703")]
			[Address(RVA = "0x4B11310", Offset = "0x4B0FF10", VA = "0x184B11310")]
			set
			{
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024E")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public DecoderFallback DecoderFallback
		{
			[Token(Token = "0x6001704")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001705")]
			[Address(RVA = "0x4B11230", Offset = "0x4B0FE30", VA = "0x184B11230")]
			set
			{
			}
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001706")]
		[Address(RVA = "0x4B0D470", Offset = "0x4B0C070", VA = "0x184B0D470", Slot = "11")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		[Token(Token = "0x1700024F")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public bool IsReadOnly
		{
			[Token(Token = "0x6001707")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000250")]
		public static Encoding ASCII
		{
			[Token(Token = "0x6001708")]
			[Address(RVA = "0x4B109F0", Offset = "0x4B0F5F0", VA = "0x184B109F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000251")]
		private static Encoding Latin1
		{
			[Token(Token = "0x6001709")]
			[Address(RVA = "0x4B10D70", Offset = "0x4B0F970", VA = "0x184B10D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		[Token(Token = "0x600170A")]
		[Address(RVA = "0x4B0DBB0", Offset = "0x4B0C7B0", VA = "0x184B0DBB0", Slot = "12")]
		public virtual int GetByteCount(string s)
		{
			return 0;
		}

		// Token: 0x0600170B RID: 5899
		[Token(Token = "0x600170B")]
		public abstract int GetByteCount(char[] chars, int index, int count);

		// Token: 0x0600170C RID: 5900 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		[Token(Token = "0x600170C")]
		[Address(RVA = "0x4B0DC80", Offset = "0x4B0C880", VA = "0x184B0DC80", Slot = "14")]
		[System.CLSCompliant(false)]
		[System.Runtime.InteropServices.ComVisible(false)]
		public unsafe virtual int GetByteCount(char* chars, int count)
		{
			return 0;
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		[Token(Token = "0x600170D")]
		[Address(RVA = "0x4B0DE40", Offset = "0x4B0CA40", VA = "0x184B0DE40", Slot = "15")]
		internal unsafe virtual int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			return 0;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600170E")]
		[Address(RVA = "0x4B0E270", Offset = "0x4B0CE70", VA = "0x184B0E270", Slot = "16")]
		public virtual byte[] GetBytes(char[] chars)
		{
			return null;
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600170F")]
		[Address(RVA = "0x4B0E110", Offset = "0x4B0CD10", VA = "0x184B0E110", Slot = "17")]
		public virtual byte[] GetBytes(char[] chars, int index, int count)
		{
			return null;
		}

		// Token: 0x06001710 RID: 5904
		[Token(Token = "0x6001710")]
		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

		// Token: 0x06001711 RID: 5905 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001711")]
		[Address(RVA = "0x4B0E340", Offset = "0x4B0CF40", VA = "0x184B0E340", Slot = "19")]
		public virtual byte[] GetBytes(string s)
		{
			return null;
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00010C08 File Offset: 0x0000EE08
		[Token(Token = "0x6001712")]
		[Address(RVA = "0x4B0E490", Offset = "0x4B0D090", VA = "0x184B0E490", Slot = "20")]
		public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00010C20 File Offset: 0x0000EE20
		[Token(Token = "0x6001713")]
		[Address(RVA = "0x4B0E200", Offset = "0x4B0CE00", VA = "0x184B0E200", Slot = "21")]
		internal unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			return 0;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00010C38 File Offset: 0x0000EE38
		[Token(Token = "0x6001714")]
		[Address(RVA = "0x4B0DEA0", Offset = "0x4B0CAA0", VA = "0x184B0DEA0", Slot = "22")]
		[System.Runtime.InteropServices.ComVisible(false)]
		[System.CLSCompliant(false)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			return 0;
		}

		// Token: 0x06001715 RID: 5909
		[Token(Token = "0x6001715")]
		public abstract int GetCharCount(byte[] bytes, int index, int count);

		// Token: 0x06001716 RID: 5910 RVA: 0x00010C50 File Offset: 0x0000EE50
		[Token(Token = "0x6001716")]
		[Address(RVA = "0x4B0E550", Offset = "0x4B0D150", VA = "0x184B0E550", Slot = "24")]
		[System.CLSCompliant(false)]
		[System.Runtime.InteropServices.ComVisible(false)]
		public unsafe virtual int GetCharCount(byte* bytes, int count)
		{
			return 0;
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00010C68 File Offset: 0x0000EE68
		[Token(Token = "0x6001717")]
		[Address(RVA = "0x4B0E710", Offset = "0x4B0D310", VA = "0x184B0E710", Slot = "25")]
		internal unsafe virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			return 0;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001718")]
		[Address(RVA = "0x4B0EB50", Offset = "0x4B0D750", VA = "0x184B0EB50", Slot = "26")]
		public virtual char[] GetChars(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001719")]
		[Address(RVA = "0x4B0E770", Offset = "0x4B0D370", VA = "0x184B0E770", Slot = "27")]
		public virtual char[] GetChars(byte[] bytes, int index, int count)
		{
			return null;
		}

		// Token: 0x0600171A RID: 5914
		[Token(Token = "0x600171A")]
		public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		// Token: 0x0600171B RID: 5915 RVA: 0x00010C80 File Offset: 0x0000EE80
		[Token(Token = "0x600171B")]
		[Address(RVA = "0x4B0E8D0", Offset = "0x4B0D4D0", VA = "0x184B0E8D0", Slot = "29")]
		[System.CLSCompliant(false)]
		[System.Runtime.InteropServices.ComVisible(false)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			return 0;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00010C98 File Offset: 0x0000EE98
		[Token(Token = "0x600171C")]
		[Address(RVA = "0x4B0E860", Offset = "0x4B0D460", VA = "0x184B0E860", Slot = "30")]
		internal unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			return 0;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600171D")]
		[Address(RVA = "0x4B0FFA0", Offset = "0x4B0EBA0", VA = "0x184B0FFA0")]
		[System.CLSCompliant(false)]
		[System.Runtime.InteropServices.ComVisible(false)]
		public unsafe string GetString(byte* bytes, int byteCount)
		{
			return null;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600171E")]
		[Address(RVA = "0x4B100C0", Offset = "0x4B0ECC0", VA = "0x184B100C0")]
		public string GetString(System.ReadOnlySpan<byte> bytes)
		{
			return null;
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		[Token(Token = "0x17000252")]
		public virtual int CodePage
		{
			[Token(Token = "0x600171F")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "31")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001720")]
		[Address(RVA = "0x4B0ED60", Offset = "0x4B0D960", VA = "0x184B0ED60", Slot = "32")]
		public virtual Decoder GetDecoder()
		{
			return null;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001721")]
		[Address(RVA = "0x4B0D520", Offset = "0x4B0C120", VA = "0x184B0D520")]
		private static Encoding CreateDefaultEncoding()
		{
			return null;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001722")]
		[Address(RVA = "0x4F6210", Offset = "0x4F4E10", VA = "0x1804F6210")]
		internal void setReadOnly(bool value = true)
		{
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000253")]
		public static Encoding Default
		{
			[Token(Token = "0x6001723")]
			[Address(RVA = "0x4B10B90", Offset = "0x4B0F790", VA = "0x184B10B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001724")]
		[Address(RVA = "0x4B0EDD0", Offset = "0x4B0D9D0", VA = "0x184B0EDD0", Slot = "33")]
		public virtual Encoder GetEncoder()
		{
			return null;
		}

		// Token: 0x06001725 RID: 5925
		[Token(Token = "0x6001725")]
		public abstract int GetMaxByteCount(int charCount);

		// Token: 0x06001726 RID: 5926
		[Token(Token = "0x6001726")]
		public abstract int GetMaxCharCount(int byteCount);

		// Token: 0x06001727 RID: 5927 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001727")]
		[Address(RVA = "0x4B0FED0", Offset = "0x4B0EAD0", VA = "0x184B0FED0", Slot = "36")]
		public virtual string GetString(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001728")]
		[Address(RVA = "0x4B10220", Offset = "0x4B0EE20", VA = "0x184B10220", Slot = "37")]
		public virtual string GetString(byte[] bytes, int index, int count)
		{
			return null;
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000254")]
		public static Encoding Unicode
		{
			[Token(Token = "0x6001729")]
			[Address(RVA = "0x4B11110", Offset = "0x4B0FD10", VA = "0x184B11110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000255")]
		public static Encoding BigEndianUnicode
		{
			[Token(Token = "0x600172A")]
			[Address(RVA = "0x4B10AB0", Offset = "0x4B0F6B0", VA = "0x184B10AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000256")]
		public static Encoding UTF7
		{
			[Token(Token = "0x600172B")]
			[Address(RVA = "0x4B10F80", Offset = "0x4B0FB80", VA = "0x184B10F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000257")]
		public static Encoding UTF8
		{
			[Token(Token = "0x600172C")]
			[Address(RVA = "0x4B11040", Offset = "0x4B0FC40", VA = "0x184B11040")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000258")]
		public static Encoding UTF32
		{
			[Token(Token = "0x600172D")]
			[Address(RVA = "0x4B10EB0", Offset = "0x4B0FAB0", VA = "0x184B10EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x4B0D9F0", Offset = "0x4B0C5F0", VA = "0x184B0D9F0", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x4B0FDE0", Offset = "0x4B0E9E0", VA = "0x184B0FDE0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x4B0DB60", Offset = "0x4B0C760", VA = "0x184B0DB60", Slot = "38")]
		internal virtual char[] GetBestFitUnicodeToBytesData()
		{
			return null;
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x4B0DB10", Offset = "0x4B0C710", VA = "0x184B0DB10", Slot = "39")]
		internal virtual char[] GetBestFitBytesToUnicodeData()
		{
			return null;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001732")]
		[Address(RVA = "0x4B10570", Offset = "0x4B0F170", VA = "0x184B10570")]
		internal void ThrowBytesOverflow()
		{
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x4B10690", Offset = "0x4B0F290", VA = "0x184B10690")]
		internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded)
		{
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001734")]
		[Address(RVA = "0x4B10730", Offset = "0x4B0F330", VA = "0x184B10730")]
		internal void ThrowCharsOverflow()
		{
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x4B10850", Offset = "0x4B0F450", VA = "0x184B10850")]
		internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded)
		{
		}

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Encoding defaultEncoding;

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Encoding unicodeEncoding;

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Encoding bigEndianUnicode;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Encoding utf7Encoding;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Encoding utf8Encoding;

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Encoding utf32Encoding;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Encoding asciiEncoding;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Encoding latin1Encoding;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static System.Collections.Generic.Dictionary<int, Encoding> encodings;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		private const int MIMECONTF_MAILNEWS = 1;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		private const int MIMECONTF_BROWSER = 2;

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		private const int MIMECONTF_SAVABLE_MAILNEWS = 256;

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		private const int MIMECONTF_SAVABLE_BROWSER = 512;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		private const int CodePageDefault = 0;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		private const int CodePageNoOEM = 1;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		private const int CodePageNoMac = 2;

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		private const int CodePageNoThread = 3;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		private const int CodePageNoSymbol = 42;

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		private const int CodePageUnicode = 1200;

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		private const int CodePageBigEndian = 1201;

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		private const int CodePageWindows1252 = 1252;

		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		private const int CodePageMacGB2312 = 10008;

		// Token: 0x04000C6B RID: 3179
		[Token(Token = "0x4000C6B")]
		private const int CodePageGB2312 = 20936;

		// Token: 0x04000C6C RID: 3180
		[Token(Token = "0x4000C6C")]
		private const int CodePageMacKorean = 10003;

		// Token: 0x04000C6D RID: 3181
		[Token(Token = "0x4000C6D")]
		private const int CodePageDLLKorean = 20949;

		// Token: 0x04000C6E RID: 3182
		[Token(Token = "0x4000C6E")]
		private const int ISO2022JP = 50220;

		// Token: 0x04000C6F RID: 3183
		[Token(Token = "0x4000C6F")]
		private const int ISO2022JPESC = 50221;

		// Token: 0x04000C70 RID: 3184
		[Token(Token = "0x4000C70")]
		private const int ISO2022JPSISO = 50222;

		// Token: 0x04000C71 RID: 3185
		[Token(Token = "0x4000C71")]
		private const int ISOKorean = 50225;

		// Token: 0x04000C72 RID: 3186
		[Token(Token = "0x4000C72")]
		private const int ISOSimplifiedCN = 50227;

		// Token: 0x04000C73 RID: 3187
		[Token(Token = "0x4000C73")]
		private const int EUCJP = 51932;

		// Token: 0x04000C74 RID: 3188
		[Token(Token = "0x4000C74")]
		private const int ChineseHZ = 52936;

		// Token: 0x04000C75 RID: 3189
		[Token(Token = "0x4000C75")]
		private const int DuplicateEUCCN = 51936;

		// Token: 0x04000C76 RID: 3190
		[Token(Token = "0x4000C76")]
		private const int EUCCN = 936;

		// Token: 0x04000C77 RID: 3191
		[Token(Token = "0x4000C77")]
		private const int EUCKR = 51949;

		// Token: 0x04000C78 RID: 3192
		[Token(Token = "0x4000C78")]
		internal const int CodePageASCII = 20127;

		// Token: 0x04000C79 RID: 3193
		[Token(Token = "0x4000C79")]
		internal const int ISO_8859_1 = 28591;

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		private const int ISCIIAssemese = 57006;

		// Token: 0x04000C7B RID: 3195
		[Token(Token = "0x4000C7B")]
		private const int ISCIIBengali = 57003;

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		private const int ISCIIDevanagari = 57002;

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		private const int ISCIIGujarathi = 57010;

		// Token: 0x04000C7E RID: 3198
		[Token(Token = "0x4000C7E")]
		private const int ISCIIKannada = 57008;

		// Token: 0x04000C7F RID: 3199
		[Token(Token = "0x4000C7F")]
		private const int ISCIIMalayalam = 57009;

		// Token: 0x04000C80 RID: 3200
		[Token(Token = "0x4000C80")]
		private const int ISCIIOriya = 57007;

		// Token: 0x04000C81 RID: 3201
		[Token(Token = "0x4000C81")]
		private const int ISCIIPanjabi = 57011;

		// Token: 0x04000C82 RID: 3202
		[Token(Token = "0x4000C82")]
		private const int ISCIITamil = 57004;

		// Token: 0x04000C83 RID: 3203
		[Token(Token = "0x4000C83")]
		private const int ISCIITelugu = 57005;

		// Token: 0x04000C84 RID: 3204
		[Token(Token = "0x4000C84")]
		private const int GB18030 = 54936;

		// Token: 0x04000C85 RID: 3205
		[Token(Token = "0x4000C85")]
		private const int ISO_8859_8I = 38598;

		// Token: 0x04000C86 RID: 3206
		[Token(Token = "0x4000C86")]
		private const int ISO_8859_8_Visual = 28598;

		// Token: 0x04000C87 RID: 3207
		[Token(Token = "0x4000C87")]
		private const int ENC50229 = 50229;

		// Token: 0x04000C88 RID: 3208
		[Token(Token = "0x4000C88")]
		private const int CodePageUTF7 = 65000;

		// Token: 0x04000C89 RID: 3209
		[Token(Token = "0x4000C89")]
		private const int CodePageUTF8 = 65001;

		// Token: 0x04000C8A RID: 3210
		[Token(Token = "0x4000C8A")]
		private const int CodePageUTF32 = 12000;

		// Token: 0x04000C8B RID: 3211
		[Token(Token = "0x4000C8B")]
		private const int CodePageUTF32BE = 12001;

		// Token: 0x04000C8C RID: 3212
		[Token(Token = "0x4000C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int m_codePage;

		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4000C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal CodePageDataItem dataItem;

		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[System.NonSerialized]
		internal bool m_deserializedFromEverett;

		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		internal EncoderFallback encoderFallback;

		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4000C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		internal DecoderFallback decoderFallback;

		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static object s_InternalSyncObject;

		// Token: 0x020002B2 RID: 690
		[Token(Token = "0x20002B2")]
		[System.Serializable]
		internal class DefaultEncoder : Encoder, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IObjectReference
		{
			// Token: 0x06001736 RID: 5942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001736")]
			[Address(RVA = "0x4B0B800", Offset = "0x4B0A400", VA = "0x184B0B800")]
			public DefaultEncoder(Encoding encoding)
			{
			}

			// Token: 0x06001737 RID: 5943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001737")]
			[Address(RVA = "0x4B0BBC0", Offset = "0x4B0A7C0", VA = "0x184B0BBC0")]
			internal DefaultEncoder(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			{
			}

			// Token: 0x06001738 RID: 5944 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6001738")]
			[Address(RVA = "0x4B0BA00", Offset = "0x4B0A600", VA = "0x184B0BA00", Slot = "12")]
			public object GetRealObject(System.Runtime.Serialization.StreamingContext context)
			{
				return null;
			}

			// Token: 0x06001739 RID: 5945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001739")]
			[Address(RVA = "0x4B0BB10", Offset = "0x4B0A710", VA = "0x184B0BB10", Slot = "11")]
			private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			{
			}

			// Token: 0x0600173A RID: 5946 RVA: 0x00010CF8 File Offset: 0x0000EEF8
			[Token(Token = "0x600173A")]
			[Address(RVA = "0x4B0B8B0", Offset = "0x4B0A4B0", VA = "0x184B0B8B0", Slot = "5")]
			public override int GetByteCount(char[] chars, int index, int count, bool flush)
			{
				return 0;
			}

			// Token: 0x0600173B RID: 5947 RVA: 0x00010D10 File Offset: 0x0000EF10
			[Token(Token = "0x600173B")]
			[Address(RVA = "0x4B0B840", Offset = "0x4B0A440", VA = "0x184B0B840", Slot = "6")]
			public unsafe override int GetByteCount(char* chars, int count, bool flush)
			{
				return 0;
			}

			// Token: 0x0600173C RID: 5948 RVA: 0x00010D28 File Offset: 0x0000EF28
			[Token(Token = "0x600173C")]
			[Address(RVA = "0x4B0B930", Offset = "0x4B0A530", VA = "0x184B0B930", Slot = "7")]
			public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
			{
				return 0;
			}

			// Token: 0x0600173D RID: 5949 RVA: 0x00010D40 File Offset: 0x0000EF40
			[Token(Token = "0x600173D")]
			[Address(RVA = "0x4B0B980", Offset = "0x4B0A580", VA = "0x184B0B980", Slot = "8")]
			public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
			{
				return 0;
			}

			// Token: 0x04000C93 RID: 3219
			[Token(Token = "0x4000C93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Encoding m_encoding;

			// Token: 0x04000C94 RID: 3220
			[Token(Token = "0x4000C94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[System.NonSerialized]
			private bool m_hasInitializedEncoding;

			// Token: 0x04000C95 RID: 3221
			[Token(Token = "0x4000C95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
			[System.NonSerialized]
			internal char charLeftOver;
		}

		// Token: 0x020002B3 RID: 691
		[Token(Token = "0x20002B3")]
		[System.Serializable]
		internal class DefaultDecoder : Decoder, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IObjectReference
		{
			// Token: 0x0600173E RID: 5950 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600173E")]
			[Address(RVA = "0x4B0B800", Offset = "0x4B0A400", VA = "0x184B0B800")]
			public DefaultDecoder(Encoding encoding)
			{
			}

			// Token: 0x0600173F RID: 5951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600173F")]
			[Address(RVA = "0x4B0B490", Offset = "0x4B0A090", VA = "0x184B0B490")]
			internal DefaultDecoder(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			{
			}

			// Token: 0x06001740 RID: 5952 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6001740")]
			[Address(RVA = "0x4B0B360", Offset = "0x4B09F60", VA = "0x184B0B360", Slot = "15")]
			public object GetRealObject(System.Runtime.Serialization.StreamingContext context)
			{
				return null;
			}

			// Token: 0x06001741 RID: 5953 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001741")]
			[Address(RVA = "0x4B0B3E0", Offset = "0x4B09FE0", VA = "0x184B0B3E0", Slot = "14")]
			private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			{
			}

			// Token: 0x06001742 RID: 5954 RVA: 0x00010D58 File Offset: 0x0000EF58
			[Token(Token = "0x6001742")]
			[Address(RVA = "0x4ADCBE0", Offset = "0x4ADB7E0", VA = "0x184ADCBE0", Slot = "5")]
			public override int GetCharCount(byte[] bytes, int index, int count)
			{
				return 0;
			}

			// Token: 0x06001743 RID: 5955 RVA: 0x00010D70 File Offset: 0x0000EF70
			[Token(Token = "0x6001743")]
			[Address(RVA = "0x4B0B1A0", Offset = "0x4B09DA0", VA = "0x184B0B1A0", Slot = "6")]
			public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
			{
				return 0;
			}

			// Token: 0x06001744 RID: 5956 RVA: 0x00010D88 File Offset: 0x0000EF88
			[Token(Token = "0x6001744")]
			[Address(RVA = "0x4B0B220", Offset = "0x4B09E20", VA = "0x184B0B220", Slot = "7")]
			public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
			{
				return 0;
			}

			// Token: 0x06001745 RID: 5957 RVA: 0x00010DA0 File Offset: 0x0000EFA0
			[Token(Token = "0x6001745")]
			[Address(RVA = "0x4ADCF80", Offset = "0x4ADBB80", VA = "0x184ADCF80", Slot = "8")]
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
			{
				return 0;
			}

			// Token: 0x06001746 RID: 5958 RVA: 0x00010DB8 File Offset: 0x0000EFB8
			[Token(Token = "0x6001746")]
			[Address(RVA = "0x4B0B310", Offset = "0x4B09F10", VA = "0x184B0B310", Slot = "9")]
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
			{
				return 0;
			}

			// Token: 0x06001747 RID: 5959 RVA: 0x00010DD0 File Offset: 0x0000EFD0
			[Token(Token = "0x6001747")]
			[Address(RVA = "0x4B0B290", Offset = "0x4B09E90", VA = "0x184B0B290", Slot = "10")]
			public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
			{
				return 0;
			}

			// Token: 0x04000C96 RID: 3222
			[Token(Token = "0x4000C96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Encoding m_encoding;

			// Token: 0x04000C97 RID: 3223
			[Token(Token = "0x4000C97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[System.NonSerialized]
			private bool m_hasInitializedEncoding;
		}

		// Token: 0x020002B4 RID: 692
		[Token(Token = "0x20002B4")]
		internal class EncodingCharBuffer
		{
			// Token: 0x06001748 RID: 5960 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001748")]
			[Address(RVA = "0x4B0C9E0", Offset = "0x4B0B5E0", VA = "0x184B0C9E0")]
			internal unsafe EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount)
			{
			}

			// Token: 0x06001749 RID: 5961 RVA: 0x00010DE8 File Offset: 0x0000EFE8
			[Token(Token = "0x6001749")]
			[Address(RVA = "0x4B0C600", Offset = "0x4B0B200", VA = "0x184B0C600")]
			internal bool AddChar(char ch, int numBytes)
			{
				return default(bool);
			}

			// Token: 0x0600174A RID: 5962 RVA: 0x00010E00 File Offset: 0x0000F000
			[Token(Token = "0x600174A")]
			[Address(RVA = "0x4B0C6E0", Offset = "0x4B0B2E0", VA = "0x184B0C6E0")]
			internal bool AddChar(char ch)
			{
				return default(bool);
			}

			// Token: 0x0600174B RID: 5963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600174B")]
			[Address(RVA = "0x4B0C7C0", Offset = "0x4B0B3C0", VA = "0x184B0C7C0")]
			internal void AdjustBytes(int count)
			{
			}

			// Token: 0x17000259 RID: 601
			// (get) Token: 0x0600174C RID: 5964 RVA: 0x00010E18 File Offset: 0x0000F018
			[Token(Token = "0x17000259")]
			internal bool MoreData
			{
				[Token(Token = "0x600174C")]
				[Address(RVA = "0x4B0CB00", Offset = "0x4B0B700", VA = "0x184B0CB00")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600174D RID: 5965 RVA: 0x00010E30 File Offset: 0x0000F030
			[Token(Token = "0x600174D")]
			[Address(RVA = "0x4B0C9C0", Offset = "0x4B0B5C0", VA = "0x184B0C9C0")]
			internal byte GetNextByte()
			{
				return 0;
			}

			// Token: 0x1700025A RID: 602
			// (get) Token: 0x0600174E RID: 5966 RVA: 0x00010E48 File Offset: 0x0000F048
			[Token(Token = "0x1700025A")]
			internal int BytesUsed
			{
				[Token(Token = "0x600174E")]
				[Address(RVA = "0x4B0CAF0", Offset = "0x4B0B6F0", VA = "0x184B0CAF0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600174F RID: 5967 RVA: 0x00010E60 File Offset: 0x0000F060
			[Token(Token = "0x600174F")]
			[Address(RVA = "0x4B0C7D0", Offset = "0x4B0B3D0", VA = "0x184B0C7D0")]
			internal bool Fallback(byte fallbackByte)
			{
				return default(bool);
			}

			// Token: 0x06001750 RID: 5968 RVA: 0x00010E78 File Offset: 0x0000F078
			[Token(Token = "0x6001750")]
			[Address(RVA = "0x4B0C840", Offset = "0x4B0B440", VA = "0x184B0C840")]
			internal bool Fallback(byte[] byteBuffer)
			{
				return default(bool);
			}

			// Token: 0x1700025B RID: 603
			// (get) Token: 0x06001751 RID: 5969 RVA: 0x00010E90 File Offset: 0x0000F090
			[Token(Token = "0x1700025B")]
			internal int Count
			{
				[Token(Token = "0x6001751")]
				[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000C98 RID: 3224
			[Token(Token = "0x4000C98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private unsafe char* chars;

			// Token: 0x04000C99 RID: 3225
			[Token(Token = "0x4000C99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private unsafe char* charStart;

			// Token: 0x04000C9A RID: 3226
			[Token(Token = "0x4000C9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private unsafe char* charEnd;

			// Token: 0x04000C9B RID: 3227
			[Token(Token = "0x4000C9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int charCountResult;

			// Token: 0x04000C9C RID: 3228
			[Token(Token = "0x4000C9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Encoding enc;

			// Token: 0x04000C9D RID: 3229
			[Token(Token = "0x4000C9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private DecoderNLS decoder;

			// Token: 0x04000C9E RID: 3230
			[Token(Token = "0x4000C9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private unsafe byte* byteStart;

			// Token: 0x04000C9F RID: 3231
			[Token(Token = "0x4000C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private unsafe byte* byteEnd;

			// Token: 0x04000CA0 RID: 3232
			[Token(Token = "0x4000CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private unsafe byte* bytes;

			// Token: 0x04000CA1 RID: 3233
			[Token(Token = "0x4000CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private DecoderFallbackBuffer fallbackBuffer;
		}

		// Token: 0x020002B5 RID: 693
		[Token(Token = "0x20002B5")]
		internal class EncodingByteBuffer
		{
			// Token: 0x06001752 RID: 5970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001752")]
			[Address(RVA = "0x4B0C2D0", Offset = "0x4B0AED0", VA = "0x184B0C2D0")]
			internal unsafe EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount)
			{
			}

			// Token: 0x06001753 RID: 5971 RVA: 0x00010EA8 File Offset: 0x0000F0A8
			[Token(Token = "0x6001753")]
			[Address(RVA = "0x4B0C050", Offset = "0x4B0AC50", VA = "0x184B0C050")]
			internal bool AddByte(byte b, int moreBytesExpected)
			{
				return default(bool);
			}

			// Token: 0x06001754 RID: 5972 RVA: 0x00010EC0 File Offset: 0x0000F0C0
			[Token(Token = "0x6001754")]
			[Address(RVA = "0x4B0C040", Offset = "0x4B0AC40", VA = "0x184B0C040")]
			internal bool AddByte(byte b1)
			{
				return default(bool);
			}

			// Token: 0x06001755 RID: 5973 RVA: 0x00010ED8 File Offset: 0x0000F0D8
			[Token(Token = "0x6001755")]
			[Address(RVA = "0x4B0BFF0", Offset = "0x4B0ABF0", VA = "0x184B0BFF0")]
			internal bool AddByte(byte b1, byte b2)
			{
				return default(bool);
			}

			// Token: 0x06001756 RID: 5974 RVA: 0x00010EF0 File Offset: 0x0000F0F0
			[Token(Token = "0x6001756")]
			[Address(RVA = "0x4B0BF90", Offset = "0x4B0AB90", VA = "0x184B0BF90")]
			internal bool AddByte(byte b1, byte b2, int moreBytesExpected)
			{
				return default(bool);
			}

			// Token: 0x06001757 RID: 5975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001757")]
			[Address(RVA = "0x4B0C1C0", Offset = "0x4B0ADC0", VA = "0x184B0C1C0")]
			internal void MovePrevious(bool bThrow)
			{
			}

			// Token: 0x1700025C RID: 604
			// (get) Token: 0x06001758 RID: 5976 RVA: 0x00010F08 File Offset: 0x0000F108
			[Token(Token = "0x1700025C")]
			internal bool MoreData
			{
				[Token(Token = "0x6001758")]
				[Address(RVA = "0x4B0C590", Offset = "0x4B0B190", VA = "0x184B0C590")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06001759 RID: 5977 RVA: 0x00010F20 File Offset: 0x0000F120
			[Token(Token = "0x6001759")]
			[Address(RVA = "0x4B0C180", Offset = "0x4B0AD80", VA = "0x184B0C180")]
			internal char GetNextChar()
			{
				return '\0';
			}

			// Token: 0x1700025D RID: 605
			// (get) Token: 0x0600175A RID: 5978 RVA: 0x00010F38 File Offset: 0x0000F138
			[Token(Token = "0x1700025D")]
			internal int CharsUsed
			{
				[Token(Token = "0x600175A")]
				[Address(RVA = "0x4B0C570", Offset = "0x4B0B170", VA = "0x184B0C570")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700025E RID: 606
			// (get) Token: 0x0600175B RID: 5979 RVA: 0x00010F50 File Offset: 0x0000F150
			[Token(Token = "0x1700025E")]
			internal int Count
			{
				[Token(Token = "0x600175B")]
				[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000CA2 RID: 3234
			[Token(Token = "0x4000CA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private unsafe byte* bytes;

			// Token: 0x04000CA3 RID: 3235
			[Token(Token = "0x4000CA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private unsafe byte* byteStart;

			// Token: 0x04000CA4 RID: 3236
			[Token(Token = "0x4000CA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private unsafe byte* byteEnd;

			// Token: 0x04000CA5 RID: 3237
			[Token(Token = "0x4000CA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private unsafe char* chars;

			// Token: 0x04000CA6 RID: 3238
			[Token(Token = "0x4000CA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private unsafe char* charStart;

			// Token: 0x04000CA7 RID: 3239
			[Token(Token = "0x4000CA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private unsafe char* charEnd;

			// Token: 0x04000CA8 RID: 3240
			[Token(Token = "0x4000CA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int byteCountResult;

			// Token: 0x04000CA9 RID: 3241
			[Token(Token = "0x4000CA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Encoding enc;

			// Token: 0x04000CAA RID: 3242
			[Token(Token = "0x4000CAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private EncoderNLS encoder;

			// Token: 0x04000CAB RID: 3243
			[Token(Token = "0x4000CAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal EncoderFallbackBuffer fallbackBuffer;
		}
	}
}
