using System;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	[Preserve]
	public class RegexConverter : JsonConverter
	{
		// Token: 0x06000A38 RID: 2616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x4DEAC60", Offset = "0x4DE9860", VA = "0x184DEAC60", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x4BBDDE0", Offset = "0x4BBC9E0", VA = "0x184BBDDE0")]
		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			return default(bool);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x4DEA8A0", Offset = "0x4DE94A0", VA = "0x184DEA8A0")]
		private void WriteBson(BsonWriter writer, Regex regex)
		{
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x4DEA9F0", Offset = "0x4DE95F0", VA = "0x184DEA9F0")]
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x4DEA200", Offset = "0x4DE8E00", VA = "0x184DEA200", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x4DEA720", Offset = "0x4DE9320", VA = "0x184DEA720")]
		private object ReadRegexString(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x4DEA430", Offset = "0x4DE9030", VA = "0x184DEA430")]
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x4DEA190", Offset = "0x4DE8D90", VA = "0x184DEA190", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RegexConverter()
		{
		}

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		private const string PatternName = "Pattern";

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		private const string OptionsName = "Options";
	}
}
