using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E21 RID: 20001
	[Token(Token = "0x2004E21")]
	public abstract class FireworkBaseState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601DE1D RID: 122397
		[Token(Token = "0x601DE1D")]
		public abstract void OnMessage(int key, ValueBundle msg);

		// Token: 0x0601DE1E RID: 122398 RVA: 0x000AC9E0 File Offset: 0x000AABE0
		[Token(Token = "0x601DE1E")]
		[Address(RVA = "0x1769620", Offset = "0x1768220", VA = "0x181769620")]
		protected bool OnPlateListItemClicked(FireworkPlateGroupModel plateGroupViewModel, string groupId)
		{
			return default(bool);
		}

		// Token: 0x0601DE1F RID: 122399 RVA: 0x000AC9F8 File Offset: 0x000AABF8
		[Token(Token = "0x601DE1F")]
		[Address(RVA = "0x1769800", Offset = "0x1768400", VA = "0x181769800")]
		protected bool OnPlateListSubItemClicked(FireworkPlateGroupModel plateGroupViewModel, FireworkData.PlateSlotData slotData)
		{
			return default(bool);
		}

		// Token: 0x0601DE20 RID: 122400 RVA: 0x000ACA10 File Offset: 0x000AAC10
		[Token(Token = "0x601DE20")]
		[Address(RVA = "0x1769540", Offset = "0x1768140", VA = "0x181769540")]
		protected bool OnPlateListFilledItemClicked(FireworkPlateGroupModel plateGroupViewModel, FireworkData.PlateSlotData slotData)
		{
			return default(bool);
		}

		// Token: 0x0601DE21 RID: 122401 RVA: 0x000ACA28 File Offset: 0x000AAC28
		[Token(Token = "0x601DE21")]
		[Address(RVA = "0x1769920", Offset = "0x1768520", VA = "0x181769920")]
		protected bool OnPnlSubListRaycastClicked(FireworkPlateGroupModel plateGroupViewModel)
		{
			return default(bool);
		}

		// Token: 0x0601DE22 RID: 122402 RVA: 0x000ACA40 File Offset: 0x000AAC40
		[Token(Token = "0x601DE22")]
		[Address(RVA = "0x1769390", Offset = "0x1767F90", VA = "0x181769390")]
		protected bool OnClearAllBtnClicked(FireworkPlateGroupModel plateGroupViewModel)
		{
			return default(bool);
		}

		// Token: 0x0601DE23 RID: 122403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE23")]
		[Address(RVA = "0x17699C0", Offset = "0x17685C0", VA = "0x1817699C0")]
		protected FireworkBaseState()
		{
		}

		// Token: 0x04027A00 RID: 162304
		[Token(Token = "0x4027A00")]
		[NonSerialized]
		public const int ON_PLATE_LIST_ITEM_CLICKED = 100;

		// Token: 0x04027A01 RID: 162305
		[Token(Token = "0x4027A01")]
		[NonSerialized]
		public const int ON_PLATE_SUB_LIST_ITEM_CLICKED = 101;

		// Token: 0x04027A02 RID: 162306
		[Token(Token = "0x4027A02")]
		[NonSerialized]
		public const int ON_PLATE_FILLED_LIST_ITEM_CLICKED = 102;

		// Token: 0x04027A03 RID: 162307
		[Token(Token = "0x4027A03")]
		[NonSerialized]
		public const int ON_PNL_SUB_LIST_RAYCAST_CLICKED = 103;

		// Token: 0x04027A04 RID: 162308
		[Token(Token = "0x4027A04")]
		[NonSerialized]
		public const int ON_CLEAR_ALL_BTN_CLICKED = 104;

		// Token: 0x04027A05 RID: 162309
		[Token(Token = "0x4027A05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlateListItemClicked;

		// Token: 0x04027A06 RID: 162310
		[Token(Token = "0x4027A06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlateListSubItemClicked;

		// Token: 0x04027A07 RID: 162311
		[Token(Token = "0x4027A07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlateListFilledItemClicked;

		// Token: 0x04027A08 RID: 162312
		[Token(Token = "0x4027A08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPnlSubListRaycastClicked;

		// Token: 0x04027A09 RID: 162313
		[Token(Token = "0x4027A09")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClearAllBtnClicked;

		// Token: 0x04027A0A RID: 162314
		[Token(Token = "0x4027A0A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
