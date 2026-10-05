using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074E3 RID: 29923
	[Token(Token = "0x20074E3")]
	public class RhineArcEntryState : State, IValueMsgReceiver
	{
		// Token: 0x0602A2E6 RID: 172774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A2E6")]
		[Address(RVA = "0x25D6990", Offset = "0x25D5590", VA = "0x1825D6990", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A2E7 RID: 172775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2E7")]
		[Address(RVA = "0x25D7030", Offset = "0x25D5C30", VA = "0x1825D7030", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A2E8 RID: 172776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2E8")]
		[Address(RVA = "0x25D7360", Offset = "0x25D5F60", VA = "0x1825D7360", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602A2E9 RID: 172777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2E9")]
		[Address(RVA = "0x25D7140", Offset = "0x25D5D40", VA = "0x1825D7140", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602A2EA RID: 172778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2EA")]
		[Address(RVA = "0x25D73D0", Offset = "0x25D5FD0", VA = "0x1825D73D0")]
		private void _ClickItem(Act25SideData.Act25SideArchiveItemType type, string itemId)
		{
		}

		// Token: 0x0602A2EB RID: 172779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2EB")]
		[Address(RVA = "0x25D7970", Offset = "0x25D6570", VA = "0x1825D7970")]
		private void _OnClickPicItemBtn(string itemId)
		{
		}

		// Token: 0x0602A2EC RID: 172780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2EC")]
		[Address(RVA = "0x25D7B30", Offset = "0x25D6730", VA = "0x1825D7B30")]
		private void _OnClickStoryItemBtn(string itemId)
		{
		}

		// Token: 0x0602A2ED RID: 172781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2ED")]
		[Address(RVA = "0x25D7880", Offset = "0x25D6480", VA = "0x1825D7880")]
		private void _OnClickKeyItem(string itemId, string toast)
		{
		}

		// Token: 0x0602A2EE RID: 172782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2EE")]
		[Address(RVA = "0x25D69F0", Offset = "0x25D55F0", VA = "0x1825D69F0")]
		public void OnClickPicArchive()
		{
		}

		// Token: 0x0602A2EF RID: 172783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2EF")]
		[Address(RVA = "0x25D6DF0", Offset = "0x25D59F0", VA = "0x1825D6DF0")]
		public void OnClickStoryArchive()
		{
		}

		// Token: 0x0602A2F0 RID: 172784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2F0")]
		[Address(RVA = "0x25D6C30", Offset = "0x25D5830", VA = "0x1825D6C30")]
		public void OnClickRhineBattlePerformance()
		{
		}

		// Token: 0x0602A2F1 RID: 172785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2F1")]
		[Address(RVA = "0x25D7CF0", Offset = "0x25D68F0", VA = "0x1825D7CF0")]
		public RhineArcEntryState()
		{
		}

		// Token: 0x0602A2F2 RID: 172786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2F2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602A2F3 RID: 172787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2F3")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403C9A9 RID: 248233
		[Token(Token = "0x403C9A9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RhineArcEntryStateBean _stateBean;

		// Token: 0x0403C9AA RID: 248234
		[Token(Token = "0x403C9AA")]
		[NonSerialized]
		public const int MSG_ITEM_CLICK = 1;

		// Token: 0x0403C9AB RID: 248235
		[Token(Token = "0x403C9AB")]
		[FieldOffset(Offset = "0x58")]
		private string m_actId;

		// Token: 0x0403C9AC RID: 248236
		[Token(Token = "0x403C9AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403C9AD RID: 248237
		[Token(Token = "0x403C9AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403C9AE RID: 248238
		[Token(Token = "0x403C9AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403C9AF RID: 248239
		[Token(Token = "0x403C9AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403C9B0 RID: 248240
		[Token(Token = "0x403C9B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClickItem;

		// Token: 0x0403C9B1 RID: 248241
		[Token(Token = "0x403C9B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnClickPicItemBtn;

		// Token: 0x0403C9B2 RID: 248242
		[Token(Token = "0x403C9B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnClickStoryItemBtn;

		// Token: 0x0403C9B3 RID: 248243
		[Token(Token = "0x403C9B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnClickKeyItem;

		// Token: 0x0403C9B4 RID: 248244
		[Token(Token = "0x403C9B4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClickPicArchive;

		// Token: 0x0403C9B5 RID: 248245
		[Token(Token = "0x403C9B5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClickStoryArchive;

		// Token: 0x0403C9B6 RID: 248246
		[Token(Token = "0x403C9B6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClickRhineBattlePerformance;

		// Token: 0x0403C9B7 RID: 248247
		[Token(Token = "0x403C9B7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
