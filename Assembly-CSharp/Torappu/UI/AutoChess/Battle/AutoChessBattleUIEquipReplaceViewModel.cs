using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064C4 RID: 25796
	[Token(Token = "0x20064C4")]
	public class AutoChessBattleUIEquipReplaceViewModel : IHotfixable
	{
		// Token: 0x17005776 RID: 22390
		// (get) Token: 0x06025124 RID: 151844 RVA: 0x000C6588 File Offset: 0x000C4788
		// (set) Token: 0x06025125 RID: 151845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005776")]
		public bool isShowEquipReplace
		{
			[Token(Token = "0x6025124")]
			[Address(RVA = "0x1FE94C0", Offset = "0x1FE80C0", VA = "0x181FE94C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025125")]
			[Address(RVA = "0x1FE9620", Offset = "0x1FE8220", VA = "0x181FE9620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005777 RID: 22391
		// (get) Token: 0x06025126 RID: 151846 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025127 RID: 151847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005777")]
		public string charName
		{
			[Token(Token = "0x6025126")]
			[Address(RVA = "0x1FE9460", Offset = "0x1FE8060", VA = "0x181FE9460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025127")]
			[Address(RVA = "0x1FE95A0", Offset = "0x1FE81A0", VA = "0x181FE95A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005778 RID: 22392
		// (get) Token: 0x06025128 RID: 151848 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025129 RID: 151849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005778")]
		public string charAvatarId
		{
			[Token(Token = "0x6025128")]
			[Address(RVA = "0x1FE9400", Offset = "0x1FE8000", VA = "0x181FE9400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025129")]
			[Address(RVA = "0x1FE9520", Offset = "0x1FE8120", VA = "0x181FE9520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602512A RID: 151850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602512A")]
		[Address(RVA = "0x1FE8B90", Offset = "0x1FE7790", VA = "0x181FE8B90")]
		public void UpdateData(AutoChessBattleUIViewModel uiViewModel)
		{
		}

		// Token: 0x0602512B RID: 151851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602512B")]
		[Address(RVA = "0x1FE8E00", Offset = "0x1FE7A00", VA = "0x181FE8E00")]
		private void _LoadCharInfo(ActAutoChessData actData)
		{
		}

		// Token: 0x0602512C RID: 151852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602512C")]
		[Address(RVA = "0x1FE8D50", Offset = "0x1FE7950", VA = "0x181FE8D50")]
		private SkillData _GetChessSkillData(ActAutoChessData actData, string chessId)
		{
			return null;
		}

		// Token: 0x0602512D RID: 151853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602512D")]
		[Address(RVA = "0x1FE9340", Offset = "0x1FE7F40", VA = "0x181FE9340")]
		public AutoChessBattleUIEquipReplaceViewModel()
		{
		}

		// Token: 0x04033EA9 RID: 212649
		[Token(Token = "0x4033EA9")]
		[FieldOffset(Offset = "0x14")]
		public int charInstId;

		// Token: 0x04033EAA RID: 212650
		[Token(Token = "0x4033EAA")]
		[FieldOffset(Offset = "0x18")]
		public int equipInstId;

		// Token: 0x04033EAD RID: 212653
		[Token(Token = "0x4033EAD")]
		[FieldOffset(Offset = "0x30")]
		public List<AutoChessBattleUIEquipReplaceViewModel.CharEquipInfo> charEquipInfos;

		// Token: 0x04033EAE RID: 212654
		[Token(Token = "0x4033EAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShowEquipReplace;

		// Token: 0x04033EAF RID: 212655
		[Token(Token = "0x4033EAF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShowEquipReplace;

		// Token: 0x04033EB0 RID: 212656
		[Token(Token = "0x4033EB0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_charName;

		// Token: 0x04033EB1 RID: 212657
		[Token(Token = "0x4033EB1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_charName;

		// Token: 0x04033EB2 RID: 212658
		[Token(Token = "0x4033EB2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_charAvatarId;

		// Token: 0x04033EB3 RID: 212659
		[Token(Token = "0x4033EB3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_charAvatarId;

		// Token: 0x04033EB4 RID: 212660
		[Token(Token = "0x4033EB4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033EB5 RID: 212661
		[Token(Token = "0x4033EB5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadCharInfo;

		// Token: 0x04033EB6 RID: 212662
		[Token(Token = "0x4033EB6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetChessSkillData;

		// Token: 0x04033EB7 RID: 212663
		[Token(Token = "0x4033EB7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064C5 RID: 25797
		[Token(Token = "0x20064C5")]
		public class CharEquipInfo
		{
			// Token: 0x0602512E RID: 151854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602512E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharEquipInfo()
			{
			}

			// Token: 0x04033EB8 RID: 212664
			[Token(Token = "0x4033EB8")]
			[FieldOffset(Offset = "0x10")]
			public int equipInstId;

			// Token: 0x04033EB9 RID: 212665
			[Token(Token = "0x4033EB9")]
			[FieldOffset(Offset = "0x18")]
			public string iconId;

			// Token: 0x04033EBA RID: 212666
			[Token(Token = "0x4033EBA")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x04033EBB RID: 212667
			[Token(Token = "0x4033EBB")]
			[FieldOffset(Offset = "0x28")]
			public string desc;
		}
	}
}
