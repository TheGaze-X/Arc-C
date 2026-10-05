using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005ED8 RID: 24280
	[Token(Token = "0x2005ED8")]
	public class CharacterInfoProfessionDetailState : PopupFloatState
	{
		// Token: 0x060232C5 RID: 144069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60232C5")]
		[Address(RVA = "0x1DAEC20", Offset = "0x1DAD820", VA = "0x181DAEC20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060232C6 RID: 144070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232C6")]
		[Address(RVA = "0x1DAEC80", Offset = "0x1DAD880", VA = "0x181DAEC80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060232C7 RID: 144071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232C7")]
		[Address(RVA = "0x1DAEDF0", Offset = "0x1DAD9F0", VA = "0x181DAEDF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060232C8 RID: 144072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232C8")]
		[Address(RVA = "0x1DAEF10", Offset = "0x1DADB10", VA = "0x181DAEF10")]
		public CharacterInfoProfessionDetailState()
		{
		}

		// Token: 0x060232C9 RID: 144073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232C9")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403078E RID: 198542
		[Token(Token = "0x403078E")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0403078F RID: 198543
		[Token(Token = "0x403078F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030790 RID: 198544
		[Token(Token = "0x4030790")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030791 RID: 198545
		[Token(Token = "0x4030791")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030792 RID: 198546
		[Token(Token = "0x4030792")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
