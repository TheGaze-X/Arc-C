using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI;
using Torappu.UI.ActivityPage;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E2F RID: 28207
	[Token(Token = "0x2006E2F")]
	public class ActVecBreakV2EntryPage : ActivityEntryPage
	{
		// Token: 0x0602824C RID: 164428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602824C")]
		[Address(RVA = "0x236EFA0", Offset = "0x236DBA0", VA = "0x18236EFA0", Slot = "31")]
		public override IPageActHandler GetActivityHandler()
		{
			return null;
		}

		// Token: 0x0602824D RID: 164429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602824D")]
		[Address(RVA = "0x236F110", Offset = "0x236DD10", VA = "0x18236F110", Slot = "36")]
		protected override void SetPageShow(bool isShow)
		{
		}

		// Token: 0x0602824E RID: 164430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602824E")]
		[Address(RVA = "0x236EEE0", Offset = "0x236DAE0", VA = "0x18236EEE0", Slot = "34")]
		protected override IEnumerator EffectOnActPageShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0602824F RID: 164431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602824F")]
		[Address(RVA = "0x236F3C0", Offset = "0x236DFC0", VA = "0x18236F3C0")]
		private ActVecBreakV2EntryPage.ActHandler _EnsureActHandler()
		{
			return null;
		}

		// Token: 0x06028250 RID: 164432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028250")]
		[Address(RVA = "0x236F290", Offset = "0x236DE90", VA = "0x18236F290")]
		private Dictionary<string, GameObject> _CreateTutorialMap()
		{
			return null;
		}

		// Token: 0x06028251 RID: 164433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028251")]
		[Address(RVA = "0x236F4E0", Offset = "0x236E0E0", VA = "0x18236F4E0")]
		private void _PlayEnterAnim(Action onAnimFinish)
		{
		}

		// Token: 0x06028252 RID: 164434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028252")]
		[Address(RVA = "0x236F6B0", Offset = "0x236E2B0", VA = "0x18236F6B0")]
		private void _ResetEnterToState(bool isShow)
		{
		}

		// Token: 0x06028253 RID: 164435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028253")]
		[Address(RVA = "0x236F200", Offset = "0x236DE00", VA = "0x18236F200")]
		private void _CancelEnterAnimIfNeed()
		{
		}

		// Token: 0x06028254 RID: 164436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028254")]
		[Address(RVA = "0x236F780", Offset = "0x236E380", VA = "0x18236F780")]
		public ActVecBreakV2EntryPage()
		{
		}

		// Token: 0x06028256 RID: 164438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028256")]
		[Address(RVA = "0x17FCD80", Offset = "0x17FB980", VA = "0x1817FCD80")]
		private void <>xLuaBaseProxy_SetPageShow(bool P0)
		{
		}

		// Token: 0x06028257 RID: 164439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028257")]
		[Address(RVA = "0x236F1F0", Offset = "0x236DDF0", VA = "0x18236F1F0")]
		private IEnumerator <>xLuaBaseProxy_EffectOnActPageShow(bool P0)
		{
			return null;
		}

		// Token: 0x04039023 RID: 233507
		[Token(Token = "0x4039023")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private CanvasGroup _animCanvasGroup;

		// Token: 0x04039024 RID: 233508
		[Token(Token = "0x4039024")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private CanvasGroup _entryCanvasGroup;

		// Token: 0x04039025 RID: 233509
		[Token(Token = "0x4039025")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _cameraGO;

		// Token: 0x04039026 RID: 233510
		[Token(Token = "0x4039026")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04039027 RID: 233511
		[Token(Token = "0x4039027")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _entryBtnOffenseGO;

		// Token: 0x04039028 RID: 233512
		[Token(Token = "0x4039028")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private GameObject _entryBtnHardGO;

		// Token: 0x04039029 RID: 233513
		[Token(Token = "0x4039029")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private GameObject _entryBtnAchvGO;

		// Token: 0x0403902A RID: 233514
		[Token(Token = "0x403902A")]
		[FieldOffset(Offset = "0x148")]
		private ActVecBreakV2EntryPage.ActHandler m_actHandler;

		// Token: 0x0403902B RID: 233515
		[Token(Token = "0x403902B")]
		[FieldOffset(Offset = "0x150")]
		private Tween m_enterTween;

		// Token: 0x0403902C RID: 233516
		[Token(Token = "0x403902C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActivityHandler;

		// Token: 0x0403902D RID: 233517
		[Token(Token = "0x403902D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetPageShow;

		// Token: 0x0403902E RID: 233518
		[Token(Token = "0x403902E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EffectOnActPageShow;

		// Token: 0x0403902F RID: 233519
		[Token(Token = "0x403902F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureActHandler;

		// Token: 0x04039030 RID: 233520
		[Token(Token = "0x4039030")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateTutorialMap;

		// Token: 0x04039031 RID: 233521
		[Token(Token = "0x4039031")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04039032 RID: 233522
		[Token(Token = "0x4039032")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ResetEnterToState;

		// Token: 0x04039033 RID: 233523
		[Token(Token = "0x4039033")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CancelEnterAnimIfNeed;

		// Token: 0x04039034 RID: 233524
		[Token(Token = "0x4039034")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E30 RID: 28208
		[Token(Token = "0x2006E30")]
		public class Params : ActivityEntryPage.IParams
		{
			// Token: 0x06028258 RID: 164440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028258")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			public string GetActId()
			{
				return null;
			}

			// Token: 0x06028259 RID: 164441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028259")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04039035 RID: 233525
			[Token(Token = "0x4039035")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x02006E31 RID: 28209
		[Token(Token = "0x2006E31")]
		public class ActHandler : ActivityEntryPageHandler
		{
			// Token: 0x0602825A RID: 164442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602825A")]
			[Address(RVA = "0x235DFC0", Offset = "0x235CBC0", VA = "0x18235DFC0")]
			public ActHandler(ActVecBreakV2EntryPage closure)
			{
			}

			// Token: 0x0602825B RID: 164443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602825B")]
			[Address(RVA = "0x235D4F0", Offset = "0x235C0F0", VA = "0x18235D4F0", Slot = "18")]
			protected override void InitModelDict(Action<string, TemplateActivityViewModel> initViewModel)
			{
			}

			// Token: 0x0602825C RID: 164444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602825C")]
			[Address(RVA = "0x235D7D0", Offset = "0x235C3D0", VA = "0x18235D7D0", Slot = "19")]
			protected override void OnRefreshData()
			{
			}

			// Token: 0x0602825D RID: 164445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602825D")]
			[Address(RVA = "0x235D220", Offset = "0x235BE20", VA = "0x18235D220", Slot = "13")]
			protected override List<AvgParam> GetTutorialParams()
			{
				return null;
			}

			// Token: 0x0602825E RID: 164446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602825E")]
			[Address(RVA = "0x235DF50", Offset = "0x235CB50", VA = "0x18235DF50")]
			private void _TriggerOffenseGuideBook(Story story)
			{
			}

			// Token: 0x0602825F RID: 164447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602825F")]
			[Address(RVA = "0x235D9D0", Offset = "0x235C5D0", VA = "0x18235D9D0", Slot = "17")]
			protected override void ResetEntryToState(bool isShow)
			{
			}

			// Token: 0x06028260 RID: 164448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028260")]
			[Address(RVA = "0x235DA60", Offset = "0x235C660", VA = "0x18235DA60", Slot = "16")]
			protected override void TriggerEntryEnterAnim(Action onAnimFinish)
			{
			}

			// Token: 0x06028261 RID: 164449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028261")]
			[Address(RVA = "0x235DCA0", Offset = "0x235C8A0", VA = "0x18235DCA0")]
			private void _GenLifeCycleModel(Action<string, TemplateActivityViewModel> initViewModel)
			{
			}

			// Token: 0x06028262 RID: 164450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028262")]
			[Address(RVA = "0x235DDE0", Offset = "0x235C9E0", VA = "0x18235DDE0")]
			private void _GenMilestoneViewModel(Action<string, TemplateActivityViewModel> initViewModel)
			{
			}

			// Token: 0x06028263 RID: 164451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028263")]
			[Address(RVA = "0x235DC90", Offset = "0x235C890", VA = "0x18235DC90")]
			private List<AvgParam> <>xLuaBaseProxy_GetTutorialParams()
			{
				return null;
			}

			// Token: 0x04039036 RID: 233526
			[Token(Token = "0x4039036")]
			[FieldOffset(Offset = "0x38")]
			private ActVecBreakV2EntryPage m_closure;

			// Token: 0x04039037 RID: 233527
			[Token(Token = "0x4039037")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039038 RID: 233528
			[Token(Token = "0x4039038")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitModelDict;

			// Token: 0x04039039 RID: 233529
			[Token(Token = "0x4039039")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnRefreshData;

			// Token: 0x0403903A RID: 233530
			[Token(Token = "0x403903A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetTutorialParams;

			// Token: 0x0403903B RID: 233531
			[Token(Token = "0x403903B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__TriggerOffenseGuideBook;

			// Token: 0x0403903C RID: 233532
			[Token(Token = "0x403903C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetEntryToState;

			// Token: 0x0403903D RID: 233533
			[Token(Token = "0x403903D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_TriggerEntryEnterAnim;

			// Token: 0x0403903E RID: 233534
			[Token(Token = "0x403903E")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__GenLifeCycleModel;

			// Token: 0x0403903F RID: 233535
			[Token(Token = "0x403903F")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__GenMilestoneViewModel;
		}
	}
}
