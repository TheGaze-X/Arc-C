using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	public class QuaternionConverter : JsonConverter
	{
		// Token: 0x06000A2C RID: 2604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x4DE9B00", Offset = "0x4DE8700", VA = "0x184DE9B00", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x4DE92E0", Offset = "0x4DE7EE0", VA = "0x184DE92E0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x4DE9350", Offset = "0x4DE7F50", VA = "0x184DE9350", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x170001D0")]
		public override bool CanRead
		{
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public QuaternionConverter()
		{
		}
	}
}
