using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C48 RID: 15432
	[Token(Token = "0x2003C48")]
	public class UniEquipUnlockViewModel : IHotfixable
	{
		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x060181F6 RID: 98806 RVA: 0x00099750 File Offset: 0x00097950
		// (set) Token: 0x060181F5 RID: 98805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700399F")]
		public bool isPreview
		{
			[Token(Token = "0x60181F6")]
			[Address(RVA = "0x10A2380", Offset = "0x10A0F80", VA = "0x1810A2380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60181F5")]
			[Address(RVA = "0x10A24B0", Offset = "0x10A10B0", VA = "0x1810A24B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x060181F7 RID: 98807 RVA: 0x00099768 File Offset: 0x00097968
		[Token(Token = "0x170039A0")]
		public bool isSpecialOperator
		{
			[Token(Token = "0x60181F7")]
			[Address(RVA = "0x10A23E0", Offset = "0x10A0FE0", VA = "0x1810A23E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x060181F8 RID: 98808 RVA: 0x00099780 File Offset: 0x00097980
		[Token(Token = "0x170039A1")]
		public int infoCount
		{
			[Token(Token = "0x60181F8")]
			[Address(RVA = "0x10A22A0", Offset = "0x10A0EA0", VA = "0x1810A22A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x060181F9 RID: 98809 RVA: 0x00099798 File Offset: 0x00097998
		[Token(Token = "0x170039A2")]
		public int infoPreviewCount
		{
			[Token(Token = "0x60181F9")]
			[Address(RVA = "0x10A2310", Offset = "0x10A0F10", VA = "0x1810A2310")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x060181FB RID: 98811 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060181FA RID: 98810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170039A3")]
		public List<RequireViewModel> requireViewModels
		{
			[Token(Token = "0x60181FB")]
			[Address(RVA = "0x10A2450", Offset = "0x10A1050", VA = "0x1810A2450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60181FA")]
			[Address(RVA = "0x10A2520", Offset = "0x10A1120", VA = "0x1810A2520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x060181FC RID: 98812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039A4")]
		public string equipName
		{
			[Token(Token = "0x60181FC")]
			[Address(RVA = "0x10A2210", Offset = "0x10A0E10", VA = "0x1810A2210")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x060181FD RID: 98813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039A5")]
		public string equipId
		{
			[Token(Token = "0x60181FD")]
			[Address(RVA = "0x10A2180", Offset = "0x10A0D80", VA = "0x1810A2180")]
			get
			{
				return null;
			}
		}

		// Token: 0x060181FE RID: 98814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181FE")]
		[Address(RVA = "0x10A0C30", Offset = "0x109F830", VA = "0x1810A0C30")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x060181FF RID: 98815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181FF")]
		[Address(RVA = "0x10A0D30", Offset = "0x109F930", VA = "0x1810A0D30")]
		public void RefreshRequires()
		{
		}

		// Token: 0x06018200 RID: 98816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018200")]
		[Address(RVA = "0x10A0D90", Offset = "0x109F990", VA = "0x1810A0D90")]
		public void SetPreviewTrans()
		{
		}

		// Token: 0x06018201 RID: 98817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018201")]
		[Address(RVA = "0x10A0E90", Offset = "0x109FA90", VA = "0x1810A0E90")]
		private void _GeneInfoData(PlayerCharacter playerChar, CharacterData charData, int equipLevel)
		{
		}

		// Token: 0x06018202 RID: 98818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018202")]
		[Address(RVA = "0x10A1D60", Offset = "0x10A0960", VA = "0x1810A1D60")]
		private void _GeneRequireViewModels()
		{
		}

		// Token: 0x06018203 RID: 98819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018203")]
		[Address(RVA = "0x10A2000", Offset = "0x10A0C00", VA = "0x1810A2000")]
		public UniEquipUnlockViewModel()
		{
		}

		// Token: 0x0401D500 RID: 120064
		[Token(Token = "0x401D500")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x0401D501 RID: 120065
		[Token(Token = "0x401D501")]
		[FieldOffset(Offset = "0x18")]
		public string templateId;

		// Token: 0x0401D502 RID: 120066
		[Token(Token = "0x401D502")]
		[FieldOffset(Offset = "0x20")]
		public UniEquipData uniEquipData;

		// Token: 0x0401D503 RID: 120067
		[Token(Token = "0x401D503")]
		[FieldOffset(Offset = "0x28")]
		public string subProfessionId;

		// Token: 0x0401D504 RID: 120068
		[Token(Token = "0x401D504")]
		[FieldOffset(Offset = "0x30")]
		public List<UniEquipMissionData> uniEquipMissionList;

		// Token: 0x0401D505 RID: 120069
		[Token(Token = "0x401D505")]
		[FieldOffset(Offset = "0x38")]
		public List<UniEquipUnlockViewModel.InfoData> infoList;

		// Token: 0x0401D506 RID: 120070
		[Token(Token = "0x401D506")]
		[FieldOffset(Offset = "0x40")]
		public List<UniEquipUnlockViewModel.InfoData> infoListPreview;

		// Token: 0x0401D507 RID: 120071
		[Token(Token = "0x401D507")]
		[FieldOffset(Offset = "0x48")]
		public SpecialOperatorInfoViewModel spOpModel;

		// Token: 0x0401D509 RID: 120073
		[Token(Token = "0x401D509")]
		[FieldOffset(Offset = "0x58")]
		private PlayerCharacter m_playerChar;

		// Token: 0x0401D50B RID: 120075
		[Token(Token = "0x401D50B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_isPreview;

		// Token: 0x0401D50C RID: 120076
		[Token(Token = "0x401D50C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isPreview;

		// Token: 0x0401D50D RID: 120077
		[Token(Token = "0x401D50D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isSpecialOperator;

		// Token: 0x0401D50E RID: 120078
		[Token(Token = "0x401D50E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_infoCount;

		// Token: 0x0401D50F RID: 120079
		[Token(Token = "0x401D50F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_infoPreviewCount;

		// Token: 0x0401D510 RID: 120080
		[Token(Token = "0x401D510")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_requireViewModels;

		// Token: 0x0401D511 RID: 120081
		[Token(Token = "0x401D511")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_requireViewModels;

		// Token: 0x0401D512 RID: 120082
		[Token(Token = "0x401D512")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_equipName;

		// Token: 0x0401D513 RID: 120083
		[Token(Token = "0x401D513")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_equipId;

		// Token: 0x0401D514 RID: 120084
		[Token(Token = "0x401D514")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D515 RID: 120085
		[Token(Token = "0x401D515")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RefreshRequires;

		// Token: 0x0401D516 RID: 120086
		[Token(Token = "0x401D516")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetPreviewTrans;

		// Token: 0x0401D517 RID: 120087
		[Token(Token = "0x401D517")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GeneInfoData;

		// Token: 0x0401D518 RID: 120088
		[Token(Token = "0x401D518")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GeneRequireViewModels;

		// Token: 0x0401D519 RID: 120089
		[Token(Token = "0x401D519")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C49 RID: 15433
		[Token(Token = "0x2003C49")]
		public class InfoData
		{
			// Token: 0x06018204 RID: 98820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018204")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InfoData()
			{
			}

			// Token: 0x0401D51A RID: 120090
			[Token(Token = "0x401D51A")]
			[FieldOffset(Offset = "0x10")]
			public string title;

			// Token: 0x0401D51B RID: 120091
			[Token(Token = "0x401D51B")]
			[FieldOffset(Offset = "0x18")]
			public string desc;
		}
	}
}
