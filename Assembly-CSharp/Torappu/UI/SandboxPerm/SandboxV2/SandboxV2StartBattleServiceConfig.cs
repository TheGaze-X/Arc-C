using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004402 RID: 17410
	[Token(Token = "0x2004402")]
	public class SandboxV2StartBattleServiceConfig : StartBattleServiceConfig<SandboxV2BattleStartRequest, SandboxV2BattleStartResponse>
	{
		// Token: 0x0601A9B0 RID: 108976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9B0")]
		[Address(RVA = "0x13BAD80", Offset = "0x13B9980", VA = "0x1813BAD80")]
		public SandboxV2StartBattleServiceConfig(string topicId, string nodeId, int squadIdx)
		{
		}

		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x0601A9B1 RID: 108977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F01")]
		protected override string serviceCode
		{
			[Token(Token = "0x601A9B1")]
			[Address(RVA = "0x13BAE40", Offset = "0x13B9A40", VA = "0x1813BAE40", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A9B2 RID: 108978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9B2")]
		[Address(RVA = "0x13BACC0", Offset = "0x13B98C0", VA = "0x1813BACC0", Slot = "5")]
		protected override SandboxV2BattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x04021EA1 RID: 138913
		[Token(Token = "0x4021EA1")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x04021EA2 RID: 138914
		[Token(Token = "0x4021EA2")]
		[FieldOffset(Offset = "0x18")]
		private string m_nodeId;

		// Token: 0x04021EA3 RID: 138915
		[Token(Token = "0x4021EA3")]
		[FieldOffset(Offset = "0x20")]
		private int m_squadIdx;

		// Token: 0x04021EA4 RID: 138916
		[Token(Token = "0x4021EA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04021EA5 RID: 138917
		[Token(Token = "0x4021EA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x04021EA6 RID: 138918
		[Token(Token = "0x4021EA6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
