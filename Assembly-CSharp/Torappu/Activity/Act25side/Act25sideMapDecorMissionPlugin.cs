using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074DA RID: 29914
	[Token(Token = "0x20074DA")]
	public class Act25sideMapDecorMissionPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602A2BC RID: 172732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2BC")]
		[Address(RVA = "0x25C9F70", Offset = "0x25C8B70", VA = "0x1825C9F70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A2BD RID: 172733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2BD")]
		[Address(RVA = "0x25C9D80", Offset = "0x25C8980", VA = "0x1825C9D80", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A2BE RID: 172734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2BE")]
		[Address(RVA = "0x25C9C70", Offset = "0x25C8870", VA = "0x1825C9C70")]
		public void OnButtonClicked()
		{
		}

		// Token: 0x0602A2BF RID: 172735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2BF")]
		[Address(RVA = "0x25C9D00", Offset = "0x25C8900", VA = "0x1825C9D00")]
		public void OnCloseButtonClicked()
		{
		}

		// Token: 0x0602A2C0 RID: 172736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2C0")]
		[Address(RVA = "0x25CA170", Offset = "0x25C8D70", VA = "0x1825CA170")]
		public Act25sideMapDecorMissionPlugin()
		{
		}

		// Token: 0x0403C94E RID: 248142
		[Token(Token = "0x403C94E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasBtnNormal;

		// Token: 0x0403C94F RID: 248143
		[Token(Token = "0x403C94F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasBtnSelected;

		// Token: 0x0403C950 RID: 248144
		[Token(Token = "0x403C950")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textBtn;

		// Token: 0x0403C951 RID: 248145
		[Token(Token = "0x403C951")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorBtnNormal;

		// Token: 0x0403C952 RID: 248146
		[Token(Token = "0x403C952")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorBtnSelected;

		// Token: 0x0403C953 RID: 248147
		[Token(Token = "0x403C953")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x0403C954 RID: 248148
		[Token(Token = "0x403C954")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _fullscreenRaycast;

		// Token: 0x0403C955 RID: 248149
		[Token(Token = "0x403C955")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _missionGroupView;

		// Token: 0x0403C956 RID: 248150
		[Token(Token = "0x403C956")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasMissionGroup;

		// Token: 0x0403C957 RID: 248151
		[Token(Token = "0x403C957")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _posHandler;

		// Token: 0x0403C958 RID: 248152
		[Token(Token = "0x403C958")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _posHide;

		// Token: 0x0403C959 RID: 248153
		[Token(Token = "0x403C959")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _posShow;

		// Token: 0x0403C95A RID: 248154
		[Token(Token = "0x403C95A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _pnlButton;

		// Token: 0x0403C95B RID: 248155
		[Token(Token = "0x403C95B")]
		[FieldOffset(Offset = "0x98")]
		private Act25sideMapDecorMissionPlugin.SwitchTween m_showSwitchTween;

		// Token: 0x0403C95C RID: 248156
		[Token(Token = "0x403C95C")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x0403C95D RID: 248157
		[Token(Token = "0x403C95D")]
		[FieldOffset(Offset = "0xA8")]
		private List<Act25sideMapDecorMissionViewModel> m_cachedMissionGroup;

		// Token: 0x0403C95E RID: 248158
		[Token(Token = "0x403C95E")]
		[FieldOffset(Offset = "0xB0")]
		private Act25sideMapDecorMissionPlugin.Adapter m_adapter;

		// Token: 0x0403C95F RID: 248159
		[Token(Token = "0x403C95F")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_cachedValid;

		// Token: 0x0403C960 RID: 248160
		[Token(Token = "0x403C960")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C961 RID: 248161
		[Token(Token = "0x403C961")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C962 RID: 248162
		[Token(Token = "0x403C962")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnButtonClicked;

		// Token: 0x0403C963 RID: 248163
		[Token(Token = "0x403C963")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCloseButtonClicked;

		// Token: 0x0403C964 RID: 248164
		[Token(Token = "0x403C964")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074DB RID: 29915
		[Token(Token = "0x20074DB")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x0602A2C1 RID: 172737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2C1")]
			[Address(RVA = "0x25D9980", Offset = "0x25D8580", VA = "0x1825D9980")]
			public SwitchTween(Act25sideMapDecorMissionPlugin closure)
			{
			}

			// Token: 0x0602A2C2 RID: 172738 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A2C2")]
			[Address(RVA = "0x25D9200", Offset = "0x25D7E00", VA = "0x1825D9200", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602A2C3 RID: 172739 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A2C3")]
			[Address(RVA = "0x25D94A0", Offset = "0x25D80A0", VA = "0x1825D94A0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602A2C4 RID: 172740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2C4")]
			[Address(RVA = "0x25D9160", Offset = "0x25D7D60", VA = "0x1825D9160", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0602A2C5 RID: 172741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2C5")]
			[Address(RVA = "0x25D90C0", Offset = "0x25D7CC0", VA = "0x1825D90C0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0602A2C6 RID: 172742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2C6")]
			[Address(RVA = "0x25D9740", Offset = "0x25D8340", VA = "0x1825D9740", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602A2C7 RID: 172743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2C7")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602A2C8 RID: 172744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2C8")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602A2C9 RID: 172745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2C9")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403C965 RID: 248165
			[Token(Token = "0x403C965")]
			[FieldOffset(Offset = "0x48")]
			private Act25sideMapDecorMissionPlugin m_closure;

			// Token: 0x0403C966 RID: 248166
			[Token(Token = "0x403C966")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403C967 RID: 248167
			[Token(Token = "0x403C967")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403C968 RID: 248168
			[Token(Token = "0x403C968")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403C969 RID: 248169
			[Token(Token = "0x403C969")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403C96A RID: 248170
			[Token(Token = "0x403C96A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0403C96B RID: 248171
			[Token(Token = "0x403C96B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x020074DC RID: 29916
		[Token(Token = "0x20074DC")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700635A RID: 25434
			// (get) Token: 0x0602A2CA RID: 172746 RVA: 0x000D79E8 File Offset: 0x000D5BE8
			[Token(Token = "0x1700635A")]
			public override int count
			{
				[Token(Token = "0x602A2CA")]
				[Address(RVA = "0x25D4710", Offset = "0x25D3310", VA = "0x1825D4710", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A2CB RID: 172747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2CB")]
			[Address(RVA = "0x25D4690", Offset = "0x25D3290", VA = "0x1825D4690")]
			public Adapter(Act25sideMapDecorMissionPlugin closure)
			{
			}

			// Token: 0x0602A2CC RID: 172748 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A2CC")]
			[Address(RVA = "0x25D44E0", Offset = "0x25D30E0", VA = "0x1825D44E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403C96C RID: 248172
			[Token(Token = "0x403C96C")]
			[FieldOffset(Offset = "0x20")]
			private Act25sideMapDecorMissionPlugin m_closure;

			// Token: 0x0403C96D RID: 248173
			[Token(Token = "0x403C96D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403C96E RID: 248174
			[Token(Token = "0x403C96E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403C96F RID: 248175
			[Token(Token = "0x403C96F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
