using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200745E RID: 29790
	[Token(Token = "0x200745E")]
	public class Act36sideFoodHandbookView : DataBinder<Act36sideFoodHandbookProperty>
	{
		// Token: 0x0602A069 RID: 172137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A069")]
		[Address(RVA = "0x259F100", Offset = "0x259DD00", VA = "0x18259F100", Slot = "7")]
		public override void OnValueChanged(Act36sideFoodHandbookProperty property)
		{
		}

		// Token: 0x0602A06A RID: 172138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A06A")]
		[Address(RVA = "0x259F080", Offset = "0x259DC80", VA = "0x18259F080")]
		public void CloseFoodHandbook()
		{
		}

		// Token: 0x0602A06B RID: 172139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A06B")]
		[Address(RVA = "0x259F690", Offset = "0x259E290", VA = "0x18259F690")]
		public Act36sideFoodHandbookView()
		{
		}

		// Token: 0x0403C48E RID: 246926
		[Token(Token = "0x403C48E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act36sideFoodHandbookEnemyPanel _enemyPanel;

		// Token: 0x0403C48F RID: 246927
		[Token(Token = "0x403C48F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act36sideFoodHandbookTabItem[] _tabItems;

		// Token: 0x0403C490 RID: 246928
		[Token(Token = "0x403C490")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act36sideFoodHandbookTokenPanel _tokenPanel;

		// Token: 0x0403C491 RID: 246929
		[Token(Token = "0x403C491")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act36sideFoodHandbookCollectRewardItem _rewardItem;

		// Token: 0x0403C492 RID: 246930
		[Token(Token = "0x403C492")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _potPanel;

		// Token: 0x0403C493 RID: 246931
		[Token(Token = "0x403C493")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C494 RID: 246932
		[Token(Token = "0x403C494")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403C495 RID: 246933
		[Token(Token = "0x403C495")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CloseFoodHandbook;

		// Token: 0x0403C496 RID: 246934
		[Token(Token = "0x403C496")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
