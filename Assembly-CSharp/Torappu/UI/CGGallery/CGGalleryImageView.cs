using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x0200600E RID: 24590
	[Token(Token = "0x200600E")]
	public class CGGalleryImageView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005400 RID: 21504
		// (get) Token: 0x060238DA RID: 145626 RVA: 0x000C13F8 File Offset: 0x000BF5F8
		[Token(Token = "0x17005400")]
		public Vector2 contentSize
		{
			[Token(Token = "0x60238DA")]
			[Address(RVA = "0x1E32540", Offset = "0x1E31140", VA = "0x181E32540")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17005401 RID: 21505
		// (get) Token: 0x060238DB RID: 145627 RVA: 0x000C1410 File Offset: 0x000BF610
		[Token(Token = "0x17005401")]
		public CGGalleryInspectImageViewScaleHandler.ScaleApplyType scaleApplyType
		{
			[Token(Token = "0x60238DB")]
			[Address(RVA = "0x1E325B0", Offset = "0x1E311B0", VA = "0x181E325B0")]
			get
			{
				return CGGalleryInspectImageViewScaleHandler.ScaleApplyType.USE_HORIZONTAL;
			}
		}

		// Token: 0x060238DC RID: 145628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238DC")]
		[Address(RVA = "0x1E30B50", Offset = "0x1E2F750", VA = "0x181E30B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060238DD RID: 145629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238DD")]
		[Address(RVA = "0x1E30880", Offset = "0x1E2F480", VA = "0x181E30880")]
		private void _EnsureTweens()
		{
		}

		// Token: 0x060238DE RID: 145630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238DE")]
		[Address(RVA = "0x1E30BE0", Offset = "0x1E2F7E0", VA = "0x181E30BE0")]
		private void _OnTransitionEnd()
		{
		}

		// Token: 0x060238DF RID: 145631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238DF")]
		[Address(RVA = "0x1E304D0", Offset = "0x1E2F0D0", VA = "0x181E304D0")]
		public void ShowImmediate()
		{
		}

		// Token: 0x060238E0 RID: 145632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238E0")]
		[Address(RVA = "0x1E30090", Offset = "0x1E2EC90", VA = "0x181E30090")]
		public void HideImmediate()
		{
		}

		// Token: 0x060238E1 RID: 145633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238E1")]
		[Address(RVA = "0x1E30570", Offset = "0x1E2F170", VA = "0x181E30570")]
		public void Show(bool forward)
		{
		}

		// Token: 0x060238E2 RID: 145634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238E2")]
		[Address(RVA = "0x1E30130", Offset = "0x1E2ED30", VA = "0x181E30130")]
		public void Hide(bool forward)
		{
		}

		// Token: 0x060238E3 RID: 145635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238E3")]
		[Address(RVA = "0x1E302F0", Offset = "0x1E2EEF0", VA = "0x181E302F0")]
		public void InitView()
		{
		}

		// Token: 0x060238E4 RID: 145636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238E4")]
		[Address(RVA = "0x1E30450", Offset = "0x1E2F050", VA = "0x181E30450")]
		public void RenderImage(CGGalleryCGViewModel cgViewModel)
		{
		}

		// Token: 0x060238E5 RID: 145637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238E5")]
		[Address(RVA = "0x1E31550", Offset = "0x1E30150", VA = "0x181E31550")]
		private void _RenderInternal(CGGalleryCGViewModel source)
		{
		}

		// Token: 0x060238E6 RID: 145638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238E6")]
		[Address(RVA = "0x1E31840", Offset = "0x1E30440", VA = "0x181E31840")]
		private void _RenderSingleImage(CGGalleryCGViewModel cg, CGGalleryCGSource source, ILoadAsset loader, float containerWidth, float containerHeight, out float totalWidth, out float totalHeight)
		{
		}

		// Token: 0x060238E7 RID: 145639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238E7")]
		[Address(RVA = "0x1E30CF0", Offset = "0x1E2F8F0", VA = "0x181E30CF0")]
		private void _RenderComposeImages(IReadOnlyList<CGGalleryCGCompositeViewModel> cgs, CGGalleryCGSource source, CGGalleryCGCompositeType composeMode, ILoadAsset loader, float containerWidth, float containerHeight, out float totalContentWidth, out float totalContentHeight)
		{
		}

		// Token: 0x060238E8 RID: 145640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238E8")]
		[Address(RVA = "0x1E31DD0", Offset = "0x1E309D0", VA = "0x181E31DD0")]
		private void _SetupImageLayout(RectTransform rectTransform, int index, int totalCount, CGGalleryCGCompositeType composeMode, float[] imageWidths, float[] imageHeights, float totalWidth, float totalHeight, float containerWidth, float containerHeight, float aspectRatio, ref float contentWidth, ref float contentHeight)
		{
		}

		// Token: 0x060238E9 RID: 145641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238E9")]
		[Address(RVA = "0x1E31B80", Offset = "0x1E30780", VA = "0x181E31B80")]
		private void _SetupHorizontalLayout(RectTransform rectTransform, int index, int totalCount, float[] imageWidths, float totalWidth, out float normalizedWidth)
		{
		}

		// Token: 0x060238EA RID: 145642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238EA")]
		[Address(RVA = "0x1E32280", Offset = "0x1E30E80", VA = "0x181E32280")]
		private void _SetupVerticalLayout(RectTransform rectTransform, int index, int totalCount, float[] imageHeights, float totalHeight, out float normalizedHeight)
		{
		}

		// Token: 0x060238EB RID: 145643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238EB")]
		[Address(RVA = "0x1E319B0", Offset = "0x1E305B0", VA = "0x181E319B0")]
		private void _SetupGrid2x2Layout(RectTransform rectTransform, int index)
		{
		}

		// Token: 0x060238EC RID: 145644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238EC")]
		[Address(RVA = "0x1E30730", Offset = "0x1E2F330", VA = "0x181E30730")]
		private void _ClearComposeImages()
		{
		}

		// Token: 0x060238ED RID: 145645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238ED")]
		[Address(RVA = "0x1E303C0", Offset = "0x1E2EFC0", VA = "0x181E303C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060238EE RID: 145646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238EE")]
		[Address(RVA = "0x1E324D0", Offset = "0x1E310D0", VA = "0x181E324D0")]
		public CGGalleryImageView()
		{
		}

		// Token: 0x04031324 RID: 201508
		[Token(Token = "0x4031324")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _cgImage;

		// Token: 0x04031325 RID: 201509
		[Token(Token = "0x4031325")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _composeImageContainer;

		// Token: 0x04031326 RID: 201510
		[Token(Token = "0x4031326")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image[] _composeImgs;

		// Token: 0x04031327 RID: 201511
		[Token(Token = "0x4031327")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _cgRightToCenterAnimLoc;

		// Token: 0x04031328 RID: 201512
		[Token(Token = "0x4031328")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _cgCenterToLeftAnimLoc;

		// Token: 0x04031329 RID: 201513
		[Token(Token = "0x4031329")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _cgContainerSize;

		// Token: 0x0403132A RID: 201514
		[Token(Token = "0x403132A")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_finder;

		// Token: 0x0403132B RID: 201515
		[Token(Token = "0x403132B")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0403132C RID: 201516
		[Token(Token = "0x403132C")]
		[FieldOffset(Offset = "0x70")]
		private AnimationSwitchTween m_rightToCenterTw;

		// Token: 0x0403132D RID: 201517
		[Token(Token = "0x403132D")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_centerToLeftTw;

		// Token: 0x0403132E RID: 201518
		[Token(Token = "0x403132E")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 m_contentSize;

		// Token: 0x0403132F RID: 201519
		[Token(Token = "0x403132F")]
		[FieldOffset(Offset = "0x88")]
		private CGGalleryInspectImageViewScaleHandler.ScaleApplyType m_scaleApplyType;

		// Token: 0x04031330 RID: 201520
		[Token(Token = "0x4031330")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_contentSize;

		// Token: 0x04031331 RID: 201521
		[Token(Token = "0x4031331")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_scaleApplyType;

		// Token: 0x04031332 RID: 201522
		[Token(Token = "0x4031332")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031333 RID: 201523
		[Token(Token = "0x4031333")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureTweens;

		// Token: 0x04031334 RID: 201524
		[Token(Token = "0x4031334")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTransitionEnd;

		// Token: 0x04031335 RID: 201525
		[Token(Token = "0x4031335")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowImmediate;

		// Token: 0x04031336 RID: 201526
		[Token(Token = "0x4031336")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HideImmediate;

		// Token: 0x04031337 RID: 201527
		[Token(Token = "0x4031337")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04031338 RID: 201528
		[Token(Token = "0x4031338")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04031339 RID: 201529
		[Token(Token = "0x4031339")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x0403133A RID: 201530
		[Token(Token = "0x403133A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RenderImage;

		// Token: 0x0403133B RID: 201531
		[Token(Token = "0x403133B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderInternal;

		// Token: 0x0403133C RID: 201532
		[Token(Token = "0x403133C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RenderSingleImage;

		// Token: 0x0403133D RID: 201533
		[Token(Token = "0x403133D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderComposeImages;

		// Token: 0x0403133E RID: 201534
		[Token(Token = "0x403133E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetupImageLayout;

		// Token: 0x0403133F RID: 201535
		[Token(Token = "0x403133F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetupHorizontalLayout;

		// Token: 0x04031340 RID: 201536
		[Token(Token = "0x4031340")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SetupVerticalLayout;

		// Token: 0x04031341 RID: 201537
		[Token(Token = "0x4031341")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SetupGrid2x2Layout;

		// Token: 0x04031342 RID: 201538
		[Token(Token = "0x4031342")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ClearComposeImages;

		// Token: 0x04031343 RID: 201539
		[Token(Token = "0x4031343")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04031344 RID: 201540
		[Token(Token = "0x4031344")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
