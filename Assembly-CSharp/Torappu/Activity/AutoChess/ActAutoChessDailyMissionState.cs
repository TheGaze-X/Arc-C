using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070E6 RID: 28902
	[Token(Token = "0x20070E6")]
	public class ActAutoChessDailyMissionState : PopupFloatState, IHotfixable
	{
		// Token: 0x06029168 RID: 168296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029168")]
		[Address(RVA = "0x247D7C0", Offset = "0x247C3C0", VA = "0x18247D7C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029169 RID: 168297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029169")]
		[Address(RVA = "0x247D820", Offset = "0x247C420", VA = "0x18247D820", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602916A RID: 168298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602916A")]
		[Address(RVA = "0x247D960", Offset = "0x247C560", VA = "0x18247D960")]
		public ActAutoChessDailyMissionState()
		{
		}

		// Token: 0x0602916B RID: 168299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602916B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403AA2D RID: 240173
		[Token(Token = "0x403AA2D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActAutoChessDailyMissionView _view;

		// Token: 0x0403AA2E RID: 240174
		[Token(Token = "0x403AA2E")]
		[FieldOffset(Offset = "0x78")]
		private ActAutoChessDailyMissionStateBean m_stateBean;

		// Token: 0x0403AA2F RID: 240175
		[Token(Token = "0x403AA2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403AA30 RID: 240176
		[Token(Token = "0x403AA30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403AA31 RID: 240177
		[Token(Token = "0x403AA31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
