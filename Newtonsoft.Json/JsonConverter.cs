using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[Preserve]
	public abstract class JsonConverter
	{
		// Token: 0x06000159 RID: 345
		[Token(Token = "0x6000159")]
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

		// Token: 0x0600015A RID: 346
		[Token(Token = "0x600015A")]
		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

		// Token: 0x0600015B RID: 347
		[Token(Token = "0x600015B")]
		public abstract bool CanConvert(Type objectType);

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x17000053")]
		public virtual bool CanRead
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x17000054")]
		public virtual bool CanWrite
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected JsonConverter()
		{
		}
	}
}
