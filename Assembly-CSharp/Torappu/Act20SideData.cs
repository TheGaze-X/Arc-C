using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CBD RID: 3261
	[Token(Token = "0x2000CBD")]
	public class Act20SideData
	{
		// Token: 0x0600699B RID: 27035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699B")]
		[Address(RVA = "0x1FF4090", Offset = "0x1FF2C90", VA = "0x181FF4090")]
		public Act20SideData()
		{
		}

		// Token: 0x040042A3 RID: 17059
		[Token(Token = "0x40042A3")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, string> zoneAdditionDataMap;

		// Token: 0x040042A4 RID: 17060
		[Token(Token = "0x40042A4")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act20SideData.ResidentCartData> residentCartDatas;

		// Token: 0x02000CBE RID: 3262
		[Token(Token = "0x2000CBE")]
		public class ResidentCartData
		{
			// Token: 0x0600699C RID: 27036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600699C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ResidentCartData()
			{
			}

			// Token: 0x040042A5 RID: 17061
			[Token(Token = "0x40042A5")]
			[FieldOffset(Offset = "0x10")]
			public string residentPic;
		}
	}
}
