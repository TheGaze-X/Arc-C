using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D19 RID: 23833
	[Token(Token = "0x2005D19")]
	public class ClimbTowerEndTrapViewModel : IHotfixable
	{
		// Token: 0x06022832 RID: 141362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022832")]
		[Address(RVA = "0x1CFE1E0", Offset = "0x1CFCDE0", VA = "0x181CFE1E0")]
		public void LoadTrap(ClimbTowerEndTrapViewModel.Type trapType, string trapId)
		{
		}

		// Token: 0x06022833 RID: 141363 RVA: 0x000BDAF8 File Offset: 0x000BBCF8
		[Token(Token = "0x6022833")]
		[Address(RVA = "0x1CFE100", Offset = "0x1CFCD00", VA = "0x181CFE100")]
		public int CompareTo(ClimbTowerEndTrapViewModel r)
		{
			return 0;
		}

		// Token: 0x06022834 RID: 141364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022834")]
		[Address(RVA = "0x1CFE2A0", Offset = "0x1CFCEA0", VA = "0x181CFE2A0")]
		public ClimbTowerEndTrapViewModel()
		{
		}

		// Token: 0x0402F6E6 RID: 194278
		[Token(Token = "0x402F6E6")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerEndTrapViewModel.Type type;

		// Token: 0x0402F6E7 RID: 194279
		[Token(Token = "0x402F6E7")]
		[FieldOffset(Offset = "0x18")]
		public Sprite imgTrap;

		// Token: 0x0402F6E8 RID: 194280
		[Token(Token = "0x402F6E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadTrap;

		// Token: 0x0402F6E9 RID: 194281
		[Token(Token = "0x402F6E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402F6EA RID: 194282
		[Token(Token = "0x402F6EA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D1A RID: 23834
		[Token(Token = "0x2005D1A")]
		public enum Type
		{
			// Token: 0x0402F6EC RID: 194284
			[Token(Token = "0x402F6EC")]
			NONE,
			// Token: 0x0402F6ED RID: 194285
			[Token(Token = "0x402F6ED")]
			NORMAL,
			// Token: 0x0402F6EE RID: 194286
			[Token(Token = "0x402F6EE")]
			CURSECARD
		}
	}
}
