using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005021 RID: 20513
	[Token(Token = "0x2005021")]
	public class EnemyDuelPrepareModeBannerPreviewCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700470A RID: 18186
		// (get) Token: 0x0601E6D9 RID: 124633 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E6D8 RID: 124632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700470A")]
		public Action<int> onClick
		{
			[Token(Token = "0x601E6D9")]
			[Address(RVA = "0x1826B40", Offset = "0x1825740", VA = "0x181826B40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601E6D8")]
			[Address(RVA = "0x1826BA0", Offset = "0x18257A0", VA = "0x181826BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E6DA RID: 124634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6DA")]
		[Address(RVA = "0x1826A00", Offset = "0x1825600", VA = "0x181826A00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E6DB RID: 124635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6DB")]
		[Address(RVA = "0x1826710", Offset = "0x1825310", VA = "0x181826710")]
		public void Render(EnemyDuelPrepareModeBannerPreviewCardView.Param param)
		{
		}

		// Token: 0x0601E6DC RID: 124636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6DC")]
		[Address(RVA = "0x1826600", Offset = "0x1825200", VA = "0x181826600")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601E6DD RID: 124637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6DD")]
		[Address(RVA = "0x1826AE0", Offset = "0x18256E0", VA = "0x181826AE0")]
		public EnemyDuelPrepareModeBannerPreviewCardView()
		{
		}

		// Token: 0x04028B94 RID: 166804
		[Token(Token = "0x4028B94")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _previewOutAnim;

		// Token: 0x04028B95 RID: 166805
		[Token(Token = "0x4028B95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _previewImg;

		// Token: 0x04028B96 RID: 166806
		[Token(Token = "0x4028B96")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04028B97 RID: 166807
		[Token(Token = "0x4028B97")]
		[FieldOffset(Offset = "0x38")]
		private string m_spriteId;

		// Token: 0x04028B98 RID: 166808
		[Token(Token = "0x4028B98")]
		[FieldOffset(Offset = "0x40")]
		private int m_viewIdx;

		// Token: 0x04028B99 RID: 166809
		[Token(Token = "0x4028B99")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028B9A RID: 166810
		[Token(Token = "0x4028B9A")]
		[FieldOffset(Offset = "0x58")]
		private AnimationSwitchTween m_notPreviewSwitchTween;

		// Token: 0x04028B9C RID: 166812
		[Token(Token = "0x4028B9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04028B9D RID: 166813
		[Token(Token = "0x4028B9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04028B9E RID: 166814
		[Token(Token = "0x4028B9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028B9F RID: 166815
		[Token(Token = "0x4028B9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028BA0 RID: 166816
		[Token(Token = "0x4028BA0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04028BA1 RID: 166817
		[Token(Token = "0x4028BA1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005022 RID: 20514
		[Token(Token = "0x2005022")]
		public struct Param
		{
			// Token: 0x04028BA2 RID: 166818
			[Token(Token = "0x4028BA2")]
			[FieldOffset(Offset = "0x0")]
			public string actId;

			// Token: 0x04028BA3 RID: 166819
			[Token(Token = "0x4028BA3")]
			[FieldOffset(Offset = "0x8")]
			public ActivityEnemyDuelModeData modeData;

			// Token: 0x04028BA4 RID: 166820
			[Token(Token = "0x4028BA4")]
			[FieldOffset(Offset = "0x10")]
			public int viewIdx;

			// Token: 0x04028BA5 RID: 166821
			[Token(Token = "0x4028BA5")]
			[FieldOffset(Offset = "0x14")]
			public int currentPreviewIdx;
		}
	}
}
