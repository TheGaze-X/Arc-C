using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000581 RID: 1409
	[Token(Token = "0x2000581")]
	[System.Serializable]
	internal class EraInfo
	{
		// Token: 0x06002999 RID: 10649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002999")]
		[Address(RVA = "0x4C2F1D0", Offset = "0x4C2DDD0", VA = "0x184C2F1D0")]
		internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear)
		{
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299A")]
		[Address(RVA = "0x4C2F0C0", Offset = "0x4C2DCC0", VA = "0x184C2F0C0")]
		internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName)
		{
		}

		// Token: 0x04001832 RID: 6194
		[Token(Token = "0x4001832")]
		[FieldOffset(Offset = "0x10")]
		internal int era;

		// Token: 0x04001833 RID: 6195
		[Token(Token = "0x4001833")]
		[FieldOffset(Offset = "0x18")]
		internal long ticks;

		// Token: 0x04001834 RID: 6196
		[Token(Token = "0x4001834")]
		[FieldOffset(Offset = "0x20")]
		internal int yearOffset;

		// Token: 0x04001835 RID: 6197
		[Token(Token = "0x4001835")]
		[FieldOffset(Offset = "0x24")]
		internal int minEraYear;

		// Token: 0x04001836 RID: 6198
		[Token(Token = "0x4001836")]
		[FieldOffset(Offset = "0x28")]
		internal int maxEraYear;

		// Token: 0x04001837 RID: 6199
		[Token(Token = "0x4001837")]
		[FieldOffset(Offset = "0x30")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		internal string eraName;

		// Token: 0x04001838 RID: 6200
		[Token(Token = "0x4001838")]
		[FieldOffset(Offset = "0x38")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		internal string abbrevEraName;

		// Token: 0x04001839 RID: 6201
		[Token(Token = "0x4001839")]
		[FieldOffset(Offset = "0x40")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		internal string englishEraName;
	}
}
