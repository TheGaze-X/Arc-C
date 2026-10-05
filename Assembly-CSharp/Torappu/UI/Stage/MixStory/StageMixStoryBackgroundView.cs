using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Video;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A5C RID: 27228
	[Token(Token = "0x2006A5C")]
	public class StageMixStoryBackgroundView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026E8C RID: 159372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E8C")]
		[Address(RVA = "0x22204E0", Offset = "0x221F0E0", VA = "0x1822204E0")]
		public void ResetView()
		{
		}

		// Token: 0x06026E8D RID: 159373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E8D")]
		[Address(RVA = "0x22203D0", Offset = "0x221EFD0", VA = "0x1822203D0")]
		public void ResetMovieView()
		{
		}

		// Token: 0x06026E8E RID: 159374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E8E")]
		[Address(RVA = "0x2220010", Offset = "0x221EC10", VA = "0x182220010")]
		public void Render(MixStoryZoneGroupViewModel model, bool fastMode)
		{
		}

		// Token: 0x06026E8F RID: 159375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E8F")]
		[Address(RVA = "0x2220CD0", Offset = "0x221F8D0", VA = "0x182220CD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026E90 RID: 159376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E90")]
		[Address(RVA = "0x22209D0", Offset = "0x221F5D0", VA = "0x1822209D0")]
		private string _GetTargetBackgroundId(MixStoryZoneGroupViewModel model, out bool haveVideoToPlay)
		{
			return null;
		}

		// Token: 0x06026E91 RID: 159377 RVA: 0x000CCA68 File Offset: 0x000CAC68
		[Token(Token = "0x6026E91")]
		[Address(RVA = "0x2220930", Offset = "0x221F530", VA = "0x182220930")]
		private StorylineType _GetLineType(MixStoryZoneGroupViewModel model)
		{
			return StorylineType.CONTINUE;
		}

		// Token: 0x06026E92 RID: 159378 RVA: 0x000CCA80 File Offset: 0x000CAC80
		[Token(Token = "0x6026E92")]
		[Address(RVA = "0x2220650", Offset = "0x221F250", VA = "0x182220650")]
		private bool _CheckNeedToPlayVideo()
		{
			return default(bool);
		}

		// Token: 0x06026E93 RID: 159379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E93")]
		[Address(RVA = "0x2220F60", Offset = "0x221FB60", VA = "0x182220F60")]
		private void _RenderBackground()
		{
		}

		// Token: 0x06026E94 RID: 159380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E94")]
		[Address(RVA = "0x2220770", Offset = "0x221F370", VA = "0x182220770")]
		private Tween _GenerateSwitchTween()
		{
			return null;
		}

		// Token: 0x06026E95 RID: 159381 RVA: 0x000CCA98 File Offset: 0x000CAC98
		[Token(Token = "0x6026E95")]
		[Address(RVA = "0x2220C70", Offset = "0x221F870", VA = "0x182220C70")]
		private float _GetTime()
		{
			return 0f;
		}

		// Token: 0x06026E96 RID: 159382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E96")]
		[Address(RVA = "0x2221410", Offset = "0x2220010", VA = "0x182221410")]
		private void _SetTimeAndRender(float time)
		{
		}

		// Token: 0x06026E97 RID: 159383 RVA: 0x000CCAB0 File Offset: 0x000CACB0
		[Token(Token = "0x6026E97")]
		[Address(RVA = "0x22206E0", Offset = "0x221F2E0", VA = "0x1822206E0")]
		private float _EvaluatePosition(float time)
		{
			return 0f;
		}

		// Token: 0x06026E98 RID: 159384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E98")]
		[Address(RVA = "0x2220EB0", Offset = "0x221FAB0", VA = "0x182220EB0")]
		private IEnumerator _PlayCoroutine()
		{
			return null;
		}

		// Token: 0x06026E99 RID: 159385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E99")]
		[Address(RVA = "0x22215C0", Offset = "0x22201C0", VA = "0x1822215C0")]
		public StageMixStoryBackgroundView()
		{
		}

		// Token: 0x04037083 RID: 225411
		[Token(Token = "0x4037083")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _imageVariant;

		// Token: 0x04037084 RID: 225412
		[Token(Token = "0x4037084")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIDynImage _backgroundImage;

		// Token: 0x04037085 RID: 225413
		[Token(Token = "0x4037085")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _videoVariant;

		// Token: 0x04037086 RID: 225414
		[Token(Token = "0x4037086")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _moviePlayerHolderContainer;

		// Token: 0x04037087 RID: 225415
		[Token(Token = "0x4037087")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _continuousPanel;

		// Token: 0x04037088 RID: 225416
		[Token(Token = "0x4037088")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _discretePanel;

		// Token: 0x04037089 RID: 225417
		[Token(Token = "0x4037089")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _switchAnimation;

		// Token: 0x0403708A RID: 225418
		[Token(Token = "0x403708A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Ease _switchEase;

		// Token: 0x0403708B RID: 225419
		[Token(Token = "0x403708B")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_hasInited;

		// Token: 0x0403708C RID: 225420
		[Token(Token = "0x403708C")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403708D RID: 225421
		[Token(Token = "0x403708D")]
		[FieldOffset(Offset = "0x70")]
		private ILoadAsset m_iLoadAsset;

		// Token: 0x0403708E RID: 225422
		[Token(Token = "0x403708E")]
		[FieldOffset(Offset = "0x78")]
		private AnimationWrapper m_wrapper;

		// Token: 0x0403708F RID: 225423
		[Token(Token = "0x403708F")]
		[FieldOffset(Offset = "0x80")]
		private float m_switchDuration;

		// Token: 0x04037090 RID: 225424
		[Token(Token = "0x4037090")]
		[FieldOffset(Offset = "0x88")]
		private AbstractMediaPlayerHolder m_playerHolder;

		// Token: 0x04037091 RID: 225425
		[Token(Token = "0x4037091")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedId;

		// Token: 0x04037092 RID: 225426
		[Token(Token = "0x4037092")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasVideo;

		// Token: 0x04037093 RID: 225427
		[Token(Token = "0x4037093")]
		[FieldOffset(Offset = "0x9C")]
		private StorylineType m_lineType;

		// Token: 0x04037094 RID: 225428
		[Token(Token = "0x4037094")]
		[FieldOffset(Offset = "0xA0")]
		private string m_displayingId;

		// Token: 0x04037095 RID: 225429
		[Token(Token = "0x4037095")]
		[FieldOffset(Offset = "0xA8")]
		private string m_videoId;

		// Token: 0x04037096 RID: 225430
		[Token(Token = "0x4037096")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_switchTween;

		// Token: 0x04037097 RID: 225431
		[Token(Token = "0x4037097")]
		[FieldOffset(Offset = "0xB8")]
		private float m_time;

		// Token: 0x04037098 RID: 225432
		[Token(Token = "0x4037098")]
		[FieldOffset(Offset = "0xBC")]
		private float m_lastPos;

		// Token: 0x04037099 RID: 225433
		[Token(Token = "0x4037099")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ResetView;

		// Token: 0x0403709A RID: 225434
		[Token(Token = "0x403709A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetMovieView;

		// Token: 0x0403709B RID: 225435
		[Token(Token = "0x403709B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403709C RID: 225436
		[Token(Token = "0x403709C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403709D RID: 225437
		[Token(Token = "0x403709D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetTargetBackgroundId;

		// Token: 0x0403709E RID: 225438
		[Token(Token = "0x403709E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetLineType;

		// Token: 0x0403709F RID: 225439
		[Token(Token = "0x403709F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckNeedToPlayVideo;

		// Token: 0x040370A0 RID: 225440
		[Token(Token = "0x40370A0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderBackground;

		// Token: 0x040370A1 RID: 225441
		[Token(Token = "0x40370A1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateSwitchTween;

		// Token: 0x040370A2 RID: 225442
		[Token(Token = "0x40370A2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetTime;

		// Token: 0x040370A3 RID: 225443
		[Token(Token = "0x40370A3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetTimeAndRender;

		// Token: 0x040370A4 RID: 225444
		[Token(Token = "0x40370A4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EvaluatePosition;

		// Token: 0x040370A5 RID: 225445
		[Token(Token = "0x40370A5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PlayCoroutine;

		// Token: 0x040370A6 RID: 225446
		[Token(Token = "0x40370A6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
