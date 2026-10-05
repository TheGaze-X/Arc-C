using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013D6 RID: 5078
	[Token(Token = "0x20013D6")]
	public class ObscuredIntConverter : JsonConverter
	{
		// Token: 0x060073E0 RID: 29664 RVA: 0x00033828 File Offset: 0x00031A28
		[Token(Token = "0x60073E0")]
		[Address(RVA = "0x2208BF0", Offset = "0x22077F0", VA = "0x182208BF0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E1")]
		[Address(RVA = "0x2208C90", Offset = "0x2207890", VA = "0x182208C90", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E2")]
		[Address(RVA = "0x2208D30", Offset = "0x2207930", VA = "0x182208D30", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x060073E3 RID: 29667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E3")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ObscuredIntConverter()
		{
		}
	}
}
