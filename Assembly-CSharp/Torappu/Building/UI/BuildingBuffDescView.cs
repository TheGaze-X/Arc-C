using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B11 RID: 6929
	[Token(Token = "0x2001B11")]
	public class BuildingBuffDescView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x0600AE93 RID: 44691 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AE94 RID: 44692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170014A5")]
		public Action<BuildingBuffDescView> onNextLevelClicked
		{
			[Token(Token = "0x600AE93")]
			[Address(RVA = "0x3289890", Offset = "0x3288490", VA = "0x183289890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600AE94")]
			[Address(RVA = "0x32898F0", Offset = "0x32884F0", VA = "0x1832898F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x0600AE95 RID: 44693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014A6")]
		public RectTransform anchorNextLevelButton
		{
			[Token(Token = "0x600AE95")]
			[Address(RVA = "0x32896C0", Offset = "0x32882C0", VA = "0x1832896C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600AE96 RID: 44694 RVA: 0x000432C0 File Offset: 0x000414C0
		[Token(Token = "0x170014A7")]
		public BuildingBuffDescStruct buffStruct
		{
			[Token(Token = "0x600AE96")]
			[Address(RVA = "0x32897A0", Offset = "0x32883A0", VA = "0x1832897A0")]
			get
			{
				return default(BuildingBuffDescStruct);
			}
		}

		// Token: 0x0600AE97 RID: 44695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE97")]
		[Address(RVA = "0x3288E30", Offset = "0x3287A30", VA = "0x183288E30")]
		private void OnEnable()
		{
		}

		// Token: 0x0600AE98 RID: 44696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE98")]
		[Address(RVA = "0x3288E90", Offset = "0x3287A90", VA = "0x183288E90")]
		public void Render(BuildingBuffDescStruct buffDesc)
		{
		}

		// Token: 0x0600AE99 RID: 44697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE99")]
		[Address(RVA = "0x3289450", Offset = "0x3288050", VA = "0x183289450")]
		private void _StartAutoLayoutCoroutine()
		{
		}

		// Token: 0x0600AE9A RID: 44698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE9A")]
		[Address(RVA = "0x32895B0", Offset = "0x32881B0", VA = "0x1832895B0")]
		private IEnumerator _UpdateAutoLayoutsCoroutine()
		{
			return null;
		}

		// Token: 0x0600AE9B RID: 44699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE9B")]
		[Address(RVA = "0x3288D20", Offset = "0x3287920", VA = "0x183288D20")]
		public void EventOnNextLevelClicked()
		{
		}

		// Token: 0x0600AE9C RID: 44700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE9C")]
		[Address(RVA = "0x3289660", Offset = "0x3288260", VA = "0x183289660")]
		public BuildingBuffDescView()
		{
		}

		// Token: 0x0400A75C RID: 42844
		[Token(Token = "0x400A75C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400A75D RID: 42845
		[Token(Token = "0x400A75D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0400A75E RID: 42846
		[Token(Token = "0x400A75E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bkgTitle;

		// Token: 0x0400A75F RID: 42847
		[Token(Token = "0x400A75F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0400A760 RID: 42848
		[Token(Token = "0x400A760")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useDarkCommentColor;

		// Token: 0x0400A761 RID: 42849
		[Token(Token = "0x400A761")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Text _unlockCondition;

		// Token: 0x0400A762 RID: 42850
		[Token(Token = "0x400A762")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Nullable")]
		private GameObject _panelLocked;

		// Token: 0x0400A763 RID: 42851
		[Token(Token = "0x400A763")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorBkgLocked;

		// Token: 0x0400A764 RID: 42852
		[Token(Token = "0x400A764")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Nullable")]
		private GameObject _btnNextLevel;

		// Token: 0x0400A765 RID: 42853
		[Token(Token = "0x400A765")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("AutoLayout")]
		private RectTransform[] _autoLayouts;

		// Token: 0x0400A766 RID: 42854
		[Token(Token = "0x400A766")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("AutoLayout")]
		private UIAutoSlideRect _autoSlideRect;

		// Token: 0x0400A767 RID: 42855
		[Token(Token = "0x400A767")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0400A768 RID: 42856
		[Token(Token = "0x400A768")]
		[FieldOffset(Offset = "0x80")]
		private BuildingBuffDescStruct m_buffCache;

		// Token: 0x0400A76A RID: 42858
		[Token(Token = "0x400A76A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNextLevelClicked;

		// Token: 0x0400A76B RID: 42859
		[Token(Token = "0x400A76B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNextLevelClicked;

		// Token: 0x0400A76C RID: 42860
		[Token(Token = "0x400A76C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_anchorNextLevelButton;

		// Token: 0x0400A76D RID: 42861
		[Token(Token = "0x400A76D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_buffStruct;

		// Token: 0x0400A76E RID: 42862
		[Token(Token = "0x400A76E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400A76F RID: 42863
		[Token(Token = "0x400A76F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400A770 RID: 42864
		[Token(Token = "0x400A770")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__StartAutoLayoutCoroutine;

		// Token: 0x0400A771 RID: 42865
		[Token(Token = "0x400A771")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateAutoLayoutsCoroutine;

		// Token: 0x0400A772 RID: 42866
		[Token(Token = "0x400A772")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnNextLevelClicked;

		// Token: 0x0400A773 RID: 42867
		[Token(Token = "0x400A773")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
