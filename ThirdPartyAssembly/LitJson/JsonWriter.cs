using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200048D RID: 1165
	[Token(Token = "0x200048D")]
	public class JsonWriter
	{
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x00010320 File Offset: 0x0000E520
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000522")]
		public int IndentValue
		{
			[Token(Token = "0x60025AB")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60025AC")]
			[Address(RVA = "0x539AB70", Offset = "0x5399770", VA = "0x18539AB70")]
			set
			{
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x00010338 File Offset: 0x0000E538
		// (set) Token: 0x060025AE RID: 9646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000523")]
		public bool PrettyPrint
		{
			[Token(Token = "0x60025AD")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025AE")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			set
			{
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000524")]
		public TextWriter TextWriter
		{
			[Token(Token = "0x60025AF")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x00010350 File Offset: 0x0000E550
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000525")]
		public bool Validate
		{
			[Token(Token = "0x60025B0")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025B1")]
			[Address(RVA = "0x31208C0", Offset = "0x311F4C0", VA = "0x1831208C0")]
			set
			{
			}
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B3")]
		[Address(RVA = "0x539AAA0", Offset = "0x53996A0", VA = "0x18539AAA0")]
		public JsonWriter()
		{
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B4")]
		[Address(RVA = "0x539A980", Offset = "0x5399580", VA = "0x18539A980")]
		public JsonWriter(StringBuilder sb)
		{
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B5")]
		[Address(RVA = "0x539AA10", Offset = "0x5399610", VA = "0x18539AA10")]
		public JsonWriter(TextWriter writer)
		{
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B6")]
		[Address(RVA = "0x5398AB0", Offset = "0x53976B0", VA = "0x185398AB0")]
		private void DoValidation(Condition cond)
		{
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B7")]
		[Address(RVA = "0x5398DB0", Offset = "0x53979B0", VA = "0x185398DB0")]
		private void Init()
		{
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B8")]
		[Address(RVA = "0x5398EE0", Offset = "0x5397AE0", VA = "0x185398EE0")]
		private static void IntToHex(int n, char[] hex)
		{
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B9")]
		[Address(RVA = "0x5398DA0", Offset = "0x53979A0", VA = "0x185398DA0")]
		private void Indent()
		{
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BA")]
		[Address(RVA = "0x5399440", Offset = "0x5398040", VA = "0x185399440")]
		private void Put(string str)
		{
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BB")]
		[Address(RVA = "0x5398F50", Offset = "0x5397B50", VA = "0x185398F50")]
		private void PutNewline()
		{
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BC")]
		[Address(RVA = "0x5398FE0", Offset = "0x5397BE0", VA = "0x185398FE0")]
		private void PutNewline(bool add_comma)
		{
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BD")]
		[Address(RVA = "0x5399080", Offset = "0x5397C80", VA = "0x185399080")]
		private void PutString(string str)
		{
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BE")]
		[Address(RVA = "0x5399680", Offset = "0x5398280", VA = "0x185399680")]
		private void Unindent()
		{
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BF")]
		[Address(RVA = "0x5399600", Offset = "0x5398200", VA = "0x185399600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C0")]
		[Address(RVA = "0x5399510", Offset = "0x5398110", VA = "0x185399510")]
		public void Reset()
		{
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C1")]
		[Address(RVA = "0x5399D20", Offset = "0x5398920", VA = "0x185399D20")]
		public void Write(bool boolean)
		{
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C2")]
		[Address(RVA = "0x539A200", Offset = "0x5398E00", VA = "0x18539A200")]
		public void Write(decimal number)
		{
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x539A3C0", Offset = "0x5398FC0", VA = "0x18539A3C0")]
		public void Write(double number)
		{
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C4")]
		[Address(RVA = "0x539A040", Offset = "0x5398C40", VA = "0x18539A040")]
		public void Write(int number)
		{
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C5")]
		[Address(RVA = "0x5399E80", Offset = "0x5398A80", VA = "0x185399E80")]
		public void Write(long number)
		{
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C6")]
		[Address(RVA = "0x539A7C0", Offset = "0x53993C0", VA = "0x18539A7C0")]
		public void Write(string str)
		{
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x539A600", Offset = "0x5399200", VA = "0x18539A600")]
		public void Write(ulong number)
		{
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x5399690", Offset = "0x5398290", VA = "0x185399690")]
		public void WriteArrayEnd()
		{
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C9")]
		[Address(RVA = "0x53997C0", Offset = "0x53983C0", VA = "0x1853997C0")]
		public void WriteArrayStart()
		{
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CA")]
		[Address(RVA = "0x53998B0", Offset = "0x53984B0", VA = "0x1853998B0")]
		public void WriteObjectEnd()
		{
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CB")]
		[Address(RVA = "0x53999E0", Offset = "0x53985E0", VA = "0x1853999E0")]
		public void WriteObjectStart()
		{
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CC")]
		[Address(RVA = "0x5399AD0", Offset = "0x53986D0", VA = "0x185399AD0")]
		public void WritePropertyName(string property_name)
		{
		}

		// Token: 0x04001503 RID: 5379
		[Token(Token = "0x4001503")]
		[FieldOffset(Offset = "0x0")]
		private static NumberFormatInfo number_format;

		// Token: 0x04001504 RID: 5380
		[Token(Token = "0x4001504")]
		[FieldOffset(Offset = "0x10")]
		private WriterContext context;

		// Token: 0x04001505 RID: 5381
		[Token(Token = "0x4001505")]
		[FieldOffset(Offset = "0x18")]
		private Stack<WriterContext> ctx_stack;

		// Token: 0x04001506 RID: 5382
		[Token(Token = "0x4001506")]
		[FieldOffset(Offset = "0x20")]
		private bool has_reached_end;

		// Token: 0x04001507 RID: 5383
		[Token(Token = "0x4001507")]
		[FieldOffset(Offset = "0x28")]
		private char[] hex_seq;

		// Token: 0x04001508 RID: 5384
		[Token(Token = "0x4001508")]
		[FieldOffset(Offset = "0x30")]
		private int indentation;

		// Token: 0x04001509 RID: 5385
		[Token(Token = "0x4001509")]
		[FieldOffset(Offset = "0x34")]
		private int indent_value;

		// Token: 0x0400150A RID: 5386
		[Token(Token = "0x400150A")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder inst_string_builder;

		// Token: 0x0400150B RID: 5387
		[Token(Token = "0x400150B")]
		[FieldOffset(Offset = "0x40")]
		private bool pretty_print;

		// Token: 0x0400150C RID: 5388
		[Token(Token = "0x400150C")]
		[FieldOffset(Offset = "0x41")]
		private bool validate;

		// Token: 0x0400150D RID: 5389
		[Token(Token = "0x400150D")]
		[FieldOffset(Offset = "0x48")]
		private TextWriter writer;
	}
}
