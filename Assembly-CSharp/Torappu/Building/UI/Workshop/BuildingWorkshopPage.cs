using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BC0 RID: 7104
	[Token(Token = "0x2001BC0")]
	public class BuildingWorkshopPage : BuildingCommonPage
	{
		// Token: 0x0600B136 RID: 45366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B136")]
		[Address(RVA = "0x32C6DC0", Offset = "0x32C59C0", VA = "0x1832C6DC0")]
		public BuildingWorkshopModel GenRefreshModel(BuildingWorkshopPage.InputParam inputParam)
		{
			return null;
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B137")]
		[Address(RVA = "0x32C6F60", Offset = "0x32C5B60", VA = "0x1832C6F60")]
		public void RefreshView(object param)
		{
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B138")]
		[Address(RVA = "0x32C7250", Offset = "0x32C5E50", VA = "0x1832C7250")]
		private IEnumerator _ResetToTargetItem(List<StateCache> stateCacheList)
		{
			return null;
		}

		// Token: 0x0600B139 RID: 45369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B139")]
		[Address(RVA = "0x32C7320", Offset = "0x32C5F20", VA = "0x1832C7320")]
		public BuildingWorkshopPage()
		{
		}

		// Token: 0x0400AB8D RID: 43917
		[Token(Token = "0x400AB8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenRefreshModel;

		// Token: 0x0400AB8E RID: 43918
		[Token(Token = "0x400AB8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x0400AB8F RID: 43919
		[Token(Token = "0x400AB8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetToTargetItem;

		// Token: 0x0400AB90 RID: 43920
		[Token(Token = "0x400AB90")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001BC1 RID: 7105
		[Token(Token = "0x2001BC1")]
		public struct InputParam
		{
			// Token: 0x0400AB91 RID: 43921
			[Token(Token = "0x400AB91")]
			[FieldOffset(Offset = "0x0")]
			public string slotId;

			// Token: 0x0400AB92 RID: 43922
			[Token(Token = "0x400AB92")]
			[FieldOffset(Offset = "0x8")]
			public BuildingWorkshopModel.TargetItemInfo targetItemInfo;
		}
	}
}
