using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007800 RID: 30720
	[Token(Token = "0x2007800")]
	public class Act1VHalfIdleSquadCustomTopMenuView : CommonSquadTopMenuViewBase
	{
		// Token: 0x0602B18C RID: 176524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B18C")]
		[Address(RVA = "0x26E7120", Offset = "0x26E5D20", VA = "0x1826E7120")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B18D RID: 176525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B18D")]
		[Address(RVA = "0x26E6EC0", Offset = "0x26E5AC0", VA = "0x1826E6EC0", Slot = "7")]
		public override void OnValueChanged(CommonSquadGroupViewProperty property)
		{
		}

		// Token: 0x0602B18E RID: 176526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B18E")]
		[Address(RVA = "0x26E7080", Offset = "0x26E5C80", VA = "0x1826E7080")]
		private void _EventOnClickBack()
		{
		}

		// Token: 0x0602B18F RID: 176527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B18F")]
		[Address(RVA = "0x26E7290", Offset = "0x26E5E90", VA = "0x1826E7290")]
		public Act1VHalfIdleSquadCustomTopMenuView()
		{
		}

		// Token: 0x0403E463 RID: 255075
		[Token(Token = "0x403E463")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act1VHalfIdleCommonTopMenu _halfIdleTopMenuAsset;

		// Token: 0x0403E464 RID: 255076
		[Token(Token = "0x403E464")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _halfIdleTopMenuRoot;

		// Token: 0x0403E465 RID: 255077
		[Token(Token = "0x403E465")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403E466 RID: 255078
		[Token(Token = "0x403E466")]
		[FieldOffset(Offset = "0x48")]
		private Act1VHalfIdleCommonTopMenu m_halfIdleCommonTopMenu;

		// Token: 0x0403E467 RID: 255079
		[Token(Token = "0x403E467")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E468 RID: 255080
		[Token(Token = "0x403E468")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E469 RID: 255081
		[Token(Token = "0x403E469")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnClickBack;

		// Token: 0x0403E46A RID: 255082
		[Token(Token = "0x403E46A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
