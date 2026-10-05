using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004E99 RID: 20121
	[Token(Token = "0x2004E99")]
	public class FifthAnnivExploreCheckPointResultView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004668 RID: 18024
		// (get) Token: 0x0601E04B RID: 122955 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E04A RID: 122954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004668")]
		public Action onNextBtnClick
		{
			[Token(Token = "0x601E04B")]
			[Address(RVA = "0x17B5F30", Offset = "0x17B4B30", VA = "0x1817B5F30")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601E04A")]
			[Address(RVA = "0x17B5F90", Offset = "0x17B4B90", VA = "0x1817B5F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E04C RID: 122956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E04C")]
		[Address(RVA = "0x17B57F0", Offset = "0x17B43F0", VA = "0x1817B57F0")]
		public void Render(FifthAnnivExploreCheckPointResultViewModel viewModel)
		{
		}

		// Token: 0x0601E04D RID: 122957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E04D")]
		[Address(RVA = "0x17B5710", Offset = "0x17B4310", VA = "0x1817B5710")]
		public void OnNextBtnClick()
		{
		}

		// Token: 0x0601E04E RID: 122958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E04E")]
		[Address(RVA = "0x17B5E20", Offset = "0x17B4A20", VA = "0x1817B5E20")]
		private void _ResetAnimations()
		{
		}

		// Token: 0x0601E04F RID: 122959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E04F")]
		[Address(RVA = "0x17B5D20", Offset = "0x17B4920", VA = "0x1817B5D20")]
		private void _PlayTween(UIAnimationLocation animLocaltion)
		{
		}

		// Token: 0x0601E050 RID: 122960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E050")]
		[Address(RVA = "0x17B5ED0", Offset = "0x17B4AD0", VA = "0x1817B5ED0")]
		public FifthAnnivExploreCheckPointResultView()
		{
		}

		// Token: 0x04027E6F RID: 163439
		[Token(Token = "0x4027E6F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _stageNumObj;

		// Token: 0x04027E70 RID: 163440
		[Token(Token = "0x4027E70")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageNumText;

		// Token: 0x04027E71 RID: 163441
		[Token(Token = "0x4027E71")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _targetDescText;

		// Token: 0x04027E72 RID: 163442
		[Token(Token = "0x4027E72")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _groupIconImg;

		// Token: 0x04027E73 RID: 163443
		[Token(Token = "0x4027E73")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _groupIconAtlas;

		// Token: 0x04027E74 RID: 163444
		[Token(Token = "0x4027E74")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _endingIconImg;

		// Token: 0x04027E75 RID: 163445
		[Token(Token = "0x4027E75")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _groupInfoObj;

		// Token: 0x04027E76 RID: 163446
		[Token(Token = "0x4027E76")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _groupNameText;

		// Token: 0x04027E77 RID: 163447
		[Token(Token = "0x4027E77")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _groupCodeText;

		// Token: 0x04027E78 RID: 163448
		[Token(Token = "0x4027E78")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _nextHotspotObj;

		// Token: 0x04027E79 RID: 163449
		[Token(Token = "0x4027E79")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _unexpandTitleText;

		// Token: 0x04027E7A RID: 163450
		[Token(Token = "0x4027E7A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _unexpandDescText;

		// Token: 0x04027E7B RID: 163451
		[Token(Token = "0x4027E7B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _expandSubTitleText;

		// Token: 0x04027E7C RID: 163452
		[Token(Token = "0x4027E7C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _expandTitleText;

		// Token: 0x04027E7D RID: 163453
		[Token(Token = "0x4027E7D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _clickHintText;

		// Token: 0x04027E7E RID: 163454
		[Token(Token = "0x4027E7E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _darkenBkg;

		// Token: 0x04027E7F RID: 163455
		[Token(Token = "0x4027E7F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _failNoiseImg;

		// Token: 0x04027E80 RID: 163456
		[Token(Token = "0x4027E80")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04027E81 RID: 163457
		[Token(Token = "0x4027E81")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _nextAnim;

		// Token: 0x04027E82 RID: 163458
		[Token(Token = "0x4027E82")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _failAnim;

		// Token: 0x04027E83 RID: 163459
		[Token(Token = "0x4027E83")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x04027E84 RID: 163460
		[Token(Token = "0x4027E84")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_tween;

		// Token: 0x04027E85 RID: 163461
		[Token(Token = "0x4027E85")]
		[FieldOffset(Offset = "0xE0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04027E87 RID: 163463
		[Token(Token = "0x4027E87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onNextBtnClick;

		// Token: 0x04027E88 RID: 163464
		[Token(Token = "0x4027E88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onNextBtnClick;

		// Token: 0x04027E89 RID: 163465
		[Token(Token = "0x4027E89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027E8A RID: 163466
		[Token(Token = "0x4027E8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnNextBtnClick;

		// Token: 0x04027E8B RID: 163467
		[Token(Token = "0x4027E8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetAnimations;

		// Token: 0x04027E8C RID: 163468
		[Token(Token = "0x4027E8C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayTween;

		// Token: 0x04027E8D RID: 163469
		[Token(Token = "0x4027E8D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
