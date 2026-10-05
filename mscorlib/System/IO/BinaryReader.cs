using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200067A RID: 1658
	[Token(Token = "0x200067A")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class BinaryReader : System.IDisposable
	{
		// Token: 0x06003234 RID: 12852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003234")]
		[Address(RVA = "0x4C750E0", Offset = "0x4C73CE0", VA = "0x184C750E0")]
		public BinaryReader(Stream input)
		{
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003235")]
		[Address(RVA = "0x4C75160", Offset = "0x4C73D60", VA = "0x184C75160")]
		public BinaryReader(Stream input, System.Text.Encoding encoding)
		{
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003236")]
		[Address(RVA = "0x4C74E20", Offset = "0x4C73A20", VA = "0x184C74E20")]
		public BinaryReader(Stream input, System.Text.Encoding encoding, bool leaveOpen)
		{
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06003237 RID: 12855 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000813")]
		public virtual Stream BaseStream
		{
			[Token(Token = "0x6003237")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003238")]
		[Address(RVA = "0x4C731B0", Offset = "0x4C71DB0", VA = "0x184C731B0", Slot = "6")]
		public virtual void Close()
		{
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003239")]
		[Address(RVA = "0x4C731F0", Offset = "0x4C71DF0", VA = "0x184C731F0", Slot = "7")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600323A")]
		[Address(RVA = "0x4C731B0", Offset = "0x4C71DB0", VA = "0x184C731B0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x0001AE68 File Offset: 0x00019068
		[Token(Token = "0x600323B")]
		[Address(RVA = "0x4C73A60", Offset = "0x4C72660", VA = "0x184C73A60", Slot = "8")]
		public virtual int PeekChar()
		{
			return 0;
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x0001AE80 File Offset: 0x00019080
		[Token(Token = "0x600323C")]
		[Address(RVA = "0x4C74BF0", Offset = "0x4C737F0", VA = "0x184C74BF0", Slot = "9")]
		public virtual int Read()
		{
			return 0;
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x0001AE98 File Offset: 0x00019098
		[Token(Token = "0x600323D")]
		[Address(RVA = "0x4C73C40", Offset = "0x4C72840", VA = "0x184C73C40", Slot = "10")]
		public virtual bool ReadBoolean()
		{
			return default(bool);
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x0001AEB0 File Offset: 0x000190B0
		[Token(Token = "0x600323E")]
		[Address(RVA = "0x4C73CA0", Offset = "0x4C728A0", VA = "0x184C73CA0", Slot = "11")]
		public virtual byte ReadByte()
		{
			return 0;
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x0001AEC8 File Offset: 0x000190C8
		[Token(Token = "0x600323F")]
		[Address(RVA = "0x4C746B0", Offset = "0x4C732B0", VA = "0x184C746B0", Slot = "12")]
		[System.CLSCompliant(false)]
		public virtual sbyte ReadSByte()
		{
			return 0;
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x0001AEE0 File Offset: 0x000190E0
		[Token(Token = "0x6003240")]
		[Address(RVA = "0x4C73EF0", Offset = "0x4C72AF0", VA = "0x184C73EF0", Slot = "13")]
		public virtual char ReadChar()
		{
			return '\0';
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x0001AEF8 File Offset: 0x000190F8
		[Token(Token = "0x6003241")]
		[Address(RVA = "0x4C74300", Offset = "0x4C72F00", VA = "0x184C74300", Slot = "14")]
		public virtual short ReadInt16()
		{
			return 0;
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x0001AF10 File Offset: 0x00019110
		[Token(Token = "0x6003242")]
		[Address(RVA = "0x4C74300", Offset = "0x4C72F00", VA = "0x184C74300", Slot = "15")]
		[System.CLSCompliant(false)]
		public virtual ushort ReadUInt16()
		{
			return 0;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x0001AF28 File Offset: 0x00019128
		[Token(Token = "0x6003243")]
		[Address(RVA = "0x4C74370", Offset = "0x4C72F70", VA = "0x184C74370", Slot = "16")]
		public virtual int ReadInt32()
		{
			return 0;
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x0001AF40 File Offset: 0x00019140
		[Token(Token = "0x6003244")]
		[Address(RVA = "0x4C74B60", Offset = "0x4C73760", VA = "0x184C74B60", Slot = "17")]
		[System.CLSCompliant(false)]
		public virtual uint ReadUInt32()
		{
			return 0U;
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x0001AF58 File Offset: 0x00019158
		[Token(Token = "0x6003245")]
		[Address(RVA = "0x4C745C0", Offset = "0x4C731C0", VA = "0x184C745C0", Slot = "18")]
		public virtual long ReadInt64()
		{
			return 0L;
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x0001AF70 File Offset: 0x00019170
		[Token(Token = "0x6003246")]
		[Address(RVA = "0x4C745C0", Offset = "0x4C731C0", VA = "0x184C745C0", Slot = "19")]
		[System.CLSCompliant(false)]
		public virtual ulong ReadUInt64()
		{
			return 0UL;
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x0001AF88 File Offset: 0x00019188
		[Token(Token = "0x6003247")]
		[Address(RVA = "0x4C74710", Offset = "0x4C73310", VA = "0x184C74710", Slot = "20")]
		public virtual float ReadSingle()
		{
			return 0f;
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x0001AFA0 File Offset: 0x000191A0
		[Token(Token = "0x6003248")]
		[Address(RVA = "0x4C742B0", Offset = "0x4C72EB0", VA = "0x184C742B0", Slot = "21")]
		public virtual double ReadDouble()
		{
			return 0.0;
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x0001AFB8 File Offset: 0x000191B8
		[Token(Token = "0x6003249")]
		[Address(RVA = "0x4C740C0", Offset = "0x4C72CC0", VA = "0x184C740C0", Slot = "22")]
		public virtual decimal ReadDecimal()
		{
			return 0m;
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600324A")]
		[Address(RVA = "0x4C74760", Offset = "0x4C73360", VA = "0x184C74760", Slot = "23")]
		public virtual string ReadString()
		{
			return null;
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x0001AFD0 File Offset: 0x000191D0
		[Token(Token = "0x600324B")]
		[Address(RVA = "0x4C73450", Offset = "0x4C72050", VA = "0x184C73450")]
		private int InternalReadChars(char[] buffer, int index, int count)
		{
			return 0;
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x0001AFE8 File Offset: 0x000191E8
		[Token(Token = "0x600324C")]
		[Address(RVA = "0x4C737B0", Offset = "0x4C723B0", VA = "0x184C737B0")]
		private int InternalReadOneChar()
		{
			return 0;
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600324D")]
		[Address(RVA = "0x4C73F40", Offset = "0x4C72B40", VA = "0x184C73F40", Slot = "24")]
		public virtual char[] ReadChars(int count)
		{
			return null;
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x0001B000 File Offset: 0x00019200
		[Token(Token = "0x600324E")]
		[Address(RVA = "0x4C74C10", Offset = "0x4C73810", VA = "0x184C74C10", Slot = "25")]
		public virtual int Read(byte[] buffer, int index, int count)
		{
			return 0;
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600324F")]
		[Address(RVA = "0x4C73D00", Offset = "0x4C72900", VA = "0x184C73D00", Slot = "26")]
		public virtual byte[] ReadBytes(int count)
		{
			return null;
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003250")]
		[Address(RVA = "0x4C732B0", Offset = "0x4C71EB0", VA = "0x184C732B0", Slot = "27")]
		protected virtual void FillBuffer(int numBytes)
		{
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x0001B018 File Offset: 0x00019218
		[Token(Token = "0x6003251")]
		[Address(RVA = "0x4C73B70", Offset = "0x4C72770", VA = "0x184C73B70")]
		protected internal int Read7BitEncodedInt()
		{
			return 0;
		}

		// Token: 0x04001B7E RID: 7038
		[Token(Token = "0x4001B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Stream m_stream;

		// Token: 0x04001B7F RID: 7039
		[Token(Token = "0x4001B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private byte[] m_buffer;

		// Token: 0x04001B80 RID: 7040
		[Token(Token = "0x4001B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Text.Decoder m_decoder;

		// Token: 0x04001B81 RID: 7041
		[Token(Token = "0x4001B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] m_charBytes;

		// Token: 0x04001B82 RID: 7042
		[Token(Token = "0x4001B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private char[] m_singleChar;

		// Token: 0x04001B83 RID: 7043
		[Token(Token = "0x4001B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private char[] m_charBuffer;

		// Token: 0x04001B84 RID: 7044
		[Token(Token = "0x4001B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_maxCharsSize;

		// Token: 0x04001B85 RID: 7045
		[Token(Token = "0x4001B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_2BytesPerChar;

		// Token: 0x04001B86 RID: 7046
		[Token(Token = "0x4001B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool m_isMemoryStream;

		// Token: 0x04001B87 RID: 7047
		[Token(Token = "0x4001B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		private bool m_leaveOpen;
	}
}
