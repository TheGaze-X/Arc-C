using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E8D RID: 7821
	[Token(Token = "0x2001E8D")]
	public class AVGCgItemPanel : ExecutorComponent, IContainsResRefs
	{
		// Token: 0x0600C1B3 RID: 49587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1B3")]
		[Address(RVA = "0x33EC860", Offset = "0x33EB460", VA = "0x1833EC860", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C1B4 RID: 49588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B4")]
		[Address(RVA = "0x33EC9F0", Offset = "0x33EB5F0", VA = "0x1833EC9F0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C1B5 RID: 49589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B5")]
		[Address(RVA = "0x33EC800", Offset = "0x33EB400", VA = "0x1833EC800", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C1B6 RID: 49590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1B6")]
		[Address(RVA = "0x33EC770", Offset = "0x33EB370", VA = "0x1833EC770", Slot = "13")]
		public AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C1B7 RID: 49591 RVA: 0x00047220 File Offset: 0x00045420
		[Token(Token = "0x600C1B7")]
		[Address(RVA = "0x33ED670", Offset = "0x33EC270", VA = "0x1833ED670")]
		private AVGCgItemPanel.SlotParam _GenSlotParam(Command command)
		{
			return default(AVGCgItemPanel.SlotParam);
		}

		// Token: 0x0600C1B8 RID: 49592 RVA: 0x00047238 File Offset: 0x00045438
		[Token(Token = "0x600C1B8")]
		[Address(RVA = "0x33ED430", Offset = "0x33EC030", VA = "0x1833ED430")]
		private bool _ExecuteShowCgItem(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C1B9 RID: 49593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B9")]
		[Address(RVA = "0x33ECB90", Offset = "0x33EB790", VA = "0x1833ECB90")]
		private void _BindSlotPostDisplayItem(string key, AVGCgItemPanel.SlotInUseItem item)
		{
		}

		// Token: 0x0600C1BA RID: 49594 RVA: 0x00047250 File Offset: 0x00045450
		[Token(Token = "0x600C1BA")]
		[Address(RVA = "0x33ED170", Offset = "0x33EBD70", VA = "0x1833ED170")]
		private bool _ExecuteHideCgItem(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C1BB RID: 49595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1BB")]
		[Address(RVA = "0x33ECFB0", Offset = "0x33EBBB0", VA = "0x1833ECFB0")]
		private void _ClearItemByKey(Command command, string key)
		{
		}

		// Token: 0x0600C1BC RID: 49596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1BC")]
		[Address(RVA = "0x33ECD30", Offset = "0x33EB930", VA = "0x1833ECD30")]
		private void _ClearAllItems(Command command)
		{
		}

		// Token: 0x0600C1BD RID: 49597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1BD")]
		[Address(RVA = "0x33EDCF0", Offset = "0x33EC8F0", VA = "0x1833EDCF0")]
		private void _ShowItem(Command command)
		{
		}

		// Token: 0x0600C1BE RID: 49598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1BE")]
		[Address(RVA = "0x33ED890", Offset = "0x33EC490", VA = "0x1833ED890")]
		private AVGCgItemPanel.SlotInUseItem _GetItemFromDict(string key)
		{
			return null;
		}

		// Token: 0x0600C1BF RID: 49599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1BF")]
		[Address(RVA = "0x33ECA60", Offset = "0x33EB660", VA = "0x1833ECA60")]
		private void _AddItemToDict(string key, AVGCgItemPanel.SlotInUseItem item)
		{
		}

		// Token: 0x0600C1C0 RID: 49600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C0")]
		[Address(RVA = "0x33EDA80", Offset = "0x33EC680", VA = "0x1833EDA80")]
		private void _RemoveItemFromDict(string key)
		{
		}

		// Token: 0x0600C1C1 RID: 49601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1C1")]
		[Address(RVA = "0x33ED510", Offset = "0x33EC110", VA = "0x1833ED510")]
		private AVGCgItemPanel.SlotStyle _FindSlotStyle(string style)
		{
			return null;
		}

		// Token: 0x0600C1C2 RID: 49602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1C2")]
		[Address(RVA = "0x33ED9D0", Offset = "0x33EC5D0", VA = "0x1833ED9D0")]
		private Sprite _LoadSprite(string key)
		{
			return null;
		}

		// Token: 0x0600C1C3 RID: 49603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C3")]
		[Address(RVA = "0x33EDB20", Offset = "0x33EC720", VA = "0x1833EDB20")]
		private void _Reset()
		{
		}

		// Token: 0x0600C1C4 RID: 49604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C4")]
		[Address(RVA = "0x33EE4B0", Offset = "0x33ED0B0", VA = "0x1833EE4B0")]
		public AVGCgItemPanel()
		{
		}

		// Token: 0x0600C1C5 RID: 49605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C5")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C33C RID: 49980
		[Token(Token = "0x400C33C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGCgItemPanel.SlotStyle[] _slotStyles;

		// Token: 0x0400C33D RID: 49981
		[Token(Token = "0x400C33D")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, AVGCgItemPanel.SlotInUseItem> m_slotsInUseDict;

		// Token: 0x0400C33E RID: 49982
		[Token(Token = "0x400C33E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C33F RID: 49983
		[Token(Token = "0x400C33F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C340 RID: 49984
		[Token(Token = "0x400C340")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C341 RID: 49985
		[Token(Token = "0x400C341")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C342 RID: 49986
		[Token(Token = "0x400C342")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenSlotParam;

		// Token: 0x0400C343 RID: 49987
		[Token(Token = "0x400C343")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteShowCgItem;

		// Token: 0x0400C344 RID: 49988
		[Token(Token = "0x400C344")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BindSlotPostDisplayItem;

		// Token: 0x0400C345 RID: 49989
		[Token(Token = "0x400C345")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecuteHideCgItem;

		// Token: 0x0400C346 RID: 49990
		[Token(Token = "0x400C346")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearItemByKey;

		// Token: 0x0400C347 RID: 49991
		[Token(Token = "0x400C347")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearAllItems;

		// Token: 0x0400C348 RID: 49992
		[Token(Token = "0x400C348")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowItem;

		// Token: 0x0400C349 RID: 49993
		[Token(Token = "0x400C349")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetItemFromDict;

		// Token: 0x0400C34A RID: 49994
		[Token(Token = "0x400C34A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__AddItemToDict;

		// Token: 0x0400C34B RID: 49995
		[Token(Token = "0x400C34B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RemoveItemFromDict;

		// Token: 0x0400C34C RID: 49996
		[Token(Token = "0x400C34C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__FindSlotStyle;

		// Token: 0x0400C34D RID: 49997
		[Token(Token = "0x400C34D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x0400C34E RID: 49998
		[Token(Token = "0x400C34E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x0400C34F RID: 49999
		[Token(Token = "0x400C34F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E8E RID: 7822
		[Token(Token = "0x2001E8E")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C1C6 RID: 49606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C1C6")]
			[Address(RVA = "0x3404B60", Offset = "0x3403760", VA = "0x183404B60", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C1C7 RID: 49607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C1C7")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public InternalResRefCollector()
			{
			}
		}

		// Token: 0x02001E8F RID: 7823
		[Token(Token = "0x2001E8F")]
		private class SlotInUseItem : IDisposable
		{
			// Token: 0x0600C1C8 RID: 49608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C1C8")]
			[Address(RVA = "0x3404F00", Offset = "0x3403B00", VA = "0x183404F00", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0600C1C9 RID: 49609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C1C9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SlotInUseItem()
			{
			}

			// Token: 0x0400C350 RID: 50000
			[Token(Token = "0x400C350")]
			[FieldOffset(Offset = "0x10")]
			public AVGShowItemSlot slot;

			// Token: 0x0400C351 RID: 50001
			[Token(Token = "0x400C351")]
			[FieldOffset(Offset = "0x18")]
			public PostDisplayHandler postDisplayHandler;
		}

		// Token: 0x02001E90 RID: 7824
		[Token(Token = "0x2001E90")]
		[Serializable]
		private class SlotStyle
		{
			// Token: 0x0600C1CA RID: 49610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C1CA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SlotStyle()
			{
			}

			// Token: 0x0400C352 RID: 50002
			[Token(Token = "0x400C352")]
			[FieldOffset(Offset = "0x10")]
			public string styleKey;

			// Token: 0x0400C353 RID: 50003
			[Token(Token = "0x400C353")]
			[FieldOffset(Offset = "0x18")]
			public UnityEngine.Object slotPrefab;
		}

		// Token: 0x02001E91 RID: 7825
		[Token(Token = "0x2001E91")]
		private struct SlotParam
		{
			// Token: 0x0400C354 RID: 50004
			[Token(Token = "0x400C354")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x0400C355 RID: 50005
			[Token(Token = "0x400C355")]
			[FieldOffset(Offset = "0x8")]
			public string image;

			// Token: 0x0400C356 RID: 50006
			[Token(Token = "0x400C356")]
			[FieldOffset(Offset = "0x10")]
			public int layer;
		}
	}
}
