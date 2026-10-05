using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	[Preserve]
	public class JavaScriptDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x06000A70 RID: 2672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x4DE7530", Offset = "0x4DE6130", VA = "0x184DE7530", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x4DE6FE0", Offset = "0x4DE5BE0", VA = "0x184DE6FE0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public JavaScriptDateTimeConverter()
		{
		}
	}
}
