using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200417C RID: 16764
	[Token(Token = "0x200417C")]
	public class SandboxV2RiftSettleView : DataBinder<SandboxV2RiftSettleProperty>
	{
		// Token: 0x06019DEE RID: 105966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DEE")]
		[Address(RVA = "0x12C8A30", Offset = "0x12C7630", VA = "0x1812C8A30", Slot = "7")]
		public override void OnValueChanged(SandboxV2RiftSettleProperty property)
		{
		}

		// Token: 0x06019DEF RID: 105967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DEF")]
		[Address(RVA = "0x12C94A0", Offset = "0x12C80A0", VA = "0x1812C94A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019DF0 RID: 105968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DF0")]
		[Address(RVA = "0x12C8990", Offset = "0x12C7590", VA = "0x1812C8990")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x06019DF1 RID: 105969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DF1")]
		[Address(RVA = "0x12C87B0", Offset = "0x12C73B0", VA = "0x1812C87B0")]
		public void OnBackgroundClicked()
		{
		}

		// Token: 0x06019DF2 RID: 105970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019DF2")]
		[Address(RVA = "0x12C9D30", Offset = "0x12C8930", VA = "0x1812C9D30")]
		private IEnumerator _UpdateInternalStateCoroutine()
		{
			return null;
		}

		// Token: 0x06019DF3 RID: 105971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DF3")]
		[Address(RVA = "0x12C9A20", Offset = "0x12C8620", VA = "0x1812C9A20")]
		private void _OnEnterAnimComplete()
		{
		}

		// Token: 0x06019DF4 RID: 105972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DF4")]
		[Address(RVA = "0x12C9A80", Offset = "0x12C8680", VA = "0x1812C9A80")]
		private void _OnRewardAppearAnimComplete()
		{
		}

		// Token: 0x06019DF5 RID: 105973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DF5")]
		[Address(RVA = "0x12C99C0", Offset = "0x12C85C0", VA = "0x1812C99C0")]
		private void _OnConfirmBtnAnimComplete()
		{
		}

		// Token: 0x06019DF6 RID: 105974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DF6")]
		[Address(RVA = "0x12C9830", Offset = "0x12C8430", VA = "0x1812C9830")]
		private void _JumpToRewardShowAnimEnd()
		{
		}

		// Token: 0x06019DF7 RID: 105975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019DF7")]
		[Address(RVA = "0x12C9C80", Offset = "0x12C8880", VA = "0x1812C9C80")]
		private IEnumerator _PlayRewardShowAnim()
		{
			return null;
		}

		// Token: 0x06019DF8 RID: 105976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DF8")]
		[Address(RVA = "0x12C9AE0", Offset = "0x12C86E0", VA = "0x1812C9AE0")]
		private void _PlayAnim(ref UIAnimationLocation anim, ref Tween tween, float delay, [Optional] TweenCallback callback)
		{
		}

		// Token: 0x06019DF9 RID: 105977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DF9")]
		[Address(RVA = "0x12C9DE0", Offset = "0x12C89E0", VA = "0x1812C9DE0")]
		public SandboxV2RiftSettleView()
		{
		}

		// Token: 0x04020815 RID: 133141
		[Token(Token = "0x4020815")]
		private const string PORT_HP_FORMAT = "{0}%";

		// Token: 0x04020816 RID: 133142
		[Token(Token = "0x4020816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Left")]
		private TwoStateToggle _leftMainToggle;

		// Token: 0x04020817 RID: 133143
		[Token(Token = "0x4020817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Left")]
		private Text _mainTargetTitle;

		// Token: 0x04020818 RID: 133144
		[Token(Token = "0x4020818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Left")]
		private GameObject _difficultyGo;

		// Token: 0x04020819 RID: 133145
		[Token(Token = "0x4020819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Left")]
		private Text _difficultyLevel;

		// Token: 0x0402081A RID: 133146
		[Token(Token = "0x402081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Right Upper")]
		private Text _portHpPercent;

		// Token: 0x0402081B RID: 133147
		[Token(Token = "0x402081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Right Upper")]
		private UIAtlasImage _portHpBg;

		// Token: 0x0402081C RID: 133148
		[Token(Token = "0x402081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Right Upper")]
		private Color _hpTextSafe;

		// Token: 0x0402081D RID: 133149
		[Token(Token = "0x402081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Right Upper")]
		private Color _hpTextDanger;

		// Token: 0x0402081E RID: 133150
		[Token(Token = "0x402081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Right Upper")]
		private Color _hpBgSafe;

		// Token: 0x0402081F RID: 133151
		[Token(Token = "0x402081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Right Upper")]
		private Color _hpBgDanger;

		// Token: 0x04020820 RID: 133152
		[Token(Token = "0x4020820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Right Upper")]
		private TwoStateToggle _portToggle;

		// Token: 0x04020821 RID: 133153
		[Token(Token = "0x4020821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Right Upper")]
		private Text _teamName;

		// Token: 0x04020822 RID: 133154
		[Token(Token = "0x4020822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Right Upper")]
		private Image _teamIcon;

		// Token: 0x04020823 RID: 133155
		[Token(Token = "0x4020823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Right Upper")]
		private Text _stayDayCount;

		// Token: 0x04020824 RID: 133156
		[Token(Token = "0x4020824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Right Middle")]
		private TwoStateToggle _mainTargetToggle;

		// Token: 0x04020825 RID: 133157
		[Token(Token = "0x4020825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Right Middle")]
		private Text _mainTargetDesc;

		// Token: 0x04020826 RID: 133158
		[Token(Token = "0x4020826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Right Middle")]
		private Text _mainTargetProgress;

		// Token: 0x04020827 RID: 133159
		[Token(Token = "0x4020827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Right Middle")]
		private TwoStateToggle _subTargetToggle;

		// Token: 0x04020828 RID: 133160
		[Token(Token = "0x4020828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Right Middle")]
		private Text _subTargetDesc;

		// Token: 0x04020829 RID: 133161
		[Token(Token = "0x4020829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Right Middle")]
		private Text _subTargetProgress;

		// Token: 0x0402082A RID: 133162
		[Token(Token = "0x402082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Right Middle")]
		private GameObject[] _hideWhenNoSubTarget;

		// Token: 0x0402082B RID: 133163
		[Token(Token = "0x402082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Lower")]
		private GameObject _rewardIcon;

		// Token: 0x0402082C RID: 133164
		[Token(Token = "0x402082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Lower")]
		private GameObject _mainRewardGo;

		// Token: 0x0402082D RID: 133165
		[Token(Token = "0x402082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Lower")]
		private SimpleLayoutContent _mainRewardContent;

		// Token: 0x0402082E RID: 133166
		[Token(Token = "0x402082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Lower")]
		private UIAnimationLocation _mainRewardTitleAnim;

		// Token: 0x0402082F RID: 133167
		[Token(Token = "0x402082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Lower")]
		private GameObject _subRewardGo;

		// Token: 0x04020830 RID: 133168
		[Token(Token = "0x4020830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Lower")]
		private SimpleLayoutContent _subRewardContent;

		// Token: 0x04020831 RID: 133169
		[Token(Token = "0x4020831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Lower")]
		private UIAnimationLocation _subRewardTitleAnim;

		// Token: 0x04020832 RID: 133170
		[Token(Token = "0x4020832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Lower")]
		private Text _mainRewardTitleWhite;

		// Token: 0x04020833 RID: 133171
		[Token(Token = "0x4020833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Lower")]
		private Text _mainRewardTitleColor;

		// Token: 0x04020834 RID: 133172
		[Token(Token = "0x4020834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private RectTransform _backClickArea;

		// Token: 0x04020835 RID: 133173
		[Token(Token = "0x4020835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04020836 RID: 133174
		[Token(Token = "0x4020836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private UIAnimationLocation _leftTargetLoopAnim;

		// Token: 0x04020837 RID: 133175
		[Token(Token = "0x4020837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private UIAnimationLocation _confirmBtnAnim;

		// Token: 0x04020838 RID: 133176
		[Token(Token = "0x4020838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Anim Params")]
		private float _rewardShowDelay;

		// Token: 0x04020839 RID: 133177
		[Token(Token = "0x4020839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[SerializeField]
		[Group("Anim Params")]
		private float _rewardCanSkipTime;

		// Token: 0x0402083A RID: 133178
		[Token(Token = "0x402083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("Anim Params")]
		private float _rewardShowInterval;

		// Token: 0x0402083B RID: 133179
		[Token(Token = "0x402083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[SerializeField]
		[Group("Anim Params")]
		private int _rewardTitleShowCount;

		// Token: 0x0402083C RID: 133180
		[Token(Token = "0x402083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool m_hasInited;

		// Token: 0x0402083D RID: 133181
		[Token(Token = "0x402083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private SandboxV2RiftSettleViewModel m_model;

		// Token: 0x0402083E RID: 133182
		[Token(Token = "0x402083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private SandboxV2RiftSettleView.RewardAdapter m_mainRewardAdapter;

		// Token: 0x0402083F RID: 133183
		[Token(Token = "0x402083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private SandboxV2RiftSettleView.RewardAdapter m_subRewardAdapter;

		// Token: 0x04020840 RID: 133184
		[Token(Token = "0x4020840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Tween m_tween;

		// Token: 0x04020841 RID: 133185
		[Token(Token = "0x4020841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Tween m_mainRewardTitleTween;

		// Token: 0x04020842 RID: 133186
		[Token(Token = "0x4020842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Tween m_subRewardTitleTween;

		// Token: 0x04020843 RID: 133187
		[Token(Token = "0x4020843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04020844 RID: 133188
		[Token(Token = "0x4020844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private SandboxV2RiftSettleView.InternalState m_state;

		// Token: 0x04020845 RID: 133189
		[Token(Token = "0x4020845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020846 RID: 133190
		[Token(Token = "0x4020846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Coroutine m_rewardAppearCoroutine;

		// Token: 0x04020847 RID: 133191
		[Token(Token = "0x4020847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020848 RID: 133192
		[Token(Token = "0x4020848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020849 RID: 133193
		[Token(Token = "0x4020849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x0402084A RID: 133194
		[Token(Token = "0x402084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackgroundClicked;

		// Token: 0x0402084B RID: 133195
		[Token(Token = "0x402084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateInternalStateCoroutine;

		// Token: 0x0402084C RID: 133196
		[Token(Token = "0x402084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnEnterAnimComplete;

		// Token: 0x0402084D RID: 133197
		[Token(Token = "0x402084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnRewardAppearAnimComplete;

		// Token: 0x0402084E RID: 133198
		[Token(Token = "0x402084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnConfirmBtnAnimComplete;

		// Token: 0x0402084F RID: 133199
		[Token(Token = "0x402084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__JumpToRewardShowAnimEnd;

		// Token: 0x04020850 RID: 133200
		[Token(Token = "0x4020850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayRewardShowAnim;

		// Token: 0x04020851 RID: 133201
		[Token(Token = "0x4020851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x04020852 RID: 133202
		[Token(Token = "0x4020852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200417D RID: 16765
		[Token(Token = "0x200417D")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003D9E RID: 15774
			// (get) Token: 0x06019DFA RID: 105978 RVA: 0x0009F960 File Offset: 0x0009DB60
			[Token(Token = "0x17003D9E")]
			public override int count
			{
				[Token(Token = "0x6019DFA")]
				[Address(RVA = "0x12B7C10", Offset = "0x12B6810", VA = "0x1812B7C10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019DFB RID: 105979 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019DFB")]
			[Address(RVA = "0x12B76D0", Offset = "0x12B62D0", VA = "0x1812B76D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019DFC RID: 105980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019DFC")]
			[Address(RVA = "0x12B7560", Offset = "0x12B6160", VA = "0x1812B7560")]
			public void PlayRewardAnim(float interval)
			{
			}

			// Token: 0x06019DFD RID: 105981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019DFD")]
			[Address(RVA = "0x12B7930", Offset = "0x12B6530", VA = "0x1812B7930")]
			public void ResetTween(bool isEnd)
			{
			}

			// Token: 0x06019DFE RID: 105982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019DFE")]
			[Address(RVA = "0x12B7AA0", Offset = "0x12B66A0", VA = "0x1812B7AA0")]
			private void _OnItemClick(int index)
			{
			}

			// Token: 0x06019DFF RID: 105983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019DFF")]
			[Address(RVA = "0x12B7BB0", Offset = "0x12B67B0", VA = "0x1812B7BB0")]
			public RewardAdapter()
			{
			}

			// Token: 0x04020853 RID: 133203
			[Token(Token = "0x4020853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<UIItemViewModel> rewards;

			// Token: 0x04020854 RID: 133204
			[Token(Token = "0x4020854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020855 RID: 133205
			[Token(Token = "0x4020855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04020856 RID: 133206
			[Token(Token = "0x4020856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_PlayRewardAnim;

			// Token: 0x04020857 RID: 133207
			[Token(Token = "0x4020857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetTween;

			// Token: 0x04020858 RID: 133208
			[Token(Token = "0x4020858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__OnItemClick;

			// Token: 0x04020859 RID: 133209
			[Token(Token = "0x4020859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200417E RID: 16766
		[Token(Token = "0x200417E")]
		private enum InternalState
		{
			// Token: 0x0402085B RID: 133211
			[Token(Token = "0x402085B")]
			NONE,
			// Token: 0x0402085C RID: 133212
			[Token(Token = "0x402085C")]
			IDLE_ENTER,
			// Token: 0x0402085D RID: 133213
			[Token(Token = "0x402085D")]
			IDLE_REWARD,
			// Token: 0x0402085E RID: 133214
			[Token(Token = "0x402085E")]
			IDLE_CONFIRM,
			// Token: 0x0402085F RID: 133215
			[Token(Token = "0x402085F")]
			ANIM_ENTER,
			// Token: 0x04020860 RID: 133216
			[Token(Token = "0x4020860")]
			ANIM_REWARD_APPEAR,
			// Token: 0x04020861 RID: 133217
			[Token(Token = "0x4020861")]
			CONFIRM_BTN_APPEAR,
			// Token: 0x04020862 RID: 133218
			[Token(Token = "0x4020862")]
			END
		}
	}
}
