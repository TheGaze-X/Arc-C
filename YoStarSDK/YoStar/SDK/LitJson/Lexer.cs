using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002FB RID: 763
	[Token(Token = "0x20002FB")]
	internal class Lexer
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x00004B8C File Offset: 0x00002D8C
		// (set) Token: 0x060011CA RID: 4554 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000215")]
		public bool AllowComments
		{
			[Token(Token = "0x60011C9")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011CA")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x00004BA4 File Offset: 0x00002DA4
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000216")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x60011CB")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011CC")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			set
			{
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x17000217")]
		public bool EndOfInput
		{
			[Token(Token = "0x60011CD")]
			[Address(RVA = "0x4EEB50", Offset = "0x4ED750", VA = "0x1804EEB50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x17000218")]
		public int Token
		{
			[Token(Token = "0x60011CE")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000219")]
		public string StringValue
		{
			[Token(Token = "0x60011CF")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x5C24980", Offset = "0x5C23580", VA = "0x185C24980")]
		public Lexer(TextReader reader)
		{
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x539ADF0", Offset = "0x53999F0", VA = "0x18539ADF0")]
		private static int HexValue(int digit)
		{
			return 0;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x5C236F0", Offset = "0x5C222F0", VA = "0x185C236F0")]
		private static void PopulateFsmTables(out Lexer.StateHandler[] fsm_handler_table, out int[] fsm_return_table)
		{
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x60011D4")]
		[Address(RVA = "0x5C24540", Offset = "0x5C23140", VA = "0x185C24540")]
		private static char ProcessEscChar(int esc_char)
		{
			return '\0';
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0x539C360", Offset = "0x539AF60", VA = "0x18539C360")]
		private static bool State1(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x539CB40", Offset = "0x539B740", VA = "0x18539CB40")]
		private static bool State2(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x539CBD0", Offset = "0x539B7D0", VA = "0x18539CBD0")]
		private static bool State3(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x539CCF0", Offset = "0x539B8F0", VA = "0x18539CCF0")]
		private static bool State4(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x539CDD0", Offset = "0x539B9D0", VA = "0x18539CDD0")]
		private static bool State5(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x539CE40", Offset = "0x539BA40", VA = "0x18539CE40")]
		private static bool State6(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x539CF30", Offset = "0x539BB30", VA = "0x18539CF30")]
		private static bool State7(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Token(Token = "0x60011DC")]
		[Address(RVA = "0x539CFB0", Offset = "0x539BBB0", VA = "0x18539CFB0")]
		private static bool State8(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00004CDC File Offset: 0x00002EDC
		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x539D060", Offset = "0x539BC60", VA = "0x18539D060")]
		private static bool State9(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x539C050", Offset = "0x539AC50", VA = "0x18539C050")]
		private static bool State10(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00004D0C File Offset: 0x00002F0C
		[Token(Token = "0x60011DF")]
		[Address(RVA = "0x539C0A0", Offset = "0x539ACA0", VA = "0x18539C0A0")]
		private static bool State11(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00004D24 File Offset: 0x00002F24
		[Token(Token = "0x60011E0")]
		[Address(RVA = "0x539C0F0", Offset = "0x539ACF0", VA = "0x18539C0F0")]
		private static bool State12(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Token(Token = "0x60011E1")]
		[Address(RVA = "0x539C140", Offset = "0x539AD40", VA = "0x18539C140")]
		private static bool State13(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00004D54 File Offset: 0x00002F54
		[Token(Token = "0x60011E2")]
		[Address(RVA = "0x539C190", Offset = "0x539AD90", VA = "0x18539C190")]
		private static bool State14(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00004D6C File Offset: 0x00002F6C
		[Token(Token = "0x60011E3")]
		[Address(RVA = "0x539C0A0", Offset = "0x539ACA0", VA = "0x18539C0A0")]
		private static bool State15(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00004D84 File Offset: 0x00002F84
		[Token(Token = "0x60011E4")]
		[Address(RVA = "0x539C1E0", Offset = "0x539ADE0", VA = "0x18539C1E0")]
		private static bool State16(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00004D9C File Offset: 0x00002F9C
		[Token(Token = "0x60011E5")]
		[Address(RVA = "0x539C230", Offset = "0x539AE30", VA = "0x18539C230")]
		private static bool State17(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00004DB4 File Offset: 0x00002FB4
		[Token(Token = "0x60011E6")]
		[Address(RVA = "0x539C280", Offset = "0x539AE80", VA = "0x18539C280")]
		private static bool State18(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00004DCC File Offset: 0x00002FCC
		[Token(Token = "0x60011E7")]
		[Address(RVA = "0x539C2D0", Offset = "0x539AED0", VA = "0x18539C2D0")]
		private static bool State19(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x539C550", Offset = "0x539B150", VA = "0x18539C550")]
		private static bool State20(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00004DFC File Offset: 0x00002FFC
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x5C24600", Offset = "0x5C23200", VA = "0x185C24600")]
		private static bool State21(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00004E14 File Offset: 0x00003014
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x5C247C0", Offset = "0x5C233C0", VA = "0x185C247C0")]
		private static bool State22(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00004E2C File Offset: 0x0000302C
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x539C8E0", Offset = "0x539B4E0", VA = "0x18539C8E0")]
		private static bool State23(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00004E44 File Offset: 0x00003044
		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x539C970", Offset = "0x539B570", VA = "0x18539C970")]
		private static bool State24(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00004E5C File Offset: 0x0000305C
		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x539C9D0", Offset = "0x539B5D0", VA = "0x18539C9D0")]
		private static bool State25(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00004E74 File Offset: 0x00003074
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x539CA30", Offset = "0x539B630", VA = "0x18539CA30")]
		private static bool State26(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00004E8C File Offset: 0x0000308C
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x539CA80", Offset = "0x539B680", VA = "0x18539CA80")]
		private static bool State27(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00004EA4 File Offset: 0x000030A4
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x539CAD0", Offset = "0x539B6D0", VA = "0x18539CAD0")]
		private static bool State28(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00004EBC File Offset: 0x000030BC
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x539AD70", Offset = "0x5399970", VA = "0x18539AD70")]
		private bool GetChar()
		{
			return default(bool);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00004ED4 File Offset: 0x000030D4
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x539AE90", Offset = "0x5399A90", VA = "0x18539AE90")]
		private int NextChar()
		{
			return 0;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00004EEC File Offset: 0x000030EC
		[Token(Token = "0x60011F3")]
		[Address(RVA = "0x5C234E0", Offset = "0x5C220E0", VA = "0x185C234E0")]
		public bool NextToken()
		{
			return default(bool);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x539D0B0", Offset = "0x539BCB0", VA = "0x18539D0B0")]
		private void UngetChar()
		{
		}

		// Token: 0x04000E50 RID: 3664
		[Token(Token = "0x4000E50")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] fsm_return_table;

		// Token: 0x04000E51 RID: 3665
		[Token(Token = "0x4000E51")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Lexer.StateHandler[] fsm_handler_table;

		// Token: 0x04000E52 RID: 3666
		[Token(Token = "0x4000E52")]
		[FieldOffset(Offset = "0x10")]
		private bool allow_comments;

		// Token: 0x04000E53 RID: 3667
		[Token(Token = "0x4000E53")]
		[FieldOffset(Offset = "0x11")]
		private bool allow_single_quoted_strings;

		// Token: 0x04000E54 RID: 3668
		[Token(Token = "0x4000E54")]
		[FieldOffset(Offset = "0x12")]
		private bool end_of_input;

		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000E55")]
		[FieldOffset(Offset = "0x18")]
		private FsmContext fsm_context;

		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000E56")]
		[FieldOffset(Offset = "0x20")]
		private int input_buffer;

		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x24")]
		private int input_char;

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x28")]
		private TextReader reader;

		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		[FieldOffset(Offset = "0x30")]
		private int state;

		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000E5A")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder string_buffer;

		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000E5B")]
		[FieldOffset(Offset = "0x40")]
		private string string_value;

		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		[FieldOffset(Offset = "0x48")]
		private int token;

		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0x4C")]
		private int unichar;

		// Token: 0x020002FC RID: 764
		// (Invoke) Token: 0x060011F6 RID: 4598
		[Token(Token = "0x20002FC")]
		private delegate bool StateHandler(FsmContext ctx);
	}
}
