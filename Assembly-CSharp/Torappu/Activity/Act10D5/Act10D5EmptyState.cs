using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B24 RID: 31524
	[Token(Token = "0x2007B24")]
	public class Act10D5EmptyState : State
	{
		// Token: 0x0602C222 RID: 180770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C222")]
		[Address(RVA = "0x28042A0", Offset = "0x2802EA0", VA = "0x1828042A0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602C223 RID: 180771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C223")]
		[Address(RVA = "0x28040B0", Offset = "0x2802CB0", VA = "0x1828040B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C224 RID: 180772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C224")]
		[Address(RVA = "0x2804110", Offset = "0x2802D10", VA = "0x182804110", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602C225 RID: 180773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C225")]
		[Address(RVA = "0x2804400", Offset = "0x2803000", VA = "0x182804400")]
		private void _DataToFavorState(IStateBean stateBean)
		{
		}

		// Token: 0x0602C226 RID: 180774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C226")]
		[Address(RVA = "0x28045E0", Offset = "0x28031E0", VA = "0x1828045E0")]
		public Act10D5EmptyState()
		{
		}

		// Token: 0x0602C227 RID: 180775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C227")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602C228 RID: 180776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C228")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403FFA4 RID: 262052
		[Token(Token = "0x403FFA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403FFA5 RID: 262053
		[Token(Token = "0x403FFA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FFA6 RID: 262054
		[Token(Token = "0x403FFA6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403FFA7 RID: 262055
		[Token(Token = "0x403FFA7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DataToFavorState;

		// Token: 0x0403FFA8 RID: 262056
		[Token(Token = "0x403FFA8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
