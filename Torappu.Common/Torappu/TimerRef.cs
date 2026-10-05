using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public class TimerRef : AutoReleasableGroup.ICustom, IHotfixable
	{
		// Token: 0x06000220 RID: 544 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x54F6200", Offset = "0x54F4E00", VA = "0x1854F6200")]
		public void TrackTimer(int newTimer, AutoReleasableGroup autoRelease)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000308C File Offset: 0x0000128C
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x54F6020", Offset = "0x54F4C20", VA = "0x1854F6020", Slot = "4")]
		public bool CheckActive()
		{
			return default(bool);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x54F6170", Offset = "0x54F4D70", VA = "0x1854F6170", Slot = "5")]
		public void Release()
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x54F62D0", Offset = "0x54F4ED0", VA = "0x1854F62D0")]
		public TimerRef()
		{
		}

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x10")]
		private int m_timerId;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate51 __Hotfix0_TrackTimer;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_CheckActive;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Release;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
