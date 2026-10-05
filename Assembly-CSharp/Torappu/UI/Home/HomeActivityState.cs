using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AFB RID: 19195
	[Token(Token = "0x2004AFB")]
	public class HomeActivityState : PopupFloatState, HomePage.INotResetToDefaultHomeState
	{
		// Token: 0x0601CD41 RID: 118081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD41")]
		[Address(RVA = "0x16379D0", Offset = "0x16365D0", VA = "0x1816379D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CD42 RID: 118082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD42")]
		[Address(RVA = "0x1638240", Offset = "0x1636E40", VA = "0x181638240")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CD43 RID: 118083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD43")]
		[Address(RVA = "0x1638390", Offset = "0x1636F90", VA = "0x181638390")]
		private void _TryDismissSelf()
		{
		}

		// Token: 0x0601CD44 RID: 118084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD44")]
		[Address(RVA = "0x1637A30", Offset = "0x1636630", VA = "0x181637A30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CD45 RID: 118085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD45")]
		[Address(RVA = "0x1638010", Offset = "0x1636C10", VA = "0x181638010", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601CD46 RID: 118086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD46")]
		[Address(RVA = "0x1637F30", Offset = "0x1636B30", VA = "0x181637F30", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601CD47 RID: 118087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD47")]
		[Address(RVA = "0x1638100", Offset = "0x1636D00", VA = "0x181638100", Slot = "31")]
		protected override IEnumerator WaitForLoading()
		{
			return null;
		}

		// Token: 0x0601CD48 RID: 118088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD48")]
		[Address(RVA = "0x1638190", Offset = "0x1636D90", VA = "0x181638190")]
		private IEnumerator _CloseWhenNotLoaded()
		{
			return null;
		}

		// Token: 0x0601CD49 RID: 118089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD49")]
		[Address(RVA = "0x1638490", Offset = "0x1637090", VA = "0x181638490")]
		public HomeActivityState()
		{
		}

		// Token: 0x0601CD4A RID: 118090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD4A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CD4B RID: 118091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD4B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601CD4C RID: 118092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD4C")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601CD4D RID: 118093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD4D")]
		[Address(RVA = "0x16380F0", Offset = "0x1636CF0", VA = "0x1816380F0")]
		private IEnumerator <>xLuaBaseProxy_WaitForLoading()
		{
			return null;
		}

		// Token: 0x04025D4F RID: 154959
		[Token(Token = "0x4025D4F")]
		private const int PRELOAD_FRAME_CNT = 3;

		// Token: 0x04025D50 RID: 154960
		[Token(Token = "0x4025D50")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HomeMainStateBean _stateBean;

		// Token: 0x04025D51 RID: 154961
		[Token(Token = "0x4025D51")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04025D52 RID: 154962
		[Token(Token = "0x4025D52")]
		[FieldOffset(Offset = "0x80")]
		private ActivityCommonEntry m_activityEntry;

		// Token: 0x04025D53 RID: 154963
		[Token(Token = "0x4025D53")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04025D54 RID: 154964
		[Token(Token = "0x4025D54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025D55 RID: 154965
		[Token(Token = "0x4025D55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025D56 RID: 154966
		[Token(Token = "0x4025D56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryDismissSelf;

		// Token: 0x04025D57 RID: 154967
		[Token(Token = "0x4025D57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025D58 RID: 154968
		[Token(Token = "0x4025D58")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025D59 RID: 154969
		[Token(Token = "0x4025D59")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04025D5A RID: 154970
		[Token(Token = "0x4025D5A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_WaitForLoading;

		// Token: 0x04025D5B RID: 154971
		[Token(Token = "0x4025D5B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CloseWhenNotLoaded;

		// Token: 0x04025D5C RID: 154972
		[Token(Token = "0x4025D5C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
