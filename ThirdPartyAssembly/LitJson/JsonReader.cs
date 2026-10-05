using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200048A RID: 1162
	[Token(Token = "0x200048A")]
	public class JsonReader
	{
		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x00010260 File Offset: 0x0000E460
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051B")]
		public bool AllowComments
		{
			[Token(Token = "0x6002594")]
			[Address(RVA = "0x5398A30", Offset = "0x5397630", VA = "0x185398A30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002595")]
			[Address(RVA = "0x5398A70", Offset = "0x5397670", VA = "0x185398A70")]
			set
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x00010278 File Offset: 0x0000E478
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051C")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x6002596")]
			[Address(RVA = "0x5398A50", Offset = "0x5397650", VA = "0x185398A50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002597")]
			[Address(RVA = "0x5398A90", Offset = "0x5397690", VA = "0x185398A90")]
			set
			{
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x00010290 File Offset: 0x0000E490
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051D")]
		public bool SkipNonMembers
		{
			[Token(Token = "0x6002598")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002599")]
			[Address(RVA = "0x31208C0", Offset = "0x311F4C0", VA = "0x1831208C0")]
			set
			{
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x1700051E")]
		public bool EndOfInput
		{
			[Token(Token = "0x600259A")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[Token(Token = "0x1700051F")]
		public bool EndOfJson
		{
			[Token(Token = "0x600259B")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x000102D8 File Offset: 0x0000E4D8
		[Token(Token = "0x17000520")]
		public JsonToken Token
		{
			[Token(Token = "0x600259C")]
			[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
			get
			{
				return JsonToken.None;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000521")]
		public object Value
		{
			[Token(Token = "0x600259D")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259F")]
		[Address(RVA = "0x53989B0", Offset = "0x53975B0", VA = "0x1853989B0")]
		public JsonReader(string json_text)
		{
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A0")]
		[Address(RVA = "0x53989A0", Offset = "0x53975A0", VA = "0x1853989A0")]
		public JsonReader(TextReader reader)
		{
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x5398710", Offset = "0x5397310", VA = "0x185398710")]
		private JsonReader(TextReader reader, bool owned)
		{
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A2")]
		[Address(RVA = "0x5397430", Offset = "0x5396030", VA = "0x185397430")]
		private static void PopulateParseTable()
		{
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A3")]
		[Address(RVA = "0x5398430", Offset = "0x5397030", VA = "0x185398430")]
		private static void TableAddCol(ParserToken row, int col, params int[] symbols)
		{
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x5398590", Offset = "0x5397190", VA = "0x185398590")]
		private static void TableAddRow(ParserToken rule)
		{
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x5397C30", Offset = "0x5396830", VA = "0x185397C30")]
		private void ProcessNumber(string number)
		{
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x5397DD0", Offset = "0x53969D0", VA = "0x185397DD0")]
		private void ProcessSymbol()
		{
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x5397FB0", Offset = "0x5396BB0", VA = "0x185397FB0")]
		private bool ReadToken()
		{
			return default(bool);
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A8")]
		[Address(RVA = "0x53973E0", Offset = "0x5395FE0", VA = "0x1853973E0")]
		public void Close()
		{
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00010308 File Offset: 0x0000E508
		[Token(Token = "0x60025A9")]
		[Address(RVA = "0x5398030", Offset = "0x5396C30", VA = "0x185398030")]
		public bool Read()
		{
			return default(bool);
		}

		// Token: 0x040014E9 RID: 5353
		[Token(Token = "0x40014E9")]
		[FieldOffset(Offset = "0x0")]
		private static IDictionary<int, IDictionary<int, int[]>> parse_table;

		// Token: 0x040014EA RID: 5354
		[Token(Token = "0x40014EA")]
		[FieldOffset(Offset = "0x10")]
		private Stack<int> automaton_stack;

		// Token: 0x040014EB RID: 5355
		[Token(Token = "0x40014EB")]
		[FieldOffset(Offset = "0x18")]
		private int current_input;

		// Token: 0x040014EC RID: 5356
		[Token(Token = "0x40014EC")]
		[FieldOffset(Offset = "0x1C")]
		private int current_symbol;

		// Token: 0x040014ED RID: 5357
		[Token(Token = "0x40014ED")]
		[FieldOffset(Offset = "0x20")]
		private bool end_of_json;

		// Token: 0x040014EE RID: 5358
		[Token(Token = "0x40014EE")]
		[FieldOffset(Offset = "0x21")]
		private bool end_of_input;

		// Token: 0x040014EF RID: 5359
		[Token(Token = "0x40014EF")]
		[FieldOffset(Offset = "0x28")]
		private Lexer lexer;

		// Token: 0x040014F0 RID: 5360
		[Token(Token = "0x40014F0")]
		[FieldOffset(Offset = "0x30")]
		private bool parser_in_string;

		// Token: 0x040014F1 RID: 5361
		[Token(Token = "0x40014F1")]
		[FieldOffset(Offset = "0x31")]
		private bool parser_return;

		// Token: 0x040014F2 RID: 5362
		[Token(Token = "0x40014F2")]
		[FieldOffset(Offset = "0x32")]
		private bool read_started;

		// Token: 0x040014F3 RID: 5363
		[Token(Token = "0x40014F3")]
		[FieldOffset(Offset = "0x38")]
		private TextReader reader;

		// Token: 0x040014F4 RID: 5364
		[Token(Token = "0x40014F4")]
		[FieldOffset(Offset = "0x40")]
		private bool reader_is_owned;

		// Token: 0x040014F5 RID: 5365
		[Token(Token = "0x40014F5")]
		[FieldOffset(Offset = "0x41")]
		private bool skip_non_members;

		// Token: 0x040014F6 RID: 5366
		[Token(Token = "0x40014F6")]
		[FieldOffset(Offset = "0x48")]
		private object token_value;

		// Token: 0x040014F7 RID: 5367
		[Token(Token = "0x40014F7")]
		[FieldOffset(Offset = "0x50")]
		private JsonToken token;
	}
}
