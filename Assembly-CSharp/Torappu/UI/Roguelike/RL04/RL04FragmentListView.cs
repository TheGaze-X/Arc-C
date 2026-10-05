using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056D5 RID: 22229
	[Token(Token = "0x20056D5")]
	public class RL04FragmentListView : DataBinder<RL04FragmentProperty>, IHotfixable
	{
		// Token: 0x17004C62 RID: 19554
		// (get) Token: 0x0602099A RID: 133530 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602099B RID: 133531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C62")]
		public ILoadAsset loader
		{
			[Token(Token = "0x602099A")]
			[Address(RVA = "0x1ABEC10", Offset = "0x1ABD810", VA = "0x181ABEC10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602099B")]
			[Address(RVA = "0x1ABED30", Offset = "0x1ABD930", VA = "0x181ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C63 RID: 19555
		// (get) Token: 0x0602099C RID: 133532 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602099D RID: 133533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C63")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x602099C")]
			[Address(RVA = "0x1ABEC70", Offset = "0x1ABD870", VA = "0x181ABEC70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602099D")]
			[Address(RVA = "0x1ABEDB0", Offset = "0x1ABD9B0", VA = "0x181ABEDB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C64 RID: 19556
		// (get) Token: 0x0602099E RID: 133534 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602099F RID: 133535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C64")]
		public Action onSwitchBtnClicked
		{
			[Token(Token = "0x602099E")]
			[Address(RVA = "0x1ABECD0", Offset = "0x1ABD8D0", VA = "0x181ABECD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602099F")]
			[Address(RVA = "0x1ABEE30", Offset = "0x1ABDA30", VA = "0x181ABEE30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060209A0 RID: 133536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209A0")]
		[Address(RVA = "0x1ABE5D0", Offset = "0x1ABD1D0", VA = "0x181ABE5D0", Slot = "7")]
		public override void OnValueChanged(RL04FragmentProperty property)
		{
		}

		// Token: 0x060209A1 RID: 133537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209A1")]
		[Address(RVA = "0x1ABE4C0", Offset = "0x1ABD0C0", VA = "0x181ABE4C0")]
		public void EventOnListSwitchBtnClicked()
		{
		}

		// Token: 0x060209A2 RID: 133538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209A2")]
		[Address(RVA = "0x1ABE940", Offset = "0x1ABD540", VA = "0x181ABE940")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060209A3 RID: 133539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209A3")]
		[Address(RVA = "0x1ABE740", Offset = "0x1ABD340", VA = "0x181ABE740")]
		private void _GenerateSwitchTween(RL04FragmentViewModel model)
		{
		}

		// Token: 0x060209A4 RID: 133540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209A4")]
		[Address(RVA = "0x1ABEB90", Offset = "0x1ABD790", VA = "0x181ABEB90")]
		public RL04FragmentListView()
		{
		}

		// Token: 0x0402C311 RID: 181009
		[Token(Token = "0x402C311")]
		private const float ALPHA_FADE_OUT = 0f;

		// Token: 0x0402C312 RID: 181010
		[Token(Token = "0x402C312")]
		private const float ALPHA_FADE_IN = 1f;

		// Token: 0x0402C313 RID: 181011
		[Token(Token = "0x402C313")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402C314 RID: 181012
		[Token(Token = "0x402C314")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNotEmpty;

		// Token: 0x0402C315 RID: 181013
		[Token(Token = "0x402C315")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animBtnSwitch;

		// Token: 0x0402C316 RID: 181014
		[Token(Token = "0x402C316")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL04FragmentListAdapter _adapter;

		// Token: 0x0402C317 RID: 181015
		[Token(Token = "0x402C317")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroupList;

		// Token: 0x0402C318 RID: 181016
		[Token(Token = "0x402C318")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _fadeTime;

		// Token: 0x0402C31C RID: 181020
		[Token(Token = "0x402C31C")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0402C31D RID: 181021
		[Token(Token = "0x402C31D")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_switchTween;

		// Token: 0x0402C31E RID: 181022
		[Token(Token = "0x402C31E")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeFragmentDialogListType m_cachedListType;

		// Token: 0x0402C31F RID: 181023
		[Token(Token = "0x402C31F")]
		[FieldOffset(Offset = "0x88")]
		private UISwitchTween m_btnSwitchTween;

		// Token: 0x0402C320 RID: 181024
		[Token(Token = "0x402C320")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x0402C321 RID: 181025
		[Token(Token = "0x402C321")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x0402C322 RID: 181026
		[Token(Token = "0x402C322")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0402C323 RID: 181027
		[Token(Token = "0x402C323")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0402C324 RID: 181028
		[Token(Token = "0x402C324")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onSwitchBtnClicked;

		// Token: 0x0402C325 RID: 181029
		[Token(Token = "0x402C325")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onSwitchBtnClicked;

		// Token: 0x0402C326 RID: 181030
		[Token(Token = "0x402C326")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402C327 RID: 181031
		[Token(Token = "0x402C327")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnListSwitchBtnClicked;

		// Token: 0x0402C328 RID: 181032
		[Token(Token = "0x402C328")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C329 RID: 181033
		[Token(Token = "0x402C329")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenerateSwitchTween;

		// Token: 0x0402C32A RID: 181034
		[Token(Token = "0x402C32A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
