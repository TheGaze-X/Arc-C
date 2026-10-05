using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public class JsonWriter
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000027A8 File Offset: 0x000009A8
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public int IndentValue
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x539AB70", Offset = "0x5399770", VA = "0x18539AB70")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000027C0 File Offset: 0x000009C0
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public bool PrettyPrint
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000058")]
		public TextWriter TextWriter
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000027D8 File Offset: 0x000009D8
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public bool Validate
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x31208C0", Offset = "0x311F4C0", VA = "0x1831208C0")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public bool LowerCaseProperties
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x5008F20", Offset = "0x5007B20", VA = "0x185008F20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x5008F40", Offset = "0x5007B40", VA = "0x185008F40")]
			set
			{
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x55C0500", Offset = "0x55BF100", VA = "0x1855C0500")]
		public JsonWriter()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x55C05D0", Offset = "0x55BF1D0", VA = "0x1855C05D0")]
		public JsonWriter(StringBuilder sb)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x55C0470", Offset = "0x55BF070", VA = "0x1855C0470")]
		public JsonWriter(TextWriter writer)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x55BE6C0", Offset = "0x55BD2C0", VA = "0x1855BE6C0")]
		private void DoValidation(Condition cond)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x55BE9B0", Offset = "0x55BD5B0", VA = "0x1855BE9B0")]
		private void Init()
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x5398EE0", Offset = "0x5397AE0", VA = "0x185398EE0")]
		private static void IntToHex(int n, char[] hex)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x5398DA0", Offset = "0x53979A0", VA = "0x185398DA0")]
		private void Indent()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x5399440", Offset = "0x5398040", VA = "0x185399440")]
		private void Put(string str)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x55BEAE0", Offset = "0x55BD6E0", VA = "0x1855BEAE0")]
		private void PutNewline()
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x55BEB80", Offset = "0x55BD780", VA = "0x1855BEB80")]
		private void PutNewline(bool add_comma)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x55BEC20", Offset = "0x55BD820", VA = "0x1855BEC20")]
		private void PutString(string str)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x5399680", Offset = "0x5398280", VA = "0x185399680")]
		private void Unindent()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x55BF0D0", Offset = "0x55BDCD0", VA = "0x1855BF0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x55BEFE0", Offset = "0x55BDBE0", VA = "0x1855BEFE0")]
		public void Reset()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x55C02B0", Offset = "0x55BEEB0", VA = "0x1855C02B0")]
		public void Write(bool boolean)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x55C00F0", Offset = "0x55BECF0", VA = "0x1855C00F0")]
		public void Write(decimal number)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x55BFB90", Offset = "0x55BE790", VA = "0x1855BFB90")]
		public void Write(double number)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x55BF810", Offset = "0x55BE410", VA = "0x1855BF810")]
		public void Write(int number)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x55BFF30", Offset = "0x55BEB30", VA = "0x1855BFF30")]
		public void Write(long number)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x55BFDD0", Offset = "0x55BE9D0", VA = "0x1855BFDD0")]
		public void Write(string str)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x55BF9D0", Offset = "0x55BE5D0", VA = "0x1855BF9D0")]
		[CLSCompliant(false)]
		public void Write(ulong number)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x55BF150", Offset = "0x55BDD50", VA = "0x1855BF150")]
		public void WriteArrayEnd()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x55BF290", Offset = "0x55BDE90", VA = "0x1855BF290")]
		public void WriteArrayStart()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x55BF380", Offset = "0x55BDF80", VA = "0x1855BF380")]
		public void WriteObjectEnd()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x55BF4C0", Offset = "0x55BE0C0", VA = "0x1855BF4C0")]
		public void WriteObjectStart()
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x55BF5B0", Offset = "0x55BE1B0", VA = "0x1855BF5B0")]
		public void WritePropertyName(string property_name)
		{
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly NumberFormatInfo number_format;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x10")]
		private WriterContext context;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x18")]
		private Stack<WriterContext> ctx_stack;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x20")]
		private bool has_reached_end;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x28")]
		private char[] hex_seq;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x30")]
		private int indentation;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x34")]
		private int indent_value;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder inst_string_builder;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x40")]
		private bool pretty_print;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x41")]
		private bool validate;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x42")]
		private bool lower_case_properties;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x48")]
		private TextWriter writer;
	}
}
