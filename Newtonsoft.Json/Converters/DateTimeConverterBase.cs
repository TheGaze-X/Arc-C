using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	[Preserve]
	public abstract class DateTimeConverterBase : JsonConverter
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x4DDEA60", Offset = "0x4DDD660", VA = "0x184DDEA60", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected DateTimeConverterBase()
		{
		}
	}
}
