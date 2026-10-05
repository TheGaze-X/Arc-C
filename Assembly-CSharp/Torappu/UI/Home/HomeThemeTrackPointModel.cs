using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B95 RID: 19349
	[Token(Token = "0x2004B95")]
	public class HomeThemeTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700447D RID: 17533
		// (get) Token: 0x0601D1C1 RID: 119233 RVA: 0x000AA820 File Offset: 0x000A8A20
		[Token(Token = "0x1700447D")]
		public bool isShow
		{
			[Token(Token = "0x601D1C1")]
			[Address(RVA = "0x16AA590", Offset = "0x16A9190", VA = "0x1816AA590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D1C2 RID: 119234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1C2")]
		[Address(RVA = "0x16AA4C0", Offset = "0x16A90C0", VA = "0x1816AA4C0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D1C3 RID: 119235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1C3")]
		[Address(RVA = "0x16AA530", Offset = "0x16A9130", VA = "0x1816AA530")]
		public HomeThemeTrackPointModel()
		{
		}

		// Token: 0x0402633F RID: 156479
		[Token(Token = "0x402633F")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04026340 RID: 156480
		[Token(Token = "0x4026340")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026341 RID: 156481
		[Token(Token = "0x4026341")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026342 RID: 156482
		[Token(Token = "0x4026342")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
