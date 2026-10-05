using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C38 RID: 15416
	[Token(Token = "0x2003C38")]
	public class UniEquipLevelUpSwitchBoardViewModel : IHotfixable
	{
		// Token: 0x060181B0 RID: 98736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181B0")]
		[Address(RVA = "0x1093810", Offset = "0x1092410", VA = "0x181093810")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData, UniEquipData uniEquipData, int current, int target, bool ifNeedSelectTween)
		{
		}

		// Token: 0x060181B1 RID: 98737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181B1")]
		[Address(RVA = "0x1093A10", Offset = "0x1092610", VA = "0x181093A10")]
		public void SetBoardInfoHeight(float basicHeight, float subProfessionHeight, float talentHeight)
		{
		}

		// Token: 0x060181B2 RID: 98738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181B2")]
		[Address(RVA = "0x1093BA0", Offset = "0x10927A0", VA = "0x181093BA0")]
		private void _GeneAttributeInfo(PlayerCharacter playerChar, UniEquipData uniEquipData)
		{
		}

		// Token: 0x060181B3 RID: 98739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181B3")]
		[Address(RVA = "0x10957B0", Offset = "0x10943B0", VA = "0x1810957B0")]
		private static void _geneInfoTextForAttr(List<StringBuilder> builders, List<AttributesCalculator.AttributeRawDelta> attributeDeltas, string baseStr, AttributeType attributeType, bool eorFlag = false)
		{
		}

		// Token: 0x060181B4 RID: 98740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181B4")]
		[Address(RVA = "0x10943B0", Offset = "0x1092FB0", VA = "0x1810943B0")]
		private void _GeneSubProfession(PlayerCharacter playerChar, CharacterData charData, UniEquipData uniEquipData)
		{
		}

		// Token: 0x060181B5 RID: 98741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181B5")]
		[Address(RVA = "0x1094DE0", Offset = "0x10939E0", VA = "0x181094DE0")]
		private void _GeneTalents(PlayerCharacter playerChar, CharacterData charData, UniEquipData uniEquipData)
		{
		}

		// Token: 0x060181B6 RID: 98742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181B6")]
		[Address(RVA = "0x1095700", Offset = "0x1094300", VA = "0x181095700")]
		public UniEquipLevelUpSwitchBoardViewModel()
		{
		}

		// Token: 0x0401D45F RID: 119903
		[Token(Token = "0x401D45F")]
		[FieldOffset(Offset = "0x10")]
		public List<UniEquipLevelUpBoardObjViewModel> boardModelList;

		// Token: 0x0401D460 RID: 119904
		[Token(Token = "0x401D460")]
		[FieldOffset(Offset = "0x18")]
		public int currentLevel;

		// Token: 0x0401D461 RID: 119905
		[Token(Token = "0x401D461")]
		[FieldOffset(Offset = "0x1C")]
		public int targetLevel;

		// Token: 0x0401D462 RID: 119906
		[Token(Token = "0x401D462")]
		[FieldOffset(Offset = "0x20")]
		public bool showSelectTween;

		// Token: 0x0401D463 RID: 119907
		[Token(Token = "0x401D463")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D464 RID: 119908
		[Token(Token = "0x401D464")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetBoardInfoHeight;

		// Token: 0x0401D465 RID: 119909
		[Token(Token = "0x401D465")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GeneAttributeInfo;

		// Token: 0x0401D466 RID: 119910
		[Token(Token = "0x401D466")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__geneInfoTextForAttr;

		// Token: 0x0401D467 RID: 119911
		[Token(Token = "0x401D467")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GeneSubProfession;

		// Token: 0x0401D468 RID: 119912
		[Token(Token = "0x401D468")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GeneTalents;

		// Token: 0x0401D469 RID: 119913
		[Token(Token = "0x401D469")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
