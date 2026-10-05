using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E25 RID: 20005
	[Token(Token = "0x2004E25")]
	public class FireworkPlateFilledListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DE2D RID: 122413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE2D")]
		[Address(RVA = "0x176AC60", Offset = "0x1769860", VA = "0x18176AC60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DE2E RID: 122414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE2E")]
		[Address(RVA = "0x176A5E0", Offset = "0x17691E0", VA = "0x18176A5E0")]
		public void Render(FireworkData.PlateSlotData plateSlotData, FireworkPlateGroupModel groupModel, FireworkPlateGroupViewStyle style)
		{
		}

		// Token: 0x0601DE2F RID: 122415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE2F")]
		[Address(RVA = "0x176AE00", Offset = "0x1769A00", VA = "0x18176AE00")]
		private void _RenderSelection(bool isSelected, bool fastMode)
		{
		}

		// Token: 0x0601DE30 RID: 122416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE30")]
		[Address(RVA = "0x176A500", Offset = "0x1769100", VA = "0x18176A500")]
		public void OnClicked()
		{
		}

		// Token: 0x0601DE31 RID: 122417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE31")]
		[Address(RVA = "0x176AED0", Offset = "0x1769AD0", VA = "0x18176AED0")]
		public FireworkPlateFilledListItemView()
		{
		}

		// Token: 0x04027A1E RID: 162334
		[Token(Token = "0x4027A1E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasEmpty;

		// Token: 0x04027A1F RID: 162335
		[Token(Token = "0x4027A1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasNormal;

		// Token: 0x04027A20 RID: 162336
		[Token(Token = "0x4027A20")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgEmptyFrame;

		// Token: 0x04027A21 RID: 162337
		[Token(Token = "0x4027A21")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgBkg;

		// Token: 0x04027A22 RID: 162338
		[Token(Token = "0x4027A22")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgRange;

		// Token: 0x04027A23 RID: 162339
		[Token(Token = "0x4027A23")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgFillFrame;

		// Token: 0x04027A24 RID: 162340
		[Token(Token = "0x4027A24")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x04027A25 RID: 162341
		[Token(Token = "0x4027A25")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgSelectedFrame;

		// Token: 0x04027A26 RID: 162342
		[Token(Token = "0x4027A26")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x04027A27 RID: 162343
		[Token(Token = "0x4027A27")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _spriteFilled;

		// Token: 0x04027A28 RID: 162344
		[Token(Token = "0x4027A28")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FireworkPlatePieceView _pieceView;

		// Token: 0x04027A29 RID: 162345
		[Token(Token = "0x4027A29")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _imgRangeCenter;

		// Token: 0x04027A2A RID: 162346
		[Token(Token = "0x4027A2A")]
		[FieldOffset(Offset = "0x78")]
		private UISwitchTween m_filledTween;

		// Token: 0x04027A2B RID: 162347
		[Token(Token = "0x4027A2B")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_selectedTween;

		// Token: 0x04027A2C RID: 162348
		[Token(Token = "0x4027A2C")]
		[FieldOffset(Offset = "0x88")]
		private FireworkPlateFilledListItemView.FilledStatus m_cachedFilledStatus;

		// Token: 0x04027A2D RID: 162349
		[Token(Token = "0x4027A2D")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_inited;

		// Token: 0x04027A2E RID: 162350
		[Token(Token = "0x4027A2E")]
		[FieldOffset(Offset = "0x90")]
		private FireworkData.PlateSlotData m_cachedSlotData;

		// Token: 0x04027A2F RID: 162351
		[Token(Token = "0x4027A2F")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027A30 RID: 162352
		[Token(Token = "0x4027A30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027A31 RID: 162353
		[Token(Token = "0x4027A31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027A32 RID: 162354
		[Token(Token = "0x4027A32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderSelection;

		// Token: 0x04027A33 RID: 162355
		[Token(Token = "0x4027A33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x04027A34 RID: 162356
		[Token(Token = "0x4027A34")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E26 RID: 20006
		[Token(Token = "0x2004E26")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x0601DE32 RID: 122418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE32")]
			[Address(RVA = "0x177E4E0", Offset = "0x177D0E0", VA = "0x18177E4E0")]
			public SwitchTween(FireworkPlateFilledListItemView closure)
			{
			}

			// Token: 0x0601DE33 RID: 122419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DE33")]
			[Address(RVA = "0x177E0D0", Offset = "0x177CCD0", VA = "0x18177E0D0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601DE34 RID: 122420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DE34")]
			[Address(RVA = "0x177E240", Offset = "0x177CE40", VA = "0x18177E240", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601DE35 RID: 122421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE35")]
			[Address(RVA = "0x177E040", Offset = "0x177CC40", VA = "0x18177E040", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601DE36 RID: 122422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE36")]
			[Address(RVA = "0x177DFB0", Offset = "0x177CBB0", VA = "0x18177DFB0", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601DE37 RID: 122423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE37")]
			[Address(RVA = "0x177DF20", Offset = "0x177CB20", VA = "0x18177DF20", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601DE38 RID: 122424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE38")]
			[Address(RVA = "0x177DE90", Offset = "0x177CA90", VA = "0x18177DE90", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601DE39 RID: 122425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE39")]
			[Address(RVA = "0x177E3B0", Offset = "0x177CFB0", VA = "0x18177E3B0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601DE3A RID: 122426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE3A")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601DE3B RID: 122427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE3B")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601DE3C RID: 122428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE3C")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601DE3D RID: 122429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE3D")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601DE3E RID: 122430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE3E")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04027A35 RID: 162357
			[Token(Token = "0x4027A35")]
			private const float ANIM_DURATION = 0.16f;

			// Token: 0x04027A36 RID: 162358
			[Token(Token = "0x4027A36")]
			[FieldOffset(Offset = "0x48")]
			private FireworkPlateFilledListItemView m_closure;

			// Token: 0x04027A37 RID: 162359
			[Token(Token = "0x4027A37")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027A38 RID: 162360
			[Token(Token = "0x4027A38")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04027A39 RID: 162361
			[Token(Token = "0x4027A39")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04027A3A RID: 162362
			[Token(Token = "0x4027A3A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04027A3B RID: 162363
			[Token(Token = "0x4027A3B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x04027A3C RID: 162364
			[Token(Token = "0x4027A3C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x04027A3D RID: 162365
			[Token(Token = "0x4027A3D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04027A3E RID: 162366
			[Token(Token = "0x4027A3E")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02004E27 RID: 20007
		[Token(Token = "0x2004E27")]
		private enum FilledStatus
		{
			// Token: 0x04027A40 RID: 162368
			[Token(Token = "0x4027A40")]
			NONE,
			// Token: 0x04027A41 RID: 162369
			[Token(Token = "0x4027A41")]
			NOT_FILLED,
			// Token: 0x04027A42 RID: 162370
			[Token(Token = "0x4027A42")]
			FILLED
		}
	}
}
