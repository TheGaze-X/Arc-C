using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main11
{
	// Token: 0x02006A33 RID: 27187
	[Token(Token = "0x2006A33")]
	public class Main11ZoneRecordController : ZoneRecordController
	{
		// Token: 0x06026DC2 RID: 159170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DC2")]
		[Address(RVA = "0x21F5190", Offset = "0x21F3D90", VA = "0x1821F5190", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06026DC3 RID: 159171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DC3")]
		[Address(RVA = "0x21F5650", Offset = "0x21F4250", VA = "0x1821F5650", Slot = "5")]
		public override void OnEnter(string zoneId)
		{
		}

		// Token: 0x06026DC4 RID: 159172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DC4")]
		[Address(RVA = "0x21F5870", Offset = "0x21F4470", VA = "0x1821F5870", Slot = "6")]
		public override void OnResume(bool isFromStack)
		{
		}

		// Token: 0x06026DC5 RID: 159173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DC5")]
		[Address(RVA = "0x21F5A10", Offset = "0x21F4610", VA = "0x1821F5A10")]
		private void _JumpToRecordPageByIdx(int idx)
		{
		}

		// Token: 0x06026DC6 RID: 159174 RVA: 0x000CC8A0 File Offset: 0x000CAAA0
		[Token(Token = "0x6026DC6")]
		[Address(RVA = "0x21F5950", Offset = "0x21F4550", VA = "0x1821F5950")]
		private bool _CheckIfRecordUnlockAndShowToast(ZoneRecordViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06026DC7 RID: 159175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DC7")]
		[Address(RVA = "0x21F5E00", Offset = "0x21F4A00", VA = "0x1821F5E00")]
		private void _OnPrevBtnClick()
		{
		}

		// Token: 0x06026DC8 RID: 159176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DC8")]
		[Address(RVA = "0x21F5D30", Offset = "0x21F4930", VA = "0x1821F5D30")]
		private void _OnNextBtnClick()
		{
		}

		// Token: 0x06026DC9 RID: 159177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DC9")]
		[Address(RVA = "0x21F5F00", Offset = "0x21F4B00", VA = "0x1821F5F00")]
		private void _OnRecordItemBtnClick(string recordId)
		{
		}

		// Token: 0x06026DCA RID: 159178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DCA")]
		[Address(RVA = "0x21F5C90", Offset = "0x21F4890", VA = "0x1821F5C90")]
		private void _OnClaimAllRewardClick()
		{
		}

		// Token: 0x06026DCB RID: 159179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DCB")]
		[Address(RVA = "0x21F5B80", Offset = "0x21F4780", VA = "0x1821F5B80")]
		private void _OnBtnBackClick()
		{
		}

		// Token: 0x06026DCC RID: 159180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DCC")]
		[Address(RVA = "0x21F5B10", Offset = "0x21F4710", VA = "0x1821F5B10")]
		private void _OnAllRewardBtnClicked()
		{
		}

		// Token: 0x06026DCD RID: 159181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DCD")]
		[Address(RVA = "0x21F6000", Offset = "0x21F4C00", VA = "0x1821F6000")]
		public Main11ZoneRecordController()
		{
		}

		// Token: 0x06026DCE RID: 159182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DCE")]
		[Address(RVA = "0x21EDAA0", Offset = "0x21EC6A0", VA = "0x1821EDAA0")]
		private void <>xLuaBaseProxy_Init()
		{
		}

		// Token: 0x06026DCF RID: 159183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DCF")]
		[Address(RVA = "0x21EDAB0", Offset = "0x21EC6B0", VA = "0x1821EDAB0")]
		private void <>xLuaBaseProxy_OnEnter(string P0)
		{
		}

		// Token: 0x06026DD0 RID: 159184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DD0")]
		[Address(RVA = "0x21EDAC0", Offset = "0x21EC6C0", VA = "0x1821EDAC0")]
		private void <>xLuaBaseProxy_OnResume(bool P0)
		{
		}

		// Token: 0x04036F27 RID: 225063
		[Token(Token = "0x4036F27")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04036F28 RID: 225064
		[Token(Token = "0x4036F28")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Main11RecordAllRewardsView _rewardsView;

		// Token: 0x04036F29 RID: 225065
		[Token(Token = "0x4036F29")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIBlurFloatPanel _panelReward;

		// Token: 0x04036F2A RID: 225066
		[Token(Token = "0x4036F2A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Main11RecordHomeView _homeView;

		// Token: 0x04036F2B RID: 225067
		[Token(Token = "0x4036F2B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Main11RecordNoteView _noteView;

		// Token: 0x04036F2C RID: 225068
		[Token(Token = "0x4036F2C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04036F2D RID: 225069
		[Token(Token = "0x4036F2D")]
		[FieldOffset(Offset = "0x60")]
		private Main11ZoneRecordViewProperty m_recordProperty;

		// Token: 0x04036F2E RID: 225070
		[Token(Token = "0x4036F2E")]
		[FieldOffset(Offset = "0x68")]
		private ZoneRecordGroupData m_cachedGroupData;

		// Token: 0x04036F2F RID: 225071
		[Token(Token = "0x4036F2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04036F30 RID: 225072
		[Token(Token = "0x4036F30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036F31 RID: 225073
		[Token(Token = "0x4036F31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04036F32 RID: 225074
		[Token(Token = "0x4036F32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__JumpToRecordPageByIdx;

		// Token: 0x04036F33 RID: 225075
		[Token(Token = "0x4036F33")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfRecordUnlockAndShowToast;

		// Token: 0x04036F34 RID: 225076
		[Token(Token = "0x4036F34")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnPrevBtnClick;

		// Token: 0x04036F35 RID: 225077
		[Token(Token = "0x4036F35")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnNextBtnClick;

		// Token: 0x04036F36 RID: 225078
		[Token(Token = "0x4036F36")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnRecordItemBtnClick;

		// Token: 0x04036F37 RID: 225079
		[Token(Token = "0x4036F37")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnClaimAllRewardClick;

		// Token: 0x04036F38 RID: 225080
		[Token(Token = "0x4036F38")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnBtnBackClick;

		// Token: 0x04036F39 RID: 225081
		[Token(Token = "0x4036F39")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnAllRewardBtnClicked;

		// Token: 0x04036F3A RID: 225082
		[Token(Token = "0x4036F3A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
