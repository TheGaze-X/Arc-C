using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020023A6 RID: 9126
	[Token(Token = "0x20023A6")]
	public struct TileWithWeight : IItemWithWeight
	{
		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x0600E781 RID: 59265 RVA: 0x000545B8 File Offset: 0x000527B8
		// (set) Token: 0x0600E782 RID: 59266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D12")]
		public float weightValue
		{
			[Token(Token = "0x600E781")]
			[Address(RVA = "0x5DE4D0", Offset = "0x5DD0D0", VA = "0x1805DE4D0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x600E782")]
			[Address(RVA = "0x5DE4E0", Offset = "0x5DD0E0", VA = "0x1805DE4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0400FEF4 RID: 65268
		[Token(Token = "0x400FEF4")]
		[FieldOffset(Offset = "0x0")]
		public Tile tile;
	}
}
