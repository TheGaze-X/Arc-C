using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.DataBind;
using Torappu.UI.SandboxPerm.SandboxV2;
using UnityEngine;
using XLua;

namespace Torappu.Scripts.UI.ConstructLand
{
	// Token: 0x020017B4 RID: 6068
	[Token(Token = "0x20017B4")]
	public class ConstructLandPageController : DataBinder<ConstructLandPageProp>
	{
		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06009955 RID: 39253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700107E")]
		public EventPool<ConstructPageMsg.EventFromScene> eventPool
		{
			[Token(Token = "0x6009955")]
			[Address(RVA = "0x3140510", Offset = "0x313F110", VA = "0x183140510")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009956 RID: 39254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009956")]
		[Address(RVA = "0x313DDD0", Offset = "0x313C9D0", VA = "0x18313DDD0")]
		public void Init(ConstructLandPage page)
		{
		}

		// Token: 0x06009957 RID: 39255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009957")]
		[Address(RVA = "0x313E410", Offset = "0x313D010", VA = "0x18313E410", Slot = "7")]
		public override void OnValueChanged(ConstructLandPageProp property)
		{
		}

		// Token: 0x06009958 RID: 39256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009958")]
		[Address(RVA = "0x313FAB0", Offset = "0x313E6B0", VA = "0x18313FAB0")]
		private void _OnSaveBtnClicked(object arg)
		{
		}

		// Token: 0x06009959 RID: 39257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009959")]
		[Address(RVA = "0x313F7A0", Offset = "0x313E3A0", VA = "0x18313F7A0")]
		private void _OnResetBtnClicked(object arg)
		{
		}

		// Token: 0x0600995A RID: 39258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600995A")]
		[Address(RVA = "0x313F060", Offset = "0x313DC60", VA = "0x18313F060")]
		private void _OnLeavePageBtnClicked(object arg)
		{
		}

		// Token: 0x0600995B RID: 39259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600995B")]
		[Address(RVA = "0x313F3E0", Offset = "0x313DFE0", VA = "0x18313F3E0")]
		private void _OnRepairAllBtnClicked()
		{
		}

		// Token: 0x0600995C RID: 39260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600995C")]
		[Address(RVA = "0x313FE70", Offset = "0x313EA70", VA = "0x18313FE70")]
		private void _OnToCraftBtnClicked(object arg)
		{
		}

		// Token: 0x0600995D RID: 39261 RVA: 0x0003B9E8 File Offset: 0x00039BE8
		[Token(Token = "0x600995D")]
		[Address(RVA = "0x313ED60", Offset = "0x313D960", VA = "0x18313ED60")]
		private bool _NeedSendSaveRequest()
		{
			return default(bool);
		}

		// Token: 0x0600995E RID: 39262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600995E")]
		[Address(RVA = "0x3140180", Offset = "0x313ED80", VA = "0x183140180")]
		private void _OpenBuildingPage()
		{
		}

		// Token: 0x0600995F RID: 39263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600995F")]
		[Address(RVA = "0x313E720", Offset = "0x313D320", VA = "0x18313E720")]
		private void _DoRepairAll()
		{
		}

		// Token: 0x06009960 RID: 39264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009960")]
		[Address(RVA = "0x313E820", Offset = "0x313D420", VA = "0x18313E820")]
		private void _DoSaveAndExit()
		{
		}

		// Token: 0x06009961 RID: 39265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009961")]
		[Address(RVA = "0x313E660", Offset = "0x313D260", VA = "0x18313E660")]
		private void _DoCancelExit()
		{
		}

		// Token: 0x06009962 RID: 39266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009962")]
		[Address(RVA = "0x313E8D0", Offset = "0x313D4D0", VA = "0x18313E8D0")]
		private void _DoSaveAndOpenBuildPage()
		{
		}

		// Token: 0x06009963 RID: 39267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009963")]
		[Address(RVA = "0x313EAE0", Offset = "0x313D6E0", VA = "0x18313EAE0")]
		private void _DoSendSaveRequest(Action<SandboxV2ConstructOperationResponse> onProceed)
		{
		}

		// Token: 0x06009964 RID: 39268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009964")]
		[Address(RVA = "0x313FD80", Offset = "0x313E980", VA = "0x18313FD80")]
		private void _OnSaveRespondAndToast(SandboxV2ConstructOperationResponse response)
		{
		}

		// Token: 0x06009965 RID: 39269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009965")]
		[Address(RVA = "0x313FC70", Offset = "0x313E870", VA = "0x18313FC70")]
		private void _OnSaveRespondAndExit(SandboxV2ConstructOperationResponse response)
		{
		}

		// Token: 0x06009966 RID: 39270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009966")]
		[Address(RVA = "0x313FD00", Offset = "0x313E900", VA = "0x18313FD00")]
		private void _OnSaveRespondAndOpenBuildPage(SandboxV2ConstructOperationResponse response)
		{
		}

		// Token: 0x06009967 RID: 39271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009967")]
		[Address(RVA = "0x313E980", Offset = "0x313D580", VA = "0x18313E980")]
		private void _DoSave()
		{
		}

		// Token: 0x06009968 RID: 39272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009968")]
		[Address(RVA = "0x313EE80", Offset = "0x313DA80", VA = "0x18313EE80")]
		private void _OnDetailedToggleClicked(bool isOn)
		{
		}

		// Token: 0x06009969 RID: 39273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009969")]
		[Address(RVA = "0x313E260", Offset = "0x313CE60", VA = "0x18313E260")]
		public void OnTipClicked(SandboxV2ConstructTipType tips)
		{
		}

		// Token: 0x0600996A RID: 39274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600996A")]
		[Address(RVA = "0x31404A0", Offset = "0x313F0A0", VA = "0x1831404A0")]
		public ConstructLandPageController()
		{
		}

		// Token: 0x04008F81 RID: 36737
		[Token(Token = "0x4008F81")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ConstructDetailedView _detailedView;

		// Token: 0x04008F82 RID: 36738
		[Token(Token = "0x4008F82")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ConstructLandConfirmRepairDeco _repairDeco;

		// Token: 0x04008F83 RID: 36739
		[Token(Token = "0x4008F83")]
		[FieldOffset(Offset = "0x30")]
		private ConstructLandPage m_page;

		// Token: 0x04008F84 RID: 36740
		[Token(Token = "0x4008F84")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x04008F85 RID: 36741
		[Token(Token = "0x4008F85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x04008F86 RID: 36742
		[Token(Token = "0x4008F86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04008F87 RID: 36743
		[Token(Token = "0x4008F87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04008F88 RID: 36744
		[Token(Token = "0x4008F88")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSaveBtnClicked;

		// Token: 0x04008F89 RID: 36745
		[Token(Token = "0x4008F89")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnResetBtnClicked;

		// Token: 0x04008F8A RID: 36746
		[Token(Token = "0x4008F8A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnLeavePageBtnClicked;

		// Token: 0x04008F8B RID: 36747
		[Token(Token = "0x4008F8B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnRepairAllBtnClicked;

		// Token: 0x04008F8C RID: 36748
		[Token(Token = "0x4008F8C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnToCraftBtnClicked;

		// Token: 0x04008F8D RID: 36749
		[Token(Token = "0x4008F8D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__NeedSendSaveRequest;

		// Token: 0x04008F8E RID: 36750
		[Token(Token = "0x4008F8E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenBuildingPage;

		// Token: 0x04008F8F RID: 36751
		[Token(Token = "0x4008F8F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DoRepairAll;

		// Token: 0x04008F90 RID: 36752
		[Token(Token = "0x4008F90")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoSaveAndExit;

		// Token: 0x04008F91 RID: 36753
		[Token(Token = "0x4008F91")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DoCancelExit;

		// Token: 0x04008F92 RID: 36754
		[Token(Token = "0x4008F92")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DoSaveAndOpenBuildPage;

		// Token: 0x04008F93 RID: 36755
		[Token(Token = "0x4008F93")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoSendSaveRequest;

		// Token: 0x04008F94 RID: 36756
		[Token(Token = "0x4008F94")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnSaveRespondAndToast;

		// Token: 0x04008F95 RID: 36757
		[Token(Token = "0x4008F95")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnSaveRespondAndExit;

		// Token: 0x04008F96 RID: 36758
		[Token(Token = "0x4008F96")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnSaveRespondAndOpenBuildPage;

		// Token: 0x04008F97 RID: 36759
		[Token(Token = "0x4008F97")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__DoSave;

		// Token: 0x04008F98 RID: 36760
		[Token(Token = "0x4008F98")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnDetailedToggleClicked;

		// Token: 0x04008F99 RID: 36761
		[Token(Token = "0x4008F99")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnTipClicked;

		// Token: 0x04008F9A RID: 36762
		[Token(Token = "0x4008F9A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
