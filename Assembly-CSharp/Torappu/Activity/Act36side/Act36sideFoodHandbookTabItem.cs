using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200745A RID: 29786
	[Token(Token = "0x200745A")]
	public class Act36sideFoodHandbookTabItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A05C RID: 172124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A05C")]
		[Address(RVA = "0x259D3D0", Offset = "0x259BFD0", VA = "0x18259D3D0")]
		public void Render(Act36sideFoodHandbookViewModel model)
		{
		}

		// Token: 0x0602A05D RID: 172125 RVA: 0x000D7418 File Offset: 0x000D5618
		[Token(Token = "0x602A05D")]
		[Address(RVA = "0x259D4F0", Offset = "0x259C0F0", VA = "0x18259D4F0")]
		private static bool _CheckHasNewByType(Act36sideFoodHandbookViewModel model, Act36sideFoodHandbookTabType tabType)
		{
			return default(bool);
		}

		// Token: 0x0602A05E RID: 172126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A05E")]
		[Address(RVA = "0x259D200", Offset = "0x259BE00", VA = "0x18259D200")]
		public void OnSelectTab()
		{
		}

		// Token: 0x0602A05F RID: 172127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A05F")]
		[Address(RVA = "0x259D590", Offset = "0x259C190", VA = "0x18259D590")]
		public Act36sideFoodHandbookTabItem()
		{
		}

		// Token: 0x0403C464 RID: 246884
		[Token(Token = "0x403C464")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act36sideFoodHandbookTabType _tabType;

		// Token: 0x0403C465 RID: 246885
		[Token(Token = "0x403C465")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _selectToggle;

		// Token: 0x0403C466 RID: 246886
		[Token(Token = "0x403C466")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _newPanel;

		// Token: 0x0403C467 RID: 246887
		[Token(Token = "0x403C467")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _clickAnim;

		// Token: 0x0403C468 RID: 246888
		[Token(Token = "0x403C468")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C469 RID: 246889
		[Token(Token = "0x403C469")]
		[FieldOffset(Offset = "0x50")]
		private Act36sideFoodHandbookTabType m_cachedSelectedType;

		// Token: 0x0403C46A RID: 246890
		[Token(Token = "0x403C46A")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_clickAnimTween;

		// Token: 0x0403C46B RID: 246891
		[Token(Token = "0x403C46B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C46C RID: 246892
		[Token(Token = "0x403C46C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckHasNewByType;

		// Token: 0x0403C46D RID: 246893
		[Token(Token = "0x403C46D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSelectTab;

		// Token: 0x0403C46E RID: 246894
		[Token(Token = "0x403C46E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
