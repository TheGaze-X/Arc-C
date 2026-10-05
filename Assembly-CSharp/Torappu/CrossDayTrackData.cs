using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FE2 RID: 4066
	[Token(Token = "0x2000FE2")]
	[Serializable]
	public class CrossDayTrackData
	{
		// Token: 0x06006D38 RID: 27960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D38")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrossDayTrackData()
		{
		}

		// Token: 0x04005638 RID: 22072
		[Token(Token = "0x4005638")]
		[FieldOffset(Offset = "0x10")]
		public long updateEndTs;

		// Token: 0x04005639 RID: 22073
		[Token(Token = "0x4005639")]
		[FieldOffset(Offset = "0x18")]
		public string id;
	}
}
