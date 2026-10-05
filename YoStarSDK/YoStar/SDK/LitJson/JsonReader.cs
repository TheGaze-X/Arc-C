using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002F6 RID: 758
	[Token(Token = "0x20002F6")]
	public class JsonReader
	{
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00004A6C File Offset: 0x00002C6C
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000209")]
		public bool AllowComments
		{
			[Token(Token = "0x600118D")]
			[Address(RVA = "0x5398A30", Offset = "0x5397630", VA = "0x185398A30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600118E")]
			[Address(RVA = "0x5398A70", Offset = "0x5397670", VA = "0x185398A70")]
			set
			{
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x00004A84 File Offset: 0x00002C84
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700020A")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x600118F")]
			[Address(RVA = "0x5398A50", Offset = "0x5397650", VA = "0x185398A50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001190")]
			[Address(RVA = "0x5398A90", Offset = "0x5397690", VA = "0x185398A90")]
			set
			{
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x00004A9C File Offset: 0x00002C9C
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700020B")]
		public bool SkipNonMembers
		{
			[Token(Token = "0x6001191")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001192")]
			[Address(RVA = "0x31208C0", Offset = "0x311F4C0", VA = "0x1831208C0")]
			set
			{
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Token(Token = "0x1700020C")]
		public bool EndOfInput
		{
			[Token(Token = "0x6001193")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00004ACC File Offset: 0x00002CCC
		[Token(Token = "0x1700020D")]
		public bool EndOfJson
		{
			[Token(Token = "0x6001194")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00004AE4 File Offset: 0x00002CE4
		[Token(Token = "0x1700020E")]
		public JsonToken Token
		{
			[Token(Token = "0x6001195")]
			[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
			get
			{
				return JsonToken.None;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020F")]
		public object Value
		{
			[Token(Token = "0x6001196")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001198")]
		[Address(RVA = "0x5CDF590", Offset = "0x5CDE190", VA = "0x185CDF590")]
		public JsonReader(string json_text)
		{
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001199")]
		[Address(RVA = "0x5CDF580", Offset = "0x5CDE180", VA = "0x185CDF580")]
		public JsonReader(TextReader reader)
		{
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600119A")]
		[Address(RVA = "0x5CDF3C0", Offset = "0x5CDDFC0", VA = "0x185CDF3C0")]
		private JsonReader(TextReader reader, bool owned)
		{
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119B")]
		[Address(RVA = "0x5CDDB30", Offset = "0x5CDC730", VA = "0x185CDDB30")]
		private static IDictionary<int, IDictionary<int, int[]>> PopulateParseTable()
		{
			return null;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600119C")]
		[Address(RVA = "0x5CDF180", Offset = "0x5CDDD80", VA = "0x185CDF180")]
		private static void TableAddCol(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken row, int col, params int[] symbols)
		{
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600119D")]
		[Address(RVA = "0x5CDF2B0", Offset = "0x5CDDEB0", VA = "0x185CDF2B0")]
		private static void TableAddRow(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken rule)
		{
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600119E")]
		[Address(RVA = "0x5CDE810", Offset = "0x5CDD410", VA = "0x185CDE810")]
		private void ProcessNumber(string number)
		{
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600119F")]
		[Address(RVA = "0x5CDEAF0", Offset = "0x5CDD6F0", VA = "0x185CDEAF0")]
		private void ProcessSymbol()
		{
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00004AFC File Offset: 0x00002CFC
		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x5CDECD0", Offset = "0x5CDD8D0", VA = "0x185CDECD0")]
		private bool ReadToken()
		{
			return default(bool);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x5CDDA90", Offset = "0x5CDC690", VA = "0x185CDDA90")]
		public void Close()
		{
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00004B14 File Offset: 0x00002D14
		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x5CDED30", Offset = "0x5CDD930", VA = "0x185CDED30")]
		public bool Read()
		{
			return default(bool);
		}

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary<int, IDictionary<int, int[]>> parse_table;

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x10")]
		private Stack<int> automaton_stack;

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x18")]
		private int current_input;

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x1C")]
		private int current_symbol;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0x20")]
		private bool end_of_json;

		// Token: 0x04000E2B RID: 3627
		[Token(Token = "0x4000E2B")]
		[FieldOffset(Offset = "0x21")]
		private bool end_of_input;

		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000E2C")]
		[FieldOffset(Offset = "0x28")]
		private Lexer lexer;

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		[FieldOffset(Offset = "0x30")]
		private bool parser_in_string;

		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000E2E")]
		[FieldOffset(Offset = "0x31")]
		private bool parser_return;

		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000E2F")]
		[FieldOffset(Offset = "0x32")]
		private bool read_started;

		// Token: 0x04000E30 RID: 3632
		[Token(Token = "0x4000E30")]
		[FieldOffset(Offset = "0x38")]
		private TextReader reader;

		// Token: 0x04000E31 RID: 3633
		[Token(Token = "0x4000E31")]
		[FieldOffset(Offset = "0x40")]
		private bool reader_is_owned;

		// Token: 0x04000E32 RID: 3634
		[Token(Token = "0x4000E32")]
		[FieldOffset(Offset = "0x41")]
		private bool skip_non_members;

		// Token: 0x04000E33 RID: 3635
		[Token(Token = "0x4000E33")]
		[FieldOffset(Offset = "0x48")]
		private object token_value;

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x50")]
		private JsonToken token;
	}
}
