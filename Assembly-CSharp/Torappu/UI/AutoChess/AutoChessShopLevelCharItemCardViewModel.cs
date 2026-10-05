using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006334 RID: 25396
	[Token(Token = "0x2006334")]
	public class AutoChessShopLevelCharItemCardViewModel : IHotfixable, IComparable<AutoChessShopLevelCharItemCardViewModel>
	{
		// Token: 0x1700565D RID: 22109
		// (get) Token: 0x060249E6 RID: 149990 RVA: 0x000C4E90 File Offset: 0x000C3090
		// (set) Token: 0x060249E7 RID: 149991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700565D")]
		public AutoChessShopLevelCharItemType itemType
		{
			[Token(Token = "0x60249E6")]
			[Address(RVA = "0x1F6F930", Offset = "0x1F6E530", VA = "0x181F6F930")]
			[CompilerGenerated]
			get
			{
				return AutoChessShopLevelCharItemType.NONE;
			}
			[Token(Token = "0x60249E7")]
			[Address(RVA = "0x1F6FDF0", Offset = "0x1F6E9F0", VA = "0x181F6FDF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700565E RID: 22110
		// (get) Token: 0x060249E8 RID: 149992 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060249E9 RID: 149993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700565E")]
		public string chessSlotId
		{
			[Token(Token = "0x60249E8")]
			[Address(RVA = "0x1F6F810", Offset = "0x1F6E410", VA = "0x181F6F810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60249E9")]
			[Address(RVA = "0x1F6FCF0", Offset = "0x1F6E8F0", VA = "0x181F6FCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700565F RID: 22111
		// (get) Token: 0x060249EA RID: 149994 RVA: 0x000C4EA8 File Offset: 0x000C30A8
		// (set) Token: 0x060249EB RID: 149995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700565F")]
		public int chessShopLv
		{
			[Token(Token = "0x60249EA")]
			[Address(RVA = "0x1F6F7B0", Offset = "0x1F6E3B0", VA = "0x181F6F7B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60249EB")]
			[Address(RVA = "0x1F6FC80", Offset = "0x1F6E880", VA = "0x181F6FC80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005660 RID: 22112
		// (get) Token: 0x060249EC RID: 149996 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060249ED RID: 149997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005660")]
		public AutoChessShopCharChessCardViewModel charCardViewModel
		{
			[Token(Token = "0x60249EC")]
			[Address(RVA = "0x1F6F750", Offset = "0x1F6E350", VA = "0x181F6F750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60249ED")]
			[Address(RVA = "0x1F6FC00", Offset = "0x1F6E800", VA = "0x181F6FC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005661 RID: 22113
		// (get) Token: 0x060249EE RID: 149998 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060249EF RID: 149999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005661")]
		public AutoChessShopCharChessDiyCardViewModel diyCharCardViewModel
		{
			[Token(Token = "0x60249EE")]
			[Address(RVA = "0x1F6F870", Offset = "0x1F6E470", VA = "0x181F6F870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60249EF")]
			[Address(RVA = "0x1F6FD70", Offset = "0x1F6E970", VA = "0x181F6FD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005662 RID: 22114
		// (get) Token: 0x060249F0 RID: 150000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005662")]
		public AutoChessMultiCharSkillEquipEditItemViewModel equipEditItemViewModel
		{
			[Token(Token = "0x60249F0")]
			[Address(RVA = "0x1F6F8D0", Offset = "0x1F6E4D0", VA = "0x181F6F8D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005663 RID: 22115
		// (get) Token: 0x060249F1 RID: 150001 RVA: 0x000C4EC0 File Offset: 0x000C30C0
		[Token(Token = "0x17005663")]
		public bool showQuickEditInfos
		{
			[Token(Token = "0x60249F1")]
			[Address(RVA = "0x1F6FB40", Offset = "0x1F6E740", VA = "0x181F6FB40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005664 RID: 22116
		// (get) Token: 0x060249F2 RID: 150002 RVA: 0x000C4ED8 File Offset: 0x000C30D8
		[Token(Token = "0x17005664")]
		public bool showNew
		{
			[Token(Token = "0x60249F2")]
			[Address(RVA = "0x1F6F9F0", Offset = "0x1F6E5F0", VA = "0x181F6F9F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005665 RID: 22117
		// (get) Token: 0x060249F3 RID: 150003 RVA: 0x000C4EF0 File Offset: 0x000C30F0
		// (set) Token: 0x060249F4 RID: 150004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005665")]
		public AutoChessShopQuickEditType quickEditType
		{
			[Token(Token = "0x60249F3")]
			[Address(RVA = "0x1F6F990", Offset = "0x1F6E590", VA = "0x181F6F990")]
			[CompilerGenerated]
			get
			{
				return AutoChessShopQuickEditType.NONE;
			}
			[Token(Token = "0x60249F4")]
			[Address(RVA = "0x1F6FE60", Offset = "0x1F6EA60", VA = "0x181F6FE60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060249F5 RID: 150005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249F5")]
		[Address(RVA = "0x1F6DF80", Offset = "0x1F6CB80", VA = "0x181F6DF80")]
		public void LoadCharCardData(string actId, AutoChessShopCharChessCardViewModel cardViewModel)
		{
		}

		// Token: 0x060249F6 RID: 150006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249F6")]
		[Address(RVA = "0x1F6E360", Offset = "0x1F6CF60", VA = "0x181F6E360")]
		public void LoadDiyCardData(string actId, AutoChessShopCharChessDiyCardViewModel diyCardViewModel)
		{
		}

		// Token: 0x060249F7 RID: 150007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249F7")]
		[Address(RVA = "0x1F6E9B0", Offset = "0x1F6D5B0", VA = "0x181F6E9B0")]
		public void RefreshCharCardByPlayerData(Dictionary<string, ActAutoChessData.ActAutoChessGarrisonData> garrisonDict, Dictionary<string, ActAutoChessData.ActAutoChessBondInfo> bondInfoDict, Dictionary<string, ActAutoChessData.ActAutoChessCharChessData> charChessDataDict, ListDict<string, ActAutoChessData.ActAutoChessCharShopChessData> charShopChessDatas, Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessPlayerDataPool)
		{
		}

		// Token: 0x060249F8 RID: 150008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249F8")]
		[Address(RVA = "0x1F6F3B0", Offset = "0x1F6DFB0", VA = "0x181F6F3B0")]
		public void RefreshEditQuickEditType(AutoChessShopQuickEditType editType)
		{
		}

		// Token: 0x060249F9 RID: 150009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249F9")]
		[Address(RVA = "0x1F6F130", Offset = "0x1F6DD30", VA = "0x181F6F130")]
		public void RefreshCharCardSkillId(string newSkillId)
		{
		}

		// Token: 0x060249FA RID: 150010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249FA")]
		[Address(RVA = "0x1F6ED20", Offset = "0x1F6D920", VA = "0x181F6ED20")]
		public void RefreshCharCardEquipId(string newEquipId)
		{
		}

		// Token: 0x060249FB RID: 150011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249FB")]
		[Address(RVA = "0x1F6EE70", Offset = "0x1F6DA70", VA = "0x181F6EE70")]
		public void RefreshCharCardIsNewTag(bool isNew)
		{
		}

		// Token: 0x060249FC RID: 150012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249FC")]
		[Address(RVA = "0x1F6F280", Offset = "0x1F6DE80", VA = "0x181F6F280")]
		public void RefreshDiyCardByPlayerData(int curPlayerDiyCnt)
		{
		}

		// Token: 0x060249FD RID: 150013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249FD")]
		[Address(RVA = "0x1F6E5F0", Offset = "0x1F6D1F0", VA = "0x181F6E5F0")]
		public void RefreshCardByViewStatusChange(AutoChessShopStatus shopStatus)
		{
		}

		// Token: 0x060249FE RID: 150014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249FE")]
		[Address(RVA = "0x1F6EFD0", Offset = "0x1F6DBD0", VA = "0x181F6EFD0")]
		public void RefreshCharCardSelectTag(bool isSelected)
		{
		}

		// Token: 0x060249FF RID: 150015 RVA: 0x000C4F08 File Offset: 0x000C3108
		[Token(Token = "0x60249FF")]
		[Address(RVA = "0x1F6DD40", Offset = "0x1F6C940", VA = "0x181F6DD40", Slot = "4")]
		public int CompareTo(AutoChessShopLevelCharItemCardViewModel other)
		{
			return 0;
		}

		// Token: 0x06024A00 RID: 150016 RVA: 0x000C4F20 File Offset: 0x000C3120
		[Token(Token = "0x6024A00")]
		[Address(RVA = "0x1F6F540", Offset = "0x1F6E140", VA = "0x181F6F540")]
		private AutoChessShopCharChessCardViewModel.InputShowAndClickParams _GenerateCharChessInputParams(AutoChessShopStatus shopStatus)
		{
			return default(AutoChessShopCharChessCardViewModel.InputShowAndClickParams);
		}

		// Token: 0x06024A01 RID: 150017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A01")]
		[Address(RVA = "0x1F6F6F0", Offset = "0x1F6E2F0", VA = "0x181F6F6F0")]
		public AutoChessShopLevelCharItemCardViewModel()
		{
		}

		// Token: 0x04033182 RID: 209282
		[Token(Token = "0x4033182")]
		[FieldOffset(Offset = "0x40")]
		private string m_actId;

		// Token: 0x04033183 RID: 209283
		[Token(Token = "0x4033183")]
		[FieldOffset(Offset = "0x48")]
		private AutoChessMultiCharSkillEquipEditItemViewModel m_equipEditItemViewModel;

		// Token: 0x04033184 RID: 209284
		[Token(Token = "0x4033184")]
		[FieldOffset(Offset = "0x50")]
		private AutoChessShopStatus m_cachedShopStatus;

		// Token: 0x04033185 RID: 209285
		[Token(Token = "0x4033185")]
		[FieldOffset(Offset = "0x54")]
		private int m_cachedCurPlayerDiyCnt;

		// Token: 0x04033186 RID: 209286
		[Token(Token = "0x4033186")]
		[FieldOffset(Offset = "0x58")]
		private AutoChessShopCharChessCardViewModel.InputShowAndClickParams m_cachedCharCardShowAndClickParams;

		// Token: 0x04033187 RID: 209287
		[Token(Token = "0x4033187")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x04033188 RID: 209288
		[Token(Token = "0x4033188")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemType;

		// Token: 0x04033189 RID: 209289
		[Token(Token = "0x4033189")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_chessSlotId;

		// Token: 0x0403318A RID: 209290
		[Token(Token = "0x403318A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_chessSlotId;

		// Token: 0x0403318B RID: 209291
		[Token(Token = "0x403318B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_chessShopLv;

		// Token: 0x0403318C RID: 209292
		[Token(Token = "0x403318C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_chessShopLv;

		// Token: 0x0403318D RID: 209293
		[Token(Token = "0x403318D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_charCardViewModel;

		// Token: 0x0403318E RID: 209294
		[Token(Token = "0x403318E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_charCardViewModel;

		// Token: 0x0403318F RID: 209295
		[Token(Token = "0x403318F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_diyCharCardViewModel;

		// Token: 0x04033190 RID: 209296
		[Token(Token = "0x4033190")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_diyCharCardViewModel;

		// Token: 0x04033191 RID: 209297
		[Token(Token = "0x4033191")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_equipEditItemViewModel;

		// Token: 0x04033192 RID: 209298
		[Token(Token = "0x4033192")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_showQuickEditInfos;

		// Token: 0x04033193 RID: 209299
		[Token(Token = "0x4033193")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_showNew;

		// Token: 0x04033194 RID: 209300
		[Token(Token = "0x4033194")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_quickEditType;

		// Token: 0x04033195 RID: 209301
		[Token(Token = "0x4033195")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_quickEditType;

		// Token: 0x04033196 RID: 209302
		[Token(Token = "0x4033196")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LoadCharCardData;

		// Token: 0x04033197 RID: 209303
		[Token(Token = "0x4033197")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadDiyCardData;

		// Token: 0x04033198 RID: 209304
		[Token(Token = "0x4033198")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_RefreshCharCardByPlayerData;

		// Token: 0x04033199 RID: 209305
		[Token(Token = "0x4033199")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_RefreshEditQuickEditType;

		// Token: 0x0403319A RID: 209306
		[Token(Token = "0x403319A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_RefreshCharCardSkillId;

		// Token: 0x0403319B RID: 209307
		[Token(Token = "0x403319B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RefreshCharCardEquipId;

		// Token: 0x0403319C RID: 209308
		[Token(Token = "0x403319C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_RefreshCharCardIsNewTag;

		// Token: 0x0403319D RID: 209309
		[Token(Token = "0x403319D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RefreshDiyCardByPlayerData;

		// Token: 0x0403319E RID: 209310
		[Token(Token = "0x403319E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RefreshCardByViewStatusChange;

		// Token: 0x0403319F RID: 209311
		[Token(Token = "0x403319F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_RefreshCharCardSelectTag;

		// Token: 0x040331A0 RID: 209312
		[Token(Token = "0x40331A0")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040331A1 RID: 209313
		[Token(Token = "0x40331A1")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GenerateCharChessInputParams;

		// Token: 0x040331A2 RID: 209314
		[Token(Token = "0x40331A2")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
