using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CEF RID: 23791
	[Token(Token = "0x2005CEF")]
	public class ClimbTowerPlanSelectState : PopupFloatState
	{
		// Token: 0x06022717 RID: 141079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022717")]
		[Address(RVA = "0x1CD4CB0", Offset = "0x1CD38B0", VA = "0x181CD4CB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022718 RID: 141080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022718")]
		[Address(RVA = "0x1CD4D10", Offset = "0x1CD3910", VA = "0x181CD4D10", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022719 RID: 141081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022719")]
		[Address(RVA = "0x1CD5740", Offset = "0x1CD4340", VA = "0x181CD5740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602271A RID: 141082 RVA: 0x000BD738 File Offset: 0x000BB938
		[Token(Token = "0x602271A")]
		[Address(RVA = "0x1CD56D0", Offset = "0x1CD42D0", VA = "0x181CD56D0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0602271B RID: 141083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602271B")]
		[Address(RVA = "0x1CD5170", Offset = "0x1CD3D70", VA = "0x181CD5170", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602271C RID: 141084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602271C")]
		[Address(RVA = "0x1CD52D0", Offset = "0x1CD3ED0", VA = "0x181CD52D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602271D RID: 141085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602271D")]
		[Address(RVA = "0x1CD5900", Offset = "0x1CD4500", VA = "0x181CD5900")]
		private void _OnPlanClick(bool isFree)
		{
		}

		// Token: 0x0602271E RID: 141086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602271E")]
		[Address(RVA = "0x1CD59E0", Offset = "0x1CD45E0", VA = "0x181CD59E0")]
		public ClimbTowerPlanSelectState()
		{
		}

		// Token: 0x06022721 RID: 141089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022721")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022722 RID: 141090 RVA: 0x000BD750 File Offset: 0x000BB950
		[Token(Token = "0x6022722")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06022723 RID: 141091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022723")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06022724 RID: 141092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022724")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402F581 RID: 193921
		[Token(Token = "0x402F581")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerPlanSelectView _view;

		// Token: 0x0402F582 RID: 193922
		[Token(Token = "0x402F582")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402F583 RID: 193923
		[Token(Token = "0x402F583")]
		[FieldOffset(Offset = "0x80")]
		private ClimbTowerPlanSelectStateBean m_stateBean;

		// Token: 0x0402F584 RID: 193924
		[Token(Token = "0x402F584")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402F585 RID: 193925
		[Token(Token = "0x402F585")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F586 RID: 193926
		[Token(Token = "0x402F586")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F587 RID: 193927
		[Token(Token = "0x402F587")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F588 RID: 193928
		[Token(Token = "0x402F588")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0402F589 RID: 193929
		[Token(Token = "0x402F589")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0402F58A RID: 193930
		[Token(Token = "0x402F58A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402F58B RID: 193931
		[Token(Token = "0x402F58B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPlanClick;

		// Token: 0x0402F58C RID: 193932
		[Token(Token = "0x402F58C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
