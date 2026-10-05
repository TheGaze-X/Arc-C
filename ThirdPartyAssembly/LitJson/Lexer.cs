using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200048F RID: 1167
	[Token(Token = "0x200048F")]
	internal class Lexer
	{
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x00010368 File Offset: 0x0000E568
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000526")]
		public bool AllowComments
		{
			[Token(Token = "0x60025CE")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025CF")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x00010380 File Offset: 0x0000E580
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000527")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x60025D0")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025D1")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			set
			{
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x00010398 File Offset: 0x0000E598
		[Token(Token = "0x17000528")]
		public bool EndOfInput
		{
			[Token(Token = "0x60025D2")]
			[Address(RVA = "0x4EEB50", Offset = "0x4ED750", VA = "0x1804EEB50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[Token(Token = "0x17000529")]
		public int Token
		{
			[Token(Token = "0x60025D3")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052A")]
		public string StringValue
		{
			[Token(Token = "0x60025D4")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D6")]
		[Address(RVA = "0x539D0D0", Offset = "0x539BCD0", VA = "0x18539D0D0")]
		public Lexer(TextReader reader)
		{
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x000103C8 File Offset: 0x0000E5C8
		[Token(Token = "0x60025D7")]
		[Address(RVA = "0x539ADF0", Offset = "0x53999F0", VA = "0x18539ADF0")]
		private static int HexValue(int digit)
		{
			return 0;
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x539B100", Offset = "0x5399D00", VA = "0x18539B100")]
		private static void PopulateFsmTables()
		{
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x000103E0 File Offset: 0x0000E5E0
		[Token(Token = "0x60025D9")]
		[Address(RVA = "0x539BF90", Offset = "0x539AB90", VA = "0x18539BF90")]
		private static char ProcessEscChar(int esc_char)
		{
			return '\0';
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x000103F8 File Offset: 0x0000E5F8
		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x539C360", Offset = "0x539AF60", VA = "0x18539C360")]
		private static bool State1(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00010410 File Offset: 0x0000E610
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x539CB40", Offset = "0x539B740", VA = "0x18539CB40")]
		private static bool State2(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00010428 File Offset: 0x0000E628
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x539CBD0", Offset = "0x539B7D0", VA = "0x18539CBD0")]
		private static bool State3(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00010440 File Offset: 0x0000E640
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x539CCF0", Offset = "0x539B8F0", VA = "0x18539CCF0")]
		private static bool State4(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00010458 File Offset: 0x0000E658
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x539CDD0", Offset = "0x539B9D0", VA = "0x18539CDD0")]
		private static bool State5(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00010470 File Offset: 0x0000E670
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x539CE40", Offset = "0x539BA40", VA = "0x18539CE40")]
		private static bool State6(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00010488 File Offset: 0x0000E688
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x539CF30", Offset = "0x539BB30", VA = "0x18539CF30")]
		private static bool State7(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x000104A0 File Offset: 0x0000E6A0
		[Token(Token = "0x60025E1")]
		[Address(RVA = "0x539CFB0", Offset = "0x539BBB0", VA = "0x18539CFB0")]
		private static bool State8(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000104B8 File Offset: 0x0000E6B8
		[Token(Token = "0x60025E2")]
		[Address(RVA = "0x539D060", Offset = "0x539BC60", VA = "0x18539D060")]
		private static bool State9(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x000104D0 File Offset: 0x0000E6D0
		[Token(Token = "0x60025E3")]
		[Address(RVA = "0x539C050", Offset = "0x539AC50", VA = "0x18539C050")]
		private static bool State10(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x000104E8 File Offset: 0x0000E6E8
		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x539C0A0", Offset = "0x539ACA0", VA = "0x18539C0A0")]
		private static bool State11(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00010500 File Offset: 0x0000E700
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x539C0F0", Offset = "0x539ACF0", VA = "0x18539C0F0")]
		private static bool State12(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00010518 File Offset: 0x0000E718
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x539C140", Offset = "0x539AD40", VA = "0x18539C140")]
		private static bool State13(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00010530 File Offset: 0x0000E730
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x539C190", Offset = "0x539AD90", VA = "0x18539C190")]
		private static bool State14(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00010548 File Offset: 0x0000E748
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x539C0A0", Offset = "0x539ACA0", VA = "0x18539C0A0")]
		private static bool State15(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00010560 File Offset: 0x0000E760
		[Token(Token = "0x60025E9")]
		[Address(RVA = "0x539C1E0", Offset = "0x539ADE0", VA = "0x18539C1E0")]
		private static bool State16(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x00010578 File Offset: 0x0000E778
		[Token(Token = "0x60025EA")]
		[Address(RVA = "0x539C230", Offset = "0x539AE30", VA = "0x18539C230")]
		private static bool State17(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00010590 File Offset: 0x0000E790
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0x539C280", Offset = "0x539AE80", VA = "0x18539C280")]
		private static bool State18(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x000105A8 File Offset: 0x0000E7A8
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x539C2D0", Offset = "0x539AED0", VA = "0x18539C2D0")]
		private static bool State19(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x000105C0 File Offset: 0x0000E7C0
		[Token(Token = "0x60025ED")]
		[Address(RVA = "0x539C550", Offset = "0x539B150", VA = "0x18539C550")]
		private static bool State20(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x000105D8 File Offset: 0x0000E7D8
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x539C5A0", Offset = "0x539B1A0", VA = "0x18539C5A0")]
		private static bool State21(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x000105F0 File Offset: 0x0000E7F0
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x539C760", Offset = "0x539B360", VA = "0x18539C760")]
		private static bool State22(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00010608 File Offset: 0x0000E808
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0x539C8E0", Offset = "0x539B4E0", VA = "0x18539C8E0")]
		private static bool State23(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x00010620 File Offset: 0x0000E820
		[Token(Token = "0x60025F1")]
		[Address(RVA = "0x539C970", Offset = "0x539B570", VA = "0x18539C970")]
		private static bool State24(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00010638 File Offset: 0x0000E838
		[Token(Token = "0x60025F2")]
		[Address(RVA = "0x539C9D0", Offset = "0x539B5D0", VA = "0x18539C9D0")]
		private static bool State25(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x00010650 File Offset: 0x0000E850
		[Token(Token = "0x60025F3")]
		[Address(RVA = "0x539CA30", Offset = "0x539B630", VA = "0x18539CA30")]
		private static bool State26(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00010668 File Offset: 0x0000E868
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x539CA80", Offset = "0x539B680", VA = "0x18539CA80")]
		private static bool State27(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00010680 File Offset: 0x0000E880
		[Token(Token = "0x60025F5")]
		[Address(RVA = "0x539CAD0", Offset = "0x539B6D0", VA = "0x18539CAD0")]
		private static bool State28(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x00010698 File Offset: 0x0000E898
		[Token(Token = "0x60025F6")]
		[Address(RVA = "0x539AD70", Offset = "0x5399970", VA = "0x18539AD70")]
		private bool GetChar()
		{
			return default(bool);
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x000106B0 File Offset: 0x0000E8B0
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x539AE90", Offset = "0x5399A90", VA = "0x18539AE90")]
		private int NextChar()
		{
			return 0;
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x000106C8 File Offset: 0x0000E8C8
		[Token(Token = "0x60025F8")]
		[Address(RVA = "0x539AEF0", Offset = "0x5399AF0", VA = "0x18539AEF0")]
		public bool NextToken()
		{
			return default(bool);
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x539D0B0", Offset = "0x539BCB0", VA = "0x18539D0B0")]
		private void UngetChar()
		{
		}

		// Token: 0x04001512 RID: 5394
		[Token(Token = "0x4001512")]
		[FieldOffset(Offset = "0x0")]
		private static int[] fsm_return_table;

		// Token: 0x04001513 RID: 5395
		[Token(Token = "0x4001513")]
		[FieldOffset(Offset = "0x8")]
		private static Lexer.StateHandler[] fsm_handler_table;

		// Token: 0x04001514 RID: 5396
		[Token(Token = "0x4001514")]
		[FieldOffset(Offset = "0x10")]
		private bool allow_comments;

		// Token: 0x04001515 RID: 5397
		[Token(Token = "0x4001515")]
		[FieldOffset(Offset = "0x11")]
		private bool allow_single_quoted_strings;

		// Token: 0x04001516 RID: 5398
		[Token(Token = "0x4001516")]
		[FieldOffset(Offset = "0x12")]
		private bool end_of_input;

		// Token: 0x04001517 RID: 5399
		[Token(Token = "0x4001517")]
		[FieldOffset(Offset = "0x18")]
		private FsmContext fsm_context;

		// Token: 0x04001518 RID: 5400
		[Token(Token = "0x4001518")]
		[FieldOffset(Offset = "0x20")]
		private int input_buffer;

		// Token: 0x04001519 RID: 5401
		[Token(Token = "0x4001519")]
		[FieldOffset(Offset = "0x24")]
		private int input_char;

		// Token: 0x0400151A RID: 5402
		[Token(Token = "0x400151A")]
		[FieldOffset(Offset = "0x28")]
		private TextReader reader;

		// Token: 0x0400151B RID: 5403
		[Token(Token = "0x400151B")]
		[FieldOffset(Offset = "0x30")]
		private int state;

		// Token: 0x0400151C RID: 5404
		[Token(Token = "0x400151C")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder string_buffer;

		// Token: 0x0400151D RID: 5405
		[Token(Token = "0x400151D")]
		[FieldOffset(Offset = "0x40")]
		private string string_value;

		// Token: 0x0400151E RID: 5406
		[Token(Token = "0x400151E")]
		[FieldOffset(Offset = "0x48")]
		private int token;

		// Token: 0x0400151F RID: 5407
		[Token(Token = "0x400151F")]
		[FieldOffset(Offset = "0x4C")]
		private int unichar;

		// Token: 0x02000490 RID: 1168
		// (Invoke) Token: 0x060025FB RID: 9723
		[Token(Token = "0x2000490")]
		private delegate bool StateHandler(FsmContext ctx);
	}
}
