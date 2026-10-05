using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200407C RID: 16508
	[Token(Token = "0x200407C")]
	public class SandboxV2CookFoodListModel : IHotfixable
	{
		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x06019885 RID: 104581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CDA")]
		public List<SandboxV2AdminMainMaterialModel> materials
		{
			[Token(Token = "0x6019885")]
			[Address(RVA = "0x123AC20", Offset = "0x1239820", VA = "0x18123AC20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x06019886 RID: 104582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CDB")]
		public List<SandboxV2CookFoodListItemModel> allItems
		{
			[Token(Token = "0x6019886")]
			[Address(RVA = "0x123AB60", Offset = "0x1239760", VA = "0x18123AB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x06019887 RID: 104583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CDC")]
		public List<SandboxV2CookFoodListItemModel> canCookItems
		{
			[Token(Token = "0x6019887")]
			[Address(RVA = "0x123ABC0", Offset = "0x12397C0", VA = "0x18123ABC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019888 RID: 104584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019888")]
		[Address(RVA = "0x1239410", Offset = "0x1238010", VA = "0x181239410")]
		public void LoadData(string topicId, SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x06019889 RID: 104585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019889")]
		[Address(RVA = "0x123A470", Offset = "0x1239070", VA = "0x18123A470")]
		private void _LoadMaterialItems(SandboxV2Data gameData, PlayerSandboxV2 playerData, string waterId, int waterCount)
		{
		}

		// Token: 0x0601988A RID: 104586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601988A")]
		[Address(RVA = "0x1239CC0", Offset = "0x12388C0", VA = "0x181239CC0")]
		private void _LoadFoodItems(string topicId, SandboxV2Data gameData, PlayerSandboxV2 playerData, string waterId, int waterCount)
		{
		}

		// Token: 0x0601988B RID: 104587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601988B")]
		[Address(RVA = "0x12396B0", Offset = "0x12382B0", VA = "0x1812396B0")]
		private List<SandboxV2AdminMainMaterialModel> _GenerateMaterials(PlayerSandboxV2 playerData, List<string> mats, string waterId, int waterCount)
		{
			return null;
		}

		// Token: 0x0601988C RID: 104588 RVA: 0x0009E838 File Offset: 0x0009CA38
		[Token(Token = "0x601988C")]
		[Address(RVA = "0x123A8D0", Offset = "0x12394D0", VA = "0x18123A8D0")]
		private static int _MatComparison(SandboxV2AdminMainMaterialModel x, SandboxV2AdminMainMaterialModel y)
		{
			return 0;
		}

		// Token: 0x0601988D RID: 104589 RVA: 0x0009E850 File Offset: 0x0009CA50
		[Token(Token = "0x601988D")]
		[Address(RVA = "0x1239AE0", Offset = "0x12386E0", VA = "0x181239AE0")]
		private static int _ItemComparison(SandboxV2CookFoodListItemModel x, SandboxV2CookFoodListItemModel y)
		{
			return 0;
		}

		// Token: 0x0601988E RID: 104590 RVA: 0x0009E868 File Offset: 0x0009CA68
		[Token(Token = "0x601988E")]
		[Address(RVA = "0x1239560", Offset = "0x1238160", VA = "0x181239560")]
		private static int _CanCookItemComparison(SandboxV2CookFoodListItemModel x, SandboxV2CookFoodListItemModel y)
		{
			return 0;
		}

		// Token: 0x0601988F RID: 104591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601988F")]
		[Address(RVA = "0x123A990", Offset = "0x1239590", VA = "0x18123A990")]
		public SandboxV2CookFoodListModel()
		{
		}

		// Token: 0x0401FD57 RID: 130391
		[Token(Token = "0x401FD57")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, SandboxV2CookFoodListItemModel> m_itemDict;

		// Token: 0x0401FD58 RID: 130392
		[Token(Token = "0x401FD58")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<SandboxV2AdminMainMaterialModel> m_materialList;

		// Token: 0x0401FD59 RID: 130393
		[Token(Token = "0x401FD59")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<SandboxV2CookFoodListItemModel> m_itemList;

		// Token: 0x0401FD5A RID: 130394
		[Token(Token = "0x401FD5A")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<SandboxV2CookFoodListItemModel> m_canCookItemList;

		// Token: 0x0401FD5B RID: 130395
		[Token(Token = "0x401FD5B")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, int> m_matConsumeCache;

		// Token: 0x0401FD5C RID: 130396
		[Token(Token = "0x401FD5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_materials;

		// Token: 0x0401FD5D RID: 130397
		[Token(Token = "0x401FD5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_allItems;

		// Token: 0x0401FD5E RID: 130398
		[Token(Token = "0x401FD5E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_canCookItems;

		// Token: 0x0401FD5F RID: 130399
		[Token(Token = "0x401FD5F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401FD60 RID: 130400
		[Token(Token = "0x401FD60")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadMaterialItems;

		// Token: 0x0401FD61 RID: 130401
		[Token(Token = "0x401FD61")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadFoodItems;

		// Token: 0x0401FD62 RID: 130402
		[Token(Token = "0x401FD62")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenerateMaterials;

		// Token: 0x0401FD63 RID: 130403
		[Token(Token = "0x401FD63")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__MatComparison;

		// Token: 0x0401FD64 RID: 130404
		[Token(Token = "0x401FD64")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ItemComparison;

		// Token: 0x0401FD65 RID: 130405
		[Token(Token = "0x401FD65")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CanCookItemComparison;

		// Token: 0x0401FD66 RID: 130406
		[Token(Token = "0x401FD66")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
