using System;
using System.Collections.Generic;
using System.Xml.Xsl.Runtime;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	internal sealed class XmlEventCache : XmlRawWriter
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x4F82BA0", Offset = "0x4F817A0", VA = "0x184F82BA0")]
		public XmlEventCache(string baseUri, bool hasRootNode)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x4F81740", Offset = "0x4F80340", VA = "0x184F81740")]
		public void EndEvents()
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x4F81790", Offset = "0x4F80390", VA = "0x184F81790")]
		public void EventsToWriter(XmlWriter writer)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x4F82500", Offset = "0x4F81100", VA = "0x184F82500", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x4F82880", Offset = "0x4F81480", VA = "0x184F82880", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x4F82850", Offset = "0x4F81450", VA = "0x184F82850", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x4F825B0", Offset = "0x4F811B0", VA = "0x184F825B0", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x4F823A0", Offset = "0x4F80FA0", VA = "0x184F823A0", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x4F824A0", Offset = "0x4F810A0", VA = "0x184F824A0", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4F82770", Offset = "0x4F81370", VA = "0x184F82770", Slot = "16")]
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4F82A40", Offset = "0x4F81640", VA = "0x184F82A40", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4F828B0", Offset = "0x4F814B0", VA = "0x184F828B0", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4F7B7E0", Offset = "0x4F7A3E0", VA = "0x184F7B7E0", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4F7BBD0", Offset = "0x4F7A7D0", VA = "0x184F7BBD0", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4F827F0", Offset = "0x4F813F0", VA = "0x184F827F0", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4F82660", Offset = "0x4F81260", VA = "0x184F82660", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x4F82400", Offset = "0x4F81000", VA = "0x184F82400", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x4F82930", Offset = "0x4F81530", VA = "0x184F82930", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x4F822A0", Offset = "0x4F80EA0", VA = "0x184F822A0", Slot = "25")]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x4F82320", Offset = "0x4F80F20", VA = "0x184F82320", Slot = "26")]
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4F81650", Offset = "0x4F80250", VA = "0x184F81650", Slot = "28")]
		public override void Close()
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4F81FD0", Offset = "0x4F80BD0", VA = "0x184F81FD0", Slot = "29")]
		public override void Flush()
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x4F829F0", Offset = "0x4F815F0", VA = "0x184F829F0", Slot = "31")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x4F81690", Offset = "0x4F80290", VA = "0x184F81690", Slot = "32")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x4F82AA0", Offset = "0x4F816A0", VA = "0x184F82AA0", Slot = "34")]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x4F82B40", Offset = "0x4F81740", VA = "0x184F82B40", Slot = "35")]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x4F821B0", Offset = "0x4F80DB0", VA = "0x184F821B0", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x4F82630", Offset = "0x4F81230", VA = "0x184F82630", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4F826C0", Offset = "0x4F812C0", VA = "0x184F826C0", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x4F826F0", Offset = "0x4F812F0", VA = "0x184F826F0", Slot = "40")]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x4F825F0", Offset = "0x4F811F0", VA = "0x184F825F0", Slot = "44")]
		internal override void WriteEndBase64()
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x4F813F0", Offset = "0x4F7FFF0", VA = "0x184F813F0")]
		private void AddEvent(XmlEventCache.XmlEventType eventType)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x4F81560", Offset = "0x4F80160", VA = "0x184F81560")]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1)
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x4F815D0", Offset = "0x4F801D0", VA = "0x184F815D0")]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2)
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x4F81360", Offset = "0x4F7FF60", VA = "0x184F81360")]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x4F814B0", Offset = "0x4F800B0", VA = "0x184F814B0")]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x4F81440", Offset = "0x4F80040", VA = "0x184F81440")]
		private void AddEvent(XmlEventCache.XmlEventType eventType, object o)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x4F82010", Offset = "0x4F80C10", VA = "0x184F82010")]
		private int NewEvent()
		{
			return 0;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x4F821F0", Offset = "0x4F80DF0", VA = "0x184F821F0")]
		private static byte[] ToBytes(byte[] buffer, int index, int count)
		{
			return null;
		}

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x20")]
		private List<XmlEventCache.XmlEvent[]> pages;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x28")]
		private XmlEventCache.XmlEvent[] pageCurr;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x30")]
		private int pageSize;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x34")]
		private bool hasRootNode;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x38")]
		private StringConcat singleText;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x70")]
		private string baseUri;

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		private enum XmlEventType
		{
			// Token: 0x040000B4 RID: 180
			[Token(Token = "0x40000B4")]
			Unknown,
			// Token: 0x040000B5 RID: 181
			[Token(Token = "0x40000B5")]
			DocType,
			// Token: 0x040000B6 RID: 182
			[Token(Token = "0x40000B6")]
			StartElem,
			// Token: 0x040000B7 RID: 183
			[Token(Token = "0x40000B7")]
			StartAttr,
			// Token: 0x040000B8 RID: 184
			[Token(Token = "0x40000B8")]
			EndAttr,
			// Token: 0x040000B9 RID: 185
			[Token(Token = "0x40000B9")]
			CData,
			// Token: 0x040000BA RID: 186
			[Token(Token = "0x40000BA")]
			Comment,
			// Token: 0x040000BB RID: 187
			[Token(Token = "0x40000BB")]
			PI,
			// Token: 0x040000BC RID: 188
			[Token(Token = "0x40000BC")]
			Whitespace,
			// Token: 0x040000BD RID: 189
			[Token(Token = "0x40000BD")]
			String,
			// Token: 0x040000BE RID: 190
			[Token(Token = "0x40000BE")]
			Raw,
			// Token: 0x040000BF RID: 191
			[Token(Token = "0x40000BF")]
			EntRef,
			// Token: 0x040000C0 RID: 192
			[Token(Token = "0x40000C0")]
			CharEnt,
			// Token: 0x040000C1 RID: 193
			[Token(Token = "0x40000C1")]
			SurrCharEnt,
			// Token: 0x040000C2 RID: 194
			[Token(Token = "0x40000C2")]
			Base64,
			// Token: 0x040000C3 RID: 195
			[Token(Token = "0x40000C3")]
			BinHex,
			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			XmlDecl1,
			// Token: 0x040000C5 RID: 197
			[Token(Token = "0x40000C5")]
			XmlDecl2,
			// Token: 0x040000C6 RID: 198
			[Token(Token = "0x40000C6")]
			StartContent,
			// Token: 0x040000C7 RID: 199
			[Token(Token = "0x40000C7")]
			EndElem,
			// Token: 0x040000C8 RID: 200
			[Token(Token = "0x40000C8")]
			FullEndElem,
			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x40000C9")]
			Nmsp,
			// Token: 0x040000CA RID: 202
			[Token(Token = "0x40000CA")]
			EndBase64,
			// Token: 0x040000CB RID: 203
			[Token(Token = "0x40000CB")]
			Close,
			// Token: 0x040000CC RID: 204
			[Token(Token = "0x40000CC")]
			Flush,
			// Token: 0x040000CD RID: 205
			[Token(Token = "0x40000CD")]
			Dispose
		}

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		private struct XmlEvent
		{
			// Token: 0x060001C6 RID: 454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			public void InitEvent(XmlEventCache.XmlEventType eventType)
			{
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x5159D0", Offset = "0x5145D0", VA = "0x1805159D0")]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1)
			{
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x4E45200", Offset = "0x4E43E00", VA = "0x184E45200")]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2)
			{
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x4F82C70", Offset = "0x4F81870", VA = "0x184F82C70")]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3)
			{
			}

			// Token: 0x060001CA RID: 458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x4F82C10", Offset = "0x4F81810", VA = "0x184F82C10")]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o)
			{
			}

			// Token: 0x060001CB RID: 459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x4F82BF0", Offset = "0x4F817F0", VA = "0x184F82BF0")]
			public void InitEvent(XmlEventCache.XmlEventType eventType, object o)
			{
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060001CC RID: 460 RVA: 0x00002358 File Offset: 0x00000558
			[Token(Token = "0x1700003B")]
			public XmlEventCache.XmlEventType EventType
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
				get
				{
					return XmlEventCache.XmlEventType.Unknown;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003C")]
			public string String1
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003D")]
			public string String2
			{
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003E")]
			public string String3
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003F")]
			public object Object
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x040000CE RID: 206
			[Token(Token = "0x40000CE")]
			[FieldOffset(Offset = "0x0")]
			private XmlEventCache.XmlEventType eventType;

			// Token: 0x040000CF RID: 207
			[Token(Token = "0x40000CF")]
			[FieldOffset(Offset = "0x8")]
			private string s1;

			// Token: 0x040000D0 RID: 208
			[Token(Token = "0x40000D0")]
			[FieldOffset(Offset = "0x10")]
			private string s2;

			// Token: 0x040000D1 RID: 209
			[Token(Token = "0x40000D1")]
			[FieldOffset(Offset = "0x18")]
			private string s3;

			// Token: 0x040000D2 RID: 210
			[Token(Token = "0x40000D2")]
			[FieldOffset(Offset = "0x20")]
			private object o;
		}
	}
}
