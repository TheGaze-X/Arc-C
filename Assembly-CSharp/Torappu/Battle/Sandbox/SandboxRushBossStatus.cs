using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A75 RID: 10869
	[Token(Token = "0x2002A75")]
	[Serializable]
	public class SandboxRushBossStatus : IHotfixable
	{
		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x0601211C RID: 74012 RVA: 0x0006E9B8 File Offset: 0x0006CBB8
		// (set) Token: 0x0601211B RID: 74011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027AA")]
		[JsonIgnore]
		public float statusHpRatio
		{
			[Token(Token = "0x601211C")]
			[Address(RVA = "0xA34290", Offset = "0xA32E90", VA = "0x180A34290")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601211B")]
			[Address(RVA = "0xA34300", Offset = "0xA32F00", VA = "0x180A34300")]
			set
			{
			}
		}

		// Token: 0x0601211D RID: 74013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601211D")]
		[Address(RVA = "0xA34230", Offset = "0xA32E30", VA = "0x180A34230")]
		public SandboxRushBossStatus()
		{
		}

		// Token: 0x040146A5 RID: 83621
		[Token(Token = "0x40146A5")]
		[FieldOffset(Offset = "0x10")]
		public int modeIndex;

		// Token: 0x040146A6 RID: 83622
		[Token(Token = "0x40146A6")]
		[FieldOffset(Offset = "0x14")]
		public int hpRatio;

		// Token: 0x040146A7 RID: 83623
		[Token(Token = "0x40146A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_statusHpRatio;

		// Token: 0x040146A8 RID: 83624
		[Token(Token = "0x40146A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_statusHpRatio;

		// Token: 0x040146A9 RID: 83625
		[Token(Token = "0x40146A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
