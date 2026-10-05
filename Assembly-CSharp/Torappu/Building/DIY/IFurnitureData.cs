using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY
{
	// Token: 0x020018CD RID: 6349
	[Token(Token = "0x20018CD")]
	public interface IFurnitureData : IDIYItem, IHotfixable
	{
		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x0600A02B RID: 41003
		[Token(Token = "0x1700123B")]
		int dimX { [Token(Token = "0x600A02B")] get; }

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x0600A02C RID: 41004
		[Token(Token = "0x1700123C")]
		int dimY { [Token(Token = "0x600A02C")] get; }

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x0600A02D RID: 41005
		[Token(Token = "0x1700123D")]
		int dimZ { [Token(Token = "0x600A02D")] get; }

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x0600A02E RID: 41006
		[Token(Token = "0x1700123E")]
		FurnitureLocationType locationType { [Token(Token = "0x600A02E")] get; }

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x0600A02F RID: 41007
		[Token(Token = "0x1700123F")]
		FurnitureInteractType interactType { [Token(Token = "0x600A02F")] get; }

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x0600A030 RID: 41008
		[Token(Token = "0x17001240")]
		BuildingData.FurnitureType furniType { [Token(Token = "0x600A030")] get; }

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x0600A031 RID: 41009
		[Token(Token = "0x17001241")]
		BuildingData.FurnitureSubType subType { [Token(Token = "0x600A031")] get; }

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x0600A032 RID: 41010
		[Token(Token = "0x17001242")]
		string musicId { [Token(Token = "0x600A032")] get; }

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600A033 RID: 41011
		[Token(Token = "0x17001243")]
		bool validOnRotate { [Token(Token = "0x600A033")] get; }

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600A034 RID: 41012
		[Token(Token = "0x17001244")]
		bool enableRotate { [Token(Token = "0x600A034")] get; }

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600A035 RID: 41013
		[Token(Token = "0x17001245")]
		GameObject prefab { [Token(Token = "0x600A035")] get; }
	}
}
