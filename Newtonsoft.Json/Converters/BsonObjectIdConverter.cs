using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	[Preserve]
	public class BsonObjectIdConverter : JsonConverter
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x4DDDF10", Offset = "0x4DDCB10", VA = "0x184DDDF10", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x4DDDD50", Offset = "0x4DDC950", VA = "0x184DDDD50", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x4DDDCE0", Offset = "0x4DDC8E0", VA = "0x184DDDCE0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public BsonObjectIdConverter()
		{
		}
	}
}
