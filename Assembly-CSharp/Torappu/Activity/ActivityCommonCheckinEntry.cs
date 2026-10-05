using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006DA8 RID: 28072
	[Token(Token = "0x2006DA8")]
	public abstract class ActivityCommonCheckinEntry : ActivityCommonEntry, IHotfixable
	{
		// Token: 0x17005E78 RID: 24184
		// (get) Token: 0x06027FAA RID: 163754 RVA: 0x000D03B0 File Offset: 0x000CE5B0
		[Token(Token = "0x17005E78")]
		protected ActivityCheckinEntryView.CheckinViewType defaultViewType
		{
			[Token(Token = "0x6027FAA")]
			[Address(RVA = "0x2337EB0", Offset = "0x2336AB0", VA = "0x182337EB0")]
			get
			{
				return ActivityCheckinEntryView.CheckinViewType.NONE;
			}
		}

		// Token: 0x17005E79 RID: 24185
		// (get) Token: 0x06027FAC RID: 163756 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027FAB RID: 163755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E79")]
		private protected string actId
		{
			[Token(Token = "0x6027FAC")]
			[Address(RVA = "0x2337E50", Offset = "0x2336A50", VA = "0x182337E50")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6027FAB")]
			[Address(RVA = "0x2337F30", Offset = "0x2336B30", VA = "0x182337F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06027FAD RID: 163757
		[Token(Token = "0x6027FAD")]
		protected abstract void RefreshInfo();

		// Token: 0x06027FAE RID: 163758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FAE")]
		[Address(RVA = "0x2337240", Offset = "0x2335E40", VA = "0x182337240", Slot = "4")]
		public override void OnEnter(string activityId)
		{
		}

		// Token: 0x06027FAF RID: 163759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FAF")]
		[Address(RVA = "0x2337CE0", Offset = "0x23368E0", VA = "0x182337CE0", Slot = "10")]
		protected virtual void _SwitchView(ActivityCheckinEntryView.CheckinViewType viewType)
		{
		}

		// Token: 0x06027FB0 RID: 163760 RVA: 0x000D03C8 File Offset: 0x000CE5C8
		[Token(Token = "0x6027FB0")]
		[Address(RVA = "0x23377D0", Offset = "0x23363D0", VA = "0x1823377D0", Slot = "11")]
		protected virtual ActivityCheckinEntryView.CheckinViewType _GetDefaultViewType()
		{
			return ActivityCheckinEntryView.CheckinViewType.NONE;
		}

		// Token: 0x06027FB1 RID: 163761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FB1")]
		[Address(RVA = "0x2337C60", Offset = "0x2336860", VA = "0x182337C60")]
		protected void _SendCheckinRequest(int index)
		{
		}

		// Token: 0x06027FB2 RID: 163762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FB2")]
		[Address(RVA = "0x23379B0", Offset = "0x23365B0", VA = "0x1823379B0")]
		protected void _SendCheckinRequestWithOption(int index, string option)
		{
		}

		// Token: 0x06027FB3 RID: 163763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FB3")]
		[Address(RVA = "0x2337830", Offset = "0x2336430", VA = "0x182337830")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027FB4 RID: 163764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027FB4")]
		[Address(RVA = "0x23378E0", Offset = "0x23364E0", VA = "0x1823378E0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x06027FB5 RID: 163765 RVA: 0x000D03E0 File Offset: 0x000CE5E0
		[Token(Token = "0x6027FB5")]
		[Address(RVA = "0x2337510", Offset = "0x2336110", VA = "0x182337510")]
		private ActivityCheckinEntryView.OptionStruct _GeneOptionStruct()
		{
			return default(ActivityCheckinEntryView.OptionStruct);
		}

		// Token: 0x06027FB6 RID: 163766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027FB6")]
		[Address(RVA = "0x23370C0", Offset = "0x2335CC0", VA = "0x1823370C0")]
		public ExtraSignPluginOptions GenExtraSignPluginOptionStruct(string[] countdown)
		{
			return null;
		}

		// Token: 0x06027FB7 RID: 163767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FB7")]
		[Address(RVA = "0x2337D40", Offset = "0x2336940", VA = "0x182337D40")]
		protected ActivityCommonCheckinEntry()
		{
		}

		// Token: 0x04038A9E RID: 232094
		[Token(Token = "0x4038A9E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Entry View")]
		private ActivityCheckinEntryView[] _viewPrefabs;

		// Token: 0x04038A9F RID: 232095
		[Token(Token = "0x4038A9F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Entry View")]
		private Transform _viewContainer;

		// Token: 0x04038AA0 RID: 232096
		[Token(Token = "0x4038AA0")]
		[FieldOffset(Offset = "0x50")]
		protected ActivityCommonCheckinViewModel m_viewModel;

		// Token: 0x04038AA1 RID: 232097
		[Token(Token = "0x4038AA1")]
		[FieldOffset(Offset = "0x58")]
		protected ActivityCommonCheckinEntry.EntryViewController m_entryViewController;

		// Token: 0x04038AA2 RID: 232098
		[Token(Token = "0x4038AA2")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04038AA4 RID: 232100
		[Token(Token = "0x4038AA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_defaultViewType;

		// Token: 0x04038AA5 RID: 232101
		[Token(Token = "0x4038AA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04038AA6 RID: 232102
		[Token(Token = "0x4038AA6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04038AA7 RID: 232103
		[Token(Token = "0x4038AA7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038AA8 RID: 232104
		[Token(Token = "0x4038AA8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SwitchView;

		// Token: 0x04038AA9 RID: 232105
		[Token(Token = "0x4038AA9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetDefaultViewType;

		// Token: 0x04038AAA RID: 232106
		[Token(Token = "0x4038AAA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SendCheckinRequest;

		// Token: 0x04038AAB RID: 232107
		[Token(Token = "0x4038AAB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendCheckinRequestWithOption;

		// Token: 0x04038AAC RID: 232108
		[Token(Token = "0x4038AAC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038AAD RID: 232109
		[Token(Token = "0x4038AAD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04038AAE RID: 232110
		[Token(Token = "0x4038AAE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GeneOptionStruct;

		// Token: 0x04038AAF RID: 232111
		[Token(Token = "0x4038AAF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GenExtraSignPluginOptionStruct;

		// Token: 0x04038AB0 RID: 232112
		[Token(Token = "0x4038AB0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DA9 RID: 28073
		[Token(Token = "0x2006DA9")]
		protected class EntryViewController : IHotfixable
		{
			// Token: 0x06027FB9 RID: 163769 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027FB9")]
			[Address(RVA = "0x23414F0", Offset = "0x23400F0", VA = "0x1823414F0")]
			public EntryViewController(ActivityCommonCheckinEntry closure)
			{
			}

			// Token: 0x06027FBA RID: 163770 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027FBA")]
			[Address(RVA = "0x2340E70", Offset = "0x233FA70", VA = "0x182340E70")]
			public void Init()
			{
			}

			// Token: 0x06027FBB RID: 163771 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027FBB")]
			[Address(RVA = "0x23410D0", Offset = "0x233FCD0", VA = "0x1823410D0")]
			public ActivityCheckinEntryView SwitchEntryView(ActivityCheckinEntryView.CheckinViewType viewType)
			{
				return null;
			}

			// Token: 0x06027FBC RID: 163772 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027FBC")]
			[Address(RVA = "0x2341280", Offset = "0x233FE80", VA = "0x182341280")]
			private ActivityCheckinEntryView _GetEntryView(ActivityCheckinEntryView.CheckinViewType viewType)
			{
				return null;
			}

			// Token: 0x04038AB1 RID: 232113
			[Token(Token = "0x4038AB1")]
			[FieldOffset(Offset = "0x10")]
			private ActivityCommonCheckinEntry m_closure;

			// Token: 0x04038AB2 RID: 232114
			[Token(Token = "0x4038AB2")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<ActivityCheckinEntryView.CheckinViewType, ActivityCheckinEntryView> m_prefabMap;

			// Token: 0x04038AB3 RID: 232115
			[Token(Token = "0x4038AB3")]
			[FieldOffset(Offset = "0x20")]
			private ListDict<ActivityCheckinEntryView.CheckinViewType, ActivityCheckinEntryView> m_instMap;

			// Token: 0x04038AB4 RID: 232116
			[Token(Token = "0x4038AB4")]
			[FieldOffset(Offset = "0x28")]
			private ActivityCheckinEntryView.CheckinViewType m_currentViewType;

			// Token: 0x04038AB5 RID: 232117
			[Token(Token = "0x4038AB5")]
			[FieldOffset(Offset = "0x30")]
			private ActivityCheckinEntryView m_currentView;

			// Token: 0x04038AB6 RID: 232118
			[Token(Token = "0x4038AB6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038AB7 RID: 232119
			[Token(Token = "0x4038AB7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04038AB8 RID: 232120
			[Token(Token = "0x4038AB8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SwitchEntryView;

			// Token: 0x04038AB9 RID: 232121
			[Token(Token = "0x4038AB9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GetEntryView;
		}

		// Token: 0x02006DAA RID: 28074
		[Token(Token = "0x2006DAA")]
		public class DelayHandler : IHotfixable
		{
			// Token: 0x06027FBD RID: 163773 RVA: 0x000D03F8 File Offset: 0x000CE5F8
			[Token(Token = "0x6027FBD")]
			[Address(RVA = "0x2340C30", Offset = "0x233F830", VA = "0x182340C30")]
			public bool SetDelay(Action nextAction, float delay)
			{
				return default(bool);
			}

			// Token: 0x06027FBE RID: 163774 RVA: 0x000D0410 File Offset: 0x000CE610
			[Token(Token = "0x6027FBE")]
			[Address(RVA = "0x2340BD0", Offset = "0x233F7D0", VA = "0x182340BD0")]
			public bool IsRunning()
			{
				return default(bool);
			}

			// Token: 0x06027FBF RID: 163775 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027FBF")]
			[Address(RVA = "0x2340B70", Offset = "0x233F770", VA = "0x182340B70")]
			public void InterruptDelay()
			{
			}

			// Token: 0x06027FC0 RID: 163776 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027FC0")]
			[Address(RVA = "0x2340D70", Offset = "0x233F970", VA = "0x182340D70")]
			private void _InvokeNextAction(Action nextAction, bool interrupted)
			{
			}

			// Token: 0x06027FC1 RID: 163777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027FC1")]
			[Address(RVA = "0x2340E10", Offset = "0x233FA10", VA = "0x182340E10")]
			public DelayHandler()
			{
			}

			// Token: 0x04038ABA RID: 232122
			[Token(Token = "0x4038ABA")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isDelayProcessing;

			// Token: 0x04038ABB RID: 232123
			[Token(Token = "0x4038ABB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetDelay;

			// Token: 0x04038ABC RID: 232124
			[Token(Token = "0x4038ABC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsRunning;

			// Token: 0x04038ABD RID: 232125
			[Token(Token = "0x4038ABD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_InterruptDelay;

			// Token: 0x04038ABE RID: 232126
			[Token(Token = "0x4038ABE")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__InvokeNextAction;

			// Token: 0x04038ABF RID: 232127
			[Token(Token = "0x4038ABF")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
