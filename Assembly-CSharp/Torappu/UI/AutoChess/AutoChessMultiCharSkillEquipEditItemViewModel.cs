using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006310 RID: 25360
	[Token(Token = "0x2006310")]
	public class AutoChessMultiCharSkillEquipEditItemViewModel : IHotfixable
	{
		// Token: 0x170055FD RID: 22013
		// (get) Token: 0x060248BC RID: 149692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170055FD")]
		public string chessId
		{
			[Token(Token = "0x60248BC")]
			[Address(RVA = "0x1F67570", Offset = "0x1F66170", VA = "0x181F67570")]
			get
			{
				return null;
			}
		}

		// Token: 0x170055FE RID: 22014
		// (get) Token: 0x060248BD RID: 149693 RVA: 0x000C4908 File Offset: 0x000C2B08
		[Token(Token = "0x170055FE")]
		public int chessLv
		{
			[Token(Token = "0x60248BD")]
			[Address(RVA = "0x1F67630", Offset = "0x1F66230", VA = "0x181F67630")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170055FF RID: 22015
		// (get) Token: 0x060248BE RID: 149694 RVA: 0x000C4920 File Offset: 0x000C2B20
		// (set) Token: 0x060248BF RID: 149695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055FF")]
		public AutoChessShopQuickEditType quickEditType
		{
			[Token(Token = "0x60248BE")]
			[Address(RVA = "0x1F676D0", Offset = "0x1F662D0", VA = "0x181F676D0")]
			[CompilerGenerated]
			get
			{
				return AutoChessShopQuickEditType.NONE;
			}
			[Token(Token = "0x60248BF")]
			[Address(RVA = "0x1F679B0", Offset = "0x1F665B0", VA = "0x181F679B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005600 RID: 22016
		// (get) Token: 0x060248C0 RID: 149696 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060248C1 RID: 149697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005600")]
		public string selectedSkillId
		{
			[Token(Token = "0x60248C0")]
			[Address(RVA = "0x1F67950", Offset = "0x1F66550", VA = "0x181F67950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60248C1")]
			[Address(RVA = "0x1F67AA0", Offset = "0x1F666A0", VA = "0x181F67AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005601 RID: 22017
		// (get) Token: 0x060248C2 RID: 149698 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060248C3 RID: 149699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005601")]
		public string selectedEquipId
		{
			[Token(Token = "0x60248C2")]
			[Address(RVA = "0x1F67730", Offset = "0x1F66330", VA = "0x181F67730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60248C3")]
			[Address(RVA = "0x1F67A20", Offset = "0x1F66620", VA = "0x181F67A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005602 RID: 22018
		// (get) Token: 0x060248C4 RID: 149700 RVA: 0x000C4938 File Offset: 0x000C2B38
		[Token(Token = "0x17005602")]
		public int selectedEquipIndex
		{
			[Token(Token = "0x60248C4")]
			[Address(RVA = "0x1F67790", Offset = "0x1F66390", VA = "0x181F67790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060248C5 RID: 149701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248C5")]
		[Address(RVA = "0x1F66610", Offset = "0x1F65210", VA = "0x181F66610")]
		public void LoadData(AutoChessShopCharChessCardViewModel cardViewModel)
		{
		}

		// Token: 0x060248C6 RID: 149702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248C6")]
		[Address(RVA = "0x1F666E0", Offset = "0x1F652E0", VA = "0x181F666E0")]
		public void RefreshEditType(AutoChessShopQuickEditType editType)
		{
		}

		// Token: 0x060248C7 RID: 149703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248C7")]
		[Address(RVA = "0x1F66850", Offset = "0x1F65450", VA = "0x181F66850")]
		public void UpdateSelectSkill(string selectId)
		{
		}

		// Token: 0x060248C8 RID: 149704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248C8")]
		[Address(RVA = "0x1F66780", Offset = "0x1F65380", VA = "0x181F66780")]
		public void UpdateSelectEquip(string selectId)
		{
		}

		// Token: 0x060248C9 RID: 149705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248C9")]
		[Address(RVA = "0x1F67120", Offset = "0x1F65D20", VA = "0x181F67120")]
		private void _LoadSkill(AutoChessShopCharChessCardViewModel charCardViewModel)
		{
		}

		// Token: 0x060248CA RID: 149706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60248CA")]
		[Address(RVA = "0x1F66920", Offset = "0x1F65520", VA = "0x181F66920")]
		private SkillItemViewModel _CreateSkill(CharacterData charData, ActAutoChessData.ActAutoChessCharChessStatusData chessAttr, int allLevel, int specLevel, int skillIndex)
		{
			return null;
		}

		// Token: 0x060248CB RID: 149707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248CB")]
		[Address(RVA = "0x1F66C30", Offset = "0x1F65830", VA = "0x181F66C30")]
		private void _LoadEquip(AutoChessShopCharChessCardViewModel charCardViewModel)
		{
		}

		// Token: 0x060248CC RID: 149708 RVA: 0x000C4950 File Offset: 0x000C2B50
		[Token(Token = "0x60248CC")]
		[Address(RVA = "0x1F66AC0", Offset = "0x1F656C0", VA = "0x181F66AC0")]
		private int _GetSelectEquipIndex()
		{
			return 0;
		}

		// Token: 0x060248CD RID: 149709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248CD")]
		[Address(RVA = "0x1F67460", Offset = "0x1F66060", VA = "0x181F67460")]
		public AutoChessMultiCharSkillEquipEditItemViewModel()
		{
		}

		// Token: 0x04032FCC RID: 208844
		[Token(Token = "0x4032FCC")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, SkillItemViewModel> skills;

		// Token: 0x04032FCD RID: 208845
		[Token(Token = "0x4032FCD")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, AutoChessMultiCharSkillEquipEditItemViewModel.EquipItemViewModel> equips;

		// Token: 0x04032FD1 RID: 208849
		[Token(Token = "0x4032FD1")]
		[FieldOffset(Offset = "0x38")]
		private AutoChessShopCharChessCardViewModel m_cardViewModel;

		// Token: 0x04032FD2 RID: 208850
		[Token(Token = "0x4032FD2")]
		[FieldOffset(Offset = "0x40")]
		private string m_selectedEquipId;

		// Token: 0x04032FD3 RID: 208851
		[Token(Token = "0x4032FD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chessId;

		// Token: 0x04032FD4 RID: 208852
		[Token(Token = "0x4032FD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_chessLv;

		// Token: 0x04032FD5 RID: 208853
		[Token(Token = "0x4032FD5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_quickEditType;

		// Token: 0x04032FD6 RID: 208854
		[Token(Token = "0x4032FD6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_quickEditType;

		// Token: 0x04032FD7 RID: 208855
		[Token(Token = "0x4032FD7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedSkillId;

		// Token: 0x04032FD8 RID: 208856
		[Token(Token = "0x4032FD8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selectedSkillId;

		// Token: 0x04032FD9 RID: 208857
		[Token(Token = "0x4032FD9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectedEquipId;

		// Token: 0x04032FDA RID: 208858
		[Token(Token = "0x4032FDA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_selectedEquipId;

		// Token: 0x04032FDB RID: 208859
		[Token(Token = "0x4032FDB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_selectedEquipIndex;

		// Token: 0x04032FDC RID: 208860
		[Token(Token = "0x4032FDC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032FDD RID: 208861
		[Token(Token = "0x4032FDD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RefreshEditType;

		// Token: 0x04032FDE RID: 208862
		[Token(Token = "0x4032FDE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateSelectSkill;

		// Token: 0x04032FDF RID: 208863
		[Token(Token = "0x4032FDF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateSelectEquip;

		// Token: 0x04032FE0 RID: 208864
		[Token(Token = "0x4032FE0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadSkill;

		// Token: 0x04032FE1 RID: 208865
		[Token(Token = "0x4032FE1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateSkill;

		// Token: 0x04032FE2 RID: 208866
		[Token(Token = "0x4032FE2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__LoadEquip;

		// Token: 0x04032FE3 RID: 208867
		[Token(Token = "0x4032FE3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetSelectEquipIndex;

		// Token: 0x04032FE4 RID: 208868
		[Token(Token = "0x4032FE4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006311 RID: 25361
		[Token(Token = "0x2006311")]
		public class EquipItemViewModel : IComparable<AutoChessMultiCharSkillEquipEditItemViewModel.EquipItemViewModel>, IHotfixable
		{
			// Token: 0x060248CE RID: 149710 RVA: 0x000C4968 File Offset: 0x000C2B68
			[Token(Token = "0x60248CE")]
			[Address(RVA = "0x1F7DE40", Offset = "0x1F7CA40", VA = "0x181F7DE40", Slot = "4")]
			public int CompareTo(AutoChessMultiCharSkillEquipEditItemViewModel.EquipItemViewModel other)
			{
				return 0;
			}

			// Token: 0x060248CF RID: 149711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60248CF")]
			[Address(RVA = "0x1F7DEF0", Offset = "0x1F7CAF0", VA = "0x181F7DEF0")]
			public EquipItemViewModel()
			{
			}

			// Token: 0x04032FE5 RID: 208869
			[Token(Token = "0x4032FE5")]
			[FieldOffset(Offset = "0x10")]
			public UniEquipData equipData;

			// Token: 0x04032FE6 RID: 208870
			[Token(Token = "0x4032FE6")]
			[FieldOffset(Offset = "0x18")]
			public int equipLv;

			// Token: 0x04032FE7 RID: 208871
			[Token(Token = "0x4032FE7")]
			[FieldOffset(Offset = "0x1C")]
			public bool isAvail;

			// Token: 0x04032FE8 RID: 208872
			[Token(Token = "0x4032FE8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x04032FE9 RID: 208873
			[Token(Token = "0x4032FE9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
