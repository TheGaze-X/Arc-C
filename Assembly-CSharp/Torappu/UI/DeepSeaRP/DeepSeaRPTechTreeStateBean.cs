using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005183 RID: 20867
	[Token(Token = "0x2005183")]
	public class DeepSeaRPTechTreeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170047D6 RID: 18390
		// (get) Token: 0x0601ED5E RID: 126302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047D6")]
		public string groupId
		{
			[Token(Token = "0x601ED5E")]
			[Address(RVA = "0x189AB60", Offset = "0x1899760", VA = "0x18189AB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601ED5F RID: 126303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED5F")]
		[Address(RVA = "0x189A0E0", Offset = "0x1898CE0", VA = "0x18189A0E0")]
		public void LoadData(bool isRetro, string groupId)
		{
		}

		// Token: 0x0601ED60 RID: 126304 RVA: 0x000AFE48 File Offset: 0x000AE048
		[Token(Token = "0x601ED60")]
		[Address(RVA = "0x1899D10", Offset = "0x1898910", VA = "0x181899D10")]
		public bool HaveTechUnlock()
		{
			return default(bool);
		}

		// Token: 0x0601ED61 RID: 126305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED61")]
		[Address(RVA = "0x189A550", Offset = "0x1899150", VA = "0x18189A550")]
		public void UpdateChange(string treeId, PlayerDeepSea.TechData data)
		{
		}

		// Token: 0x0601ED62 RID: 126306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED62")]
		[Address(RVA = "0x1899C10", Offset = "0x1898810", VA = "0x181899C10")]
		public string GetDefaultBranchId(string treeId)
		{
			return null;
		}

		// Token: 0x0601ED63 RID: 126307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED63")]
		[Address(RVA = "0x189A360", Offset = "0x1898F60", VA = "0x18189A360")]
		public void SwitchBranch(string treeId)
		{
		}

		// Token: 0x0601ED64 RID: 126308 RVA: 0x000AFE60 File Offset: 0x000AE060
		[Token(Token = "0x601ED64")]
		[Address(RVA = "0x1899E90", Offset = "0x1898A90", VA = "0x181899E90")]
		public bool IsSettingChanged()
		{
			return default(bool);
		}

		// Token: 0x0601ED65 RID: 126309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED65")]
		[Address(RVA = "0x1899900", Offset = "0x1898500", VA = "0x181899900")]
		public List<TechBranchData> GetChangedBranchList()
		{
			return null;
		}

		// Token: 0x0601ED66 RID: 126310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED66")]
		[Address(RVA = "0x189A680", Offset = "0x1899280", VA = "0x18189A680")]
		public void UpdateSettingStateAsChanged()
		{
		}

		// Token: 0x0601ED67 RID: 126311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED67")]
		[Address(RVA = "0x189A7E0", Offset = "0x18993E0", VA = "0x18189A7E0")]
		public void UpdateSettingStateAsSaved()
		{
		}

		// Token: 0x0601ED68 RID: 126312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED68")]
		[Address(RVA = "0x189A710", Offset = "0x1899310", VA = "0x18189A710")]
		public void UpdateSettingStateAsNone()
		{
		}

		// Token: 0x0601ED69 RID: 126313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED69")]
		[Address(RVA = "0x189A8B0", Offset = "0x18994B0", VA = "0x18189A8B0")]
		private DeepSeaRPTechTreeNodeModel _GetTreeNodeModel(string treeId)
		{
			return null;
		}

		// Token: 0x0601ED6A RID: 126314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED6A")]
		[Address(RVA = "0x189AA70", Offset = "0x1899670", VA = "0x18189AA70")]
		public DeepSeaRPTechTreeStateBean()
		{
		}

		// Token: 0x040295BA RID: 169402
		[Token(Token = "0x40295BA")]
		[FieldOffset(Offset = "0x10")]
		public DeepSeaRPTechTreeViewProperty viewProperty;

		// Token: 0x040295BB RID: 169403
		[Token(Token = "0x40295BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupId;

		// Token: 0x040295BC RID: 169404
		[Token(Token = "0x40295BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040295BD RID: 169405
		[Token(Token = "0x40295BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HaveTechUnlock;

		// Token: 0x040295BE RID: 169406
		[Token(Token = "0x40295BE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateChange;

		// Token: 0x040295BF RID: 169407
		[Token(Token = "0x40295BF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDefaultBranchId;

		// Token: 0x040295C0 RID: 169408
		[Token(Token = "0x40295C0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SwitchBranch;

		// Token: 0x040295C1 RID: 169409
		[Token(Token = "0x40295C1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsSettingChanged;

		// Token: 0x040295C2 RID: 169410
		[Token(Token = "0x40295C2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetChangedBranchList;

		// Token: 0x040295C3 RID: 169411
		[Token(Token = "0x40295C3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateSettingStateAsChanged;

		// Token: 0x040295C4 RID: 169412
		[Token(Token = "0x40295C4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateSettingStateAsSaved;

		// Token: 0x040295C5 RID: 169413
		[Token(Token = "0x40295C5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateSettingStateAsNone;

		// Token: 0x040295C6 RID: 169414
		[Token(Token = "0x40295C6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetTreeNodeModel;

		// Token: 0x040295C7 RID: 169415
		[Token(Token = "0x40295C7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
