using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	[Preserve]
	public class StringEnumConverter : JsonConverter
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00005E38 File Offset: 0x00004038
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D2")]
		public bool CamelCaseText
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00005E50 File Offset: 0x00004050
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D3")]
		public bool AllowIntegerValues
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x4DEBAA0", Offset = "0x4DEA6A0", VA = "0x184DEBAA0")]
		public StringEnumConverter()
		{
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x4DEBA70", Offset = "0x4DEA670", VA = "0x184DEBA70")]
		public StringEnumConverter(bool camelCaseText)
		{
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x4DEB870", Offset = "0x4DEA470", VA = "0x184DEB870", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x4DEB3E0", Offset = "0x4DE9FE0", VA = "0x184DEB3E0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00005E68 File Offset: 0x00004068
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x4DEB370", Offset = "0x4DE9F70", VA = "0x184DEB370", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
}
