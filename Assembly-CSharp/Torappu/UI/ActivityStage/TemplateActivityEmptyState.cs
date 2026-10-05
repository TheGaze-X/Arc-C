using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C98 RID: 27800
	[Token(Token = "0x2006C98")]
	public class TemplateActivityEmptyState : State
	{
		// Token: 0x06027A89 RID: 162441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027A89")]
		[Address(RVA = "0x22DBCF0", Offset = "0x22DA8F0", VA = "0x1822DBCF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027A8A RID: 162442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027A8A")]
		[Address(RVA = "0x22DC020", Offset = "0x22DAC20", VA = "0x1822DC020", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06027A8B RID: 162443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A8B")]
		[Address(RVA = "0x22DBD50", Offset = "0x22DA950", VA = "0x1822DBD50", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06027A8C RID: 162444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A8C")]
		[Address(RVA = "0x22DC1F0", Offset = "0x22DADF0", VA = "0x1822DC1F0")]
		private void _RegisterToMedalState(IStateBean stateBean)
		{
		}

		// Token: 0x06027A8D RID: 162445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A8D")]
		[Address(RVA = "0x22DC3A0", Offset = "0x22DAFA0", VA = "0x1822DC3A0")]
		private void _RegisterToTemplateMissionState(IStateBean stateBean)
		{
		}

		// Token: 0x06027A8E RID: 162446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A8E")]
		[Address(RVA = "0x22DC550", Offset = "0x22DB150", VA = "0x1822DC550")]
		public TemplateActivityEmptyState()
		{
		}

		// Token: 0x06027A8F RID: 162447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027A8F")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06027A90 RID: 162448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A90")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04038413 RID: 230419
		[Token(Token = "0x4038413")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038414 RID: 230420
		[Token(Token = "0x4038414")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04038415 RID: 230421
		[Token(Token = "0x4038415")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04038416 RID: 230422
		[Token(Token = "0x4038416")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterToMedalState;

		// Token: 0x04038417 RID: 230423
		[Token(Token = "0x4038417")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterToTemplateMissionState;

		// Token: 0x04038418 RID: 230424
		[Token(Token = "0x4038418")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
