using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act3fun
{
	// Token: 0x020073BB RID: 29627
	[Token(Token = "0x20073BB")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act3FunBattleStartConfig : StartBattleServiceConfig<Act3FunBattleStartRequst, Act3FunBattleStartResponse>
	{
		// Token: 0x170062D3 RID: 25299
		// (get) Token: 0x06029DC1 RID: 171457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062D3")]
		protected override string serviceCode
		{
			[Token(Token = "0x6029DC1")]
			[Address(RVA = "0x256E460", Offset = "0x256D060", VA = "0x18256E460", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029DC2 RID: 171458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DC2")]
		[Address(RVA = "0x256E3D0", Offset = "0x256CFD0", VA = "0x18256E3D0")]
		public Act3FunBattleStartConfig(string stageId)
		{
		}

		// Token: 0x06029DC3 RID: 171459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029DC3")]
		[Address(RVA = "0x256E330", Offset = "0x256CF30", VA = "0x18256E330", Slot = "5")]
		protected override Act3FunBattleStartRequst ParseRequest()
		{
			return null;
		}

		// Token: 0x0403BFD8 RID: 245720
		[Token(Token = "0x403BFD8")]
		[FieldOffset(Offset = "0x10")]
		private string m_stageId;

		// Token: 0x0403BFD9 RID: 245721
		[Token(Token = "0x403BFD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403BFDA RID: 245722
		[Token(Token = "0x403BFDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403BFDB RID: 245723
		[Token(Token = "0x403BFDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
