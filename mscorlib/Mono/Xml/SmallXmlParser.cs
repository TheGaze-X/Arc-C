using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace Mono.Xml
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	internal class SmallXmlParser
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x4ABA1B0", Offset = "0x4AB8DB0", VA = "0x184ABA1B0")]
		public SmallXmlParser()
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x4AB7D90", Offset = "0x4AB6990", VA = "0x184AB7D90")]
		private System.Exception Error(string msg)
		{
			return null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x4ABA0A0", Offset = "0x4AB8CA0", VA = "0x184ABA0A0")]
		private System.Exception UnexpectedEndError()
		{
			return null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x4AB8200", Offset = "0x4AB6E00", VA = "0x184AB8200")]
		private bool IsNameChar(char c, bool start)
		{
			return default(bool);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x4AB8310", Offset = "0x4AB6F10", VA = "0x184AB8310")]
		private bool IsWhitespace(int c)
		{
			return default(bool);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x4AB9F80", Offset = "0x4AB8B80", VA = "0x184AB9F80")]
		public void SkipWhitespaces()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4AB8090", Offset = "0x4AB6C90", VA = "0x184AB8090")]
		private void HandleWhitespaces()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x4AB9F90", Offset = "0x4AB8B90", VA = "0x184AB9F90")]
		public void SkipWhitespaces(bool expected)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x4AB8610", Offset = "0x4AB7210", VA = "0x184AB8610")]
		private int Peek()
		{
			return 0;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4AB9F00", Offset = "0x4AB8B00", VA = "0x184AB9F00")]
		private int Read()
		{
			return 0;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x4AB7E90", Offset = "0x4AB6A90", VA = "0x184AB7E90")]
		public void Expect(int c)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x4AB9D70", Offset = "0x4AB8970", VA = "0x184AB9D70")]
		private string ReadUntil(char until, bool handleReferences)
		{
			return null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x4AB9910", Offset = "0x4AB8510", VA = "0x184AB9910")]
		public string ReadName()
		{
			return null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x4AB8330", Offset = "0x4AB6F30", VA = "0x184AB8330")]
		public void Parse(System.IO.TextReader input, SmallXmlParser.IContentHandler handler)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x4AB7CA0", Offset = "0x4AB68A0", VA = "0x184AB7CA0")]
		private void Cleanup()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x4AB8E30", Offset = "0x4AB7A30", VA = "0x184AB8E30")]
		public void ReadContent()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x4AB7F80", Offset = "0x4AB6B80", VA = "0x184AB7F80")]
		private void HandleBufferedContent()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x4AB8B40", Offset = "0x4AB7740", VA = "0x184AB8B40")]
		private void ReadCharacters()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x4AB9B50", Offset = "0x4AB8750", VA = "0x184AB9B50")]
		private void ReadReference()
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x4AB89D0", Offset = "0x4AB75D0", VA = "0x184AB89D0")]
		private int ReadCharacterReference()
		{
			return 0;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x4AB8660", Offset = "0x4AB7260", VA = "0x184AB8660")]
		private void ReadAttribute(SmallXmlParser.AttrListImpl a)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x4AB8850", Offset = "0x4AB7450", VA = "0x184AB8850")]
		private void ReadCDATASection()
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x4AB8CA0", Offset = "0x4AB78A0", VA = "0x184AB8CA0")]
		private void ReadComment()
		{
		}

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x10")]
		private SmallXmlParser.IContentHandler handler;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x18")]
		private System.IO.TextReader reader;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x20")]
		private System.Collections.Stack elementNames;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x28")]
		private System.Collections.Stack xmlSpaces;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x30")]
		private string xmlSpace;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x38")]
		private System.Text.StringBuilder buffer;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x40")]
		private char[] nameBuffer;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x48")]
		private bool isWhitespace;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x50")]
		private SmallXmlParser.AttrListImpl attributes;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x58")]
		private int line;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x5C")]
		private int column;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x60")]
		private bool resetColumn;

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x200004A")]
		public interface IContentHandler
		{
			// Token: 0x060000A6 RID: 166
			[Token(Token = "0x60000A6")]
			void OnStartParsing(SmallXmlParser parser);

			// Token: 0x060000A7 RID: 167
			[Token(Token = "0x60000A7")]
			void OnEndParsing(SmallXmlParser parser);

			// Token: 0x060000A8 RID: 168
			[Token(Token = "0x60000A8")]
			void OnStartElement(string name, SmallXmlParser.IAttrList attrs);

			// Token: 0x060000A9 RID: 169
			[Token(Token = "0x60000A9")]
			void OnEndElement(string name);

			// Token: 0x060000AA RID: 170
			[Token(Token = "0x60000AA")]
			void OnProcessingInstruction(string name, string text);

			// Token: 0x060000AB RID: 171
			[Token(Token = "0x60000AB")]
			void OnChars(string text);

			// Token: 0x060000AC RID: 172
			[Token(Token = "0x60000AC")]
			void OnIgnorableWhitespace(string text);
		}

		// Token: 0x0200004B RID: 75
		[Token(Token = "0x200004B")]
		public interface IAttrList
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000AD RID: 173
			[Token(Token = "0x17000010")]
			int Length { [Token(Token = "0x60000AD")] get; }

			// Token: 0x060000AE RID: 174
			[Token(Token = "0x60000AE")]
			string GetName(int i);

			// Token: 0x060000AF RID: 175
			[Token(Token = "0x60000AF")]
			string GetValue(int i);

			// Token: 0x060000B0 RID: 176
			[Token(Token = "0x60000B0")]
			string GetValue(string name);

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000B1 RID: 177
			[Token(Token = "0x17000011")]
			string[] Names { [Token(Token = "0x60000B1")] get; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000B2 RID: 178
			[Token(Token = "0x17000012")]
			string[] Values { [Token(Token = "0x60000B2")] get; }
		}

		// Token: 0x0200004C RID: 76
		[Token(Token = "0x200004C")]
		private class AttrListImpl : SmallXmlParser.IAttrList
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000B3 RID: 179 RVA: 0x000024C0 File Offset: 0x000006C0
			[Token(Token = "0x17000013")]
			public int Length
			{
				[Token(Token = "0x60000B3")]
				[Address(RVA = "0x4AA9C20", Offset = "0x4AA8820", VA = "0x184AA9C20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x4AA99D0", Offset = "0x4AA85D0", VA = "0x184AA99D0", Slot = "5")]
			public string GetName(int i)
			{
				return null;
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x4AA9A30", Offset = "0x4AA8630", VA = "0x184AA9A30", Slot = "6")]
			public string GetValue(int i)
			{
				return null;
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x4AA9A90", Offset = "0x4AA8690", VA = "0x184AA9A90", Slot = "7")]
			public string GetValue(string name)
			{
				return null;
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000014")]
			public string[] Names
			{
				[Token(Token = "0x60000B7")]
				[Address(RVA = "0x4AA9C60", Offset = "0x4AA8860", VA = "0x184AA9C60", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000015")]
			public string[] Values
			{
				[Token(Token = "0x60000B8")]
				[Address(RVA = "0x4AA9CB0", Offset = "0x4AA88B0", VA = "0x184AA9CB0", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x4AA9940", Offset = "0x4AA8540", VA = "0x184AA9940")]
			internal void Clear()
			{
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x4AA98C0", Offset = "0x4AA84C0", VA = "0x184AA98C0")]
			internal void Add(string name, string value)
			{
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x4AA9B60", Offset = "0x4AA8760", VA = "0x184AA9B60")]
			public AttrListImpl()
			{
			}

			// Token: 0x04000153 RID: 339
			[Token(Token = "0x4000153")]
			[FieldOffset(Offset = "0x10")]
			private System.Collections.Generic.List<string> attrNames;

			// Token: 0x04000154 RID: 340
			[Token(Token = "0x4000154")]
			[FieldOffset(Offset = "0x18")]
			private System.Collections.Generic.List<string> attrValues;
		}
	}
}
