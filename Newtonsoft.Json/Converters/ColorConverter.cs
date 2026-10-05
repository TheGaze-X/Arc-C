using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	public class ColorConverter : JsonConverter
	{
		// Token: 0x06000A05 RID: 2565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x4DDE470", Offset = "0x4DDD070", VA = "0x184DDE470", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x4DDE090", Offset = "0x4DDCC90", VA = "0x184DDE090", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x4DDE140", Offset = "0x4DDCD40", VA = "0x184DDE140", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x170001CB")]
		public override bool CanRead
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ColorConverter()
		{
		}
	}
}
