using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x020018E9 RID: 6377
	[Token(Token = "0x20018E9")]
	public class FurnitureGenreConfig : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A0D6 RID: 41174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D6")]
		[Address(RVA = "0x31B0790", Offset = "0x31AF390", VA = "0x1831B0790")]
		public FurnitureGenreConfig()
		{
		}

		// Token: 0x04009732 RID: 38706
		[Token(Token = "0x4009732")]
		[FieldOffset(Offset = "0x18")]
		public FurnitureGenreConfig.FurnitureGenre[] genres;

		// Token: 0x04009733 RID: 38707
		[Token(Token = "0x4009733")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020018EA RID: 6378
		[Token(Token = "0x20018EA")]
		[Serializable]
		public class FurnitureGenre
		{
			// Token: 0x0600A0D7 RID: 41175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A0D7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FurnitureGenre()
			{
			}

			// Token: 0x04009734 RID: 38708
			[Token(Token = "0x4009734")]
			[FieldOffset(Offset = "0x10")]
			public List<BuildingData.FurnitureType> furnitureTypes;
		}
	}
}
