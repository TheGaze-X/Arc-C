using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	public class EnumerableVectorConverter<T> : JsonConverter
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A12")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x6000A13")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A14")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x170001CD")]
		public override bool CanRead
		{
			[Token(Token = "0x6000A15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A16")]
		public EnumerableVectorConverter()
		{
		}

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly VectorConverter VectorConverter;
	}
}
