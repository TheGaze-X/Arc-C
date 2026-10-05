using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004405 RID: 17413
	[Token(Token = "0x2004405")]
	public class SandboxV2RacingStartBattleServiceConfig : StartBattleServiceConfig<SandboxV2RacingBattleStartRequest, SandboxV2RacingBattleStartResponse>
	{
		// Token: 0x0601A9B9 RID: 108985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9B9")]
		[Address(RVA = "0x13B0470", Offset = "0x13AF070", VA = "0x1813B0470")]
		public SandboxV2RacingStartBattleServiceConfig(string topicId, string nodeId, string racerInstId)
		{
		}

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x0601A9BA RID: 108986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F02")]
		protected override string serviceCode
		{
			[Token(Token = "0x601A9BA")]
			[Address(RVA = "0x13B0540", Offset = "0x13AF140", VA = "0x1813B0540", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A9BB RID: 108987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9BB")]
		[Address(RVA = "0x13B03B0", Offset = "0x13AEFB0", VA = "0x1813B03B0", Slot = "5")]
		protected override SandboxV2RacingBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x04021EAF RID: 138927
		[Token(Token = "0x4021EAF")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x04021EB0 RID: 138928
		[Token(Token = "0x4021EB0")]
		[FieldOffset(Offset = "0x18")]
		private string m_nodeId;

		// Token: 0x04021EB1 RID: 138929
		[Token(Token = "0x4021EB1")]
		[FieldOffset(Offset = "0x20")]
		private string m_racerInstId;

		// Token: 0x04021EB2 RID: 138930
		[Token(Token = "0x4021EB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04021EB3 RID: 138931
		[Token(Token = "0x4021EB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x04021EB4 RID: 138932
		[Token(Token = "0x4021EB4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
