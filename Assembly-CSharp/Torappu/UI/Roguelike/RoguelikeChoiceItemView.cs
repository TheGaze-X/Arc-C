using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051B1 RID: 20913
	[Token(Token = "0x20051B1")]
	public class RoguelikeChoiceItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x0601EE43 RID: 126531 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EE44 RID: 126532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700480E")]
		public Action<IRoguelikeGameChoice> onChoiceConfirm
		{
			[Token(Token = "0x601EE43")]
			[Address(RVA = "0x18A3410", Offset = "0x18A2010", VA = "0x1818A3410")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601EE44")]
			[Address(RVA = "0x18A34D0", Offset = "0x18A20D0", VA = "0x1818A34D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x0601EE45 RID: 126533 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EE46 RID: 126534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700480F")]
		public Action<IRoguelikeGameChoice> onChoiceSelect
		{
			[Token(Token = "0x601EE45")]
			[Address(RVA = "0x18A3470", Offset = "0x18A2070", VA = "0x1818A3470")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601EE46")]
			[Address(RVA = "0x18A3550", Offset = "0x18A2150", VA = "0x1818A3550")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601EE47 RID: 126535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE47")]
		[Address(RVA = "0x18A2F30", Offset = "0x18A1B30", VA = "0x1818A2F30")]
		private RoguelikeCustomizableItemIcon _EnsureItemIcon()
		{
			return null;
		}

		// Token: 0x0601EE48 RID: 126536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE48")]
		[Address(RVA = "0x18A2310", Offset = "0x18A0F10", VA = "0x1818A2310")]
		public void Setup(string topicId, UIPage page, RoguelikeChoicePlugin choicePlugin, IRoguelikeGameChoice choice)
		{
		}

		// Token: 0x0601EE49 RID: 126537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE49")]
		[Address(RVA = "0x18A2C20", Offset = "0x18A1820", VA = "0x1818A2C20")]
		private void _CreateAndRenderLeftDeco()
		{
		}

		// Token: 0x0601EE4A RID: 126538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE4A")]
		[Address(RVA = "0x18A3160", Offset = "0x18A1D60", VA = "0x1818A3160")]
		private void _SetContentVisible(bool isExpand)
		{
		}

		// Token: 0x0601EE4B RID: 126539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE4B")]
		[Address(RVA = "0x18A2040", Offset = "0x18A0C40", VA = "0x1818A2040")]
		public void SetChoiceActive(bool active, Action onAnimComplete)
		{
		}

		// Token: 0x0601EE4C RID: 126540 RVA: 0x000B0118 File Offset: 0x000AE318
		[Token(Token = "0x601EE4C")]
		[Address(RVA = "0x18A3100", Offset = "0x18A1D00", VA = "0x1818A3100")]
		private float _GetSwitchPosition()
		{
			return 0f;
		}

		// Token: 0x0601EE4D RID: 126541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE4D")]
		[Address(RVA = "0x18A32F0", Offset = "0x18A1EF0", VA = "0x1818A32F0")]
		private void _SetSwtichPosition(float position)
		{
		}

		// Token: 0x0601EE4E RID: 126542 RVA: 0x000B0130 File Offset: 0x000AE330
		[Token(Token = "0x601EE4E")]
		[Address(RVA = "0x18A1DB0", Offset = "0x18A09B0", VA = "0x1818A1DB0")]
		public bool IsChoiceEqual(IRoguelikeGameChoice choice)
		{
			return default(bool);
		}

		// Token: 0x0601EE4F RID: 126543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE4F")]
		[Address(RVA = "0x18A1F60", Offset = "0x18A0B60", VA = "0x1818A1F60")]
		public void OnSelectButtonPressed()
		{
		}

		// Token: 0x0601EE50 RID: 126544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE50")]
		[Address(RVA = "0x18A1E40", Offset = "0x18A0A40", VA = "0x1818A1E40")]
		public void OnActiveButtonPressed()
		{
		}

		// Token: 0x0601EE51 RID: 126545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE51")]
		[Address(RVA = "0x18A3390", Offset = "0x18A1F90", VA = "0x1818A3390")]
		public RoguelikeChoiceItemView()
		{
		}

		// Token: 0x04029709 RID: 169737
		[Token(Token = "0x4029709")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Style Config")]
		private float _disableTextAlpha;

		// Token: 0x0402970A RID: 169738
		[Token(Token = "0x402970A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Group("Style Config")]
		private float _disableIconAlpha;

		// Token: 0x0402970B RID: 169739
		[Token(Token = "0x402970B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Style Config")]
		private float _activeIconAlpha;

		// Token: 0x0402970C RID: 169740
		[Token(Token = "0x402970C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Group("Style Config")]
		private Color _diableBgColor;

		// Token: 0x0402970D RID: 169741
		[Token(Token = "0x402970D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Style Config")]
		private Graphic[] _bgImageList;

		// Token: 0x0402970E RID: 169742
		[Token(Token = "0x402970E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Style Config")]
		private Text[] _descTextList;

		// Token: 0x0402970F RID: 169743
		[Token(Token = "0x402970F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _titleLabel;

		// Token: 0x04029710 RID: 169744
		[Token(Token = "0x4029710")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _contentLabel;

		// Token: 0x04029711 RID: 169745
		[Token(Token = "0x4029711")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _itemTitleLabel;

		// Token: 0x04029712 RID: 169746
		[Token(Token = "0x4029712")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemDescLabel;

		// Token: 0x04029713 RID: 169747
		[Token(Token = "0x4029713")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _itemHintLabel;

		// Token: 0x04029714 RID: 169748
		[Token(Token = "0x4029714")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _funcIconImage;

		// Token: 0x04029715 RID: 169749
		[Token(Token = "0x4029715")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _itemIconHolder;

		// Token: 0x04029716 RID: 169750
		[Token(Token = "0x4029716")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RoguelikeCustomizableItemIcon _itemIconPrefab;

		// Token: 0x04029717 RID: 169751
		[Token(Token = "0x4029717")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _itemIconScale;

		// Token: 0x04029718 RID: 169752
		[Token(Token = "0x4029718")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _choiceButton;

		// Token: 0x04029719 RID: 169753
		[Token(Token = "0x4029719")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button _riseButton;

		// Token: 0x0402971A RID: 169754
		[Token(Token = "0x402971A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _leftDecoContainer;

		// Token: 0x0402971B RID: 169755
		[Token(Token = "0x402971B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x0402971C RID: 169756
		[Token(Token = "0x402971C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Ease _switchEase;

		// Token: 0x0402971D RID: 169757
		[Token(Token = "0x402971D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CanvasGroup _canvasFuncIcon;

		// Token: 0x0402971E RID: 169758
		[Token(Token = "0x402971E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CanvasGroup _canvasItemIcon;

		// Token: 0x0402971F RID: 169759
		[Token(Token = "0x402971F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIColorGraphic _graphicChoiceGraphic;

		// Token: 0x04029720 RID: 169760
		[Token(Token = "0x4029720")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIColorGraphic _graphicRiseGraphic;

		// Token: 0x04029721 RID: 169761
		[Token(Token = "0x4029721")]
		[FieldOffset(Offset = "0xE0")]
		private IRoguelikeGameChoice m_choice;

		// Token: 0x04029722 RID: 169762
		[Token(Token = "0x4029722")]
		[FieldOffset(Offset = "0xE8")]
		private string m_topicId;

		// Token: 0x04029723 RID: 169763
		[Token(Token = "0x4029723")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_active;

		// Token: 0x04029724 RID: 169764
		[Token(Token = "0x4029724")]
		[FieldOffset(Offset = "0xF4")]
		private RoguelikeChoiceLeftDecoType m_cacheDecoType;

		// Token: 0x04029725 RID: 169765
		[Token(Token = "0x4029725")]
		[FieldOffset(Offset = "0xF8")]
		private RoguelikeChoiceLeftDecoView m_leftDecoView;

		// Token: 0x04029726 RID: 169766
		[Token(Token = "0x4029726")]
		[FieldOffset(Offset = "0x100")]
		private RoguelikeChoicePlugin m_choicePlugin;

		// Token: 0x04029727 RID: 169767
		[Token(Token = "0x4029727")]
		[FieldOffset(Offset = "0x108")]
		private RoguelikeCustomizableItemIcon m_itemIcon;

		// Token: 0x04029728 RID: 169768
		[Token(Token = "0x4029728")]
		[FieldOffset(Offset = "0x110")]
		private AnimationWrapper m_switchWrapper;

		// Token: 0x04029729 RID: 169769
		[Token(Token = "0x4029729")]
		[FieldOffset(Offset = "0x118")]
		private float m_switchDuration;

		// Token: 0x0402972A RID: 169770
		[Token(Token = "0x402972A")]
		[FieldOffset(Offset = "0x11C")]
		private float m_switchPosition;

		// Token: 0x0402972D RID: 169773
		[Token(Token = "0x402972D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onChoiceConfirm;

		// Token: 0x0402972E RID: 169774
		[Token(Token = "0x402972E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onChoiceConfirm;

		// Token: 0x0402972F RID: 169775
		[Token(Token = "0x402972F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onChoiceSelect;

		// Token: 0x04029730 RID: 169776
		[Token(Token = "0x4029730")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onChoiceSelect;

		// Token: 0x04029731 RID: 169777
		[Token(Token = "0x4029731")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureItemIcon;

		// Token: 0x04029732 RID: 169778
		[Token(Token = "0x4029732")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04029733 RID: 169779
		[Token(Token = "0x4029733")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateAndRenderLeftDeco;

		// Token: 0x04029734 RID: 169780
		[Token(Token = "0x4029734")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetContentVisible;

		// Token: 0x04029735 RID: 169781
		[Token(Token = "0x4029735")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetChoiceActive;

		// Token: 0x04029736 RID: 169782
		[Token(Token = "0x4029736")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetSwitchPosition;

		// Token: 0x04029737 RID: 169783
		[Token(Token = "0x4029737")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetSwtichPosition;

		// Token: 0x04029738 RID: 169784
		[Token(Token = "0x4029738")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsChoiceEqual;

		// Token: 0x04029739 RID: 169785
		[Token(Token = "0x4029739")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnSelectButtonPressed;

		// Token: 0x0402973A RID: 169786
		[Token(Token = "0x402973A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnActiveButtonPressed;

		// Token: 0x0402973B RID: 169787
		[Token(Token = "0x402973B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
