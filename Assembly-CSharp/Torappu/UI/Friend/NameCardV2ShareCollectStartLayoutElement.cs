using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DCF RID: 19919
	[Token(Token = "0x2004DCF")]
	public class NameCardV2ShareCollectStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DC79 RID: 121977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DC79")]
		[Address(RVA = "0x17633D0", Offset = "0x1761FD0", VA = "0x1817633D0", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DC7A RID: 121978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC7A")]
		[Address(RVA = "0x1763520", Offset = "0x1762120", VA = "0x181763520")]
		public NameCardV2ShareCollectStartLayoutElement()
		{
		}

		// Token: 0x040276B4 RID: 161460
		[Token(Token = "0x40276B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hiredTimePart;

		// Token: 0x040276B5 RID: 161461
		[Token(Token = "0x40276B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _birthTimePart;

		// Token: 0x040276B6 RID: 161462
		[Token(Token = "0x40276B6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _hiredTime;

		// Token: 0x040276B7 RID: 161463
		[Token(Token = "0x40276B7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _birthTime;

		// Token: 0x040276B8 RID: 161464
		[Token(Token = "0x40276B8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _assistThemeStateToggle;

		// Token: 0x040276B9 RID: 161465
		[Token(Token = "0x40276B9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _assistConstText;

		// Token: 0x040276BA RID: 161466
		[Token(Token = "0x40276BA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _themeConstText;

		// Token: 0x040276BB RID: 161467
		[Token(Token = "0x40276BB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _assistThemeName;

		// Token: 0x040276BC RID: 161468
		[Token(Token = "0x40276BC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _assistThemeEnName;

		// Token: 0x040276BD RID: 161469
		[Token(Token = "0x40276BD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _skinCount;

		// Token: 0x040276BE RID: 161470
		[Token(Token = "0x40276BE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _characterCount;

		// Token: 0x040276BF RID: 161471
		[Token(Token = "0x40276BF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _themeColoredText1;

		// Token: 0x040276C0 RID: 161472
		[Token(Token = "0x40276C0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _themeColoredText2;

		// Token: 0x040276C1 RID: 161473
		[Token(Token = "0x40276C1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CrossAppShareStartLayoutContent _teamIconContent;

		// Token: 0x040276C2 RID: 161474
		[Token(Token = "0x40276C2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _operatorCollectPercent;

		// Token: 0x040276C3 RID: 161475
		[Token(Token = "0x40276C3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _themeColor1;

		// Token: 0x040276C4 RID: 161476
		[Token(Token = "0x40276C4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _themeColor2;

		// Token: 0x040276C5 RID: 161477
		[Token(Token = "0x40276C5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _themeColor3;

		// Token: 0x040276C6 RID: 161478
		[Token(Token = "0x40276C6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _operatorCollectUnselect;

		// Token: 0x040276C7 RID: 161479
		[Token(Token = "0x40276C7")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _operatorCollectSelect;

		// Token: 0x040276C8 RID: 161480
		[Token(Token = "0x40276C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x040276C9 RID: 161481
		[Token(Token = "0x40276C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DD0 RID: 19920
		[Token(Token = "0x2004DD0")]
		public class NameCardV2ShareCollectModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x0601DC7B RID: 121979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC7B")]
			[Address(RVA = "0x1761D70", Offset = "0x1760970", VA = "0x181761D70")]
			public void InitCollector(NameCardV2ShareCollectStartLayoutElement closure)
			{
			}

			// Token: 0x170045D6 RID: 17878
			// (get) Token: 0x0601DC7C RID: 121980 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC7D RID: 121981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045D6")]
			public CrossAppShareTextModel hiredDateModel
			{
				[Token(Token = "0x601DC7C")]
				[Address(RVA = "0x1762090", Offset = "0x1760C90", VA = "0x181762090")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC7D")]
				[Address(RVA = "0x1762810", Offset = "0x1761410", VA = "0x181762810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045D7 RID: 17879
			// (get) Token: 0x0601DC7E RID: 121982 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC7F RID: 121983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045D7")]
			public CrossAppShareTextModel birthDateModel
			{
				[Token(Token = "0x601DC7E")]
				[Address(RVA = "0x1761F70", Offset = "0x1760B70", VA = "0x181761F70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC7F")]
				[Address(RVA = "0x1762690", Offset = "0x1761290", VA = "0x181762690")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045D8 RID: 17880
			// (get) Token: 0x0601DC80 RID: 121984 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC81 RID: 121985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045D8")]
			public CrossAppShareTextModel assistThemeConstTextModel
			{
				[Token(Token = "0x601DC80")]
				[Address(RVA = "0x1761E50", Offset = "0x1760A50", VA = "0x181761E50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC81")]
				[Address(RVA = "0x1762510", Offset = "0x1761110", VA = "0x181762510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045D9 RID: 17881
			// (get) Token: 0x0601DC82 RID: 121986 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC83 RID: 121987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045D9")]
			public CrossAppShareTextModel assistThemeNameModel
			{
				[Token(Token = "0x601DC82")]
				[Address(RVA = "0x1761F10", Offset = "0x1760B10", VA = "0x181761F10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC83")]
				[Address(RVA = "0x1762610", Offset = "0x1761210", VA = "0x181762610")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045DA RID: 17882
			// (get) Token: 0x0601DC84 RID: 121988 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC85 RID: 121989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045DA")]
			public CrossAppShareTextModel assistThemeEnNameModel
			{
				[Token(Token = "0x601DC84")]
				[Address(RVA = "0x1761EB0", Offset = "0x1760AB0", VA = "0x181761EB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC85")]
				[Address(RVA = "0x1762590", Offset = "0x1761190", VA = "0x181762590")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045DB RID: 17883
			// (get) Token: 0x0601DC86 RID: 121990 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC87 RID: 121991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045DB")]
			public CrossAppShareTextModel skinCountModel
			{
				[Token(Token = "0x601DC86")]
				[Address(RVA = "0x1762270", Offset = "0x1760E70", VA = "0x181762270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC87")]
				[Address(RVA = "0x1762A90", Offset = "0x1761690", VA = "0x181762A90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045DC RID: 17884
			// (get) Token: 0x0601DC88 RID: 121992 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC89 RID: 121993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045DC")]
			public CrossAppShareTextModel characterCountModel
			{
				[Token(Token = "0x601DC88")]
				[Address(RVA = "0x1762030", Offset = "0x1760C30", VA = "0x181762030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC89")]
				[Address(RVA = "0x1762790", Offset = "0x1761390", VA = "0x181762790")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045DD RID: 17885
			// (get) Token: 0x0601DC8A RID: 121994 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC8B RID: 121995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045DD")]
			public CrossAppShareTextModel themeColoredText1Model
			{
				[Token(Token = "0x601DC8A")]
				[Address(RVA = "0x1762450", Offset = "0x1761050", VA = "0x181762450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC8B")]
				[Address(RVA = "0x1762D10", Offset = "0x1761910", VA = "0x181762D10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045DE RID: 17886
			// (get) Token: 0x0601DC8C RID: 121996 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC8D RID: 121997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045DE")]
			public CrossAppShareTextModel themeColoredText2Model
			{
				[Token(Token = "0x601DC8C")]
				[Address(RVA = "0x17624B0", Offset = "0x17610B0", VA = "0x1817624B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC8D")]
				[Address(RVA = "0x1762D90", Offset = "0x1761990", VA = "0x181762D90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045DF RID: 17887
			// (get) Token: 0x0601DC8E RID: 121998 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC8F RID: 121999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045DF")]
			public CrossAppShareLayoutContentModel teamIconModel
			{
				[Token(Token = "0x601DC8E")]
				[Address(RVA = "0x17622D0", Offset = "0x1760ED0", VA = "0x1817622D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC8F")]
				[Address(RVA = "0x1762B10", Offset = "0x1761710", VA = "0x181762B10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045E0 RID: 17888
			// (get) Token: 0x0601DC90 RID: 122000 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC91 RID: 122001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045E0")]
			public CrossAppShareImageModel operatorCollectPercentModel
			{
				[Token(Token = "0x601DC90")]
				[Address(RVA = "0x1762150", Offset = "0x1760D50", VA = "0x181762150")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC91")]
				[Address(RVA = "0x1762910", Offset = "0x1761510", VA = "0x181762910")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045E1 RID: 17889
			// (get) Token: 0x0601DC92 RID: 122002 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC93 RID: 122003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045E1")]
			public CrossAppShareImageModel themeColor1Model
			{
				[Token(Token = "0x601DC92")]
				[Address(RVA = "0x1762330", Offset = "0x1760F30", VA = "0x181762330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC93")]
				[Address(RVA = "0x1762B90", Offset = "0x1761790", VA = "0x181762B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045E2 RID: 17890
			// (get) Token: 0x0601DC94 RID: 122004 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC95 RID: 122005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045E2")]
			public CrossAppShareImageModel themeColor2Model
			{
				[Token(Token = "0x601DC94")]
				[Address(RVA = "0x1762390", Offset = "0x1760F90", VA = "0x181762390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC95")]
				[Address(RVA = "0x1762C10", Offset = "0x1761810", VA = "0x181762C10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045E3 RID: 17891
			// (get) Token: 0x0601DC96 RID: 122006 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC97 RID: 122007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045E3")]
			public CrossAppShareImageModel themeColor3Model
			{
				[Token(Token = "0x601DC96")]
				[Address(RVA = "0x17623F0", Offset = "0x1760FF0", VA = "0x1817623F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC97")]
				[Address(RVA = "0x1762C90", Offset = "0x1761890", VA = "0x181762C90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045E4 RID: 17892
			// (get) Token: 0x0601DC98 RID: 122008 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC99 RID: 122009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045E4")]
			public CrossAppShareObjectActiveModel hiredTimeSelectModel
			{
				[Token(Token = "0x601DC98")]
				[Address(RVA = "0x17620F0", Offset = "0x1760CF0", VA = "0x1817620F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC99")]
				[Address(RVA = "0x1762890", Offset = "0x1761490", VA = "0x181762890")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045E5 RID: 17893
			// (get) Token: 0x0601DC9A RID: 122010 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC9B RID: 122011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045E5")]
			public CrossAppShareObjectActiveModel birthSelectModel
			{
				[Token(Token = "0x601DC9A")]
				[Address(RVA = "0x1761FD0", Offset = "0x1760BD0", VA = "0x181761FD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC9B")]
				[Address(RVA = "0x1762710", Offset = "0x1761310", VA = "0x181762710")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045E6 RID: 17894
			// (get) Token: 0x0601DC9C RID: 122012 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC9D RID: 122013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045E6")]
			public CrossAppShareObjectActiveModel operatorCollectUnselectModel
			{
				[Token(Token = "0x601DC9C")]
				[Address(RVA = "0x1762210", Offset = "0x1760E10", VA = "0x181762210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC9D")]
				[Address(RVA = "0x1762A10", Offset = "0x1761610", VA = "0x181762A10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045E7 RID: 17895
			// (get) Token: 0x0601DC9E RID: 122014 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC9F RID: 122015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045E7")]
			public CrossAppShareObjectActiveModel operatorCollectSelectModel
			{
				[Token(Token = "0x601DC9E")]
				[Address(RVA = "0x17621B0", Offset = "0x1760DB0", VA = "0x1817621B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC9F")]
				[Address(RVA = "0x1762990", Offset = "0x1761590", VA = "0x181762990")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DCA0 RID: 122016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCA0")]
			[Address(RVA = "0x1760E70", Offset = "0x175FA70", VA = "0x181760E70", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DCA1 RID: 122017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCA1")]
			[Address(RVA = "0x1761DF0", Offset = "0x17609F0", VA = "0x181761DF0")]
			public NameCardV2ShareCollectModelCollector()
			{
			}

			// Token: 0x040276CA RID: 161482
			[Token(Token = "0x40276CA")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareCollectStartLayoutElement m_closure;

			// Token: 0x040276DD RID: 161501
			[Token(Token = "0x40276DD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x040276DE RID: 161502
			[Token(Token = "0x40276DE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_hiredDateModel;

			// Token: 0x040276DF RID: 161503
			[Token(Token = "0x40276DF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_hiredDateModel;

			// Token: 0x040276E0 RID: 161504
			[Token(Token = "0x40276E0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_birthDateModel;

			// Token: 0x040276E1 RID: 161505
			[Token(Token = "0x40276E1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_birthDateModel;

			// Token: 0x040276E2 RID: 161506
			[Token(Token = "0x40276E2")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_assistThemeConstTextModel;

			// Token: 0x040276E3 RID: 161507
			[Token(Token = "0x40276E3")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_assistThemeConstTextModel;

			// Token: 0x040276E4 RID: 161508
			[Token(Token = "0x40276E4")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_assistThemeNameModel;

			// Token: 0x040276E5 RID: 161509
			[Token(Token = "0x40276E5")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_set_assistThemeNameModel;

			// Token: 0x040276E6 RID: 161510
			[Token(Token = "0x40276E6")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_assistThemeEnNameModel;

			// Token: 0x040276E7 RID: 161511
			[Token(Token = "0x40276E7")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_set_assistThemeEnNameModel;

			// Token: 0x040276E8 RID: 161512
			[Token(Token = "0x40276E8")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_skinCountModel;

			// Token: 0x040276E9 RID: 161513
			[Token(Token = "0x40276E9")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_set_skinCountModel;

			// Token: 0x040276EA RID: 161514
			[Token(Token = "0x40276EA")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_characterCountModel;

			// Token: 0x040276EB RID: 161515
			[Token(Token = "0x40276EB")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_set_characterCountModel;

			// Token: 0x040276EC RID: 161516
			[Token(Token = "0x40276EC")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_themeColoredText1Model;

			// Token: 0x040276ED RID: 161517
			[Token(Token = "0x40276ED")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_set_themeColoredText1Model;

			// Token: 0x040276EE RID: 161518
			[Token(Token = "0x40276EE")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_themeColoredText2Model;

			// Token: 0x040276EF RID: 161519
			[Token(Token = "0x40276EF")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_set_themeColoredText2Model;

			// Token: 0x040276F0 RID: 161520
			[Token(Token = "0x40276F0")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_get_teamIconModel;

			// Token: 0x040276F1 RID: 161521
			[Token(Token = "0x40276F1")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_set_teamIconModel;

			// Token: 0x040276F2 RID: 161522
			[Token(Token = "0x40276F2")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_get_operatorCollectPercentModel;

			// Token: 0x040276F3 RID: 161523
			[Token(Token = "0x40276F3")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_set_operatorCollectPercentModel;

			// Token: 0x040276F4 RID: 161524
			[Token(Token = "0x40276F4")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_get_themeColor1Model;

			// Token: 0x040276F5 RID: 161525
			[Token(Token = "0x40276F5")]
			[FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_set_themeColor1Model;

			// Token: 0x040276F6 RID: 161526
			[Token(Token = "0x40276F6")]
			[FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_get_themeColor2Model;

			// Token: 0x040276F7 RID: 161527
			[Token(Token = "0x40276F7")]
			[FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_set_themeColor2Model;

			// Token: 0x040276F8 RID: 161528
			[Token(Token = "0x40276F8")]
			[FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_get_themeColor3Model;

			// Token: 0x040276F9 RID: 161529
			[Token(Token = "0x40276F9")]
			[FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_set_themeColor3Model;

			// Token: 0x040276FA RID: 161530
			[Token(Token = "0x40276FA")]
			[FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_get_hiredTimeSelectModel;

			// Token: 0x040276FB RID: 161531
			[Token(Token = "0x40276FB")]
			[FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_set_hiredTimeSelectModel;

			// Token: 0x040276FC RID: 161532
			[Token(Token = "0x40276FC")]
			[FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_get_birthSelectModel;

			// Token: 0x040276FD RID: 161533
			[Token(Token = "0x40276FD")]
			[FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_set_birthSelectModel;

			// Token: 0x040276FE RID: 161534
			[Token(Token = "0x40276FE")]
			[FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_get_operatorCollectUnselectModel;

			// Token: 0x040276FF RID: 161535
			[Token(Token = "0x40276FF")]
			[FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0_set_operatorCollectUnselectModel;

			// Token: 0x04027700 RID: 161536
			[Token(Token = "0x4027700")]
			[FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_get_operatorCollectSelectModel;

			// Token: 0x04027701 RID: 161537
			[Token(Token = "0x4027701")]
			[FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_set_operatorCollectSelectModel;

			// Token: 0x04027702 RID: 161538
			[Token(Token = "0x4027702")]
			[FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x04027703 RID: 161539
			[Token(Token = "0x4027703")]
			[FieldOffset(Offset = "0x130")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
