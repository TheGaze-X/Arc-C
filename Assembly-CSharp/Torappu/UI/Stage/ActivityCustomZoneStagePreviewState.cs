using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006879 RID: 26745
	[Token(Token = "0x2006879")]
	public class ActivityCustomZoneStagePreviewState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060264D9 RID: 156889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60264D9")]
		[Address(RVA = "0x215F210", Offset = "0x215DE10", VA = "0x18215F210", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060264DA RID: 156890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264DA")]
		[Address(RVA = "0x215F270", Offset = "0x215DE70", VA = "0x18215F270", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060264DB RID: 156891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264DB")]
		[Address(RVA = "0x215F340", Offset = "0x215DF40", VA = "0x18215F340", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x060264DC RID: 156892 RVA: 0x000CA9F8 File Offset: 0x000C8BF8
		[Token(Token = "0x60264DC")]
		[Address(RVA = "0x215F5B0", Offset = "0x215E1B0", VA = "0x18215F5B0")]
		private bool _TryLoadStagePreviewHolder(string prefabPath)
		{
			return default(bool);
		}

		// Token: 0x060264DD RID: 156893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264DD")]
		[Address(RVA = "0x215F4A0", Offset = "0x215E0A0", VA = "0x18215F4A0")]
		private void _ClearLoadedStagePreviewHolder()
		{
		}

		// Token: 0x060264DE RID: 156894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264DE")]
		[Address(RVA = "0x215F410", Offset = "0x215E010", VA = "0x18215F410", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060264DF RID: 156895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264DF")]
		[Address(RVA = "0x215F7F0", Offset = "0x215E3F0", VA = "0x18215F7F0")]
		public ActivityCustomZoneStagePreviewState()
		{
		}

		// Token: 0x060264E0 RID: 156896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264E0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060264E1 RID: 156897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264E1")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04035F59 RID: 221017
		[Token(Token = "0x4035F59")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _previewHolderContainer;

		// Token: 0x04035F5A RID: 221018
		[Token(Token = "0x4035F5A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActivityCustomZoneStateBean _stateBean;

		// Token: 0x04035F5B RID: 221019
		[Token(Token = "0x4035F5B")]
		[FieldOffset(Offset = "0x80")]
		private ActivityCustomZoneStagePreviewHolderBase m_previewHolder;

		// Token: 0x04035F5C RID: 221020
		[Token(Token = "0x4035F5C")]
		[FieldOffset(Offset = "0x88")]
		private string m_previewPathCache;

		// Token: 0x04035F5D RID: 221021
		[Token(Token = "0x4035F5D")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04035F5E RID: 221022
		[Token(Token = "0x4035F5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035F5F RID: 221023
		[Token(Token = "0x4035F5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035F60 RID: 221024
		[Token(Token = "0x4035F60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04035F61 RID: 221025
		[Token(Token = "0x4035F61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryLoadStagePreviewHolder;

		// Token: 0x04035F62 RID: 221026
		[Token(Token = "0x4035F62")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearLoadedStagePreviewHolder;

		// Token: 0x04035F63 RID: 221027
		[Token(Token = "0x4035F63")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04035F64 RID: 221028
		[Token(Token = "0x4035F64")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
