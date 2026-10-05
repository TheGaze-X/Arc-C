using System;
using Il2CppDummyDll;
using Torappu;
using UnityEngine;
using XLua;

// Token: 0x02000077 RID: 119
[Token(Token = "0x2000077")]
public class XDAccountSetting : MonoBehaviour, IHotfixable
{
	// Token: 0x060001CB RID: 459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x515600", Offset = "0x514200", VA = "0x180515600")]
	public void EventOnPlayerUserCenter()
	{
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x515140", Offset = "0x513D40", VA = "0x180515140")]
	public void EventOnPlayerHelpCenter()
	{
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x515390", Offset = "0x513F90", VA = "0x180515390")]
	public void EventOnPlayerQuit()
	{
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x515850", Offset = "0x514450", VA = "0x180515850")]
	public XDAccountSetting()
	{
	}

	// Token: 0x040001E6 RID: 486
	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x18")]
	private Action m_userCenter;

	// Token: 0x040001E7 RID: 487
	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x20")]
	private Action m_helpCenter;

	// Token: 0x040001E8 RID: 488
	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x28")]
	private Action m_loginOut;

	// Token: 0x040001E9 RID: 489
	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x0")]
	private static DelegateBridge __Hotfix0_EventOnPlayerUserCenter;

	// Token: 0x040001EA RID: 490
	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x8")]
	private static DelegateBridge __Hotfix0_EventOnPlayerHelpCenter;

	// Token: 0x040001EB RID: 491
	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x10")]
	private static DelegateBridge __Hotfix0_EventOnPlayerQuit;

	// Token: 0x040001EC RID: 492
	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x18")]
	private static DelegateBridge _c__Hotfix0_ctor;
}
