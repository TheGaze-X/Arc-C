using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act4fun
{
	// Token: 0x02007207 RID: 29191
	[Token(Token = "0x2007207")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act4FunBattleStartConfig : StartBattleServiceConfig<Act4FunBattleStartRequst, Act4FunBattleStartResponse>
	{
		// Token: 0x17006208 RID: 25096
		// (get) Token: 0x06029641 RID: 169537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006208")]
		protected override string serviceCode
		{
			[Token(Token = "0x6029641")]
			[Address(RVA = "0x24C0680", Offset = "0x24BF280", VA = "0x1824C0680", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029642 RID: 169538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029642")]
		[Address(RVA = "0x24C05F0", Offset = "0x24BF1F0", VA = "0x1824C05F0")]
		public Act4FunBattleStartConfig(string stageId)
		{
		}

		// Token: 0x06029643 RID: 169539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029643")]
		[Address(RVA = "0x24C0550", Offset = "0x24BF150", VA = "0x1824C0550", Slot = "5")]
		protected override Act4FunBattleStartRequst ParseRequest()
		{
			return null;
		}

		// Token: 0x0403B1F5 RID: 242165
		[Token(Token = "0x403B1F5")]
		[FieldOffset(Offset = "0x10")]
		private string m_stageId;

		// Token: 0x0403B1F6 RID: 242166
		[Token(Token = "0x403B1F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403B1F7 RID: 242167
		[Token(Token = "0x403B1F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403B1F8 RID: 242168
		[Token(Token = "0x403B1F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
