using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x02007832 RID: 30770
	[Token(Token = "0x2007832")]
	public class Act1VHalfIdleBattleFinishRewardItemView : MonoBehaviour, IAct1VHalfIdleSimpleItemView<Act1VHalfIdleStuffDepotItemViewModel>, IHotfixable
	{
		// Token: 0x0602B277 RID: 176759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B277")]
		[Address(RVA = "0x26F5AF0", Offset = "0x26F46F0", VA = "0x1826F5AF0", Slot = "4")]
		public void Render(Act1VHalfIdleStuffDepotItemViewModel data)
		{
		}

		// Token: 0x0602B278 RID: 176760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B278")]
		[Address(RVA = "0x26F59E0", Offset = "0x26F45E0", VA = "0x1826F59E0")]
		public void PlayEntryAnim(int idx, float delay)
		{
		}

		// Token: 0x0602B279 RID: 176761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B279")]
		[Address(RVA = "0x26F5940", Offset = "0x26F4540", VA = "0x1826F5940")]
		public void EventOnClickItem()
		{
		}

		// Token: 0x0602B27A RID: 176762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B27A")]
		[Address(RVA = "0x26F5C10", Offset = "0x26F4810", VA = "0x1826F5C10")]
		public Act1VHalfIdleBattleFinishRewardItemView()
		{
		}

		// Token: 0x0403E627 RID: 255527
		[Token(Token = "0x403E627")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403E628 RID: 255528
		[Token(Token = "0x403E628")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _entryInterval;

		// Token: 0x0403E629 RID: 255529
		[Token(Token = "0x403E629")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403E62A RID: 255530
		[Token(Token = "0x403E62A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _cnt;

		// Token: 0x0403E62B RID: 255531
		[Token(Token = "0x403E62B")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E62C RID: 255532
		[Token(Token = "0x403E62C")]
		[FieldOffset(Offset = "0x50")]
		private Act1VHalfIdleStuffDepotItemViewModel m_cachedModel;

		// Token: 0x0403E62D RID: 255533
		[Token(Token = "0x403E62D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E62E RID: 255534
		[Token(Token = "0x403E62E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayEntryAnim;

		// Token: 0x0403E62F RID: 255535
		[Token(Token = "0x403E62F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClickItem;

		// Token: 0x0403E630 RID: 255536
		[Token(Token = "0x403E630")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
