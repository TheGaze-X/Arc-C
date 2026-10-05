using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CD2 RID: 15570
	[Token(Token = "0x2003CD2")]
	public class TuningProductCircleView : MonoBehaviour, IHotfixable, ITimeWatcher
	{
		// Token: 0x06018470 RID: 99440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018470")]
		[Address(RVA = "0x10C8EB0", Offset = "0x10C7AB0", VA = "0x1810C8EB0")]
		public void Render(TuningProductCircleView.Param viewParam)
		{
		}

		// Token: 0x06018471 RID: 99441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018471")]
		[Address(RVA = "0x10C9160", Offset = "0x10C7D60", VA = "0x1810C9160")]
		public void SetCircleShowStatus(bool isShow)
		{
		}

		// Token: 0x06018472 RID: 99442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018472")]
		[Address(RVA = "0x10C9320", Offset = "0x10C7F20", VA = "0x1810C9320", Slot = "4")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x06018473 RID: 99443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018473")]
		[Address(RVA = "0x10C9690", Offset = "0x10C8290", VA = "0x1810C9690")]
		private void _RenderCircle()
		{
		}

		// Token: 0x06018474 RID: 99444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018474")]
		[Address(RVA = "0x10C94A0", Offset = "0x10C80A0", VA = "0x1810C94A0")]
		private Image _GeneNewImage()
		{
			return null;
		}

		// Token: 0x06018475 RID: 99445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018475")]
		[Address(RVA = "0x10C95E0", Offset = "0x10C81E0", VA = "0x1810C95E0")]
		private Sprite _LoadFragmentSprite(ILoadAsset assetLoader, string spriteId)
		{
			return null;
		}

		// Token: 0x06018476 RID: 99446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018476")]
		[Address(RVA = "0x10C99E0", Offset = "0x10C85E0", VA = "0x1810C99E0")]
		private void _RotateImageWithTargetAngle(Image targetImage, float targetAngle)
		{
		}

		// Token: 0x06018477 RID: 99447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018477")]
		[Address(RVA = "0x10C9550", Offset = "0x10C8150", VA = "0x1810C9550")]
		private void _KillSequence()
		{
		}

		// Token: 0x06018478 RID: 99448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018478")]
		[Address(RVA = "0x10C92C0", Offset = "0x10C7EC0", VA = "0x1810C92C0")]
		private void Start()
		{
		}

		// Token: 0x06018479 RID: 99449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018479")]
		[Address(RVA = "0x10C8E50", Offset = "0x10C7A50", VA = "0x1810C8E50")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601847A RID: 99450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601847A")]
		[Address(RVA = "0x10C9B70", Offset = "0x10C8770", VA = "0x1810C9B70")]
		public TuningProductCircleView()
		{
		}

		// Token: 0x0401DA09 RID: 121353
		[Token(Token = "0x401DA09")]
		private const float CIRCLE_FULL_ANGLE = 360f;

		// Token: 0x0401DA0A RID: 121354
		[Token(Token = "0x401DA0A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _selfRectTransform;

		// Token: 0x0401DA0B RID: 121355
		[Token(Token = "0x401DA0B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _baseImg;

		// Token: 0x0401DA0C RID: 121356
		[Token(Token = "0x401DA0C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _circleGroup;

		// Token: 0x0401DA0D RID: 121357
		[Token(Token = "0x401DA0D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _showAlpha;

		// Token: 0x0401DA0E RID: 121358
		[Token(Token = "0x401DA0E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _hideAlpha;

		// Token: 0x0401DA0F RID: 121359
		[Token(Token = "0x401DA0F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _fadeTweenDuration;

		// Token: 0x0401DA10 RID: 121360
		[Token(Token = "0x401DA10")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _radius;

		// Token: 0x0401DA11 RID: 121361
		[Token(Token = "0x401DA11")]
		[FieldOffset(Offset = "0x40")]
		private List<Image> m_imageList;

		// Token: 0x0401DA12 RID: 121362
		[Token(Token = "0x401DA12")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401DA13 RID: 121363
		[Token(Token = "0x401DA13")]
		[FieldOffset(Offset = "0x58")]
		private float m_currentSoundPerRound;

		// Token: 0x0401DA14 RID: 121364
		[Token(Token = "0x401DA14")]
		[FieldOffset(Offset = "0x5C")]
		private float m_currentRotateAngle;

		// Token: 0x0401DA15 RID: 121365
		[Token(Token = "0x401DA15")]
		[FieldOffset(Offset = "0x60")]
		private TuningProductCircleView.Param m_cachedParam;

		// Token: 0x0401DA16 RID: 121366
		[Token(Token = "0x401DA16")]
		[FieldOffset(Offset = "0x80")]
		private Sequence m_sequence;

		// Token: 0x0401DA17 RID: 121367
		[Token(Token = "0x401DA17")]
		[FieldOffset(Offset = "0x88")]
		private bool m_cachedIsShow;

		// Token: 0x0401DA18 RID: 121368
		[Token(Token = "0x401DA18")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedSegmentId;

		// Token: 0x0401DA19 RID: 121369
		[Token(Token = "0x401DA19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DA1A RID: 121370
		[Token(Token = "0x401DA1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetCircleShowStatus;

		// Token: 0x0401DA1B RID: 121371
		[Token(Token = "0x401DA1B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0401DA1C RID: 121372
		[Token(Token = "0x401DA1C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCircle;

		// Token: 0x0401DA1D RID: 121373
		[Token(Token = "0x401DA1D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GeneNewImage;

		// Token: 0x0401DA1E RID: 121374
		[Token(Token = "0x401DA1E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadFragmentSprite;

		// Token: 0x0401DA1F RID: 121375
		[Token(Token = "0x401DA1F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RotateImageWithTargetAngle;

		// Token: 0x0401DA20 RID: 121376
		[Token(Token = "0x401DA20")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__KillSequence;

		// Token: 0x0401DA21 RID: 121377
		[Token(Token = "0x401DA21")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401DA22 RID: 121378
		[Token(Token = "0x401DA22")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401DA23 RID: 121379
		[Token(Token = "0x401DA23")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CD3 RID: 15571
		[Token(Token = "0x2003CD3")]
		public struct Param
		{
			// Token: 0x0401DA24 RID: 121380
			[Token(Token = "0x401DA24")]
			[FieldOffset(Offset = "0x0")]
			public string spriteId;

			// Token: 0x0401DA25 RID: 121381
			[Token(Token = "0x401DA25")]
			[FieldOffset(Offset = "0x8")]
			public int stepCount;

			// Token: 0x0401DA26 RID: 121382
			[Token(Token = "0x401DA26")]
			[FieldOffset(Offset = "0xC")]
			public float soundPerRound;

			// Token: 0x0401DA27 RID: 121383
			[Token(Token = "0x401DA27")]
			[FieldOffset(Offset = "0x10")]
			public Color spriteColor;
		}
	}
}
