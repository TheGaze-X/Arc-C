using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Preserve]
	public class JsonTextWriter : JsonWriter
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		private Base64Encoder Base64Encoder
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x4D7C560", Offset = "0x4D7B160", VA = "0x184D7C560")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004A")]
		public IArrayPool<char> ArrayPool
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x4D7C620", Offset = "0x4D7B220", VA = "0x184D7C620")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000026E8 File Offset: 0x000008E8
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004B")]
		public int Indentation
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x4D7C600", Offset = "0x4D7B200", VA = "0x184D7C600")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x4D7C6C0", Offset = "0x4D7B2C0", VA = "0x184D7C6C0")]
			set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004C")]
		public char QuoteChar
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x4D7C610", Offset = "0x4D7B210", VA = "0x184D7C610")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x4D7C730", Offset = "0x4D7B330", VA = "0x184D7C730")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004D")]
		public char IndentChar
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x4D7C5F0", Offset = "0x4D7B1F0", VA = "0x184D7C5F0")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x4D7C6A0", Offset = "0x4D7B2A0", VA = "0x184D7C6A0")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002730 File Offset: 0x00000930
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004E")]
		public bool QuoteName
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x36D4C80", Offset = "0x36D3880", VA = "0x1836D4C80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x36D4F00", Offset = "0x36D3B00", VA = "0x1836D4F00")]
			set
			{
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x4D7C470", Offset = "0x4D7B070", VA = "0x184D7C470")]
		public JsonTextWriter(TextWriter textWriter)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x4D7A350", Offset = "0x4D78F50", VA = "0x184D7A350", Slot = "6")]
		public override void Flush()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4D7A280", Offset = "0x4D78E80", VA = "0x184D7A280", Slot = "7")]
		public override void Close()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x4D7AF40", Offset = "0x4D79B40", VA = "0x184D7AF40", Slot = "8")]
		public override void WriteStartObject()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4D7ADD0", Offset = "0x4D799D0", VA = "0x184D7ADD0", Slot = "10")]
		public override void WriteStartArray()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x4D7AE30", Offset = "0x4D79A30", VA = "0x184D7AE30", Slot = "12")]
		public override void WriteStartConstructor(string name)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x4D7A530", Offset = "0x4D79130", VA = "0x184D7A530", Slot = "18")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x4D7ABC0", Offset = "0x4D797C0", VA = "0x184D7ABC0", Slot = "14")]
		public override void WritePropertyName(string name)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4D7AC30", Offset = "0x4D79830", VA = "0x184D7AC30", Slot = "15")]
		public override void WritePropertyName(string name, bool escape)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x4D7A390", Offset = "0x4D78F90", VA = "0x184D7A390", Slot = "5")]
		internal override void OnStringEscapeHandlingChanged()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x4D7A3A0", Offset = "0x4D78FA0", VA = "0x184D7A3A0")]
		private void UpdateCharEscapeFlags()
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4D7A790", Offset = "0x4D79390", VA = "0x184D7A790", Slot = "19")]
		protected override void WriteIndent()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x4D7B050", Offset = "0x4D79C50", VA = "0x184D7B050", Slot = "20")]
		protected override void WriteValueDelimiter()
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x4D7A740", Offset = "0x4D79340", VA = "0x184D7A740", Slot = "21")]
		protected override void WriteIndentSpace()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x4D7B0A0", Offset = "0x4D79CA0", VA = "0x184D7B0A0")]
		private void WriteValueInternal(string value, JsonToken token)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x4D7B220", Offset = "0x4D79E20", VA = "0x184D7B220", Slot = "63")]
		public override void WriteValue(object value)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x4D7AB10", Offset = "0x4D79710", VA = "0x184D7AB10", Slot = "22")]
		public override void WriteNull()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x4D7AFA0", Offset = "0x4D79BA0", VA = "0x184D7AFA0", Slot = "23")]
		public override void WriteUndefined()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x4D7AD70", Offset = "0x4D79970", VA = "0x184D7AD70", Slot = "24")]
		public override void WriteRaw(string json)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x4D7BAF0", Offset = "0x4D7A6F0", VA = "0x184D7BAF0", Slot = "26")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x4D7A650", Offset = "0x4D79250", VA = "0x184D7A650")]
		private void WriteEscapedString(string value, bool quote)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x4D7B230", Offset = "0x4D79E30", VA = "0x184D7B230", Slot = "27")]
		public override void WriteValue(int value)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x4D7B550", Offset = "0x4D7A150", VA = "0x184D7B550", Slot = "28")]
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4D7C1E0", Offset = "0x4D7ADE0", VA = "0x184D7C1E0", Slot = "29")]
		public override void WriteValue(long value)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4D7C1A0", Offset = "0x4D7ADA0", VA = "0x184D7C1A0", Slot = "30")]
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4D7C220", Offset = "0x4D7AE20", VA = "0x184D7C220", Slot = "31")]
		public override void WriteValue(float value)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x4D7C2F0", Offset = "0x4D7AEF0", VA = "0x184D7C2F0", Slot = "48")]
		public override void WriteValue(float? value)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x4D7C0D0", Offset = "0x4D7ACD0", VA = "0x184D7C0D0", Slot = "32")]
		public override void WriteValue(double value)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x4D7B270", Offset = "0x4D79E70", VA = "0x184D7B270", Slot = "49")]
		public override void WriteValue(double? value)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x4D7B8A0", Offset = "0x4D7A4A0", VA = "0x184D7B8A0", Slot = "33")]
		public override void WriteValue(bool value)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x4D7B390", Offset = "0x4D79F90", VA = "0x184D7B390", Slot = "34")]
		public override void WriteValue(short value)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x4D7B510", Offset = "0x4D7A110", VA = "0x184D7B510", Slot = "35")]
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x4D7C030", Offset = "0x4D7AC30", VA = "0x184D7C030", Slot = "36")]
		public override void WriteValue(char value)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4D7BFF0", Offset = "0x4D7ABF0", VA = "0x184D7BFF0", Slot = "37")]
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4D7BAB0", Offset = "0x4D7A6B0", VA = "0x184D7BAB0", Slot = "38")]
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4D7B940", Offset = "0x4D7A540", VA = "0x184D7B940", Slot = "39")]
		public override void WriteValue(decimal value)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4D7BBC0", Offset = "0x4D7A7C0", VA = "0x184D7BBC0", Slot = "40")]
		public override void WriteValue(DateTime value)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x4D7B0F0", Offset = "0x4D79CF0", VA = "0x184D7B0F0", Slot = "61")]
		public override void WriteValue(byte[] value)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x4D7B590", Offset = "0x4D7A190", VA = "0x184D7B590", Slot = "41")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x4D7B3D0", Offset = "0x4D79FD0", VA = "0x184D7B3D0", Slot = "42")]
		public override void WriteValue(Guid value)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x4D7BEC0", Offset = "0x4D7AAC0", VA = "0x184D7BEC0", Slot = "43")]
		public override void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x4D7B9F0", Offset = "0x4D7A5F0", VA = "0x184D7B9F0", Slot = "62")]
		public override void WriteValue(Uri value)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4D7A420", Offset = "0x4D79020", VA = "0x184D7A420", Slot = "64")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x4D7C410", Offset = "0x4D7B010", VA = "0x184D7C410", Slot = "65")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x4D7A310", Offset = "0x4D78F10", VA = "0x184D7A310")]
		private void EnsureWriteBuffer()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x4D7AA50", Offset = "0x4D79650", VA = "0x184D7AA50")]
		private void WriteIntegerValue(long value)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4D7A8F0", Offset = "0x4D794F0", VA = "0x184D7A8F0")]
		private void WriteIntegerValue(ulong uvalue)
		{
		}

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x60")]
		private readonly TextWriter _writer;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x68")]
		private Base64Encoder _base64Encoder;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x70")]
		private char _indentChar;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x74")]
		private int _indentation;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x78")]
		private char _quoteChar;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x7A")]
		private bool _quoteName;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x80")]
		private bool[] _charEscapeFlags;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x88")]
		private char[] _writeBuffer;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x90")]
		private IArrayPool<char> _arrayPool;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x98")]
		private char[] _indentChars;
	}
}
