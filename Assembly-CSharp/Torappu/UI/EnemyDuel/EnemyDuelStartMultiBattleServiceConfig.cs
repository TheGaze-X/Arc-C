using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F70 RID: 20336
	[Token(Token = "0x2004F70")]
	public class EnemyDuelStartMultiBattleServiceConfig : StartBattleServiceConfig<EnemyDuelMultiBattleStartRequest, EnemyDuelMultiBattleStartResponse>
	{
		// Token: 0x0601E3FF RID: 123903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3FF")]
		[Address(RVA = "0x1807A90", Offset = "0x1806690", VA = "0x181807A90")]
		public EnemyDuelStartMultiBattleServiceConfig(string activityId, string sceneId)
		{
		}

		// Token: 0x170046E3 RID: 18147
		// (get) Token: 0x0601E400 RID: 123904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046E3")]
		protected override string serviceCode
		{
			[Token(Token = "0x601E400")]
			[Address(RVA = "0x1807B40", Offset = "0x1806740", VA = "0x181807B40", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E401 RID: 123905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E401")]
		[Address(RVA = "0x18079E0", Offset = "0x18065E0", VA = "0x1818079E0", Slot = "5")]
		protected override EnemyDuelMultiBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x040285CB RID: 165323
		[Token(Token = "0x40285CB")]
		[FieldOffset(Offset = "0x10")]
		private string m_activityId;

		// Token: 0x040285CC RID: 165324
		[Token(Token = "0x40285CC")]
		[FieldOffset(Offset = "0x18")]
		private string m_sceneId;

		// Token: 0x040285CD RID: 165325
		[Token(Token = "0x40285CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040285CE RID: 165326
		[Token(Token = "0x40285CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x040285CF RID: 165327
		[Token(Token = "0x40285CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
