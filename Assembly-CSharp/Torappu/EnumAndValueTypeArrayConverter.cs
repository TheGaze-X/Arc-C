using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013D8 RID: 5080
	[Token(Token = "0x20013D8")]
	public class EnumAndValueTypeArrayConverter : JsonConverter
	{
		// Token: 0x060073E8 RID: 29672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E8")]
		[Address(RVA = "0x22059C0", Offset = "0x22045C0", VA = "0x1822059C0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x060073E9 RID: 29673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E9")]
		[Address(RVA = "0x2205730", Offset = "0x2204330", VA = "0x182205730", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060073EA RID: 29674 RVA: 0x00033858 File Offset: 0x00031A58
		[Token(Token = "0x60073EA")]
		[Address(RVA = "0x2205650", Offset = "0x2204250", VA = "0x182205650", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x060073EB RID: 29675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073EB")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public EnumAndValueTypeArrayConverter()
		{
		}
	}
}
