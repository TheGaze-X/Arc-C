using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013D2 RID: 5074
	[Token(Token = "0x20013D2")]
	public class BoolToIntJsonConverter : JsonConverter
	{
		// Token: 0x060073D2 RID: 29650 RVA: 0x000337C8 File Offset: 0x000319C8
		[Token(Token = "0x60073D2")]
		[Address(RVA = "0x21FF370", Offset = "0x21FDF70", VA = "0x1821FF370", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x060073D3 RID: 29651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D3")]
		[Address(RVA = "0x21FF410", Offset = "0x21FE010", VA = "0x1821FF410", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D4")]
		[Address(RVA = "0x21FF4B0", Offset = "0x21FE0B0", VA = "0x1821FF4B0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x060073D5 RID: 29653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D5")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public BoolToIntJsonConverter()
		{
		}
	}
}
