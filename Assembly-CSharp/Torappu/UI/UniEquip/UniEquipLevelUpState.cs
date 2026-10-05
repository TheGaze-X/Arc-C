using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C14 RID: 15380
	[Token(Token = "0x2003C14")]
	public class UniEquipLevelUpState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060180EC RID: 98540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60180EC")]
		[Address(RVA = "0x1088260", Offset = "0x1086E60", VA = "0x181088260", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060180ED RID: 98541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180ED")]
		[Address(RVA = "0x10882C0", Offset = "0x1086EC0", VA = "0x1810882C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060180EE RID: 98542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180EE")]
		[Address(RVA = "0x10884F0", Offset = "0x10870F0", VA = "0x1810884F0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060180EF RID: 98543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180EF")]
		[Address(RVA = "0x10883A0", Offset = "0x1086FA0", VA = "0x1810883A0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060180F0 RID: 98544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180F0")]
		[Address(RVA = "0x1087DF0", Offset = "0x10869F0", VA = "0x181087DF0")]
		public void EventOnConfirmClick()
		{
		}

		// Token: 0x060180F1 RID: 98545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180F1")]
		[Address(RVA = "0x1087D70", Offset = "0x1086970", VA = "0x181087D70")]
		public void EventOnCancelClick()
		{
		}

		// Token: 0x060180F2 RID: 98546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180F2")]
		[Address(RVA = "0x1088170", Offset = "0x1086D70", VA = "0x181088170")]
		public void EventOnRouteToTarget()
		{
		}

		// Token: 0x060180F3 RID: 98547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180F3")]
		[Address(RVA = "0x1088640", Offset = "0x1087240", VA = "0x181088640")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060180F4 RID: 98548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180F4")]
		[Address(RVA = "0x1088580", Offset = "0x1087180", VA = "0x181088580")]
		private void _EventOnSelectTargetLevel(int selectLevel)
		{
		}

		// Token: 0x060180F5 RID: 98549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180F5")]
		[Address(RVA = "0x10886E0", Offset = "0x10872E0", VA = "0x1810886E0")]
		public UniEquipLevelUpState()
		{
		}

		// Token: 0x060180F6 RID: 98550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180F6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060180F7 RID: 98551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180F7")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0401D2F4 RID: 119540
		[Token(Token = "0x401D2F4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UniEquipLevelUpView _levelUpView;

		// Token: 0x0401D2F5 RID: 119541
		[Token(Token = "0x401D2F5")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0401D2F6 RID: 119542
		[Token(Token = "0x401D2F6")]
		[FieldOffset(Offset = "0x80")]
		private UniEquipLevelUpStateBean m_stateBean;

		// Token: 0x0401D2F7 RID: 119543
		[Token(Token = "0x401D2F7")]
		[NonSerialized]
		public const int MSG_TARGET_LEVEL_CHANGE = 1;

		// Token: 0x0401D2F8 RID: 119544
		[Token(Token = "0x401D2F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D2F9 RID: 119545
		[Token(Token = "0x401D2F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D2FA RID: 119546
		[Token(Token = "0x401D2FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401D2FB RID: 119547
		[Token(Token = "0x401D2FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401D2FC RID: 119548
		[Token(Token = "0x401D2FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClick;

		// Token: 0x0401D2FD RID: 119549
		[Token(Token = "0x401D2FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnCancelClick;

		// Token: 0x0401D2FE RID: 119550
		[Token(Token = "0x401D2FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnRouteToTarget;

		// Token: 0x0401D2FF RID: 119551
		[Token(Token = "0x401D2FF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D300 RID: 119552
		[Token(Token = "0x401D300")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnSelectTargetLevel;

		// Token: 0x0401D301 RID: 119553
		[Token(Token = "0x401D301")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
