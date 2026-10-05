using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002642 RID: 9794
	[Token(Token = "0x2002642")]
	public struct AdditionalBuildCondition
	{
		// Token: 0x04011CF1 RID: 72945
		[Token(Token = "0x4011CF1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AdditionalBuildCondition DEFAULT;

		// Token: 0x04011CF2 RID: 72946
		[Token(Token = "0x4011CF2")]
		[FieldOffset(Offset = "0x14")]
		public static readonly AdditionalBuildCondition NONE;

		// Token: 0x04011CF3 RID: 72947
		[Token(Token = "0x4011CF3")]
		[FieldOffset(Offset = "0x28")]
		public static readonly AdditionalBuildCondition ALL;

		// Token: 0x04011CF4 RID: 72948
		[Token(Token = "0x4011CF4")]
		[FieldOffset(Offset = "0x0")]
		public BuildableType additionalBuildableType;

		// Token: 0x04011CF5 RID: 72949
		[Token(Token = "0x4011CF5")]
		[FieldOffset(Offset = "0x4")]
		public AdvancedBuildableMask additionalAdvancedBuildableMask;

		// Token: 0x04011CF6 RID: 72950
		[Token(Token = "0x4011CF6")]
		[FieldOffset(Offset = "0x8")]
		public bool excludeNoTargetTile;

		// Token: 0x04011CF7 RID: 72951
		[Token(Token = "0x4011CF7")]
		[FieldOffset(Offset = "0x9")]
		public bool excludeOccupiedByWalkEnemy;

		// Token: 0x04011CF8 RID: 72952
		[Token(Token = "0x4011CF8")]
		[FieldOffset(Offset = "0xA")]
		public bool allowWalkEnemyInHostRange;

		// Token: 0x04011CF9 RID: 72953
		[Token(Token = "0x4011CF9")]
		[FieldOffset(Offset = "0xB")]
		public bool checkManuallyBuildableType;

		// Token: 0x04011CFA RID: 72954
		[Token(Token = "0x4011CFA")]
		[FieldOffset(Offset = "0xC")]
		public BuildableType manuallyBuildableType;

		// Token: 0x04011CFB RID: 72955
		[Token(Token = "0x4011CFB")]
		[FieldOffset(Offset = "0x10")]
		public int dynamicBuildConditionMask;
	}
}
