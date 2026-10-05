using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EFF RID: 24319
	[Token(Token = "0x2005EFF")]
	public class CharacterInfoHolderBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x17005357 RID: 21335
		// (get) Token: 0x060233C8 RID: 144328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005357")]
		public CharacterInfoHolderBean.CultivateViewModel currentFocusCultivateViewModel
		{
			[Token(Token = "0x60233C8")]
			[Address(RVA = "0x1DC1910", Offset = "0x1DC0510", VA = "0x181DC1910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005358 RID: 21336
		// (get) Token: 0x060233C9 RID: 144329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005358")]
		public CharacterInfoHolderBean.CharViewModel currentFocusCharViewModel
		{
			[Token(Token = "0x60233C9")]
			[Address(RVA = "0x1DC1810", Offset = "0x1DC0410", VA = "0x181DC1810")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005359 RID: 21337
		// (get) Token: 0x060233CA RID: 144330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005359")]
		public CharInfoGroupProperty property
		{
			[Token(Token = "0x60233CA")]
			[Address(RVA = "0x1DC1A10", Offset = "0x1DC0610", VA = "0x181DC1A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060233CB RID: 144331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233CB")]
		[Address(RVA = "0x1DC1210", Offset = "0x1DBFE10", VA = "0x181DC1210")]
		public void InitData(ICharInfoHomeInitParam param)
		{
		}

		// Token: 0x060233CC RID: 144332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233CC")]
		[Address(RVA = "0x1DC1610", Offset = "0x1DC0210", VA = "0x181DC1610")]
		public void SetFocus(int focusIndex)
		{
		}

		// Token: 0x060233CD RID: 144333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233CD")]
		[Address(RVA = "0x1DC1550", Offset = "0x1DC0150", VA = "0x181DC1550")]
		public void RefreshInstId(int instId)
		{
		}

		// Token: 0x060233CE RID: 144334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233CE")]
		[Address(RVA = "0x1DC14A0", Offset = "0x1DC00A0", VA = "0x181DC14A0")]
		public void RefreshCurrentFocus()
		{
		}

		// Token: 0x060233CF RID: 144335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233CF")]
		[Address(RVA = "0x1DC1150", Offset = "0x1DBFD50", VA = "0x181DC1150")]
		public void ClearData()
		{
		}

		// Token: 0x060233D0 RID: 144336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233D0")]
		[Address(RVA = "0x1DC1720", Offset = "0x1DC0320", VA = "0x181DC1720")]
		public CharacterInfoHolderBean()
		{
		}

		// Token: 0x040308C3 RID: 198851
		[Token(Token = "0x40308C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharInfoGroupProperty _property;

		// Token: 0x040308C4 RID: 198852
		[Token(Token = "0x40308C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentFocusCultivateViewModel;

		// Token: 0x040308C5 RID: 198853
		[Token(Token = "0x40308C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentFocusCharViewModel;

		// Token: 0x040308C6 RID: 198854
		[Token(Token = "0x40308C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x040308C7 RID: 198855
		[Token(Token = "0x40308C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040308C8 RID: 198856
		[Token(Token = "0x40308C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetFocus;

		// Token: 0x040308C9 RID: 198857
		[Token(Token = "0x40308C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshInstId;

		// Token: 0x040308CA RID: 198858
		[Token(Token = "0x40308CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshCurrentFocus;

		// Token: 0x040308CB RID: 198859
		[Token(Token = "0x40308CB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ClearData;

		// Token: 0x040308CC RID: 198860
		[Token(Token = "0x40308CC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F00 RID: 24320
		[Token(Token = "0x2005F00")]
		public class CultivateViewModel
		{
			// Token: 0x1700535A RID: 21338
			// (get) Token: 0x060233D1 RID: 144337 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700535A")]
			public string charName
			{
				[Token(Token = "0x60233D1")]
				[Address(RVA = "0x1DD0E50", Offset = "0x1DCFA50", VA = "0x181DD0E50")]
				get
				{
					return null;
				}
			}

			// Token: 0x060233D2 RID: 144338 RVA: 0x000C0348 File Offset: 0x000BE548
			[Token(Token = "0x60233D2")]
			[Address(RVA = "0x1DCFD50", Offset = "0x1DCE950", VA = "0x181DCFD50")]
			public CharQuery GetCharQuery()
			{
				return default(CharQuery);
			}

			// Token: 0x060233D3 RID: 144339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233D3")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			public void SetSelectSkillId(string skillId)
			{
			}

			// Token: 0x060233D4 RID: 144340 RVA: 0x000C0360 File Offset: 0x000BE560
			[Token(Token = "0x60233D4")]
			[Address(RVA = "0x1DCFFD0", Offset = "0x1DCEBD0", VA = "0x181DCFFD0")]
			public bool IsBtnTokenShow()
			{
				return default(bool);
			}

			// Token: 0x060233D5 RID: 144341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60233D5")]
			[Address(RVA = "0x1DCFDA0", Offset = "0x1DCE9A0", VA = "0x181DCFDA0")]
			public string GetTokenId()
			{
				return null;
			}

			// Token: 0x060233D6 RID: 144342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60233D6")]
			[Address(RVA = "0x1DD0B00", Offset = "0x1DCF700", VA = "0x181DD0B00")]
			private string _GetSkillTokenId()
			{
				return null;
			}

			// Token: 0x060233D7 RID: 144343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60233D7")]
			[Address(RVA = "0x1DD0B90", Offset = "0x1DCF790", VA = "0x181DD0B90")]
			private string _GetTalentTokenId()
			{
				return null;
			}

			// Token: 0x060233D8 RID: 144344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233D8")]
			[Address(RVA = "0x1DD0610", Offset = "0x1DCF210", VA = "0x181DD0610")]
			public void SetEquipId(string equipId)
			{
			}

			// Token: 0x060233D9 RID: 144345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233D9")]
			[Address(RVA = "0x1DCFFF0", Offset = "0x1DCEBF0", VA = "0x181DCFFF0")]
			public void LoadData(int charInstIdParam)
			{
			}

			// Token: 0x060233DA RID: 144346 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60233DA")]
			[Address(RVA = "0x1DCFC90", Offset = "0x1DCE890", VA = "0x181DCFC90")]
			public CharTokenViewModel GeneTokenViewModel()
			{
				return null;
			}

			// Token: 0x060233DB RID: 144347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233DB")]
			[Address(RVA = "0x1DD0C70", Offset = "0x1DCF870", VA = "0x181DD0C70")]
			public CultivateViewModel()
			{
			}

			// Token: 0x040308CD RID: 198861
			[Token(Token = "0x40308CD")]
			[FieldOffset(Offset = "0x10")]
			public AttributeViewProperty attributeProperty;

			// Token: 0x040308CE RID: 198862
			[Token(Token = "0x40308CE")]
			[FieldOffset(Offset = "0x18")]
			public CharacterProfileViewProperty profileProperty;

			// Token: 0x040308CF RID: 198863
			[Token(Token = "0x40308CF")]
			[FieldOffset(Offset = "0x20")]
			public SkillGroupViewProperty skillProperty;

			// Token: 0x040308D0 RID: 198864
			[Token(Token = "0x40308D0")]
			[FieldOffset(Offset = "0x28")]
			public BattleInfoViewProperty battleProperty;

			// Token: 0x040308D1 RID: 198865
			[Token(Token = "0x40308D1")]
			[FieldOffset(Offset = "0x30")]
			public SpCharInfoViewProperty spCharInfoProperty;

			// Token: 0x040308D2 RID: 198866
			[Token(Token = "0x40308D2")]
			[FieldOffset(Offset = "0x38")]
			public SpecialOperatorInfoViewProperty spOpInfoProperty;

			// Token: 0x040308D3 RID: 198867
			[Token(Token = "0x40308D3")]
			[FieldOffset(Offset = "0x40")]
			public BoolProperty isCharacterLocked;

			// Token: 0x040308D4 RID: 198868
			[Token(Token = "0x40308D4")]
			[FieldOffset(Offset = "0x48")]
			public int charInstId;

			// Token: 0x040308D5 RID: 198869
			[Token(Token = "0x40308D5")]
			[FieldOffset(Offset = "0x50")]
			public string charId;

			// Token: 0x040308D6 RID: 198870
			[Token(Token = "0x40308D6")]
			[FieldOffset(Offset = "0x58")]
			public string tmplId;

			// Token: 0x040308D7 RID: 198871
			[Token(Token = "0x40308D7")]
			[FieldOffset(Offset = "0x60")]
			public bool isReachMaxEvolve;

			// Token: 0x040308D8 RID: 198872
			[Token(Token = "0x40308D8")]
			[FieldOffset(Offset = "0x61")]
			public bool isReachMaxPotential;

			// Token: 0x040308D9 RID: 198873
			[Token(Token = "0x40308D9")]
			[FieldOffset(Offset = "0x62")]
			public bool isPotentialApplicable;

			// Token: 0x040308DA RID: 198874
			[Token(Token = "0x40308DA")]
			[FieldOffset(Offset = "0x64")]
			public EvolvePhase evolvePhase;

			// Token: 0x040308DB RID: 198875
			[Token(Token = "0x40308DB")]
			[FieldOffset(Offset = "0x68")]
			public CharacterData charDataCache;

			// Token: 0x040308DC RID: 198876
			[Token(Token = "0x40308DC")]
			[FieldOffset(Offset = "0x70")]
			public bool isStarMarked;

			// Token: 0x040308DD RID: 198877
			[Token(Token = "0x40308DD")]
			[FieldOffset(Offset = "0x78")]
			public string focusSkillId;

			// Token: 0x040308DE RID: 198878
			[Token(Token = "0x40308DE")]
			[FieldOffset(Offset = "0x80")]
			public CharacterInfoHolderBean.CultivateViewModel.CharInfoEquipShowParam equipShowParam;

			// Token: 0x02005F01 RID: 24321
			[Token(Token = "0x2005F01")]
			public struct CharInfoEquipShowParam : IHotfixable
			{
				// Token: 0x060233DC RID: 144348 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60233DC")]
				[Address(RVA = "0x1DBC020", Offset = "0x1DBAC20", VA = "0x181DBC020")]
				public void LoadParam(int equipCnt, int selectEquipPosition, string newEquipId)
				{
				}

				// Token: 0x060233DD RID: 144349 RVA: 0x000C0378 File Offset: 0x000BE578
				[Token(Token = "0x60233DD")]
				[Address(RVA = "0x1DBBFB0", Offset = "0x1DBABB0", VA = "0x181DBBFB0")]
				public bool GetIfChangeEquip()
				{
					return default(bool);
				}

				// Token: 0x040308DF RID: 198879
				[Token(Token = "0x40308DF")]
				private const int EQUIP_MIN_SHOW_CNT = 3;

				// Token: 0x040308E0 RID: 198880
				[Token(Token = "0x40308E0")]
				private const int SELECT_EQUIP_POSITION_NO_NEED_PRESET_POSITION = 0;

				// Token: 0x040308E1 RID: 198881
				[Token(Token = "0x40308E1")]
				[FieldOffset(Offset = "0x0")]
				public bool isEquipCntOverLimit;

				// Token: 0x040308E2 RID: 198882
				[Token(Token = "0x40308E2")]
				[FieldOffset(Offset = "0x1")]
				public bool isEquipScrollNeedPresetPosition;

				// Token: 0x040308E3 RID: 198883
				[Token(Token = "0x40308E3")]
				[FieldOffset(Offset = "0x2")]
				private bool m_isChangeEquip;

				// Token: 0x040308E4 RID: 198884
				[Token(Token = "0x40308E4")]
				[FieldOffset(Offset = "0x8")]
				private string m_cachedEquipId;

				// Token: 0x040308E5 RID: 198885
				[Token(Token = "0x40308E5")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_LoadParam;

				// Token: 0x040308E6 RID: 198886
				[Token(Token = "0x40308E6")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GetIfChangeEquip;
			}
		}

		// Token: 0x02005F02 RID: 24322
		[Token(Token = "0x2005F02")]
		public class CharViewModel : IHotfixable
		{
			// Token: 0x060233DE RID: 144350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233DE")]
			[Address(RVA = "0x1DBE250", Offset = "0x1DBCE50", VA = "0x181DBE250")]
			public CharViewModel(int i_instId)
			{
			}

			// Token: 0x1700535B RID: 21339
			// (get) Token: 0x060233DF RID: 144351 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700535B")]
			public CharacterInfoHolderBean.CultivateViewModel cultViewModel
			{
				[Token(Token = "0x60233DF")]
				[Address(RVA = "0x1DBE360", Offset = "0x1DBCF60", VA = "0x181DBE360")]
				get
				{
					return null;
				}
			}

			// Token: 0x060233E0 RID: 144352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233E0")]
			[Address(RVA = "0x1DBD9A0", Offset = "0x1DBC5A0", VA = "0x181DBD9A0")]
			public void InitIllust(int charInstIdParam)
			{
			}

			// Token: 0x060233E1 RID: 144353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233E1")]
			[Address(RVA = "0x1DBDC60", Offset = "0x1DBC860", VA = "0x181DBDC60")]
			public void InitPotential()
			{
			}

			// Token: 0x060233E2 RID: 144354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233E2")]
			[Address(RVA = "0x1DBDE80", Offset = "0x1DBCA80", VA = "0x181DBDE80")]
			private void _LoadPotentialWithHighRarity(CharacterData data)
			{
			}

			// Token: 0x060233E3 RID: 144355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233E3")]
			[Address(RVA = "0x1DBDF50", Offset = "0x1DBCB50", VA = "0x181DBDF50")]
			private void _LoadPotentialWithLowRarity(CharacterData data)
			{
			}

			// Token: 0x060233E4 RID: 144356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233E4")]
			[Address(RVA = "0x1DBDFF0", Offset = "0x1DBCBF0", VA = "0x181DBDFF0")]
			private void _LoadPrimaryItem(string itemId, ItemType itemType)
			{
			}

			// Token: 0x060233E5 RID: 144357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233E5")]
			[Address(RVA = "0x1DBE120", Offset = "0x1DBCD20", VA = "0x181DBE120")]
			private void _LoadSecondaryItem(string itemId, ItemType itemType)
			{
			}

			// Token: 0x040308E7 RID: 198887
			[Token(Token = "0x40308E7")]
			[FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x040308E8 RID: 198888
			[Token(Token = "0x40308E8")]
			[FieldOffset(Offset = "0x14")]
			public bool showSecondaryPotentialItem;

			// Token: 0x040308E9 RID: 198889
			[Token(Token = "0x40308E9")]
			[FieldOffset(Offset = "0x18")]
			public UIItemViewModel primaryItem;

			// Token: 0x040308EA RID: 198890
			[Token(Token = "0x40308EA")]
			[FieldOffset(Offset = "0x20")]
			public UIItemViewModel secondaryItem;

			// Token: 0x040308EB RID: 198891
			[Token(Token = "0x40308EB")]
			[FieldOffset(Offset = "0x28")]
			private CharacterInfoHolderBean.CultivateViewModel m_cultViewModel;

			// Token: 0x040308EC RID: 198892
			[Token(Token = "0x40308EC")]
			[FieldOffset(Offset = "0x30")]
			public CharacterIllustViewProperty illustProperty;

			// Token: 0x040308ED RID: 198893
			[Token(Token = "0x40308ED")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040308EE RID: 198894
			[Token(Token = "0x40308EE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_cultViewModel;

			// Token: 0x040308EF RID: 198895
			[Token(Token = "0x40308EF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_InitIllust;

			// Token: 0x040308F0 RID: 198896
			[Token(Token = "0x40308F0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_InitPotential;

			// Token: 0x040308F1 RID: 198897
			[Token(Token = "0x40308F1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__LoadPotentialWithHighRarity;

			// Token: 0x040308F2 RID: 198898
			[Token(Token = "0x40308F2")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__LoadPotentialWithLowRarity;

			// Token: 0x040308F3 RID: 198899
			[Token(Token = "0x40308F3")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__LoadPrimaryItem;

			// Token: 0x040308F4 RID: 198900
			[Token(Token = "0x40308F4")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__LoadSecondaryItem;
		}

		// Token: 0x02005F03 RID: 24323
		[Token(Token = "0x2005F03")]
		public class CharGroupViewModel
		{
			// Token: 0x060233E6 RID: 144358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233E6")]
			[Address(RVA = "0x1DBBD10", Offset = "0x1DBA910", VA = "0x181DBBD10")]
			public void RefreshInstId(int instId)
			{
			}

			// Token: 0x060233E7 RID: 144359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233E7")]
			[Address(RVA = "0x1DBB820", Offset = "0x1DBA420", VA = "0x181DBB820")]
			public void CheckIfResumeBackChangeEquip()
			{
			}

			// Token: 0x060233E8 RID: 144360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233E8")]
			[Address(RVA = "0x1DBBD00", Offset = "0x1DBA900", VA = "0x181DBBD00")]
			public void NotifyRefreshEquipScroll()
			{
			}

			// Token: 0x1700535C RID: 21340
			// (get) Token: 0x060233E9 RID: 144361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700535C")]
			public CharacterInfoHolderBean.CharViewModel focusCharViewModel
			{
				[Token(Token = "0x60233E9")]
				[Address(RVA = "0x1DBBE50", Offset = "0x1DBAA50", VA = "0x181DBBE50")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700535D RID: 21341
			// (get) Token: 0x060233EA RID: 144362 RVA: 0x000C0390 File Offset: 0x000BE590
			// (set) Token: 0x060233EB RID: 144363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700535D")]
			public int focusPos
			{
				[Token(Token = "0x60233EA")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60233EB")]
				[Address(RVA = "0x1DBBE90", Offset = "0x1DBAA90", VA = "0x181DBBE90")]
				set
				{
				}
			}

			// Token: 0x1700535E RID: 21342
			// (get) Token: 0x060233EC RID: 144364 RVA: 0x000C03A8 File Offset: 0x000BE5A8
			// (set) Token: 0x060233ED RID: 144365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700535E")]
			public int instId
			{
				[Token(Token = "0x60233EC")]
				[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60233ED")]
				[Address(RVA = "0x1DBBF00", Offset = "0x1DBAB00", VA = "0x181DBBF00")]
				set
				{
				}
			}

			// Token: 0x060233EE RID: 144366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233EE")]
			[Address(RVA = "0x1DBB8F0", Offset = "0x1DBA4F0", VA = "0x181DBB8F0")]
			public void InitViewModel(List<int> i_charViewModelGroup, int i_instId, bool i_isFromHandBook)
			{
			}

			// Token: 0x060233EF RID: 144367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233EF")]
			[Address(RVA = "0x1DBBBC0", Offset = "0x1DBA7C0", VA = "0x181DBBBC0")]
			public void InitViewModel(ICharInfoHomeInitParam param)
			{
			}

			// Token: 0x060233F0 RID: 144368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233F0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharGroupViewModel()
			{
			}

			// Token: 0x040308F5 RID: 198901
			[Token(Token = "0x40308F5")]
			[FieldOffset(Offset = "0x10")]
			public List<CharacterInfoHolderBean.CharViewModel> charViewModelGroup;

			// Token: 0x040308F6 RID: 198902
			[Token(Token = "0x40308F6")]
			[FieldOffset(Offset = "0x18")]
			public bool isFromHandBook;

			// Token: 0x040308F7 RID: 198903
			[Token(Token = "0x40308F7")]
			[FieldOffset(Offset = "0x1C")]
			public int equipScrollSequenceNum;

			// Token: 0x040308F8 RID: 198904
			[Token(Token = "0x40308F8")]
			[FieldOffset(Offset = "0x20")]
			private int m_focusPos;

			// Token: 0x040308F9 RID: 198905
			[Token(Token = "0x40308F9")]
			[FieldOffset(Offset = "0x24")]
			private int m_instId;
		}
	}
}
