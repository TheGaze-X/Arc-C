using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AF9 RID: 19193
	[Token(Token = "0x2004AF9")]
	public class HomeActivityAvgState : State
	{
		// Token: 0x0601CD32 RID: 118066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD32")]
		[Address(RVA = "0x1637440", Offset = "0x1636040", VA = "0x181637440", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CD33 RID: 118067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD33")]
		[Address(RVA = "0x16374A0", Offset = "0x16360A0", VA = "0x1816374A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CD34 RID: 118068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD34")]
		[Address(RVA = "0x16376E0", Offset = "0x16362E0", VA = "0x1816376E0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601CD35 RID: 118069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD35")]
		[Address(RVA = "0x1637790", Offset = "0x1636390", VA = "0x181637790")]
		private void _OnStoryEnd(Story story)
		{
		}

		// Token: 0x0601CD36 RID: 118070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD36")]
		[Address(RVA = "0x16378C0", Offset = "0x16364C0", VA = "0x1816378C0")]
		private IEnumerator _TryDissmissSelf()
		{
			return null;
		}

		// Token: 0x0601CD37 RID: 118071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD37")]
		[Address(RVA = "0x1637970", Offset = "0x1636570", VA = "0x181637970")]
		public HomeActivityAvgState()
		{
		}

		// Token: 0x0601CD39 RID: 118073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD39")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CD3A RID: 118074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD3A")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04025D44 RID: 154948
		[Token(Token = "0x4025D44")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HomeMainStateBean _stateBean;

		// Token: 0x04025D45 RID: 154949
		[Token(Token = "0x4025D45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025D46 RID: 154950
		[Token(Token = "0x4025D46")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025D47 RID: 154951
		[Token(Token = "0x4025D47")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04025D48 RID: 154952
		[Token(Token = "0x4025D48")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnStoryEnd;

		// Token: 0x04025D49 RID: 154953
		[Token(Token = "0x4025D49")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryDissmissSelf;

		// Token: 0x04025D4A RID: 154954
		[Token(Token = "0x4025D4A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
