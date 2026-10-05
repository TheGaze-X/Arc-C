using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F15 RID: 16149
	[Token(Token = "0x2003F15")]
	public class SiracusaCharTaskRingItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x0601912B RID: 102699 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601912C RID: 102700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BFF")]
		public Action<int> onRingSelect
		{
			[Token(Token = "0x601912B")]
			[Address(RVA = "0x11B3A90", Offset = "0x11B2690", VA = "0x1811B3A90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601912C")]
			[Address(RVA = "0x11B3B50", Offset = "0x11B2750", VA = "0x1811B3B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x0601912D RID: 102701 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601912E RID: 102702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C00")]
		public Action<string, string> onTaskClick
		{
			[Token(Token = "0x601912D")]
			[Address(RVA = "0x11B3AF0", Offset = "0x11B26F0", VA = "0x1811B3AF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601912E")]
			[Address(RVA = "0x11B3BD0", Offset = "0x11B27D0", VA = "0x1811B3BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601912F RID: 102703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601912F")]
		[Address(RVA = "0x11B2F50", Offset = "0x11B1B50", VA = "0x1811B2F50")]
		public void Render(int index, SiracusaCharTaskRingModel taskRingModel, bool isSelect, bool isEnd)
		{
		}

		// Token: 0x06019130 RID: 102704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019130")]
		[Address(RVA = "0x11B37D0", Offset = "0x11B23D0", VA = "0x1811B37D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019131 RID: 102705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019131")]
		[Address(RVA = "0x11B3690", Offset = "0x11B2290", VA = "0x1811B3690")]
		private void _CreateListViewIfNeed(bool isLinear)
		{
		}

		// Token: 0x06019132 RID: 102706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019132")]
		[Address(RVA = "0x11B3930", Offset = "0x11B2530", VA = "0x1811B3930")]
		private void _UpdateStatusIcon(PlayerSiracusaMap.TaskRingStatus ringStatus, bool isUnlock)
		{
		}

		// Token: 0x06019133 RID: 102707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019133")]
		[Address(RVA = "0x11B2E40", Offset = "0x11B1A40", VA = "0x1811B2E40")]
		public void EventOnSelectRing()
		{
		}

		// Token: 0x06019134 RID: 102708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019134")]
		[Address(RVA = "0x11B3A20", Offset = "0x11B2620", VA = "0x1811B3A20")]
		public SiracusaCharTaskRingItemView()
		{
		}

		// Token: 0x0401F04E RID: 127054
		[Token(Token = "0x401F04E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textRingDesc;

		// Token: 0x0401F04F RID: 127055
		[Token(Token = "0x401F04F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _splitLineGo;

		// Token: 0x0401F050 RID: 127056
		[Token(Token = "0x401F050")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _taskRingLine;

		// Token: 0x0401F051 RID: 127057
		[Token(Token = "0x401F051")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayoutElement _taskListLayout;

		// Token: 0x0401F052 RID: 127058
		[Token(Token = "0x401F052")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _taskListAlphaHandler;

		// Token: 0x0401F053 RID: 127059
		[Token(Token = "0x401F053")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _expandDuration;

		// Token: 0x0401F054 RID: 127060
		[Token(Token = "0x401F054")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SiracusaCharTaskListView _conditionTaskListViewPrefab;

		// Token: 0x0401F055 RID: 127061
		[Token(Token = "0x401F055")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SiracusaCharTaskListView _linearTaskListViewPrefab;

		// Token: 0x0401F056 RID: 127062
		[Token(Token = "0x401F056")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Task Ring Icon")]
		private UIAtlasImage _imgStatus;

		// Token: 0x0401F057 RID: 127063
		[Token(Token = "0x401F057")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Task Ring Icon")]
		private UIAtlasObject _iconStatusAtlas;

		// Token: 0x0401F058 RID: 127064
		[Token(Token = "0x401F058")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Task Ring Icon")]
		private string _iconCompleteName;

		// Token: 0x0401F059 RID: 127065
		[Token(Token = "0x401F059")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Task Ring Icon")]
		private string _iconDoingName;

		// Token: 0x0401F05A RID: 127066
		[Token(Token = "0x401F05A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Task Ring Icon")]
		private string _iconLockedName;

		// Token: 0x0401F05B RID: 127067
		[Token(Token = "0x401F05B")]
		[FieldOffset(Offset = "0x80")]
		private int m_index;

		// Token: 0x0401F05C RID: 127068
		[Token(Token = "0x401F05C")]
		[FieldOffset(Offset = "0x88")]
		private SiracusaCharTaskListView m_listView;

		// Token: 0x0401F05D RID: 127069
		[Token(Token = "0x401F05D")]
		[FieldOffset(Offset = "0x90")]
		private bool m_prevIsLinear;

		// Token: 0x0401F05E RID: 127070
		[Token(Token = "0x401F05E")]
		[FieldOffset(Offset = "0x94")]
		private float m_listHeight;

		// Token: 0x0401F05F RID: 127071
		[Token(Token = "0x401F05F")]
		[FieldOffset(Offset = "0x98")]
		private SiracusaCharTaskRingItemView.FadeTranslationSwitchTween m_switchTween;

		// Token: 0x0401F060 RID: 127072
		[Token(Token = "0x401F060")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x0401F063 RID: 127075
		[Token(Token = "0x401F063")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onRingSelect;

		// Token: 0x0401F064 RID: 127076
		[Token(Token = "0x401F064")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onRingSelect;

		// Token: 0x0401F065 RID: 127077
		[Token(Token = "0x401F065")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onTaskClick;

		// Token: 0x0401F066 RID: 127078
		[Token(Token = "0x401F066")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onTaskClick;

		// Token: 0x0401F067 RID: 127079
		[Token(Token = "0x401F067")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F068 RID: 127080
		[Token(Token = "0x401F068")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F069 RID: 127081
		[Token(Token = "0x401F069")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateListViewIfNeed;

		// Token: 0x0401F06A RID: 127082
		[Token(Token = "0x401F06A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateStatusIcon;

		// Token: 0x0401F06B RID: 127083
		[Token(Token = "0x401F06B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnSelectRing;

		// Token: 0x0401F06C RID: 127084
		[Token(Token = "0x401F06C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F16 RID: 16150
		[Token(Token = "0x2003F16")]
		public class FadeTranslationSwitchTween : UISwitchTween
		{
			// Token: 0x06019135 RID: 102709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019135")]
			[Address(RVA = "0x11AD370", Offset = "0x11ABF70", VA = "0x1811AD370")]
			public FadeTranslationSwitchTween(SiracusaCharTaskRingItemView closure)
			{
			}

			// Token: 0x06019136 RID: 102710 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019136")]
			[Address(RVA = "0x11ACD10", Offset = "0x11AB910", VA = "0x1811ACD10", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06019137 RID: 102711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019137")]
			[Address(RVA = "0x11ACD70", Offset = "0x11AB970", VA = "0x1811ACD70", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06019138 RID: 102712 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019138")]
			[Address(RVA = "0x11AD0F0", Offset = "0x11ABCF0", VA = "0x1811AD0F0")]
			private UISwitchTween.ITweenHandler _GenerateTween(bool isShow)
			{
				return null;
			}

			// Token: 0x06019139 RID: 102713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019139")]
			[Address(RVA = "0x11ACC70", Offset = "0x11AB870", VA = "0x1811ACC70", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601913A RID: 102714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601913A")]
			[Address(RVA = "0x11ACBD0", Offset = "0x11AB7D0", VA = "0x1811ACBD0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601913B RID: 102715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601913B")]
			[Address(RVA = "0x11ACEF0", Offset = "0x11ABAF0", VA = "0x1811ACEF0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601913C RID: 102716 RVA: 0x0009CED0 File Offset: 0x0009B0D0
			[Token(Token = "0x601913C")]
			[Address(RVA = "0x11ACDD0", Offset = "0x11AB9D0", VA = "0x1811ACDD0")]
			private float GetTargetAlpha(bool isShow)
			{
				return 0f;
			}

			// Token: 0x0601913D RID: 102717 RVA: 0x0009CEE8 File Offset: 0x0009B0E8
			[Token(Token = "0x601913D")]
			[Address(RVA = "0x11ACE60", Offset = "0x11ABA60", VA = "0x1811ACE60")]
			private float GetTargetHeight(bool isShow)
			{
				return 0f;
			}

			// Token: 0x06019140 RID: 102720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019140")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06019141 RID: 102721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019141")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x06019142 RID: 102722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019142")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0401F06D RID: 127085
			[Token(Token = "0x401F06D")]
			[FieldOffset(Offset = "0x48")]
			private SiracusaCharTaskRingItemView m_closure;

			// Token: 0x0401F06E RID: 127086
			[Token(Token = "0x401F06E")]
			[FieldOffset(Offset = "0x50")]
			private CanvasGroup m_alphaHandler;

			// Token: 0x0401F06F RID: 127087
			[Token(Token = "0x401F06F")]
			[FieldOffset(Offset = "0x58")]
			private LayoutElement m_layoutElement;

			// Token: 0x0401F070 RID: 127088
			[Token(Token = "0x401F070")]
			[FieldOffset(Offset = "0x60")]
			private Graphic m_line;

			// Token: 0x0401F071 RID: 127089
			[Token(Token = "0x401F071")]
			[FieldOffset(Offset = "0x68")]
			private float m_duration;

			// Token: 0x0401F072 RID: 127090
			[Token(Token = "0x401F072")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F073 RID: 127091
			[Token(Token = "0x401F073")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0401F074 RID: 127092
			[Token(Token = "0x401F074")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0401F075 RID: 127093
			[Token(Token = "0x401F075")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GenerateTween;

			// Token: 0x0401F076 RID: 127094
			[Token(Token = "0x401F076")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0401F077 RID: 127095
			[Token(Token = "0x401F077")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0401F078 RID: 127096
			[Token(Token = "0x401F078")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0401F079 RID: 127097
			[Token(Token = "0x401F079")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetTargetAlpha;

			// Token: 0x0401F07A RID: 127098
			[Token(Token = "0x401F07A")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_GetTargetHeight;

			// Token: 0x02003F17 RID: 16151
			[Token(Token = "0x2003F17")]
			private class TweenHandler : UISwitchTween.ITweenHandler, IHotfixable
			{
				// Token: 0x06019143 RID: 102723 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6019143")]
				[Address(RVA = "0x11C39C0", Offset = "0x11C25C0", VA = "0x1811C39C0")]
				public TweenHandler(Tween alpha, Tween pos, Tween line)
				{
				}

				// Token: 0x06019144 RID: 102724 RVA: 0x0009CF18 File Offset: 0x0009B118
				[Token(Token = "0x6019144")]
				[Address(RVA = "0x11C3740", Offset = "0x11C2340", VA = "0x1811C3740", Slot = "6")]
				public bool IsPlaying()
				{
					return default(bool);
				}

				// Token: 0x06019145 RID: 102725 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6019145")]
				[Address(RVA = "0x11C37C0", Offset = "0x11C23C0", VA = "0x1811C37C0", Slot = "7")]
				public void KillIfNecessary()
				{
				}

				// Token: 0x06019146 RID: 102726 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6019146")]
				[Address(RVA = "0x11C3870", Offset = "0x11C2470", VA = "0x1811C3870", Slot = "5")]
				public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback)
				{
					return null;
				}

				// Token: 0x06019147 RID: 102727 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6019147")]
				[Address(RVA = "0x11C3900", Offset = "0x11C2500", VA = "0x1811C3900", Slot = "4")]
				public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill)
				{
					return null;
				}

				// Token: 0x0401F07B RID: 127099
				[Token(Token = "0x401F07B")]
				[FieldOffset(Offset = "0x10")]
				private Tween m_alphaTweener;

				// Token: 0x0401F07C RID: 127100
				[Token(Token = "0x401F07C")]
				[FieldOffset(Offset = "0x18")]
				private Tween m_posTweener;

				// Token: 0x0401F07D RID: 127101
				[Token(Token = "0x401F07D")]
				[FieldOffset(Offset = "0x20")]
				private Tween m_lineTweener;

				// Token: 0x0401F07E RID: 127102
				[Token(Token = "0x401F07E")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x0401F07F RID: 127103
				[Token(Token = "0x401F07F")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_IsPlaying;

				// Token: 0x0401F080 RID: 127104
				[Token(Token = "0x401F080")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_KillIfNecessary;

				// Token: 0x0401F081 RID: 127105
				[Token(Token = "0x401F081")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_OnComplete;

				// Token: 0x0401F082 RID: 127106
				[Token(Token = "0x401F082")]
				[FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_SetAutoKill;
			}
		}
	}
}
