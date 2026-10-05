using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A87 RID: 27271
	[Token(Token = "0x2006A87")]
	public class StageMixStoryBriefTagView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602704F RID: 159823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602704F")]
		[Address(RVA = "0x223DCE0", Offset = "0x223C8E0", VA = "0x18223DCE0")]
		public void Render(List<StageStorylineTagViewModel> tags)
		{
		}

		// Token: 0x06027050 RID: 159824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027050")]
		[Address(RVA = "0x223DAD0", Offset = "0x223C6D0", VA = "0x18223DAD0")]
		public void OnSwitchEvent()
		{
		}

		// Token: 0x06027051 RID: 159825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027051")]
		[Address(RVA = "0x223E1C0", Offset = "0x223CDC0", VA = "0x18223E1C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027052 RID: 159826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027052")]
		[Address(RVA = "0x223E3C0", Offset = "0x223CFC0", VA = "0x18223E3C0")]
		private void _ResetSwitch()
		{
		}

		// Token: 0x06027053 RID: 159827 RVA: 0x000CD488 File Offset: 0x000CB688
		[Token(Token = "0x6027053")]
		[Address(RVA = "0x223E160", Offset = "0x223CD60", VA = "0x18223E160")]
		private float _GetPosition()
		{
			return 0f;
		}

		// Token: 0x06027054 RID: 159828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027054")]
		[Address(RVA = "0x223E4F0", Offset = "0x223D0F0", VA = "0x18223E4F0")]
		private void _SetPosition(float position)
		{
		}

		// Token: 0x06027055 RID: 159829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027055")]
		[Address(RVA = "0x223E310", Offset = "0x223CF10", VA = "0x18223E310")]
		private IEnumerator _LockSwitchForContentHeightCoroutine()
		{
			return null;
		}

		// Token: 0x06027056 RID: 159830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027056")]
		[Address(RVA = "0x223E5F0", Offset = "0x223D1F0", VA = "0x18223E5F0")]
		public StageMixStoryBriefTagView()
		{
		}

		// Token: 0x04037329 RID: 226089
		[Token(Token = "0x4037329")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _tagContent;

		// Token: 0x0403732A RID: 226090
		[Token(Token = "0x403732A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayoutGroup _tagLayout;

		// Token: 0x0403732B RID: 226091
		[Token(Token = "0x403732B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _tagViewport;

		// Token: 0x0403732C RID: 226092
		[Token(Token = "0x403732C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _defaultLayer;

		// Token: 0x0403732D RID: 226093
		[Token(Token = "0x403732D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _expandedLayer;

		// Token: 0x0403732E RID: 226094
		[Token(Token = "0x403732E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _canSwitchPanels;

		// Token: 0x0403732F RID: 226095
		[Token(Token = "0x403732F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _switchDuration;

		// Token: 0x04037330 RID: 226096
		[Token(Token = "0x4037330")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Ease _switchEase;

		// Token: 0x04037331 RID: 226097
		[Token(Token = "0x4037331")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04037332 RID: 226098
		[Token(Token = "0x4037332")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_finder;

		// Token: 0x04037333 RID: 226099
		[Token(Token = "0x4037333")]
		[FieldOffset(Offset = "0x68")]
		private float m_initHeight;

		// Token: 0x04037334 RID: 226100
		[Token(Token = "0x4037334")]
		[FieldOffset(Offset = "0x70")]
		private StageMixStoryBriefTagView.Adapter m_adapter;

		// Token: 0x04037335 RID: 226101
		[Token(Token = "0x4037335")]
		[FieldOffset(Offset = "0x78")]
		private float m_contentHeight;

		// Token: 0x04037336 RID: 226102
		[Token(Token = "0x4037336")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_canSwitch;

		// Token: 0x04037337 RID: 226103
		[Token(Token = "0x4037337")]
		[FieldOffset(Offset = "0x7D")]
		private bool m_lock;

		// Token: 0x04037338 RID: 226104
		[Token(Token = "0x4037338")]
		[FieldOffset(Offset = "0x80")]
		private Coroutine m_lockCoroutine;

		// Token: 0x04037339 RID: 226105
		[Token(Token = "0x4037339")]
		[FieldOffset(Offset = "0x88")]
		private bool m_expanded;

		// Token: 0x0403733A RID: 226106
		[Token(Token = "0x403733A")]
		[FieldOffset(Offset = "0x8C")]
		private float m_switchPosition;

		// Token: 0x0403733B RID: 226107
		[Token(Token = "0x403733B")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_switchTween;

		// Token: 0x0403733C RID: 226108
		[Token(Token = "0x403733C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403733D RID: 226109
		[Token(Token = "0x403733D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSwitchEvent;

		// Token: 0x0403733E RID: 226110
		[Token(Token = "0x403733E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403733F RID: 226111
		[Token(Token = "0x403733F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResetSwitch;

		// Token: 0x04037340 RID: 226112
		[Token(Token = "0x4037340")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x04037341 RID: 226113
		[Token(Token = "0x4037341")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetPosition;

		// Token: 0x04037342 RID: 226114
		[Token(Token = "0x4037342")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LockSwitchForContentHeightCoroutine;

		// Token: 0x04037343 RID: 226115
		[Token(Token = "0x4037343")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A88 RID: 27272
		[Token(Token = "0x2006A88")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005C31 RID: 23601
			// (get) Token: 0x06027057 RID: 159831 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027058 RID: 159832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005C31")]
			public List<StageStorylineTagViewModel> dataSource
			{
				[Token(Token = "0x6027057")]
				[Address(RVA = "0x2236640", Offset = "0x2235240", VA = "0x182236640")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027058")]
				[Address(RVA = "0x2236760", Offset = "0x2235360", VA = "0x182236760")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005C32 RID: 23602
			// (get) Token: 0x06027059 RID: 159833 RVA: 0x000CD4A0 File Offset: 0x000CB6A0
			[Token(Token = "0x17005C32")]
			public override int count
			{
				[Token(Token = "0x6027059")]
				[Address(RVA = "0x22364C0", Offset = "0x22350C0", VA = "0x1822364C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602705A RID: 159834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602705A")]
			[Address(RVA = "0x2236030", Offset = "0x2234C30", VA = "0x182236030", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602705B RID: 159835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602705B")]
			[Address(RVA = "0x22363E0", Offset = "0x2234FE0", VA = "0x1822363E0")]
			public Adapter()
			{
			}

			// Token: 0x04037345 RID: 226117
			[Token(Token = "0x4037345")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSource;

			// Token: 0x04037346 RID: 226118
			[Token(Token = "0x4037346")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSource;

			// Token: 0x04037347 RID: 226119
			[Token(Token = "0x4037347")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037348 RID: 226120
			[Token(Token = "0x4037348")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04037349 RID: 226121
			[Token(Token = "0x4037349")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
