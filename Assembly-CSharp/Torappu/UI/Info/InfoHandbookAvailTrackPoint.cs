using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Info
{
	// Token: 0x02004A4D RID: 19021
	[Token(Token = "0x2004A4D")]
	public class InfoHandbookAvailTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004378 RID: 17272
		// (get) Token: 0x0601C982 RID: 117122 RVA: 0x000A8B70 File Offset: 0x000A6D70
		[Token(Token = "0x17004378")]
		public bool isShow
		{
			[Token(Token = "0x601C982")]
			[Address(RVA = "0x1612AD0", Offset = "0x16116D0", VA = "0x181612AD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601C983 RID: 117123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C983")]
		[Address(RVA = "0x1612A00", Offset = "0x1611600", VA = "0x181612A00", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601C984 RID: 117124 RVA: 0x000A8B88 File Offset: 0x000A6D88
		[Token(Token = "0x601C984")]
		[Address(RVA = "0x1612560", Offset = "0x1611160", VA = "0x181612560")]
		public static bool GetAvailState()
		{
			return default(bool);
		}

		// Token: 0x0601C985 RID: 117125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C985")]
		[Address(RVA = "0x1612A70", Offset = "0x1611670", VA = "0x181612A70")]
		public InfoHandbookAvailTrackPoint()
		{
		}

		// Token: 0x040258B6 RID: 153782
		[Token(Token = "0x40258B6")]
		[FieldOffset(Offset = "0x10")]
		private bool m_availFlag;

		// Token: 0x040258B7 RID: 153783
		[Token(Token = "0x40258B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040258B8 RID: 153784
		[Token(Token = "0x40258B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040258B9 RID: 153785
		[Token(Token = "0x40258B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAvailState;

		// Token: 0x040258BA RID: 153786
		[Token(Token = "0x40258BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
