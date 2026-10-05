using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006943 RID: 26947
	[Token(Token = "0x2006943")]
	public class StageZoneSeasonAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x06026953 RID: 158035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026953")]
		[Address(RVA = "0x21B9080", Offset = "0x21B7C80", VA = "0x1821B9080", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06026954 RID: 158036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026954")]
		[Address(RVA = "0x21B91B0", Offset = "0x21B7DB0", VA = "0x1821B91B0")]
		public void UpdateViews()
		{
		}

		// Token: 0x06026955 RID: 158037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026955")]
		[Address(RVA = "0x21B9370", Offset = "0x21B7F70", VA = "0x1821B9370")]
		public StageZoneSeasonAdapter()
		{
		}

		// Token: 0x040366E0 RID: 222944
		[Token(Token = "0x40366E0")]
		[FieldOffset(Offset = "0x18")]
		public List<UIRecycleLayoutAdapter.IVirtualView> views;

		// Token: 0x040366E1 RID: 222945
		[Token(Token = "0x40366E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x040366E2 RID: 222946
		[Token(Token = "0x40366E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateViews;

		// Token: 0x040366E3 RID: 222947
		[Token(Token = "0x40366E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
