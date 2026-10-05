using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200440A RID: 17418
	[Token(Token = "0x200440A")]
	public class SandboxV2MonthStartBattleServiceConfig : StartBattleServiceConfig<SandboxV2MonthBattleStartRequest, SandboxV2MonthBattleStartResponse>
	{
		// Token: 0x0601A9C4 RID: 108996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9C4")]
		[Address(RVA = "0x13ABEE0", Offset = "0x13AAAE0", VA = "0x1813ABEE0")]
		public SandboxV2MonthStartBattleServiceConfig(string topicId, int squadIdx, string monthRushId)
		{
		}

		// Token: 0x0601A9C5 RID: 108997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9C5")]
		[Address(RVA = "0x13ABE20", Offset = "0x13AAA20", VA = "0x1813ABE20", Slot = "5")]
		protected override SandboxV2MonthBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x0601A9C6 RID: 108998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F03")]
		protected override string serviceCode
		{
			[Token(Token = "0x601A9C6")]
			[Address(RVA = "0x13ABFA0", Offset = "0x13AABA0", VA = "0x1813ABFA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x04021EC1 RID: 138945
		[Token(Token = "0x4021EC1")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x04021EC2 RID: 138946
		[Token(Token = "0x4021EC2")]
		[FieldOffset(Offset = "0x18")]
		private int m_squadIdx;

		// Token: 0x04021EC3 RID: 138947
		[Token(Token = "0x4021EC3")]
		[FieldOffset(Offset = "0x20")]
		private string m_monthRushId;

		// Token: 0x04021EC4 RID: 138948
		[Token(Token = "0x4021EC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04021EC5 RID: 138949
		[Token(Token = "0x4021EC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ParseRequest;

		// Token: 0x04021EC6 RID: 138950
		[Token(Token = "0x4021EC6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_serviceCode;
	}
}
