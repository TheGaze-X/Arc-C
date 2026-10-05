using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006EA4 RID: 28324
	[Token(Token = "0x2006EA4")]
	public class VecBreakV2DefenseStartBattleConfig : StartBattleServiceConfig<VecBreakV2DefenseStartBattleRequest, VecBreakV2DefenseStartBattleResponse>
	{
		// Token: 0x17005F33 RID: 24371
		// (get) Token: 0x060284C8 RID: 165064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F33")]
		protected override string serviceCode
		{
			[Token(Token = "0x60284C8")]
			[Address(RVA = "0x23A67D0", Offset = "0x23A53D0", VA = "0x1823A67D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060284C9 RID: 165065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284C9")]
		[Address(RVA = "0x23A6700", Offset = "0x23A5300", VA = "0x1823A6700")]
		public VecBreakV2DefenseStartBattleConfig(string activityId, string stageId, CommonStartBattleRequest.SquadModel squadModel)
		{
		}

		// Token: 0x060284CA RID: 165066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284CA")]
		[Address(RVA = "0x23A6640", Offset = "0x23A5240", VA = "0x1823A6640", Slot = "5")]
		protected override VecBreakV2DefenseStartBattleRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x0403945D RID: 234589
		[Token(Token = "0x403945D")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0403945E RID: 234590
		[Token(Token = "0x403945E")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x0403945F RID: 234591
		[Token(Token = "0x403945F")]
		[FieldOffset(Offset = "0x20")]
		private CommonStartBattleRequest.SquadModel m_squadModel;

		// Token: 0x04039460 RID: 234592
		[Token(Token = "0x4039460")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x04039461 RID: 234593
		[Token(Token = "0x4039461")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04039462 RID: 234594
		[Token(Token = "0x4039462")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
