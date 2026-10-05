using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F93 RID: 3987
	[Token(Token = "0x2000F93")]
	[Serializable]
	public class ClimbTowerLevelDropInfo
	{
		// Token: 0x06006CD1 RID: 27857 RVA: 0x00031A40 File Offset: 0x0002FC40
		[Token(Token = "0x6006CD1")]
		[Address(RVA = "0x1028420", Offset = "0x1027020", VA = "0x181028420")]
		public bool ShouldSerializepassRewards()
		{
			return default(bool);
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x00031A58 File Offset: 0x0002FC58
		[Token(Token = "0x6006CD2")]
		[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0")]
		public bool ShouldSerializedisplayDropInfo()
		{
			return default(bool);
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerLevelDropInfo()
		{
		}

		// Token: 0x040054A5 RID: 21669
		[Token(Token = "0x40054A5")]
		[FieldOffset(Offset = "0x10")]
		public WeightItemBundle[][] passRewards;

		// Token: 0x040054A6 RID: 21670
		[Token(Token = "0x40054A6")]
		[FieldOffset(Offset = "0x18")]
		public List<StageData.DisplayRewards> displayRewards;

		// Token: 0x040054A7 RID: 21671
		[Token(Token = "0x40054A7")]
		[FieldOffset(Offset = "0x20")]
		public List<StageData.DisplayDetailRewards> displayDetailRewards;

		// Token: 0x040054A8 RID: 21672
		[Token(Token = "0x40054A8")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ClimbTowerDropDisplayInfo> displayDropInfo;
	}
}
