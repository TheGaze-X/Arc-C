using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200440D RID: 17421
	[Token(Token = "0x200440D")]
	public class SandboxV2BattleFinishServiceConfig : FinishBattleServiceConfig<SandboxV2BattleFinishRequest, SandboxV2BattleFinishResponse>
	{
		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x0601A9CD RID: 109005 RVA: 0x000A28A0 File Offset: 0x000A0AA0
		[Token(Token = "0x17003F04")]
		public override int overrideMaxRetryCount
		{
			[Token(Token = "0x601A9CD")]
			[Address(RVA = "0x13A8070", Offset = "0x13A6C70", VA = "0x1813A8070", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601A9CE RID: 109006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9CE")]
		[Address(RVA = "0x13A8000", Offset = "0x13A6C00", VA = "0x1813A8000")]
		public SandboxV2BattleFinishServiceConfig(string serviceCode, string topicId)
		{
		}

		// Token: 0x0601A9CF RID: 109007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9CF")]
		[Address(RVA = "0x13A7F50", Offset = "0x13A6B50", VA = "0x1813A7F50", Slot = "9")]
		public override void OnParseRequest(SandboxV2BattleFinishRequest request)
		{
		}

		// Token: 0x04021ECB RID: 138955
		[Token(Token = "0x4021ECB")]
		private const int FINISH_BATTLE_SERVICE_MAX_RETRY_COUNT = 100;

		// Token: 0x04021ECC RID: 138956
		[Token(Token = "0x4021ECC")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;
	}
}
