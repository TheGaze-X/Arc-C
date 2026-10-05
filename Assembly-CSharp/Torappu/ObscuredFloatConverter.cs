using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013D7 RID: 5079
	[Token(Token = "0x20013D7")]
	public class ObscuredFloatConverter : JsonConverter
	{
		// Token: 0x060073E4 RID: 29668 RVA: 0x00033840 File Offset: 0x00031A40
		[Token(Token = "0x60073E4")]
		[Address(RVA = "0x22089B0", Offset = "0x22075B0", VA = "0x1822089B0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x060073E5 RID: 29669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E5")]
		[Address(RVA = "0x2208A50", Offset = "0x2207650", VA = "0x182208A50", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060073E6 RID: 29670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E6")]
		[Address(RVA = "0x2208B00", Offset = "0x2207700", VA = "0x182208B00", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x060073E7 RID: 29671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E7")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ObscuredFloatConverter()
		{
		}
	}
}
