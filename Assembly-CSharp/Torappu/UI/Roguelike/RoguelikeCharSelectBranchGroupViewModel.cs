using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054AF RID: 21679
	[Token(Token = "0x20054AF")]
	public class RoguelikeCharSelectBranchGroupViewModel : IHotfixable
	{
		// Token: 0x17004ABE RID: 19134
		// (get) Token: 0x0601FE44 RID: 130628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004ABE")]
		public string currentEquipId
		{
			[Token(Token = "0x601FE44")]
			[Address(RVA = "0x1A00E90", Offset = "0x19FFA90", VA = "0x181A00E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FE45 RID: 130629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE45")]
		[Address(RVA = "0x1A00D50", Offset = "0x19FF950", VA = "0x181A00D50")]
		public void SetEquipId(string i_equipId, string i_defaultEquipId)
		{
		}

		// Token: 0x0601FE46 RID: 130630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FE46")]
		[Address(RVA = "0x1A00AB0", Offset = "0x19FF6B0", VA = "0x181A00AB0")]
		public Sprite GetCurrentEquipIcon()
		{
			return null;
		}

		// Token: 0x0601FE47 RID: 130631 RVA: 0x000B3B08 File Offset: 0x000B1D08
		[Token(Token = "0x601FE47")]
		[Address(RVA = "0x1A00C50", Offset = "0x19FF850", VA = "0x181A00C50")]
		public int GetEquipLevelById(string equipId)
		{
			return 0;
		}

		// Token: 0x0601FE48 RID: 130632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FE48")]
		[Address(RVA = "0x1A009B0", Offset = "0x19FF5B0", VA = "0x181A009B0")]
		public RoguelikeCharSelectBranchItemViewModel AchieveBranchModelById(string branchId)
		{
			return null;
		}

		// Token: 0x0601FE49 RID: 130633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE49")]
		[Address(RVA = "0x1A00E30", Offset = "0x19FFA30", VA = "0x181A00E30")]
		public RoguelikeCharSelectBranchGroupViewModel()
		{
		}

		// Token: 0x0402B032 RID: 176178
		[Token(Token = "0x402B032")]
		[FieldOffset(Offset = "0x10")]
		public string featureDescBasic;

		// Token: 0x0402B033 RID: 176179
		[Token(Token = "0x402B033")]
		[FieldOffset(Offset = "0x18")]
		public string rawFeatureDesc;

		// Token: 0x0402B034 RID: 176180
		[Token(Token = "0x402B034")]
		[FieldOffset(Offset = "0x20")]
		public string featureDescAdditive;

		// Token: 0x0402B035 RID: 176181
		[Token(Token = "0x402B035")]
		[FieldOffset(Offset = "0x28")]
		private string m_currentEquipId;

		// Token: 0x0402B036 RID: 176182
		[Token(Token = "0x402B036")]
		[FieldOffset(Offset = "0x30")]
		public string defaultEquipId;

		// Token: 0x0402B037 RID: 176183
		[Token(Token = "0x402B037")]
		[FieldOffset(Offset = "0x38")]
		public bool haveAvailEquip;

		// Token: 0x0402B038 RID: 176184
		[Token(Token = "0x402B038")]
		[FieldOffset(Offset = "0x39")]
		public bool haveEquip;

		// Token: 0x0402B039 RID: 176185
		[Token(Token = "0x402B039")]
		[FieldOffset(Offset = "0x3A")]
		public bool havePlayerEquipUnlocked;

		// Token: 0x0402B03A RID: 176186
		[Token(Token = "0x402B03A")]
		[FieldOffset(Offset = "0x3B")]
		public bool ableToSelect;

		// Token: 0x0402B03B RID: 176187
		[Token(Token = "0x402B03B")]
		[FieldOffset(Offset = "0x40")]
		public string subProfessionInfo;

		// Token: 0x0402B03C RID: 176188
		[Token(Token = "0x402B03C")]
		[FieldOffset(Offset = "0x48")]
		public RoguelikeTalentViewModel[] talentDescs;

		// Token: 0x0402B03D RID: 176189
		[Token(Token = "0x402B03D")]
		[FieldOffset(Offset = "0x50")]
		public List<RoguelikeCharSelectBranchItemViewModel> branchModels;

		// Token: 0x0402B03E RID: 176190
		[Token(Token = "0x402B03E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentEquipId;

		// Token: 0x0402B03F RID: 176191
		[Token(Token = "0x402B03F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetEquipId;

		// Token: 0x0402B040 RID: 176192
		[Token(Token = "0x402B040")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCurrentEquipIcon;

		// Token: 0x0402B041 RID: 176193
		[Token(Token = "0x402B041")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetEquipLevelById;

		// Token: 0x0402B042 RID: 176194
		[Token(Token = "0x402B042")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AchieveBranchModelById;

		// Token: 0x0402B043 RID: 176195
		[Token(Token = "0x402B043")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
