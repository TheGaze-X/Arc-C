using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050E1 RID: 20705
	[Token(Token = "0x20050E1")]
	public class EmoticonPagerPanelView : EmoticonPanelBaseView
	{
		// Token: 0x0601E9C7 RID: 125383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9C7")]
		[Address(RVA = "0x183ACE0", Offset = "0x18398E0", VA = "0x18183ACE0", Slot = "9")]
		public override void Init(ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601E9C8 RID: 125384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9C8")]
		[Address(RVA = "0x183B400", Offset = "0x183A000", VA = "0x18183B400", Slot = "8")]
		protected override void _Render(EmoticonPanelBaseModel baseModel)
		{
		}

		// Token: 0x0601E9C9 RID: 125385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9C9")]
		[Address(RVA = "0x183AEC0", Offset = "0x1839AC0", VA = "0x18183AEC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E9CA RID: 125386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9CA")]
		[Address(RVA = "0x183B370", Offset = "0x1839F70", VA = "0x18183B370")]
		private void _OnPageValueChanged(float value)
		{
		}

		// Token: 0x0601E9CB RID: 125387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9CB")]
		[Address(RVA = "0x183B2F0", Offset = "0x1839EF0", VA = "0x18183B2F0")]
		private void _OnPageIndexChanged(int index)
		{
		}

		// Token: 0x0601E9CC RID: 125388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9CC")]
		[Address(RVA = "0x183AD60", Offset = "0x1839960", VA = "0x18183AD60")]
		public void OnClickLeftButton()
		{
		}

		// Token: 0x0601E9CD RID: 125389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9CD")]
		[Address(RVA = "0x183ADD0", Offset = "0x18399D0", VA = "0x18183ADD0")]
		public void OnClickRightButton()
		{
		}

		// Token: 0x0601E9CE RID: 125390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9CE")]
		[Address(RVA = "0x183AE40", Offset = "0x1839A40", VA = "0x18183AE40")]
		public void OnClosePanel()
		{
		}

		// Token: 0x0601E9CF RID: 125391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9CF")]
		[Address(RVA = "0x183B9B0", Offset = "0x183A5B0", VA = "0x18183B9B0")]
		public EmoticonPagerPanelView()
		{
		}

		// Token: 0x0601E9D0 RID: 125392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9D0")]
		[Address(RVA = "0x183AEB0", Offset = "0x1839AB0", VA = "0x18183AEB0")]
		private void <>xLuaBaseProxy_Init(ILoadAsset P0)
		{
		}

		// Token: 0x04029056 RID: 168022
		[Token(Token = "0x4029056")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollViewMoveToughPager _pager;

		// Token: 0x04029057 RID: 168023
		[Token(Token = "0x4029057")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _bgRect;

		// Token: 0x04029058 RID: 168024
		[Token(Token = "0x4029058")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _themeName;

		// Token: 0x04029059 RID: 168025
		[Token(Token = "0x4029059")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _leftArrow;

		// Token: 0x0402905A RID: 168026
		[Token(Token = "0x402905A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _rightArrow;

		// Token: 0x0402905B RID: 168027
		[Token(Token = "0x402905B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _emojiGroupContent;

		// Token: 0x0402905C RID: 168028
		[Token(Token = "0x402905C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _dotContent;

		// Token: 0x0402905D RID: 168029
		[Token(Token = "0x402905D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _rectPos;

		// Token: 0x0402905E RID: 168030
		[Token(Token = "0x402905E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _switchAnimLocation;

		// Token: 0x0402905F RID: 168031
		[Token(Token = "0x402905F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private EmoticonPagerPanelPlugin _panelPlugin;

		// Token: 0x04029060 RID: 168032
		[Token(Token = "0x4029060")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x04029061 RID: 168033
		[Token(Token = "0x4029061")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _panelGroup;

		// Token: 0x04029062 RID: 168034
		[Token(Token = "0x4029062")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04029063 RID: 168035
		[Token(Token = "0x4029063")]
		[FieldOffset(Offset = "0x98")]
		private EmoticonPagerPanelModel m_cachedModel;

		// Token: 0x04029064 RID: 168036
		[Token(Token = "0x4029064")]
		[FieldOffset(Offset = "0xA0")]
		private EmoticonPagerPanelView.EmojiGroupAdapter m_emojiGroupAdapter;

		// Token: 0x04029065 RID: 168037
		[Token(Token = "0x4029065")]
		[FieldOffset(Offset = "0xA8")]
		private EmoticonPagerPanelView.DotAdapter m_dotAdapter;

		// Token: 0x04029066 RID: 168038
		[Token(Token = "0x4029066")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_showTween;

		// Token: 0x04029067 RID: 168039
		[Token(Token = "0x4029067")]
		[FieldOffset(Offset = "0xB8")]
		private int m_showSeqNum;

		// Token: 0x04029068 RID: 168040
		[Token(Token = "0x4029068")]
		[FieldOffset(Offset = "0xBC")]
		private int m_hideFastModeSeqNum;

		// Token: 0x04029069 RID: 168041
		[Token(Token = "0x4029069")]
		[FieldOffset(Offset = "0xC0")]
		private EmojiSceneType m_cachedSceneType;

		// Token: 0x0402906A RID: 168042
		[Token(Token = "0x402906A")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public Action onClickLeftButton;

		// Token: 0x0402906B RID: 168043
		[Token(Token = "0x402906B")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public Action onClickRightButton;

		// Token: 0x0402906C RID: 168044
		[Token(Token = "0x402906C")]
		[FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		public Action<int> onPagerIndexChanged;

		// Token: 0x0402906D RID: 168045
		[Token(Token = "0x402906D")]
		[FieldOffset(Offset = "0xE0")]
		[NonSerialized]
		public Action<string, string> onClickEmojiItem;

		// Token: 0x0402906E RID: 168046
		[Token(Token = "0x402906E")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public Action onClosePanel;

		// Token: 0x0402906F RID: 168047
		[Token(Token = "0x402906F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04029070 RID: 168048
		[Token(Token = "0x4029070")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04029071 RID: 168049
		[Token(Token = "0x4029071")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029072 RID: 168050
		[Token(Token = "0x4029072")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPageValueChanged;

		// Token: 0x04029073 RID: 168051
		[Token(Token = "0x4029073")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnPageIndexChanged;

		// Token: 0x04029074 RID: 168052
		[Token(Token = "0x4029074")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickLeftButton;

		// Token: 0x04029075 RID: 168053
		[Token(Token = "0x4029075")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickRightButton;

		// Token: 0x04029076 RID: 168054
		[Token(Token = "0x4029076")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClosePanel;

		// Token: 0x04029077 RID: 168055
		[Token(Token = "0x4029077")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020050E2 RID: 20706
		[Token(Token = "0x20050E2")]
		private class EmojiGroupAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E9D1 RID: 125393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E9D1")]
			[Address(RVA = "0x18392A0", Offset = "0x1837EA0", VA = "0x1818392A0")]
			public EmojiGroupAdapter(EmoticonPagerPanelView closure)
			{
			}

			// Token: 0x1700476A RID: 18282
			// (get) Token: 0x0601E9D2 RID: 125394 RVA: 0x000AF128 File Offset: 0x000AD328
			[Token(Token = "0x1700476A")]
			public override int count
			{
				[Token(Token = "0x601E9D2")]
				[Address(RVA = "0x1839320", Offset = "0x1837F20", VA = "0x181839320", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E9D3 RID: 125395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E9D3")]
			[Address(RVA = "0x1839050", Offset = "0x1837C50", VA = "0x181839050", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04029078 RID: 168056
			[Token(Token = "0x4029078")]
			[FieldOffset(Offset = "0x20")]
			private EmoticonPagerPanelView m_closure;

			// Token: 0x04029079 RID: 168057
			[Token(Token = "0x4029079")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402907A RID: 168058
			[Token(Token = "0x402907A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402907B RID: 168059
			[Token(Token = "0x402907B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020050E3 RID: 20707
		[Token(Token = "0x20050E3")]
		private class DotAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E9D4 RID: 125396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E9D4")]
			[Address(RVA = "0x18386D0", Offset = "0x18372D0", VA = "0x1818386D0")]
			public DotAdapter(EmoticonPagerPanelView closure)
			{
			}

			// Token: 0x1700476B RID: 18283
			// (get) Token: 0x0601E9D5 RID: 125397 RVA: 0x000AF140 File Offset: 0x000AD340
			[Token(Token = "0x1700476B")]
			public override int count
			{
				[Token(Token = "0x601E9D5")]
				[Address(RVA = "0x1838750", Offset = "0x1837350", VA = "0x181838750", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E9D6 RID: 125398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E9D6")]
			[Address(RVA = "0x1838300", Offset = "0x1836F00", VA = "0x181838300", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601E9D7 RID: 125399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E9D7")]
			[Address(RVA = "0x1838450", Offset = "0x1837050", VA = "0x181838450")]
			public void SampleDotAnim(float curValue)
			{
			}

			// Token: 0x0601E9D8 RID: 125400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E9D8")]
			[Address(RVA = "0x1838570", Offset = "0x1837170", VA = "0x181838570")]
			private void _SampleDot(int position, float curValue, GameObject obj)
			{
			}

			// Token: 0x0402907C RID: 168060
			[Token(Token = "0x402907C")]
			[FieldOffset(Offset = "0x20")]
			private EmoticonPagerPanelView m_closure;

			// Token: 0x0402907D RID: 168061
			[Token(Token = "0x402907D")]
			private const string DOT_TWEEN_ANIM_NAME = "emoji_chat_panel_dot";

			// Token: 0x0402907E RID: 168062
			[Token(Token = "0x402907E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402907F RID: 168063
			[Token(Token = "0x402907F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04029080 RID: 168064
			[Token(Token = "0x4029080")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04029081 RID: 168065
			[Token(Token = "0x4029081")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SampleDotAnim;

			// Token: 0x04029082 RID: 168066
			[Token(Token = "0x4029082")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__SampleDot;
		}
	}
}
