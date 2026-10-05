using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006894 RID: 26772
	[Token(Token = "0x2006894")]
	public class StageZoneSelectState : StageTabBaseState, IValueMsgReceiver
	{
		// Token: 0x060265CF RID: 157135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265CF")]
		[Address(RVA = "0x216F970", Offset = "0x216E570", VA = "0x18216F970")]
		private void _InitedIfNot()
		{
		}

		// Token: 0x060265D0 RID: 157136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265D0")]
		private T _InitZoneGroupPanel<T>(T prefab, Transform container, List<StageZoneGroupPanel> collector) where T : StageZoneGroupPanel
		{
			return null;
		}

		// Token: 0x060265D1 RID: 157137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265D1")]
		[Address(RVA = "0x216EC60", Offset = "0x216D860", VA = "0x18216EC60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060265D2 RID: 157138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265D2")]
		[Address(RVA = "0x216F4F0", Offset = "0x216E0F0", VA = "0x18216F4F0", Slot = "19")]
		protected override IEnumerator OnPreload()
		{
			return null;
		}

		// Token: 0x060265D3 RID: 157139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265D3")]
		[Address(RVA = "0x216F5A0", Offset = "0x216E1A0", VA = "0x18216F5A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060265D4 RID: 157140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265D4")]
		[Address(RVA = "0x216F640", Offset = "0x216E240", VA = "0x18216F640", Slot = "20")]
		public override ITransAction PickDynamicTransAction(State otherState, TransitionType transType)
		{
			return null;
		}

		// Token: 0x17005A89 RID: 23177
		// (get) Token: 0x060265D5 RID: 157141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A89")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x60265D5")]
			[Address(RVA = "0x2171120", Offset = "0x216FD20", VA = "0x182171120", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x060265D6 RID: 157142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265D6")]
		[Address(RVA = "0x216ECC0", Offset = "0x216D8C0", VA = "0x18216ECC0", Slot = "25")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060265D7 RID: 157143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265D7")]
		[Address(RVA = "0x21703D0", Offset = "0x216EFD0", VA = "0x1821703D0")]
		private void _OnMixStorySelectZone(string storySetId, string zoneId)
		{
		}

		// Token: 0x060265D8 RID: 157144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265D8")]
		[Address(RVA = "0x216FCB0", Offset = "0x216E8B0", VA = "0x18216FCB0")]
		private void _JumpToZone(string storySetId, string zoneId)
		{
		}

		// Token: 0x060265D9 RID: 157145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265D9")]
		[Address(RVA = "0x2170250", Offset = "0x216EE50", VA = "0x182170250")]
		private void _OnMixStorySelectBrief(string storySetId)
		{
		}

		// Token: 0x060265DA RID: 157146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265DA")]
		[Address(RVA = "0x216FF30", Offset = "0x216EB30", VA = "0x18216FF30")]
		private void _OnMixStoryFocusStorySet(string storySetId)
		{
		}

		// Token: 0x060265DB RID: 157147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265DB")]
		[Address(RVA = "0x2170060", Offset = "0x216EC60", VA = "0x182170060")]
		private void _OnMixStoryFocusStoryline(string storylineId)
		{
		}

		// Token: 0x060265DC RID: 157148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265DC")]
		[Address(RVA = "0x2170190", Offset = "0x216ED90", VA = "0x182170190")]
		private void _OnMixStoryFoldStorylines()
		{
		}

		// Token: 0x060265DD RID: 157149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265DD")]
		[Address(RVA = "0x2170630", Offset = "0x216F230", VA = "0x182170630")]
		private void _OnRoguelikeClicked()
		{
		}

		// Token: 0x060265DE RID: 157150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265DE")]
		[Address(RVA = "0x21707C0", Offset = "0x216F3C0", VA = "0x1821707C0")]
		private void _OnRoguelikeEntryClicked()
		{
		}

		// Token: 0x060265DF RID: 157151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265DF")]
		[Address(RVA = "0x2170910", Offset = "0x216F510", VA = "0x182170910")]
		private void _OnSandboxClicked()
		{
		}

		// Token: 0x060265E0 RID: 157152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265E0")]
		[Address(RVA = "0x2170B50", Offset = "0x216F750", VA = "0x182170B50")]
		private void _OnZoneSelected(ZoneGroupViewModel zoneGroup, ZoneViewModel zoneModel)
		{
		}

		// Token: 0x060265E1 RID: 157153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265E1")]
		[Address(RVA = "0x2170D40", Offset = "0x216F940", VA = "0x182170D40")]
		private void _SelectZone(string zoneId)
		{
		}

		// Token: 0x060265E2 RID: 157154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265E2")]
		[Address(RVA = "0x2170E80", Offset = "0x216FA80", VA = "0x182170E80")]
		private void _SetActEntryEffectEnable(bool enable)
		{
		}

		// Token: 0x060265E3 RID: 157155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265E3")]
		[Address(RVA = "0x2170F90", Offset = "0x216FB90", VA = "0x182170F90")]
		private void _Tutorial_TriggerRetroTutorialIfNeed()
		{
		}

		// Token: 0x060265E4 RID: 157156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265E4")]
		[Address(RVA = "0x2171060", Offset = "0x216FC60", VA = "0x182171060")]
		public StageZoneSelectState()
		{
		}

		// Token: 0x060265E7 RID: 157159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265E7")]
		[Address(RVA = "0x15A0840", Offset = "0x159F440", VA = "0x1815A0840")]
		private IEnumerator <>xLuaBaseProxy_OnPreload()
		{
			return null;
		}

		// Token: 0x060265E8 RID: 157160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265E8")]
		[Address(RVA = "0x216B190", Offset = "0x2169D90", VA = "0x18216B190")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060265E9 RID: 157161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265E9")]
		[Address(RVA = "0xF97A90", Offset = "0xF96690", VA = "0x180F97A90")]
		private ITransAction <>xLuaBaseProxy_PickDynamicTransAction(State P0, TransitionType P1)
		{
			return null;
		}

		// Token: 0x060265EA RID: 157162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265EA")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x0403606B RID: 221291
		[Token(Token = "0x403606B")]
		private const float ZONE_GROUP_ANIM_DUR = 0.4f;

		// Token: 0x0403606C RID: 221292
		[Token(Token = "0x403606C")]
		[NonSerialized]
		public const int ON_ROGUELIKE_CLICKED = 0;

		// Token: 0x0403606D RID: 221293
		[Token(Token = "0x403606D")]
		[NonSerialized]
		public const int ON_ROGUELIKE_ENTRY_CLICKED = 1;

		// Token: 0x0403606E RID: 221294
		[Token(Token = "0x403606E")]
		[NonSerialized]
		public const int ON_SANDBOX_CLICKED = 2;

		// Token: 0x0403606F RID: 221295
		[Token(Token = "0x403606F")]
		[NonSerialized]
		public const int ON_MIX_STORY_SELECT_ZONE = 3;

		// Token: 0x04036070 RID: 221296
		[Token(Token = "0x4036070")]
		[NonSerialized]
		public const int ON_MIX_STORY_SELECT_BRIEF = 4;

		// Token: 0x04036071 RID: 221297
		[Token(Token = "0x4036071")]
		[NonSerialized]
		public const int ON_MIX_STORY_FOCUS_STORY_SET = 5;

		// Token: 0x04036072 RID: 221298
		[Token(Token = "0x4036072")]
		[NonSerialized]
		public const int ON_MIX_STORY_FOCUS_STORYLINE = 6;

		// Token: 0x04036073 RID: 221299
		[Token(Token = "0x4036073")]
		[NonSerialized]
		public const int ON_MIX_STORY_FOLD_STORYLINES = 7;

		// Token: 0x04036074 RID: 221300
		[Token(Token = "0x4036074")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private StageStateBean _stateBean;

		// Token: 0x04036075 RID: 221301
		[Token(Token = "0x4036075")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StageZoneSelectBackground _background;

		// Token: 0x04036076 RID: 221302
		[Token(Token = "0x4036076")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04036077 RID: 221303
		[Token(Token = "0x4036077")]
		[FieldOffset(Offset = "0x70")]
		private StageZoneWeeklyGroupPanel m_weeklyGroup;

		// Token: 0x04036078 RID: 221304
		[Token(Token = "0x4036078")]
		[FieldOffset(Offset = "0x78")]
		private StageZoneHomeMainGroupPanel m_homeGroup;

		// Token: 0x04036079 RID: 221305
		[Token(Token = "0x4036079")]
		[FieldOffset(Offset = "0x80")]
		private StageZoneCampaignGroupPanel m_campaignGroup;

		// Token: 0x0403607A RID: 221306
		[Token(Token = "0x403607A")]
		[FieldOffset(Offset = "0x88")]
		private StageZoneMixStoryGroupPanel m_mixStoryGroup;

		// Token: 0x0403607B RID: 221307
		[Token(Token = "0x403607B")]
		[FieldOffset(Offset = "0x90")]
		private StageZonePermModeGroupPanel m_permModeGroup;

		// Token: 0x0403607C RID: 221308
		[Token(Token = "0x403607C")]
		[FieldOffset(Offset = "0x98")]
		private StageZoneSeasonGroupPanel m_seasonGroup;

		// Token: 0x0403607D RID: 221309
		[Token(Token = "0x403607D")]
		[FieldOffset(Offset = "0xA0")]
		private List<StageZoneGroupPanel> m_zoneGroupPanels;

		// Token: 0x0403607E RID: 221310
		[Token(Token = "0x403607E")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0403607F RID: 221311
		[Token(Token = "0x403607F")]
		[FieldOffset(Offset = "0xB0")]
		private MixStoryGroupViewProperty m_mixStoryGroupViewProperty;

		// Token: 0x04036080 RID: 221312
		[Token(Token = "0x4036080")]
		[FieldOffset(Offset = "0xB8")]
		private StateCacheHandler<StageZoneSelectState.StateRuntime> m_cacheHandler;

		// Token: 0x04036081 RID: 221313
		[Token(Token = "0x4036081")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitedIfNot;

		// Token: 0x04036082 RID: 221314
		[Token(Token = "0x4036082")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitZoneGroupPanel;

		// Token: 0x04036083 RID: 221315
		[Token(Token = "0x4036083")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04036084 RID: 221316
		[Token(Token = "0x4036084")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreload;

		// Token: 0x04036085 RID: 221317
		[Token(Token = "0x4036085")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04036086 RID: 221318
		[Token(Token = "0x4036086")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PickDynamicTransAction;

		// Token: 0x04036087 RID: 221319
		[Token(Token = "0x4036087")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x04036088 RID: 221320
		[Token(Token = "0x4036088")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04036089 RID: 221321
		[Token(Token = "0x4036089")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnMixStorySelectZone;

		// Token: 0x0403608A RID: 221322
		[Token(Token = "0x403608A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__JumpToZone;

		// Token: 0x0403608B RID: 221323
		[Token(Token = "0x403608B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnMixStorySelectBrief;

		// Token: 0x0403608C RID: 221324
		[Token(Token = "0x403608C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnMixStoryFocusStorySet;

		// Token: 0x0403608D RID: 221325
		[Token(Token = "0x403608D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnMixStoryFocusStoryline;

		// Token: 0x0403608E RID: 221326
		[Token(Token = "0x403608E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnMixStoryFoldStorylines;

		// Token: 0x0403608F RID: 221327
		[Token(Token = "0x403608F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnRoguelikeClicked;

		// Token: 0x04036090 RID: 221328
		[Token(Token = "0x4036090")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnRoguelikeEntryClicked;

		// Token: 0x04036091 RID: 221329
		[Token(Token = "0x4036091")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnSandboxClicked;

		// Token: 0x04036092 RID: 221330
		[Token(Token = "0x4036092")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnZoneSelected;

		// Token: 0x04036093 RID: 221331
		[Token(Token = "0x4036093")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SelectZone;

		// Token: 0x04036094 RID: 221332
		[Token(Token = "0x4036094")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SetActEntryEffectEnable;

		// Token: 0x04036095 RID: 221333
		[Token(Token = "0x4036095")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__Tutorial_TriggerRetroTutorialIfNeed;

		// Token: 0x04036096 RID: 221334
		[Token(Token = "0x4036096")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006895 RID: 26773
		[Token(Token = "0x2006895")]
		public struct StateRuntime
		{
			// Token: 0x04036097 RID: 221335
			[Token(Token = "0x4036097")]
			[FieldOffset(Offset = "0x0")]
			public string activityId;

			// Token: 0x04036098 RID: 221336
			[Token(Token = "0x4036098")]
			[FieldOffset(Offset = "0x8")]
			public string focusedZoneId;

			// Token: 0x04036099 RID: 221337
			[Token(Token = "0x4036099")]
			[FieldOffset(Offset = "0x10")]
			public ZoneViewType focusZoneViewType;

			// Token: 0x0403609A RID: 221338
			[Token(Token = "0x403609A")]
			[FieldOffset(Offset = "0x14")]
			public bool focusLastVisitedMainline;
		}

		// Token: 0x02006896 RID: 26774
		[Token(Token = "0x2006896")]
		private class ForwardOutTransition : ITransAction
		{
			// Token: 0x060265EB RID: 157163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60265EB")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public ForwardOutTransition(StageZoneSelectState closure)
			{
			}

			// Token: 0x17005A8A RID: 23178
			// (get) Token: 0x060265EC RID: 157164 RVA: 0x000CABA8 File Offset: 0x000C8DA8
			[Token(Token = "0x17005A8A")]
			public TransActionType ActionType
			{
				[Token(Token = "0x60265EC")]
				[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
				get
				{
					return TransActionType.SEQUENTIAL;
				}
			}

			// Token: 0x060265ED RID: 157165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60265ED")]
			[Address(RVA = "0x215FEA0", Offset = "0x215EAA0", VA = "0x18215FEA0", Slot = "4")]
			public void Execute(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x060265EE RID: 157166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60265EE")]
			[Address(RVA = "0x215FEA0", Offset = "0x215EAA0", VA = "0x18215FEA0", Slot = "5")]
			public void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x060265EF RID: 157167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60265EF")]
			[Address(RVA = "0x215FEE0", Offset = "0x215EAE0", VA = "0x18215FEE0")]
			private void _Execute(TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x0403609B RID: 221339
			[Token(Token = "0x403609B")]
			[FieldOffset(Offset = "0x10")]
			private StageZoneSelectState m_closure;
		}

		// Token: 0x02006897 RID: 26775
		[Token(Token = "0x2006897")]
		private class BackInTransition : ITransAction
		{
			// Token: 0x060265F0 RID: 157168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60265F0")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public BackInTransition(StageZoneSelectState closure)
			{
			}

			// Token: 0x17005A8B RID: 23179
			// (get) Token: 0x060265F1 RID: 157169 RVA: 0x000CABC0 File Offset: 0x000C8DC0
			[Token(Token = "0x17005A8B")]
			public TransActionType ActionType
			{
				[Token(Token = "0x60265F1")]
				[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
				get
				{
					return TransActionType.SEQUENTIAL;
				}
			}

			// Token: 0x060265F2 RID: 157170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60265F2")]
			[Address(RVA = "0x215F850", Offset = "0x215E450", VA = "0x18215F850", Slot = "4")]
			public void Execute(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x060265F3 RID: 157171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60265F3")]
			[Address(RVA = "0x215F850", Offset = "0x215E450", VA = "0x18215F850", Slot = "5")]
			public void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x060265F4 RID: 157172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60265F4")]
			[Address(RVA = "0x215F890", Offset = "0x215E490", VA = "0x18215F890")]
			private void _Execute(TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x0403609C RID: 221340
			[Token(Token = "0x403609C")]
			[FieldOffset(Offset = "0x10")]
			private StageZoneSelectState m_closure;
		}
	}
}
