using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act5fun
{
	// Token: 0x020071D2 RID: 29138
	[Token(Token = "0x20071D2")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act5FunBattleStartConfig : StartBattleServiceConfig<Act5FunBattleStartRequst, Act5FunBattleStartResponse>
	{
		// Token: 0x170061E3 RID: 25059
		// (get) Token: 0x06029579 RID: 169337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061E3")]
		protected override string serviceCode
		{
			[Token(Token = "0x6029579")]
			[Address(RVA = "0x24AE4B0", Offset = "0x24AD0B0", VA = "0x1824AE4B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602957A RID: 169338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602957A")]
		[Address(RVA = "0x24AE420", Offset = "0x24AD020", VA = "0x1824AE420")]
		public Act5FunBattleStartConfig(string stageId)
		{
		}

		// Token: 0x0602957B RID: 169339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602957B")]
		[Address(RVA = "0x24AE380", Offset = "0x24ACF80", VA = "0x1824AE380", Slot = "5")]
		protected override Act5FunBattleStartRequst ParseRequest()
		{
			return null;
		}

		// Token: 0x0403B0B4 RID: 241844
		[Token(Token = "0x403B0B4")]
		[FieldOffset(Offset = "0x10")]
		private string m_stageId;

		// Token: 0x0403B0B5 RID: 241845
		[Token(Token = "0x403B0B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403B0B6 RID: 241846
		[Token(Token = "0x403B0B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403B0B7 RID: 241847
		[Token(Token = "0x403B0B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
