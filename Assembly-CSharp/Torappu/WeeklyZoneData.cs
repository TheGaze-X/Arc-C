using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020013C2 RID: 5058
	[Token(Token = "0x20013C2")]
	[Serializable]
	public class WeeklyZoneData
	{
		// Token: 0x060073B2 RID: 29618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WeeklyZoneData()
		{
		}

		// Token: 0x0400707D RID: 28797
		[Token(Token = "0x400707D")]
		[FieldOffset(Offset = "0x10")]
		public int[] daysOfWeek;

		// Token: 0x0400707E RID: 28798
		[Token(Token = "0x400707E")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public WeeklyType type;
	}
}
