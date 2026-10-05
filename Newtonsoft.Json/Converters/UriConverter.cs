using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	public class UriConverter : JsonConverter
	{
		// Token: 0x06000A4F RID: 2639 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x4DF06C0", Offset = "0x4DEF2C0", VA = "0x184DF06C0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x4DF0730", Offset = "0x4DEF330", VA = "0x184DF0730", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x4DF0890", Offset = "0x4DEF490", VA = "0x184DF0890", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public UriConverter()
		{
		}
	}
}
