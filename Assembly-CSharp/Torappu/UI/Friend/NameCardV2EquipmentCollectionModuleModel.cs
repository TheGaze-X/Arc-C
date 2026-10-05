using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.UniEquipArchive;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D93 RID: 19859
	[Token(Token = "0x2004D93")]
	public class NameCardV2EquipmentCollectionModuleModel : NameCardV2RemovableModuleBaseModel
	{
		// Token: 0x170045AA RID: 17834
		// (get) Token: 0x0601DB69 RID: 121705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170045AA")]
		public List<NameCardV2EquipmentCollectionInfoItemViewModel> infoItemViewModelList
		{
			[Token(Token = "0x601DB69")]
			[Address(RVA = "0x17489A0", Offset = "0x17475A0", VA = "0x1817489A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170045AB RID: 17835
		// (get) Token: 0x0601DB6A RID: 121706 RVA: 0x000AC5A8 File Offset: 0x000AA7A8
		[Token(Token = "0x170045AB")]
		public override NameCardV2ModuleSubType moduleSubType
		{
			[Token(Token = "0x601DB6A")]
			[Address(RVA = "0x1748A00", Offset = "0x1747600", VA = "0x181748A00", Slot = "10")]
			get
			{
				return NameCardV2ModuleSubType.NONE;
			}
		}

		// Token: 0x0601DB6B RID: 121707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB6B")]
		[Address(RVA = "0x1747CA0", Offset = "0x17468A0", VA = "0x181747CA0", Slot = "9")]
		protected override void OnLoadFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB6C RID: 121708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB6C")]
		[Address(RVA = "0x1747FE0", Offset = "0x1746BE0", VA = "0x181747FE0", Slot = "7")]
		protected override void OnLoadSelfData()
		{
		}

		// Token: 0x0601DB6D RID: 121709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB6D")]
		[Address(RVA = "0x1748040", Offset = "0x1746C40", VA = "0x181748040", Slot = "8")]
		protected override void OnRefreshSelfData()
		{
		}

		// Token: 0x0601DB6E RID: 121710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB6E")]
		[Address(RVA = "0x1748490", Offset = "0x1747090", VA = "0x181748490")]
		public void SwitchShowType()
		{
		}

		// Token: 0x0601DB6F RID: 121711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB6F")]
		[Address(RVA = "0x1748620", Offset = "0x1747220", VA = "0x181748620")]
		private void _CalcFriendModuleInfoDatas(out int equipTotalCountWithoutLimit, out int charHasModuleCountWithoutLimit)
		{
		}

		// Token: 0x0601DB70 RID: 121712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB70")]
		[Address(RVA = "0x17488B0", Offset = "0x17474B0", VA = "0x1817488B0")]
		public NameCardV2EquipmentCollectionModuleModel()
		{
		}

		// Token: 0x04027451 RID: 160849
		[Token(Token = "0x4027451")]
		[FieldOffset(Offset = "0x50")]
		private List<NameCardV2EquipmentCollectionInfoItemViewModel> m_infoItemViewModelList;

		// Token: 0x04027452 RID: 160850
		[Token(Token = "0x4027452")]
		[FieldOffset(Offset = "0x58")]
		private UniEquipArchiveCollectionInfoViewModel m_selfCollectionInfoViewModel;

		// Token: 0x04027453 RID: 160851
		[Token(Token = "0x4027453")]
		[FieldOffset(Offset = "0x60")]
		public bool isSelf;

		// Token: 0x04027454 RID: 160852
		[Token(Token = "0x4027454")]
		[FieldOffset(Offset = "0x61")]
		private bool m_showFriendTotalInfo;

		// Token: 0x04027455 RID: 160853
		[Token(Token = "0x4027455")]
		[FieldOffset(Offset = "0x62")]
		private bool m_showSelfTotalInfo;

		// Token: 0x04027456 RID: 160854
		[Token(Token = "0x4027456")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_infoItemViewModelList;

		// Token: 0x04027457 RID: 160855
		[Token(Token = "0x4027457")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_moduleSubType;

		// Token: 0x04027458 RID: 160856
		[Token(Token = "0x4027458")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoadFriendData;

		// Token: 0x04027459 RID: 160857
		[Token(Token = "0x4027459")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnLoadSelfData;

		// Token: 0x0402745A RID: 160858
		[Token(Token = "0x402745A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRefreshSelfData;

		// Token: 0x0402745B RID: 160859
		[Token(Token = "0x402745B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SwitchShowType;

		// Token: 0x0402745C RID: 160860
		[Token(Token = "0x402745C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalcFriendModuleInfoDatas;

		// Token: 0x0402745D RID: 160861
		[Token(Token = "0x402745D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
