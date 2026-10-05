using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200495D RID: 18781
	[Token(Token = "0x200495D")]
	public class MedalEntryState : State
	{
		// Token: 0x0601C4E8 RID: 115944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C4E8")]
		[Address(RVA = "0x15CA2C0", Offset = "0x15C8EC0", VA = "0x1815CA2C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C4E9 RID: 115945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4E9")]
		[Address(RVA = "0x15CA590", Offset = "0x15C9190", VA = "0x1815CA590", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C4EA RID: 115946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4EA")]
		[Address(RVA = "0x15CA880", Offset = "0x15C9480", VA = "0x1815CA880", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601C4EB RID: 115947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4EB")]
		[Address(RVA = "0x15CA3B0", Offset = "0x15C8FB0", VA = "0x1815CA3B0")]
		public void OnClickList()
		{
		}

		// Token: 0x0601C4EC RID: 115948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4EC")]
		[Address(RVA = "0x15CA320", Offset = "0x15C8F20", VA = "0x1815CA320")]
		public void OnClickGroup()
		{
		}

		// Token: 0x0601C4ED RID: 115949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4ED")]
		[Address(RVA = "0x15CA470", Offset = "0x15C9070", VA = "0x1815CA470")]
		public void OnClickSelect()
		{
		}

		// Token: 0x0601C4EE RID: 115950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4EE")]
		[Address(RVA = "0x15CA500", Offset = "0x15C9100", VA = "0x1815CA500")]
		public void OnDIYClicked()
		{
		}

		// Token: 0x0601C4EF RID: 115951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4EF")]
		[Address(RVA = "0x15CAB80", Offset = "0x15C9780", VA = "0x1815CAB80")]
		private void _LoadDIYMedalGroup()
		{
		}

		// Token: 0x0601C4F0 RID: 115952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4F0")]
		[Address(RVA = "0x15CA960", Offset = "0x15C9560", VA = "0x1815CA960")]
		private void _LoadActMedalGroup()
		{
		}

		// Token: 0x0601C4F1 RID: 115953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4F1")]
		[Address(RVA = "0x15CAF00", Offset = "0x15C9B00", VA = "0x1815CAF00")]
		public MedalEntryState()
		{
		}

		// Token: 0x0601C4F2 RID: 115954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4F2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C4F3 RID: 115955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4F3")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04025067 RID: 151655
		[Token(Token = "0x4025067")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MedalEntryListBtn _listBtn;

		// Token: 0x04025068 RID: 151656
		[Token(Token = "0x4025068")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _diyContainer;

		// Token: 0x04025069 RID: 151657
		[Token(Token = "0x4025069")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _groupContainer;

		// Token: 0x0402506A RID: 151658
		[Token(Token = "0x402506A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MedalListStateBean _stateBean;

		// Token: 0x0402506B RID: 151659
		[Token(Token = "0x402506B")]
		[FieldOffset(Offset = "0x70")]
		private UIMedalGroupView m_diyMedalGroup;

		// Token: 0x0402506C RID: 151660
		[Token(Token = "0x402506C")]
		[FieldOffset(Offset = "0x78")]
		private UIMedalGroupView m_actMedalGroup;

		// Token: 0x0402506D RID: 151661
		[Token(Token = "0x402506D")]
		[FieldOffset(Offset = "0x80")]
		private bool _initIfNot;

		// Token: 0x0402506E RID: 151662
		[Token(Token = "0x402506E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402506F RID: 151663
		[Token(Token = "0x402506F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025070 RID: 151664
		[Token(Token = "0x4025070")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025071 RID: 151665
		[Token(Token = "0x4025071")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickList;

		// Token: 0x04025072 RID: 151666
		[Token(Token = "0x4025072")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickGroup;

		// Token: 0x04025073 RID: 151667
		[Token(Token = "0x4025073")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickSelect;

		// Token: 0x04025074 RID: 151668
		[Token(Token = "0x4025074")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDIYClicked;

		// Token: 0x04025075 RID: 151669
		[Token(Token = "0x4025075")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadDIYMedalGroup;

		// Token: 0x04025076 RID: 151670
		[Token(Token = "0x4025076")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadActMedalGroup;

		// Token: 0x04025077 RID: 151671
		[Token(Token = "0x4025077")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
