using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004410 RID: 17424
	[Token(Token = "0x2004410")]
	public class SandboxV2RacingBattleFinishServiceConfig : FinishBattleServiceConfig<SandboxV2RacingBattleFinishRequest, SandboxV2RacingBattleFinishResponse>
	{
		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x0601A9D6 RID: 109014 RVA: 0x000A28B8 File Offset: 0x000A0AB8
		[Token(Token = "0x17003F05")]
		public override int overrideMaxRetryCount
		{
			[Token(Token = "0x601A9D6")]
			[Address(RVA = "0x13A8070", Offset = "0x13A6C70", VA = "0x1813A8070", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601A9D7 RID: 109015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9D7")]
		[Address(RVA = "0x13B0340", Offset = "0x13AEF40", VA = "0x1813B0340")]
		public SandboxV2RacingBattleFinishServiceConfig(string serviceCode, string topicId)
		{
		}

		// Token: 0x0601A9D8 RID: 109016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9D8")]
		[Address(RVA = "0x13B0200", Offset = "0x13AEE00", VA = "0x1813B0200", Slot = "9")]
		public override void OnParseRequest(SandboxV2RacingBattleFinishRequest request)
		{
		}

		// Token: 0x04021ED4 RID: 138964
		[Token(Token = "0x4021ED4")]
		private const int FINISH_BATTLE_SERVICE_MAX_RETRY_COUNT = 100;

		// Token: 0x04021ED5 RID: 138965
		[Token(Token = "0x4021ED5")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;
	}
}
