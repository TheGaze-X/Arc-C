using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004415 RID: 17429
	[Token(Token = "0x2004415")]
	public class SandboxV2MonthBattleFinishServiceConfig : FinishBattleServiceConfig<SandboxV2BattleFinishRequest, SandboxV2MonthBattleFinishResponse>
	{
		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x0601A9E1 RID: 109025 RVA: 0x000A28D0 File Offset: 0x000A0AD0
		[Token(Token = "0x17003F06")]
		public override int overrideMaxRetryCount
		{
			[Token(Token = "0x601A9E1")]
			[Address(RVA = "0x13A8070", Offset = "0x13A6C70", VA = "0x1813A8070", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601A9E2 RID: 109026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9E2")]
		[Address(RVA = "0x13ABDB0", Offset = "0x13AA9B0", VA = "0x1813ABDB0")]
		public SandboxV2MonthBattleFinishServiceConfig(string serviceCode, string topicId)
		{
		}

		// Token: 0x0601A9E3 RID: 109027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9E3")]
		[Address(RVA = "0x13ABD00", Offset = "0x13AA900", VA = "0x1813ABD00", Slot = "9")]
		public override void OnParseRequest(SandboxV2BattleFinishRequest request)
		{
		}

		// Token: 0x04021EE5 RID: 138981
		[Token(Token = "0x4021EE5")]
		private const int FINISH_BATTLE_SERVICE_MAX_RETRY_COUNT = 100;

		// Token: 0x04021EE6 RID: 138982
		[Token(Token = "0x4021EE6")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;
	}
}
