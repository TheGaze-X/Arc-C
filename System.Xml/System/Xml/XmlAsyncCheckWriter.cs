using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	internal class XmlAsyncCheckWriter : XmlWriter
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x4F7AFD0", Offset = "0x4F79BD0", VA = "0x184F7AFD0")]
		public XmlAsyncCheckWriter(XmlWriter writer)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x4F7A4B0", Offset = "0x4F790B0", VA = "0x184F7A4B0")]
		private void CheckAsync()
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x4F7AD70", Offset = "0x4F79970", VA = "0x184F7AD70", Slot = "5")]
		public override void WriteStartDocument()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x4F7AD10", Offset = "0x4F79910", VA = "0x184F7AD10", Slot = "6")]
		public override void WriteStartDocument(bool standalone)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x4F7A9F0", Offset = "0x4F795F0", VA = "0x184F7A9F0", Slot = "7")]
		public override void WriteEndDocument()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x4F7A920", Offset = "0x4F79520", VA = "0x184F7A920", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x4F7ADC0", Offset = "0x4F799C0", VA = "0x184F7ADC0", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x4F7AA40", Offset = "0x4F79640", VA = "0x184F7AA40", Slot = "10")]
		public override void WriteEndElement()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4F7AAF0", Offset = "0x4F796F0", VA = "0x184F7AAF0", Slot = "11")]
		public override void WriteFullEndElement()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x4F7AC90", Offset = "0x4F79890", VA = "0x184F7AC90", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4F7A9A0", Offset = "0x4F795A0", VA = "0x184F7A9A0", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x4F7A780", Offset = "0x4F79380", VA = "0x184F7A780", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x4F7A8C0", Offset = "0x4F794C0", VA = "0x184F7A8C0", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x4F7AB40", Offset = "0x4F79740", VA = "0x184F7AB40", Slot = "16")]
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4F7AA90", Offset = "0x4F79690", VA = "0x184F7AA90", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x4F7A7E0", Offset = "0x4F793E0", VA = "0x184F7A7E0", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x4F7AF70", Offset = "0x4F79B70", VA = "0x184F7AF70", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4F7AE40", Offset = "0x4F79A40", VA = "0x184F7AE40", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x4F7AEA0", Offset = "0x4F79AA0", VA = "0x184F7AEA0", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x4F7A840", Offset = "0x4F79440", VA = "0x184F7A840", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x4F7ABB0", Offset = "0x4F797B0", VA = "0x184F7ABB0", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x4F7AC30", Offset = "0x4F79830", VA = "0x184F7AC30", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x4F7A680", Offset = "0x4F79280", VA = "0x184F7A680", Slot = "25")]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x4F7A700", Offset = "0x4F79300", VA = "0x184F7A700", Slot = "26")]
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x17000037")]
		public override WriteState WriteState
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x4F7B060", Offset = "0x4F79C60", VA = "0x184F7B060", Slot = "27")]
			get
			{
				return WriteState.Start;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x4F7A550", Offset = "0x4F79150", VA = "0x184F7A550", Slot = "28")]
		public override void Close()
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x4F7A5D0", Offset = "0x4F791D0", VA = "0x184F7A5D0", Slot = "29")]
		public override void Flush()
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x4F7A620", Offset = "0x4F79220", VA = "0x184F7A620", Slot = "30")]
		public override string LookupPrefix(string ns)
		{
			return null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x4F7AF10", Offset = "0x4F79B10", VA = "0x184F7AF10", Slot = "31")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4F7A5A0", Offset = "0x4F791A0", VA = "0x184F7A5A0", Slot = "32")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x10")]
		private readonly XmlWriter coreWriter;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x18")]
		private Task lastTask;
	}
}
