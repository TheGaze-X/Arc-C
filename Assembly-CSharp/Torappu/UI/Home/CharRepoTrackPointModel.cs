using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B92 RID: 19346
	[Token(Token = "0x2004B92")]
	public class CharRepoTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700447A RID: 17530
		// (get) Token: 0x0601D1B8 RID: 119224 RVA: 0x000AA7D8 File Offset: 0x000A89D8
		[Token(Token = "0x1700447A")]
		public bool isShow
		{
			[Token(Token = "0x601D1B8")]
			[Address(RVA = "0x1699860", Offset = "0x1698460", VA = "0x181699860", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D1B9 RID: 119225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1B9")]
		[Address(RVA = "0x1699620", Offset = "0x1698220", VA = "0x181699620", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D1BA RID: 119226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1BA")]
		[Address(RVA = "0x1699800", Offset = "0x1698400", VA = "0x181699800")]
		public CharRepoTrackPointModel()
		{
		}

		// Token: 0x04026333 RID: 156467
		[Token(Token = "0x4026333")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasTrackPoint;

		// Token: 0x04026334 RID: 156468
		[Token(Token = "0x4026334")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026335 RID: 156469
		[Token(Token = "0x4026335")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026336 RID: 156470
		[Token(Token = "0x4026336")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
