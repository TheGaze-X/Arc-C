using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040A3 RID: 16547
	[Token(Token = "0x20040A3")]
	public class SandboxV2AdminMainInventoryItemDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x0601999E RID: 104862 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601999F RID: 104863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D16")]
		public string topicId
		{
			[Token(Token = "0x601999E")]
			[Address(RVA = "0x1249580", Offset = "0x1248180", VA = "0x181249580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601999F")]
			[Address(RVA = "0x12496D0", Offset = "0x12482D0", VA = "0x1812496D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x060199A0 RID: 104864 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060199A1 RID: 104865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D17")]
		public List<SandboxV2AdminMainInventoryItemModel> itemList
		{
			[Token(Token = "0x60199A0")]
			[Address(RVA = "0x1249520", Offset = "0x1248120", VA = "0x181249520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60199A1")]
			[Address(RVA = "0x1249650", Offset = "0x1248250", VA = "0x181249650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x060199A2 RID: 104866 RVA: 0x0009EC58 File Offset: 0x0009CE58
		// (set) Token: 0x060199A3 RID: 104867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D18")]
		public int defaultItemIdx
		{
			[Token(Token = "0x60199A2")]
			[Address(RVA = "0x12494C0", Offset = "0x12480C0", VA = "0x1812494C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60199A3")]
			[Address(RVA = "0x12495E0", Offset = "0x12481E0", VA = "0x1812495E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060199A4 RID: 104868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199A4")]
		[Address(RVA = "0x12492E0", Offset = "0x1247EE0", VA = "0x1812492E0")]
		public void SetItemList(List<SandboxV2AdminMainInventoryItemModel> items, int currIdx, string topic)
		{
		}

		// Token: 0x060199A5 RID: 104869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199A5")]
		[Address(RVA = "0x1249460", Offset = "0x1248060", VA = "0x181249460")]
		public SandboxV2AdminMainInventoryItemDetailStateBean()
		{
		}

		// Token: 0x0401FF9B RID: 130971
		[Token(Token = "0x401FF9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0401FF9C RID: 130972
		[Token(Token = "0x401FF9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0401FF9D RID: 130973
		[Token(Token = "0x401FF9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemList;

		// Token: 0x0401FF9E RID: 130974
		[Token(Token = "0x401FF9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_itemList;

		// Token: 0x0401FF9F RID: 130975
		[Token(Token = "0x401FF9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_defaultItemIdx;

		// Token: 0x0401FFA0 RID: 130976
		[Token(Token = "0x401FFA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_defaultItemIdx;

		// Token: 0x0401FFA1 RID: 130977
		[Token(Token = "0x401FFA1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetItemList;

		// Token: 0x0401FFA2 RID: 130978
		[Token(Token = "0x401FFA2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
