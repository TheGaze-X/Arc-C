using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007504 RID: 29956
	[Token(Token = "0x2007504")]
	public class RhineBattlePerformanceState : State
	{
		// Token: 0x0602A3A4 RID: 172964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A3A4")]
		[Address(RVA = "0x25EEC80", Offset = "0x25ED880", VA = "0x1825EEC80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A3A5 RID: 172965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3A5")]
		[Address(RVA = "0x25EEF00", Offset = "0x25EDB00", VA = "0x1825EEF00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A3A6 RID: 172966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3A6")]
		[Address(RVA = "0x25EF450", Offset = "0x25EE050", VA = "0x1825EF450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A3A7 RID: 172967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3A7")]
		[Address(RVA = "0x25EF300", Offset = "0x25EDF00", VA = "0x1825EF300")]
		private void _ConsumeLocalTrack(string groupId)
		{
		}

		// Token: 0x0602A3A8 RID: 172968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3A8")]
		[Address(RVA = "0x25EECE0", Offset = "0x25ED8E0", VA = "0x1825EECE0")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x0602A3A9 RID: 172969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3A9")]
		[Address(RVA = "0x25EF560", Offset = "0x25EE160", VA = "0x1825EF560")]
		public RhineBattlePerformanceState()
		{
		}

		// Token: 0x0602A3AA RID: 172970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3AA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403CADC RID: 248540
		[Token(Token = "0x403CADC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RhineBattlePerformanceView _view;

		// Token: 0x0403CADD RID: 248541
		[Token(Token = "0x403CADD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0403CADE RID: 248542
		[Token(Token = "0x403CADE")]
		[FieldOffset(Offset = "0x60")]
		private RhineBattlePerformanceStateBean m_stateBean;

		// Token: 0x0403CADF RID: 248543
		[Token(Token = "0x403CADF")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0403CAE0 RID: 248544
		[Token(Token = "0x403CAE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CAE1 RID: 248545
		[Token(Token = "0x403CAE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CAE2 RID: 248546
		[Token(Token = "0x403CAE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CAE3 RID: 248547
		[Token(Token = "0x403CAE3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ConsumeLocalTrack;

		// Token: 0x0403CAE4 RID: 248548
		[Token(Token = "0x403CAE4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x0403CAE5 RID: 248549
		[Token(Token = "0x403CAE5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
