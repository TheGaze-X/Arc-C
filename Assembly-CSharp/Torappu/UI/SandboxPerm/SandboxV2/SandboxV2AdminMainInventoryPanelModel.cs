using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040B0 RID: 16560
	[Token(Token = "0x20040B0")]
	public class SandboxV2AdminMainInventoryPanelModel : IHotfixable
	{
		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x060199E0 RID: 104928 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060199E1 RID: 104929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D22")]
		public string topicId
		{
			[Token(Token = "0x60199E0")]
			[Address(RVA = "0x1276410", Offset = "0x1275010", VA = "0x181276410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60199E1")]
			[Address(RVA = "0x12766C0", Offset = "0x12752C0", VA = "0x1812766C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x060199E2 RID: 104930 RVA: 0x0009ECE8 File Offset: 0x0009CEE8
		// (set) Token: 0x060199E3 RID: 104931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D23")]
		public SandboxV2AdminMainInventoryItemShowType itemShowType
		{
			[Token(Token = "0x60199E2")]
			[Address(RVA = "0x1276350", Offset = "0x1274F50", VA = "0x181276350")]
			[CompilerGenerated]
			get
			{
				return SandboxV2AdminMainInventoryItemShowType.NONE;
			}
			[Token(Token = "0x60199E3")]
			[Address(RVA = "0x12765D0", Offset = "0x12751D0", VA = "0x1812765D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x060199E4 RID: 104932 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060199E5 RID: 104933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D24")]
		public List<SandboxV2AdminMainInventoryItemModel> allItem
		{
			[Token(Token = "0x60199E4")]
			[Address(RVA = "0x1276230", Offset = "0x1274E30", VA = "0x181276230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60199E5")]
			[Address(RVA = "0x1276470", Offset = "0x1275070", VA = "0x181276470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x060199E6 RID: 104934 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060199E7 RID: 104935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D25")]
		public List<SandboxV2AdminMainInventoryItemModel> showItemList
		{
			[Token(Token = "0x60199E6")]
			[Address(RVA = "0x12763B0", Offset = "0x1274FB0", VA = "0x1812763B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60199E7")]
			[Address(RVA = "0x1276640", Offset = "0x1275240", VA = "0x181276640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x060199E8 RID: 104936 RVA: 0x0009ED00 File Offset: 0x0009CF00
		// (set) Token: 0x060199E9 RID: 104937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D26")]
		public int currClickItemIdx
		{
			[Token(Token = "0x60199E8")]
			[Address(RVA = "0x1276290", Offset = "0x1274E90", VA = "0x181276290")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60199E9")]
			[Address(RVA = "0x12764F0", Offset = "0x12750F0", VA = "0x1812764F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x060199EA RID: 104938 RVA: 0x0009ED18 File Offset: 0x0009CF18
		// (set) Token: 0x060199EB RID: 104939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D27")]
		public bool isSingleMode
		{
			[Token(Token = "0x60199EA")]
			[Address(RVA = "0x12762F0", Offset = "0x1274EF0", VA = "0x1812762F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60199EB")]
			[Address(RVA = "0x1276560", Offset = "0x1275160", VA = "0x181276560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060199EC RID: 104940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199EC")]
		[Address(RVA = "0x12749F0", Offset = "0x12735F0", VA = "0x1812749F0")]
		public void Init(string topic)
		{
		}

		// Token: 0x060199ED RID: 104941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199ED")]
		[Address(RVA = "0x1274AA0", Offset = "0x12736A0", VA = "0x181274AA0")]
		public void Reload()
		{
		}

		// Token: 0x060199EE RID: 104942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199EE")]
		[Address(RVA = "0x12756D0", Offset = "0x12742D0", VA = "0x1812756D0")]
		private void _LoadAllItem(string topic)
		{
		}

		// Token: 0x060199EF RID: 104943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60199EF")]
		[Address(RVA = "0x1275120", Offset = "0x1273D20", VA = "0x181275120")]
		private SandboxV2AdminMainInventoryItemModel _AddItemToAll(string itemId, int count)
		{
			return null;
		}

		// Token: 0x060199F0 RID: 104944 RVA: 0x0009ED30 File Offset: 0x0009CF30
		[Token(Token = "0x60199F0")]
		[Address(RVA = "0x1274BB0", Offset = "0x12737B0", VA = "0x181274BB0")]
		public bool SetCurrItemViewType(SandboxV2AdminMainInventoryItemShowType showType, bool forceRefresh = false)
		{
			return default(bool);
		}

		// Token: 0x060199F1 RID: 104945 RVA: 0x0009ED48 File Offset: 0x0009CF48
		[Token(Token = "0x60199F1")]
		[Address(RVA = "0x1275420", Offset = "0x1274020", VA = "0x181275420")]
		private int _ItemSort(SandboxV2AdminMainInventoryItemModel item1, SandboxV2AdminMainInventoryItemModel item2)
		{
			return 0;
		}

		// Token: 0x060199F2 RID: 104946 RVA: 0x0009ED60 File Offset: 0x0009CF60
		[Token(Token = "0x60199F2")]
		[Address(RVA = "0x1274900", Offset = "0x1273500", VA = "0x181274900")]
		public static SandboxV2AdminMainInventoryItemShowType CheckItemShowType(SandboxPermItemType itemType)
		{
			return SandboxV2AdminMainInventoryItemShowType.NONE;
		}

		// Token: 0x060199F3 RID: 104947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199F3")]
		[Address(RVA = "0x12761D0", Offset = "0x1274DD0", VA = "0x1812761D0")]
		public SandboxV2AdminMainInventoryPanelModel()
		{
		}

		// Token: 0x04020013 RID: 131091
		[Token(Token = "0x4020013")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04020014 RID: 131092
		[Token(Token = "0x4020014")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04020015 RID: 131093
		[Token(Token = "0x4020015")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemShowType;

		// Token: 0x04020016 RID: 131094
		[Token(Token = "0x4020016")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_itemShowType;

		// Token: 0x04020017 RID: 131095
		[Token(Token = "0x4020017")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_allItem;

		// Token: 0x04020018 RID: 131096
		[Token(Token = "0x4020018")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_allItem;

		// Token: 0x04020019 RID: 131097
		[Token(Token = "0x4020019")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_showItemList;

		// Token: 0x0402001A RID: 131098
		[Token(Token = "0x402001A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_showItemList;

		// Token: 0x0402001B RID: 131099
		[Token(Token = "0x402001B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_currClickItemIdx;

		// Token: 0x0402001C RID: 131100
		[Token(Token = "0x402001C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_currClickItemIdx;

		// Token: 0x0402001D RID: 131101
		[Token(Token = "0x402001D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isSingleMode;

		// Token: 0x0402001E RID: 131102
		[Token(Token = "0x402001E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_isSingleMode;

		// Token: 0x0402001F RID: 131103
		[Token(Token = "0x402001F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04020020 RID: 131104
		[Token(Token = "0x4020020")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Reload;

		// Token: 0x04020021 RID: 131105
		[Token(Token = "0x4020021")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadAllItem;

		// Token: 0x04020022 RID: 131106
		[Token(Token = "0x4020022")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__AddItemToAll;

		// Token: 0x04020023 RID: 131107
		[Token(Token = "0x4020023")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetCurrItemViewType;

		// Token: 0x04020024 RID: 131108
		[Token(Token = "0x4020024")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ItemSort;

		// Token: 0x04020025 RID: 131109
		[Token(Token = "0x4020025")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CheckItemShowType;

		// Token: 0x04020026 RID: 131110
		[Token(Token = "0x4020026")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
