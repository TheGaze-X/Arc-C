using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DD9 RID: 28121
	[Token(Token = "0x2006DD9")]
	public class ActVecBreakV2ResCollector : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005EB0 RID: 24240
		// (get) Token: 0x06028099 RID: 163993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EB0")]
		public Sprite imgOffenseSeasonTitle
		{
			[Token(Token = "0x6028099")]
			[Address(RVA = "0x2355A00", Offset = "0x2354600", VA = "0x182355A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB1 RID: 24241
		// (get) Token: 0x0602809A RID: 163994 RVA: 0x000D07D0 File Offset: 0x000CE9D0
		[Token(Token = "0x17005EB1")]
		public Color offenseThemeColor
		{
			[Token(Token = "0x602809A")]
			[Address(RVA = "0x2355D60", Offset = "0x2354960", VA = "0x182355D60")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17005EB2 RID: 24242
		// (get) Token: 0x0602809B RID: 163995 RVA: 0x000D07E8 File Offset: 0x000CE9E8
		[Token(Token = "0x17005EB2")]
		public Color colorTheme
		{
			[Token(Token = "0x602809B")]
			[Address(RVA = "0x23558C0", Offset = "0x23544C0", VA = "0x1823558C0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17005EB3 RID: 24243
		// (get) Token: 0x0602809C RID: 163996 RVA: 0x000D0800 File Offset: 0x000CEA00
		[Token(Token = "0x17005EB3")]
		public Color colorTheme2
		{
			[Token(Token = "0x602809C")]
			[Address(RVA = "0x2355840", Offset = "0x2354440", VA = "0x182355840")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17005EB4 RID: 24244
		// (get) Token: 0x0602809D RID: 163997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EB4")]
		public Sprite imgToDoBg
		{
			[Token(Token = "0x602809D")]
			[Address(RVA = "0x2355B80", Offset = "0x2354780", VA = "0x182355B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB5 RID: 24245
		// (get) Token: 0x0602809E RID: 163998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EB5")]
		public Sprite imgMedalEntry
		{
			[Token(Token = "0x602809E")]
			[Address(RVA = "0x23559A0", Offset = "0x23545A0", VA = "0x1823559A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB6 RID: 24246
		// (get) Token: 0x0602809F RID: 163999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EB6")]
		public Sprite imgSeasonIcon
		{
			[Token(Token = "0x602809F")]
			[Address(RVA = "0x2355B20", Offset = "0x2354720", VA = "0x182355B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB7 RID: 24247
		// (get) Token: 0x060280A0 RID: 164000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EB7")]
		public Sprite imgSeasonCode
		{
			[Token(Token = "0x60280A0")]
			[Address(RVA = "0x2355A60", Offset = "0x2354660", VA = "0x182355A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB8 RID: 24248
		// (get) Token: 0x060280A1 RID: 164001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EB8")]
		public Sprite imgSeasonDeco
		{
			[Token(Token = "0x60280A1")]
			[Address(RVA = "0x2355AC0", Offset = "0x23546C0", VA = "0x182355AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB9 RID: 24249
		// (get) Token: 0x060280A2 RID: 164002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EB9")]
		public Sprite imgEntryScreen
		{
			[Token(Token = "0x60280A2")]
			[Address(RVA = "0x2355940", Offset = "0x2354540", VA = "0x182355940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EBA RID: 24250
		// (get) Token: 0x060280A3 RID: 164003 RVA: 0x000D0818 File Offset: 0x000CEA18
		[Token(Token = "0x17005EBA")]
		public Color colorTextScheduleActive
		{
			[Token(Token = "0x60280A3")]
			[Address(RVA = "0x23557C0", Offset = "0x23543C0", VA = "0x1823557C0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17005EBB RID: 24251
		// (get) Token: 0x060280A4 RID: 164004 RVA: 0x000D0830 File Offset: 0x000CEA30
		[Token(Token = "0x17005EBB")]
		public Color colorBgScheduleActive
		{
			[Token(Token = "0x60280A4")]
			[Address(RVA = "0x2355740", Offset = "0x2354340", VA = "0x182355740")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17005EBC RID: 24252
		// (get) Token: 0x060280A5 RID: 164005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EBC")]
		public Sprite imgZoneTitle
		{
			[Token(Token = "0x60280A5")]
			[Address(RVA = "0x2355D00", Offset = "0x2354900", VA = "0x182355D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EBD RID: 24253
		// (get) Token: 0x060280A6 RID: 164006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EBD")]
		public Sprite imgZoneAchvEntry
		{
			[Token(Token = "0x60280A6")]
			[Address(RVA = "0x2355BE0", Offset = "0x23547E0", VA = "0x182355BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EBE RID: 24254
		// (get) Token: 0x060280A7 RID: 164007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EBE")]
		public Sprite imgZoneActEntry
		{
			[Token(Token = "0x60280A7")]
			[Address(RVA = "0x2355C40", Offset = "0x2354840", VA = "0x182355C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EBF RID: 24255
		// (get) Token: 0x060280A8 RID: 164008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EBF")]
		public Sprite imgZoneTabIcon
		{
			[Token(Token = "0x60280A8")]
			[Address(RVA = "0x2355CA0", Offset = "0x23548A0", VA = "0x182355CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060280A9 RID: 164009 RVA: 0x000D0848 File Offset: 0x000CEA48
		[Token(Token = "0x60280A9")]
		[Address(RVA = "0x23554F0", Offset = "0x23540F0", VA = "0x1823554F0")]
		public bool TryGetOffenseCustomLayer(int level, out ActVecBreakV2ResCollector.CustomOffenseTowerLayer layer)
		{
			return default(bool);
		}

		// Token: 0x060280AA RID: 164010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280AA")]
		[Address(RVA = "0x23556E0", Offset = "0x23542E0", VA = "0x1823556E0")]
		public ActVecBreakV2ResCollector()
		{
		}

		// Token: 0x04038C6D RID: 232557
		[Token(Token = "0x4038C6D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Offense")]
		private Sprite _imgOffenseSeasonTitle;

		// Token: 0x04038C6E RID: 232558
		[Token(Token = "0x4038C6E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Offense")]
		private Color _offenseThemeColor;

		// Token: 0x04038C6F RID: 232559
		[Token(Token = "0x4038C6F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Offense")]
		private ActVecBreakV2ResCollector.CustomOffenseTowerLayer[] _customOffenseTowerLayers;

		// Token: 0x04038C70 RID: 232560
		[Token(Token = "0x4038C70")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Entry")]
		private Sprite _imgMedalEntry;

		// Token: 0x04038C71 RID: 232561
		[Token(Token = "0x4038C71")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Entry")]
		private Sprite _imgSeasonIcon;

		// Token: 0x04038C72 RID: 232562
		[Token(Token = "0x4038C72")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Entry")]
		private Sprite _imgSeasonCode;

		// Token: 0x04038C73 RID: 232563
		[Token(Token = "0x4038C73")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Entry")]
		private Sprite _imgSeasonDeco;

		// Token: 0x04038C74 RID: 232564
		[Token(Token = "0x4038C74")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Entry")]
		private Sprite _imgEntryScreen;

		// Token: 0x04038C75 RID: 232565
		[Token(Token = "0x4038C75")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Zone")]
		private Sprite _imgZoneTitle;

		// Token: 0x04038C76 RID: 232566
		[Token(Token = "0x4038C76")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Zone")]
		private Sprite _imgZoneAchvEntry;

		// Token: 0x04038C77 RID: 232567
		[Token(Token = "0x4038C77")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Zone")]
		private Sprite _imgZoneActEntry;

		// Token: 0x04038C78 RID: 232568
		[Token(Token = "0x4038C78")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Zone")]
		private Sprite _imgZoneTabIcon;

		// Token: 0x04038C79 RID: 232569
		[Token(Token = "0x4038C79")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Sprite _imgToDoBg;

		// Token: 0x04038C7A RID: 232570
		[Token(Token = "0x4038C7A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorTheme;

		// Token: 0x04038C7B RID: 232571
		[Token(Token = "0x4038C7B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _colorTheme2;

		// Token: 0x04038C7C RID: 232572
		[Token(Token = "0x4038C7C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _colorTextScheduleActive;

		// Token: 0x04038C7D RID: 232573
		[Token(Token = "0x4038C7D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _colorBgScheduleActive;

		// Token: 0x04038C7E RID: 232574
		[Token(Token = "0x4038C7E")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<int, ActVecBreakV2ResCollector.CustomOffenseTowerLayer> m_customOffenseTowerLayers;

		// Token: 0x04038C7F RID: 232575
		[Token(Token = "0x4038C7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_imgOffenseSeasonTitle;

		// Token: 0x04038C80 RID: 232576
		[Token(Token = "0x4038C80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_offenseThemeColor;

		// Token: 0x04038C81 RID: 232577
		[Token(Token = "0x4038C81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_colorTheme;

		// Token: 0x04038C82 RID: 232578
		[Token(Token = "0x4038C82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_colorTheme2;

		// Token: 0x04038C83 RID: 232579
		[Token(Token = "0x4038C83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_imgToDoBg;

		// Token: 0x04038C84 RID: 232580
		[Token(Token = "0x4038C84")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_imgMedalEntry;

		// Token: 0x04038C85 RID: 232581
		[Token(Token = "0x4038C85")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_imgSeasonIcon;

		// Token: 0x04038C86 RID: 232582
		[Token(Token = "0x4038C86")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_imgSeasonCode;

		// Token: 0x04038C87 RID: 232583
		[Token(Token = "0x4038C87")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_imgSeasonDeco;

		// Token: 0x04038C88 RID: 232584
		[Token(Token = "0x4038C88")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_imgEntryScreen;

		// Token: 0x04038C89 RID: 232585
		[Token(Token = "0x4038C89")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_colorTextScheduleActive;

		// Token: 0x04038C8A RID: 232586
		[Token(Token = "0x4038C8A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_colorBgScheduleActive;

		// Token: 0x04038C8B RID: 232587
		[Token(Token = "0x4038C8B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_imgZoneTitle;

		// Token: 0x04038C8C RID: 232588
		[Token(Token = "0x4038C8C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_imgZoneAchvEntry;

		// Token: 0x04038C8D RID: 232589
		[Token(Token = "0x4038C8D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_imgZoneActEntry;

		// Token: 0x04038C8E RID: 232590
		[Token(Token = "0x4038C8E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_imgZoneTabIcon;

		// Token: 0x04038C8F RID: 232591
		[Token(Token = "0x4038C8F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_TryGetOffenseCustomLayer;

		// Token: 0x04038C90 RID: 232592
		[Token(Token = "0x4038C90")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DDA RID: 28122
		[Token(Token = "0x2006DDA")]
		[Serializable]
		public struct CustomOffenseTowerLayer
		{
			// Token: 0x04038C91 RID: 232593
			[Token(Token = "0x4038C91")]
			[FieldOffset(Offset = "0x0")]
			public int level;

			// Token: 0x04038C92 RID: 232594
			[Token(Token = "0x4038C92")]
			[FieldOffset(Offset = "0x8")]
			public Sprite baseSprite;

			// Token: 0x04038C93 RID: 232595
			[Token(Token = "0x4038C93")]
			[FieldOffset(Offset = "0x10")]
			public Sprite iconSprite;

			// Token: 0x04038C94 RID: 232596
			[Token(Token = "0x4038C94")]
			[FieldOffset(Offset = "0x18")]
			public Color numColor;
		}
	}
}
