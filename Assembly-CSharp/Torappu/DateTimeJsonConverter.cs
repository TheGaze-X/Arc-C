using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013D3 RID: 5075
	[Token(Token = "0x20013D3")]
	public class DateTimeJsonConverter : JsonConverter
	{
		// Token: 0x060073D6 RID: 29654 RVA: 0x000337E0 File Offset: 0x000319E0
		[Token(Token = "0x60073D6")]
		[Address(RVA = "0x2205350", Offset = "0x2203F50", VA = "0x182205350", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x060073D7 RID: 29655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D7")]
		[Address(RVA = "0x22053D0", Offset = "0x2203FD0", VA = "0x1822053D0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060073D8 RID: 29656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D8")]
		[Address(RVA = "0x2205500", Offset = "0x2204100", VA = "0x182205500", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D9")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public DateTimeJsonConverter()
		{
		}
	}
}
