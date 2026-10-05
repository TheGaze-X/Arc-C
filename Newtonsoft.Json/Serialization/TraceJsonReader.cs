using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	[Preserve]
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x4D98BA0", Offset = "0x4D977A0", VA = "0x184D98BA0")]
		public TraceJsonReader(JsonReader innerReader)
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x4D983C0", Offset = "0x4D96FC0", VA = "0x184D983C0")]
		public string GetDeserializedJsonMessage()
		{
			return null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x4D98AF0", Offset = "0x4D976F0", VA = "0x184D98AF0", Slot = "12")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x4D98990", Offset = "0x4D97590", VA = "0x184D98990", Slot = "13")]
		public override int? ReadAsInt32()
		{
			return null;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x4D98A40", Offset = "0x4D97640", VA = "0x184D98A40", Slot = "14")]
		public override string ReadAsString()
		{
			return null;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x4D985E0", Offset = "0x4D971E0", VA = "0x184D985E0", Slot = "15")]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x4D98810", Offset = "0x4D97410", VA = "0x184D98810", Slot = "18")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x4D988D0", Offset = "0x4D974D0", VA = "0x184D988D0", Slot = "16")]
		public override double? ReadAsDouble()
		{
			return null;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x4D98530", Offset = "0x4D97130", VA = "0x184D98530", Slot = "17")]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x4D98750", Offset = "0x4D97350", VA = "0x184D98750", Slot = "19")]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x4D98690", Offset = "0x4D97290", VA = "0x184D98690", Slot = "20")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x170000C2")]
		public override int Depth
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x4D98D30", Offset = "0x4D97930", VA = "0x184D98D30", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C3")]
		public override string Path
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x4D98D80", Offset = "0x4D97980", VA = "0x184D98D80", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00003D80 File Offset: 0x00001F80
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C4")]
		public override char QuoteChar
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x4D98DD0", Offset = "0x4D979D0", VA = "0x184D98DD0", Slot = "5")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x4D98F10", Offset = "0x4D97B10", VA = "0x184D98F10", Slot = "6")]
			protected internal set
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x170000C5")]
		public override JsonToken TokenType
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x4D98E20", Offset = "0x4D97A20", VA = "0x184D98E20", Slot = "7")]
			get
			{
				return JsonToken.None;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C6")]
		public override object Value
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x4D98EC0", Offset = "0x4D97AC0", VA = "0x184D98EC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		public override Type ValueType
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x4D98E70", Offset = "0x4D97A70", VA = "0x184D98E70", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x4D98380", Offset = "0x4D96F80", VA = "0x184D98380", Slot = "22")]
		public override void Close()
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x4D98410", Offset = "0x4D97010", VA = "0x184D98410", Slot = "23")]
		private bool HasLineInfo()
		{
			return default(bool);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x170000C8")]
		private int LineNumber
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x4D98470", Offset = "0x4D97070", VA = "0x184D98470", Slot = "24")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x170000C9")]
		private int LinePosition
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x4D984D0", Offset = "0x4D970D0", VA = "0x184D984D0", Slot = "25")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x78")]
		private readonly JsonReader _innerReader;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x80")]
		private readonly JsonTextWriter _textWriter;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x88")]
		private readonly StringWriter _sw;
	}
}
