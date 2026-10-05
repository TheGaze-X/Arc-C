using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Torappu.Battle;
using Torappu.UI.CharSelect;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034F6 RID: 13558
	[Token(Token = "0x20034F6")]
	public class BasicCharInfoModel : ICharIdentityInfo, ICharacterInfo, IHotfixable, ICharDetailInfo, ICharAttrInfo, ICharSkinInfo, IComparableChar
	{
		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x060159BB RID: 88507 RVA: 0x0008CD00 File Offset: 0x0008AF00
		[Token(Token = "0x1700331A")]
		[JsonIgnore]
		public bool isEmpty
		{
			[Token(Token = "0x60159BB")]
			[Address(RVA = "0xE2E8E0", Offset = "0xE2D4E0", VA = "0x180E2E8E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x060159BC RID: 88508 RVA: 0x0008CD18 File Offset: 0x0008AF18
		// (set) Token: 0x060159BD RID: 88509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700331B")]
		public int instId
		{
			[Token(Token = "0x60159BC")]
			[Address(RVA = "0xE2E870", Offset = "0xE2D470", VA = "0x180E2E870", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60159BD")]
			[Address(RVA = "0xE2F9F0", Offset = "0xE2E5F0", VA = "0x180E2F9F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x060159BE RID: 88510 RVA: 0x0008CD30 File Offset: 0x0008AF30
		// (set) Token: 0x060159BF RID: 88511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700331C")]
		public bool instAble
		{
			[Token(Token = "0x60159BE")]
			[Address(RVA = "0xE2E800", Offset = "0xE2D400", VA = "0x180E2E800", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60159BF")]
			[Address(RVA = "0xE2F960", Offset = "0xE2E560", VA = "0x180E2F960")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x060159C0 RID: 88512 RVA: 0x0008CD48 File Offset: 0x0008AF48
		// (set) Token: 0x060159C1 RID: 88513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700331D")]
		public int sortIndex
		{
			[Token(Token = "0x60159C0")]
			[Address(RVA = "0xE2F420", Offset = "0xE2E020", VA = "0x180E2F420", Slot = "45")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60159C1")]
			[Address(RVA = "0xE2FF80", Offset = "0xE2EB80", VA = "0x180E2FF80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x060159C2 RID: 88514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060159C3 RID: 88515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700331E")]
		public string charId
		{
			[Token(Token = "0x60159C2")]
			[Address(RVA = "0xE2E380", Offset = "0xE2CF80", VA = "0x180E2E380", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60159C3")]
			[Address(RVA = "0xE2F600", Offset = "0xE2E200", VA = "0x180E2F600")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x060159C4 RID: 88516 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060159C5 RID: 88517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700331F")]
		public string skinId
		{
			[Token(Token = "0x60159C4")]
			[Address(RVA = "0xE2F0D0", Offset = "0xE2DCD0", VA = "0x180E2F0D0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60159C5")]
			[Address(RVA = "0xE2FEF0", Offset = "0xE2EAF0", VA = "0x180E2FEF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x060159C6 RID: 88518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003320")]
		public string portraitId
		{
			[Token(Token = "0x60159C6")]
			[Address(RVA = "0xE2ECE0", Offset = "0xE2D8E0", VA = "0x180E2ECE0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x060159C7 RID: 88519 RVA: 0x0008CD60 File Offset: 0x0008AF60
		[Token(Token = "0x17003321")]
		public virtual bool allowSpSkin
		{
			[Token(Token = "0x60159C7")]
			[Address(RVA = "0xE2E000", Offset = "0xE2CC00", VA = "0x180E2E000", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x060159C8 RID: 88520 RVA: 0x0008CD78 File Offset: 0x0008AF78
		[Token(Token = "0x17003322")]
		public CharUISkinStruct skinStruct
		{
			[Token(Token = "0x60159C8")]
			[Address(RVA = "0xE2F140", Offset = "0xE2DD40", VA = "0x180E2F140", Slot = "29")]
			get
			{
				return default(CharUISkinStruct);
			}
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x060159C9 RID: 88521 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060159CA RID: 88522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003323")]
		public string tmplId
		{
			[Token(Token = "0x60159C9")]
			[Address(RVA = "0xE2F590", Offset = "0xE2E190", VA = "0x180E2F590", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60159CA")]
			[Address(RVA = "0xE30120", Offset = "0xE2ED20", VA = "0x180E30120")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x060159CB RID: 88523 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060159CC RID: 88524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003324")]
		public string name
		{
			[Token(Token = "0x60159CB")]
			[Address(RVA = "0xE2EBE0", Offset = "0xE2D7E0", VA = "0x180E2EBE0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60159CC")]
			[Address(RVA = "0xE2FB90", Offset = "0xE2E790", VA = "0x180E2FB90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x060159CD RID: 88525 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060159CE RID: 88526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003325")]
		public string nickName
		{
			[Token(Token = "0x60159CD")]
			[Address(RVA = "0xE2EC60", Offset = "0xE2D860", VA = "0x180E2EC60", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60159CE")]
			[Address(RVA = "0xE2FC20", Offset = "0xE2E820", VA = "0x180E2FC20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x060159CF RID: 88527 RVA: 0x0008CD90 File Offset: 0x0008AF90
		// (set) Token: 0x060159D0 RID: 88528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003326")]
		public RarityRank rarity
		{
			[Token(Token = "0x60159CF")]
			[Address(RVA = "0xE2EF90", Offset = "0xE2DB90", VA = "0x180E2EF90", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return RarityRank.TIER_1;
			}
			[Token(Token = "0x60159D0")]
			[Address(RVA = "0xE2FE60", Offset = "0xE2EA60", VA = "0x180E2FE60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x060159D1 RID: 88529 RVA: 0x0008CDA8 File Offset: 0x0008AFA8
		// (set) Token: 0x060159D2 RID: 88530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003327")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x60159D1")]
			[Address(RVA = "0xE2EF20", Offset = "0xE2DB20", VA = "0x180E2EF20", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return ProfessionCategory.NONE;
			}
			[Token(Token = "0x60159D2")]
			[Address(RVA = "0xE2FDD0", Offset = "0xE2E9D0", VA = "0x180E2FDD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x060159D3 RID: 88531 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060159D4 RID: 88532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003328")]
		public string subProfessionId
		{
			[Token(Token = "0x60159D3")]
			[Address(RVA = "0xE2F510", Offset = "0xE2E110", VA = "0x180E2F510", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60159D4")]
			[Address(RVA = "0xE30090", Offset = "0xE2EC90", VA = "0x180E30090")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x060159D5 RID: 88533 RVA: 0x0008CDC0 File Offset: 0x0008AFC0
		// (set) Token: 0x060159D6 RID: 88534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003329")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x60159D5")]
			[Address(RVA = "0xE2E610", Offset = "0xE2D210", VA = "0x180E2E610", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x60159D6")]
			[Address(RVA = "0xE2F720", Offset = "0xE2E320", VA = "0x180E2F720")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x060159D7 RID: 88535 RVA: 0x0008CDD8 File Offset: 0x0008AFD8
		// (set) Token: 0x060159D8 RID: 88536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700332A")]
		public int potentialRank
		{
			[Token(Token = "0x60159D7")]
			[Address(RVA = "0xE2EEB0", Offset = "0xE2DAB0", VA = "0x180E2EEB0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60159D8")]
			[Address(RVA = "0xE2FD40", Offset = "0xE2E940", VA = "0x180E2FD40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x060159D9 RID: 88537 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060159DA RID: 88538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700332B")]
		public string description
		{
			[Token(Token = "0x60159D9")]
			[Address(RVA = "0xE2E590", Offset = "0xE2D190", VA = "0x180E2E590", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60159DA")]
			[Address(RVA = "0xE2F690", Offset = "0xE2E290", VA = "0x180E2F690")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x060159DB RID: 88539 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060159DC RID: 88540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700332C")]
		public string positionStr
		{
			[Token(Token = "0x60159DB")]
			[Address(RVA = "0xE2EDA0", Offset = "0xE2D9A0", VA = "0x180E2EDA0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60159DC")]
			[Address(RVA = "0xE2FCB0", Offset = "0xE2E8B0", VA = "0x180E2FCB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x060159DD RID: 88541 RVA: 0x0008CDF0 File Offset: 0x0008AFF0
		// (set) Token: 0x060159DE RID: 88542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700332D")]
		public int level
		{
			[Token(Token = "0x60159DD")]
			[Address(RVA = "0xE2E950", Offset = "0xE2D550", VA = "0x180E2E950", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60159DE")]
			[Address(RVA = "0xE2FA70", Offset = "0xE2E670", VA = "0x180E2FA70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x060159DF RID: 88543 RVA: 0x0008CE08 File Offset: 0x0008B008
		// (set) Token: 0x060159E0 RID: 88544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700332E")]
		public int maxLevel
		{
			[Token(Token = "0x60159DF")]
			[Address(RVA = "0xE2EB70", Offset = "0xE2D770", VA = "0x180E2EB70", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60159E0")]
			[Address(RVA = "0xE2FB00", Offset = "0xE2E700", VA = "0x180E2FB00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x060159E1 RID: 88545 RVA: 0x0008CE20 File Offset: 0x0008B020
		// (set) Token: 0x060159E2 RID: 88546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700332F")]
		public float expPercent
		{
			[Token(Token = "0x60159E1")]
			[Address(RVA = "0xE2E680", Offset = "0xE2D280", VA = "0x180E2E680", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60159E2")]
			[Address(RVA = "0xE2F7B0", Offset = "0xE2E3B0", VA = "0x180E2F7B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x060159E3 RID: 88547 RVA: 0x0008CE38 File Offset: 0x0008B038
		// (set) Token: 0x060159E4 RID: 88548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003330")]
		public DateTime gainTime
		{
			[Token(Token = "0x60159E3")]
			[Address(RVA = "0xE2E780", Offset = "0xE2D380", VA = "0x180E2E780", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60159E4")]
			[Address(RVA = "0xE2F8D0", Offset = "0xE2E4D0", VA = "0x180E2F8D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x060159E5 RID: 88549 RVA: 0x0008CE50 File Offset: 0x0008B050
		// (set) Token: 0x060159E6 RID: 88550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003331")]
		public int favorPoint
		{
			[Token(Token = "0x60159E5")]
			[Address(RVA = "0xE2E700", Offset = "0xE2D300", VA = "0x180E2E700", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60159E6")]
			[Address(RVA = "0xE2F840", Offset = "0xE2E440", VA = "0x180E2F840")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x060159E7 RID: 88551 RVA: 0x0008CE68 File Offset: 0x0008B068
		// (set) Token: 0x060159E8 RID: 88552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003332")]
		public CharStarMarkState starMark
		{
			[Token(Token = "0x60159E7")]
			[Address(RVA = "0xE2F490", Offset = "0xE2E090", VA = "0x180E2F490", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return CharStarMarkState.NONE;
			}
			[Token(Token = "0x60159E8")]
			[Address(RVA = "0xE30000", Offset = "0xE2EC00", VA = "0x180E30000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x060159E9 RID: 88553 RVA: 0x0008CE80 File Offset: 0x0008B080
		[Token(Token = "0x17003333")]
		public BuildableType position
		{
			[Token(Token = "0x60159E9")]
			[Address(RVA = "0xE2EE20", Offset = "0xE2DA20", VA = "0x180E2EE20")]
			get
			{
				return BuildableType.NONE;
			}
		}

		// Token: 0x060159EA RID: 88554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60159EA")]
		[Address(RVA = "0xE2C990", Offset = "0xE2B590", VA = "0x180E2C990")]
		private AttributesData _AttrDataSecured()
		{
			return null;
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x060159EB RID: 88555 RVA: 0x0008CE98 File Offset: 0x0008B098
		[Token(Token = "0x17003334")]
		public int atk
		{
			[Token(Token = "0x60159EB")]
			[Address(RVA = "0xE2E160", Offset = "0xE2CD60", VA = "0x180E2E160", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x060159EC RID: 88556 RVA: 0x0008CEB0 File Offset: 0x0008B0B0
		[Token(Token = "0x17003335")]
		public int def
		{
			[Token(Token = "0x60159EC")]
			[Address(RVA = "0xE2E4C0", Offset = "0xE2D0C0", VA = "0x180E2E4C0", Slot = "38")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x060159ED RID: 88557 RVA: 0x0008CEC8 File Offset: 0x0008B0C8
		[Token(Token = "0x17003336")]
		public float magicRes
		{
			[Token(Token = "0x60159ED")]
			[Address(RVA = "0xE2E9C0", Offset = "0xE2D5C0", VA = "0x180E2E9C0", Slot = "39")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x060159EE RID: 88558 RVA: 0x0008CEE0 File Offset: 0x0008B0E0
		[Token(Token = "0x17003337")]
		public int cost
		{
			[Token(Token = "0x60159EE")]
			[Address(RVA = "0xE2E3F0", Offset = "0xE2CFF0", VA = "0x180E2E3F0", Slot = "40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x060159EF RID: 88559 RVA: 0x0008CEF8 File Offset: 0x0008B0F8
		[Token(Token = "0x17003338")]
		public int maxHp
		{
			[Token(Token = "0x60159EF")]
			[Address(RVA = "0xE2EAA0", Offset = "0xE2D6A0", VA = "0x180E2EAA0", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x060159F0 RID: 88560 RVA: 0x0008CF10 File Offset: 0x0008B110
		[Token(Token = "0x17003339")]
		public int blockCnt
		{
			[Token(Token = "0x60159F0")]
			[Address(RVA = "0xE2E2B0", Offset = "0xE2CEB0", VA = "0x180E2E2B0", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x060159F1 RID: 88561 RVA: 0x0008CF28 File Offset: 0x0008B128
		[Token(Token = "0x1700333A")]
		public int respawnTime
		{
			[Token(Token = "0x60159F1")]
			[Address(RVA = "0xE2F000", Offset = "0xE2DC00", VA = "0x180E2F000", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x060159F2 RID: 88562 RVA: 0x0008CF40 File Offset: 0x0008B140
		[Token(Token = "0x1700333B")]
		public float atkSpeed
		{
			[Token(Token = "0x60159F2")]
			[Address(RVA = "0xE2E080", Offset = "0xE2CC80", VA = "0x180E2E080", Slot = "44")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x060159F3 RID: 88563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700333C")]
		public AttributesData attrData
		{
			[Token(Token = "0x60159F3")]
			[Address(RVA = "0xE2E230", Offset = "0xE2CE30", VA = "0x180E2E230", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x060159F4 RID: 88564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60159F4")]
		[Address(RVA = "0xE2DD90", Offset = "0xE2C990", VA = "0x180E2DD90")]
		protected BasicCharInfoModel()
		{
		}

		// Token: 0x060159F5 RID: 88565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60159F5")]
		[Address(RVA = "0xE2C650", Offset = "0xE2B250", VA = "0x180E2C650", Slot = "49")]
		public virtual void SetSkinId(string newSkinId)
		{
		}

		// Token: 0x060159F6 RID: 88566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60159F6")]
		[Address(RVA = "0xE2C5B0", Offset = "0xE2B1B0", VA = "0x180E2C5B0", Slot = "50")]
		public virtual void SetAttrData(AttributesData newAttrData)
		{
		}

		// Token: 0x060159F7 RID: 88567 RVA: 0x0008CF58 File Offset: 0x0008B158
		[Token(Token = "0x60159F7")]
		[Address(RVA = "0xE2CC40", Offset = "0xE2B840", VA = "0x180E2CC40")]
		private static float _CalCharExpPercent(CharacterData charData, string charId, int level, int maxLevel, EvolvePhase evolvePhase, int exp)
		{
			return 0f;
		}

		// Token: 0x060159F8 RID: 88568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60159F8")]
		[Address(RVA = "0xE2C4F0", Offset = "0xE2B0F0", VA = "0x180E2C4F0")]
		public static BasicCharInfoModel LoadModelFromSharedChar(SharedCharData sharedChar, CharacterData charData)
		{
			return null;
		}

		// Token: 0x060159F9 RID: 88569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60159F9")]
		[Address(RVA = "0xE2BF50", Offset = "0xE2AB50", VA = "0x180E2BF50")]
		public static BasicCharInfoModel LoadModelFromBattleChar(BattleCharacterData battleCharData)
		{
			return null;
		}

		// Token: 0x060159FA RID: 88570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60159FA")]
		[Address(RVA = "0xE2C420", Offset = "0xE2B020", VA = "0x180E2C420")]
		public static BasicCharInfoModel LoadModelFromSharedCharWithPotenialRank(SharedCharData sharedChar, CharacterData charData)
		{
			return null;
		}

		// Token: 0x060159FB RID: 88571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60159FB")]
		[Address(RVA = "0xE2DE10", Offset = "0xE2CA10", VA = "0x180E2DE10")]
		private BasicCharInfoModel(SharedCharData sharedChar, CharacterData charData)
		{
		}

		// Token: 0x060159FC RID: 88572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60159FC")]
		[Address(RVA = "0xE2D920", Offset = "0xE2C520", VA = "0x180E2D920")]
		private BasicCharInfoModel(BattleCharacterData battleChar)
		{
		}

		// Token: 0x060159FD RID: 88573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60159FD")]
		[Address(RVA = "0xE2C0E0", Offset = "0xE2ACE0", VA = "0x180E2C0E0")]
		public static BasicCharInfoModel LoadModelFromCultivateData(CharQuery charQuery, CharacterData charData, BasicCharInfoModel.CultivateModel cultivateModel)
		{
			return null;
		}

		// Token: 0x060159FE RID: 88574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60159FE")]
		[Address(RVA = "0xE2DA40", Offset = "0xE2C640", VA = "0x180E2DA40")]
		protected BasicCharInfoModel(CharQuery charQuery, CharacterData charData, BasicCharInfoModel.CultivateModel cultivateModel)
		{
		}

		// Token: 0x060159FF RID: 88575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60159FF")]
		[Address(RVA = "0xE2C200", Offset = "0xE2AE00", VA = "0x180E2C200")]
		public static BasicCharInfoModel LoadModelFromPlayerChar(PlayerCharacter playerChar, CharacterData charData, bool instAble = true)
		{
			return null;
		}

		// Token: 0x06015A00 RID: 88576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A00")]
		[Address(RVA = "0xE2CED0", Offset = "0xE2BAD0", VA = "0x180E2CED0")]
		public BasicCharInfoModel(PlayerCharacter playerChar, CharacterData charData, bool instAble = true)
		{
		}

		// Token: 0x06015A01 RID: 88577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015A01")]
		[Address(RVA = "0xE2C2E0", Offset = "0xE2AEE0", VA = "0x180E2C2E0")]
		public static BasicCharInfoModel LoadModelFromPredefinedChar(PredefinedCharStruct charStruct, CharacterData charData)
		{
			return null;
		}

		// Token: 0x06015A02 RID: 88578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A02")]
		[Address(RVA = "0xE2D4D0", Offset = "0xE2C0D0", VA = "0x180E2D4D0")]
		public BasicCharInfoModel(PredefinedCharStruct charStruct, CharacterData charData)
		{
		}

		// Token: 0x06015A03 RID: 88579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015A03")]
		[Address(RVA = "0xE2C700", Offset = "0xE2B300", VA = "0x180E2C700")]
		public static BasicCharInfoModel TestOnly_LoadChar(int fakeInstId, string charId, CharacterData charData)
		{
			return null;
		}

		// Token: 0x06015A04 RID: 88580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A04")]
		[Address(RVA = "0xE2D2D0", Offset = "0xE2BED0", VA = "0x180E2D2D0")]
		private BasicCharInfoModel(int fakeInstId, string charId, CharacterData charData)
		{
		}

		// Token: 0x04019E82 RID: 106114
		[Token(Token = "0x4019E82")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BasicCharInfoModel EMPTY;

		// Token: 0x04019E83 RID: 106115
		[Token(Token = "0x4019E83")]
		[FieldOffset(Offset = "0x10")]
		[JsonIgnore]
		private bool m_isEmpty;

		// Token: 0x04019E99 RID: 106137
		[Token(Token = "0x4019E99")]
		[FieldOffset(Offset = "0x90")]
		[JsonIgnore]
		private CharacterData m_charData;

		// Token: 0x04019E9A RID: 106138
		[Token(Token = "0x4019E9A")]
		[FieldOffset(Offset = "0x98")]
		[JsonIgnore]
		private PlayerCharacter m_playerData;

		// Token: 0x04019E9B RID: 106139
		[Token(Token = "0x4019E9B")]
		[FieldOffset(Offset = "0xA0")]
		[JsonIgnore]
		private AttributesData m_attrData;

		// Token: 0x04019E9C RID: 106140
		[Token(Token = "0x4019E9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04019E9D RID: 106141
		[Token(Token = "0x4019E9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x04019E9E RID: 106142
		[Token(Token = "0x4019E9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_instId;

		// Token: 0x04019E9F RID: 106143
		[Token(Token = "0x4019E9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_instAble;

		// Token: 0x04019EA0 RID: 106144
		[Token(Token = "0x4019EA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_instAble;

		// Token: 0x04019EA1 RID: 106145
		[Token(Token = "0x4019EA1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_sortIndex;

		// Token: 0x04019EA2 RID: 106146
		[Token(Token = "0x4019EA2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_sortIndex;

		// Token: 0x04019EA3 RID: 106147
		[Token(Token = "0x4019EA3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x04019EA4 RID: 106148
		[Token(Token = "0x4019EA4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_charId;

		// Token: 0x04019EA5 RID: 106149
		[Token(Token = "0x4019EA5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_skinId;

		// Token: 0x04019EA6 RID: 106150
		[Token(Token = "0x4019EA6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_skinId;

		// Token: 0x04019EA7 RID: 106151
		[Token(Token = "0x4019EA7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_portraitId;

		// Token: 0x04019EA8 RID: 106152
		[Token(Token = "0x4019EA8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_allowSpSkin;

		// Token: 0x04019EA9 RID: 106153
		[Token(Token = "0x4019EA9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_skinStruct;

		// Token: 0x04019EAA RID: 106154
		[Token(Token = "0x4019EAA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_tmplId;

		// Token: 0x04019EAB RID: 106155
		[Token(Token = "0x4019EAB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_tmplId;

		// Token: 0x04019EAC RID: 106156
		[Token(Token = "0x4019EAC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x04019EAD RID: 106157
		[Token(Token = "0x4019EAD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x04019EAE RID: 106158
		[Token(Token = "0x4019EAE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_nickName;

		// Token: 0x04019EAF RID: 106159
		[Token(Token = "0x4019EAF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_nickName;

		// Token: 0x04019EB0 RID: 106160
		[Token(Token = "0x4019EB0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_rarity;

		// Token: 0x04019EB1 RID: 106161
		[Token(Token = "0x4019EB1")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_rarity;

		// Token: 0x04019EB2 RID: 106162
		[Token(Token = "0x4019EB2")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x04019EB3 RID: 106163
		[Token(Token = "0x4019EB3")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_profession;

		// Token: 0x04019EB4 RID: 106164
		[Token(Token = "0x4019EB4")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_subProfessionId;

		// Token: 0x04019EB5 RID: 106165
		[Token(Token = "0x4019EB5")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_subProfessionId;

		// Token: 0x04019EB6 RID: 106166
		[Token(Token = "0x4019EB6")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x04019EB7 RID: 106167
		[Token(Token = "0x4019EB7")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_set_evolvePhase;

		// Token: 0x04019EB8 RID: 106168
		[Token(Token = "0x4019EB8")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_potentialRank;

		// Token: 0x04019EB9 RID: 106169
		[Token(Token = "0x4019EB9")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_set_potentialRank;

		// Token: 0x04019EBA RID: 106170
		[Token(Token = "0x4019EBA")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_description;

		// Token: 0x04019EBB RID: 106171
		[Token(Token = "0x4019EBB")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_set_description;

		// Token: 0x04019EBC RID: 106172
		[Token(Token = "0x4019EBC")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_positionStr;

		// Token: 0x04019EBD RID: 106173
		[Token(Token = "0x4019EBD")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_set_positionStr;

		// Token: 0x04019EBE RID: 106174
		[Token(Token = "0x4019EBE")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x04019EBF RID: 106175
		[Token(Token = "0x4019EBF")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x04019EC0 RID: 106176
		[Token(Token = "0x4019EC0")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_maxLevel;

		// Token: 0x04019EC1 RID: 106177
		[Token(Token = "0x4019EC1")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_set_maxLevel;

		// Token: 0x04019EC2 RID: 106178
		[Token(Token = "0x4019EC2")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_expPercent;

		// Token: 0x04019EC3 RID: 106179
		[Token(Token = "0x4019EC3")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_set_expPercent;

		// Token: 0x04019EC4 RID: 106180
		[Token(Token = "0x4019EC4")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_gainTime;

		// Token: 0x04019EC5 RID: 106181
		[Token(Token = "0x4019EC5")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_set_gainTime;

		// Token: 0x04019EC6 RID: 106182
		[Token(Token = "0x4019EC6")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_favorPoint;

		// Token: 0x04019EC7 RID: 106183
		[Token(Token = "0x4019EC7")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_set_favorPoint;

		// Token: 0x04019EC8 RID: 106184
		[Token(Token = "0x4019EC8")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_starMark;

		// Token: 0x04019EC9 RID: 106185
		[Token(Token = "0x4019EC9")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_set_starMark;

		// Token: 0x04019ECA RID: 106186
		[Token(Token = "0x4019ECA")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_position;

		// Token: 0x04019ECB RID: 106187
		[Token(Token = "0x4019ECB")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__AttrDataSecured;

		// Token: 0x04019ECC RID: 106188
		[Token(Token = "0x4019ECC")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_atk;

		// Token: 0x04019ECD RID: 106189
		[Token(Token = "0x4019ECD")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_get_def;

		// Token: 0x04019ECE RID: 106190
		[Token(Token = "0x4019ECE")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_magicRes;

		// Token: 0x04019ECF RID: 106191
		[Token(Token = "0x4019ECF")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_get_cost;

		// Token: 0x04019ED0 RID: 106192
		[Token(Token = "0x4019ED0")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_get_maxHp;

		// Token: 0x04019ED1 RID: 106193
		[Token(Token = "0x4019ED1")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_get_blockCnt;

		// Token: 0x04019ED2 RID: 106194
		[Token(Token = "0x4019ED2")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_get_respawnTime;

		// Token: 0x04019ED3 RID: 106195
		[Token(Token = "0x4019ED3")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_get_atkSpeed;

		// Token: 0x04019ED4 RID: 106196
		[Token(Token = "0x4019ED4")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_get_attrData;

		// Token: 0x04019ED5 RID: 106197
		[Token(Token = "0x4019ED5")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04019ED6 RID: 106198
		[Token(Token = "0x4019ED6")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_SetSkinId;

		// Token: 0x04019ED7 RID: 106199
		[Token(Token = "0x4019ED7")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_SetAttrData;

		// Token: 0x04019ED8 RID: 106200
		[Token(Token = "0x4019ED8")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__CalCharExpPercent;

		// Token: 0x04019ED9 RID: 106201
		[Token(Token = "0x4019ED9")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_LoadModelFromSharedChar;

		// Token: 0x04019EDA RID: 106202
		[Token(Token = "0x4019EDA")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_LoadModelFromBattleChar;

		// Token: 0x04019EDB RID: 106203
		[Token(Token = "0x4019EDB")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_LoadModelFromSharedCharWithPotenialRank;

		// Token: 0x04019EDC RID: 106204
		[Token(Token = "0x4019EDC")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x04019EDD RID: 106205
		[Token(Token = "0x4019EDD")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge _c__Hotfix2_ctor;

		// Token: 0x04019EDE RID: 106206
		[Token(Token = "0x4019EDE")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_LoadModelFromCultivateData;

		// Token: 0x04019EDF RID: 106207
		[Token(Token = "0x4019EDF")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge _c__Hotfix3_ctor;

		// Token: 0x04019EE0 RID: 106208
		[Token(Token = "0x4019EE0")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_LoadModelFromPlayerChar;

		// Token: 0x04019EE1 RID: 106209
		[Token(Token = "0x4019EE1")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge _c__Hotfix4_ctor;

		// Token: 0x04019EE2 RID: 106210
		[Token(Token = "0x4019EE2")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_LoadModelFromPredefinedChar;

		// Token: 0x04019EE3 RID: 106211
		[Token(Token = "0x4019EE3")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge _c__Hotfix5_ctor;

		// Token: 0x04019EE4 RID: 106212
		[Token(Token = "0x4019EE4")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_TestOnly_LoadChar;

		// Token: 0x04019EE5 RID: 106213
		[Token(Token = "0x4019EE5")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge _c__Hotfix6_ctor;

		// Token: 0x020034F7 RID: 13559
		[Token(Token = "0x20034F7")]
		public struct CultivateModel
		{
			// Token: 0x04019EE6 RID: 106214
			[Token(Token = "0x4019EE6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly BasicCharInfoModel.CultivateModel NON_CULTIVATE;

			// Token: 0x04019EE7 RID: 106215
			[Token(Token = "0x4019EE7")]
			[FieldOffset(Offset = "0x0")]
			public EvolvePhase evolvePhase;

			// Token: 0x04019EE8 RID: 106216
			[Token(Token = "0x4019EE8")]
			[FieldOffset(Offset = "0x4")]
			public int favorPoint;

			// Token: 0x04019EE9 RID: 106217
			[Token(Token = "0x4019EE9")]
			[FieldOffset(Offset = "0x8")]
			public int level;

			// Token: 0x04019EEA RID: 106218
			[Token(Token = "0x4019EEA")]
			[FieldOffset(Offset = "0xC")]
			public int potentialRank;
		}

		// Token: 0x020034F8 RID: 13560
		[Token(Token = "0x20034F8")]
		public struct DefaultIdentityInfoPatchBuilder : ICharInfoPatchBuilder<BasicCharInfoModel>, IHotfixable
		{
			// Token: 0x1700333D RID: 13117
			// (get) Token: 0x06015A07 RID: 88583 RVA: 0x0008CF70 File Offset: 0x0008B170
			[Token(Token = "0x1700333D")]
			public bool isEmpty
			{
				[Token(Token = "0x6015A07")]
				[Address(RVA = "0xE38260", Offset = "0xE36E60", VA = "0x180E38260", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06015A08 RID: 88584 RVA: 0x0008CF88 File Offset: 0x0008B188
			[Token(Token = "0x6015A08")]
			[Address(RVA = "0xE380B0", Offset = "0xE36CB0", VA = "0x180E380B0")]
			public static BasicCharInfoModel.DefaultIdentityInfoPatchBuilder ParseFromPlayerCharacter(PlayerCharacter playerChar, bool instAble)
			{
				return default(BasicCharInfoModel.DefaultIdentityInfoPatchBuilder);
			}

			// Token: 0x06015A09 RID: 88585 RVA: 0x0008CFA0 File Offset: 0x0008B1A0
			[Token(Token = "0x6015A09")]
			[Address(RVA = "0xE37A30", Offset = "0xE36630", VA = "0x180E37A30")]
			public static BasicCharInfoModel.DefaultIdentityInfoPatchBuilder ParseFromCharData(CharQuery charQuery, EvolvePhase evolvePhase, int level, int potentialRank)
			{
				return default(BasicCharInfoModel.DefaultIdentityInfoPatchBuilder);
			}

			// Token: 0x06015A0A RID: 88586 RVA: 0x0008CFB8 File Offset: 0x0008B1B8
			[Token(Token = "0x6015A0A")]
			[Address(RVA = "0xE37CE0", Offset = "0xE368E0", VA = "0x180E37CE0")]
			public static BasicCharInfoModel.DefaultIdentityInfoPatchBuilder ParseFromIdentityInfo(ICharIdentityInfo identityInfo)
			{
				return default(BasicCharInfoModel.DefaultIdentityInfoPatchBuilder);
			}

			// Token: 0x06015A0B RID: 88587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015A0B")]
			[Address(RVA = "0xE378B0", Offset = "0xE364B0", VA = "0x180E378B0", Slot = "5")]
			public BasicCharInfoModel BuildTo(BasicCharInfoModel basicCharInfo)
			{
				return null;
			}

			// Token: 0x04019EEB RID: 106219
			[Token(Token = "0x4019EEB")]
			[FieldOffset(Offset = "0x0")]
			public int instId;

			// Token: 0x04019EEC RID: 106220
			[Token(Token = "0x4019EEC")]
			[FieldOffset(Offset = "0x4")]
			public bool instAble;

			// Token: 0x04019EED RID: 106221
			[Token(Token = "0x4019EED")]
			[FieldOffset(Offset = "0x8")]
			public string charId;

			// Token: 0x04019EEE RID: 106222
			[Token(Token = "0x4019EEE")]
			[FieldOffset(Offset = "0x10")]
			public string tmplId;

			// Token: 0x04019EEF RID: 106223
			[Token(Token = "0x4019EEF")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04019EF0 RID: 106224
			[Token(Token = "0x4019EF0")]
			[FieldOffset(Offset = "0x20")]
			public int sortIndex;

			// Token: 0x04019EF1 RID: 106225
			[Token(Token = "0x4019EF1")]
			[FieldOffset(Offset = "0x24")]
			public RarityRank rarity;

			// Token: 0x04019EF2 RID: 106226
			[Token(Token = "0x4019EF2")]
			[FieldOffset(Offset = "0x28")]
			public ProfessionCategory profession;

			// Token: 0x04019EF3 RID: 106227
			[Token(Token = "0x4019EF3")]
			[FieldOffset(Offset = "0x2C")]
			public EvolvePhase evolvePhase;

			// Token: 0x04019EF4 RID: 106228
			[Token(Token = "0x4019EF4")]
			[FieldOffset(Offset = "0x30")]
			public int level;

			// Token: 0x04019EF5 RID: 106229
			[Token(Token = "0x4019EF5")]
			[FieldOffset(Offset = "0x34")]
			public int potentialRank;

			// Token: 0x04019EF6 RID: 106230
			[Token(Token = "0x4019EF6")]
			[FieldOffset(Offset = "0x38")]
			public int favorPoint;

			// Token: 0x04019EF7 RID: 106231
			[Token(Token = "0x4019EF7")]
			[FieldOffset(Offset = "0x40")]
			public CharacterData charData;

			// Token: 0x04019EF8 RID: 106232
			[Token(Token = "0x4019EF8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x04019EF9 RID: 106233
			[Token(Token = "0x4019EF9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ParseFromPlayerCharacter;

			// Token: 0x04019EFA RID: 106234
			[Token(Token = "0x4019EFA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ParseFromCharData;

			// Token: 0x04019EFB RID: 106235
			[Token(Token = "0x4019EFB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ParseFromIdentityInfo;

			// Token: 0x04019EFC RID: 106236
			[Token(Token = "0x4019EFC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}

		// Token: 0x020034F9 RID: 13561
		[Token(Token = "0x20034F9")]
		public struct DefaultDetailInfoPatchBuilder : ICharInfoPatchBuilder<BasicCharInfoModel>, IHotfixable
		{
			// Token: 0x1700333E RID: 13118
			// (get) Token: 0x06015A0C RID: 88588 RVA: 0x0008CFD0 File Offset: 0x0008B1D0
			[Token(Token = "0x1700333E")]
			public bool isEmpty
			{
				[Token(Token = "0x6015A0C")]
				[Address(RVA = "0xE37830", Offset = "0xE36430", VA = "0x180E37830", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06015A0D RID: 88589 RVA: 0x0008CFE8 File Offset: 0x0008B1E8
			[Token(Token = "0x6015A0D")]
			[Address(RVA = "0xE374E0", Offset = "0xE360E0", VA = "0x180E374E0")]
			public static BasicCharInfoModel.DefaultDetailInfoPatchBuilder ParseFromPlayerCharacter(PlayerCharacter playerChar)
			{
				return default(BasicCharInfoModel.DefaultDetailInfoPatchBuilder);
			}

			// Token: 0x06015A0E RID: 88590 RVA: 0x0008D000 File Offset: 0x0008B200
			[Token(Token = "0x6015A0E")]
			[Address(RVA = "0xE36EF0", Offset = "0xE35AF0", VA = "0x180E36EF0")]
			public static BasicCharInfoModel.DefaultDetailInfoPatchBuilder ParseFromCharData(CharQuery charQuery, EvolvePhase evolvePhase, int level, int potentialRank)
			{
				return default(BasicCharInfoModel.DefaultDetailInfoPatchBuilder);
			}

			// Token: 0x06015A0F RID: 88591 RVA: 0x0008D018 File Offset: 0x0008B218
			[Token(Token = "0x6015A0F")]
			[Address(RVA = "0xE371C0", Offset = "0xE35DC0", VA = "0x180E371C0")]
			public static BasicCharInfoModel.DefaultDetailInfoPatchBuilder ParseFromDetailInfo(ICharDetailInfo detailInfo)
			{
				return default(BasicCharInfoModel.DefaultDetailInfoPatchBuilder);
			}

			// Token: 0x06015A10 RID: 88592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015A10")]
			[Address(RVA = "0xE36DC0", Offset = "0xE359C0", VA = "0x180E36DC0", Slot = "5")]
			public BasicCharInfoModel BuildTo(BasicCharInfoModel basicCharInfo)
			{
				return null;
			}

			// Token: 0x04019EFD RID: 106237
			[Token(Token = "0x4019EFD")]
			[FieldOffset(Offset = "0x0")]
			public string nickName;

			// Token: 0x04019EFE RID: 106238
			[Token(Token = "0x4019EFE")]
			[FieldOffset(Offset = "0x8")]
			public string subProfessionId;

			// Token: 0x04019EFF RID: 106239
			[Token(Token = "0x4019EFF")]
			[FieldOffset(Offset = "0x10")]
			public int maxLevel;

			// Token: 0x04019F00 RID: 106240
			[Token(Token = "0x4019F00")]
			[FieldOffset(Offset = "0x14")]
			public float expPercent;

			// Token: 0x04019F01 RID: 106241
			[Token(Token = "0x4019F01")]
			[FieldOffset(Offset = "0x18")]
			public string description;

			// Token: 0x04019F02 RID: 106242
			[Token(Token = "0x4019F02")]
			[FieldOffset(Offset = "0x20")]
			public string positionStr;

			// Token: 0x04019F03 RID: 106243
			[Token(Token = "0x4019F03")]
			[FieldOffset(Offset = "0x28")]
			public DateTime gainTime;

			// Token: 0x04019F04 RID: 106244
			[Token(Token = "0x4019F04")]
			[FieldOffset(Offset = "0x30")]
			public CharStarMarkState starMark;

			// Token: 0x04019F05 RID: 106245
			[Token(Token = "0x4019F05")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x04019F06 RID: 106246
			[Token(Token = "0x4019F06")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ParseFromPlayerCharacter;

			// Token: 0x04019F07 RID: 106247
			[Token(Token = "0x4019F07")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ParseFromCharData;

			// Token: 0x04019F08 RID: 106248
			[Token(Token = "0x4019F08")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ParseFromDetailInfo;

			// Token: 0x04019F09 RID: 106249
			[Token(Token = "0x4019F09")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}

		// Token: 0x020034FA RID: 13562
		[Token(Token = "0x20034FA")]
		public struct DefaultAttrInfoPatchBuilder : ICharInfoPatchBuilder<BasicCharInfoModel>, IHotfixable
		{
			// Token: 0x1700333F RID: 13119
			// (get) Token: 0x06015A11 RID: 88593 RVA: 0x0008D030 File Offset: 0x0008B230
			[Token(Token = "0x1700333F")]
			public bool isEmpty
			{
				[Token(Token = "0x6015A11")]
				[Address(RVA = "0xE36D60", Offset = "0xE35960", VA = "0x180E36D60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06015A12 RID: 88594 RVA: 0x0008D048 File Offset: 0x0008B248
			[Token(Token = "0x6015A12")]
			[Address(RVA = "0xE36AE0", Offset = "0xE356E0", VA = "0x180E36AE0")]
			public static BasicCharInfoModel.DefaultAttrInfoPatchBuilder ParseFromPlayerCharacter(PlayerCharacter playerChar)
			{
				return default(BasicCharInfoModel.DefaultAttrInfoPatchBuilder);
			}

			// Token: 0x06015A13 RID: 88595 RVA: 0x0008D060 File Offset: 0x0008B260
			[Token(Token = "0x6015A13")]
			[Address(RVA = "0xE367B0", Offset = "0xE353B0", VA = "0x180E367B0")]
			public static BasicCharInfoModel.DefaultAttrInfoPatchBuilder ParseFromCharData(CharQuery charQuery, EvolvePhase evolvePhase, int level, int potentialRank, int favorPoint, ICharEquipInfo equipInfo)
			{
				return default(BasicCharInfoModel.DefaultAttrInfoPatchBuilder);
			}

			// Token: 0x06015A14 RID: 88596 RVA: 0x0008D078 File Offset: 0x0008B278
			[Token(Token = "0x6015A14")]
			[Address(RVA = "0xE36690", Offset = "0xE35290", VA = "0x180E36690")]
			public static BasicCharInfoModel.DefaultAttrInfoPatchBuilder ParseFromAttrInfo(ICharAttrInfo attrInfo)
			{
				return default(BasicCharInfoModel.DefaultAttrInfoPatchBuilder);
			}

			// Token: 0x06015A15 RID: 88597 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015A15")]
			[Address(RVA = "0xE36600", Offset = "0xE35200", VA = "0x180E36600", Slot = "5")]
			public BasicCharInfoModel BuildTo(BasicCharInfoModel basicCharInfo)
			{
				return null;
			}

			// Token: 0x04019F0A RID: 106250
			[Token(Token = "0x4019F0A")]
			[FieldOffset(Offset = "0x0")]
			public AttributesData attrData;

			// Token: 0x04019F0B RID: 106251
			[Token(Token = "0x4019F0B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x04019F0C RID: 106252
			[Token(Token = "0x4019F0C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ParseFromPlayerCharacter;

			// Token: 0x04019F0D RID: 106253
			[Token(Token = "0x4019F0D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ParseFromCharData;

			// Token: 0x04019F0E RID: 106254
			[Token(Token = "0x4019F0E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ParseFromAttrInfo;

			// Token: 0x04019F0F RID: 106255
			[Token(Token = "0x4019F0F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}

		// Token: 0x020034FB RID: 13563
		[Token(Token = "0x20034FB")]
		public struct DefaultSkinInfoPatchBuilder : ICharInfoPatchBuilder<BasicCharInfoModel>, IHotfixable
		{
			// Token: 0x17003340 RID: 13120
			// (get) Token: 0x06015A16 RID: 88598 RVA: 0x0008D090 File Offset: 0x0008B290
			[Token(Token = "0x17003340")]
			public bool isEmpty
			{
				[Token(Token = "0x6015A16")]
				[Address(RVA = "0xE38820", Offset = "0xE37420", VA = "0x180E38820", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06015A17 RID: 88599 RVA: 0x0008D0A8 File Offset: 0x0008B2A8
			[Token(Token = "0x6015A17")]
			[Address(RVA = "0xE385A0", Offset = "0xE371A0", VA = "0x180E385A0")]
			public static BasicCharInfoModel.DefaultSkinInfoPatchBuilder ParseFromPlayerCharacter(PlayerCharacter playerChar, bool instAble)
			{
				return default(BasicCharInfoModel.DefaultSkinInfoPatchBuilder);
			}

			// Token: 0x06015A18 RID: 88600 RVA: 0x0008D0C0 File Offset: 0x0008B2C0
			[Token(Token = "0x6015A18")]
			[Address(RVA = "0xE383F0", Offset = "0xE36FF0", VA = "0x180E383F0")]
			public static BasicCharInfoModel.DefaultSkinInfoPatchBuilder ParseFromCharData(CharQuery charQuery, EvolvePhase evolvePhase)
			{
				return default(BasicCharInfoModel.DefaultSkinInfoPatchBuilder);
			}

			// Token: 0x06015A19 RID: 88601 RVA: 0x0008D0D8 File Offset: 0x0008B2D8
			[Token(Token = "0x6015A19")]
			[Address(RVA = "0xE38780", Offset = "0xE37380", VA = "0x180E38780")]
			public static BasicCharInfoModel.DefaultSkinInfoPatchBuilder ParseFromSkinInfo(ICharSkinInfo skinInfo)
			{
				return default(BasicCharInfoModel.DefaultSkinInfoPatchBuilder);
			}

			// Token: 0x06015A1A RID: 88602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015A1A")]
			[Address(RVA = "0xE38310", Offset = "0xE36F10", VA = "0x180E38310", Slot = "5")]
			public BasicCharInfoModel BuildTo(BasicCharInfoModel basicCharInfo)
			{
				return null;
			}

			// Token: 0x04019F10 RID: 106256
			[Token(Token = "0x4019F10")]
			[FieldOffset(Offset = "0x0")]
			public string skinId;

			// Token: 0x04019F11 RID: 106257
			[Token(Token = "0x4019F11")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x04019F12 RID: 106258
			[Token(Token = "0x4019F12")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ParseFromPlayerCharacter;

			// Token: 0x04019F13 RID: 106259
			[Token(Token = "0x4019F13")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ParseFromCharData;

			// Token: 0x04019F14 RID: 106260
			[Token(Token = "0x4019F14")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ParseFromSkinInfo;

			// Token: 0x04019F15 RID: 106261
			[Token(Token = "0x4019F15")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}
	}
}
