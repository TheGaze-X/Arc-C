using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013DB RID: 5083
	[Token(Token = "0x20013DB")]
	public class InterningStringConverter : JsonConverter
	{
		// Token: 0x060073F4 RID: 29684 RVA: 0x000338A0 File Offset: 0x00031AA0
		[Token(Token = "0x60073F4")]
		[Address(RVA = "0x22065D0", Offset = "0x22051D0", VA = "0x1822065D0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073F5")]
		[Address(RVA = "0x2206670", Offset = "0x2205270", VA = "0x182206670", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F6")]
		[Address(RVA = "0x2206740", Offset = "0x2205340", VA = "0x182206740", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F7")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public InterningStringConverter()
		{
		}

		// Token: 0x040070D2 RID: 28882
		[Token(Token = "0x40070D2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StringDedupEntry s_dedupEntry;
	}
}
