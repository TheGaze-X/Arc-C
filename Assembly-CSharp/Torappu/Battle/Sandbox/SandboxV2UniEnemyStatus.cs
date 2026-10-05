using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A74 RID: 10868
	[Token(Token = "0x2002A74")]
	[Serializable]
	public class SandboxV2UniEnemyStatus : IHotfixable
	{
		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x06012119 RID: 74009 RVA: 0x0006E9A0 File Offset: 0x0006CBA0
		// (set) Token: 0x06012118 RID: 74008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027A9")]
		[JsonIgnore]
		public float statusHpRatio
		{
			[Token(Token = "0x6012119")]
			[Address(RVA = "0xA344D0", Offset = "0xA330D0", VA = "0x180A344D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6012118")]
			[Address(RVA = "0xA34540", Offset = "0xA33140", VA = "0x180A34540")]
			set
			{
			}
		}

		// Token: 0x0601211A RID: 74010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601211A")]
		[Address(RVA = "0xA34470", Offset = "0xA33070", VA = "0x180A34470")]
		public SandboxV2UniEnemyStatus()
		{
		}

		// Token: 0x040146A1 RID: 83617
		[Token(Token = "0x40146A1")]
		[FieldOffset(Offset = "0x10")]
		public int hpRatio;

		// Token: 0x040146A2 RID: 83618
		[Token(Token = "0x40146A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_statusHpRatio;

		// Token: 0x040146A3 RID: 83619
		[Token(Token = "0x40146A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_statusHpRatio;

		// Token: 0x040146A4 RID: 83620
		[Token(Token = "0x40146A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
