using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[Preserve]
	public abstract class JsonReader : IDisposable
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x17000055")]
		protected JsonReader.State CurrentState
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return JsonReader.State.Start;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000027C0 File Offset: 0x000009C0
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000056")]
		public bool CloseInput
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2109C30", Offset = "0x2108830", VA = "0x182109C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x4D6B950", Offset = "0x4D6A550", VA = "0x184D6B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000027D8 File Offset: 0x000009D8
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000057")]
		public bool SupportMultipleContent
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x37002A0", Offset = "0x36FEEA0", VA = "0x1837002A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x37002C0", Offset = "0x36FEEC0", VA = "0x1837002C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000058")]
		public virtual char QuoteChar
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x4D6B920", Offset = "0x4D6A520", VA = "0x184D6B920", Slot = "5")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x4D6BB70", Offset = "0x4D6A770", VA = "0x184D6BB70", Slot = "6")]
			protected internal set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000059")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return DateTimeZoneHandling.Local;
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x4D6B9D0", Offset = "0x4D6A5D0", VA = "0x184D6B9D0")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005A")]
		public DateParseHandling DateParseHandling
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return DateParseHandling.None;
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x4D6B960", Offset = "0x4D6A560", VA = "0x184D6B960")]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005B")]
		public FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x32FB190", Offset = "0x32F9D90", VA = "0x1832FB190")]
			get
			{
				return FloatParseHandling.Double;
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x4D6BA40", Offset = "0x4D6A640", VA = "0x184D6BA40")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005C")]
		public string DateFormatString
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002850 File Offset: 0x00000A50
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005D")]
		public int? MaxDepth
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x4D6B800", Offset = "0x4D6A400", VA = "0x184D6B800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x4D6BAB0", Offset = "0x4D6A6B0", VA = "0x184D6BAB0")]
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x1700005E")]
		public virtual JsonToken TokenType
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "7")]
			get
			{
				return JsonToken.None;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		public virtual object Value
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public virtual Type ValueType
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x4D6B930", Offset = "0x4D6A530", VA = "0x184D6B930", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x17000061")]
		public virtual int Depth
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x4D6B770", Offset = "0x4D6A370", VA = "0x184D6B770", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public virtual string Path
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x4D6B810", Offset = "0x4D6A410", VA = "0x184D6B810", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000063")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x4D6B710", Offset = "0x4D6A310", VA = "0x184D6B710")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x4D67500", Offset = "0x4D66100", VA = "0x184D67500")]
		internal JsonPosition GetPosition(int depth)
		{
			return default(JsonPosition);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x4D6B6E0", Offset = "0x4D6A2E0", VA = "0x184D6B6E0")]
		protected JsonReader()
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x4D67840", Offset = "0x4D66440", VA = "0x184D67840")]
		private void Push(JsonContainerType value)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x4D67710", Offset = "0x4D66310", VA = "0x184D67710")]
		private JsonContainerType Pop()
		{
			return JsonContainerType.None;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
		private JsonContainerType Peek()
		{
			return JsonContainerType.None;
		}

		// Token: 0x0600017D RID: 381
		[Token(Token = "0x600017D")]
		public abstract bool Read();

		// Token: 0x0600017E RID: 382 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x4D694C0", Offset = "0x4D680C0", VA = "0x184D694C0", Slot = "13")]
		public virtual int? ReadAsInt32()
		{
			return null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x4D6A920", Offset = "0x4D69520", VA = "0x184D6A920")]
		internal int? ReadInt32String(string s)
		{
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x4D697C0", Offset = "0x4D683C0", VA = "0x184D697C0", Slot = "14")]
		public virtual string ReadAsString()
		{
			return null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x4D682F0", Offset = "0x4D66EF0", VA = "0x184D682F0", Slot = "15")]
		public virtual byte[] ReadAsBytes()
		{
			return null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x4D67D00", Offset = "0x4D66900", VA = "0x184D67D00")]
		internal byte[] ReadArrayIntoByteArray()
		{
			return null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x4D691B0", Offset = "0x4D67DB0", VA = "0x184D691B0", Slot = "16")]
		public virtual double? ReadAsDouble()
		{
			return null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4D6A6E0", Offset = "0x4D692E0", VA = "0x184D6A6E0")]
		internal double? ReadDoubleString(string s)
		{
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4D67FE0", Offset = "0x4D66BE0", VA = "0x184D67FE0", Slot = "17")]
		public virtual bool? ReadAsBoolean()
		{
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x4D69B60", Offset = "0x4D68760", VA = "0x184D69B60")]
		internal bool? ReadBooleanString(string s)
		{
			return null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x4D68E60", Offset = "0x4D67A60", VA = "0x184D68E60", Slot = "18")]
		public virtual decimal? ReadAsDecimal()
		{
			return null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4D6A440", Offset = "0x4D69040", VA = "0x184D6A440")]
		internal decimal? ReadDecimalString(string s)
		{
			return null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x4D68B60", Offset = "0x4D67760", VA = "0x184D68B60", Slot = "19")]
		public virtual DateTime? ReadAsDateTime()
		{
			return null;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x4D6A110", Offset = "0x4D68D10", VA = "0x184D6A110")]
		internal DateTime? ReadDateTimeString(string s)
		{
			return null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4D68840", Offset = "0x4D67440", VA = "0x184D68840", Slot = "20")]
		public virtual DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4D69D60", Offset = "0x4D68960", VA = "0x184D69D60")]
		internal DateTimeOffset? ReadDateTimeOffsetString(string s)
		{
			return null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x4D6AE40", Offset = "0x4D69A40", VA = "0x184D6AE40")]
		internal void ReaderReadAndAssert()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4D673C0", Offset = "0x4D65FC0", VA = "0x184D673C0")]
		internal JsonReaderException CreateUnexpectedEndException()
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4D6AB50", Offset = "0x4D69750", VA = "0x184D6AB50")]
		internal void ReadIntoWrappedTypeObject()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4D6B230", Offset = "0x4D69E30", VA = "0x184D6B230")]
		public void Skip()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4D6B210", Offset = "0x4D69E10", VA = "0x184D6B210")]
		protected void SetToken(JsonToken newToken)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x4D6B1F0", Offset = "0x4D69DF0", VA = "0x184D6B1F0")]
		protected void SetToken(JsonToken newToken, object value)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x4D6B000", Offset = "0x4D69C00", VA = "0x184D6B000")]
		internal void SetToken(JsonToken newToken, object value, bool updateIndex)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x4D6AEC0", Offset = "0x4D69AC0", VA = "0x184D6AEC0")]
		internal void SetPostValueState(bool updateIndex)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x4D6B3D0", Offset = "0x4D69FD0", VA = "0x184D6B3D0")]
		private void UpdateScopeWithFinishedValue()
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x4D6B3E0", Offset = "0x4D69FE0", VA = "0x184D6B3E0")]
		private void ValidateEnd(JsonToken endToken)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x4D6AEF0", Offset = "0x4D69AF0", VA = "0x184D6AEF0")]
		protected void SetStateBasedOnCurrent()
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x4D6AEA0", Offset = "0x4D69AA0", VA = "0x184D6AEA0")]
		private void SetFinished()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x4D675A0", Offset = "0x4D661A0", VA = "0x184D675A0")]
		private JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			return JsonContainerType.None;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x4D6B360", Offset = "0x4D69F60", VA = "0x184D6B360", Slot = "4")]
		private void Dispose()
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x4D67400", Offset = "0x4D66000", VA = "0x184D67400", Slot = "21")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x4D673A0", Offset = "0x4D65FA0", VA = "0x184D673A0", Slot = "22")]
		public virtual void Close()
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x4D67BD0", Offset = "0x4D667D0", VA = "0x184D67BD0")]
		internal void ReadAndAssert()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x4D67C40", Offset = "0x4D66840", VA = "0x184D67C40")]
		internal bool ReadAndMoveToContent()
		{
			return default(bool);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x4D67680", Offset = "0x4D66280", VA = "0x184D67680")]
		internal bool MoveToContent()
		{
			return default(bool);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x4D67450", Offset = "0x4D66050", VA = "0x184D67450")]
		private JsonToken GetContentToken()
		{
			return JsonToken.None;
		}

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x10")]
		private JsonToken _tokenType;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x18")]
		private object _value;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x20")]
		internal char _quoteChar;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x24")]
		internal JsonReader.State _currentState;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x28")]
		private JsonPosition _currentPosition;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x40")]
		private CultureInfo _culture;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x48")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x4C")]
		private int? _maxDepth;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x54")]
		private bool _hasExceededMaxDepth;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x58")]
		internal DateParseHandling _dateParseHandling;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x5C")]
		internal FloatParseHandling _floatParseHandling;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x60")]
		private string _dateFormatString;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x68")]
		private List<JsonPosition> _stack;

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		protected internal enum State
		{
			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40000D9")]
			Start,
			// Token: 0x040000DA RID: 218
			[Token(Token = "0x40000DA")]
			Complete,
			// Token: 0x040000DB RID: 219
			[Token(Token = "0x40000DB")]
			Property,
			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			ObjectStart,
			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			Object,
			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			ArrayStart,
			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			Array,
			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			Closed,
			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			PostValue,
			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			ConstructorStart,
			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			Constructor,
			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			Error,
			// Token: 0x040000E5 RID: 229
			[Token(Token = "0x40000E5")]
			Finished
		}
	}
}
