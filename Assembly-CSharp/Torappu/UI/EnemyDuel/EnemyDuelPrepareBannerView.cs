using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200501F RID: 20511
	[Token(Token = "0x200501F")]
	public class EnemyDuelPrepareBannerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004709 RID: 18185
		// (get) Token: 0x0601E6CF RID: 124623 RVA: 0x000AE6A8 File Offset: 0x000AC8A8
		// (set) Token: 0x0601E6D0 RID: 124624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004709")]
		public int curBannerIdx
		{
			[Token(Token = "0x601E6CF")]
			[Address(RVA = "0x18253D0", Offset = "0x1823FD0", VA = "0x1818253D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601E6D0")]
			[Address(RVA = "0x1825430", Offset = "0x1824030", VA = "0x181825430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E6D1 RID: 124625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6D1")]
		[Address(RVA = "0x1825270", Offset = "0x1823E70", VA = "0x181825270")]
		private void _SetBannerPic(string picId)
		{
		}

		// Token: 0x0601E6D2 RID: 124626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6D2")]
		[Address(RVA = "0x1824E80", Offset = "0x1823A80", VA = "0x181824E80")]
		private void _ChangeBannerLoopIdx(int loopIdx)
		{
		}

		// Token: 0x0601E6D3 RID: 124627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E6D3")]
		[Address(RVA = "0x1824C90", Offset = "0x1823890", VA = "0x181824C90")]
		private Tween _BuildBannerPicLoopTween(float interval)
		{
			return null;
		}

		// Token: 0x0601E6D4 RID: 124628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6D4")]
		[Address(RVA = "0x1824B80", Offset = "0x1823780", VA = "0x181824B80")]
		public void Render(EnemyDuelPrepareBannerView.Param param)
		{
		}

		// Token: 0x0601E6D5 RID: 124629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6D5")]
		[Address(RVA = "0x1825370", Offset = "0x1823F70", VA = "0x181825370")]
		public EnemyDuelPrepareBannerView()
		{
		}

		// Token: 0x04028B82 RID: 166786
		[Token(Token = "0x4028B82")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bannerPicImg;

		// Token: 0x04028B83 RID: 166787
		[Token(Token = "0x4028B83")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _bannerSwitchOutAnim;

		// Token: 0x04028B84 RID: 166788
		[Token(Token = "0x4028B84")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _bannerSwitchInAnim;

		// Token: 0x04028B85 RID: 166789
		[Token(Token = "0x4028B85")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028B86 RID: 166790
		[Token(Token = "0x4028B86")]
		[FieldOffset(Offset = "0x50")]
		private EnemyDuelPrepareBannerView.Param m_param;

		// Token: 0x04028B87 RID: 166791
		[Token(Token = "0x4028B87")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_modeBannerPicLoopTween;

		// Token: 0x04028B89 RID: 166793
		[Token(Token = "0x4028B89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curBannerIdx;

		// Token: 0x04028B8A RID: 166794
		[Token(Token = "0x4028B8A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_curBannerIdx;

		// Token: 0x04028B8B RID: 166795
		[Token(Token = "0x4028B8B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetBannerPic;

		// Token: 0x04028B8C RID: 166796
		[Token(Token = "0x4028B8C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ChangeBannerLoopIdx;

		// Token: 0x04028B8D RID: 166797
		[Token(Token = "0x4028B8D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__BuildBannerPicLoopTween;

		// Token: 0x04028B8E RID: 166798
		[Token(Token = "0x4028B8E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028B8F RID: 166799
		[Token(Token = "0x4028B8F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005020 RID: 20512
		[Token(Token = "0x2005020")]
		public class Param
		{
			// Token: 0x0601E6D7 RID: 124631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E6D7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04028B90 RID: 166800
			[Token(Token = "0x4028B90")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04028B91 RID: 166801
			[Token(Token = "0x4028B91")]
			[FieldOffset(Offset = "0x18")]
			public ActivityEnemyDuelModeData modeData;

			// Token: 0x04028B92 RID: 166802
			[Token(Token = "0x4028B92")]
			[FieldOffset(Offset = "0x20")]
			public int initBannerIdx;

			// Token: 0x04028B93 RID: 166803
			[Token(Token = "0x4028B93")]
			[FieldOffset(Offset = "0x24")]
			public float rotateTime;
		}
	}
}
