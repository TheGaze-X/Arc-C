using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	public class ResolutionConverter : JsonConverter
	{
		// Token: 0x06000A41 RID: 2625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x4DEB0A0", Offset = "0x4DE9CA0", VA = "0x184DEB0A0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x4DEAEE0", Offset = "0x4DE9AE0", VA = "0x184DEAEE0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x4DEAF50", Offset = "0x4DE9B50", VA = "0x184DEAF50", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00005E20 File Offset: 0x00004020
		[Token(Token = "0x170001D1")]
		public override bool CanRead
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ResolutionConverter()
		{
		}
	}
}
