using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071EB RID: 29163
	[Token(Token = "0x20071EB")]
	public class Act5D0MileStoneState : MileStoneState
	{
		// Token: 0x060295E9 RID: 169449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295E9")]
		[Address(RVA = "0x24AA130", Offset = "0x24A8D30", VA = "0x1824AA130", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060295EA RID: 169450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295EA")]
		[Address(RVA = "0x24A9F60", Offset = "0x24A8B60", VA = "0x1824A9F60")]
		private void InitTopMenu()
		{
		}

		// Token: 0x060295EB RID: 169451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60295EB")]
		[Address(RVA = "0x24A9EF0", Offset = "0x24A8AF0", VA = "0x1824A9EF0", Slot = "31")]
		protected override string GetMileStoneServiceCode()
		{
			return null;
		}

		// Token: 0x060295EC RID: 169452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295EC")]
		[Address(RVA = "0x24AA340", Offset = "0x24A8F40", VA = "0x1824AA340")]
		public void ToActivityMission()
		{
		}

		// Token: 0x060295ED RID: 169453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295ED")]
		[Address(RVA = "0x24AA3E0", Offset = "0x24A8FE0", VA = "0x1824AA3E0")]
		public Act5D0MileStoneState()
		{
		}

		// Token: 0x060295EF RID: 169455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295EF")]
		[Address(RVA = "0x24AA3D0", Offset = "0x24A8FD0", VA = "0x1824AA3D0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403B147 RID: 241991
		[Token(Token = "0x403B147")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _topMenuContainer;

		// Token: 0x0403B148 RID: 241992
		[Token(Token = "0x403B148")]
		[FieldOffset(Offset = "0x88")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403B149 RID: 241993
		[Token(Token = "0x403B149")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B14A RID: 241994
		[Token(Token = "0x403B14A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitTopMenu;

		// Token: 0x0403B14B RID: 241995
		[Token(Token = "0x403B14B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMileStoneServiceCode;

		// Token: 0x0403B14C RID: 241996
		[Token(Token = "0x403B14C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ToActivityMission;

		// Token: 0x0403B14D RID: 241997
		[Token(Token = "0x403B14D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
