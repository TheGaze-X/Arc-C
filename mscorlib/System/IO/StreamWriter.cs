using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000659 RID: 1625
	[Token(Token = "0x2000659")]
	[System.Serializable]
	public class StreamWriter : TextWriter
	{
		// Token: 0x060030C7 RID: 12487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C7")]
		[Address(RVA = "0x4C84690", Offset = "0x4C83290", VA = "0x184C84690")]
		private void CheckAsyncTaskInProgress()
		{
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C8")]
		[Address(RVA = "0x4C84CC0", Offset = "0x4C838C0", VA = "0x184C84CC0")]
		private static void ThrowAsyncIOInProgress()
		{
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060030C9 RID: 12489 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007D3")]
		private static System.Text.Encoding UTF8NoBOM
		{
			[Token(Token = "0x60030C9")]
			[Address(RVA = "0x4C85F40", Offset = "0x4C84B40", VA = "0x184C85F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030CA")]
		[Address(RVA = "0x4C85E50", Offset = "0x4C84A50", VA = "0x184C85E50")]
		internal StreamWriter()
		{
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030CB")]
		[Address(RVA = "0x4C85C10", Offset = "0x4C84810", VA = "0x184C85C10")]
		public StreamWriter(Stream stream)
		{
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030CC")]
		[Address(RVA = "0x4C85870", Offset = "0x4C84470", VA = "0x184C85870")]
		public StreamWriter(Stream stream, System.Text.Encoding encoding)
		{
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030CD")]
		[Address(RVA = "0x4C85F10", Offset = "0x4C84B10", VA = "0x184C85F10")]
		public StreamWriter(Stream stream, System.Text.Encoding encoding, int bufferSize)
		{
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030CE")]
		[Address(RVA = "0x4C85610", Offset = "0x4C84210", VA = "0x184C85610")]
		public StreamWriter(Stream stream, System.Text.Encoding encoding, int bufferSize, bool leaveOpen)
		{
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030CF")]
		[Address(RVA = "0x4C85D80", Offset = "0x4C84980", VA = "0x184C85D80")]
		public StreamWriter(string path)
		{
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D0")]
		[Address(RVA = "0x4C85CC0", Offset = "0x4C848C0", VA = "0x184C85CC0")]
		public StreamWriter(string path, bool append)
		{
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D1")]
		[Address(RVA = "0x4C85E30", Offset = "0x4C84A30", VA = "0x184C85E30")]
		public StreamWriter(string path, bool append, System.Text.Encoding encoding)
		{
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D2")]
		[Address(RVA = "0x4C858A0", Offset = "0x4C844A0", VA = "0x184C858A0")]
		public StreamWriter(string path, bool append, System.Text.Encoding encoding, int bufferSize)
		{
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D3")]
		[Address(RVA = "0x4C84AF0", Offset = "0x4C836F0", VA = "0x184C84AF0")]
		private void Init(Stream streamArg, System.Text.Encoding encodingArg, int bufferSize, bool shouldLeaveOpen)
		{
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D4")]
		[Address(RVA = "0x4C846F0", Offset = "0x4C832F0", VA = "0x184C846F0", Slot = "8")]
		public override void Close()
		{
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D5")]
		[Address(RVA = "0x4C84760", Offset = "0x4C83360", VA = "0x184C84760", Slot = "9")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D6")]
		[Address(RVA = "0x4C84830", Offset = "0x4C83430", VA = "0x184C84830", Slot = "10")]
		public override void Flush()
		{
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D7")]
		[Address(RVA = "0x4C848A0", Offset = "0x4C834A0", VA = "0x184C848A0")]
		private void Flush(bool flushStream, bool flushEncoder)
		{
		}

		// Token: 0x170007D4 RID: 2004
		// (set) Token: 0x060030D8 RID: 12504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D4")]
		public virtual bool AutoFlush
		{
			[Token(Token = "0x60030D8")]
			[Address(RVA = "0x4C85F80", Offset = "0x4C84B80", VA = "0x184C85F80", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x0001A6D0 File Offset: 0x000188D0
		[Token(Token = "0x170007D5")]
		internal bool LeaveOpen
		{
			[Token(Token = "0x60030D9")]
			[Address(RVA = "0x4C85F30", Offset = "0x4C84B30", VA = "0x184C85F30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060030DA RID: 12506 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007D6")]
		public override System.Text.Encoding Encoding
		{
			[Token(Token = "0x60030DA")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030DB")]
		[Address(RVA = "0x4C85140", Offset = "0x4C83D40", VA = "0x184C85140", Slot = "13")]
		public override void Write(char value)
		{
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030DC")]
		[Address(RVA = "0x4C85200", Offset = "0x4C83E00", VA = "0x184C85200", Slot = "14")]
		[MethodImpl(8)]
		public override void Write(char[] buffer)
		{
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030DD")]
		[Address(RVA = "0x4C85270", Offset = "0x4C83E70", VA = "0x184C85270", Slot = "15")]
		[MethodImpl(8)]
		public override void Write(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030DE")]
		[Address(RVA = "0x4C84DF0", Offset = "0x4C839F0", VA = "0x184C84DF0")]
		[MethodImpl(256)]
		private void WriteSpan(System.ReadOnlySpan<char> buffer, bool appendNewLine)
		{
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x4C850C0", Offset = "0x4C83CC0", VA = "0x184C850C0", Slot = "17")]
		[MethodImpl(8)]
		public override void Write(string value)
		{
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E0")]
		[Address(RVA = "0x4C84D20", Offset = "0x4C83920", VA = "0x184C84D20", Slot = "21")]
		[MethodImpl(8)]
		public override void WriteLine(string value)
		{
		}

		// Token: 0x04001AF9 RID: 6905
		[Token(Token = "0x4001AF9")]
		internal const int DefaultBufferSize = 1024;

		// Token: 0x04001AFA RID: 6906
		[Token(Token = "0x4001AFA")]
		private const int DefaultFileStreamBufferSize = 4096;

		// Token: 0x04001AFB RID: 6907
		[Token(Token = "0x4001AFB")]
		private const int MinBufferSize = 128;

		// Token: 0x04001AFC RID: 6908
		[Token(Token = "0x4001AFC")]
		private const int DontCopyOnWriteLineThreshold = 512;

		// Token: 0x04001AFD RID: 6909
		[Token(Token = "0x4001AFD")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly StreamWriter Null;

		// Token: 0x04001AFE RID: 6910
		[Token(Token = "0x4001AFE")]
		[FieldOffset(Offset = "0x30")]
		private Stream _stream;

		// Token: 0x04001AFF RID: 6911
		[Token(Token = "0x4001AFF")]
		[FieldOffset(Offset = "0x38")]
		private System.Text.Encoding _encoding;

		// Token: 0x04001B00 RID: 6912
		[Token(Token = "0x4001B00")]
		[FieldOffset(Offset = "0x40")]
		private System.Text.Encoder _encoder;

		// Token: 0x04001B01 RID: 6913
		[Token(Token = "0x4001B01")]
		[FieldOffset(Offset = "0x48")]
		private byte[] _byteBuffer;

		// Token: 0x04001B02 RID: 6914
		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x50")]
		private char[] _charBuffer;

		// Token: 0x04001B03 RID: 6915
		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0x58")]
		private int _charPos;

		// Token: 0x04001B04 RID: 6916
		[Token(Token = "0x4001B04")]
		[FieldOffset(Offset = "0x5C")]
		private int _charLen;

		// Token: 0x04001B05 RID: 6917
		[Token(Token = "0x4001B05")]
		[FieldOffset(Offset = "0x60")]
		private bool _autoFlush;

		// Token: 0x04001B06 RID: 6918
		[Token(Token = "0x4001B06")]
		[FieldOffset(Offset = "0x61")]
		private bool _haveWrittenPreamble;

		// Token: 0x04001B07 RID: 6919
		[Token(Token = "0x4001B07")]
		[FieldOffset(Offset = "0x62")]
		private bool _closable;

		// Token: 0x04001B08 RID: 6920
		[Token(Token = "0x4001B08")]
		[FieldOffset(Offset = "0x68")]
		private System.Threading.Tasks.Task _asyncWriteTask;
	}
}
