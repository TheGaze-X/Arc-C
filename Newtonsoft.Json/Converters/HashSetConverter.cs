using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	public class HashSetConverter : JsonConverter
	{
		// Token: 0x06000A18 RID: 2584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x4DDEDD0", Offset = "0x4DDD9D0", VA = "0x184DDEDD0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x4DDED10", Offset = "0x4DDD910", VA = "0x184DDED10", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x170001CE")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public HashSetConverter()
		{
		}
	}
}
