using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	[Preserve]
	public class BinaryConverter : JsonConverter
	{
		// Token: 0x060009FE RID: 2558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x4DDD2D0", Offset = "0x4DDBED0", VA = "0x184DDD2D0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x4DDCB00", Offset = "0x4DDB700", VA = "0x184DDCB00")]
		private byte[] GetByteArray(object value)
		{
			return null;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x4DDC940", Offset = "0x4DDB540", VA = "0x184DDC940")]
		private void EnsureReflectionObject(Type t)
		{
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x4DDCEF0", Offset = "0x4DDBAF0", VA = "0x184DDCEF0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x4DDCC80", Offset = "0x4DDB880", VA = "0x184DDCC80")]
		private byte[] ReadByteArray(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x4DDC8F0", Offset = "0x4DDB4F0", VA = "0x184DDC8F0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public BinaryConverter()
		{
		}

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		private const string BinaryTypeName = "System.Data.Linq.Binary";

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		private const string BinaryToArrayName = "ToArray";

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x10")]
		private ReflectionObject _reflectionObject;
	}
}
