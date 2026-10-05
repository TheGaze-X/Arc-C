using System;
using Il2CppDummyDll;
using Torappu.UI.HiddenStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D63 RID: 28003
	[Token(Token = "0x2006D63")]
	public class ActivityHiddenStageToastHolder : ActivityAssetHolder
	{
		// Token: 0x06027E88 RID: 163464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E88")]
		[Address(RVA = "0x233C490", Offset = "0x233B090", VA = "0x18233C490", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027E89 RID: 163465 RVA: 0x000CFEB8 File Offset: 0x000CE0B8
		[Token(Token = "0x6027E89")]
		[Address(RVA = "0x233C610", Offset = "0x233B210", VA = "0x18233C610", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027E8A RID: 163466 RVA: 0x000CFED0 File Offset: 0x000CE0D0
		[Token(Token = "0x6027E8A")]
		[Address(RVA = "0x233C6F0", Offset = "0x233B2F0", VA = "0x18233C6F0")]
		public bool TryGetHiddenStageToastPrefab(out HiddenStageMissionNotifyView notifyView)
		{
			return default(bool);
		}

		// Token: 0x06027E8B RID: 163467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E8B")]
		[Address(RVA = "0x233C7D0", Offset = "0x233B3D0", VA = "0x18233C7D0")]
		public ActivityHiddenStageToastHolder()
		{
		}

		// Token: 0x06027E8C RID: 163468 RVA: 0x000CFEE8 File Offset: 0x000CE0E8
		[Token(Token = "0x6027E8C")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x04038914 RID: 231700
		[Token(Token = "0x4038914")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HiddenStageMissionNotifyView _hiddenStageToast;

		// Token: 0x04038915 RID: 231701
		[Token(Token = "0x4038915")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x04038916 RID: 231702
		[Token(Token = "0x4038916")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x04038917 RID: 231703
		[Token(Token = "0x4038917")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetHiddenStageToastPrefab;

		// Token: 0x04038918 RID: 231704
		[Token(Token = "0x4038918")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
