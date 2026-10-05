using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F73 RID: 20339
	[Token(Token = "0x2004F73")]
	public class EnemyDuelStartSingleBattleServiceConfig : StartBattleServiceConfig<EnemyDuelSingleBattleStartRequest, EnemyDuelSingleBattleStartResponse>
	{
		// Token: 0x0601E408 RID: 123912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E408")]
		[Address(RVA = "0x1807C60", Offset = "0x1806860", VA = "0x181807C60")]
		public EnemyDuelStartSingleBattleServiceConfig(string activityId, string modeId)
		{
		}

		// Token: 0x170046E4 RID: 18148
		// (get) Token: 0x0601E409 RID: 123913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046E4")]
		protected override string serviceCode
		{
			[Token(Token = "0x601E409")]
			[Address(RVA = "0x1807D10", Offset = "0x1806910", VA = "0x181807D10", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E40A RID: 123914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E40A")]
		[Address(RVA = "0x1807BB0", Offset = "0x18067B0", VA = "0x181807BB0", Slot = "5")]
		protected override EnemyDuelSingleBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x040285D2 RID: 165330
		[Token(Token = "0x40285D2")]
		[FieldOffset(Offset = "0x10")]
		private string m_activityId;

		// Token: 0x040285D3 RID: 165331
		[Token(Token = "0x40285D3")]
		[FieldOffset(Offset = "0x18")]
		private string m_modeId;

		// Token: 0x040285D4 RID: 165332
		[Token(Token = "0x40285D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040285D5 RID: 165333
		[Token(Token = "0x40285D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x040285D6 RID: 165334
		[Token(Token = "0x40285D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
