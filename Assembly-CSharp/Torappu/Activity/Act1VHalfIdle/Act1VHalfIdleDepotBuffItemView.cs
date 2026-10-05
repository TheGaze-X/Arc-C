using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200779A RID: 30618
	[Token(Token = "0x200779A")]
	public class Act1VHalfIdleDepotBuffItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AFDA RID: 176090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFDA")]
		[Address(RVA = "0x26C8690", Offset = "0x26C7290", VA = "0x1826C8690")]
		public void Render(Act1VHalfIdleDepotBuffItemViewModel viewModel, int enterSeq)
		{
		}

		// Token: 0x0602AFDB RID: 176091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFDB")]
		[Address(RVA = "0x26C8BF0", Offset = "0x26C77F0", VA = "0x1826C8BF0")]
		private void _PlayUpgradeAnim()
		{
		}

		// Token: 0x0602AFDC RID: 176092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFDC")]
		[Address(RVA = "0x26C85A0", Offset = "0x26C71A0", VA = "0x1826C85A0")]
		public void OnClick()
		{
		}

		// Token: 0x0602AFDD RID: 176093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFDD")]
		[Address(RVA = "0x26C8D60", Offset = "0x26C7960", VA = "0x1826C8D60")]
		public Act1VHalfIdleDepotBuffItemView()
		{
		}

		// Token: 0x0403E0C6 RID: 254150
		[Token(Token = "0x403E0C6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403E0C7 RID: 254151
		[Token(Token = "0x403E0C7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _level;

		// Token: 0x0403E0C8 RID: 254152
		[Token(Token = "0x403E0C8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403E0C9 RID: 254153
		[Token(Token = "0x403E0C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0403E0CA RID: 254154
		[Token(Token = "0x403E0CA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelInactive;

		// Token: 0x0403E0CB RID: 254155
		[Token(Token = "0x403E0CB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _activeColor;

		// Token: 0x0403E0CC RID: 254156
		[Token(Token = "0x403E0CC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _inactiveColor;

		// Token: 0x0403E0CD RID: 254157
		[Token(Token = "0x403E0CD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelMax;

		// Token: 0x0403E0CE RID: 254158
		[Token(Token = "0x403E0CE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelCount;

		// Token: 0x0403E0CF RID: 254159
		[Token(Token = "0x403E0CF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0403E0D0 RID: 254160
		[Token(Token = "0x403E0D0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textCountEmpty;

		// Token: 0x0403E0D1 RID: 254161
		[Token(Token = "0x403E0D1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _upgradeAnim;

		// Token: 0x0403E0D2 RID: 254162
		[Token(Token = "0x403E0D2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelAnim;

		// Token: 0x0403E0D3 RID: 254163
		[Token(Token = "0x403E0D3")]
		[FieldOffset(Offset = "0x98")]
		private int m_cachedEnterSeq;

		// Token: 0x0403E0D4 RID: 254164
		[Token(Token = "0x403E0D4")]
		[FieldOffset(Offset = "0xA0")]
		private Act1VHalfIdleDepotBuffItemViewModel m_cachedViewModel;

		// Token: 0x0403E0D5 RID: 254165
		[Token(Token = "0x403E0D5")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403E0D6 RID: 254166
		[Token(Token = "0x403E0D6")]
		[FieldOffset(Offset = "0xB8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E0D7 RID: 254167
		[Token(Token = "0x403E0D7")]
		[FieldOffset(Offset = "0xC8")]
		private ProfessionCategory m_cachedProf;

		// Token: 0x0403E0D8 RID: 254168
		[Token(Token = "0x403E0D8")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_upgradeTween;

		// Token: 0x0403E0D9 RID: 254169
		[Token(Token = "0x403E0D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E0DA RID: 254170
		[Token(Token = "0x403E0DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayUpgradeAnim;

		// Token: 0x0403E0DB RID: 254171
		[Token(Token = "0x403E0DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403E0DC RID: 254172
		[Token(Token = "0x403E0DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
