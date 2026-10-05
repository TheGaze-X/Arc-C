using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	public class Matrix4x4Converter : JsonConverter
	{
		// Token: 0x06000A27 RID: 2599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x4DE87E0", Offset = "0x4DE73E0", VA = "0x184DE87E0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x4DE8360", Offset = "0x4DE6F60", VA = "0x184DE8360", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x170001CF")]
		public override bool CanRead
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x4DE82F0", Offset = "0x4DE6EF0", VA = "0x184DE82F0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public Matrix4x4Converter()
		{
		}
	}
}
