using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063B1 RID: 25521
	[Token(Token = "0x20063B1")]
	public class AutoChessCharSelectCardViewModel : TemplateCharSelectCardViewModel, AutoChessShopCharChessCardViewModel.ICharInfo
	{
		// Token: 0x170056CD RID: 22221
		// (get) Token: 0x06024C9C RID: 150684 RVA: 0x000C5760 File Offset: 0x000C3960
		// (set) Token: 0x06024C9D RID: 150685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056CD")]
		public int localInstId
		{
			[Token(Token = "0x6024C9C")]
			[Address(RVA = "0x1F99D60", Offset = "0x1F98960", VA = "0x181F99D60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024C9D")]
			[Address(RVA = "0x1F9A3D0", Offset = "0x1F98FD0", VA = "0x181F9A3D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170056CE RID: 22222
		// (get) Token: 0x06024C9E RID: 150686 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024C9F RID: 150687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056CE")]
		public AutoChessData systemData
		{
			[Token(Token = "0x6024C9E")]
			[Address(RVA = "0x1F9A090", Offset = "0x1F98C90", VA = "0x181F9A090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024C9F")]
			[Address(RVA = "0x1F9A670", Offset = "0x1F99270", VA = "0x181F9A670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170056CF RID: 22223
		// (get) Token: 0x06024CA0 RID: 150688 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CA1 RID: 150689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056CF")]
		public ActAutoChessData activityData
		{
			[Token(Token = "0x6024CA0")]
			[Address(RVA = "0x1F999E0", Offset = "0x1F985E0", VA = "0x181F999E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CA1")]
			[Address(RVA = "0x1F9A0F0", Offset = "0x1F98CF0", VA = "0x181F9A0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170056D0 RID: 22224
		// (get) Token: 0x06024CA2 RID: 150690 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CA3 RID: 150691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056D0")]
		public ActAutoChessData.ActAutoChessCharShopChessData shopChessData
		{
			[Token(Token = "0x6024CA2")]
			[Address(RVA = "0x1F99F10", Offset = "0x1F98B10", VA = "0x181F99F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CA3")]
			[Address(RVA = "0x1F9A530", Offset = "0x1F99130", VA = "0x181F9A530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170056D1 RID: 22225
		// (get) Token: 0x06024CA4 RID: 150692 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CA5 RID: 150693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056D1")]
		public ActAutoChessData.ActAutoChessCharChessStatusData chessNormalStatusData
		{
			[Token(Token = "0x6024CA4")]
			[Address(RVA = "0x1F99B90", Offset = "0x1F98790", VA = "0x181F99B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CA5")]
			[Address(RVA = "0x1F9A290", Offset = "0x1F98E90", VA = "0x181F9A290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170056D2 RID: 22226
		// (get) Token: 0x06024CA6 RID: 150694 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CA7 RID: 150695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056D2")]
		public ActAutoChessData.ActAutoChessCharChessStatusData chessGoldenStatusData
		{
			[Token(Token = "0x6024CA6")]
			[Address(RVA = "0x1F99B30", Offset = "0x1F98730", VA = "0x181F99B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CA7")]
			[Address(RVA = "0x1F9A210", Offset = "0x1F98E10", VA = "0x181F9A210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170056D3 RID: 22227
		// (get) Token: 0x06024CA8 RID: 150696 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CA9 RID: 150697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056D3")]
		public ActAutoChessData.ActAutoChessCharShopChessData originChess
		{
			[Token(Token = "0x6024CA8")]
			[Address(RVA = "0x1F99E50", Offset = "0x1F98A50", VA = "0x181F99E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CA9")]
			[Address(RVA = "0x1F9A440", Offset = "0x1F99040", VA = "0x181F9A440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170056D4 RID: 22228
		// (get) Token: 0x06024CAA RID: 150698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056D4")]
		public override ICharacterCardViewModel charBaseModel
		{
			[Token(Token = "0x6024CAA")]
			[Address(RVA = "0x1F99A40", Offset = "0x1F98640", VA = "0x181F99A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170056D5 RID: 22229
		// (get) Token: 0x06024CAB RID: 150699 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CAC RID: 150700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056D5")]
		public override string skillId
		{
			[Token(Token = "0x6024CAB")]
			[Address(RVA = "0x1F99F70", Offset = "0x1F98B70", VA = "0x181F99F70", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CAC")]
			[Address(RVA = "0x1F9A5B0", Offset = "0x1F991B0", VA = "0x181F9A5B0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x170056D6 RID: 22230
		// (get) Token: 0x06024CAD RID: 150701 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CAE RID: 150702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056D6")]
		public override string equipId
		{
			[Token(Token = "0x6024CAD")]
			[Address(RVA = "0x1F99D00", Offset = "0x1F98900", VA = "0x181F99D00", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CAE")]
			[Address(RVA = "0x1F9A310", Offset = "0x1F98F10", VA = "0x181F9A310", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06024CAF RID: 150703 RVA: 0x000C5778 File Offset: 0x000C3978
		[Token(Token = "0x6024CAF")]
		[Address(RVA = "0x1F97B60", Offset = "0x1F96760", VA = "0x181F97B60", Slot = "5")]
		public override AttackRangeDescModel GetAttackRange()
		{
			return default(AttackRangeDescModel);
		}

		// Token: 0x06024CB0 RID: 150704 RVA: 0x000C5790 File Offset: 0x000C3990
		[Token(Token = "0x6024CB0")]
		[Address(RVA = "0x1F97C00", Offset = "0x1F96800", VA = "0x181F97C00", Slot = "11")]
		public override int GetInstId()
		{
			return 0;
		}

		// Token: 0x06024CB1 RID: 150705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CB1")]
		[Address(RVA = "0x1F99620", Offset = "0x1F98220", VA = "0x181F99620", Slot = "10")]
		public override void SynWithPlayerData(TemplateCharSelectController.InputParam cacheInput)
		{
		}

		// Token: 0x06024CB2 RID: 150706 RVA: 0x000C57A8 File Offset: 0x000C39A8
		[Token(Token = "0x6024CB2")]
		[Address(RVA = "0x1F97CF0", Offset = "0x1F968F0", VA = "0x181F97CF0")]
		public bool Load(AutoChessCharSelectCardViewModel.InitParam initParam)
		{
			return default(bool);
		}

		// Token: 0x06024CB3 RID: 150707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CB3")]
		[Address(RVA = "0x1F99690", Offset = "0x1F98290", VA = "0x181F99690")]
		private void _UpdateSkillIndex()
		{
		}

		// Token: 0x06024CB4 RID: 150708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CB4")]
		[Address(RVA = "0x1F99590", Offset = "0x1F98190", VA = "0x181F99590", Slot = "14")]
		protected override void OnSelectChanged(bool sel)
		{
		}

		// Token: 0x170056D7 RID: 22231
		// (get) Token: 0x06024CB5 RID: 150709 RVA: 0x000C57C0 File Offset: 0x000C39C0
		// (set) Token: 0x06024CB6 RID: 150710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056D7")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6024CB5")]
			[Address(RVA = "0x1F99AA0", Offset = "0x1F986A0", VA = "0x181F99AA0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x6024CB6")]
			[Address(RVA = "0x1F9A170", Offset = "0x1F98D70", VA = "0x181F9A170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170056D8 RID: 22232
		// (get) Token: 0x06024CB7 RID: 150711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056D8")]
		public string skinId
		{
			[Token(Token = "0x6024CB7")]
			[Address(RVA = "0x1F9A030", Offset = "0x1F98C30", VA = "0x181F9A030", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170056D9 RID: 22233
		// (get) Token: 0x06024CB8 RID: 150712 RVA: 0x000C57D8 File Offset: 0x000C39D8
		[Token(Token = "0x170056D9")]
		public int skillIndex
		{
			[Token(Token = "0x6024CB8")]
			[Address(RVA = "0x1F99FD0", Offset = "0x1F98BD0", VA = "0x181F99FD0", Slot = "23")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170056DA RID: 22234
		// (get) Token: 0x06024CB9 RID: 150713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056DA")]
		public string currentEquip
		{
			[Token(Token = "0x6024CB9")]
			[Address(RVA = "0x1F99CA0", Offset = "0x1F988A0", VA = "0x181F99CA0", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x170056DB RID: 22235
		// (get) Token: 0x06024CBA RID: 150714 RVA: 0x000C57F0 File Offset: 0x000C39F0
		// (set) Token: 0x06024CBB RID: 150715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056DB")]
		public int potentialRank
		{
			[Token(Token = "0x6024CBA")]
			[Address(RVA = "0x1F99EB0", Offset = "0x1F98AB0", VA = "0x181F99EB0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024CBB")]
			[Address(RVA = "0x1F9A4C0", Offset = "0x1F990C0", VA = "0x181F9A4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170056DC RID: 22236
		// (get) Token: 0x06024CBC RID: 150716 RVA: 0x000C5808 File Offset: 0x000C3A08
		[Token(Token = "0x170056DC")]
		public PlayerActivity.PlayerActAutoChessActivity.AutoChessCharType chessType
		{
			[Token(Token = "0x6024CBC")]
			[Address(RVA = "0x1F99BF0", Offset = "0x1F987F0", VA = "0x181F99BF0", Slot = "20")]
			get
			{
				return PlayerActivity.PlayerActAutoChessActivity.AutoChessCharType.OWN;
			}
		}

		// Token: 0x170056DD RID: 22237
		// (get) Token: 0x06024CBD RID: 150717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056DD")]
		public ActAutoChessData.ActAutoChessCharShopChessData originChessShopData
		{
			[Token(Token = "0x6024CBD")]
			[Address(RVA = "0x1F99DC0", Offset = "0x1F989C0", VA = "0x181F99DC0", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024CBE RID: 150718 RVA: 0x000C5820 File Offset: 0x000C3A20
		[Token(Token = "0x6024CBE")]
		[Address(RVA = "0x1F97C90", Offset = "0x1F96890", VA = "0x181F97C90", Slot = "18")]
		public bool LoadCharInfo()
		{
			return default(bool);
		}

		// Token: 0x06024CBF RID: 150719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CBF")]
		[Address(RVA = "0x1F99930", Offset = "0x1F98530", VA = "0x181F99930")]
		public AutoChessCharSelectCardViewModel()
		{
		}

		// Token: 0x06024CC0 RID: 150720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CC0")]
		[Address(RVA = "0x1F99680", Offset = "0x1F98280", VA = "0x181F99680")]
		private void <>xLuaBaseProxy_OnSelectChanged(bool P0)
		{
		}

		// Token: 0x040336B3 RID: 210611
		[Token(Token = "0x40336B3")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessShopCharChessCardViewModel chessModel;

		// Token: 0x040336BA RID: 210618
		[Token(Token = "0x40336BA")]
		[FieldOffset(Offset = "0x68")]
		private DefaultCommonCharCardViewModel m_basicCharModel;

		// Token: 0x040336BB RID: 210619
		[Token(Token = "0x40336BB")]
		[FieldOffset(Offset = "0x70")]
		private string m_skillId;

		// Token: 0x040336BC RID: 210620
		[Token(Token = "0x40336BC")]
		[FieldOffset(Offset = "0x78")]
		private int m_skillIndex;

		// Token: 0x040336BD RID: 210621
		[Token(Token = "0x40336BD")]
		[FieldOffset(Offset = "0x80")]
		private string m_equipId;

		// Token: 0x040336BE RID: 210622
		[Token(Token = "0x40336BE")]
		[FieldOffset(Offset = "0x88")]
		private string m_skin;

		// Token: 0x040336C1 RID: 210625
		[Token(Token = "0x40336C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_localInstId;

		// Token: 0x040336C2 RID: 210626
		[Token(Token = "0x40336C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_localInstId;

		// Token: 0x040336C3 RID: 210627
		[Token(Token = "0x40336C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_systemData;

		// Token: 0x040336C4 RID: 210628
		[Token(Token = "0x40336C4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_systemData;

		// Token: 0x040336C5 RID: 210629
		[Token(Token = "0x40336C5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_activityData;

		// Token: 0x040336C6 RID: 210630
		[Token(Token = "0x40336C6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_activityData;

		// Token: 0x040336C7 RID: 210631
		[Token(Token = "0x40336C7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_shopChessData;

		// Token: 0x040336C8 RID: 210632
		[Token(Token = "0x40336C8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_shopChessData;

		// Token: 0x040336C9 RID: 210633
		[Token(Token = "0x40336C9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_chessNormalStatusData;

		// Token: 0x040336CA RID: 210634
		[Token(Token = "0x40336CA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_chessNormalStatusData;

		// Token: 0x040336CB RID: 210635
		[Token(Token = "0x40336CB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_chessGoldenStatusData;

		// Token: 0x040336CC RID: 210636
		[Token(Token = "0x40336CC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_chessGoldenStatusData;

		// Token: 0x040336CD RID: 210637
		[Token(Token = "0x40336CD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_originChess;

		// Token: 0x040336CE RID: 210638
		[Token(Token = "0x40336CE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_originChess;

		// Token: 0x040336CF RID: 210639
		[Token(Token = "0x40336CF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_charBaseModel;

		// Token: 0x040336D0 RID: 210640
		[Token(Token = "0x40336D0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_skillId;

		// Token: 0x040336D1 RID: 210641
		[Token(Token = "0x40336D1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_skillId;

		// Token: 0x040336D2 RID: 210642
		[Token(Token = "0x40336D2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_equipId;

		// Token: 0x040336D3 RID: 210643
		[Token(Token = "0x40336D3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_equipId;

		// Token: 0x040336D4 RID: 210644
		[Token(Token = "0x40336D4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetAttackRange;

		// Token: 0x040336D5 RID: 210645
		[Token(Token = "0x40336D5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetInstId;

		// Token: 0x040336D6 RID: 210646
		[Token(Token = "0x40336D6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SynWithPlayerData;

		// Token: 0x040336D7 RID: 210647
		[Token(Token = "0x40336D7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x040336D8 RID: 210648
		[Token(Token = "0x40336D8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__UpdateSkillIndex;

		// Token: 0x040336D9 RID: 210649
		[Token(Token = "0x40336D9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnSelectChanged;

		// Token: 0x040336DA RID: 210650
		[Token(Token = "0x40336DA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x040336DB RID: 210651
		[Token(Token = "0x40336DB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x040336DC RID: 210652
		[Token(Token = "0x40336DC")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_skinId;

		// Token: 0x040336DD RID: 210653
		[Token(Token = "0x40336DD")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_skillIndex;

		// Token: 0x040336DE RID: 210654
		[Token(Token = "0x40336DE")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_currentEquip;

		// Token: 0x040336DF RID: 210655
		[Token(Token = "0x40336DF")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_potentialRank;

		// Token: 0x040336E0 RID: 210656
		[Token(Token = "0x40336E0")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_potentialRank;

		// Token: 0x040336E1 RID: 210657
		[Token(Token = "0x40336E1")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_chessType;

		// Token: 0x040336E2 RID: 210658
		[Token(Token = "0x40336E2")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_originChessShopData;

		// Token: 0x040336E3 RID: 210659
		[Token(Token = "0x40336E3")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_LoadCharInfo;

		// Token: 0x040336E4 RID: 210660
		[Token(Token = "0x40336E4")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020063B2 RID: 25522
		[Token(Token = "0x20063B2")]
		public struct InitParam
		{
			// Token: 0x040336E5 RID: 210661
			[Token(Token = "0x40336E5")]
			[FieldOffset(Offset = "0x0")]
			public string actId;

			// Token: 0x040336E6 RID: 210662
			[Token(Token = "0x40336E6")]
			[FieldOffset(Offset = "0x8")]
			public AutoChessData systemData;

			// Token: 0x040336E7 RID: 210663
			[Token(Token = "0x40336E7")]
			[FieldOffset(Offset = "0x10")]
			public ActAutoChessData actData;

			// Token: 0x040336E8 RID: 210664
			[Token(Token = "0x40336E8")]
			[FieldOffset(Offset = "0x18")]
			public CharQuery charQuery;

			// Token: 0x040336E9 RID: 210665
			[Token(Token = "0x40336E9")]
			[FieldOffset(Offset = "0x30")]
			public int potentialRank;

			// Token: 0x040336EA RID: 210666
			[Token(Token = "0x40336EA")]
			[FieldOffset(Offset = "0x34")]
			public int skillIndex;

			// Token: 0x040336EB RID: 210667
			[Token(Token = "0x40336EB")]
			[FieldOffset(Offset = "0x38")]
			public string currEquip;

			// Token: 0x040336EC RID: 210668
			[Token(Token = "0x40336EC")]
			[FieldOffset(Offset = "0x40")]
			public string skin;

			// Token: 0x040336ED RID: 210669
			[Token(Token = "0x40336ED")]
			[FieldOffset(Offset = "0x48")]
			public ActAutoChessData.ActAutoChessCharShopChessData forChess;

			// Token: 0x040336EE RID: 210670
			[Token(Token = "0x40336EE")]
			[FieldOffset(Offset = "0x50")]
			public ActAutoChessData.ActAutoChessCharShopChessData inChess;

			// Token: 0x040336EF RID: 210671
			[Token(Token = "0x40336EF")]
			[FieldOffset(Offset = "0x58")]
			public ActAutoChessData.ActAutoChessCharShopChessData originChess;
		}
	}
}
