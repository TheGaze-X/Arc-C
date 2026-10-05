using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityPage
{
	// Token: 0x02006779 RID: 26489
	[Token(Token = "0x2006779")]
	public abstract class ActivityEntryPageHandler : IPageActHandler, IHotfixable
	{
		// Token: 0x170059E7 RID: 23015
		// (get) Token: 0x06025FF6 RID: 155638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059E7")]
		public ActivityEntryPageHandler.BaseActHandler baseActHandler
		{
			[Token(Token = "0x6025FF6")]
			[Address(RVA = "0x20EC580", Offset = "0x20EB180", VA = "0x1820EC580")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025FF7 RID: 155639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FF7")]
		[Address(RVA = "0x20EB0C0", Offset = "0x20E9CC0", VA = "0x1820EB0C0", Slot = "4")]
		public void InitHandler(IActEntry entry)
		{
		}

		// Token: 0x06025FF8 RID: 155640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FF8")]
		[Address(RVA = "0x20EAF90", Offset = "0x20E9B90", VA = "0x1820EAF90", Slot = "5")]
		public void DisposeHandler()
		{
		}

		// Token: 0x06025FF9 RID: 155641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FF9")]
		[Address(RVA = "0x20EB590", Offset = "0x20EA190", VA = "0x1820EB590", Slot = "6")]
		public void TriggerInitState(StateEngine stateEngine)
		{
		}

		// Token: 0x06025FFA RID: 155642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FFA")]
		[Address(RVA = "0x20EB6F0", Offset = "0x20EA2F0", VA = "0x1820EB6F0", Slot = "7")]
		public void TriggerStart(bool isFromStack)
		{
		}

		// Token: 0x06025FFB RID: 155643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025FFB")]
		[Address(RVA = "0x20EB3D0", Offset = "0x20E9FD0", VA = "0x1820EB3D0", Slot = "8")]
		public IEnumerator TriggerActEnterEffect()
		{
			return null;
		}

		// Token: 0x06025FFC RID: 155644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025FFC")]
		[Address(RVA = "0x20EB480", Offset = "0x20EA080", VA = "0x1820EB480", Slot = "9")]
		public IEnumerator TriggerActExitEffect()
		{
			return null;
		}

		// Token: 0x06025FFD RID: 155645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FFD")]
		[Address(RVA = "0x20EB340", Offset = "0x20E9F40", VA = "0x1820EB340", Slot = "10")]
		public void ResetActEntryState(bool isShow)
		{
		}

		// Token: 0x06025FFE RID: 155646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FFE")]
		[Address(RVA = "0x20EBC70", Offset = "0x20EA870", VA = "0x1820EBC70")]
		public void _TriggerBGMSignal()
		{
		}

		// Token: 0x06025FFF RID: 155647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FFF")]
		[Address(RVA = "0x20EBE40", Offset = "0x20EAA40", VA = "0x1820EBE40")]
		private void _TryTriggerAvgOrTutorial()
		{
		}

		// Token: 0x06026000 RID: 155648 RVA: 0x000C9A50 File Offset: 0x000C7C50
		[Token(Token = "0x6026000")]
		[Address(RVA = "0x20EC3B0", Offset = "0x20EAFB0", VA = "0x1820EC3B0")]
		private bool _TryTriggerVideoAvg()
		{
			return default(bool);
		}

		// Token: 0x06026001 RID: 155649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026001")]
		[Address(RVA = "0x20EC020", Offset = "0x20EAC20", VA = "0x1820EC020")]
		private void _TryTriggerTutorial()
		{
		}

		// Token: 0x06026002 RID: 155650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026002")]
		[Address(RVA = "0x20EBAC0", Offset = "0x20EA6C0", VA = "0x1820EBAC0")]
		private void _OnVideoAvgComplete(Story story)
		{
		}

		// Token: 0x06026003 RID: 155651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026003")]
		[Address(RVA = "0x20EBA00", Offset = "0x20EA600", VA = "0x1820EBA00")]
		private void _OnEnterAnimFinish()
		{
		}

		// Token: 0x170059E8 RID: 23016
		// (get) Token: 0x06026004 RID: 155652 RVA: 0x000C9A68 File Offset: 0x000C7C68
		[Token(Token = "0x170059E8")]
		protected virtual bool playEntryAnimAfterAVG
		{
			[Token(Token = "0x6026004")]
			[Address(RVA = "0x20EC5E0", Offset = "0x20EB1E0", VA = "0x1820EC5E0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026005 RID: 155653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026005")]
		[Address(RVA = "0x20EB060", Offset = "0x20E9C60", VA = "0x1820EB060", Slot = "13")]
		protected virtual List<AvgParam> GetTutorialParams()
		{
			return null;
		}

		// Token: 0x06026006 RID: 155654 RVA: 0x000C9A80 File Offset: 0x000C7C80
		[Token(Token = "0x6026006")]
		[Address(RVA = "0x20EAEF0", Offset = "0x20E9AF0", VA = "0x1820EAEF0", Slot = "14")]
		public virtual bool CanSkipAnim(TransitionContext context)
		{
			return default(bool);
		}

		// Token: 0x06026007 RID: 155655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026007")]
		[Address(RVA = "0x20EB530", Offset = "0x20EA130", VA = "0x1820EB530", Slot = "15")]
		protected virtual CustomYieldInstruction TriggerEntryExitAnim()
		{
			return null;
		}

		// Token: 0x06026008 RID: 155656
		[Token(Token = "0x6026008")]
		protected abstract void TriggerEntryEnterAnim(Action onAnimFinish);

		// Token: 0x06026009 RID: 155657
		[Token(Token = "0x6026009")]
		protected abstract void ResetEntryToState(bool isShow);

		// Token: 0x0602600A RID: 155658
		[Token(Token = "0x602600A")]
		protected abstract void InitModelDict(Action<string, TemplateActivityViewModel> initViewModel);

		// Token: 0x0602600B RID: 155659
		[Token(Token = "0x602600B")]
		protected abstract void OnRefreshData();

		// Token: 0x0602600C RID: 155660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602600C")]
		[Address(RVA = "0x20EC510", Offset = "0x20EB110", VA = "0x1820EC510")]
		protected ActivityEntryPageHandler()
		{
		}

		// Token: 0x04035755 RID: 218965
		[Token(Token = "0x4035755")]
		[FieldOffset(Offset = "0x10")]
		private float ANIM_SMOOTH_DELAY;

		// Token: 0x04035756 RID: 218966
		[Token(Token = "0x4035756")]
		[FieldOffset(Offset = "0x18")]
		private IActEntry m_entry;

		// Token: 0x04035757 RID: 218967
		[Token(Token = "0x4035757")]
		[FieldOffset(Offset = "0x20")]
		private ActivityEntryPageHandler.BaseActHandler m_baseActHandler;

		// Token: 0x04035758 RID: 218968
		[Token(Token = "0x4035758")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isVideoAvgRunning;

		// Token: 0x04035759 RID: 218969
		[Token(Token = "0x4035759")]
		[FieldOffset(Offset = "0x30")]
		protected string m_actId;

		// Token: 0x0403575A RID: 218970
		[Token(Token = "0x403575A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_baseActHandler;

		// Token: 0x0403575B RID: 218971
		[Token(Token = "0x403575B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitHandler;

		// Token: 0x0403575C RID: 218972
		[Token(Token = "0x403575C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DisposeHandler;

		// Token: 0x0403575D RID: 218973
		[Token(Token = "0x403575D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TriggerInitState;

		// Token: 0x0403575E RID: 218974
		[Token(Token = "0x403575E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TriggerStart;

		// Token: 0x0403575F RID: 218975
		[Token(Token = "0x403575F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TriggerActEnterEffect;

		// Token: 0x04035760 RID: 218976
		[Token(Token = "0x4035760")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TriggerActExitEffect;

		// Token: 0x04035761 RID: 218977
		[Token(Token = "0x4035761")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetActEntryState;

		// Token: 0x04035762 RID: 218978
		[Token(Token = "0x4035762")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TriggerBGMSignal;

		// Token: 0x04035763 RID: 218979
		[Token(Token = "0x4035763")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryTriggerAvgOrTutorial;

		// Token: 0x04035764 RID: 218980
		[Token(Token = "0x4035764")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryTriggerVideoAvg;

		// Token: 0x04035765 RID: 218981
		[Token(Token = "0x4035765")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x04035766 RID: 218982
		[Token(Token = "0x4035766")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnVideoAvgComplete;

		// Token: 0x04035767 RID: 218983
		[Token(Token = "0x4035767")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnEnterAnimFinish;

		// Token: 0x04035768 RID: 218984
		[Token(Token = "0x4035768")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_playEntryAnimAfterAVG;

		// Token: 0x04035769 RID: 218985
		[Token(Token = "0x4035769")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetTutorialParams;

		// Token: 0x0403576A RID: 218986
		[Token(Token = "0x403576A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CanSkipAnim;

		// Token: 0x0403576B RID: 218987
		[Token(Token = "0x403576B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TriggerEntryExitAnim;

		// Token: 0x0403576C RID: 218988
		[Token(Token = "0x403576C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200677A RID: 26490
		[Token(Token = "0x200677A")]
		public class BaseActHandler : IBaseActHandler, IHotfixable, IPlayerDataListener
		{
			// Token: 0x0602600E RID: 155662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602600E")]
			[Address(RVA = "0x20EFBC0", Offset = "0x20EE7C0", VA = "0x1820EFBC0")]
			public BaseActHandler(ActivityEntryPageHandler pageActHandler)
			{
			}

			// Token: 0x0602600F RID: 155663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602600F")]
			[Address(RVA = "0x20EF5D0", Offset = "0x20EE1D0", VA = "0x1820EF5D0")]
			public void OnDispose()
			{
			}

			// Token: 0x06026010 RID: 155664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026010")]
			[Address(RVA = "0x20EF8B0", Offset = "0x20EE4B0", VA = "0x1820EF8B0")]
			private void _InitViewModel(string id, TemplateActivityViewModel viewModel)
			{
			}

			// Token: 0x06026011 RID: 155665 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026011")]
			[Address(RVA = "0x20EF3B0", Offset = "0x20EDFB0", VA = "0x1820EF3B0", Slot = "4")]
			public TemplateActivityViewModel GetViewModel(string param)
			{
				return null;
			}

			// Token: 0x06026012 RID: 155666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026012")]
			[Address(RVA = "0x20EF760", Offset = "0x20EE360", VA = "0x1820EF760", Slot = "8")]
			public void UnBind(IBaseActViewBinder binder, string param)
			{
			}

			// Token: 0x06026013 RID: 155667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026013")]
			[Address(RVA = "0x20EED00", Offset = "0x20ED900", VA = "0x1820EED00", Slot = "7")]
			public void Bind(IBaseActViewBinder binder, string param)
			{
			}

			// Token: 0x06026014 RID: 155668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026014")]
			[Address(RVA = "0x20EF4C0", Offset = "0x20EE0C0", VA = "0x1820EF4C0", Slot = "6")]
			public void OnDataUpdated(string param)
			{
			}

			// Token: 0x06026015 RID: 155669 RVA: 0x000C9A98 File Offset: 0x000C7C98
			[Token(Token = "0x6026015")]
			[Address(RVA = "0x20EF2D0", Offset = "0x20EDED0", VA = "0x1820EF2D0", Slot = "10")]
			public TemplateActivityLifeCycleViewModel.ActState GetCurrentState()
			{
				return TemplateActivityLifeCycleViewModel.ActState.NOT_OPEN;
			}

			// Token: 0x06026016 RID: 155670 RVA: 0x000C9AB0 File Offset: 0x000C7CB0
			[Token(Token = "0x6026016")]
			[Address(RVA = "0x20EEFC0", Offset = "0x20EDBC0", VA = "0x1820EEFC0", Slot = "9")]
			public bool CheckIfActivityIsOpen()
			{
				return default(bool);
			}

			// Token: 0x06026017 RID: 155671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026017")]
			[Address(RVA = "0x20EF230", Offset = "0x20EDE30", VA = "0x1820EF230", Slot = "5")]
			public string GetActId()
			{
				return null;
			}

			// Token: 0x06026018 RID: 155672 RVA: 0x000C9AC8 File Offset: 0x000C7CC8
			[Token(Token = "0x6026018")]
			[Address(RVA = "0x20EF100", Offset = "0x20EDD00", VA = "0x1820EF100", Slot = "11")]
			public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
			{
				return default(bool);
			}

			// Token: 0x06026019 RID: 155673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026019")]
			[Address(RVA = "0x20EF660", Offset = "0x20EE260", VA = "0x1820EF660", Slot = "12")]
			public void OnPlayerDataChanged()
			{
			}

			// Token: 0x0403576D RID: 218989
			[Token(Token = "0x403576D")]
			[FieldOffset(Offset = "0x10")]
			private TemplateActivityBindPlainHolder m_binderListHolder;

			// Token: 0x0403576E RID: 218990
			[Token(Token = "0x403576E")]
			[FieldOffset(Offset = "0x18")]
			private TemplateActivityViewModelProperty m_activityModelProperty;

			// Token: 0x0403576F RID: 218991
			[Token(Token = "0x403576F")]
			[FieldOffset(Offset = "0x20")]
			private ActivityEntryPageHandler m_pageActHandler;

			// Token: 0x04035770 RID: 218992
			[Token(Token = "0x4035770")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04035771 RID: 218993
			[Token(Token = "0x4035771")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnDispose;

			// Token: 0x04035772 RID: 218994
			[Token(Token = "0x4035772")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__InitViewModel;

			// Token: 0x04035773 RID: 218995
			[Token(Token = "0x4035773")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetViewModel;

			// Token: 0x04035774 RID: 218996
			[Token(Token = "0x4035774")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UnBind;

			// Token: 0x04035775 RID: 218997
			[Token(Token = "0x4035775")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Bind;

			// Token: 0x04035776 RID: 218998
			[Token(Token = "0x4035776")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnDataUpdated;

			// Token: 0x04035777 RID: 218999
			[Token(Token = "0x4035777")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetCurrentState;

			// Token: 0x04035778 RID: 219000
			[Token(Token = "0x4035778")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_CheckIfActivityIsOpen;

			// Token: 0x04035779 RID: 219001
			[Token(Token = "0x4035779")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_GetActId;

			// Token: 0x0403577A RID: 219002
			[Token(Token = "0x403577A")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_CheckIfDataChanged;

			// Token: 0x0403577B RID: 219003
			[Token(Token = "0x403577B")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnPlayerDataChanged;
		}
	}
}
