using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D60 RID: 28000
	[Token(Token = "0x2006D60")]
	[RequireComponent(typeof(StageCustomZoneContainer))]
	public class ActivityCustomZoneContainerAssetHolder : ActivityAssetHolder
	{
		// Token: 0x06027E7A RID: 163450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E7A")]
		[Address(RVA = "0x233B620", Offset = "0x233A220", VA = "0x18233B620", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027E7B RID: 163451 RVA: 0x000CFE10 File Offset: 0x000CE010
		[Token(Token = "0x6027E7B")]
		[Address(RVA = "0x233B810", Offset = "0x233A410", VA = "0x18233B810", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027E7C RID: 163452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E7C")]
		[Address(RVA = "0x233B8F0", Offset = "0x233A4F0", VA = "0x18233B8F0")]
		public ActivityCustomZoneContainerAssetHolder()
		{
		}

		// Token: 0x06027E7D RID: 163453 RVA: 0x000CFE28 File Offset: 0x000CE028
		[Token(Token = "0x6027E7D")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x04038906 RID: 231686
		[Token(Token = "0x4038906")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ActivityCustomZoneMapHolder> _zoneHolders;

		// Token: 0x04038907 RID: 231687
		[Token(Token = "0x4038907")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x04038908 RID: 231688
		[Token(Token = "0x4038908")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x04038909 RID: 231689
		[Token(Token = "0x4038909")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
