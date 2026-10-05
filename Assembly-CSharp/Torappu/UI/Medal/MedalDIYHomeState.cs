using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004920 RID: 18720
	[Token(Token = "0x2004920")]
	public class MedalDIYHomeState : State
	{
		// Token: 0x0601C390 RID: 115600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C390")]
		[Address(RVA = "0x15AE030", Offset = "0x15ACC30", VA = "0x1815AE030", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C391 RID: 115601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C391")]
		[Address(RVA = "0x15AF050", Offset = "0x15ADC50", VA = "0x1815AF050")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C392 RID: 115602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C392")]
		[Address(RVA = "0x15AE090", Offset = "0x15ACC90", VA = "0x1815AE090", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C393 RID: 115603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C393")]
		[Address(RVA = "0x15AE490", Offset = "0x15AD090", VA = "0x1815AE490", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C394 RID: 115604 RVA: 0x000A7958 File Offset: 0x000A5B58
		[Token(Token = "0x601C394")]
		[Address(RVA = "0x15AE9F0", Offset = "0x15AD5F0", VA = "0x1815AE9F0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0601C395 RID: 115605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C395")]
		[Address(RVA = "0x15AE330", Offset = "0x15ACF30", VA = "0x1815AE330", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601C396 RID: 115606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C396")]
		[Address(RVA = "0x15ADBE0", Offset = "0x15AC7E0", VA = "0x1815ADBE0")]
		public void EventOnResetClicked()
		{
		}

		// Token: 0x0601C397 RID: 115607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C397")]
		[Address(RVA = "0x15AD820", Offset = "0x15AC420", VA = "0x1815AD820")]
		public void EventOnAddClicked()
		{
		}

		// Token: 0x0601C398 RID: 115608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C398")]
		[Address(RVA = "0x15ADFD0", Offset = "0x15ACBD0", VA = "0x1815ADFD0")]
		public void EventOnSaveClicked()
		{
		}

		// Token: 0x0601C399 RID: 115609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C399")]
		[Address(RVA = "0x15ADB40", Offset = "0x15AC740", VA = "0x1815ADB40")]
		public void EventOnPreviewClicked()
		{
		}

		// Token: 0x0601C39A RID: 115610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C39A")]
		[Address(RVA = "0x15AD8C0", Offset = "0x15AC4C0", VA = "0x1815AD8C0")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601C39B RID: 115611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C39B")]
		[Address(RVA = "0x15AF290", Offset = "0x15ADE90", VA = "0x1815AF290")]
		private void _OnRouteToPreview(MedalDIYPreviewBean stateBean)
		{
		}

		// Token: 0x0601C39C RID: 115612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C39C")]
		[Address(RVA = "0x15AF370", Offset = "0x15ADF70", VA = "0x1815AF370")]
		private void _OnRouteToSelectState(MedalListStateBean listBean)
		{
		}

		// Token: 0x0601C39D RID: 115613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C39D")]
		[Address(RVA = "0x15AF170", Offset = "0x15ADD70", VA = "0x1815AF170")]
		private void _OnBackFromSelectState(MedalListStateBean listBean)
		{
		}

		// Token: 0x0601C39E RID: 115614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C39E")]
		[Address(RVA = "0x15AF600", Offset = "0x15AE200", VA = "0x1815AF600")]
		private void _ResetAllTokens()
		{
		}

		// Token: 0x0601C39F RID: 115615 RVA: 0x000A7970 File Offset: 0x000A5B70
		[Token(Token = "0x601C39F")]
		[Address(RVA = "0x15AEBE0", Offset = "0x15AD7E0", VA = "0x1815AEBE0")]
		private bool _CheckIfToStayToSave(Action actionExit)
		{
			return default(bool);
		}

		// Token: 0x0601C3A0 RID: 115616 RVA: 0x000A7988 File Offset: 0x000A5B88
		[Token(Token = "0x601C3A0")]
		[Address(RVA = "0x15AEA60", Offset = "0x15AD660", VA = "0x1815AEA60")]
		private bool _CheckIfEditingTokenDirty()
		{
			return default(bool);
		}

		// Token: 0x0601C3A1 RID: 115617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3A1")]
		[Address(RVA = "0x15AF7C0", Offset = "0x15AE3C0", VA = "0x1815AF7C0")]
		private void _SendSaveCustomDataRequest()
		{
		}

		// Token: 0x0601C3A2 RID: 115618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C3A2")]
		[Address(RVA = "0x15AED80", Offset = "0x15AD980", VA = "0x1815AED80")]
		private MedalSetCustomDataRequest _CreateSetCustomDataRequest()
		{
			return null;
		}

		// Token: 0x0601C3A3 RID: 115619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3A3")]
		[Address(RVA = "0x15AFA80", Offset = "0x15AE680", VA = "0x1815AFA80")]
		public MedalDIYHomeState()
		{
		}

		// Token: 0x0601C3A7 RID: 115623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3A7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C3A8 RID: 115624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C3A8")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C3A9 RID: 115625 RVA: 0x000A79A0 File Offset: 0x000A5BA0
		[Token(Token = "0x601C3A9")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0601C3AA RID: 115626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C3AA")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04024E9B RID: 151195
		[Token(Token = "0x4024E9B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIMedalDIYManager _manager;

		// Token: 0x04024E9C RID: 151196
		[Token(Token = "0x4024E9C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _btnBack;

		// Token: 0x04024E9D RID: 151197
		[Token(Token = "0x4024E9D")]
		[FieldOffset(Offset = "0x60")]
		private MedalDIYHomeBean m_stateBean;

		// Token: 0x04024E9E RID: 151198
		[Token(Token = "0x4024E9E")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x04024E9F RID: 151199
		[Token(Token = "0x4024E9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024EA0 RID: 151200
		[Token(Token = "0x4024EA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024EA1 RID: 151201
		[Token(Token = "0x4024EA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024EA2 RID: 151202
		[Token(Token = "0x4024EA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04024EA3 RID: 151203
		[Token(Token = "0x4024EA3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04024EA4 RID: 151204
		[Token(Token = "0x4024EA4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04024EA5 RID: 151205
		[Token(Token = "0x4024EA5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnResetClicked;

		// Token: 0x04024EA6 RID: 151206
		[Token(Token = "0x4024EA6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnAddClicked;

		// Token: 0x04024EA7 RID: 151207
		[Token(Token = "0x4024EA7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnSaveClicked;

		// Token: 0x04024EA8 RID: 151208
		[Token(Token = "0x4024EA8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnPreviewClicked;

		// Token: 0x04024EA9 RID: 151209
		[Token(Token = "0x4024EA9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04024EAA RID: 151210
		[Token(Token = "0x4024EAA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnRouteToPreview;

		// Token: 0x04024EAB RID: 151211
		[Token(Token = "0x4024EAB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnRouteToSelectState;

		// Token: 0x04024EAC RID: 151212
		[Token(Token = "0x4024EAC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnBackFromSelectState;

		// Token: 0x04024EAD RID: 151213
		[Token(Token = "0x4024EAD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ResetAllTokens;

		// Token: 0x04024EAE RID: 151214
		[Token(Token = "0x4024EAE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckIfToStayToSave;

		// Token: 0x04024EAF RID: 151215
		[Token(Token = "0x4024EAF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CheckIfEditingTokenDirty;

		// Token: 0x04024EB0 RID: 151216
		[Token(Token = "0x4024EB0")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SendSaveCustomDataRequest;

		// Token: 0x04024EB1 RID: 151217
		[Token(Token = "0x4024EB1")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CreateSetCustomDataRequest;

		// Token: 0x04024EB2 RID: 151218
		[Token(Token = "0x4024EB2")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
