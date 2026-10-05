using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017EC RID: 6124
	[Token(Token = "0x20017EC")]
	[Serializable]
	public class LODPreprocessSettings
	{
		// Token: 0x06009AB8 RID: 39608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB8")]
		[Address(RVA = "0x3160BE0", Offset = "0x315F7E0", VA = "0x183160BE0")]
		public LODPreprocessSettings()
		{
		}

		// Token: 0x04009111 RID: 37137
		[Token(Token = "0x4009111")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<BuildingData.LODLEVEL, FurnitureLodPreprocessSetting> furnitureSetting;
	}
}
