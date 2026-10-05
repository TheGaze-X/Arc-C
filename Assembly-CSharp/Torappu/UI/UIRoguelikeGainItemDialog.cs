using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Roguelike;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A96 RID: 14998
	[Token(Token = "0x2003A96")]
	public class UIRoguelikeGainItemDialog : UICustomDialog<UIRoguelikeGainItemDialog.Options>
	{
		// Token: 0x06017B4A RID: 97098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B4A")]
		[Address(RVA = "0xFF60A0", Offset = "0xFF4CA0", VA = "0x180FF60A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017B4B RID: 97099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B4B")]
		[Address(RVA = "0xFF6270", Offset = "0xFF4E70", VA = "0x180FF6270")]
		private void _RenderSingle()
		{
		}

		// Token: 0x06017B4C RID: 97100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B4C")]
		[Address(RVA = "0xFF61B0", Offset = "0xFF4DB0", VA = "0x180FF61B0")]
		private void _OnSingleCanceled()
		{
		}

		// Token: 0x06017B4D RID: 97101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B4D")]
		[Address(RVA = "0xFF5FB0", Offset = "0xFF4BB0", VA = "0x180FF5FB0", Slot = "7")]
		protected override void OnRender(UIRoguelikeGainItemDialog.Options options)
		{
		}

		// Token: 0x06017B4E RID: 97102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B4E")]
		[Address(RVA = "0xFF5F50", Offset = "0xFF4B50", VA = "0x180FF5F50")]
		public void OnCancelClicked()
		{
		}

		// Token: 0x06017B4F RID: 97103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B4F")]
		[Address(RVA = "0xFF68B0", Offset = "0xFF54B0", VA = "0x180FF68B0")]
		public UIRoguelikeGainItemDialog()
		{
		}

		// Token: 0x0401C99A RID: 117146
		[Token(Token = "0x401C99A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeCustomizableItemIcon _itemIconPrefab;

		// Token: 0x0401C99B RID: 117147
		[Token(Token = "0x401C99B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _itemIconHolder;

		// Token: 0x0401C99C RID: 117148
		[Token(Token = "0x401C99C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _itemIconScale;

		// Token: 0x0401C99D RID: 117149
		[Token(Token = "0x401C99D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0401C99E RID: 117150
		[Token(Token = "0x401C99E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textUsage;

		// Token: 0x0401C99F RID: 117151
		[Token(Token = "0x401C99F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textDescription;

		// Token: 0x0401C9A0 RID: 117152
		[Token(Token = "0x401C9A0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _pnlClose;

		// Token: 0x0401C9A1 RID: 117153
		[Token(Token = "0x401C9A1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _pnlNext;

		// Token: 0x0401C9A2 RID: 117154
		[Token(Token = "0x401C9A2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _imgBlack;

		// Token: 0x0401C9A3 RID: 117155
		[Token(Token = "0x401C9A3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _imgBlackFadeInDuration;

		// Token: 0x0401C9A4 RID: 117156
		[Token(Token = "0x401C9A4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _fadeInAnim;

		// Token: 0x0401C9A5 RID: 117157
		[Token(Token = "0x401C9A5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation _popAnim;

		// Token: 0x0401C9A6 RID: 117158
		[Token(Token = "0x401C9A6")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedTopicId;

		// Token: 0x0401C9A7 RID: 117159
		[Token(Token = "0x401C9A7")]
		[FieldOffset(Offset = "0xD0")]
		private List<string> m_cachedItemIds;

		// Token: 0x0401C9A8 RID: 117160
		[Token(Token = "0x401C9A8")]
		[FieldOffset(Offset = "0xD8")]
		private RoguelikeCustomizableItemIcon m_itemIcon;

		// Token: 0x0401C9A9 RID: 117161
		[Token(Token = "0x401C9A9")]
		[FieldOffset(Offset = "0xE0")]
		private int m_index;

		// Token: 0x0401C9AA RID: 117162
		[Token(Token = "0x401C9AA")]
		[FieldOffset(Offset = "0xE4")]
		private bool m_inited;

		// Token: 0x0401C9AB RID: 117163
		[Token(Token = "0x401C9AB")]
		[FieldOffset(Offset = "0xE5")]
		private bool m_isNormalFadeIn;

		// Token: 0x0401C9AC RID: 117164
		[Token(Token = "0x401C9AC")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_animTween;

		// Token: 0x0401C9AD RID: 117165
		[Token(Token = "0x401C9AD")]
		[FieldOffset(Offset = "0xF0")]
		private FadeSwitchTween m_imgBlackTween;

		// Token: 0x0401C9AE RID: 117166
		[Token(Token = "0x401C9AE")]
		[FieldOffset(Offset = "0xF8")]
		private Action m_onConfirmed;

		// Token: 0x0401C9AF RID: 117167
		[Token(Token = "0x401C9AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C9B0 RID: 117168
		[Token(Token = "0x401C9B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSingle;

		// Token: 0x0401C9B1 RID: 117169
		[Token(Token = "0x401C9B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSingleCanceled;

		// Token: 0x0401C9B2 RID: 117170
		[Token(Token = "0x401C9B2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401C9B3 RID: 117171
		[Token(Token = "0x401C9B3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancelClicked;

		// Token: 0x0401C9B4 RID: 117172
		[Token(Token = "0x401C9B4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A97 RID: 14999
		[Token(Token = "0x2003A97")]
		public struct Options
		{
			// Token: 0x0401C9B5 RID: 117173
			[Token(Token = "0x401C9B5")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0401C9B6 RID: 117174
			[Token(Token = "0x401C9B6")]
			[FieldOffset(Offset = "0x8")]
			public List<string> itemIdList;

			// Token: 0x0401C9B7 RID: 117175
			[Token(Token = "0x401C9B7")]
			[FieldOffset(Offset = "0x10")]
			public bool isNormalFadeIn;

			// Token: 0x0401C9B8 RID: 117176
			[Token(Token = "0x401C9B8")]
			[FieldOffset(Offset = "0x18")]
			public Action onConfirm;
		}
	}
}
