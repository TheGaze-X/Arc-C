using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075EF RID: 30191
	[Token(Token = "0x20075EF")]
	public class Act24sideMissionState : PopupFadeState, IBaseActStateHolder, IHotfixable
	{
		// Token: 0x0602A818 RID: 174104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A818")]
		[Address(RVA = "0x262C7B0", Offset = "0x262B3B0", VA = "0x18262C7B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A819 RID: 174105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A819")]
		[Address(RVA = "0x262C8B0", Offset = "0x262B4B0", VA = "0x18262C8B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A81A RID: 174106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A81A")]
		[Address(RVA = "0x262CB10", Offset = "0x262B710", VA = "0x18262CB10", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602A81B RID: 174107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A81B")]
		[Address(RVA = "0x262CE10", Offset = "0x262BA10", VA = "0x18262CE10", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602A81C RID: 174108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A81C")]
		[Address(RVA = "0x262DA40", Offset = "0x262C640", VA = "0x18262DA40")]
		private void _RefreshData()
		{
		}

		// Token: 0x0602A81D RID: 174109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A81D")]
		[Address(RVA = "0x262DCE0", Offset = "0x262C8E0", VA = "0x18262DCE0")]
		private void _RefreshStageMeldingData()
		{
		}

		// Token: 0x0602A81E RID: 174110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A81E")]
		[Address(RVA = "0x262DBA0", Offset = "0x262C7A0", VA = "0x18262DBA0")]
		private void _RefreshEntryMissionData()
		{
		}

		// Token: 0x0602A81F RID: 174111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A81F")]
		[Address(RVA = "0x262CFD0", Offset = "0x262BBD0", VA = "0x18262CFD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A820 RID: 174112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A820")]
		[Address(RVA = "0x262D880", Offset = "0x262C480", VA = "0x18262D880")]
		private void _OnEnterDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x0602A821 RID: 174113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A821")]
		[Address(RVA = "0x262C730", Offset = "0x262B330", VA = "0x18262C730", Slot = "31")]
		public void BindController(TemplateActivityController controller)
		{
		}

		// Token: 0x0602A822 RID: 174114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A822")]
		[Address(RVA = "0x262CCB0", Offset = "0x262B8B0", VA = "0x18262CCB0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602A823 RID: 174115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A823")]
		[Address(RVA = "0x262D4A0", Offset = "0x262C0A0", VA = "0x18262D4A0")]
		private void _OnClickDetailBtn(string missionId)
		{
		}

		// Token: 0x0602A824 RID: 174116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A824")]
		[Address(RVA = "0x262D200", Offset = "0x262BE00", VA = "0x18262D200")]
		private void _OnClickCompleleBtn(string missionId)
		{
		}

		// Token: 0x0602A825 RID: 174117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A825")]
		[Address(RVA = "0x262D590", Offset = "0x262C190", VA = "0x18262D590")]
		private void _OnClickOneClickBtn()
		{
		}

		// Token: 0x0602A826 RID: 174118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A826")]
		[Address(RVA = "0x262C810", Offset = "0x262B410", VA = "0x18262C810")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x0602A827 RID: 174119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A827")]
		[Address(RVA = "0x262D970", Offset = "0x262C570", VA = "0x18262D970")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602A828 RID: 174120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A828")]
		[Address(RVA = "0x262DE60", Offset = "0x262CA60", VA = "0x18262DE60")]
		public Act24sideMissionState()
		{
		}

		// Token: 0x0602A82C RID: 174124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A82C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602A82D RID: 174125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A82D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602A82E RID: 174126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A82E")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0602A82F RID: 174127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A82F")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403D2F7 RID: 250615
		[Token(Token = "0x403D2F7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act24sideMissionView _view;

		// Token: 0x0403D2F8 RID: 250616
		[Token(Token = "0x403D2F8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0403D2F9 RID: 250617
		[Token(Token = "0x403D2F9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0403D2FA RID: 250618
		[Token(Token = "0x403D2FA")]
		[FieldOffset(Offset = "0x90")]
		private Act24sideMissionStateBean m_stateBean;

		// Token: 0x0403D2FB RID: 250619
		[Token(Token = "0x403D2FB")]
		[FieldOffset(Offset = "0x98")]
		private TemplateActivityController m_cacheController;

		// Token: 0x0403D2FC RID: 250620
		[Token(Token = "0x403D2FC")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_entryTween;

		// Token: 0x0403D2FD RID: 250621
		[Token(Token = "0x403D2FD")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0403D2FE RID: 250622
		[Token(Token = "0x403D2FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D2FF RID: 250623
		[Token(Token = "0x403D2FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D300 RID: 250624
		[Token(Token = "0x403D300")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403D301 RID: 250625
		[Token(Token = "0x403D301")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403D302 RID: 250626
		[Token(Token = "0x403D302")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x0403D303 RID: 250627
		[Token(Token = "0x403D303")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshStageMeldingData;

		// Token: 0x0403D304 RID: 250628
		[Token(Token = "0x403D304")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshEntryMissionData;

		// Token: 0x0403D305 RID: 250629
		[Token(Token = "0x403D305")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D306 RID: 250630
		[Token(Token = "0x403D306")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnEnterDetailState;

		// Token: 0x0403D307 RID: 250631
		[Token(Token = "0x403D307")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x0403D308 RID: 250632
		[Token(Token = "0x403D308")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403D309 RID: 250633
		[Token(Token = "0x403D309")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnClickDetailBtn;

		// Token: 0x0403D30A RID: 250634
		[Token(Token = "0x403D30A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnClickCompleleBtn;

		// Token: 0x0403D30B RID: 250635
		[Token(Token = "0x403D30B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnClickOneClickBtn;

		// Token: 0x0403D30C RID: 250636
		[Token(Token = "0x403D30C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x0403D30D RID: 250637
		[Token(Token = "0x403D30D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403D30E RID: 250638
		[Token(Token = "0x403D30E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
