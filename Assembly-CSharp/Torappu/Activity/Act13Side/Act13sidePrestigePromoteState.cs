using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A08 RID: 31240
	[Token(Token = "0x2007A08")]
	public class Act13sidePrestigePromoteState : PopupFadeState
	{
		// Token: 0x0602BC9E RID: 179358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC9E")]
		[Address(RVA = "0x27BCE60", Offset = "0x27BBA60", VA = "0x1827BCE60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BC9F RID: 179359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC9F")]
		[Address(RVA = "0x27BCEC0", Offset = "0x27BBAC0", VA = "0x1827BCEC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BCA0 RID: 179360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCA0")]
		[Address(RVA = "0x27BD070", Offset = "0x27BBC70", VA = "0x1827BD070")]
		public Act13sidePrestigePromoteState()
		{
		}

		// Token: 0x0602BCA2 RID: 179362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCA2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403F5AD RID: 259501
		[Token(Token = "0x403F5AD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewParent;

		// Token: 0x0403F5AE RID: 259502
		[Token(Token = "0x403F5AE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act13sidePrestigePromoteView _viewPrefab;

		// Token: 0x0403F5AF RID: 259503
		[Token(Token = "0x403F5AF")]
		[FieldOffset(Offset = "0x80")]
		private Act13sidePrestigePromoteStateBean m_stateBean;

		// Token: 0x0403F5B0 RID: 259504
		[Token(Token = "0x403F5B0")]
		[FieldOffset(Offset = "0x88")]
		private Act13sidePrestigePromoteView _viewInstance;

		// Token: 0x0403F5B1 RID: 259505
		[Token(Token = "0x403F5B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F5B2 RID: 259506
		[Token(Token = "0x403F5B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F5B3 RID: 259507
		[Token(Token = "0x403F5B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
