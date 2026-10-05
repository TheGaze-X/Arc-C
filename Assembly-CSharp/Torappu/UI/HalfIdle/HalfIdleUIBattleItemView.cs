using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006764 RID: 26468
	[Token(Token = "0x2006764")]
	public class HalfIdleUIBattleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025F98 RID: 155544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F98")]
		[Address(RVA = "0x20F6240", Offset = "0x20F4E40", VA = "0x1820F6240")]
		public void Render(HalfIdleUIBattleItemViewModel viewModel)
		{
		}

		// Token: 0x06025F99 RID: 155545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F99")]
		[Address(RVA = "0x20F6620", Offset = "0x20F5220", VA = "0x1820F6620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025F9A RID: 155546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F9A")]
		[Address(RVA = "0x20F6740", Offset = "0x20F5340", VA = "0x1820F6740")]
		public HalfIdleUIBattleItemView()
		{
		}

		// Token: 0x040356F6 RID: 218870
		[Token(Token = "0x40356F6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemNumText;

		// Token: 0x040356F7 RID: 218871
		[Token(Token = "0x40356F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x040356F8 RID: 218872
		[Token(Token = "0x40356F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _itemAddedAnim;

		// Token: 0x040356F9 RID: 218873
		[Token(Token = "0x40356F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _itemCollectProgress;

		// Token: 0x040356FA RID: 218874
		[Token(Token = "0x40356FA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _fullGo;

		// Token: 0x040356FB RID: 218875
		[Token(Token = "0x40356FB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x040356FC RID: 218876
		[Token(Token = "0x40356FC")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040356FD RID: 218877
		[Token(Token = "0x40356FD")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedCnt;

		// Token: 0x040356FE RID: 218878
		[Token(Token = "0x40356FE")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_progressTween;

		// Token: 0x040356FF RID: 218879
		[Token(Token = "0x40356FF")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_itemAddedTween;

		// Token: 0x04035700 RID: 218880
		[Token(Token = "0x4035700")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x04035701 RID: 218881
		[Token(Token = "0x4035701")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035702 RID: 218882
		[Token(Token = "0x4035702")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035703 RID: 218883
		[Token(Token = "0x4035703")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
