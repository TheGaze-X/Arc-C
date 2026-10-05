using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;

namespace Torappu
{
	// Token: 0x020010E2 RID: 4322
	[Token(Token = "0x20010E2")]
	[Serializable]
	public class TileData
	{
		// Token: 0x06006E86 RID: 28294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E86")]
		[Address(RVA = "0x2116DB0", Offset = "0x21159B0", VA = "0x182116DB0")]
		public TileData DeepClone()
		{
			return null;
		}

		// Token: 0x06006E87 RID: 28295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E87")]
		[Address(RVA = "0x2117090", Offset = "0x2115C90", VA = "0x182117090")]
		public TileData()
		{
		}

		// Token: 0x04005C9E RID: 23710
		[Token(Token = "0x4005C9E")]
		[FieldOffset(Offset = "0x10")]
		public string tileKey;

		// Token: 0x04005C9F RID: 23711
		[Token(Token = "0x4005C9F")]
		[FieldOffset(Offset = "0x18")]
		public TileData.HeightType heightType;

		// Token: 0x04005CA0 RID: 23712
		[Token(Token = "0x4005CA0")]
		[FieldOffset(Offset = "0x1C")]
		public BuildableType buildableType;

		// Token: 0x04005CA1 RID: 23713
		[Token(Token = "0x4005CA1")]
		[FieldOffset(Offset = "0x20")]
		public MotionMask passableMask;

		// Token: 0x04005CA2 RID: 23714
		[Token(Token = "0x4005CA2")]
		[FieldOffset(Offset = "0x24")]
		public PlayerSideMask playerSideMask;

		// Token: 0x04005CA3 RID: 23715
		[Token(Token = "0x4005CA3")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public AdvancedBuildableMask advancedBuildableMask;

		// Token: 0x04005CA4 RID: 23716
		[Token(Token = "0x4005CA4")]
		[FieldOffset(Offset = "0x30")]
		public List<Blackboard.DataPair> blackboard;

		// Token: 0x04005CA5 RID: 23717
		[Token(Token = "0x4005CA5")]
		[FieldOffset(Offset = "0x38")]
		public MapEffectData[] effects;

		// Token: 0x020010E3 RID: 4323
		[Token(Token = "0x20010E3")]
		public enum HeightType
		{
			// Token: 0x04005CA7 RID: 23719
			[Token(Token = "0x4005CA7")]
			LOWLAND,
			// Token: 0x04005CA8 RID: 23720
			[Token(Token = "0x4005CA8")]
			HIGHLAND,
			// Token: 0x04005CA9 RID: 23721
			[Token(Token = "0x4005CA9")]
			E_NUM
		}

		// Token: 0x020010E4 RID: 4324
		[Token(Token = "0x20010E4")]
		[Flags]
		public enum HeightTypeMask
		{
			// Token: 0x04005CAB RID: 23723
			[Token(Token = "0x4005CAB")]
			NONE = 0,
			// Token: 0x04005CAC RID: 23724
			[Token(Token = "0x4005CAC")]
			LOWLAND = 1,
			// Token: 0x04005CAD RID: 23725
			[Token(Token = "0x4005CAD")]
			HIGHLAND = 2,
			// Token: 0x04005CAE RID: 23726
			[Token(Token = "0x4005CAE")]
			ALL = 3
		}
	}
}
