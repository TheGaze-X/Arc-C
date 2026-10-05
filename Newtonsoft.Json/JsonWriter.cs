using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[Preserve]
	public abstract class JsonWriter : IDisposable
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x4D89F90", Offset = "0x4D88B90", VA = "0x184D89F90")]
		internal static JsonWriter.State[][] BuildStateArray()
		{
			return null;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00002C58 File Offset: 0x00000E58
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000081")]
		public bool CloseOutput
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x17000082")]
		protected internal int Top
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x4D8EFC0", Offset = "0x4D8DBC0", VA = "0x184D8EFC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x17000083")]
		public WriteState WriteState
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x4D8F020", Offset = "0x4D8DC20", VA = "0x184D8F020")]
			get
			{
				return WriteState.Error;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		internal string ContainerPath
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x4D8EDB0", Offset = "0x4D8D9B0", VA = "0x184D8EDB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public string Path
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x4D8EEB0", Offset = "0x4D8DAB0", VA = "0x184D8EEB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00002CA0 File Offset: 0x00000EA0
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000086")]
		public Formatting Formatting
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return Formatting.None;
			}
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x4D8F280", Offset = "0x4D8DE80", VA = "0x184D8F280")]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000087")]
		public DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			get
			{
				return DateFormatHandling.IsoDateFormat;
			}
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x4D8F130", Offset = "0x4D8DD30", VA = "0x184D8F130")]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000088")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return DateTimeZoneHandling.Local;
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x4D8F1A0", Offset = "0x4D8DDA0", VA = "0x184D8F1A0")]
			set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000089")]
		public StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x1793F50", Offset = "0x1792B50", VA = "0x181793F50")]
			get
			{
				return StringEscapeHandling.Default;
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x4D8F2F0", Offset = "0x4D8DEF0", VA = "0x184D8F2F0")]
			set
			{
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00002D00 File Offset: 0x00000F00
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008A")]
		public FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return FloatFormatHandling.String;
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x4D8F210", Offset = "0x4D8DE10", VA = "0x184D8F210")]
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008B")]
		public string DateFormatString
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008C")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x4D8EE50", Offset = "0x4D8DA50", VA = "0x184D8EE50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x4D8ED80", Offset = "0x4D8D980", VA = "0x184D8ED80")]
		protected JsonWriter()
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x4D8AD70", Offset = "0x4D89970", VA = "0x184D8AD70")]
		internal void UpdateScopeWithFinishedValue()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x4D8A8F0", Offset = "0x4D894F0", VA = "0x184D8A8F0")]
		private void Push(JsonContainerType value)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x4D8A800", Offset = "0x4D89400", VA = "0x184D8A800")]
		private JsonContainerType Pop()
		{
			return JsonContainerType.None;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
		private JsonContainerType Peek()
		{
			return JsonContainerType.None;
		}

		// Token: 0x0600025D RID: 605
		[Token(Token = "0x600025D")]
		public abstract void Flush();

		// Token: 0x0600025E RID: 606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x4D89950", Offset = "0x4D88550", VA = "0x184D89950", Slot = "7")]
		public virtual void Close()
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x4D8B3B0", Offset = "0x4D89FB0", VA = "0x184D8B3B0", Slot = "8")]
		public virtual void WriteStartObject()
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x4D8B090", Offset = "0x4D89C90", VA = "0x184D8B090", Slot = "9")]
		public virtual void WriteEndObject()
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x4D8B390", Offset = "0x4D89F90", VA = "0x184D8B390", Slot = "10")]
		public virtual void WriteStartArray()
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x4D8B070", Offset = "0x4D89C70", VA = "0x184D8B070", Slot = "11")]
		public virtual void WriteEndArray()
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x4D8B3A0", Offset = "0x4D89FA0", VA = "0x184D8B3A0", Slot = "12")]
		public virtual void WriteStartConstructor(string name)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x4D8B080", Offset = "0x4D89C80", VA = "0x184D8B080", Slot = "13")]
		public virtual void WriteEndConstructor()
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x4D8A540", Offset = "0x4D89140", VA = "0x184D8A540", Slot = "14")]
		public virtual void WritePropertyName(string name)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x4D8B2E0", Offset = "0x4D89EE0", VA = "0x184D8B2E0", Slot = "15")]
		public virtual void WritePropertyName(string name, bool escape)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x4D8B0A0", Offset = "0x4D89CA0", VA = "0x184D8B0A0", Slot = "16")]
		public virtual void WriteEnd()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x4D8B700", Offset = "0x4D8A300", VA = "0x184D8B700")]
		public void WriteToken(JsonReader reader)
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x4D8C0A0", Offset = "0x4D8ACA0", VA = "0x184D8C0A0")]
		public void WriteToken(JsonReader reader, bool writeChildren)
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x4D8B7E0", Offset = "0x4D8A3E0", VA = "0x184D8B7E0")]
		public void WriteToken(JsonToken token, object value)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x4D8B7D0", Offset = "0x4D8A3D0", VA = "0x184D8B7D0")]
		public void WriteToken(JsonToken token)
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x4D8B3C0", Offset = "0x4D89FC0", VA = "0x184D8B3C0", Slot = "17")]
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x4D8AD80", Offset = "0x4D89980", VA = "0x184D8AD80")]
		private void WriteConstructorDate(JsonReader reader)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x4D8B1B0", Offset = "0x4D89DB0", VA = "0x184D8B1B0")]
		private void WriteEnd(JsonContainerType type)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x4D89950", Offset = "0x4D88550", VA = "0x184D89950")]
		private void AutoCompleteAll()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x4D8A470", Offset = "0x4D89070", VA = "0x184D8A470")]
		private JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			return JsonToken.None;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x4D899D0", Offset = "0x4D885D0", VA = "0x184D899D0")]
		private void AutoCompleteClose(JsonContainerType type)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
		protected virtual void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		protected virtual void WriteIndent()
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		protected virtual void WriteValueDelimiter()
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		protected virtual void WriteIndentSpace()
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x4D89D50", Offset = "0x4D88950", VA = "0x184D89D50")]
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x4D8B2C0", Offset = "0x4D89EC0", VA = "0x184D8B2C0", Slot = "22")]
		public virtual void WriteNull()
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x4D8C180", Offset = "0x4D8AD80", VA = "0x184D8C180", Slot = "23")]
		public virtual void WriteUndefined()
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "24")]
		public virtual void WriteRaw(string json)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x4D8B330", Offset = "0x4D89F30", VA = "0x184D8B330", Slot = "25")]
		public virtual void WriteRawValue(string json)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x4D8C6B0", Offset = "0x4D8B2B0", VA = "0x184D8C6B0", Slot = "26")]
		public virtual void WriteValue(string value)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x4D8C250", Offset = "0x4D8AE50", VA = "0x184D8C250", Slot = "27")]
		public virtual void WriteValue(int value)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x4D8C250", Offset = "0x4D8AE50", VA = "0x184D8C250", Slot = "28")]
		[CLSCompliant(false)]
		public virtual void WriteValue(uint value)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x4D8C250", Offset = "0x4D8AE50", VA = "0x184D8C250", Slot = "29")]
		public virtual void WriteValue(long value)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x4D8C250", Offset = "0x4D8AE50", VA = "0x184D8C250", Slot = "30")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong value)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x4D8C490", Offset = "0x4D8B090", VA = "0x184D8C490", Slot = "31")]
		public virtual void WriteValue(float value)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x4D8C490", Offset = "0x4D8B090", VA = "0x184D8C490", Slot = "32")]
		public virtual void WriteValue(double value)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x4D8C820", Offset = "0x4D8B420", VA = "0x184D8C820", Slot = "33")]
		public virtual void WriteValue(bool value)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x4D8C250", Offset = "0x4D8AE50", VA = "0x184D8C250", Slot = "34")]
		public virtual void WriteValue(short value)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x4D8C250", Offset = "0x4D8AE50", VA = "0x184D8C250", Slot = "35")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort value)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x4D8C6B0", Offset = "0x4D8B2B0", VA = "0x184D8C6B0", Slot = "36")]
		public virtual void WriteValue(char value)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x4D8C250", Offset = "0x4D8AE50", VA = "0x184D8C250", Slot = "37")]
		public virtual void WriteValue(byte value)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x4D8C250", Offset = "0x4D8AE50", VA = "0x184D8C250", Slot = "38")]
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte value)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x4D8C490", Offset = "0x4D8B090", VA = "0x184D8C490", Slot = "39")]
		public virtual void WriteValue(decimal value)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x4D8C270", Offset = "0x4D8AE70", VA = "0x184D8C270", Slot = "40")]
		public virtual void WriteValue(DateTime value)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x4D8C270", Offset = "0x4D8AE70", VA = "0x184D8C270", Slot = "41")]
		public virtual void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x4D8C6B0", Offset = "0x4D8B2B0", VA = "0x184D8C6B0", Slot = "42")]
		public virtual void WriteValue(Guid value)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x4D8C6B0", Offset = "0x4D8B2B0", VA = "0x184D8C6B0", Slot = "43")]
		public virtual void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x4D8E290", Offset = "0x4D8CE90", VA = "0x184D8E290", Slot = "44")]
		public virtual void WriteValue(int? value)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x4D8C600", Offset = "0x4D8B200", VA = "0x184D8C600", Slot = "45")]
		[CLSCompliant(false)]
		public virtual void WriteValue(uint? value)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x4D8DF10", Offset = "0x4D8CB10", VA = "0x184D8DF10", Slot = "46")]
		public virtual void WriteValue(long? value)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x4D8C840", Offset = "0x4D8B440", VA = "0x184D8C840", Slot = "47")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong? value)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x4D8C4B0", Offset = "0x4D8B0B0", VA = "0x184D8C4B0", Slot = "48")]
		public virtual void WriteValue(float? value)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x4D8C6D0", Offset = "0x4D8B2D0", VA = "0x184D8C6D0", Slot = "49")]
		public virtual void WriteValue(double? value)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x4D8E180", Offset = "0x4D8CD80", VA = "0x184D8E180", Slot = "50")]
		public virtual void WriteValue(bool? value)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x4D8C8E0", Offset = "0x4D8B4E0", VA = "0x184D8C8E0", Slot = "51")]
		public virtual void WriteValue(short? value)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x4D8E3F0", Offset = "0x4D8CFF0", VA = "0x184D8E3F0", Slot = "52")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort? value)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x4D8C1A0", Offset = "0x4D8ADA0", VA = "0x184D8C1A0", Slot = "53")]
		public virtual void WriteValue(char? value)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x4D8C770", Offset = "0x4D8B370", VA = "0x184D8C770", Slot = "54")]
		public virtual void WriteValue(byte? value)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x4D8C3E0", Offset = "0x4D8AFE0", VA = "0x184D8C3E0", Slot = "55")]
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte? value)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x4D8C330", Offset = "0x4D8AF30", VA = "0x184D8C330", Slot = "56")]
		public virtual void WriteValue(decimal? value)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x4D8C290", Offset = "0x4D8AE90", VA = "0x184D8C290", Slot = "57")]
		public virtual void WriteValue(DateTime? value)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x4D8C990", Offset = "0x4D8B590", VA = "0x184D8C990", Slot = "58")]
		public virtual void WriteValue(DateTimeOffset? value)
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x4D8E340", Offset = "0x4D8CF40", VA = "0x184D8E340", Slot = "59")]
		public virtual void WriteValue(Guid? value)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x4D8C560", Offset = "0x4D8B160", VA = "0x184D8C560", Slot = "60")]
		public virtual void WriteValue(TimeSpan? value)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x4D8E230", Offset = "0x4D8CE30", VA = "0x184D8E230", Slot = "61")]
		public virtual void WriteValue(byte[] value)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x4D8DFB0", Offset = "0x4D8CBB0", VA = "0x184D8DFB0", Slot = "62")]
		public virtual void WriteValue(Uri value)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x4D8E060", Offset = "0x4D8CC60", VA = "0x184D8E060", Slot = "63")]
		public virtual void WriteValue(object value)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x4D8A520", Offset = "0x4D89120", VA = "0x184D8A520", Slot = "64")]
		public virtual void WriteComment(string text)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x4D8A720", Offset = "0x4D89320", VA = "0x184D8A720", Slot = "65")]
		public virtual void WriteWhitespace(string ws)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x4D8AD00", Offset = "0x4D89900", VA = "0x184D8AD00", Slot = "4")]
		private void Dispose()
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x4D8A420", Offset = "0x4D89020", VA = "0x184D8A420", Slot = "66")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x4D8CA40", Offset = "0x4D8B640", VA = "0x184D8CA40")]
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x4D8A370", Offset = "0x4D88F70", VA = "0x184D8A370")]
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value)
		{
			return null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x4D8AA70", Offset = "0x4D89670", VA = "0x184D8AA70")]
		protected void SetWriteState(JsonToken token, object value)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x4D8A530", Offset = "0x4D89130", VA = "0x184D8A530")]
		internal void InternalWriteEnd(JsonContainerType container)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x4D8A540", Offset = "0x4D89140", VA = "0x184D8A540")]
		internal void InternalWritePropertyName(string name)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void InternalWriteRaw()
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x4D8A570", Offset = "0x4D89170", VA = "0x184D8A570")]
		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x4D8A700", Offset = "0x4D89300", VA = "0x184D8A700")]
		internal void InternalWriteValue(JsonToken token)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x4D8A720", Offset = "0x4D89320", VA = "0x184D8A720")]
		internal void InternalWriteWhitespace(string ws)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x4D8A520", Offset = "0x4D89120", VA = "0x184D8A520")]
		internal void InternalWriteComment()
		{
		}

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x0")]
		private static readonly JsonWriter.State[][] StateArray;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly JsonWriter.State[][] StateArrayTempate;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x10")]
		private List<JsonPosition> _stack;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x18")]
		private JsonPosition _currentPosition;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x30")]
		private JsonWriter.State _currentState;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x34")]
		private Formatting _formatting;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x3C")]
		private DateFormatHandling _dateFormatHandling;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x40")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x44")]
		private StringEscapeHandling _stringEscapeHandling;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x48")]
		private FloatFormatHandling _floatFormatHandling;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x50")]
		private string _dateFormatString;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x58")]
		private CultureInfo _culture;

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		internal enum State
		{
			// Token: 0x0400013F RID: 319
			[Token(Token = "0x400013F")]
			Start,
			// Token: 0x04000140 RID: 320
			[Token(Token = "0x4000140")]
			Property,
			// Token: 0x04000141 RID: 321
			[Token(Token = "0x4000141")]
			ObjectStart,
			// Token: 0x04000142 RID: 322
			[Token(Token = "0x4000142")]
			Object,
			// Token: 0x04000143 RID: 323
			[Token(Token = "0x4000143")]
			ArrayStart,
			// Token: 0x04000144 RID: 324
			[Token(Token = "0x4000144")]
			Array,
			// Token: 0x04000145 RID: 325
			[Token(Token = "0x4000145")]
			ConstructorStart,
			// Token: 0x04000146 RID: 326
			[Token(Token = "0x4000146")]
			Constructor,
			// Token: 0x04000147 RID: 327
			[Token(Token = "0x4000147")]
			Closed,
			// Token: 0x04000148 RID: 328
			[Token(Token = "0x4000148")]
			Error
		}
	}
}
