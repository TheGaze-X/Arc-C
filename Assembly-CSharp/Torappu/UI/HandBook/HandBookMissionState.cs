using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006670 RID: 26224
	[Token(Token = "0x2006670")]
	public class HandBookMissionState : PopupFloatState
	{
		// Token: 0x06025A70 RID: 154224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A70")]
		[Address(RVA = "0x209BAB0", Offset = "0x209A6B0", VA = "0x18209BAB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025A71 RID: 154225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A71")]
		[Address(RVA = "0x209BB10", Offset = "0x209A710", VA = "0x18209BB10")]
		public void OnCollectionRequest(string id)
		{
		}

		// Token: 0x06025A72 RID: 154226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A72")]
		[Address(RVA = "0x209C360", Offset = "0x209AF60", VA = "0x18209C360")]
		private IEnumerator _ReceiveItemsCoroutine(List<HandBookMissionReward> rewardList)
		{
			return null;
		}

		// Token: 0x06025A73 RID: 154227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A73")]
		[Address(RVA = "0x209BE00", Offset = "0x209AA00", VA = "0x18209BE00", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06025A74 RID: 154228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A74")]
		[Address(RVA = "0x209C040", Offset = "0x209AC40", VA = "0x18209C040")]
		public void RefreshData()
		{
		}

		// Token: 0x06025A75 RID: 154229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A75")]
		[Address(RVA = "0x209BD90", Offset = "0x209A990", VA = "0x18209BD90", Slot = "29")]
		protected override void OnPopup()
		{
		}

		// Token: 0x06025A76 RID: 154230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A76")]
		[Address(RVA = "0x209BD20", Offset = "0x209A920", VA = "0x18209BD20", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06025A77 RID: 154231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A77")]
		[Address(RVA = "0x209C430", Offset = "0x209B030", VA = "0x18209C430")]
		public HandBookMissionState()
		{
		}

		// Token: 0x06025A79 RID: 154233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A79")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06025A7A RID: 154234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A7A")]
		[Address(RVA = "0x209C350", Offset = "0x209AF50", VA = "0x18209C350")]
		private void <>xLuaBaseProxy_OnPopup()
		{
		}

		// Token: 0x06025A7B RID: 154235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A7B")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04034E4F RID: 216655
		[Token(Token = "0x4034E4F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HandBookMissionStateBean _stateBean;

		// Token: 0x04034E50 RID: 216656
		[Token(Token = "0x4034E50")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HandBookMissionGroup _missionGroup;

		// Token: 0x04034E51 RID: 216657
		[Token(Token = "0x4034E51")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _missionContainer;

		// Token: 0x04034E52 RID: 216658
		[Token(Token = "0x4034E52")]
		[FieldOffset(Offset = "0x88")]
		private bool m_notFromEnterFlag;

		// Token: 0x04034E53 RID: 216659
		[Token(Token = "0x4034E53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034E54 RID: 216660
		[Token(Token = "0x4034E54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCollectionRequest;

		// Token: 0x04034E55 RID: 216661
		[Token(Token = "0x4034E55")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04034E56 RID: 216662
		[Token(Token = "0x4034E56")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04034E57 RID: 216663
		[Token(Token = "0x4034E57")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04034E58 RID: 216664
		[Token(Token = "0x4034E58")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPopup;

		// Token: 0x04034E59 RID: 216665
		[Token(Token = "0x4034E59")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04034E5A RID: 216666
		[Token(Token = "0x4034E5A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
