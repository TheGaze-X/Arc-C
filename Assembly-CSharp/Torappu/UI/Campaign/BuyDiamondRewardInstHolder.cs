using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006131 RID: 24881
	[Token(Token = "0x2006131")]
	public class BuyDiamondRewardInstHolder : DynamicPrefabInstHolder, IHotfixable
	{
		// Token: 0x06023ED4 RID: 147156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023ED4")]
		[Address(RVA = "0x1E831E0", Offset = "0x1E81DE0", VA = "0x181E831E0", Slot = "4")]
		public override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x06023ED5 RID: 147157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ED5")]
		[Address(RVA = "0x1E83280", Offset = "0x1E81E80", VA = "0x181E83280")]
		public BuyDiamondRewardInstHolder()
		{
		}

		// Token: 0x04031DEA RID: 204266
		[Token(Token = "0x4031DEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x04031DEB RID: 204267
		[Token(Token = "0x4031DEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
