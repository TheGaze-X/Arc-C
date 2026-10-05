using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006745 RID: 26437
	[Token(Token = "0x2006745")]
	public class HalfIdleUIBattleEquipIconView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025F10 RID: 155408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F10")]
		[Address(RVA = "0x20F1510", Offset = "0x20F0110", VA = "0x1820F1510")]
		public void Render(Act1VHalfIdleEquipData data, string actId)
		{
		}

		// Token: 0x06025F11 RID: 155409 RVA: 0x000C9810 File Offset: 0x000C7A10
		[Token(Token = "0x6025F11")]
		[Address(RVA = "0x20F1770", Offset = "0x20F0370", VA = "0x1820F1770")]
		private Color _GetEquipLevelColor(int level)
		{
			return default(Color);
		}

		// Token: 0x06025F12 RID: 155410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F12")]
		[Address(RVA = "0x20F1840", Offset = "0x20F0440", VA = "0x1820F1840")]
		public HalfIdleUIBattleEquipIconView()
		{
		}

		// Token: 0x040355A8 RID: 218536
		[Token(Token = "0x40355A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImg;

		// Token: 0x040355A9 RID: 218537
		[Token(Token = "0x40355A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _glowImg;

		// Token: 0x040355AA RID: 218538
		[Token(Token = "0x40355AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _levelImg;

		// Token: 0x040355AB RID: 218539
		[Token(Token = "0x40355AB")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040355AC RID: 218540
		[Token(Token = "0x40355AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040355AD RID: 218541
		[Token(Token = "0x40355AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetEquipLevelColor;

		// Token: 0x040355AE RID: 218542
		[Token(Token = "0x40355AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
