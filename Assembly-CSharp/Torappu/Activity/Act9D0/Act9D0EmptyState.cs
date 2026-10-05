using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007156 RID: 29014
	[Token(Token = "0x2007156")]
	public class Act9D0EmptyState : State
	{
		// Token: 0x06029318 RID: 168728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029318")]
		[Address(RVA = "0x2492C40", Offset = "0x2491840", VA = "0x182492C40", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029319 RID: 168729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029319")]
		[Address(RVA = "0x2492A00", Offset = "0x2491600", VA = "0x182492A00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602931A RID: 168730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602931A")]
		[Address(RVA = "0x2492A60", Offset = "0x2491660", VA = "0x182492A60", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602931B RID: 168731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602931B")]
		[Address(RVA = "0x2493030", Offset = "0x2491C30", VA = "0x182493030")]
		public Act9D0EmptyState()
		{
		}

		// Token: 0x0602931C RID: 168732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602931C")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602931D RID: 168733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602931D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403AD1A RID: 240922
		[Token(Token = "0x403AD1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403AD1B RID: 240923
		[Token(Token = "0x403AD1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403AD1C RID: 240924
		[Token(Token = "0x403AD1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403AD1D RID: 240925
		[Token(Token = "0x403AD1D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
