using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E6C RID: 28268
	[Token(Token = "0x2006E6C")]
	public class ActVecBreakV2SquadBuffSelectPage : StateEnginePage
	{
		// Token: 0x17005F05 RID: 24325
		// (get) Token: 0x0602839F RID: 164767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F05")]
		public string actId
		{
			[Token(Token = "0x602839F")]
			[Address(RVA = "0x2382F40", Offset = "0x2381B40", VA = "0x182382F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060283A0 RID: 164768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283A0")]
		[Address(RVA = "0x2382E20", Offset = "0x2381A20", VA = "0x182382E20", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060283A1 RID: 164769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283A1")]
		[Address(RVA = "0x2382EE0", Offset = "0x2381AE0", VA = "0x182382EE0")]
		public ActVecBreakV2SquadBuffSelectPage()
		{
		}

		// Token: 0x060283A2 RID: 164770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283A2")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x040392BA RID: 234170
		[Token(Token = "0x40392BA")]
		[FieldOffset(Offset = "0xF0")]
		private ActVecBreakV2SquadBuffSelectPage.Param m_cacheParam;

		// Token: 0x040392BB RID: 234171
		[Token(Token = "0x40392BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x040392BC RID: 234172
		[Token(Token = "0x40392BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040392BD RID: 234173
		[Token(Token = "0x40392BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E6D RID: 28269
		[Token(Token = "0x2006E6D")]
		public class Param
		{
			// Token: 0x060283A3 RID: 164771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60283A3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040392BE RID: 234174
			[Token(Token = "0x40392BE")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
