using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ED9 RID: 28377
	[Token(Token = "0x2006ED9")]
	public class ActMultiV3StartBattleServiceConfig : StartBattleServiceConfig<ActMultiV3BattleStartRequest, ActMultiV3BattleStartResponse>
	{
		// Token: 0x0602855B RID: 165211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602855B")]
		[Address(RVA = "0x238D780", Offset = "0x238C380", VA = "0x18238D780")]
		public ActMultiV3StartBattleServiceConfig(string actId, string sceneId)
		{
		}

		// Token: 0x17005F46 RID: 24390
		// (get) Token: 0x0602855C RID: 165212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F46")]
		protected override string serviceCode
		{
			[Token(Token = "0x602855C")]
			[Address(RVA = "0x238D830", Offset = "0x238C430", VA = "0x18238D830", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602855D RID: 165213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602855D")]
		[Address(RVA = "0x238D6D0", Offset = "0x238C2D0", VA = "0x18238D6D0", Slot = "5")]
		protected override ActMultiV3BattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x04039551 RID: 234833
		[Token(Token = "0x4039551")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x04039552 RID: 234834
		[Token(Token = "0x4039552")]
		[FieldOffset(Offset = "0x18")]
		private string m_sceneId;

		// Token: 0x04039553 RID: 234835
		[Token(Token = "0x4039553")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04039554 RID: 234836
		[Token(Token = "0x4039554")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x04039555 RID: 234837
		[Token(Token = "0x4039555")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
