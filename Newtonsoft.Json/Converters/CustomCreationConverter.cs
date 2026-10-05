using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	[Preserve]
	public abstract class CustomCreationConverter<T> : JsonConverter
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A0A")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0B")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A0C RID: 2572
		[Token(Token = "0x6000A0C")]
		public abstract T Create(Type objectType);

		// Token: 0x06000A0D RID: 2573 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x6000A0D")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x170001CC")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000A0E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A0F")]
		protected CustomCreationConverter()
		{
		}
	}
}
