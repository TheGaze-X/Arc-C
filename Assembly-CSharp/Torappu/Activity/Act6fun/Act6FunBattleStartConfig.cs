using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071AE RID: 29102
	[Token(Token = "0x20071AE")]
	public class Act6FunBattleStartConfig : StartBattleServiceConfig<Act6FunBattleStartRequest, Act6FunBattleStartResponse>
	{
		// Token: 0x170061C1 RID: 25025
		// (get) Token: 0x060294CC RID: 169164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061C1")]
		protected override string serviceCode
		{
			[Token(Token = "0x60294CC")]
			[Address(RVA = "0x24AE6A0", Offset = "0x24AD2A0", VA = "0x1824AE6A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060294CD RID: 169165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294CD")]
		[Address(RVA = "0x24AE610", Offset = "0x24AD210", VA = "0x1824AE610")]
		public Act6FunBattleStartConfig(string stageId)
		{
		}

		// Token: 0x060294CE RID: 169166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60294CE")]
		[Address(RVA = "0x24AE570", Offset = "0x24AD170", VA = "0x1824AE570", Slot = "5")]
		protected override Act6FunBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x0403AF9A RID: 241562
		[Token(Token = "0x403AF9A")]
		[FieldOffset(Offset = "0x10")]
		private string m_stageId;

		// Token: 0x0403AF9B RID: 241563
		[Token(Token = "0x403AF9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403AF9C RID: 241564
		[Token(Token = "0x403AF9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403AF9D RID: 241565
		[Token(Token = "0x403AF9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
