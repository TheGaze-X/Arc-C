using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006020 RID: 24608
	[Token(Token = "0x2006020")]
	public class CarvingHomeEntryChallengeTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023977 RID: 145783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023977")]
		[Address(RVA = "0x1E3AB20", Offset = "0x1E39720", VA = "0x181E3AB20")]
		public void Render(CarvingHomeEntryItemViewModel itemModel)
		{
		}

		// Token: 0x06023978 RID: 145784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023978")]
		[Address(RVA = "0x1E3AC00", Offset = "0x1E39800", VA = "0x181E3AC00")]
		public void ResetStatus()
		{
		}

		// Token: 0x06023979 RID: 145785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023979")]
		[Address(RVA = "0x1E3A9C0", Offset = "0x1E395C0", VA = "0x181E3A9C0")]
		public Tween GenerateAnim(CarvingHomeEntryChallengeTabView.AnimType type)
		{
			return null;
		}

		// Token: 0x0602397A RID: 145786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602397A")]
		[Address(RVA = "0x1E3ACB0", Offset = "0x1E398B0", VA = "0x181E3ACB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602397B RID: 145787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602397B")]
		[Address(RVA = "0x1E3ADD0", Offset = "0x1E399D0", VA = "0x181E3ADD0")]
		public CarvingHomeEntryChallengeTabView()
		{
		}

		// Token: 0x0403144A RID: 201802
		[Token(Token = "0x403144A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarvingHomeEntryChallengeTabView.AnimConfig[] _animConfigList;

		// Token: 0x0403144B RID: 201803
		[Token(Token = "0x403144B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403144C RID: 201804
		[Token(Token = "0x403144C")]
		[FieldOffset(Offset = "0x28")]
		private EnumIntStructDictionary<CarvingHomeEntryChallengeTabView.AnimType, UIAnimationLocation> m_animDict;

		// Token: 0x0403144D RID: 201805
		[Token(Token = "0x403144D")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0403144E RID: 201806
		[Token(Token = "0x403144E")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403144F RID: 201807
		[Token(Token = "0x403144F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031450 RID: 201808
		[Token(Token = "0x4031450")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetStatus;

		// Token: 0x04031451 RID: 201809
		[Token(Token = "0x4031451")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateAnim;

		// Token: 0x04031452 RID: 201810
		[Token(Token = "0x4031452")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031453 RID: 201811
		[Token(Token = "0x4031453")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006021 RID: 24609
		[Token(Token = "0x2006021")]
		public enum AnimType
		{
			// Token: 0x04031455 RID: 201813
			[Token(Token = "0x4031455")]
			ENTER,
			// Token: 0x04031456 RID: 201814
			[Token(Token = "0x4031456")]
			PREV_OUT,
			// Token: 0x04031457 RID: 201815
			[Token(Token = "0x4031457")]
			PREV_IN,
			// Token: 0x04031458 RID: 201816
			[Token(Token = "0x4031458")]
			NEXT_OUT,
			// Token: 0x04031459 RID: 201817
			[Token(Token = "0x4031459")]
			NEXT_IN
		}

		// Token: 0x02006022 RID: 24610
		[Token(Token = "0x2006022")]
		[Serializable]
		public struct AnimConfig
		{
			// Token: 0x0403145A RID: 201818
			[Token(Token = "0x403145A")]
			[FieldOffset(Offset = "0x0")]
			public CarvingHomeEntryChallengeTabView.AnimType type;

			// Token: 0x0403145B RID: 201819
			[Token(Token = "0x403145B")]
			[FieldOffset(Offset = "0x8")]
			public UIAnimationLocation anim;
		}
	}
}
