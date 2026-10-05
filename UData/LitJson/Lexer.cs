using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	internal class Lexer
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public bool AllowComments
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x1700005D")]
		public bool EndOfInput
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x4EEB50", Offset = "0x4ED750", VA = "0x1804EEB50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x1700005E")]
		public int Token
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700005F")]
		public string StringValue
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x55C1B00", Offset = "0x55C0700", VA = "0x1855C1B00")]
		public Lexer(TextReader reader)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x539ADF0", Offset = "0x53999F0", VA = "0x18539ADF0")]
		private static int HexValue(int digit)
		{
			return 0;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x55C0870", Offset = "0x55BF470", VA = "0x1855C0870")]
		private static void PopulateFsmTables(out Lexer.StateHandler[] fsm_handler_table, out int[] fsm_return_table)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x55C16C0", Offset = "0x55C02C0", VA = "0x1855C16C0")]
		private static char ProcessEscChar(int esc_char)
		{
			return '\0';
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x539C360", Offset = "0x539AF60", VA = "0x18539C360")]
		private static bool State1(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x539CB40", Offset = "0x539B740", VA = "0x18539CB40")]
		private static bool State2(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x539CBD0", Offset = "0x539B7D0", VA = "0x18539CBD0")]
		private static bool State3(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x539CCF0", Offset = "0x539B8F0", VA = "0x18539CCF0")]
		private static bool State4(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x539CDD0", Offset = "0x539B9D0", VA = "0x18539CDD0")]
		private static bool State5(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x539CE40", Offset = "0x539BA40", VA = "0x18539CE40")]
		private static bool State6(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x539CF30", Offset = "0x539BB30", VA = "0x18539CF30")]
		private static bool State7(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x539CFB0", Offset = "0x539BBB0", VA = "0x18539CFB0")]
		private static bool State8(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x539D060", Offset = "0x539BC60", VA = "0x18539D060")]
		private static bool State9(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x539C050", Offset = "0x539AC50", VA = "0x18539C050")]
		private static bool State10(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x539C0A0", Offset = "0x539ACA0", VA = "0x18539C0A0")]
		private static bool State11(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x539C0F0", Offset = "0x539ACF0", VA = "0x18539C0F0")]
		private static bool State12(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x539C140", Offset = "0x539AD40", VA = "0x18539C140")]
		private static bool State13(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x539C190", Offset = "0x539AD90", VA = "0x18539C190")]
		private static bool State14(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x539C0A0", Offset = "0x539ACA0", VA = "0x18539C0A0")]
		private static bool State15(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x539C1E0", Offset = "0x539ADE0", VA = "0x18539C1E0")]
		private static bool State16(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x539C230", Offset = "0x539AE30", VA = "0x18539C230")]
		private static bool State17(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x539C280", Offset = "0x539AE80", VA = "0x18539C280")]
		private static bool State18(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x539C2D0", Offset = "0x539AED0", VA = "0x18539C2D0")]
		private static bool State19(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x539C550", Offset = "0x539B150", VA = "0x18539C550")]
		private static bool State20(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x55C1780", Offset = "0x55C0380", VA = "0x1855C1780")]
		private static bool State21(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x55C1940", Offset = "0x55C0540", VA = "0x1855C1940")]
		private static bool State22(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x539C8E0", Offset = "0x539B4E0", VA = "0x18539C8E0")]
		private static bool State23(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x539C970", Offset = "0x539B570", VA = "0x18539C970")]
		private static bool State24(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x539C9D0", Offset = "0x539B5D0", VA = "0x18539C9D0")]
		private static bool State25(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x539CA30", Offset = "0x539B630", VA = "0x18539CA30")]
		private static bool State26(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x539CA80", Offset = "0x539B680", VA = "0x18539CA80")]
		private static bool State27(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x539CAD0", Offset = "0x539B6D0", VA = "0x18539CAD0")]
		private static bool State28(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x539AD70", Offset = "0x5399970", VA = "0x18539AD70")]
		private bool GetChar()
		{
			return default(bool);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x539AE90", Offset = "0x5399A90", VA = "0x18539AE90")]
		private int NextChar()
		{
			return 0;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x55C0660", Offset = "0x55BF260", VA = "0x1855C0660")]
		public bool NextToken()
		{
			return default(bool);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x539D0B0", Offset = "0x539BCB0", VA = "0x18539D0B0")]
		private void UngetChar()
		{
		}

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] fsm_return_table;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Lexer.StateHandler[] fsm_handler_table;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x10")]
		private bool allow_comments;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x11")]
		private bool allow_single_quoted_strings;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x12")]
		private bool end_of_input;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x18")]
		private FsmContext fsm_context;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x20")]
		private int input_buffer;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x24")]
		private int input_char;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x28")]
		private TextReader reader;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x30")]
		private int state;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder string_buffer;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x40")]
		private string string_value;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x48")]
		private int token;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x4C")]
		private int unichar;

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060001C2 RID: 450
		[Token(Token = "0x200002B")]
		private delegate bool StateHandler(FsmContext ctx);
	}
}
