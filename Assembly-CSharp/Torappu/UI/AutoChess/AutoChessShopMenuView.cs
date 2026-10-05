using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006352 RID: 25426
	[Token(Token = "0x2006352")]
	public class AutoChessShopMenuView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024AFC RID: 150268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AFC")]
		[Address(RVA = "0x1F8CF10", Offset = "0x1F8BB10", VA = "0x181F8CF10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024AFD RID: 150269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AFD")]
		[Address(RVA = "0x1F8D230", Offset = "0x1F8BE30", VA = "0x181F8D230")]
		private void _RefreshToggleClickState(bool isToggleCanClick)
		{
		}

		// Token: 0x06024AFE RID: 150270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AFE")]
		[Address(RVA = "0x1F8CB10", Offset = "0x1F8B710", VA = "0x181F8CB10")]
		public void Render(AutoChessShopViewModel shopViewModel)
		{
		}

		// Token: 0x06024AFF RID: 150271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AFF")]
		[Address(RVA = "0x1F8CCE0", Offset = "0x1F8B8E0", VA = "0x181F8CCE0")]
		public void TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x06024B00 RID: 150272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B00")]
		[Address(RVA = "0x1F8C8A0", Offset = "0x1F8B4A0", VA = "0x181F8C8A0")]
		private AutoChessShopMenuLevelItemView GetMenuLevelItemView(int position)
		{
			return null;
		}

		// Token: 0x06024B01 RID: 150273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B01")]
		[Address(RVA = "0x1F8C980", Offset = "0x1F8B580", VA = "0x181F8C980")]
		public void OnConfirmQuickSkillAndModuleClick()
		{
		}

		// Token: 0x06024B02 RID: 150274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B02")]
		[Address(RVA = "0x1F8CA10", Offset = "0x1F8B610", VA = "0x181F8CA10")]
		public void OnShopTypeToggleClick()
		{
		}

		// Token: 0x06024B03 RID: 150275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B03")]
		[Address(RVA = "0x1F8D440", Offset = "0x1F8C040", VA = "0x181F8D440")]
		public AutoChessShopMenuView()
		{
		}

		// Token: 0x0403336F RID: 209775
		[Token(Token = "0x403336F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _layoutMenuLevelList;

		// Token: 0x04033370 RID: 209776
		[Token(Token = "0x4033370")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroupToggleParent;

		// Token: 0x04033371 RID: 209777
		[Token(Token = "0x4033371")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroupToggleMask;

		// Token: 0x04033372 RID: 209778
		[Token(Token = "0x4033372")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasSwitchShopTypeTogglePart;

		// Token: 0x04033373 RID: 209779
		[Token(Token = "0x4033373")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _shopTypeSwitchAnim;

		// Token: 0x04033374 RID: 209780
		[Token(Token = "0x4033374")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasConfirmQuickSkillAndModulePart;

		// Token: 0x04033375 RID: 209781
		[Token(Token = "0x4033375")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objTrapTab;

		// Token: 0x04033376 RID: 209782
		[Token(Token = "0x4033376")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x04033377 RID: 209783
		[Token(Token = "0x4033377")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04033378 RID: 209784
		[Token(Token = "0x4033378")]
		[FieldOffset(Offset = "0x70")]
		private AutoChessShopViewModel m_viewModel;

		// Token: 0x04033379 RID: 209785
		[Token(Token = "0x4033379")]
		[FieldOffset(Offset = "0x78")]
		private AutoChessShopMenuView.ShopMenuLevelListAdapter m_shopMenuLevelListAdapter;

		// Token: 0x0403337A RID: 209786
		[Token(Token = "0x403337A")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_tweenSwitchShopTypeTogglePart;

		// Token: 0x0403337B RID: 209787
		[Token(Token = "0x403337B")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_tweenConfirmQuickSkillAndModulePart;

		// Token: 0x0403337C RID: 209788
		[Token(Token = "0x403337C")]
		[FieldOffset(Offset = "0x90")]
		private AnimationSwitchTween m_shopTypeSwitchTween;

		// Token: 0x0403337D RID: 209789
		[Token(Token = "0x403337D")]
		[FieldOffset(Offset = "0x98")]
		private AutoChessShopStatus m_cachedShopStatus;

		// Token: 0x0403337E RID: 209790
		[Token(Token = "0x403337E")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_tweenSwitchShopTypeToggleParent;

		// Token: 0x0403337F RID: 209791
		[Token(Token = "0x403337F")]
		[FieldOffset(Offset = "0xA8")]
		private FadeSwitchTween m_tweenSwitchShopTypeToggleMask;

		// Token: 0x04033380 RID: 209792
		[Token(Token = "0x4033380")]
		private const float TOGGLE_PARENT_ALPHA_DURATION = 0.2f;

		// Token: 0x04033381 RID: 209793
		[Token(Token = "0x4033381")]
		private const float TOGGLE_PARENT_SHOW_ALPHA_VAL = 1f;

		// Token: 0x04033382 RID: 209794
		[Token(Token = "0x4033382")]
		private const float TOGGLE_PARENT_FADE_ALPHA_VAL = 0.3f;

		// Token: 0x04033383 RID: 209795
		[Token(Token = "0x4033383")]
		private const int TUTORIAL_FIVE_LEVEL_MENU_ITEM_POS = 4;

		// Token: 0x04033384 RID: 209796
		[Token(Token = "0x4033384")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033385 RID: 209797
		[Token(Token = "0x4033385")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshToggleClickState;

		// Token: 0x04033386 RID: 209798
		[Token(Token = "0x4033386")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033387 RID: 209799
		[Token(Token = "0x4033387")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterTutorialGo;

		// Token: 0x04033388 RID: 209800
		[Token(Token = "0x4033388")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMenuLevelItemView;

		// Token: 0x04033389 RID: 209801
		[Token(Token = "0x4033389")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConfirmQuickSkillAndModuleClick;

		// Token: 0x0403338A RID: 209802
		[Token(Token = "0x403338A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnShopTypeToggleClick;

		// Token: 0x0403338B RID: 209803
		[Token(Token = "0x403338B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006353 RID: 25427
		[Token(Token = "0x2006353")]
		private class ShopMenuLevelListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06024B04 RID: 150276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B04")]
			[Address(RVA = "0x1F95560", Offset = "0x1F94160", VA = "0x181F95560")]
			public ShopMenuLevelListAdapter(AutoChessShopMenuView closure)
			{
			}

			// Token: 0x170056A0 RID: 22176
			// (get) Token: 0x06024B05 RID: 150277 RVA: 0x000C5358 File Offset: 0x000C3558
			[Token(Token = "0x170056A0")]
			public override int count
			{
				[Token(Token = "0x6024B05")]
				[Address(RVA = "0x1F955E0", Offset = "0x1F941E0", VA = "0x181F955E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024B06 RID: 150278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024B06")]
			[Address(RVA = "0x1F95360", Offset = "0x1F93F60", VA = "0x181F95360", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403338C RID: 209804
			[Token(Token = "0x403338C")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessShopMenuView m_closure;

			// Token: 0x0403338D RID: 209805
			[Token(Token = "0x403338D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403338E RID: 209806
			[Token(Token = "0x403338E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403338F RID: 209807
			[Token(Token = "0x403338F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
