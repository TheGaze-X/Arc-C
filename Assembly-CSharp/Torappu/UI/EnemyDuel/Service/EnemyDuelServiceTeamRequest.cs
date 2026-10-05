using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200506F RID: 20591
	[Token(Token = "0x200506F")]
	public abstract class EnemyDuelServiceTeamRequest : EnemyDuelServiceRequest
	{
		// Token: 0x17004743 RID: 18243
		// (get) Token: 0x0601E850 RID: 125008 RVA: 0x000AEAB0 File Offset: 0x000ACCB0
		[Token(Token = "0x17004743")]
		public override EnemyDuelServiceRequestTarget target
		{
			[Token(Token = "0x601E850")]
			[Address(RVA = "0x1848500", Offset = "0x1847100", VA = "0x181848500", Slot = "6")]
			get
			{
				return EnemyDuelServiceRequestTarget.TEAM;
			}
		}

		// Token: 0x0601E851 RID: 125009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E851")]
		[Address(RVA = "0x1848460", Offset = "0x1847060", VA = "0x181848460")]
		protected EnemyDuelServiceTeamRequest()
		{
		}

		// Token: 0x04028DF7 RID: 167415
		[Token(Token = "0x4028DF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x04028DF8 RID: 167416
		[Token(Token = "0x4028DF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
