using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000654 RID: 1620
	[Token(Token = "0x2000654")]
	[System.Serializable]
	public class StreamReader : TextReader
	{
		// Token: 0x06003091 RID: 12433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003091")]
		[Address(RVA = "0x4C814B0", Offset = "0x4C800B0", VA = "0x184C814B0")]
		private void CheckAsyncTaskInProgress()
		{
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003092")]
		[Address(RVA = "0x4C83B80", Offset = "0x4C82780", VA = "0x184C83B80")]
		private static void ThrowAsyncIOInProgress()
		{
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003093")]
		[Address(RVA = "0x4C83E60", Offset = "0x4C82A60", VA = "0x184C83E60")]
		internal StreamReader()
		{
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003094")]
		[Address(RVA = "0x4C844E0", Offset = "0x4C830E0", VA = "0x184C844E0")]
		public StreamReader(Stream stream)
		{
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003095")]
		[Address(RVA = "0x4C83F20", Offset = "0x4C82B20", VA = "0x184C83F20")]
		public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
		{
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003096")]
		[Address(RVA = "0x4C83E30", Offset = "0x4C82A30", VA = "0x184C83E30")]
		public StreamReader(Stream stream, System.Text.Encoding encoding)
		{
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003097")]
		[Address(RVA = "0x4C84550", Offset = "0x4C83150", VA = "0x184C84550")]
		public StreamReader(Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks)
		{
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003098")]
		[Address(RVA = "0x4C83F80", Offset = "0x4C82B80", VA = "0x184C83F80")]
		public StreamReader(Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003099")]
		[Address(RVA = "0x4C83D80", Offset = "0x4C82980", VA = "0x184C83D80")]
		public StreamReader(string path)
		{
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309A")]
		[Address(RVA = "0x4C83DD0", Offset = "0x4C829D0", VA = "0x184C83DD0")]
		public StreamReader(string path, bool detectEncodingFromByteOrderMarks)
		{
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309B")]
		[Address(RVA = "0x4C84530", Offset = "0x4C83130", VA = "0x184C84530")]
		public StreamReader(string path, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks)
		{
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309C")]
		[Address(RVA = "0x4C841F0", Offset = "0x4C82DF0", VA = "0x184C841F0")]
		public StreamReader(string path, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
		{
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309D")]
		[Address(RVA = "0x4C81940", Offset = "0x4C80540", VA = "0x184C81940")]
		private void Init(Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309E")]
		[Address(RVA = "0x4C81920", Offset = "0x4C80520", VA = "0x184C81920")]
		internal void Init(Stream stream)
		{
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309F")]
		[Address(RVA = "0x4B6A320", Offset = "0x4B68F20", VA = "0x184B6A320", Slot = "7")]
		public override void Close()
		{
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A0")]
		[Address(RVA = "0x4C81880", Offset = "0x4C80480", VA = "0x184C81880", Slot = "8")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007CD")]
		public virtual System.Text.Encoding CurrentEncoding
		{
			[Token(Token = "0x60030A1")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007CE")]
		public virtual Stream BaseStream
		{
			[Token(Token = "0x60030A2")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x0001A550 File Offset: 0x00018750
		[Token(Token = "0x170007CF")]
		internal bool LeaveOpen
		{
			[Token(Token = "0x60030A3")]
			[Address(RVA = "0x4C84680", Offset = "0x4C83280", VA = "0x184C84680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x0001A568 File Offset: 0x00018768
		[Token(Token = "0x170007D0")]
		public bool EndOfStream
		{
			[Token(Token = "0x60030A4")]
			[Address(RVA = "0x4C84580", Offset = "0x4C83180", VA = "0x184C84580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x0001A580 File Offset: 0x00018780
		[Token(Token = "0x60030A5")]
		[Address(RVA = "0x4C81C20", Offset = "0x4C80820", VA = "0x184C81C20", Slot = "9")]
		public override int Peek()
		{
			return 0;
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x0001A598 File Offset: 0x00018798
		[Token(Token = "0x60030A6")]
		[Address(RVA = "0x4C83850", Offset = "0x4C82450", VA = "0x184C83850", Slot = "10")]
		public override int Read()
		{
			return 0;
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x0001A5B0 File Offset: 0x000187B0
		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x4C83980", Offset = "0x4C82580", VA = "0x184C83980", Slot = "11")]
		public override int Read(char[] buffer, int index, int count)
		{
			return 0;
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x0001A5C8 File Offset: 0x000187C8
		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x4C83790", Offset = "0x4C82390", VA = "0x184C83790", Slot = "12")]
		public override int Read(System.Span<char> buffer)
		{
			return 0;
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x0001A5E0 File Offset: 0x000187E0
		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x4C82EF0", Offset = "0x4C81AF0", VA = "0x184C82EF0")]
		private int ReadSpan(System.Span<char> buffer)
		{
			return 0;
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x4C835E0", Offset = "0x4C821E0", VA = "0x184C835E0", Slot = "13")]
		public override string ReadToEnd()
		{
			return null;
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x4C81510", Offset = "0x4C80110", VA = "0x184C81510")]
		private void CompressBuffer(int n)
		{
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AC")]
		[Address(RVA = "0x4C81560", Offset = "0x4C80160", VA = "0x184C81560")]
		private void DetectEncoding()
		{
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x0001A5F8 File Offset: 0x000187F8
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x4C81AE0", Offset = "0x4C806E0", VA = "0x184C81AE0")]
		private bool IsPreamble()
		{
			return default(bool);
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x0001A610 File Offset: 0x00018810
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x4C81FD0", Offset = "0x4C80BD0", VA = "0x184C81FD0", Slot = "19")]
		internal virtual int ReadBuffer()
		{
			return 0;
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x0001A628 File Offset: 0x00018828
		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x4C824E0", Offset = "0x4C810E0", VA = "0x184C824E0")]
		private int ReadBuffer(System.Span<char> userBuffer, out bool readToUserBuffer)
		{
			return 0;
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x4C82C10", Offset = "0x4C81810", VA = "0x184C82C10", Slot = "14")]
		public override string ReadLine()
		{
			return null;
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60030B1")]
		[Address(RVA = "0x4C832B0", Offset = "0x4C81EB0", VA = "0x184C832B0", Slot = "15")]
		public override System.Threading.Tasks.Task<string> ReadToEndAsync()
		{
			return null;
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x4C831A0", Offset = "0x4C81DA0", VA = "0x184C831A0")]
		private System.Threading.Tasks.Task<string> ReadToEndAsyncInternal()
		{
			return null;
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x0001A640 File Offset: 0x00018840
		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x4C81D30", Offset = "0x4C80930", VA = "0x184C81D30", Slot = "16")]
		internal override System.Threading.Tasks.ValueTask<int> ReadAsyncInternal(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken)
		{
			return default(System.Threading.Tasks.ValueTask<int>);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60030B4")]
		[Address(RVA = "0x4C81EC0", Offset = "0x4C80AC0", VA = "0x184C81EC0")]
		private System.Threading.Tasks.Task<int> ReadBufferAsync()
		{
			return null;
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0001A658 File Offset: 0x00018858
		[Token(Token = "0x60030B5")]
		[Address(RVA = "0x4C81550", Offset = "0x4C80150", VA = "0x184C81550")]
		internal bool DataAvailable()
		{
			return default(bool);
		}

		// Token: 0x04001AD1 RID: 6865
		[Token(Token = "0x4001AD1")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly StreamReader Null;

		// Token: 0x04001AD2 RID: 6866
		[Token(Token = "0x4001AD2")]
		[FieldOffset(Offset = "0x18")]
		private Stream _stream;

		// Token: 0x04001AD3 RID: 6867
		[Token(Token = "0x4001AD3")]
		[FieldOffset(Offset = "0x20")]
		private System.Text.Encoding _encoding;

		// Token: 0x04001AD4 RID: 6868
		[Token(Token = "0x4001AD4")]
		[FieldOffset(Offset = "0x28")]
		private System.Text.Decoder _decoder;

		// Token: 0x04001AD5 RID: 6869
		[Token(Token = "0x4001AD5")]
		[FieldOffset(Offset = "0x30")]
		private byte[] _byteBuffer;

		// Token: 0x04001AD6 RID: 6870
		[Token(Token = "0x4001AD6")]
		[FieldOffset(Offset = "0x38")]
		private char[] _charBuffer;

		// Token: 0x04001AD7 RID: 6871
		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0x40")]
		private int _charPos;

		// Token: 0x04001AD8 RID: 6872
		[Token(Token = "0x4001AD8")]
		[FieldOffset(Offset = "0x44")]
		private int _charLen;

		// Token: 0x04001AD9 RID: 6873
		[Token(Token = "0x4001AD9")]
		[FieldOffset(Offset = "0x48")]
		private int _byteLen;

		// Token: 0x04001ADA RID: 6874
		[Token(Token = "0x4001ADA")]
		[FieldOffset(Offset = "0x4C")]
		private int _bytePos;

		// Token: 0x04001ADB RID: 6875
		[Token(Token = "0x4001ADB")]
		[FieldOffset(Offset = "0x50")]
		private int _maxCharsPerBuffer;

		// Token: 0x04001ADC RID: 6876
		[Token(Token = "0x4001ADC")]
		[FieldOffset(Offset = "0x54")]
		private bool _detectEncoding;

		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x55")]
		private bool _checkPreamble;

		// Token: 0x04001ADE RID: 6878
		[Token(Token = "0x4001ADE")]
		[FieldOffset(Offset = "0x56")]
		private bool _isBlocked;

		// Token: 0x04001ADF RID: 6879
		[Token(Token = "0x4001ADF")]
		[FieldOffset(Offset = "0x57")]
		private bool _closable;

		// Token: 0x04001AE0 RID: 6880
		[Token(Token = "0x4001AE0")]
		[FieldOffset(Offset = "0x58")]
		private System.Threading.Tasks.Task _asyncReadTask;

		// Token: 0x02000655 RID: 1621
		[Token(Token = "0x2000655")]
		private class NullStreamReader : StreamReader
		{
			// Token: 0x060030B7 RID: 12471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030B7")]
			[Address(RVA = "0x4C7F260", Offset = "0x4C7DE60", VA = "0x184C7F260")]
			internal NullStreamReader()
			{
			}

			// Token: 0x170007D1 RID: 2001
			// (get) Token: 0x060030B8 RID: 12472 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007D1")]
			public override Stream BaseStream
			{
				[Token(Token = "0x60030B8")]
				[Address(RVA = "0x4C7F390", Offset = "0x4C7DF90", VA = "0x184C7F390", Slot = "18")]
				get
				{
					return null;
				}
			}

			// Token: 0x170007D2 RID: 2002
			// (get) Token: 0x060030B9 RID: 12473 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007D2")]
			public override System.Text.Encoding CurrentEncoding
			{
				[Token(Token = "0x60030B9")]
				[Address(RVA = "0x4C7F3E0", Offset = "0x4C7DFE0", VA = "0x184C7F3E0", Slot = "17")]
				get
				{
					return null;
				}
			}

			// Token: 0x060030BA RID: 12474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030BA")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x060030BB RID: 12475 RVA: 0x0001A670 File Offset: 0x00018870
			[Token(Token = "0x60030BB")]
			[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "9")]
			public override int Peek()
			{
				return 0;
			}

			// Token: 0x060030BC RID: 12476 RVA: 0x0001A688 File Offset: 0x00018888
			[Token(Token = "0x60030BC")]
			[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "10")]
			public override int Read()
			{
				return 0;
			}

			// Token: 0x060030BD RID: 12477 RVA: 0x0001A6A0 File Offset: 0x000188A0
			[Token(Token = "0x60030BD")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "11")]
			public override int Read(char[] buffer, int index, int count)
			{
				return 0;
			}

			// Token: 0x060030BE RID: 12478 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60030BE")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
			public override string ReadLine()
			{
				return null;
			}

			// Token: 0x060030BF RID: 12479 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60030BF")]
			[Address(RVA = "0x4C7F220", Offset = "0x4C7DE20", VA = "0x184C7F220", Slot = "13")]
			public override string ReadToEnd()
			{
				return null;
			}

			// Token: 0x060030C0 RID: 12480 RVA: 0x0001A6B8 File Offset: 0x000188B8
			[Token(Token = "0x60030C0")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "19")]
			internal override int ReadBuffer()
			{
				return 0;
			}
		}
	}
}
