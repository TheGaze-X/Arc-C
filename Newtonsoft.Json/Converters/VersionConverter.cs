using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	[Preserve]
	public class VersionConverter : JsonConverter
	{
		// Token: 0x06000A63 RID: 2659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x4DF1DB0", Offset = "0x4DF09B0", VA = "0x184DF1DB0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x4DF1B10", Offset = "0x4DF0710", VA = "0x184DF1B10", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00005F40 File Offset: 0x00004140
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x4DF1AA0", Offset = "0x4DF06A0", VA = "0x184DF1AA0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public VersionConverter()
		{
		}
	}
}
