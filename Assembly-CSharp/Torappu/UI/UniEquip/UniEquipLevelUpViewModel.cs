using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C3C RID: 15420
	[Token(Token = "0x2003C3C")]
	public class UniEquipLevelUpViewModel : IHotfixable
	{
		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x060181C3 RID: 98755 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060181C2 RID: 98754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003995")]
		public List<RequireViewModel> requireViewModels
		{
			[Token(Token = "0x60181C3")]
			[Address(RVA = "0x1097740", Offset = "0x1096340", VA = "0x181097740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60181C2")]
			[Address(RVA = "0x10977A0", Offset = "0x10963A0", VA = "0x1810977A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x060181C4 RID: 98756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003996")]
		public string equipId
		{
			[Token(Token = "0x60181C4")]
			[Address(RVA = "0x1097620", Offset = "0x1096220", VA = "0x181097620")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x060181C5 RID: 98757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003997")]
		public string equipName
		{
			[Token(Token = "0x60181C5")]
			[Address(RVA = "0x10976B0", Offset = "0x10962B0", VA = "0x1810976B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060181C6 RID: 98758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181C6")]
		[Address(RVA = "0x1096D80", Offset = "0x1095980", VA = "0x181096D80")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData, string equipId)
		{
		}

		// Token: 0x060181C7 RID: 98759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181C7")]
		[Address(RVA = "0x1096E80", Offset = "0x1095A80", VA = "0x181096E80")]
		public void RefreshRequires()
		{
		}

		// Token: 0x060181C8 RID: 98760 RVA: 0x00099630 File Offset: 0x00097830
		[Token(Token = "0x60181C8")]
		[Address(RVA = "0x1096CF0", Offset = "0x10958F0", VA = "0x181096CF0")]
		public bool CheckIfTargetMaxLevel()
		{
			return default(bool);
		}

		// Token: 0x060181C9 RID: 98761 RVA: 0x00099648 File Offset: 0x00097848
		[Token(Token = "0x60181C9")]
		[Address(RVA = "0x1096EE0", Offset = "0x1095AE0", VA = "0x181096EE0")]
		public bool TrySelectLevel(int selectLevel)
		{
			return default(bool);
		}

		// Token: 0x060181CA RID: 98762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181CA")]
		[Address(RVA = "0x1096F80", Offset = "0x1095B80", VA = "0x181096F80")]
		private void _GeneRequireViewModels()
		{
		}

		// Token: 0x060181CB RID: 98763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181CB")]
		[Address(RVA = "0x1097250", Offset = "0x1095E50", VA = "0x181097250")]
		private void _GeneSwitchBoardViewModel(bool ifNeedSelectTween = false)
		{
		}

		// Token: 0x060181CC RID: 98764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181CC")]
		[Address(RVA = "0x1097580", Offset = "0x1096180", VA = "0x181097580")]
		public UniEquipLevelUpViewModel()
		{
		}

		// Token: 0x0401D484 RID: 119940
		[Token(Token = "0x401D484")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x0401D485 RID: 119941
		[Token(Token = "0x401D485")]
		[FieldOffset(Offset = "0x18")]
		public string templateId;

		// Token: 0x0401D486 RID: 119942
		[Token(Token = "0x401D486")]
		[FieldOffset(Offset = "0x20")]
		public UniEquipData uniEquipData;

		// Token: 0x0401D487 RID: 119943
		[Token(Token = "0x401D487")]
		[FieldOffset(Offset = "0x28")]
		public int currentLevel;

		// Token: 0x0401D488 RID: 119944
		[Token(Token = "0x401D488")]
		[FieldOffset(Offset = "0x2C")]
		public int targetLevel;

		// Token: 0x0401D489 RID: 119945
		[Token(Token = "0x401D489")]
		[FieldOffset(Offset = "0x30")]
		public UniEquipLevelUpSwitchBoardViewModel switchBoardViewModel;

		// Token: 0x0401D48A RID: 119946
		[Token(Token = "0x401D48A")]
		[FieldOffset(Offset = "0x38")]
		private PlayerCharacter m_playerChar;

		// Token: 0x0401D48B RID: 119947
		[Token(Token = "0x401D48B")]
		[FieldOffset(Offset = "0x40")]
		private CharacterData m_charData;

		// Token: 0x0401D48D RID: 119949
		[Token(Token = "0x401D48D")]
		[FieldOffset(Offset = "0x50")]
		public SpecialOperatorInfoViewModel spOpModel;

		// Token: 0x0401D48E RID: 119950
		[Token(Token = "0x401D48E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_requireViewModels;

		// Token: 0x0401D48F RID: 119951
		[Token(Token = "0x401D48F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_requireViewModels;

		// Token: 0x0401D490 RID: 119952
		[Token(Token = "0x401D490")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_equipId;

		// Token: 0x0401D491 RID: 119953
		[Token(Token = "0x401D491")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_equipName;

		// Token: 0x0401D492 RID: 119954
		[Token(Token = "0x401D492")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D493 RID: 119955
		[Token(Token = "0x401D493")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshRequires;

		// Token: 0x0401D494 RID: 119956
		[Token(Token = "0x401D494")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckIfTargetMaxLevel;

		// Token: 0x0401D495 RID: 119957
		[Token(Token = "0x401D495")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TrySelectLevel;

		// Token: 0x0401D496 RID: 119958
		[Token(Token = "0x401D496")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GeneRequireViewModels;

		// Token: 0x0401D497 RID: 119959
		[Token(Token = "0x401D497")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GeneSwitchBoardViewModel;

		// Token: 0x0401D498 RID: 119960
		[Token(Token = "0x401D498")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
