using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x0200782E RID: 30766
	[Token(Token = "0x200782E")]
	public class Act1VHalfIdleBattleFinishPlotCardView : MonoBehaviour, IAct1VHalfIdleSimpleItemView<Act1VHalfIdleBattleFinishPlotCardViewModel>, IHotfixable
	{
		// Token: 0x0602B26D RID: 176749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B26D")]
		[Address(RVA = "0x26F5130", Offset = "0x26F3D30", VA = "0x1826F5130", Slot = "4")]
		public void Render(Act1VHalfIdleBattleFinishPlotCardViewModel model)
		{
		}

		// Token: 0x0602B26E RID: 176750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B26E")]
		[Address(RVA = "0x26F5250", Offset = "0x26F3E50", VA = "0x1826F5250")]
		public Act1VHalfIdleBattleFinishPlotCardView()
		{
		}

		// Token: 0x0403E613 RID: 255507
		[Token(Token = "0x403E613")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403E614 RID: 255508
		[Token(Token = "0x403E614")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _rarity;

		// Token: 0x0403E615 RID: 255509
		[Token(Token = "0x403E615")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E616 RID: 255510
		[Token(Token = "0x403E616")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E617 RID: 255511
		[Token(Token = "0x403E617")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
