using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F35 RID: 16181
	[Token(Token = "0x2003F35")]
	public class SiracusaOperaCommentItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601921C RID: 102940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601921C")]
		[Address(RVA = "0x11D89C0", Offset = "0x11D75C0", VA = "0x1811D89C0")]
		public void Render(SiracusaOperaCommentItemViewModel viewModel, float preferedHeight, bool isSelected, bool isInit)
		{
		}

		// Token: 0x0601921D RID: 102941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601921D")]
		[Address(RVA = "0x11D8ED0", Offset = "0x11D7AD0", VA = "0x1811D8ED0")]
		public Sprite _LoadAvartar(string charId)
		{
			return null;
		}

		// Token: 0x0601921E RID: 102942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601921E")]
		[Address(RVA = "0x11D8D50", Offset = "0x11D7950", VA = "0x1811D8D50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601921F RID: 102943 RVA: 0x0009D140 File Offset: 0x0009B340
		[Token(Token = "0x601921F")]
		[Address(RVA = "0x11D87B0", Offset = "0x11D73B0", VA = "0x1811D87B0")]
		public float GetPreferedHeight(string textContent)
		{
			return 0f;
		}

		// Token: 0x06019220 RID: 102944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019220")]
		[Address(RVA = "0x11D8940", Offset = "0x11D7540", VA = "0x1811D8940")]
		public void OnClick()
		{
		}

		// Token: 0x06019221 RID: 102945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019221")]
		[Address(RVA = "0x11D90E0", Offset = "0x11D7CE0", VA = "0x1811D90E0")]
		public SiracusaOperaCommentItemView()
		{
		}

		// Token: 0x0401F1FE RID: 127486
		[Token(Token = "0x401F1FE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _commentTitle;

		// Token: 0x0401F1FF RID: 127487
		[Token(Token = "0x401F1FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0401F200 RID: 127488
		[Token(Token = "0x401F200")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _score;

		// Token: 0x0401F201 RID: 127489
		[Token(Token = "0x401F201")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x0401F202 RID: 127490
		[Token(Token = "0x401F202")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0401F203 RID: 127491
		[Token(Token = "0x401F203")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _frame;

		// Token: 0x0401F204 RID: 127492
		[Token(Token = "0x401F204")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelFrame;

		// Token: 0x0401F205 RID: 127493
		[Token(Token = "0x401F205")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _likeBtn;

		// Token: 0x0401F206 RID: 127494
		[Token(Token = "0x401F206")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _confirmLikeBtn;

		// Token: 0x0401F207 RID: 127495
		[Token(Token = "0x401F207")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelHotpot;

		// Token: 0x0401F208 RID: 127496
		[Token(Token = "0x401F208")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelLike;

		// Token: 0x0401F209 RID: 127497
		[Token(Token = "0x401F209")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _currLike;

		// Token: 0x0401F20A RID: 127498
		[Token(Token = "0x401F20A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _charCardAvatar;

		// Token: 0x0401F20B RID: 127499
		[Token(Token = "0x401F20B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _selectedAnim;

		// Token: 0x0401F20C RID: 127500
		[Token(Token = "0x401F20C")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action<string> onCommentClicked;

		// Token: 0x0401F20D RID: 127501
		[Token(Token = "0x401F20D")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0401F20E RID: 127502
		[Token(Token = "0x401F20E")]
		[FieldOffset(Offset = "0xA0")]
		private SiracusaOperaCommentItemView.OperaCommentSeletedSwitchTween m_selectedTween;

		// Token: 0x0401F20F RID: 127503
		[Token(Token = "0x401F20F")]
		[FieldOffset(Offset = "0xA8")]
		private TextGenerator m_textGenerator;

		// Token: 0x0401F210 RID: 127504
		[Token(Token = "0x401F210")]
		[FieldOffset(Offset = "0xB0")]
		private TextGenerationSettings m_textGeneratorSettings;

		// Token: 0x0401F211 RID: 127505
		[Token(Token = "0x401F211")]
		[FieldOffset(Offset = "0x110")]
		private string m_cachedCommentId;

		// Token: 0x0401F212 RID: 127506
		[Token(Token = "0x401F212")]
		private const float REMAIN_HEIGHT = 134f;

		// Token: 0x0401F213 RID: 127507
		[Token(Token = "0x401F213")]
		private const float MIN_HEIGHT = 180f;

		// Token: 0x0401F214 RID: 127508
		[Token(Token = "0x401F214")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F215 RID: 127509
		[Token(Token = "0x401F215")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadAvartar;

		// Token: 0x0401F216 RID: 127510
		[Token(Token = "0x401F216")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F217 RID: 127511
		[Token(Token = "0x401F217")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPreferedHeight;

		// Token: 0x0401F218 RID: 127512
		[Token(Token = "0x401F218")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401F219 RID: 127513
		[Token(Token = "0x401F219")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F36 RID: 16182
		[Token(Token = "0x2003F36")]
		private class OperaCommentSeletedSwitchTween : UISwitchTween
		{
			// Token: 0x06019222 RID: 102946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019222")]
			[Address(RVA = "0x11C5F70", Offset = "0x11C4B70", VA = "0x1811C5F70")]
			public OperaCommentSeletedSwitchTween(SiracusaOperaCommentItemView closure)
			{
			}

			// Token: 0x06019223 RID: 102947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019223")]
			[Address(RVA = "0x11C5CE0", Offset = "0x11C48E0", VA = "0x1811C5CE0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06019224 RID: 102948 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019224")]
			[Address(RVA = "0x11C5B80", Offset = "0x11C4780", VA = "0x1811C5B80", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06019225 RID: 102949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019225")]
			[Address(RVA = "0x11C5AD0", Offset = "0x11C46D0", VA = "0x1811C5AD0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06019226 RID: 102950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019226")]
			[Address(RVA = "0x11C5A20", Offset = "0x11C4620", VA = "0x1811C5A20", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x06019227 RID: 102951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019227")]
			[Address(RVA = "0x11C5E40", Offset = "0x11C4A40", VA = "0x1811C5E40", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06019228 RID: 102952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019228")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06019229 RID: 102953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019229")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601922A RID: 102954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601922A")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0401F21A RID: 127514
			[Token(Token = "0x401F21A")]
			private const float SHOW_DURATION = 0.6f;

			// Token: 0x0401F21B RID: 127515
			[Token(Token = "0x401F21B")]
			[FieldOffset(Offset = "0x48")]
			private SiracusaOperaCommentItemView m_closure;

			// Token: 0x0401F21C RID: 127516
			[Token(Token = "0x401F21C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F21D RID: 127517
			[Token(Token = "0x401F21D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0401F21E RID: 127518
			[Token(Token = "0x401F21E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0401F21F RID: 127519
			[Token(Token = "0x401F21F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0401F220 RID: 127520
			[Token(Token = "0x401F220")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0401F221 RID: 127521
			[Token(Token = "0x401F221")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
