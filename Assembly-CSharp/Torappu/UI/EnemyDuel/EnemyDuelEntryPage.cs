using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityPage;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F86 RID: 20358
	[Token(Token = "0x2004F86")]
	public class EnemyDuelEntryPage : ActivityEntryPage
	{
		// Token: 0x170046E5 RID: 18149
		// (get) Token: 0x0601E446 RID: 123974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046E5")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x601E446")]
			[Address(RVA = "0x17FCF10", Offset = "0x17FBB10", VA = "0x1817FCF10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170046E6 RID: 18150
		// (get) Token: 0x0601E447 RID: 123975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046E6")]
		public RectTransform spineContainer
		{
			[Token(Token = "0x601E447")]
			[Address(RVA = "0x17FCFD0", Offset = "0x17FBBD0", VA = "0x1817FCFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170046E7 RID: 18151
		// (get) Token: 0x0601E448 RID: 123976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046E7")]
		public PageCameraRenderTextureHolder rtHolder
		{
			[Token(Token = "0x601E448")]
			[Address(RVA = "0x17FCF70", Offset = "0x17FBB70", VA = "0x1817FCF70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E449 RID: 123977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E449")]
		[Address(RVA = "0x17FCD90", Offset = "0x17FB990", VA = "0x1817FCD90")]
		private EnemyDuelEntryPage.ActHandler _EnsureActHandler()
		{
			return null;
		}

		// Token: 0x0601E44A RID: 123978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E44A")]
		[Address(RVA = "0x17FCA80", Offset = "0x17FB680", VA = "0x1817FCA80", Slot = "31")]
		public override IPageActHandler GetActivityHandler()
		{
			return null;
		}

		// Token: 0x0601E44B RID: 123979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E44B")]
		[Address(RVA = "0x17FCCD0", Offset = "0x17FB8D0", VA = "0x1817FCCD0", Slot = "36")]
		protected override void SetPageShow(bool isShow)
		{
		}

		// Token: 0x0601E44C RID: 123980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E44C")]
		[Address(RVA = "0x17FCBF0", Offset = "0x17FB7F0", VA = "0x1817FCBF0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601E44D RID: 123981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E44D")]
		[Address(RVA = "0x17FCEB0", Offset = "0x17FBAB0", VA = "0x1817FCEB0")]
		public EnemyDuelEntryPage()
		{
		}

		// Token: 0x0601E44E RID: 123982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E44E")]
		[Address(RVA = "0x17FCD80", Offset = "0x17FB980", VA = "0x1817FCD80")]
		private void <>xLuaBaseProxy_SetPageShow(bool P0)
		{
		}

		// Token: 0x0601E44F RID: 123983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E44F")]
		[Address(RVA = "0x17FCD70", Offset = "0x17FB970", VA = "0x1817FCD70")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0402863A RID: 165434
		[Token(Token = "0x402863A")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private CanvasGroup _root;

		// Token: 0x0402863B RID: 165435
		[Token(Token = "0x402863B")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private PageCameraRenderTextureHolder _rtHolder;

		// Token: 0x0402863C RID: 165436
		[Token(Token = "0x402863C")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0402863D RID: 165437
		[Token(Token = "0x402863D")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private RectTransform _spineContainer;

		// Token: 0x0402863E RID: 165438
		[Token(Token = "0x402863E")]
		[FieldOffset(Offset = "0x128")]
		private UICompDialogMgr m_diaglogMgr;

		// Token: 0x0402863F RID: 165439
		[Token(Token = "0x402863F")]
		[FieldOffset(Offset = "0x130")]
		private EnemyDuelEntryPage.ActHandler m_actHandler;

		// Token: 0x04028640 RID: 165440
		[Token(Token = "0x4028640")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x04028641 RID: 165441
		[Token(Token = "0x4028641")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_spineContainer;

		// Token: 0x04028642 RID: 165442
		[Token(Token = "0x4028642")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rtHolder;

		// Token: 0x04028643 RID: 165443
		[Token(Token = "0x4028643")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureActHandler;

		// Token: 0x04028644 RID: 165444
		[Token(Token = "0x4028644")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetActivityHandler;

		// Token: 0x04028645 RID: 165445
		[Token(Token = "0x4028645")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetPageShow;

		// Token: 0x04028646 RID: 165446
		[Token(Token = "0x4028646")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04028647 RID: 165447
		[Token(Token = "0x4028647")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F87 RID: 20359
		[Token(Token = "0x2004F87")]
		public class Params : ActivityEntryPage.IParams
		{
			// Token: 0x0601E450 RID: 123984 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E450")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			public string GetActId()
			{
				return null;
			}

			// Token: 0x0601E451 RID: 123985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E451")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04028648 RID: 165448
			[Token(Token = "0x4028648")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x02004F88 RID: 20360
		[Token(Token = "0x2004F88")]
		public class ActHandler : ActivityEntryPageHandler
		{
			// Token: 0x0601E452 RID: 123986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E452")]
			[Address(RVA = "0x17F70C0", Offset = "0x17F5CC0", VA = "0x1817F70C0")]
			public ActHandler(EnemyDuelEntryPage page)
			{
			}

			// Token: 0x0601E453 RID: 123987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E453")]
			[Address(RVA = "0x17F6290", Offset = "0x17F4E90", VA = "0x1817F6290", Slot = "18")]
			protected override void InitModelDict(Action<string, TemplateActivityViewModel> initViewModel)
			{
			}

			// Token: 0x0601E454 RID: 123988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E454")]
			[Address(RVA = "0x17F6570", Offset = "0x17F5170", VA = "0x1817F6570", Slot = "19")]
			protected override void OnRefreshData()
			{
			}

			// Token: 0x0601E455 RID: 123989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E455")]
			[Address(RVA = "0x17F6C10", Offset = "0x17F5810", VA = "0x1817F6C10")]
			private void _GenLifeCycleModel(Action<string, TemplateActivityViewModel> initViewModel)
			{
			}

			// Token: 0x0601E456 RID: 123990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E456")]
			[Address(RVA = "0x17F6D50", Offset = "0x17F5950", VA = "0x1817F6D50")]
			private void _GenMedalViewModel(Action<string, TemplateActivityViewModel> initViewModel)
			{
			}

			// Token: 0x0601E457 RID: 123991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E457")]
			[Address(RVA = "0x17F6EB0", Offset = "0x17F5AB0", VA = "0x1817F6EB0")]
			private void _GenMilestoneViewModel(Action<string, TemplateActivityViewModel> initViewModel)
			{
			}

			// Token: 0x0601E458 RID: 123992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E458")]
			[Address(RVA = "0x17F6AC0", Offset = "0x17F56C0", VA = "0x1817F6AC0", Slot = "16")]
			protected override void TriggerEntryEnterAnim(Action onAnimFinish)
			{
			}

			// Token: 0x0601E459 RID: 123993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E459")]
			[Address(RVA = "0x17F6830", Offset = "0x17F5430", VA = "0x1817F6830", Slot = "17")]
			protected override void ResetEntryToState(bool isShow)
			{
			}

			// Token: 0x04028649 RID: 165449
			[Token(Token = "0x4028649")]
			[FieldOffset(Offset = "0x38")]
			private EnemyDuelEntryPage m_entryPage;

			// Token: 0x0402864A RID: 165450
			[Token(Token = "0x402864A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402864B RID: 165451
			[Token(Token = "0x402864B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitModelDict;

			// Token: 0x0402864C RID: 165452
			[Token(Token = "0x402864C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnRefreshData;

			// Token: 0x0402864D RID: 165453
			[Token(Token = "0x402864D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GenLifeCycleModel;

			// Token: 0x0402864E RID: 165454
			[Token(Token = "0x402864E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GenMedalViewModel;

			// Token: 0x0402864F RID: 165455
			[Token(Token = "0x402864F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__GenMilestoneViewModel;

			// Token: 0x04028650 RID: 165456
			[Token(Token = "0x4028650")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_TriggerEntryEnterAnim;

			// Token: 0x04028651 RID: 165457
			[Token(Token = "0x4028651")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetEntryToState;
		}
	}
}
