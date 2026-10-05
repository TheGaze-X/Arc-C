using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public class JsonReader
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000026E8 File Offset: 0x000008E8
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		public bool AllowComments
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x5398A30", Offset = "0x5397630", VA = "0x185398A30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x5398A70", Offset = "0x5397670", VA = "0x185398A70")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x5398A50", Offset = "0x5397650", VA = "0x185398A50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x5398A90", Offset = "0x5397690", VA = "0x185398A90")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public bool SkipNonMembers
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x31208C0", Offset = "0x311F4C0", VA = "0x1831208C0")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x17000052")]
		public bool EndOfInput
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x17000053")]
		public bool EndOfJson
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x17000054")]
		public JsonToken Token
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
			get
			{
				return JsonToken.None;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000055")]
		public object Value
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x55BE640", Offset = "0x55BD240", VA = "0x1855BE640")]
		public JsonReader(string json_text)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x55BE3A0", Offset = "0x55BCFA0", VA = "0x1855BE3A0")]
		public JsonReader(TextReader reader)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x55BE3B0", Offset = "0x55BCFB0", VA = "0x1855BE3B0")]
		private JsonReader(TextReader reader, bool owned)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x55BCB10", Offset = "0x55BB710", VA = "0x1855BCB10")]
		private static IDictionary<int, IDictionary<int, int[]>> PopulateParseTable()
		{
			return null;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x55BE160", Offset = "0x55BCD60", VA = "0x1855BE160")]
		private static void TableAddCol(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken row, int col, params int[] symbols)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x55BE290", Offset = "0x55BCE90", VA = "0x1855BE290")]
		private static void TableAddRow(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken rule)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x55BD7F0", Offset = "0x55BC3F0", VA = "0x1855BD7F0")]
		private void ProcessNumber(string number)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x55BDAD0", Offset = "0x55BC6D0", VA = "0x1855BDAD0")]
		private void ProcessSymbol()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x55BDCB0", Offset = "0x55BC8B0", VA = "0x1855BDCB0")]
		private bool ReadToken()
		{
			return default(bool);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x55BCA70", Offset = "0x55BB670", VA = "0x1855BCA70")]
		public void Close()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x55BDD10", Offset = "0x55BC910", VA = "0x1855BDD10")]
		public bool Read()
		{
			return default(bool);
		}

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary<int, IDictionary<int, int[]>> parse_table;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x10")]
		private Stack<int> automaton_stack;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x18")]
		private int current_input;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x1C")]
		private int current_symbol;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x20")]
		private bool end_of_json;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x21")]
		private bool end_of_input;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x28")]
		private Lexer lexer;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x30")]
		private bool parser_in_string;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x31")]
		private bool parser_return;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x32")]
		private bool read_started;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x38")]
		private TextReader reader;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x40")]
		private bool reader_is_owned;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x41")]
		private bool skip_non_members;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x48")]
		private object token_value;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x50")]
		private JsonToken token;
	}
}
