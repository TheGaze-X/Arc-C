using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069D1 RID: 27089
	[Token(Token = "0x20069D1")]
	public class ZoneRecordDiffRewardItemAdapter : SimpleLayoutAdapter
	{
		// Token: 0x17005B79 RID: 23417
		// (get) Token: 0x06026C19 RID: 158745 RVA: 0x000CC300 File Offset: 0x000CA500
		[Token(Token = "0x17005B79")]
		public override int count
		{
			[Token(Token = "0x6026C19")]
			[Address(RVA = "0x21DE460", Offset = "0x21DD060", VA = "0x1821DE460", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06026C1A RID: 158746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C1A")]
		[Address(RVA = "0x21DE1C0", Offset = "0x21DCDC0", VA = "0x1821DE1C0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06026C1B RID: 158747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C1B")]
		[Address(RVA = "0x21DE3B0", Offset = "0x21DCFB0", VA = "0x1821DE3B0")]
		public ZoneRecordDiffRewardItemAdapter()
		{
		}

		// Token: 0x04036BE4 RID: 224228
		[Token(Token = "0x4036BE4")]
		[FieldOffset(Offset = "0x20")]
		public List<ZoneRecordRewardViewModel> rewardViewModels;

		// Token: 0x04036BE5 RID: 224229
		[Token(Token = "0x4036BE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04036BE6 RID: 224230
		[Token(Token = "0x4036BE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04036BE7 RID: 224231
		[Token(Token = "0x4036BE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
