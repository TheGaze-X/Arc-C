using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017F9 RID: 6137
	[Token(Token = "0x20017F9")]
	public class BuildingFuncFurnitureModel : IHotfixable
	{
		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06009AFD RID: 39677 RVA: 0x0003C4C8 File Offset: 0x0003A6C8
		// (set) Token: 0x06009AFE RID: 39678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010E9")]
		public BuildingFuncFurnitureModel.FurnOutlineInfo outlineInfo
		{
			[Token(Token = "0x6009AFD")]
			[Address(RVA = "0x31539F0", Offset = "0x31525F0", VA = "0x1831539F0")]
			get
			{
				return default(BuildingFuncFurnitureModel.FurnOutlineInfo);
			}
			[Token(Token = "0x6009AFE")]
			[Address(RVA = "0x3153A70", Offset = "0x3152670", VA = "0x183153A70")]
			set
			{
			}
		}

		// Token: 0x06009AFF RID: 39679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AFF")]
		[Address(RVA = "0x3153320", Offset = "0x3151F20", VA = "0x183153320")]
		public void OnInit()
		{
		}

		// Token: 0x06009B00 RID: 39680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B00")]
		[Address(RVA = "0x3153640", Offset = "0x3152240", VA = "0x183153640")]
		public void UpdateData()
		{
		}

		// Token: 0x06009B01 RID: 39681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B01")]
		[Address(RVA = "0x3153840", Offset = "0x3152440", VA = "0x183153840")]
		public void UpdateData(BuildingData.FurnitureSubType subType)
		{
		}

		// Token: 0x06009B02 RID: 39682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B02")]
		[Address(RVA = "0x3153280", Offset = "0x3151E80", VA = "0x183153280")]
		public BuildingFuncFurniBtnModel GetFuncFurnSubTypeModel(BuildingData.FurnitureSubType subType)
		{
			return null;
		}

		// Token: 0x06009B03 RID: 39683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B03")]
		[Address(RVA = "0x3153990", Offset = "0x3152590", VA = "0x183153990")]
		public BuildingFuncFurnitureModel()
		{
		}

		// Token: 0x04009159 RID: 37209
		[Token(Token = "0x4009159")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, BuildingFuncFurniBtnModel> m_models;

		// Token: 0x0400915A RID: 37210
		[Token(Token = "0x400915A")]
		[FieldOffset(Offset = "0x18")]
		private BuildingFuncFurnitureModel.FurnOutlineInfo m_currFurnOutlineInfo;

		// Token: 0x0400915B RID: 37211
		[Token(Token = "0x400915B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_outlineInfo;

		// Token: 0x0400915C RID: 37212
		[Token(Token = "0x400915C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_outlineInfo;

		// Token: 0x0400915D RID: 37213
		[Token(Token = "0x400915D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400915E RID: 37214
		[Token(Token = "0x400915E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0400915F RID: 37215
		[Token(Token = "0x400915F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_UpdateData;

		// Token: 0x04009160 RID: 37216
		[Token(Token = "0x4009160")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetFuncFurnSubTypeModel;

		// Token: 0x04009161 RID: 37217
		[Token(Token = "0x4009161")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020017FA RID: 6138
		[Token(Token = "0x20017FA")]
		public struct FurnOutlineInfo
		{
			// Token: 0x170010EA RID: 4330
			// (get) Token: 0x06009B04 RID: 39684 RVA: 0x0003C4E0 File Offset: 0x0003A6E0
			[Token(Token = "0x170010EA")]
			public bool isEmpty
			{
				[Token(Token = "0x6009B04")]
				[Address(RVA = "0xEAD120", Offset = "0xEABD20", VA = "0x180EAD120")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04009162 RID: 37218
			[Token(Token = "0x4009162")]
			[FieldOffset(Offset = "0x0")]
			public BuildingData.FurnitureSubType outlineSubType;

			// Token: 0x04009163 RID: 37219
			[Token(Token = "0x4009163")]
			[FieldOffset(Offset = "0x8")]
			public string slotId;

			// Token: 0x04009164 RID: 37220
			[Token(Token = "0x4009164")]
			[FieldOffset(Offset = "0x0")]
			public static readonly BuildingFuncFurnitureModel.FurnOutlineInfo EMPTY;
		}
	}
}
