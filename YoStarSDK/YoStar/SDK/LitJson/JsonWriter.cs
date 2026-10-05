using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	public class JsonWriter
	{
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00004B2C File Offset: 0x00002D2C
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000210")]
		public int IndentValue
		{
			[Token(Token = "0x60011A4")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60011A5")]
			[Address(RVA = "0x539AB70", Offset = "0x5399770", VA = "0x18539AB70")]
			set
			{
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00004B44 File Offset: 0x00002D44
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000211")]
		public bool PrettyPrint
		{
			[Token(Token = "0x60011A6")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011A7")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			set
			{
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000212")]
		public TextWriter TextWriter
		{
			[Token(Token = "0x60011A8")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00004B5C File Offset: 0x00002D5C
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000213")]
		public bool Validate
		{
			[Token(Token = "0x60011A9")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011AA")]
			[Address(RVA = "0x31208C0", Offset = "0x311F4C0", VA = "0x1831208C0")]
			set
			{
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00004B74 File Offset: 0x00002D74
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000214")]
		public bool LowerCaseProperties
		{
			[Token(Token = "0x60011AB")]
			[Address(RVA = "0x5008F20", Offset = "0x5007B20", VA = "0x185008F20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011AC")]
			[Address(RVA = "0x5008F40", Offset = "0x5007B40", VA = "0x185008F40")]
			set
			{
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x5C23410", Offset = "0x5C22010", VA = "0x185C23410")]
		public JsonWriter()
		{
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011AF")]
		[Address(RVA = "0x5C232F0", Offset = "0x5C21EF0", VA = "0x185C232F0")]
		public JsonWriter(StringBuilder sb)
		{
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011B0")]
		[Address(RVA = "0x5C23380", Offset = "0x5C21F80", VA = "0x185C23380")]
		public JsonWriter(TextWriter writer)
		{
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011B1")]
		[Address(RVA = "0x5C21680", Offset = "0x5C20280", VA = "0x185C21680")]
		private void DoValidation(Condition cond)
		{
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011B2")]
		[Address(RVA = "0x5C21970", Offset = "0x5C20570", VA = "0x185C21970")]
		private void Init()
		{
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011B3")]
		[Address(RVA = "0x5398EE0", Offset = "0x5397AE0", VA = "0x185398EE0")]
		private static void IntToHex(int n, char[] hex)
		{
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011B4")]
		[Address(RVA = "0x5398DA0", Offset = "0x53979A0", VA = "0x185398DA0")]
		private void Indent()
		{
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x5399440", Offset = "0x5398040", VA = "0x185399440")]
		private void Put(string str)
		{
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011B6")]
		[Address(RVA = "0x55BEAE0", Offset = "0x55BD6E0", VA = "0x1855BEAE0")]
		private void PutNewline()
		{
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011B7")]
		[Address(RVA = "0x55BEB80", Offset = "0x55BD780", VA = "0x1855BEB80")]
		private void PutNewline(bool add_comma)
		{
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x5C21AA0", Offset = "0x5C206A0", VA = "0x185C21AA0")]
		private void PutString(string str)
		{
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011B9")]
		[Address(RVA = "0x5399680", Offset = "0x5398280", VA = "0x185399680")]
		private void Unindent()
		{
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x5C21F50", Offset = "0x5C20B50", VA = "0x185C21F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011BB")]
		[Address(RVA = "0x5C21E60", Offset = "0x5C20A60", VA = "0x185C21E60")]
		public void Reset()
		{
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011BC")]
		[Address(RVA = "0x5C22DB0", Offset = "0x5C219B0", VA = "0x185C22DB0")]
		public void Write(bool boolean)
		{
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011BD")]
		[Address(RVA = "0x5C22A90", Offset = "0x5C21690", VA = "0x185C22A90")]
		public void Write(decimal number)
		{
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011BE")]
		[Address(RVA = "0x5C22850", Offset = "0x5C21450", VA = "0x185C22850")]
		public void Write(double number)
		{
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011BF")]
		[Address(RVA = "0x5C22F10", Offset = "0x5C21B10", VA = "0x185C22F10")]
		public void Write(int number)
		{
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011C0")]
		[Address(RVA = "0x5C230D0", Offset = "0x5C21CD0", VA = "0x185C230D0")]
		public void Write(long number)
		{
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011C1")]
		[Address(RVA = "0x5C22C50", Offset = "0x5C21850", VA = "0x185C22C50")]
		public void Write(string str)
		{
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x5C22690", Offset = "0x5C21290", VA = "0x185C22690")]
		[CLSCompliant(false)]
		public void Write(ulong number)
		{
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x5C21FD0", Offset = "0x5C20BD0", VA = "0x185C21FD0")]
		public void WriteArrayEnd()
		{
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x5C22110", Offset = "0x5C20D10", VA = "0x185C22110")]
		public void WriteArrayStart()
		{
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x5C22200", Offset = "0x5C20E00", VA = "0x185C22200")]
		public void WriteObjectEnd()
		{
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x5C22340", Offset = "0x5C20F40", VA = "0x185C22340")]
		public void WriteObjectStart()
		{
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x5C22430", Offset = "0x5C21030", VA = "0x185C22430")]
		public void WritePropertyName(string property_name)
		{
		}

		// Token: 0x04000E40 RID: 3648
		[Token(Token = "0x4000E40")]
		[FieldOffset(Offset = "0x0")]
		private static readonly NumberFormatInfo number_format;

		// Token: 0x04000E41 RID: 3649
		[Token(Token = "0x4000E41")]
		[FieldOffset(Offset = "0x10")]
		private WriterContext context;

		// Token: 0x04000E42 RID: 3650
		[Token(Token = "0x4000E42")]
		[FieldOffset(Offset = "0x18")]
		private Stack<WriterContext> ctx_stack;

		// Token: 0x04000E43 RID: 3651
		[Token(Token = "0x4000E43")]
		[FieldOffset(Offset = "0x20")]
		private bool has_reached_end;

		// Token: 0x04000E44 RID: 3652
		[Token(Token = "0x4000E44")]
		[FieldOffset(Offset = "0x28")]
		private char[] hex_seq;

		// Token: 0x04000E45 RID: 3653
		[Token(Token = "0x4000E45")]
		[FieldOffset(Offset = "0x30")]
		private int indentation;

		// Token: 0x04000E46 RID: 3654
		[Token(Token = "0x4000E46")]
		[FieldOffset(Offset = "0x34")]
		private int indent_value;

		// Token: 0x04000E47 RID: 3655
		[Token(Token = "0x4000E47")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder inst_string_builder;

		// Token: 0x04000E48 RID: 3656
		[Token(Token = "0x4000E48")]
		[FieldOffset(Offset = "0x40")]
		private bool pretty_print;

		// Token: 0x04000E49 RID: 3657
		[Token(Token = "0x4000E49")]
		[FieldOffset(Offset = "0x41")]
		private bool validate;

		// Token: 0x04000E4A RID: 3658
		[Token(Token = "0x4000E4A")]
		[FieldOffset(Offset = "0x42")]
		private bool lower_case_properties;

		// Token: 0x04000E4B RID: 3659
		[Token(Token = "0x4000E4B")]
		[FieldOffset(Offset = "0x48")]
		private TextWriter writer;
	}
}
