using System;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	[Preserve]
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00005F58 File Offset: 0x00004158
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D7")]
		public DateTimeStyles DateTimeStyles
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return DateTimeStyles.None;
			}
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D8")]
		public string DateTimeFormat
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x4DDF9C0", Offset = "0x4DDE5C0", VA = "0x184DDF9C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x4DDFA10", Offset = "0x4DDE610", VA = "0x184DDFA10")]
			set
			{
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D9")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x4DDF960", Offset = "0x4DDE560", VA = "0x184DDF960")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x4DDF600", Offset = "0x4DDE200", VA = "0x184DDF600", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x4DDF020", Offset = "0x4DDDC20", VA = "0x184DDF020", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x4DDF950", Offset = "0x4DDE550", VA = "0x184DDF950")]
		public IsoDateTimeConverter()
		{
		}

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x10")]
		private DateTimeStyles _dateTimeStyles;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x18")]
		private string _dateTimeFormat;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x20")]
		private CultureInfo _culture;
	}
}
