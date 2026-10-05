using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052C4 RID: 21188
	[Token(Token = "0x20052C4")]
	public class RoguelikeEndingState : UIPopupState
	{
		// Token: 0x0601F3F7 RID: 127991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3F7")]
		[Address(RVA = "0x18F8C70", Offset = "0x18F7870", VA = "0x1818F8C70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F3F8 RID: 127992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3F8")]
		[Address(RVA = "0x18F8F60", Offset = "0x18F7B60", VA = "0x1818F8F60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F3F9 RID: 127993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3F9")]
		[Address(RVA = "0x18F9520", Offset = "0x18F8120", VA = "0x1818F9520", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601F3FA RID: 127994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3FA")]
		[Address(RVA = "0x18F9640", Offset = "0x18F8240", VA = "0x1818F9640", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601F3FB RID: 127995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3FB")]
		[Address(RVA = "0x18F8F00", Offset = "0x18F7B00", VA = "0x1818F8F00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601F3FC RID: 127996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3FC")]
		[Address(RVA = "0x18F9A30", Offset = "0x18F8630", VA = "0x1818F9A30")]
		private void _LoadControllerIfNot(string topicId)
		{
		}

		// Token: 0x0601F3FD RID: 127997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3FD")]
		[Address(RVA = "0x18F9760", Offset = "0x18F8360", VA = "0x1818F9760", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601F3FE RID: 127998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3FE")]
		[Address(RVA = "0x18F8CD0", Offset = "0x18F78D0", VA = "0x1818F8CD0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601F3FF RID: 127999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3FF")]
		[Address(RVA = "0x18F98A0", Offset = "0x18F84A0", VA = "0x1818F98A0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601F400 RID: 128000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F400")]
		[Address(RVA = "0x18F8E10", Offset = "0x18F7A10", VA = "0x1818F8E10", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601F401 RID: 128001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F401")]
		[Address(RVA = "0x18F9BA0", Offset = "0x18F87A0", VA = "0x1818F9BA0")]
		private void _TriggerBGMSignal()
		{
		}

		// Token: 0x0601F402 RID: 128002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F402")]
		[Address(RVA = "0x18F9990", Offset = "0x18F8590", VA = "0x1818F9990")]
		private void _ClearBGM()
		{
		}

		// Token: 0x0601F403 RID: 128003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F403")]
		[Address(RVA = "0x18F9D50", Offset = "0x18F8950", VA = "0x1818F9D50")]
		public RoguelikeEndingState()
		{
		}

		// Token: 0x0601F404 RID: 128004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F404")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601F405 RID: 128005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F405")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601F406 RID: 128006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F406")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04029F8A RID: 171914
		[Token(Token = "0x4029F8A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04029F8B RID: 171915
		[Token(Token = "0x4029F8B")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeEndingControllerBase m_controller;

		// Token: 0x04029F8C RID: 171916
		[Token(Token = "0x4029F8C")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeEndingStateBean m_stateBean;

		// Token: 0x04029F8D RID: 171917
		[Token(Token = "0x4029F8D")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeMenuAdapter m_menuAdapter;

		// Token: 0x04029F8E RID: 171918
		[Token(Token = "0x4029F8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04029F8F RID: 171919
		[Token(Token = "0x4029F8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04029F90 RID: 171920
		[Token(Token = "0x4029F90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04029F91 RID: 171921
		[Token(Token = "0x4029F91")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04029F92 RID: 171922
		[Token(Token = "0x4029F92")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04029F93 RID: 171923
		[Token(Token = "0x4029F93")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadControllerIfNot;

		// Token: 0x04029F94 RID: 171924
		[Token(Token = "0x4029F94")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04029F95 RID: 171925
		[Token(Token = "0x4029F95")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04029F96 RID: 171926
		[Token(Token = "0x4029F96")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04029F97 RID: 171927
		[Token(Token = "0x4029F97")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04029F98 RID: 171928
		[Token(Token = "0x4029F98")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TriggerBGMSignal;

		// Token: 0x04029F99 RID: 171929
		[Token(Token = "0x4029F99")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x04029F9A RID: 171930
		[Token(Token = "0x4029F9A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
