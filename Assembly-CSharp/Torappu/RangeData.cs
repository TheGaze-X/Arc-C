using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x0200112B RID: 4395
	[Token(Token = "0x200112B")]
	[Serializable]
	public class RangeData
	{
		// Token: 0x06006EF2 RID: 28402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF2")]
		[Address(RVA = "0x210E7C0", Offset = "0x210D3C0", VA = "0x18210E7C0")]
		public void OnInit()
		{
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF3")]
		[Address(RVA = "0x210E7D0", Offset = "0x210D3D0", VA = "0x18210E7D0")]
		private void _ConstructBoundingBoxes()
		{
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x000323E8 File Offset: 0x000305E8
		[Token(Token = "0x6006EF4")]
		[Address(RVA = "0x210EE30", Offset = "0x210DA30", VA = "0x18210EE30")]
		private static bool _TryFindBoundingBox(GridPosition min, HashSet<GridPosition> remainingSet, HashSet<GridPosition> allSet, out ObscuredRect rect)
		{
			return default(bool);
		}

		// Token: 0x06006EF5 RID: 28405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF5")]
		[Address(RVA = "0x210F300", Offset = "0x210DF00", VA = "0x18210F300")]
		public RangeData()
		{
		}

		// Token: 0x04005E2B RID: 24107
		[Token(Token = "0x4005E2B")]
		public const SharedConsts.Direction RANGE_STANDARD_DIRECTION = SharedConsts.Direction.UP;

		// Token: 0x04005E2C RID: 24108
		[Token(Token = "0x4005E2C")]
		[FieldOffset(Offset = "0x0")]
		private static List<GridPosition> s_sharedList;

		// Token: 0x04005E2D RID: 24109
		[Token(Token = "0x4005E2D")]
		[FieldOffset(Offset = "0x8")]
		private static HashSet<GridPosition> s_sharedRemainingSet;

		// Token: 0x04005E2E RID: 24110
		[Token(Token = "0x4005E2E")]
		[FieldOffset(Offset = "0x10")]
		private static HashSet<GridPosition> s_sharedAllSet;

		// Token: 0x04005E2F RID: 24111
		[Token(Token = "0x4005E2F")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005E30 RID: 24112
		[Token(Token = "0x4005E30")]
		[FieldOffset(Offset = "0x18")]
		public SharedConsts.Direction direction;

		// Token: 0x04005E31 RID: 24113
		[Token(Token = "0x4005E31")]
		[FieldOffset(Offset = "0x20")]
		public List<GridPosition> grids;

		// Token: 0x04005E32 RID: 24114
		[Token(Token = "0x4005E32")]
		[FieldOffset(Offset = "0x28")]
		[JsonIgnore]
		[NonSerialized]
		public List<ObscuredRect> boundingBoxes;
	}
}
