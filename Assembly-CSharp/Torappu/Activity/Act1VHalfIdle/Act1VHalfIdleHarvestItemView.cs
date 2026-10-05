using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077A5 RID: 30629
	[Token(Token = "0x20077A5")]
	public class Act1VHalfIdleHarvestItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AFFD RID: 176125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFFD")]
		[Address(RVA = "0x26CC680", Offset = "0x26CB280", VA = "0x1826CC680")]
		public void Render(Act1VHalfIdleHarvestItemViewModel viewModel)
		{
		}

		// Token: 0x0602AFFE RID: 176126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFFE")]
		[Address(RVA = "0x26CC5D0", Offset = "0x26CB1D0", VA = "0x1826CC5D0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602AFFF RID: 176127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFFF")]
		[Address(RVA = "0x26CC850", Offset = "0x26CB450", VA = "0x1826CC850")]
		public Act1VHalfIdleHarvestItemView()
		{
		}

		// Token: 0x0403E119 RID: 254233
		[Token(Token = "0x403E119")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0403E11A RID: 254234
		[Token(Token = "0x403E11A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _availObj;

		// Token: 0x0403E11B RID: 254235
		[Token(Token = "0x403E11B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _disableObj;

		// Token: 0x0403E11C RID: 254236
		[Token(Token = "0x403E11C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _availItemCard;

		// Token: 0x0403E11D RID: 254237
		[Token(Token = "0x403E11D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _disableItemCard;

		// Token: 0x0403E11E RID: 254238
		[Token(Token = "0x403E11E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image[] _iconImgs;

		// Token: 0x0403E11F RID: 254239
		[Token(Token = "0x403E11F")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E120 RID: 254240
		[Token(Token = "0x403E120")]
		[FieldOffset(Offset = "0x58")]
		private UIItemViewModel m_uiItemViewModel;

		// Token: 0x0403E121 RID: 254241
		[Token(Token = "0x403E121")]
		[FieldOffset(Offset = "0x60")]
		private string m_itemId;

		// Token: 0x0403E122 RID: 254242
		[Token(Token = "0x403E122")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E123 RID: 254243
		[Token(Token = "0x403E123")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403E124 RID: 254244
		[Token(Token = "0x403E124")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
