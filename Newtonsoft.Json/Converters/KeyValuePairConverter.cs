using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	[Preserve]
	public class KeyValuePairConverter : JsonConverter
	{
		// Token: 0x06000A1D RID: 2589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x4DE78A0", Offset = "0x4DE64A0", VA = "0x184DE78A0")]
		private static ReflectionObject InitializeReflectionObject(Type t)
		{
			return null;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x4DE7F30", Offset = "0x4DE6B30", VA = "0x184DE7F30", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x4DE7B20", Offset = "0x4DE6720", VA = "0x184DE7B20", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x4DE7790", Offset = "0x4DE6390", VA = "0x184DE7790", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public KeyValuePairConverter()
		{
		}

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		private const string KeyName = "Key";

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		private const string ValueName = "Value";

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType;
	}
}
