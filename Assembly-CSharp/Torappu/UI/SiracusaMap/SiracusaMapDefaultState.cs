using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F70 RID: 16240
	[Token(Token = "0x2003F70")]
	public class SiracusaMapDefaultState : State
	{
		// Token: 0x0601933C RID: 103228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601933C")]
		[Address(RVA = "0x11EC890", Offset = "0x11EB490", VA = "0x1811EC890", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601933D RID: 103229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601933D")]
		[Address(RVA = "0x11EC8F0", Offset = "0x11EB4F0", VA = "0x1811EC8F0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601933E RID: 103230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601933E")]
		[Address(RVA = "0x11ECA50", Offset = "0x11EB650", VA = "0x1811ECA50")]
		private void _OnJumpToRewardDetailView(IStateBean stateBean)
		{
		}

		// Token: 0x0601933F RID: 103231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601933F")]
		[Address(RVA = "0x11ECC50", Offset = "0x11EB850", VA = "0x1811ECC50")]
		public SiracusaMapDefaultState()
		{
		}

		// Token: 0x06019340 RID: 103232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019340")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401F3F2 RID: 127986
		[Token(Token = "0x401F3F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F3F3 RID: 127987
		[Token(Token = "0x401F3F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401F3F4 RID: 127988
		[Token(Token = "0x401F3F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailView;

		// Token: 0x0401F3F5 RID: 127989
		[Token(Token = "0x401F3F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
