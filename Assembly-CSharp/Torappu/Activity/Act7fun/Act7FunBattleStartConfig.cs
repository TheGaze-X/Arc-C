using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act7fun
{
	// Token: 0x02007196 RID: 29078
	[Token(Token = "0x2007196")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act7FunBattleStartConfig : StartBattleServiceConfig<Act7FunBattleStartRequst, Act7FunBattleStartResponse>
	{
		// Token: 0x170061AF RID: 25007
		// (get) Token: 0x0602943A RID: 169018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061AF")]
		protected override string serviceCode
		{
			[Token(Token = "0x602943A")]
			[Address(RVA = "0x2491BD0", Offset = "0x24907D0", VA = "0x182491BD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602943B RID: 169019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602943B")]
		[Address(RVA = "0x2491B40", Offset = "0x2490740", VA = "0x182491B40")]
		public Act7FunBattleStartConfig(string stageId)
		{
		}

		// Token: 0x0602943C RID: 169020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602943C")]
		[Address(RVA = "0x2491AA0", Offset = "0x24906A0", VA = "0x182491AA0", Slot = "5")]
		protected override Act7FunBattleStartRequst ParseRequest()
		{
			return null;
		}

		// Token: 0x0403AEEE RID: 241390
		[Token(Token = "0x403AEEE")]
		[FieldOffset(Offset = "0x10")]
		private string m_stageId;

		// Token: 0x0403AEEF RID: 241391
		[Token(Token = "0x403AEEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403AEF0 RID: 241392
		[Token(Token = "0x403AEF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403AEF1 RID: 241393
		[Token(Token = "0x403AEF1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
