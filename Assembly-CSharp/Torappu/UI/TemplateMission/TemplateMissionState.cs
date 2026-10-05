using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DA6 RID: 15782
	[Token(Token = "0x2003DA6")]
	public class TemplateMissionState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060188A1 RID: 100513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60188A1")]
		[Address(RVA = "0x1115390", Offset = "0x1113F90", VA = "0x181115390", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060188A2 RID: 100514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188A2")]
		[Address(RVA = "0x11153F0", Offset = "0x1113FF0", VA = "0x1811153F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060188A3 RID: 100515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188A3")]
		[Address(RVA = "0x11156E0", Offset = "0x11142E0", VA = "0x1811156E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060188A4 RID: 100516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188A4")]
		[Address(RVA = "0x1115210", Offset = "0x1113E10", VA = "0x181115210")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x060188A5 RID: 100517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188A5")]
		[Address(RVA = "0x11155B0", Offset = "0x11141B0", VA = "0x1811155B0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060188A6 RID: 100518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188A6")]
		[Address(RVA = "0x1115910", Offset = "0x1114510", VA = "0x181115910")]
		private void _InitController(TemplateMissionInputParam inputParam)
		{
		}

		// Token: 0x060188A7 RID: 100519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60188A7")]
		[Address(RVA = "0x11157C0", Offset = "0x11143C0", VA = "0x1811157C0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060188A8 RID: 100520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188A8")]
		[Address(RVA = "0x1115B60", Offset = "0x1114760", VA = "0x181115B60")]
		public TemplateMissionState()
		{
		}

		// Token: 0x060188AA RID: 100522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188AA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060188AB RID: 100523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188AB")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060188AC RID: 100524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60188AC")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0401E160 RID: 123232
		[Token(Token = "0x401E160")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0401E161 RID: 123233
		[Token(Token = "0x401E161")]
		[FieldOffset(Offset = "0x78")]
		private TemplateMissionStateBean m_missionStateBean;

		// Token: 0x0401E162 RID: 123234
		[Token(Token = "0x401E162")]
		[FieldOffset(Offset = "0x80")]
		private AbstractTemplateMissionViewController m_missionController;

		// Token: 0x0401E163 RID: 123235
		[Token(Token = "0x401E163")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401E164 RID: 123236
		[Token(Token = "0x401E164")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401E165 RID: 123237
		[Token(Token = "0x401E165")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401E166 RID: 123238
		[Token(Token = "0x401E166")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0401E167 RID: 123239
		[Token(Token = "0x401E167")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401E168 RID: 123240
		[Token(Token = "0x401E168")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitController;

		// Token: 0x0401E169 RID: 123241
		[Token(Token = "0x401E169")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401E16A RID: 123242
		[Token(Token = "0x401E16A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
