using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AC6 RID: 15046
	[Token(Token = "0x2003AC6")]
	public class InfoPolyTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x06017BC5 RID: 97221 RVA: 0x00097D58 File Offset: 0x00095F58
		[Token(Token = "0x170038EE")]
		public bool isShow
		{
			[Token(Token = "0x6017BC5")]
			[Address(RVA = "0xFFB4E0", Offset = "0xFFA0E0", VA = "0x180FFB4E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06017BC6 RID: 97222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BC6")]
		[Address(RVA = "0xFFB2D0", Offset = "0xFF9ED0", VA = "0x180FFB2D0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06017BC7 RID: 97223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BC7")]
		[Address(RVA = "0xFFB430", Offset = "0xFFA030", VA = "0x180FFB430")]
		public InfoPolyTrackPoint()
		{
		}

		// Token: 0x0401CA73 RID: 117363
		[Token(Token = "0x401CA73")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, int> m_forceId2FavorDataListMap;

		// Token: 0x0401CA74 RID: 117364
		[Token(Token = "0x401CA74")]
		[FieldOffset(Offset = "0x18")]
		private bool m_availFlag;

		// Token: 0x0401CA75 RID: 117365
		[Token(Token = "0x401CA75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0401CA76 RID: 117366
		[Token(Token = "0x401CA76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0401CA77 RID: 117367
		[Token(Token = "0x401CA77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
