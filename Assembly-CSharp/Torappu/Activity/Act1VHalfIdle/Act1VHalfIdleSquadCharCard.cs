using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077FA RID: 30714
	[Token(Token = "0x20077FA")]
	public class Act1VHalfIdleSquadCharCard : CommonSquadCardViewBase
	{
		// Token: 0x0602B161 RID: 176481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B161")]
		[Address(RVA = "0x26E34E0", Offset = "0x26E20E0", VA = "0x1826E34E0")]
		private void _CreateCardIfNot()
		{
		}

		// Token: 0x0602B162 RID: 176482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B162")]
		[Address(RVA = "0x26E33D0", Offset = "0x26E1FD0", VA = "0x1826E33D0", Slot = "5")]
		protected override void CustomRenderCard(CommonSquadCardViewBase.Options input)
		{
		}

		// Token: 0x0602B163 RID: 176483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B163")]
		[Address(RVA = "0x26E3690", Offset = "0x26E2290", VA = "0x1826E3690")]
		public Act1VHalfIdleSquadCharCard()
		{
		}

		// Token: 0x0403E42A RID: 255018
		[Token(Token = "0x403E42A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0403E42B RID: 255019
		[Token(Token = "0x403E42B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0403E42C RID: 255020
		[Token(Token = "0x403E42C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0403E42D RID: 255021
		[Token(Token = "0x403E42D")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isCreateCard;

		// Token: 0x0403E42E RID: 255022
		[Token(Token = "0x403E42E")]
		[FieldOffset(Offset = "0x58")]
		private CommonCharCardView m_cacheCard;

		// Token: 0x0403E42F RID: 255023
		[Token(Token = "0x403E42F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CreateCardIfNot;

		// Token: 0x0403E430 RID: 255024
		[Token(Token = "0x403E430")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CustomRenderCard;

		// Token: 0x0403E431 RID: 255025
		[Token(Token = "0x403E431")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
