using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073ED RID: 29677
	[Token(Token = "0x20073ED")]
	public class Act3D0ClueState : PopupFloatState
	{
		// Token: 0x06029EB2 RID: 171698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029EB2")]
		[Address(RVA = "0x2587440", Offset = "0x2586040", VA = "0x182587440", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029EB3 RID: 171699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EB3")]
		[Address(RVA = "0x25874A0", Offset = "0x25860A0", VA = "0x1825874A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029EB4 RID: 171700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EB4")]
		[Address(RVA = "0x2587530", Offset = "0x2586130", VA = "0x182587530")]
		public Act3D0ClueState()
		{
		}

		// Token: 0x06029EB5 RID: 171701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EB5")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403C120 RID: 246048
		[Token(Token = "0x403C120")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act3D0ClueStateBean _stateBean;

		// Token: 0x0403C121 RID: 246049
		[Token(Token = "0x403C121")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act3D0ClueHolder _clueHolder;

		// Token: 0x0403C122 RID: 246050
		[Token(Token = "0x403C122")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403C123 RID: 246051
		[Token(Token = "0x403C123")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403C124 RID: 246052
		[Token(Token = "0x403C124")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
