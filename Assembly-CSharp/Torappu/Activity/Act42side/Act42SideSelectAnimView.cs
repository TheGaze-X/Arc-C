using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200732D RID: 29485
	[Token(Token = "0x200732D")]
	public class Act42SideSelectAnimView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029B21 RID: 170785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B21")]
		[Address(RVA = "0x250C060", Offset = "0x250AC60", VA = "0x18250C060", Slot = "4")]
		protected virtual void _OnPlaySelectAnim()
		{
		}

		// Token: 0x06029B22 RID: 170786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B22")]
		[Address(RVA = "0x2514950", Offset = "0x2513550", VA = "0x182514950")]
		protected void _HandleSelectAnim(bool isUnlocked, bool isSelected, bool isTabChanged)
		{
		}

		// Token: 0x06029B23 RID: 170787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B23")]
		[Address(RVA = "0x2514B80", Offset = "0x2513780", VA = "0x182514B80")]
		public Act42SideSelectAnimView()
		{
		}

		// Token: 0x0403BADF RID: 244447
		[Token(Token = "0x403BADF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animSelect;

		// Token: 0x0403BAE0 RID: 244448
		[Token(Token = "0x403BAE0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animUnselect;

		// Token: 0x0403BAE1 RID: 244449
		[Token(Token = "0x403BAE1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected GameObject _selectedFrame;

		// Token: 0x0403BAE2 RID: 244450
		[Token(Token = "0x403BAE2")]
		[FieldOffset(Offset = "0x40")]
		private UIBiAnimClipSwitchTween m_tween;

		// Token: 0x0403BAE3 RID: 244451
		[Token(Token = "0x403BAE3")]
		[FieldOffset(Offset = "0x48")]
		protected bool m_cachedSelected;

		// Token: 0x0403BAE4 RID: 244452
		[Token(Token = "0x403BAE4")]
		[FieldOffset(Offset = "0x49")]
		private bool m_tweenBuild;

		// Token: 0x0403BAE5 RID: 244453
		[Token(Token = "0x403BAE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnPlaySelectAnim;

		// Token: 0x0403BAE6 RID: 244454
		[Token(Token = "0x403BAE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleSelectAnim;

		// Token: 0x0403BAE7 RID: 244455
		[Token(Token = "0x403BAE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
