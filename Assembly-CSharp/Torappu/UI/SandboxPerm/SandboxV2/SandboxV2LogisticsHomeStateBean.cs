using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004345 RID: 17221
	[Token(Token = "0x2004345")]
	public class SandboxV2LogisticsHomeStateBean : IHotfixable
	{
		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x0601A71F RID: 108319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EBE")]
		public string topicId
		{
			[Token(Token = "0x601A71F")]
			[Address(RVA = "0x1387B50", Offset = "0x1386750", VA = "0x181387B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A720 RID: 108320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A720")]
		[Address(RVA = "0x1387810", Offset = "0x1386410", VA = "0x181387810")]
		public void LoadData(SandboxV2LogisticsPage.Param pageParam)
		{
		}

		// Token: 0x0601A721 RID: 108321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A721")]
		[Address(RVA = "0x1387A60", Offset = "0x1386660", VA = "0x181387A60")]
		public SandboxV2LogisticsHomeStateBean()
		{
		}

		// Token: 0x040219EB RID: 137707
		[Token(Token = "0x40219EB")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2LogisticsHomeProperty viewProperty;

		// Token: 0x040219EC RID: 137708
		[Token(Token = "0x40219EC")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;

		// Token: 0x040219ED RID: 137709
		[Token(Token = "0x40219ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040219EE RID: 137710
		[Token(Token = "0x40219EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040219EF RID: 137711
		[Token(Token = "0x40219EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
