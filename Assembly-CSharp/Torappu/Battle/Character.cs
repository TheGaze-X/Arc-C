using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using Torappu.Battle.Effects;
using Torappu.Battle.TPhysic2D;
using Torappu.Battle.UI;
using Torappu.CharWord;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025A3 RID: 9635
	[Token(Token = "0x20025A3")]
	[SelectionBase]
	public class Character : Unit, IBuildable, ILocatable
	{
		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x0600F866 RID: 63590 RVA: 0x0005D0F0 File Offset: 0x0005B2F0
		[Token(Token = "0x1700209C")]
		protected virtual SideType initSideType
		{
			[Token(Token = "0x600F866")]
			[Address(RVA = "0x706C10", Offset = "0x705810", VA = "0x180706C10", Slot = "193")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x0600F867 RID: 63591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700209D")]
		public Transform skinHolder
		{
			[Token(Token = "0x600F867")]
			[Address(RVA = "0x708560", Offset = "0x707160", VA = "0x180708560")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x0600F868 RID: 63592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700209E")]
		public override Transform graphicHolderTransform
		{
			[Token(Token = "0x600F868")]
			[Address(RVA = "0x706520", Offset = "0x705120", VA = "0x180706520", Slot = "61")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x0600F869 RID: 63593 RVA: 0x0005D108 File Offset: 0x0005B308
		[Token(Token = "0x1700209F")]
		public override bool alive
		{
			[Token(Token = "0x600F869")]
			[Address(RVA = "0x705080", Offset = "0x703C80", VA = "0x180705080", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x0600F86A RID: 63594 RVA: 0x0005D120 File Offset: 0x0005B320
		[Token(Token = "0x170020A0")]
		public Deck.Card.AdvancedCardBuildState advancedBuildState
		{
			[Token(Token = "0x600F86A")]
			[Address(RVA = "0x704F50", Offset = "0x703B50", VA = "0x180704F50")]
			get
			{
				return Deck.Card.AdvancedCardBuildState.DEFAULT;
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x0600F86B RID: 63595 RVA: 0x0005D138 File Offset: 0x0005B338
		[Token(Token = "0x170020A1")]
		public override bool aliveOrDying
		{
			[Token(Token = "0x600F86B")]
			[Address(RVA = "0x704FC0", Offset = "0x703BC0", VA = "0x180704FC0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x0600F86C RID: 63596 RVA: 0x0005D150 File Offset: 0x0005B350
		[Token(Token = "0x170020A2")]
		public bool disableClickCharacterInfo
		{
			[Token(Token = "0x600F86C")]
			[Address(RVA = "0x706370", Offset = "0x704F70", VA = "0x180706370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x0600F86D RID: 63597 RVA: 0x0005D168 File Offset: 0x0005B368
		[Token(Token = "0x170020A3")]
		public bool canBlockEnemyOnRootTile
		{
			[Token(Token = "0x600F86D")]
			[Address(RVA = "0x705B00", Offset = "0x704700", VA = "0x180705B00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x0600F86E RID: 63598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020A4")]
		public override UnitMode defaultMode
		{
			[Token(Token = "0x600F86E")]
			[Address(RVA = "0x706050", Offset = "0x704C50", VA = "0x180706050", Slot = "141")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x0600F86F RID: 63599 RVA: 0x0005D180 File Offset: 0x0005B380
		[Token(Token = "0x170020A5")]
		public int defaultModeIndex
		{
			[Token(Token = "0x600F86F")]
			[Address(RVA = "0x705FE0", Offset = "0x704BE0", VA = "0x180705FE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x0600F870 RID: 63600 RVA: 0x0005D198 File Offset: 0x0005B398
		// (set) Token: 0x0600F871 RID: 63601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170020A6")]
		public uint cardUid
		{
			[Token(Token = "0x600F870")]
			[Address(RVA = "0x705C10", Offset = "0x704810", VA = "0x180705C10")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600F871")]
			[Address(RVA = "0x708E30", Offset = "0x707A30", VA = "0x180708E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x0600F872 RID: 63602 RVA: 0x0005D1B0 File Offset: 0x0005B3B0
		[Token(Token = "0x170020A7")]
		public uint tokenOrHostUid
		{
			[Token(Token = "0x600F872")]
			[Address(RVA = "0x708830", Offset = "0x707430", VA = "0x180708830")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x0600F873 RID: 63603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020A8")]
		public string characterId
		{
			[Token(Token = "0x600F873")]
			[Address(RVA = "0x705C80", Offset = "0x704880", VA = "0x180705C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x0600F874 RID: 63604 RVA: 0x0005D1C8 File Offset: 0x0005B3C8
		[Token(Token = "0x170020A9")]
		public bool playStartVocal
		{
			[Token(Token = "0x600F874")]
			[Address(RVA = "0x707CE0", Offset = "0x7068E0", VA = "0x180707CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x0600F875 RID: 63605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020AA")]
		public override Tile rootTile
		{
			[Token(Token = "0x600F875")]
			[Address(RVA = "0x708030", Offset = "0x706C30", VA = "0x180708030", Slot = "50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x0600F876 RID: 63606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020AB")]
		public override Tile oldTile
		{
			[Token(Token = "0x600F876")]
			[Address(RVA = "0x707970", Offset = "0x706570", VA = "0x180707970", Slot = "51")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x0600F877 RID: 63607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020AC")]
		public override UnitAnimator animator
		{
			[Token(Token = "0x600F877")]
			[Address(RVA = "0x705230", Offset = "0x703E30", VA = "0x180705230", Slot = "158")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x0600F878 RID: 63608 RVA: 0x0005D1E0 File Offset: 0x0005B3E0
		[Token(Token = "0x170020AD")]
		public override bool isInCombat
		{
			[Token(Token = "0x600F878")]
			[Address(RVA = "0x706F10", Offset = "0x705B10", VA = "0x180706F10", Slot = "149")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x0600F879 RID: 63609 RVA: 0x0005D1F8 File Offset: 0x0005B3F8
		[Token(Token = "0x170020AE")]
		public override FP hatred
		{
			[Token(Token = "0x600F879")]
			[Address(RVA = "0x7067C0", Offset = "0x7053C0", VA = "0x1807067C0", Slot = "46")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x0600F87A RID: 63610 RVA: 0x0005D210 File Offset: 0x0005B410
		[Token(Token = "0x170020AF")]
		public override FP maxEs
		{
			[Token(Token = "0x600F87A")]
			[Address(RVA = "0x7076F0", Offset = "0x7062F0", VA = "0x1807076F0", Slot = "79")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x0600F87B RID: 63611 RVA: 0x0005D228 File Offset: 0x0005B428
		[Token(Token = "0x170020B0")]
		public FP maxEsRatio
		{
			[Token(Token = "0x600F87B")]
			[Address(RVA = "0x707670", Offset = "0x706270", VA = "0x180707670")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x0600F87C RID: 63612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020B1")]
		public override string talentRange
		{
			[Token(Token = "0x600F87C")]
			[Address(RVA = "0x7087B0", Offset = "0x7073B0", VA = "0x1807087B0", Slot = "143")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x0600F87D RID: 63613 RVA: 0x0005D240 File Offset: 0x0005B440
		[Token(Token = "0x170020B2")]
		public BuildCondition originBuildCondition
		{
			[Token(Token = "0x600F87D")]
			[Address(RVA = "0x7079F0", Offset = "0x7065F0", VA = "0x1807079F0")]
			get
			{
				return default(BuildCondition);
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x0600F87E RID: 63614 RVA: 0x0005D258 File Offset: 0x0005B458
		[Token(Token = "0x170020B3")]
		public BuildCondition buildCondition
		{
			[Token(Token = "0x600F87E")]
			[Address(RVA = "0x705820", Offset = "0x704420", VA = "0x180705820", Slot = "191")]
			get
			{
				return default(BuildCondition);
			}
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x0600F87F RID: 63615 RVA: 0x0005D270 File Offset: 0x0005B470
		[Token(Token = "0x170020B4")]
		public AdditionalBuildCondition additionalBuildCondition
		{
			[Token(Token = "0x600F87F")]
			[Address(RVA = "0x704DB0", Offset = "0x7039B0", VA = "0x180704DB0")]
			get
			{
				return default(AdditionalBuildCondition);
			}
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x0600F880 RID: 63616 RVA: 0x0005D288 File Offset: 0x0005B488
		[Token(Token = "0x170020B5")]
		public BuildableType additionalBuildType
		{
			[Token(Token = "0x600F880")]
			[Address(RVA = "0x704E50", Offset = "0x703A50", VA = "0x180704E50")]
			get
			{
				return BuildableType.NONE;
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x0600F881 RID: 63617 RVA: 0x0005D2A0 File Offset: 0x0005B4A0
		[Token(Token = "0x170020B6")]
		public AdvancedBuildableMask addtionalMask
		{
			[Token(Token = "0x600F881")]
			[Address(RVA = "0x704ED0", Offset = "0x703AD0", VA = "0x180704ED0")]
			get
			{
				return AdvancedBuildableMask.NONE;
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x0600F882 RID: 63618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020B7")]
		public override Ability attack
		{
			[Token(Token = "0x600F882")]
			[Address(RVA = "0x7053C0", Offset = "0x703FC0", VA = "0x1807053C0", Slot = "146")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x0600F883 RID: 63619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020B8")]
		public Ability rawAttackWithoutReplacement
		{
			[Token(Token = "0x600F883")]
			[Address(RVA = "0x707E60", Offset = "0x706A60", VA = "0x180707E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x0600F884 RID: 63620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020B9")]
		public override Ability combat
		{
			[Token(Token = "0x600F884")]
			[Address(RVA = "0x705D10", Offset = "0x704910", VA = "0x180705D10", Slot = "144")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x0600F885 RID: 63621 RVA: 0x0005D2B8 File Offset: 0x0005B4B8
		[Token(Token = "0x170020BA")]
		public override bool hasCombat
		{
			[Token(Token = "0x600F885")]
			[Address(RVA = "0x7065E0", Offset = "0x7051E0", VA = "0x1807065E0", Slot = "145")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x0600F886 RID: 63622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020BB")]
		protected Ability rawCombatWithoutReplacement
		{
			[Token(Token = "0x600F886")]
			[Address(RVA = "0x707EE0", Offset = "0x706AE0", VA = "0x180707EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x0600F887 RID: 63623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020BC")]
		public override TargetTrigger attackTrigger
		{
			[Token(Token = "0x600F887")]
			[Address(RVA = "0x7052B0", Offset = "0x703EB0", VA = "0x1807052B0", Slot = "147")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x0600F888 RID: 63624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020BD")]
		public BasicSkill skill
		{
			[Token(Token = "0x600F888")]
			[Address(RVA = "0x7084E0", Offset = "0x7070E0", VA = "0x1807084E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x0600F889 RID: 63625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020BE")]
		public SkillData skillData
		{
			[Token(Token = "0x600F889")]
			[Address(RVA = "0x7083E0", Offset = "0x706FE0", VA = "0x1807083E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x0600F88A RID: 63626 RVA: 0x0005D2D0 File Offset: 0x0005B4D0
		[Token(Token = "0x170020BF")]
		public virtual bool hideTileOption
		{
			[Token(Token = "0x600F88A")]
			[Address(RVA = "0x706840", Offset = "0x705440", VA = "0x180706840", Slot = "194")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x0600F88B RID: 63627 RVA: 0x0005D2E8 File Offset: 0x0005B4E8
		[Token(Token = "0x170020C0")]
		public bool hasSkill
		{
			[Token(Token = "0x600F88B")]
			[Address(RVA = "0x706710", Offset = "0x705310", VA = "0x180706710")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x0600F88C RID: 63628 RVA: 0x0005D300 File Offset: 0x0005B500
		[Token(Token = "0x170020C1")]
		protected bool showSkill
		{
			[Token(Token = "0x600F88C")]
			[Address(RVA = "0x708230", Offset = "0x706E30", VA = "0x180708230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x0600F88D RID: 63629 RVA: 0x0005D318 File Offset: 0x0005B518
		[Token(Token = "0x170020C2")]
		public virtual bool showHpSlider
		{
			[Token(Token = "0x600F88D")]
			[Address(RVA = "0x708150", Offset = "0x706D50", VA = "0x180708150", Slot = "195")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x0600F88E RID: 63630 RVA: 0x0005D330 File Offset: 0x0005B530
		[Token(Token = "0x170020C3")]
		public virtual bool showSpSlider
		{
			[Token(Token = "0x600F88E")]
			[Address(RVA = "0x708370", Offset = "0x706F70", VA = "0x180708370", Slot = "196")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x0600F88F RID: 63631 RVA: 0x0005D348 File Offset: 0x0005B548
		[Token(Token = "0x170020C4")]
		public virtual bool showShield
		{
			[Token(Token = "0x600F88F")]
			[Address(RVA = "0x7081C0", Offset = "0x706DC0", VA = "0x1807081C0", Slot = "197")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x0600F890 RID: 63632 RVA: 0x0005D360 File Offset: 0x0005B560
		[Token(Token = "0x170020C5")]
		public virtual bool forceUseAllyHud
		{
			[Token(Token = "0x600F890")]
			[Address(RVA = "0x7064B0", Offset = "0x7050B0", VA = "0x1807064B0", Slot = "198")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x0600F891 RID: 63633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020C6")]
		public Ability traitAbility
		{
			[Token(Token = "0x600F891")]
			[Address(RVA = "0x7088C0", Offset = "0x7074C0", VA = "0x1807088C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x0600F892 RID: 63634 RVA: 0x0005D378 File Offset: 0x0005B578
		[Token(Token = "0x170020C7")]
		public bool dontMoveCameraWhenFocus
		{
			[Token(Token = "0x600F892")]
			[Address(RVA = "0x706430", Offset = "0x705030", VA = "0x180706430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x0600F893 RID: 63635 RVA: 0x0005D390 File Offset: 0x0005B590
		[Token(Token = "0x170020C8")]
		public bool disableCharInfoPanel
		{
			[Token(Token = "0x600F893")]
			[Address(RVA = "0x7062F0", Offset = "0x704EF0", VA = "0x1807062F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x0600F894 RID: 63636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020C9")]
		public Ability traitOrTraitAsTalentAbility
		{
			[Token(Token = "0x600F894")]
			[Address(RVA = "0x708B20", Offset = "0x707720", VA = "0x180708B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x0600F895 RID: 63637 RVA: 0x0005D3A8 File Offset: 0x0005B5A8
		[Token(Token = "0x170020CA")]
		public bool traitAsTalent
		{
			[Token(Token = "0x600F895")]
			[Address(RVA = "0x708940", Offset = "0x707540", VA = "0x180708940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x0600F896 RID: 63638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020CB")]
		public override IDrawableRange rangeToShow
		{
			[Token(Token = "0x600F896")]
			[Address(RVA = "0x707D60", Offset = "0x706960", VA = "0x180707D60", Slot = "155")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x0600F897 RID: 63639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020CC")]
		public override string defaultRangeId
		{
			[Token(Token = "0x600F897")]
			[Address(RVA = "0x7060F0", Offset = "0x704CF0", VA = "0x1807060F0", Slot = "157")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x0600F898 RID: 63640 RVA: 0x0005D3C0 File Offset: 0x0005B5C0
		[Token(Token = "0x170020CD")]
		public bool isToken
		{
			[Token(Token = "0x600F898")]
			[Address(RVA = "0x7073D0", Offset = "0x705FD0", VA = "0x1807073D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x0600F899 RID: 63641 RVA: 0x0005D3D8 File Offset: 0x0005B5D8
		[Token(Token = "0x170020CE")]
		public bool originOccupiedRemainingCharacterCnt
		{
			[Token(Token = "0x600F899")]
			[Address(RVA = "0x707AD0", Offset = "0x7066D0", VA = "0x180707AD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x0600F89A RID: 63642 RVA: 0x0005D3F0 File Offset: 0x0005B5F0
		[Token(Token = "0x170020CF")]
		public virtual bool occupiedRemainingCharacterCnt
		{
			[Token(Token = "0x600F89A")]
			[Address(RVA = "0x707880", Offset = "0x706480", VA = "0x180707880", Slot = "199")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x0600F89B RID: 63643 RVA: 0x0005D408 File Offset: 0x0005B608
		// (set) Token: 0x0600F89C RID: 63644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170020D0")]
		public virtual int originRemainingCharacterCntVolume
		{
			[Token(Token = "0x600F89B")]
			[Address(RVA = "0x707B60", Offset = "0x706760", VA = "0x180707B60", Slot = "200")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600F89C")]
			[Address(RVA = "0x708F60", Offset = "0x707B60", VA = "0x180708F60", Slot = "201")]
			set
			{
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x0600F89D RID: 63645 RVA: 0x0005D420 File Offset: 0x0005B620
		[Token(Token = "0x170020D1")]
		public virtual int remainingCharacterCntVolume
		{
			[Token(Token = "0x600F89D")]
			[Address(RVA = "0x707F60", Offset = "0x706B60", VA = "0x180707F60", Slot = "202")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x0600F89E RID: 63646 RVA: 0x0005D438 File Offset: 0x0005B638
		[Token(Token = "0x170020D2")]
		public bool overflowOccupiedCnt
		{
			[Token(Token = "0x600F89E")]
			[Address(RVA = "0x707BE0", Offset = "0x7067E0", VA = "0x180707BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x0600F89F RID: 63647 RVA: 0x0005D450 File Offset: 0x0005B650
		[Token(Token = "0x170020D3")]
		public virtual bool withdrawable
		{
			[Token(Token = "0x600F89F")]
			[Address(RVA = "0x708CE0", Offset = "0x7078E0", VA = "0x180708CE0", Slot = "203")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x0600F8A0 RID: 63648 RVA: 0x0005D468 File Offset: 0x0005B668
		[Token(Token = "0x170020D4")]
		public bool isManuallySpawned
		{
			[Token(Token = "0x600F8A0")]
			[Address(RVA = "0x7071E0", Offset = "0x705DE0", VA = "0x1807071E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x0600F8A1 RID: 63649 RVA: 0x0005D480 File Offset: 0x0005B680
		[Token(Token = "0x170020D5")]
		public bool manuallyWithdrawable
		{
			[Token(Token = "0x600F8A1")]
			[Address(RVA = "0x707570", Offset = "0x706170", VA = "0x180707570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x0600F8A2 RID: 63650 RVA: 0x0005D498 File Offset: 0x0005B698
		[Token(Token = "0x170020D6")]
		public override bool isMine
		{
			[Token(Token = "0x600F8A2")]
			[Address(RVA = "0x707260", Offset = "0x705E60", VA = "0x180707260", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F8A3 RID: 63651 RVA: 0x0005D4B0 File Offset: 0x0005B6B0
		[Token(Token = "0x600F8A3")]
		[Address(RVA = "0x6F7940", Offset = "0x6F6540", VA = "0x1806F7940")]
		public bool IsControllable(PlayerSide opSide)
		{
			return default(bool);
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x0600F8A4 RID: 63652 RVA: 0x0005D4C8 File Offset: 0x0005B6C8
		[Token(Token = "0x170020D7")]
		public bool isBuiltPredefined
		{
			[Token(Token = "0x600F8A4")]
			[Address(RVA = "0x706CF0", Offset = "0x7058F0", VA = "0x180706CF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x0600F8A5 RID: 63653 RVA: 0x0005D4E0 File Offset: 0x0005B6E0
		[Token(Token = "0x170020D8")]
		protected bool isPlayerCharacter
		{
			[Token(Token = "0x600F8A5")]
			[Address(RVA = "0x707310", Offset = "0x705F10", VA = "0x180707310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x0600F8A6 RID: 63654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020D9")]
		public override Transform directionTransform
		{
			[Token(Token = "0x600F8A6")]
			[Address(RVA = "0x706270", Offset = "0x704E70", VA = "0x180706270", Slot = "62")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x0600F8A7 RID: 63655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020DA")]
		public IList<Enemy> blockedEnemies
		{
			[Token(Token = "0x600F8A7")]
			[Address(RVA = "0x705700", Offset = "0x704300", VA = "0x180705700")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x0600F8A8 RID: 63656 RVA: 0x0005D4F8 File Offset: 0x0005B6F8
		[Token(Token = "0x170020DB")]
		public int blockedTotalVolumn
		{
			[Token(Token = "0x600F8A8")]
			[Address(RVA = "0x705790", Offset = "0x704390", VA = "0x180705790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x0600F8A9 RID: 63657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020DC")]
		public Transform directionIndicator
		{
			[Token(Token = "0x600F8A9")]
			[Address(RVA = "0x7061F0", Offset = "0x704DF0", VA = "0x1807061F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x0600F8AA RID: 63658 RVA: 0x0005D510 File Offset: 0x0005B710
		[Token(Token = "0x170020DD")]
		public virtual float blockRadiusSquare
		{
			[Token(Token = "0x600F8AA")]
			[Address(RVA = "0x705660", Offset = "0x704260", VA = "0x180705660", Slot = "204")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x0600F8AB RID: 63659 RVA: 0x0005D528 File Offset: 0x0005B728
		[Token(Token = "0x170020DE")]
		public virtual TCircle blockCircle
		{
			[Token(Token = "0x600F8AB")]
			[Address(RVA = "0x705470", Offset = "0x704070", VA = "0x180705470", Slot = "205")]
			get
			{
				return default(TCircle);
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x0600F8AC RID: 63660 RVA: 0x0005D540 File Offset: 0x0005B740
		[Token(Token = "0x170020DF")]
		public virtual float minBlockDistToTarget
		{
			[Token(Token = "0x600F8AC")]
			[Address(RVA = "0x707800", Offset = "0x706400", VA = "0x180707800", Slot = "206")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x0600F8AD RID: 63661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020E0")]
		public Blackboard traitBlackboard
		{
			[Token(Token = "0x600F8AD")]
			[Address(RVA = "0x708A00", Offset = "0x707600", VA = "0x180708A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F8AE RID: 63662 RVA: 0x0005D558 File Offset: 0x0005B758
		[Token(Token = "0x600F8AE")]
		[Address(RVA = "0x6F7850", Offset = "0x6F6450", VA = "0x1806F7850")]
		public VoiceQuery GetVoiceQuery()
		{
			return default(VoiceQuery);
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x0600F8AF RID: 63663 RVA: 0x0005D570 File Offset: 0x0005B770
		[Token(Token = "0x170020E1")]
		public MotionMode blockMode
		{
			[Token(Token = "0x600F8AF")]
			[Address(RVA = "0x705570", Offset = "0x704170", VA = "0x180705570")]
			get
			{
				return MotionMode.WALK;
			}
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x0600F8B0 RID: 63664 RVA: 0x0005D588 File Offset: 0x0005B788
		[Token(Token = "0x170020E2")]
		public bool ignoreBlockMode
		{
			[Token(Token = "0x600F8B0")]
			[Address(RVA = "0x706B90", Offset = "0x705790", VA = "0x180706B90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x0600F8B1 RID: 63665 RVA: 0x0005D5A0 File Offset: 0x0005B7A0
		[Token(Token = "0x170020E3")]
		protected override bool isFixedRotation
		{
			[Token(Token = "0x600F8B1")]
			[Address(RVA = "0x706D70", Offset = "0x705970", VA = "0x180706D70", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x0600F8B2 RID: 63666 RVA: 0x0005D5B8 File Offset: 0x0005B7B8
		[Token(Token = "0x170020E4")]
		protected override int initState
		{
			[Token(Token = "0x600F8B2")]
			[Address(RVA = "0x706C80", Offset = "0x705880", VA = "0x180706C80", Slot = "68")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x0600F8B3 RID: 63667 RVA: 0x0005D5D0 File Offset: 0x0005B7D0
		[Token(Token = "0x170020E5")]
		protected override float delayToRecycle
		{
			[Token(Token = "0x600F8B3")]
			[Address(RVA = "0x706170", Offset = "0x704D70", VA = "0x180706170", Slot = "66")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x0600F8B4 RID: 63668 RVA: 0x0005D5E8 File Offset: 0x0005B7E8
		[Token(Token = "0x170020E6")]
		protected virtual bool allowWithdrawGainCost
		{
			[Token(Token = "0x600F8B4")]
			[Address(RVA = "0x705120", Offset = "0x703D20", VA = "0x180705120", Slot = "207")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F8B5 RID: 63669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8B5")]
		[Address(RVA = "0x6FD6D0", Offset = "0x6FC2D0", VA = "0x1806FD6D0")]
		public void SetExternWithdrawGainCostFlag(bool value)
		{
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x0600F8B6 RID: 63670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020E7")]
		protected HierachyStateMachine<Character.States.State, Character, Character.States.Blackboard> stateMachine
		{
			[Token(Token = "0x600F8B6")]
			[Address(RVA = "0x7086B0", Offset = "0x7072B0", VA = "0x1807086B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x0600F8B7 RID: 63671 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F8B8 RID: 63672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170020E8")]
		public BattleCharacterData data
		{
			[Token(Token = "0x600F8B7")]
			[Address(RVA = "0x705E40", Offset = "0x704A40", VA = "0x180705E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600F8B8")]
			[Address(RVA = "0x708EC0", Offset = "0x707AC0", VA = "0x180708EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x0600F8B9 RID: 63673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020E9")]
		public BattleCharacterData.SharedData sharedData
		{
			[Token(Token = "0x600F8B9")]
			[Address(RVA = "0x7080B0", Offset = "0x706CB0", VA = "0x1807080B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x0600F8BA RID: 63674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020EA")]
		public override List<ObjectPtr<Projectile>> managedProjectiles
		{
			[Token(Token = "0x600F8BA")]
			[Address(RVA = "0x707460", Offset = "0x706060", VA = "0x180707460", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x0600F8BB RID: 63675 RVA: 0x0005D600 File Offset: 0x0005B800
		[Token(Token = "0x170020EB")]
		public override FP createdTime
		{
			[Token(Token = "0x600F8BB")]
			[Address(RVA = "0x705DC0", Offset = "0x7049C0", VA = "0x180705DC0", Slot = "55")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x0600F8BC RID: 63676 RVA: 0x0005D618 File Offset: 0x0005B818
		[Token(Token = "0x170020EC")]
		public FP deadTime
		{
			[Token(Token = "0x600F8BC")]
			[Address(RVA = "0x705F60", Offset = "0x704B60", VA = "0x180705F60")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x0600F8BD RID: 63677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020ED")]
		protected virtual string startEffect
		{
			[Token(Token = "0x600F8BD")]
			[Address(RVA = "0x7085E0", Offset = "0x7071E0", VA = "0x1807085E0", Slot = "208")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x0600F8BE RID: 63678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170020EE")]
		protected virtual string deadEffect
		{
			[Token(Token = "0x600F8BE")]
			[Address(RVA = "0x705EC0", Offset = "0x704AC0", VA = "0x180705EC0", Slot = "209")]
			get
			{
				return null;
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x0600F8BF RID: 63679 RVA: 0x0005D630 File Offset: 0x0005B830
		[Token(Token = "0x170020EF")]
		protected bool hasReplacement
		{
			[Token(Token = "0x600F8BF")]
			[Address(RVA = "0x706690", Offset = "0x705290", VA = "0x180706690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x0600F8C0 RID: 63680 RVA: 0x0005D648 File Offset: 0x0005B848
		[Token(Token = "0x170020F0")]
		public bool isInSkillState
		{
			[Token(Token = "0x600F8C0")]
			[Address(RVA = "0x707150", Offset = "0x705D50", VA = "0x180707150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x0600F8C1 RID: 63681 RVA: 0x0005D660 File Offset: 0x0005B860
		[Token(Token = "0x170020F1")]
		public override bool isInAttackState
		{
			[Token(Token = "0x600F8C1")]
			[Address(RVA = "0x706DF0", Offset = "0x7059F0", VA = "0x180706DF0", Slot = "150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x0600F8C2 RID: 63682 RVA: 0x0005D678 File Offset: 0x0005B878
		[Token(Token = "0x170020F2")]
		public override bool isInCombatState
		{
			[Token(Token = "0x600F8C2")]
			[Address(RVA = "0x706E80", Offset = "0x705A80", VA = "0x180706E80", Slot = "151")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x0600F8C3 RID: 63683 RVA: 0x0005D690 File Offset: 0x0005B890
		[Token(Token = "0x170020F3")]
		public override bool isInRebornState
		{
			[Token(Token = "0x600F8C3")]
			[Address(RVA = "0x7070C0", Offset = "0x705CC0", VA = "0x1807070C0", Slot = "153")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x0600F8C4 RID: 63684 RVA: 0x0005D6A8 File Offset: 0x0005B8A8
		[Token(Token = "0x170020F4")]
		public bool isInIdletState
		{
			[Token(Token = "0x600F8C4")]
			[Address(RVA = "0x707030", Offset = "0x705C30", VA = "0x180707030")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x0600F8C5 RID: 63685 RVA: 0x0005D6C0 File Offset: 0x0005B8C0
		[Token(Token = "0x170020F5")]
		public override bool isInDyingState
		{
			[Token(Token = "0x600F8C5")]
			[Address(RVA = "0x706FA0", Offset = "0x705BA0", VA = "0x180706FA0", Slot = "152")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x0600F8C6 RID: 63686 RVA: 0x0005D6D8 File Offset: 0x0005B8D8
		[Token(Token = "0x170020F6")]
		public bool canBeReplace
		{
			[Token(Token = "0x600F8C6")]
			[Address(RVA = "0x705A60", Offset = "0x704660", VA = "0x180705A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x0600F8C7 RID: 63687 RVA: 0x0005D6F0 File Offset: 0x0005B8F0
		[Token(Token = "0x170020F7")]
		public bool skillUiFollowHeadPoint
		{
			[Token(Token = "0x600F8C7")]
			[Address(RVA = "0x708460", Offset = "0x707060", VA = "0x180708460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x0600F8C8 RID: 63688 RVA: 0x0005D708 File Offset: 0x0005B908
		[Token(Token = "0x170020F8")]
		public virtual bool alwaysBlockFree
		{
			[Token(Token = "0x600F8C8")]
			[Address(RVA = "0x7051C0", Offset = "0x703DC0", VA = "0x1807051C0", Slot = "210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F8C9 RID: 63689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8C9")]
		[Address(RVA = "0x6FB960", Offset = "0x6FA560", VA = "0x1806FB960")]
		public void PlayBornAnimationAndEffect(ref FP m_remainingTime, Action noBornAnimationFallBack, bool disableEffect = false)
		{
		}

		// Token: 0x0600F8CA RID: 63690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8CA")]
		[Address(RVA = "0x6FDA30", Offset = "0x6FC630", VA = "0x1806FDA30")]
		public void StopBornAnimationAndEffect(string animationKey)
		{
		}

		// Token: 0x0600F8CB RID: 63691 RVA: 0x0005D720 File Offset: 0x0005B920
		[Token(Token = "0x600F8CB")]
		[Address(RVA = "0x6FCD10", Offset = "0x6FB910", VA = "0x1806FCD10")]
		public bool ResetBornAnimationAndEffect(string bornAnimKey, string bornEffect)
		{
			return default(bool);
		}

		// Token: 0x0600F8CC RID: 63692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8CC")]
		[Address(RVA = "0x7029A0", Offset = "0x7015A0", VA = "0x1807029A0")]
		private void _PlayUniEquipEffect(float playSpeed)
		{
		}

		// Token: 0x0600F8CD RID: 63693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8CD")]
		[Address(RVA = "0x6F4060", Offset = "0x6F2C60", VA = "0x1806F4060")]
		public void BuildAt(Deck.Card card, Tile tile, SharedConsts.Direction direction)
		{
		}

		// Token: 0x0600F8CE RID: 63694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8CE")]
		[Address(RVA = "0x6F3CB0", Offset = "0x6F28B0", VA = "0x1806F3CB0")]
		public void BuildAsPredefined(BattleCharacterData data, Tile tile, SharedConsts.Direction direction)
		{
		}

		// Token: 0x0600F8CF RID: 63695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8CF")]
		[Address(RVA = "0x6F3EA0", Offset = "0x6F2AA0", VA = "0x1806F3EA0")]
		public void BuildAsRuntimeInst(BattleCharacterData data, Tile tile, SharedConsts.Direction direction, SideType sideType, PlayerSide pSide)
		{
		}

		// Token: 0x0600F8D0 RID: 63696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8D0")]
		[Address(RVA = "0x6F3B20", Offset = "0x6F2720", VA = "0x1806F3B20", Slot = "24")]
		public override void Born()
		{
		}

		// Token: 0x0600F8D1 RID: 63697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8D1")]
		[Address(RVA = "0x6F7D00", Offset = "0x6F6900", VA = "0x1806F7D00")]
		public void MakeDummy(BattleCharacterData data, SharedConsts.Direction direction, AdditionalBuildCondition additionalBuildCondition, PlayerSide deckPlayerSide = PlayerSide.DEFAULT)
		{
		}

		// Token: 0x0600F8D2 RID: 63698 RVA: 0x0005D738 File Offset: 0x0005B938
		[Token(Token = "0x600F8D2")]
		[Address(RVA = "0x6FB3F0", Offset = "0x6F9FF0", VA = "0x1806FB3F0")]
		public bool OpTrigSkill(PlayerSide operationSide = PlayerSide.DEFAULT, [Optional] string extraInfo)
		{
			return default(bool);
		}

		// Token: 0x0600F8D3 RID: 63699 RVA: 0x0005D750 File Offset: 0x0005B950
		[Token(Token = "0x600F8D3")]
		[Address(RVA = "0x6FCA30", Offset = "0x6FB630", VA = "0x1806FCA30")]
		public bool RemoteTrigSkill()
		{
			return default(bool);
		}

		// Token: 0x0600F8D4 RID: 63700 RVA: 0x0005D768 File Offset: 0x0005B968
		[Token(Token = "0x600F8D4")]
		[Address(RVA = "0x6FDF10", Offset = "0x6FCB10", VA = "0x1806FDF10")]
		public bool TriggerAutoSkill()
		{
			return default(bool);
		}

		// Token: 0x0600F8D5 RID: 63701 RVA: 0x0005D780 File Offset: 0x0005B980
		[Token(Token = "0x600F8D5")]
		[Address(RVA = "0x6FDC70", Offset = "0x6FC870", VA = "0x1806FDC70")]
		public bool SwitchToAttackState()
		{
			return default(bool);
		}

		// Token: 0x0600F8D6 RID: 63702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8D6")]
		[Address(RVA = "0x6FDE10", Offset = "0x6FCA10", VA = "0x1806FDE10")]
		public void SwitchToSkillState()
		{
		}

		// Token: 0x0600F8D7 RID: 63703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8D7")]
		[Address(RVA = "0x6FDB50", Offset = "0x6FC750", VA = "0x1806FDB50")]
		public void SwitchOutFromSkillState()
		{
		}

		// Token: 0x0600F8D8 RID: 63704 RVA: 0x0005D798 File Offset: 0x0005B998
		[Token(Token = "0x600F8D8")]
		[Address(RVA = "0x6F4970", Offset = "0x6F3570", VA = "0x1806F4970")]
		public bool CheckIsBornState()
		{
			return default(bool);
		}

		// Token: 0x0600F8D9 RID: 63705 RVA: 0x0005D7B0 File Offset: 0x0005B9B0
		[Token(Token = "0x600F8D9")]
		[Address(RVA = "0x6FF3F0", Offset = "0x6FDFF0", VA = "0x1806FF3F0", Slot = "211")]
		public virtual bool Withdraw(bool switchToDeadState = false, bool force = false, bool manual = true, bool logAutoWithdraw = false)
		{
			return default(bool);
		}

		// Token: 0x0600F8DA RID: 63706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8DA")]
		[Address(RVA = "0x6FF210", Offset = "0x6FDE10", VA = "0x1806FF210")]
		public void WithdrawByLevel()
		{
		}

		// Token: 0x0600F8DB RID: 63707 RVA: 0x0005D7C8 File Offset: 0x0005B9C8
		[Token(Token = "0x600F8DB")]
		[Address(RVA = "0x6F44C0", Offset = "0x6F30C0", VA = "0x1806F44C0", Slot = "192")]
		public bool CheckBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool ignoreAdvancedBuildableMask = false)
		{
			return default(bool);
		}

		// Token: 0x0600F8DC RID: 63708 RVA: 0x0005D7E0 File Offset: 0x0005B9E0
		[Token(Token = "0x600F8DC")]
		[Address(RVA = "0x6F4B20", Offset = "0x6F3720", VA = "0x1806F4B20")]
		public bool CheckRespawnSelfBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool ignoreAdvancedBuildableMask = false)
		{
			return default(bool);
		}

		// Token: 0x0600F8DD RID: 63709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8DD")]
		[Address(RVA = "0x6F7A10", Offset = "0x6F6610", VA = "0x1806F7A10", Slot = "212")]
		public virtual void LocateOnTile(Tile tile, bool spawnManually)
		{
		}

		// Token: 0x0600F8DE RID: 63710 RVA: 0x0005D7F8 File Offset: 0x0005B9F8
		[Token(Token = "0x600F8DE")]
		[Address(RVA = "0x6FC4F0", Offset = "0x6FB0F0", VA = "0x1806FC4F0")]
		public bool RechargeToken(int cnt, Deck.Card.RechargeTiming timing, bool refreshRemainingCnt = false)
		{
			return default(bool);
		}

		// Token: 0x0600F8DF RID: 63711 RVA: 0x0005D810 File Offset: 0x0005BA10
		[Token(Token = "0x600F8DF")]
		[Address(RVA = "0x6FC7E0", Offset = "0x6FB3E0", VA = "0x1806FC7E0")]
		public bool RefreshTokenDeployAndStackCnt(bool refreshTokenOrHost, int maxDeployCountAddition, int maxDeckStackCountAddition)
		{
			return default(bool);
		}

		// Token: 0x0600F8E0 RID: 63712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8E0")]
		[Address(RVA = "0x6F57E0", Offset = "0x6F43E0", VA = "0x1806F57E0", Slot = "163")]
		public override Entity FetchHost()
		{
			return null;
		}

		// Token: 0x0600F8E1 RID: 63713 RVA: 0x0005D828 File Offset: 0x0005BA28
		[Token(Token = "0x600F8E1")]
		[Address(RVA = "0x6FE0B0", Offset = "0x6FCCB0", VA = "0x1806FE0B0")]
		public bool TryGetAtkAsHostBased(out FP atk)
		{
			return default(bool);
		}

		// Token: 0x0600F8E2 RID: 63714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8E2")]
		[Address(RVA = "0x6FD020", Offset = "0x6FBC20", VA = "0x1806FD020")]
		public void ResetSearchBlockeeTicker()
		{
		}

		// Token: 0x0600F8E3 RID: 63715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8E3")]
		[Address(RVA = "0x6FD340", Offset = "0x6FBF40", VA = "0x1806FD340")]
		public void SearchBlockeeImmediate()
		{
		}

		// Token: 0x0600F8E4 RID: 63716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8E4")]
		[Address(RVA = "0x6F59D0", Offset = "0x6F45D0", VA = "0x1806F59D0")]
		public void FetchTokenOrHost(int maxTargetNum, List<Entity> results, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8E5")]
		[Address(RVA = "0x6F6BF0", Offset = "0x6F57F0", VA = "0x1806F6BF0")]
		public string GetCurrentModeRangeId()
		{
			return null;
		}

		// Token: 0x0600F8E6 RID: 63718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8E6")]
		[Address(RVA = "0x6F7030", Offset = "0x6F5C30", VA = "0x1806F7030", Slot = "175")]
		public override string GetModeRangeId(UnitMode mode, RangeIdUsage usage)
		{
			return null;
		}

		// Token: 0x0600F8E7 RID: 63719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8E7")]
		[Address(RVA = "0x6F72E0", Offset = "0x6F5EE0", VA = "0x1806F72E0")]
		public IDrawableRange GetRangeOfSkill()
		{
			return null;
		}

		// Token: 0x0600F8E8 RID: 63720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8E8")]
		[Address(RVA = "0x6FB620", Offset = "0x6FA220", VA = "0x1806FB620", Slot = "169")]
		public override void PlayAudioSignal(string ev, bool ignorePredefined)
		{
		}

		// Token: 0x0600F8E9 RID: 63721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8E9")]
		[Address(RVA = "0x701EF0", Offset = "0x700AF0", VA = "0x180701EF0")]
		private string _GetCharacterSignal(string ev)
		{
			return null;
		}

		// Token: 0x0600F8EA RID: 63722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8EA")]
		[Address(RVA = "0x6FBF70", Offset = "0x6FAB70", VA = "0x1806FBF70", Slot = "170")]
		public override void PreloadSpecialAudioSignals(string characterId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x0600F8EB RID: 63723 RVA: 0x0005D840 File Offset: 0x0005BA40
		[Token(Token = "0x600F8EB")]
		[Address(RVA = "0x6F4D20", Offset = "0x6F3920", VA = "0x1806F4D20")]
		protected bool CheckUseIdForAudioSignal(string ev)
		{
			return default(bool);
		}

		// Token: 0x0600F8EC RID: 63724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8EC")]
		[Address(RVA = "0x6F6370", Offset = "0x6F4F70", VA = "0x1806F6370", Slot = "172")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600F8ED RID: 63725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8ED")]
		[Address(RVA = "0x6F4340", Offset = "0x6F2F40", VA = "0x1806F4340", Slot = "94")]
		public override void ChangeMotionMode(MotionMode mode)
		{
		}

		// Token: 0x0600F8EE RID: 63726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8EE")]
		[Address(RVA = "0x6FCFA0", Offset = "0x6FBBA0", VA = "0x1806FCFA0", Slot = "95")]
		public override void ResetMotionMode()
		{
		}

		// Token: 0x0600F8EF RID: 63727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8EF")]
		[Address(RVA = "0x6F42B0", Offset = "0x6F2EB0", VA = "0x1806F42B0")]
		public void ChangeBlockMode(MotionMode mode)
		{
		}

		// Token: 0x0600F8F0 RID: 63728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F0")]
		[Address(RVA = "0x6FCC80", Offset = "0x6FB880", VA = "0x1806FCC80")]
		public void ResetBlockMode()
		{
		}

		// Token: 0x0600F8F1 RID: 63729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F1")]
		[Address(RVA = "0x6F9470", Offset = "0x6F8070", VA = "0x1806F9470")]
		public void OnBlockModeChanged()
		{
		}

		// Token: 0x0600F8F2 RID: 63730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F2")]
		[Address(RVA = "0x6F5CA0", Offset = "0x6F48A0", VA = "0x1806F5CA0", Slot = "113")]
		protected override void FinishMe(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600F8F3 RID: 63731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F3")]
		[Address(RVA = "0x6F52F0", Offset = "0x6F3EF0", VA = "0x1806F52F0", Slot = "180")]
		protected override void DoFakeDeath(Unit.RebornData rebornData)
		{
		}

		// Token: 0x0600F8F4 RID: 63732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F4")]
		[Address(RVA = "0x6F53F0", Offset = "0x6F3FF0", VA = "0x1806F53F0", Slot = "181")]
		protected override void DoReborn(Unit.RebornData data)
		{
		}

		// Token: 0x0600F8F5 RID: 63733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F5")]
		[Address(RVA = "0x6F62A0", Offset = "0x6F4EA0", VA = "0x1806F62A0")]
		public void ForceDying()
		{
		}

		// Token: 0x0600F8F6 RID: 63734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F6")]
		[Address(RVA = "0x6FD1C0", Offset = "0x6FBDC0", VA = "0x1806FD1C0")]
		public void RespawnSelf(Tile newTile, SharedConsts.Direction newDirection, bool spawnManually = false, PlayerSide side = PlayerSide.DEFAULT, bool ignoreAdvancedBuildableMask = false)
		{
		}

		// Token: 0x0600F8F7 RID: 63735 RVA: 0x0005D858 File Offset: 0x0005BA58
		[Token(Token = "0x600F8F7")]
		[Address(RVA = "0x6F8300", Offset = "0x6F6F00", VA = "0x1806F8300")]
		public bool MoveLikeRespawnSelf(Tile newTile, SharedConsts.Direction newDirection, bool spawnManually = false, PlayerSide side = PlayerSide.DEFAULT, bool ignoreAdvancedBuildableMask = false)
		{
			return default(bool);
		}

		// Token: 0x0600F8F8 RID: 63736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F8")]
		[Address(RVA = "0x6F5ED0", Offset = "0x6F4AD0", VA = "0x1806F5ED0")]
		public void FinishWithReason(Entity.FinishReason finishReason)
		{
		}

		// Token: 0x0600F8F9 RID: 63737 RVA: 0x0005D870 File Offset: 0x0005BA70
		[Token(Token = "0x600F8F9")]
		[Address(RVA = "0x6F8520", Offset = "0x6F7120", VA = "0x1806F8520")]
		public bool MoveLikeRespawnSelf(Tile newTile, SharedConsts.Direction newDirection, out Character charOrToken, bool spawnManually = false, PlayerSide side = PlayerSide.DEFAULT, bool ignoreAdvancedBuildableMask = false, bool forceSpawn = false)
		{
			return default(bool);
		}

		// Token: 0x0600F8FA RID: 63738 RVA: 0x0005D888 File Offset: 0x0005BA88
		[Token(Token = "0x600F8FA")]
		[Address(RVA = "0x6F81B0", Offset = "0x6F6DB0", VA = "0x1806F81B0")]
		public bool MoveLikeRespawnExternal(Tile newTile, SharedConsts.Direction newDirection, out Character charOrToken, bool spawnManually = false, PlayerSide side = PlayerSide.DEFAULT, bool ignoreAdvancedBuildableMask = false, bool forceSpawn = false)
		{
			return default(bool);
		}

		// Token: 0x0600F8FB RID: 63739 RVA: 0x0005D8A0 File Offset: 0x0005BAA0
		[Token(Token = "0x600F8FB")]
		[Address(RVA = "0x702750", Offset = "0x701350", VA = "0x180702750")]
		private bool _MoveLikeRespawn(Tile newTile, SharedConsts.Direction newDirection, out Character charOrToken, bool spawnManually = false, PlayerSide side = PlayerSide.DEFAULT, bool ignoreAdvancedBuildableMask = false, bool forceSpawn = false)
		{
			return default(bool);
		}

		// Token: 0x0600F8FC RID: 63740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8FC")]
		[Address(RVA = "0x6FD0B0", Offset = "0x6FBCB0", VA = "0x1806FD0B0")]
		public Character RespawnSelfAsPredefined(string alias, Tile newTile, SharedConsts.Direction newDirection)
		{
			return null;
		}

		// Token: 0x0600F8FD RID: 63741 RVA: 0x0005D8B8 File Offset: 0x0005BAB8
		[Token(Token = "0x600F8FD")]
		[Address(RVA = "0x6F6DA0", Offset = "0x6F59A0", VA = "0x1806F6DA0")]
		public float GetDelayToRecycleTime()
		{
			return 0f;
		}

		// Token: 0x0600F8FE RID: 63742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8FE")]
		[Address(RVA = "0x6F5F80", Offset = "0x6F4B80", VA = "0x1806F5F80")]
		public void FinishWithReplace(Character character)
		{
		}

		// Token: 0x0600F8FF RID: 63743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8FF")]
		[Address(RVA = "0x6F4E10", Offset = "0x6F3A10", VA = "0x1806F4E10", Slot = "114")]
		protected override void ClearAbilities()
		{
		}

		// Token: 0x0600F900 RID: 63744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F900")]
		[Address(RVA = "0x7016A0", Offset = "0x7002A0", VA = "0x1807016A0")]
		private void _ClearAbilityProjectilesIfNeeded()
		{
		}

		// Token: 0x0600F901 RID: 63745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F901")]
		[Address(RVA = "0x700A50", Offset = "0x6FF650", VA = "0x180700A50")]
		private void _BuildAtInternal(Character.BuildParam characterBuildParam)
		{
		}

		// Token: 0x0600F902 RID: 63746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F902")]
		[Address(RVA = "0x702560", Offset = "0x701160", VA = "0x180702560")]
		private void _InitAllModeDirection()
		{
		}

		// Token: 0x0600F903 RID: 63747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F903")]
		[Address(RVA = "0x6F7C10", Offset = "0x6F6810", VA = "0x1806F7C10")]
		public void LogSnapshotIfNot()
		{
		}

		// Token: 0x0600F904 RID: 63748 RVA: 0x0005D8D0 File Offset: 0x0005BAD0
		[Token(Token = "0x600F904")]
		[Address(RVA = "0x6F47B0", Offset = "0x6F33B0", VA = "0x1806F47B0", Slot = "97")]
		public override bool CheckHasFilterTag(string unitTag)
		{
			return default(bool);
		}

		// Token: 0x0600F905 RID: 63749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F905")]
		[Address(RVA = "0x6FD410", Offset = "0x6FC010", VA = "0x1806FD410")]
		public void SetAdditionalBuildCondition(BuildableType type, AdvancedBuildableMask mask)
		{
		}

		// Token: 0x0600F906 RID: 63750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F906")]
		[Address(RVA = "0x6FD4C0", Offset = "0x6FC0C0", VA = "0x1806FD4C0")]
		public void SetAdditionalBuildCondition(AdditionalBuildCondition condition)
		{
		}

		// Token: 0x0600F907 RID: 63751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F907")]
		[Address(RVA = "0x6F39D0", Offset = "0x6F25D0", VA = "0x1806F39D0")]
		public void AddOverlapSourceId(string sourceId)
		{
		}

		// Token: 0x0600F908 RID: 63752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F908")]
		[Address(RVA = "0x6FCBE0", Offset = "0x6FB7E0", VA = "0x1806FCBE0")]
		public void RemoveOverlapSourceId(string sourceId)
		{
		}

		// Token: 0x0600F909 RID: 63753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F909")]
		[Address(RVA = "0x6F8110", Offset = "0x6F6D10", VA = "0x1806F8110")]
		public void ModifyOverlapTakeEffect(bool flag)
		{
		}

		// Token: 0x0600F90A RID: 63754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F90A")]
		[Address(RVA = "0x6F6E40", Offset = "0x6F5A40", VA = "0x1806F6E40", Slot = "88")]
		public override EffectReplacePair[] GetEffectReplacePairs()
		{
			return null;
		}

		// Token: 0x0600F90B RID: 63755 RVA: 0x0005D8E8 File Offset: 0x0005BAE8
		[Token(Token = "0x600F90B")]
		[Address(RVA = "0x6FE520", Offset = "0x6FD120", VA = "0x1806FE520", Slot = "103")]
		public override bool TryHookEffect(string originEffectKey, out string newEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600F90C RID: 63756 RVA: 0x0005D900 File Offset: 0x0005BB00
		[Token(Token = "0x600F90C")]
		[Address(RVA = "0x6FE360", Offset = "0x6FCF60", VA = "0x1806FE360", Slot = "105")]
		public override bool TryHookAudio(string signal, string subSignal, out string newSignal, out string newSubsignal)
		{
			return default(bool);
		}

		// Token: 0x0600F90D RID: 63757 RVA: 0x0005D918 File Offset: 0x0005BB18
		[Token(Token = "0x600F90D")]
		[Address(RVA = "0x6FE6B0", Offset = "0x6FD2B0", VA = "0x1806FE6B0", Slot = "106")]
		public override bool TryHookProjectile(string originProjectile, out string graphicProjectileKey, out string logicProjectile, out Entity.MountPointType muzzlePoint)
		{
			return default(bool);
		}

		// Token: 0x0600F90E RID: 63758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F90E")]
		[Address(RVA = "0x6FC950", Offset = "0x6FB550", VA = "0x1806FC950")]
		public void RegisterReplacement(Character.IReplacement replacement)
		{
		}

		// Token: 0x0600F90F RID: 63759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F90F")]
		[Address(RVA = "0x6FEC80", Offset = "0x6FD880", VA = "0x1806FEC80")]
		public void UnregisterReplacement(Character.IReplacement ability)
		{
		}

		// Token: 0x0600F910 RID: 63760 RVA: 0x0005D930 File Offset: 0x0005BB30
		[Token(Token = "0x600F910")]
		[Address(RVA = "0x6F4A00", Offset = "0x6F3600", VA = "0x1806F4A00")]
		public bool CheckIsCurrentReplacement(Character.IReplacement ability)
		{
			return default(bool);
		}

		// Token: 0x0600F911 RID: 63761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F911")]
		[Address(RVA = "0x6F4FB0", Offset = "0x6F3BB0", VA = "0x1806F4FB0")]
		public void ClearReplacement()
		{
		}

		// Token: 0x0600F912 RID: 63762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F912")]
		[Address(RVA = "0x6F74B0", Offset = "0x6F60B0", VA = "0x1806F74B0")]
		public string GetStartEffect()
		{
			return null;
		}

		// Token: 0x0600F913 RID: 63763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F913")]
		[Address(RVA = "0x6F6C80", Offset = "0x6F5880", VA = "0x1806F6C80")]
		public string GetDeadEffect()
		{
			return null;
		}

		// Token: 0x0600F914 RID: 63764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F914")]
		[Address(RVA = "0x6F65C0", Offset = "0x6F51C0", VA = "0x1806F65C0", Slot = "171")]
		public override Blackboard GetAttackBlackboard(UnitMode mode)
		{
			return null;
		}

		// Token: 0x0600F915 RID: 63765 RVA: 0x0005D948 File Offset: 0x0005BB48
		[Token(Token = "0x600F915")]
		[Address(RVA = "0x7014D0", Offset = "0x7000D0", VA = "0x1807014D0")]
		private bool _CheckCanSwithToAttackState()
		{
			return default(bool);
		}

		// Token: 0x0600F916 RID: 63766 RVA: 0x0005D960 File Offset: 0x0005BB60
		[Token(Token = "0x600F916")]
		[Address(RVA = "0x703DE0", Offset = "0x7029E0", VA = "0x180703DE0")]
		private bool _SearchAttackTarget()
		{
			return default(bool);
		}

		// Token: 0x0600F917 RID: 63767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F917")]
		[Address(RVA = "0x701D70", Offset = "0x700970", VA = "0x180701D70")]
		private Enemy _FetchCombatTarget()
		{
			return null;
		}

		// Token: 0x0600F918 RID: 63768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F918")]
		[Address(RVA = "0x6FDFE0", Offset = "0x6FCBE0", VA = "0x1806FDFE0")]
		public void TryFaceToIdleDirection()
		{
		}

		// Token: 0x0600F919 RID: 63769 RVA: 0x0005D978 File Offset: 0x0005BB78
		[Token(Token = "0x600F919")]
		[Address(RVA = "0x708D60", Offset = "0x707960", VA = "0x180708D60", Slot = "83")]
		public override bool isStillMotionTargetFreeWithImmuneFlag(AbnormalFlag immuneFlag, AbnormalCombo immuneCombo, MotionMode sourceMotionMode)
		{
			return default(bool);
		}

		// Token: 0x0600F91A RID: 63770 RVA: 0x0005D990 File Offset: 0x0005BB90
		[Token(Token = "0x600F91A")]
		[Address(RVA = "0x6F4840", Offset = "0x6F3440", VA = "0x1806F4840", Slot = "213")]
		public virtual bool CheckInBlockRange(Entity target, float shrink = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600F91B RID: 63771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F91B")]
		[Address(RVA = "0x703FC0", Offset = "0x702BC0", VA = "0x180703FC0", Slot = "214")]
		protected virtual void _SearchBlockee(bool force = false)
		{
		}

		// Token: 0x0600F91C RID: 63772 RVA: 0x0005D9A8 File Offset: 0x0005BBA8
		[Token(Token = "0x600F91C")]
		[Address(RVA = "0x701260", Offset = "0x6FFE60", VA = "0x180701260")]
		private bool _CheckBlockable(Entity entity, Entity source, out FP weight, out int volume)
		{
			return default(bool);
		}

		// Token: 0x0600F91D RID: 63773 RVA: 0x0005D9C0 File Offset: 0x0005BBC0
		[Token(Token = "0x600F91D")]
		[Address(RVA = "0x6F43E0", Offset = "0x6F2FE0", VA = "0x1806F43E0")]
		public bool CheckBlockVolumeNotExceeded(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0600F91E RID: 63774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F91E")]
		[Address(RVA = "0x7017E0", Offset = "0x7003E0", VA = "0x1807017E0")]
		protected void _ClearAllBlockees()
		{
		}

		// Token: 0x0600F91F RID: 63775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F91F")]
		[Address(RVA = "0x6FF840", Offset = "0x6FE440", VA = "0x1806FF840")]
		protected void _AddBlockee(Enemy enemy)
		{
		}

		// Token: 0x0600F920 RID: 63776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F920")]
		[Address(RVA = "0x6FCB00", Offset = "0x6FB700", VA = "0x1806FCB00")]
		public void RemoveBlockee(Enemy enemy)
		{
		}

		// Token: 0x0600F921 RID: 63777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F921")]
		[Address(RVA = "0x6FC460", Offset = "0x6FB060", VA = "0x1806FC460")]
		public void RecalculateBlockeesTotalVolume()
		{
		}

		// Token: 0x0600F922 RID: 63778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F922")]
		[Address(RVA = "0x6FED20", Offset = "0x6FD920", VA = "0x1806FED20")]
		public void UpdateBlockees()
		{
		}

		// Token: 0x0600F923 RID: 63779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F923")]
		[Address(RVA = "0x6FD830", Offset = "0x6FC430", VA = "0x1806FD830")]
		protected void SetupSkin(UnitAnimator skin, string name)
		{
		}

		// Token: 0x0600F924 RID: 63780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F924")]
		[Address(RVA = "0x6FC690", Offset = "0x6FB290", VA = "0x1806FC690")]
		protected void RecycleSkinIfNot()
		{
		}

		// Token: 0x0600F925 RID: 63781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F925")]
		[Address(RVA = "0x6FA6E0", Offset = "0x6F92E0", VA = "0x1806FA6E0", Slot = "26")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0600F926 RID: 63782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F926")]
		[Address(RVA = "0x6FAE40", Offset = "0x6F9A40", VA = "0x1806FAE40", Slot = "27")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600F927 RID: 63783 RVA: 0x0005D9D8 File Offset: 0x0005BBD8
		[Token(Token = "0x600F927")]
		[Address(RVA = "0x6F7730", Offset = "0x6F6330", VA = "0x1806F7730", Slot = "215")]
		protected virtual float GetTileLocateHeight()
		{
			return 0f;
		}

		// Token: 0x0600F928 RID: 63784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F928")]
		[Address(RVA = "0x6F8D50", Offset = "0x6F7950", VA = "0x1806F8D50", Slot = "183")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600F929 RID: 63785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F929")]
		[Address(RVA = "0x6F9F90", Offset = "0x6F8B90", VA = "0x1806F9F90", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600F92A RID: 63786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F92A")]
		[Address(RVA = "0x704630", Offset = "0x703230", VA = "0x180704630")]
		private void _SpawnDeckBuffs(bool isRallyPointLikeSwitch = false)
		{
		}

		// Token: 0x0600F92B RID: 63787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F92B")]
		[Address(RVA = "0x6F9540", Offset = "0x6F8140", VA = "0x1806F9540", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600F92C RID: 63788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F92C")]
		[Address(RVA = "0x6FA550", Offset = "0x6F9150", VA = "0x1806FA550", Slot = "184")]
		public override void OnReborn(Unit.RebornData data)
		{
		}

		// Token: 0x0600F92D RID: 63789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F92D")]
		[Address(RVA = "0x6F9E40", Offset = "0x6F8A40", VA = "0x1806F9E40", Slot = "117")]
		protected override void OnHpZero(bool noSource, bool skipReborn)
		{
		}

		// Token: 0x0600F92E RID: 63790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F92E")]
		[Address(RVA = "0x6FA840", Offset = "0x6F9440", VA = "0x1806FA840", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600F92F RID: 63791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F92F")]
		[Address(RVA = "0x6FFDE0", Offset = "0x6FE9E0", VA = "0x1806FFDE0", Slot = "13")]
		protected override void _AssignLocalPosInternal(Vector3 localPos)
		{
		}

		// Token: 0x0600F930 RID: 63792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F930")]
		[Address(RVA = "0x6FA2D0", Offset = "0x6F8ED0", VA = "0x1806FA2D0", Slot = "115")]
		protected override void OnLocate()
		{
		}

		// Token: 0x0600F931 RID: 63793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F931")]
		[Address(RVA = "0x6F9C20", Offset = "0x6F8820", VA = "0x1806F9C20", Slot = "119")]
		protected override void OnFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600F932 RID: 63794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F932")]
		[Address(RVA = "0x6F51B0", Offset = "0x6F3DB0", VA = "0x1806F51B0", Slot = "112")]
		protected override StateMachine ConstructStateMachine()
		{
			return null;
		}

		// Token: 0x0600F933 RID: 63795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F933")]
		[Address(RVA = "0x6F8AA0", Offset = "0x6F76A0", VA = "0x1806F8AA0", Slot = "122")]
		protected override void OnAttributeDirty(AttributeType attributeType, FP oldValue)
		{
		}

		// Token: 0x0600F934 RID: 63796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F934")]
		[Address(RVA = "0x6F9900", Offset = "0x6F8500", VA = "0x1806F9900", Slot = "34")]
		protected override void OnDisappearChanged(bool newValue)
		{
		}

		// Token: 0x0600F935 RID: 63797 RVA: 0x0005D9F0 File Offset: 0x0005BBF0
		[Token(Token = "0x600F935")]
		[Address(RVA = "0x6F4A90", Offset = "0x6F3690", VA = "0x1806F4A90")]
		protected bool CheckModeChangeBeforeAttack(int oldModeIndex)
		{
			return default(bool);
		}

		// Token: 0x0600F936 RID: 63798 RVA: 0x0005DA08 File Offset: 0x0005BC08
		[Token(Token = "0x600F936")]
		[Address(RVA = "0x6F8FB0", Offset = "0x6F7BB0", VA = "0x1806F8FB0")]
		protected bool OnBeforeAttack(Ability ability, bool isCombat)
		{
			return default(bool);
		}

		// Token: 0x0600F937 RID: 63799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F937")]
		[Address(RVA = "0x6F8670", Offset = "0x6F7270", VA = "0x1806F8670")]
		protected void OnAfterAttack(Ability ability, bool isCombat, Ability.FinishReason reason)
		{
		}

		// Token: 0x0600F938 RID: 63800 RVA: 0x0005DA20 File Offset: 0x0005BC20
		[Token(Token = "0x600F938")]
		[Address(RVA = "0x6F9250", Offset = "0x6F7E50", VA = "0x1806F9250")]
		protected bool OnBeforeSkill(BasicSkill skill)
		{
			return default(bool);
		}

		// Token: 0x0600F939 RID: 63801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F939")]
		[Address(RVA = "0x6F8890", Offset = "0x6F7490", VA = "0x1806F8890")]
		protected void OnAfterSkill(BasicSkill skill, Ability.FinishReason reason)
		{
		}

		// Token: 0x0600F93A RID: 63802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93A")]
		[Address(RVA = "0x6FAD30", Offset = "0x6F9930", VA = "0x1806FAD30")]
		public void OnSkillStart()
		{
		}

		// Token: 0x0600F93B RID: 63803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93B")]
		[Address(RVA = "0x6FB180", Offset = "0x6F9D80", VA = "0x1806FB180")]
		public void OnToggleSkillStart()
		{
		}

		// Token: 0x0600F93C RID: 63804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93C")]
		[Address(RVA = "0x6FAC10", Offset = "0x6F9810", VA = "0x1806FAC10")]
		public void OnSkillRetriggered()
		{
		}

		// Token: 0x0600F93D RID: 63805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93D")]
		[Address(RVA = "0x6FAA70", Offset = "0x6F9670", VA = "0x1806FAA70")]
		public void OnSkillCastSucceed()
		{
		}

		// Token: 0x0600F93E RID: 63806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93E")]
		[Address(RVA = "0x6FAB20", Offset = "0x6F9720", VA = "0x1806FAB20")]
		public void OnSkillFinish()
		{
		}

		// Token: 0x0600F93F RID: 63807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93F")]
		[Address(RVA = "0x6FBC10", Offset = "0x6FA810", VA = "0x1806FBC10", Slot = "185")]
		public override void PopulateSnapshotToHashBuilder(HashCodeBuilder builder)
		{
		}

		// Token: 0x0600F940 RID: 63808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F940")]
		[Address(RVA = "0x6FBD60", Offset = "0x6FA960", VA = "0x1806FBD60", Slot = "186")]
		public override void PopulateSnapshotToStrBuilder(StringBuilder builder)
		{
		}

		// Token: 0x0600F941 RID: 63809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F941")]
		[Address(RVA = "0x6F5230", Offset = "0x6F3E30", VA = "0x1806F5230", Slot = "216")]
		protected virtual BasicSkill CreateSkill(SkillData data)
		{
			return null;
		}

		// Token: 0x0600F942 RID: 63810 RVA: 0x0005DA38 File Offset: 0x0005BC38
		[Token(Token = "0x600F942")]
		[Address(RVA = "0x6F3A70", Offset = "0x6F2670", VA = "0x1806F3A70", Slot = "217")]
		protected virtual Vector2 BlockeeOffsetPosSet(Vector2 offset, Enemy enemy)
		{
			return default(Vector2);
		}

		// Token: 0x0600F943 RID: 63811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F943")]
		[Address(RVA = "0x6FEFA0", Offset = "0x6FDBA0", VA = "0x1806FEFA0")]
		protected void UpdateHatred()
		{
		}

		// Token: 0x0600F944 RID: 63812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F944")]
		[Address(RVA = "0x6FEEE0", Offset = "0x6FDAE0", VA = "0x1806FEEE0")]
		public void UpdateHatred(float newHatred)
		{
		}

		// Token: 0x0600F945 RID: 63813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F945")]
		[Address(RVA = "0x6F54E0", Offset = "0x6F40E0", VA = "0x1806F54E0")]
		public void EnsureSkillOnInAbnormalState()
		{
		}

		// Token: 0x0600F946 RID: 63814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F946")]
		[Address(RVA = "0x6FF9B0", Offset = "0x6FE5B0", VA = "0x1806FF9B0")]
		private void _AssignData(BattleCharacterData data, SideType sideType, PlayerSide playerSide)
		{
		}

		// Token: 0x0600F947 RID: 63815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F947")]
		[Address(RVA = "0x702E50", Offset = "0x701A50", VA = "0x180702E50")]
		private void _PreprocessSkill(SkillData data)
		{
		}

		// Token: 0x0600F948 RID: 63816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F948")]
		[Address(RVA = "0x703A60", Offset = "0x702660", VA = "0x180703A60")]
		private void _RecycleEquipIfNot()
		{
		}

		// Token: 0x0600F949 RID: 63817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F949")]
		[Address(RVA = "0x6FFF80", Offset = "0x6FEB80", VA = "0x1806FFF80")]
		private void _AssignSkill(SkillData skillData, Blackboard externalBlackboard, Dictionary<string, TalentData> talentMap)
		{
		}

		// Token: 0x0600F94A RID: 63818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F94A")]
		[Address(RVA = "0x7030B0", Offset = "0x701CB0", VA = "0x1807030B0")]
		private void _PreprocessSkin(CharSkinData skinData)
		{
		}

		// Token: 0x0600F94B RID: 63819 RVA: 0x0005DA50 File Offset: 0x0005BC50
		[Token(Token = "0x600F94B")]
		[Address(RVA = "0x7015C0", Offset = "0x7001C0", VA = "0x1807015C0")]
		private bool _CheckDontCreateSkinBeforeGameLoaded()
		{
			return default(bool);
		}

		// Token: 0x0600F94C RID: 63820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F94C")]
		[Address(RVA = "0x702BF0", Offset = "0x7017F0", VA = "0x180702BF0")]
		private void _PreprocessEquip()
		{
		}

		// Token: 0x0600F94D RID: 63821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F94D")]
		[Address(RVA = "0x703300", Offset = "0x701F00", VA = "0x180703300")]
		private void _PreprocessTalents(IList<TalentData> talentsData, TalentData traitTalentData, out Dictionary<string, TalentData> talentMap, out Blackboard skillBlackboard)
		{
		}

		// Token: 0x0600F94E RID: 63822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F94E")]
		[Address(RVA = "0x700250", Offset = "0x6FEE50", VA = "0x180700250")]
		private void _AssignTalents(Dictionary<string, TalentData> talentMap)
		{
		}

		// Token: 0x0600F94F RID: 63823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F94F")]
		[Address(RVA = "0x6FC100", Offset = "0x6FAD00", VA = "0x1806FC100")]
		public void ReassignTalents(Dictionary<string, TalentData> talentMap)
		{
		}

		// Token: 0x0600F950 RID: 63824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F950")]
		[Address(RVA = "0x700650", Offset = "0x6FF250", VA = "0x180700650")]
		private void _AssignTrait(CharacterData.TraitData traitData)
		{
		}

		// Token: 0x0600F951 RID: 63825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F951")]
		[Address(RVA = "0x7037F0", Offset = "0x7023F0", VA = "0x1807037F0")]
		private void _PreprocessTrait(CharacterData.TraitData traitData, out TalentData talentData)
		{
		}

		// Token: 0x0600F952 RID: 63826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F952")]
		[Address(RVA = "0x7018F0", Offset = "0x7004F0", VA = "0x1807018F0")]
		private void _EquipProcessTalents()
		{
		}

		// Token: 0x0600F953 RID: 63827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F953")]
		[Address(RVA = "0x701AF0", Offset = "0x7006F0", VA = "0x180701AF0")]
		private void _EquipProcessTrait()
		{
		}

		// Token: 0x0600F954 RID: 63828 RVA: 0x0005DA68 File Offset: 0x0005BC68
		[Token(Token = "0x600F954")]
		[Address(RVA = "0x702050", Offset = "0x700C50", VA = "0x180702050")]
		private int _GetDefaultModeIndex(Dictionary<string, TalentData> talentMap)
		{
			return 0;
		}

		// Token: 0x0600F955 RID: 63829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F955")]
		[Address(RVA = "0x7022D0", Offset = "0x700ED0", VA = "0x1807022D0")]
		private string _GetDefaultRangeId(Dictionary<string, TalentData> talentMap)
		{
			return null;
		}

		// Token: 0x0600F956 RID: 63830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F956")]
		[Address(RVA = "0x6F9B50", Offset = "0x6F8750", VA = "0x1806F9B50")]
		private void OnEquipProcessed(string equipOriginKey, GameObject equip)
		{
		}

		// Token: 0x0600F957 RID: 63831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F957")]
		[Address(RVA = "0x6F6940", Offset = "0x6F5540", VA = "0x1806F6940", Slot = "178")]
		public override AbstractBasicAttack GetCurrentAttackOrCombatAbility()
		{
			return null;
		}

		// Token: 0x0600F958 RID: 63832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F958")]
		[Address(RVA = "0x6F73F0", Offset = "0x6F5FF0", VA = "0x1806F73F0")]
		public Ability GetSpecialModeAttack(int modeIndex)
		{
			return null;
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x0600F959 RID: 63833 RVA: 0x0005DA80 File Offset: 0x0005BC80
		[Token(Token = "0x170020F9")]
		public override FP ColliderRadius
		{
			[Token(Token = "0x600F959")]
			[Address(RVA = "0x704D30", Offset = "0x703930", VA = "0x180704D30", Slot = "148")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0600F95A RID: 63834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F95A")]
		[Address(RVA = "0x6FA410", Offset = "0x6F9010", VA = "0x1806FA410")]
		public void OnRallyPointLikeReborn()
		{
		}

		// Token: 0x0600F95B RID: 63835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F95B")]
		[Address(RVA = "0x6FB270", Offset = "0x6F9E70", VA = "0x1806FB270")]
		public void OnTokenCategoryChanged()
		{
		}

		// Token: 0x0600F95C RID: 63836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F95C")]
		[Address(RVA = "0x703960", Offset = "0x702560", VA = "0x180703960")]
		private void _ReactivateMainTriggerCollider()
		{
		}

		// Token: 0x0600F95D RID: 63837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F95D")]
		[Address(RVA = "0x6FD640", Offset = "0x6FC240", VA = "0x1806FD640")]
		public void SetDontOccupyDeployCntFlag(bool dontOccupyDeployCnt)
		{
		}

		// Token: 0x0600F95E RID: 63838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F95E")]
		[Address(RVA = "0x6FD560", Offset = "0x6FC160", VA = "0x1806FD560")]
		public void SetDisableClickCharacterInfo(bool isDisable, Character.DisableClickCharacterInfoReasonMask reason)
		{
		}

		// Token: 0x0600F95F RID: 63839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F95F")]
		[Address(RVA = "0x6FD760", Offset = "0x6FC360", VA = "0x1806FD760")]
		public void SetWithdrawCostRecoverRatio(float ratio, bool isReset, bool limitMaxWithdrawCostByDeployUse)
		{
		}

		// Token: 0x0600F960 RID: 63840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F960")]
		[Address(RVA = "0x6FF180", Offset = "0x6FDD80", VA = "0x1806FF180")]
		public void UpdateMaxEs(FP maxEsRatio)
		{
		}

		// Token: 0x0600F961 RID: 63841 RVA: 0x0005DA98 File Offset: 0x0005BC98
		[Token(Token = "0x600F961")]
		[Address(RVA = "0x6F99D0", Offset = "0x6F85D0", VA = "0x1806F99D0", Slot = "218")]
		public virtual bool OnEntityOverlapLikeOperationSucceed(SharedConsts.Direction direction, Tile targetTile, Deck.SpawnDetailsTracker spawnDetailsTracker)
		{
			return default(bool);
		}

		// Token: 0x0600F962 RID: 63842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F962")]
		[Address(RVA = "0x6F9A80", Offset = "0x6F8680", VA = "0x1806F9A80")]
		public void OnEntityWillOverlap(Entity entity, SharedConsts.Direction direction)
		{
		}

		// Token: 0x0600F963 RID: 63843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F963")]
		[Address(RVA = "0x6F64A0", Offset = "0x6F50A0", VA = "0x1806F64A0", Slot = "167")]
		public override void GatherHudPluginTypes(List<string> pluginNames)
		{
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x0600F964 RID: 63844 RVA: 0x0005DAB0 File Offset: 0x0005BCB0
		[Token(Token = "0x170020FA")]
		public override HudPluginMask hudPluginMask
		{
			[Token(Token = "0x600F964")]
			[Address(RVA = "0x7068B0", Offset = "0x7054B0", VA = "0x1807068B0", Slot = "166")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x0600F965 RID: 63845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F965")]
		[Address(RVA = "0x6F6800", Offset = "0x6F5400", VA = "0x1806F6800", Slot = "188")]
		public override string GetBakeMuzzleDataPath()
		{
			return null;
		}

		// Token: 0x0600F966 RID: 63846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F966")]
		[Address(RVA = "0x7049E0", Offset = "0x7035E0", VA = "0x1807049E0")]
		public Character()
		{
		}

		// Token: 0x0600F968 RID: 63848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F968")]
		[Address(RVA = "0x6FEBF0", Offset = "0x6FD7F0", VA = "0x1806FEBF0")]
		private Transform <>xLuaBaseProxy_get_graphicHolderTransform()
		{
			return null;
		}

		// Token: 0x0600F969 RID: 63849 RVA: 0x0005DAC8 File Offset: 0x0005BCC8
		[Token(Token = "0x600F969")]
		[Address(RVA = "0x6FEB60", Offset = "0x6FD760", VA = "0x1806FEB60")]
		private bool <>xLuaBaseProxy_get_alive()
		{
			return default(bool);
		}

		// Token: 0x0600F96A RID: 63850 RVA: 0x0005DAE0 File Offset: 0x0005BCE0
		[Token(Token = "0x600F96A")]
		[Address(RVA = "0x6FEB50", Offset = "0x6FD750", VA = "0x1806FEB50")]
		private bool <>xLuaBaseProxy_get_aliveOrDying()
		{
			return default(bool);
		}

		// Token: 0x0600F96B RID: 63851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F96B")]
		[Address(RVA = "0x6FEBB0", Offset = "0x6FD7B0", VA = "0x1806FEBB0")]
		private UnitMode <>xLuaBaseProxy_get_defaultMode()
		{
			return null;
		}

		// Token: 0x0600F96C RID: 63852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F96C")]
		[Address(RVA = "0x6FEB70", Offset = "0x6FD770", VA = "0x1806FEB70")]
		private UnitAnimator <>xLuaBaseProxy_get_animator()
		{
			return null;
		}

		// Token: 0x0600F96D RID: 63853 RVA: 0x0005DAF8 File Offset: 0x0005BCF8
		[Token(Token = "0x600F96D")]
		[Address(RVA = "0x6FEC40", Offset = "0x6FD840", VA = "0x1806FEC40")]
		private FP <>xLuaBaseProxy_get_maxEs()
		{
			return default(FP);
		}

		// Token: 0x0600F96E RID: 63854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F96E")]
		[Address(RVA = "0x6FEC60", Offset = "0x6FD860", VA = "0x1806FEC60")]
		private string <>xLuaBaseProxy_get_talentRange()
		{
			return null;
		}

		// Token: 0x0600F96F RID: 63855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F96F")]
		[Address(RVA = "0x6FEB90", Offset = "0x6FD790", VA = "0x1806FEB90")]
		private Ability <>xLuaBaseProxy_get_attack()
		{
			return null;
		}

		// Token: 0x0600F970 RID: 63856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F970")]
		[Address(RVA = "0x6FEBA0", Offset = "0x6FD7A0", VA = "0x1806FEBA0")]
		private Ability <>xLuaBaseProxy_get_combat()
		{
			return null;
		}

		// Token: 0x0600F971 RID: 63857 RVA: 0x0005DB10 File Offset: 0x0005BD10
		[Token(Token = "0x600F971")]
		[Address(RVA = "0x6FEC00", Offset = "0x6FD800", VA = "0x1806FEC00")]
		private bool <>xLuaBaseProxy_get_hasCombat()
		{
			return default(bool);
		}

		// Token: 0x0600F972 RID: 63858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F972")]
		[Address(RVA = "0x6FEB80", Offset = "0x6FD780", VA = "0x1806FEB80")]
		private TargetTrigger <>xLuaBaseProxy_get_attackTrigger()
		{
			return null;
		}

		// Token: 0x0600F973 RID: 63859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F973")]
		[Address(RVA = "0x6FEC50", Offset = "0x6FD850", VA = "0x1806FEC50")]
		private IDrawableRange <>xLuaBaseProxy_get_rangeToShow()
		{
			return null;
		}

		// Token: 0x0600F974 RID: 63860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F974")]
		[Address(RVA = "0x6FEBC0", Offset = "0x6FD7C0", VA = "0x1806FEBC0")]
		private string <>xLuaBaseProxy_get_defaultRangeId()
		{
			return null;
		}

		// Token: 0x0600F975 RID: 63861 RVA: 0x0005DB28 File Offset: 0x0005BD28
		[Token(Token = "0x600F975")]
		[Address(RVA = "0x6FEC30", Offset = "0x6FD830", VA = "0x1806FEC30")]
		private bool <>xLuaBaseProxy_get_isMine()
		{
			return default(bool);
		}

		// Token: 0x0600F976 RID: 63862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F976")]
		[Address(RVA = "0x6FEBE0", Offset = "0x6FD7E0", VA = "0x1806FEBE0")]
		private Transform <>xLuaBaseProxy_get_directionTransform()
		{
			return null;
		}

		// Token: 0x0600F977 RID: 63863 RVA: 0x0005DB40 File Offset: 0x0005BD40
		[Token(Token = "0x600F977")]
		[Address(RVA = "0x6FEC20", Offset = "0x6FD820", VA = "0x1806FEC20")]
		private int <>xLuaBaseProxy_get_initState()
		{
			return 0;
		}

		// Token: 0x0600F978 RID: 63864 RVA: 0x0005DB58 File Offset: 0x0005BD58
		[Token(Token = "0x600F978")]
		[Address(RVA = "0x6FEBD0", Offset = "0x6FD7D0", VA = "0x1806FEBD0")]
		private float <>xLuaBaseProxy_get_delayToRecycle()
		{
			return 0f;
		}

		// Token: 0x0600F979 RID: 63865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F979")]
		[Address(RVA = "0x6FE870", Offset = "0x6FD470", VA = "0x1806FE870")]
		private void <>xLuaBaseProxy_Born()
		{
		}

		// Token: 0x0600F97A RID: 63866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F97A")]
		[Address(RVA = "0x6FE940", Offset = "0x6FD540", VA = "0x1806FE940")]
		private Entity <>xLuaBaseProxy_FetchHost()
		{
			return null;
		}

		// Token: 0x0600F97B RID: 63867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F97B")]
		[Address(RVA = "0x6FE9B0", Offset = "0x6FD5B0", VA = "0x1806FE9B0")]
		private string <>xLuaBaseProxy_GetModeRangeId(UnitMode P0, RangeIdUsage P1)
		{
			return null;
		}

		// Token: 0x0600F97C RID: 63868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F97C")]
		[Address(RVA = "0x6099F0", Offset = "0x6085F0", VA = "0x1806099F0")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x0600F97D RID: 63869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F97D")]
		[Address(RVA = "0x6FE960", Offset = "0x6FD560", VA = "0x1806FE960")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600F97E RID: 63870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F97E")]
		[Address(RVA = "0x6FE880", Offset = "0x6FD480", VA = "0x1806FE880")]
		private void <>xLuaBaseProxy_ChangeMotionMode(MotionMode P0)
		{
		}

		// Token: 0x0600F97F RID: 63871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F97F")]
		[Address(RVA = "0x6FEAE0", Offset = "0x6FD6E0", VA = "0x1806FEAE0")]
		private void <>xLuaBaseProxy_ResetMotionMode()
		{
		}

		// Token: 0x0600F980 RID: 63872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F980")]
		[Address(RVA = "0x6FE950", Offset = "0x6FD550", VA = "0x1806FE950")]
		private void <>xLuaBaseProxy_FinishMe(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600F981 RID: 63873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F981")]
		[Address(RVA = "0x6FE8A0", Offset = "0x6FD4A0", VA = "0x1806FE8A0")]
		private void <>xLuaBaseProxy_DoFakeDeath(Unit.RebornData P0)
		{
		}

		// Token: 0x0600F982 RID: 63874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F982")]
		[Address(RVA = "0x6FE8F0", Offset = "0x6FD4F0", VA = "0x1806FE8F0")]
		private void <>xLuaBaseProxy_DoReborn(Unit.RebornData P0)
		{
		}

		// Token: 0x0600F983 RID: 63875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F983")]
		[Address(RVA = "0x6FE890", Offset = "0x6FD490", VA = "0x1806FE890")]
		private void <>xLuaBaseProxy_ClearAbilities()
		{
		}

		// Token: 0x0600F984 RID: 63876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F984")]
		[Address(RVA = "0x6FE9A0", Offset = "0x6FD5A0", VA = "0x1806FE9A0")]
		private EffectReplacePair[] <>xLuaBaseProxy_GetEffectReplacePairs()
		{
			return null;
		}

		// Token: 0x0600F985 RID: 63877 RVA: 0x0005DB70 File Offset: 0x0005BD70
		[Token(Token = "0x600F985")]
		[Address(RVA = "0x6FEB00", Offset = "0x6FD700", VA = "0x1806FEB00")]
		private bool <>xLuaBaseProxy_TryHookEffect(string P0, out string P1)
		{
			return default(bool);
		}

		// Token: 0x0600F986 RID: 63878 RVA: 0x0005DB88 File Offset: 0x0005BD88
		[Token(Token = "0x600F986")]
		[Address(RVA = "0x6FEAF0", Offset = "0x6FD6F0", VA = "0x1806FEAF0")]
		private bool <>xLuaBaseProxy_TryHookAudio(string P0, string P1, out string P2, out string P3)
		{
			return default(bool);
		}

		// Token: 0x0600F987 RID: 63879 RVA: 0x0005DBA0 File Offset: 0x0005BDA0
		[Token(Token = "0x600F987")]
		[Address(RVA = "0x6FEB10", Offset = "0x6FD710", VA = "0x1806FEB10")]
		private bool <>xLuaBaseProxy_TryHookProjectile(string P0, out string P1, out string P2, out Entity.MountPointType P3)
		{
			return default(bool);
		}

		// Token: 0x0600F988 RID: 63880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F988")]
		[Address(RVA = "0x6FE980", Offset = "0x6FD580", VA = "0x1806FE980")]
		private Blackboard <>xLuaBaseProxy_GetAttackBlackboard(UnitMode P0)
		{
			return null;
		}

		// Token: 0x0600F989 RID: 63881 RVA: 0x0005DBB8 File Offset: 0x0005BDB8
		[Token(Token = "0x600F989")]
		[Address(RVA = "0x6FEC70", Offset = "0x6FD870", VA = "0x1806FEC70")]
		private bool <>xLuaBaseProxy_isStillMotionTargetFreeWithImmuneFlag(AbnormalFlag P0, AbnormalCombo P1, MotionMode P2)
		{
			return default(bool);
		}

		// Token: 0x0600F98A RID: 63882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F98A")]
		[Address(RVA = "0x6FEA90", Offset = "0x6FD690", VA = "0x1806FEA90")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0600F98B RID: 63883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F98B")]
		[Address(RVA = "0x6FEAB0", Offset = "0x6FD6B0", VA = "0x1806FEAB0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600F98C RID: 63884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F98C")]
		[Address(RVA = "0x6FE9D0", Offset = "0x6FD5D0", VA = "0x1806FE9D0")]
		private void <>xLuaBaseProxy_OnAwake()
		{
		}

		// Token: 0x0600F98D RID: 63885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F98D")]
		[Address(RVA = "0x6FEA20", Offset = "0x6FD620", VA = "0x1806FEA20")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600F98E RID: 63886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F98E")]
		[Address(RVA = "0x6FE9E0", Offset = "0x6FD5E0", VA = "0x1806FE9E0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600F98F RID: 63887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F98F")]
		[Address(RVA = "0x6FEA40", Offset = "0x6FD640", VA = "0x1806FEA40")]
		private void <>xLuaBaseProxy_OnReborn(Unit.RebornData P0)
		{
		}

		// Token: 0x0600F990 RID: 63888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F990")]
		[Address(RVA = "0x6FEA10", Offset = "0x6FD610", VA = "0x1806FEA10")]
		private void <>xLuaBaseProxy_OnHpZero(bool P0, bool P1)
		{
		}

		// Token: 0x0600F991 RID: 63889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F991")]
		[Address(RVA = "0x6FEAA0", Offset = "0x6FD6A0", VA = "0x1806FEAA0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600F992 RID: 63890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F992")]
		[Address(RVA = "0x6FEB20", Offset = "0x6FD720", VA = "0x1806FEB20")]
		private void <>xLuaBaseProxy__AssignLocalPosInternal(Vector3 P0)
		{
		}

		// Token: 0x0600F993 RID: 63891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F993")]
		[Address(RVA = "0x6FEA30", Offset = "0x6FD630", VA = "0x1806FEA30")]
		private void <>xLuaBaseProxy_OnLocate()
		{
		}

		// Token: 0x0600F994 RID: 63892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F994")]
		[Address(RVA = "0x6FEA00", Offset = "0x6FD600", VA = "0x1806FEA00")]
		private void <>xLuaBaseProxy_OnFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600F995 RID: 63893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F995")]
		[Address(RVA = "0x6FE9C0", Offset = "0x6FD5C0", VA = "0x1806FE9C0")]
		private void <>xLuaBaseProxy_OnAttributeDirty(AttributeType P0, FP P1)
		{
		}

		// Token: 0x0600F996 RID: 63894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F996")]
		[Address(RVA = "0x6FE9F0", Offset = "0x6FD5F0", VA = "0x1806FE9F0")]
		private void <>xLuaBaseProxy_OnDisappearChanged(bool P0)
		{
		}

		// Token: 0x0600F997 RID: 63895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F997")]
		[Address(RVA = "0x6FEAC0", Offset = "0x6FD6C0", VA = "0x1806FEAC0")]
		private void <>xLuaBaseProxy_PopulateSnapshotToHashBuilder(HashCodeBuilder P0)
		{
		}

		// Token: 0x0600F998 RID: 63896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F998")]
		[Address(RVA = "0x6FEAD0", Offset = "0x6FD6D0", VA = "0x1806FEAD0")]
		private void <>xLuaBaseProxy_PopulateSnapshotToStrBuilder(StringBuilder P0)
		{
		}

		// Token: 0x0600F999 RID: 63897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F999")]
		[Address(RVA = "0x6FE990", Offset = "0x6FD590", VA = "0x1806FE990")]
		private AbstractBasicAttack <>xLuaBaseProxy_GetCurrentAttackOrCombatAbility()
		{
			return null;
		}

		// Token: 0x0600F99A RID: 63898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F99A")]
		[Address(RVA = "0x6FE970", Offset = "0x6FD570", VA = "0x1806FE970")]
		private void <>xLuaBaseProxy_GatherHudPluginTypes(List<string> P0)
		{
		}

		// Token: 0x0600F99B RID: 63899 RVA: 0x0005DBD0 File Offset: 0x0005BDD0
		[Token(Token = "0x600F99B")]
		[Address(RVA = "0x6FEC10", Offset = "0x6FD810", VA = "0x1806FEC10")]
		private HudPluginMask <>xLuaBaseProxy_get_hudPluginMask()
		{
			return HudPluginMask.NONE;
		}

		// Token: 0x0401140A RID: 70666
		[Token(Token = "0x401140A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector2 LOG_SNAPSHOT_PERIOD_RANGE;

		// Token: 0x0401140B RID: 70667
		[Token(Token = "0x401140B")]
		private const int FIND_BLOCKEE_TICK = 3;

		// Token: 0x0401140C RID: 70668
		[Token(Token = "0x401140C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly FP HATRED_VALUE_GAP;

		// Token: 0x0401140D RID: 70669
		[Token(Token = "0x401140D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly FP HATRED_VALUE_PER_FRAME_GAP;

		// Token: 0x0401140E RID: 70670
		[Token(Token = "0x401140E")]
		private const int DEFAULT_REMAINING_CHARACTER_CNT_VOLUME = 1;

		// Token: 0x0401140F RID: 70671
		[Token(Token = "0x401140F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		[SerializeField]
		[FormerlySerializedAs("_graphicTransform")]
		private Transform _skinHolder;

		// Token: 0x04011410 RID: 70672
		[Token(Token = "0x4011410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		[SerializeField]
		private MotionMode _motionMode;

		// Token: 0x04011411 RID: 70673
		[Token(Token = "0x4011411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		[SerializeField]
		private MotionMode _blockMode;

		// Token: 0x04011412 RID: 70674
		[Token(Token = "0x4011412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		[SerializeField]
		private bool _ignoreBlockMode;

		// Token: 0x04011413 RID: 70675
		[Token(Token = "0x4011413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A1")]
		[SerializeField]
		private bool _isFixedRotation;

		// Token: 0x04011414 RID: 70676
		[Token(Token = "0x4011414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A2")]
		[SerializeField]
		private bool _occupiedRemainingCharacterCnt;

		// Token: 0x04011415 RID: 70677
		[Token(Token = "0x4011415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A3")]
		[SerializeField]
		private bool _useRealBornTimeFromAnim;

		// Token: 0x04011416 RID: 70678
		[Token(Token = "0x4011416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		[SerializeField]
		private BuildCondition _buildCondition;

		// Token: 0x04011417 RID: 70679
		[Token(Token = "0x4011417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		[SerializeField]
		private Ability _traitAbility;

		// Token: 0x04011418 RID: 70680
		[Token(Token = "0x4011418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		[SerializeField]
		private float _withdrawCostRecoverRatio;

		// Token: 0x04011419 RID: 70681
		[Token(Token = "0x4011419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x304")]
		[SerializeField]
		private float _maxWithdrawCostRatioOfRawCost;

		// Token: 0x0401141A RID: 70682
		[Token(Token = "0x401141A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		[SerializeField]
		private Transform _directionTransform;

		// Token: 0x0401141B RID: 70683
		[Token(Token = "0x401141B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		[SerializeField]
		private Transform _directionIndicator;

		// Token: 0x0401141C RID: 70684
		[Token(Token = "0x401141C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		[SerializeField]
		protected string _startEffect;

		// Token: 0x0401141D RID: 70685
		[Token(Token = "0x401141D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		[SerializeField]
		protected string _deadEffect;

		// Token: 0x0401141E RID: 70686
		[Token(Token = "0x401141E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		[SerializeField]
		private bool _playStartVocal;

		// Token: 0x0401141F RID: 70687
		[Token(Token = "0x401141F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x329")]
		[SerializeField]
		private bool _showDeadTweenColor;

		// Token: 0x04011420 RID: 70688
		[Token(Token = "0x4011420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32A")]
		[SerializeField]
		private bool _useSpecificDeadAnim;

		// Token: 0x04011421 RID: 70689
		[Token(Token = "0x4011421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32B")]
		[SerializeField]
		private bool _onlyPlayStartEffectOnce;

		// Token: 0x04011422 RID: 70690
		[Token(Token = "0x4011422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		[SerializeField]
		private bool _dontMoveCameraWhenFocus;

		// Token: 0x04011423 RID: 70691
		[Token(Token = "0x4011423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32D")]
		[SerializeField]
		private bool _disableCharInfoPanel;

		// Token: 0x04011424 RID: 70692
		[Token(Token = "0x4011424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32E")]
		[SerializeField]
		private bool _disableRotateWhenDead;

		// Token: 0x04011425 RID: 70693
		[Token(Token = "0x4011425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32F")]
		[SerializeField]
		private bool _disableSetDirectionWhenDummy;

		// Token: 0x04011426 RID: 70694
		[Token(Token = "0x4011426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		[SerializeField]
		private bool _clearProjectileWhenDead;

		// Token: 0x04011427 RID: 70695
		[Token(Token = "0x4011427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x331")]
		[SerializeField]
		private Character.UseIdForAudioSignalMask _useIdForAudioSignalMask;

		// Token: 0x04011428 RID: 70696
		[Token(Token = "0x4011428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x332")]
		[SerializeField]
		private bool _preprocessData;

		// Token: 0x04011429 RID: 70697
		[Token(Token = "0x4011429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x333")]
		[SerializeField]
		private bool _disableClickCharacterInfo;

		// Token: 0x0401142A RID: 70698
		[Token(Token = "0x401142A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		[SerializeField]
		private bool _skillUiFollowHeadPint;

		// Token: 0x0401142B RID: 70699
		[Token(Token = "0x401142B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x335")]
		private bool m_isBuiltPredefined;

		// Token: 0x0401142C RID: 70700
		[Token(Token = "0x401142C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x336")]
		protected bool m_spawnMannually;

		// Token: 0x0401142D RID: 70701
		[Token(Token = "0x401142D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x337")]
		private bool m_dontOccupyDeployCnt;

		// Token: 0x0401142E RID: 70702
		[Token(Token = "0x401142E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private AdvancedBuildableMask m_additionalBuildableMask;

		// Token: 0x0401142F RID: 70703
		[Token(Token = "0x401142F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private string m_defaultRangeId;

		// Token: 0x04011430 RID: 70704
		[Token(Token = "0x4011430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private int m_defaultModeIndex;

		// Token: 0x04011431 RID: 70705
		[Token(Token = "0x4011431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private FP m_hatred;

		// Token: 0x04011432 RID: 70706
		[Token(Token = "0x4011432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private FP m_createdTime;

		// Token: 0x04011433 RID: 70707
		[Token(Token = "0x4011433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private FP m_deadTime;

		// Token: 0x04011434 RID: 70708
		[Token(Token = "0x4011434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private string m_talentRange;

		// Token: 0x04011435 RID: 70709
		[Token(Token = "0x4011435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		protected Tile m_rootTile;

		// Token: 0x04011436 RID: 70710
		[Token(Token = "0x4011436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private Character.BlockedEnemyManager m_blockedEnemyMgr;

		// Token: 0x04011437 RID: 70711
		[Token(Token = "0x4011437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private PeriodicTicker m_findBlockeeTicker;

		// Token: 0x04011438 RID: 70712
		[Token(Token = "0x4011438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private PeriodicTimer m_snapshotTimer;

		// Token: 0x04011439 RID: 70713
		[Token(Token = "0x4011439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private Character.IReplacement m_replacement;

		// Token: 0x0401143A RID: 70714
		[Token(Token = "0x401143A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private BasicSkill m_skill;

		// Token: 0x0401143B RID: 70715
		[Token(Token = "0x401143B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private SkillData m_skillData;

		// Token: 0x0401143C RID: 70716
		[Token(Token = "0x401143C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private Unit.RebornData m_rebornData;

		// Token: 0x0401143D RID: 70717
		[Token(Token = "0x401143D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private ObjectPtr<Effect> m_startEffect;

		// Token: 0x0401143E RID: 70718
		[Token(Token = "0x401143E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private FP m_maxEsRatio;

		// Token: 0x0401143F RID: 70719
		[Token(Token = "0x401143F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		protected ListDict<string, string> m_effectOverrideMap;

		// Token: 0x04011440 RID: 70720
		[Token(Token = "0x4011440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private ListDict<GameObject, string> m_equipObjects;

		// Token: 0x04011441 RID: 70721
		[Token(Token = "0x4011441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private UnitAnimator m_currentSkin;

		// Token: 0x04011442 RID: 70722
		[Token(Token = "0x4011442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private IList<DeckBuff> m_deckBuffDatas;

		// Token: 0x04011443 RID: 70723
		[Token(Token = "0x4011443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private IList<Blackboard> m_deckBuffBlackboard;

		// Token: 0x04011444 RID: 70724
		[Token(Token = "0x4011444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private float m_delayToRecycle;

		// Token: 0x04011445 RID: 70725
		[Token(Token = "0x4011445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private UnitDataFlowConfig m_dataFlowConfig;

		// Token: 0x04011446 RID: 70726
		[Token(Token = "0x4011446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private BuildCondition m_buildCondition;

		// Token: 0x04011447 RID: 70727
		[Token(Token = "0x4011447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private AdditionalBuildCondition m_additionalBuildCondition;

		// Token: 0x04011448 RID: 70728
		[Token(Token = "0x4011448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private Ability m_traitAbility;

		// Token: 0x04011449 RID: 70729
		[Token(Token = "0x4011449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		private float m_withdrawCostRecoverRatio;

		// Token: 0x0401144A RID: 70730
		[Token(Token = "0x401144A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
		private bool m_limitMaxWithdrawCostByDeployUse;

		// Token: 0x0401144B RID: 70731
		[Token(Token = "0x401144B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		private Deck.Card.AdvancedCardBuildState m_advancedBuildState;

		// Token: 0x0401144C RID: 70732
		[Token(Token = "0x401144C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4BC")]
		private int m_deployCostThisTime;

		// Token: 0x0401144D RID: 70733
		[Token(Token = "0x401144D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		private int m_originRemainingChrCntVolume;

		// Token: 0x0401144E RID: 70734
		[Token(Token = "0x401144E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C4")]
		private float m_lastTileLocateHeight;

		// Token: 0x0401144F RID: 70735
		[Token(Token = "0x401144F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		private EnableStateWithKey<Character.DisableClickCharacterInfoReasonMask> m_disableClickState;

		// Token: 0x04011450 RID: 70736
		[Token(Token = "0x4011450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		private bool m_externWithdrawGainCostFlag;

		// Token: 0x04011451 RID: 70737
		[Token(Token = "0x4011451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D4")]
		public float m_overrideBornTime;

		// Token: 0x04011453 RID: 70739
		[Token(Token = "0x4011453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4DC")]
		private MotionMode m_changableBlockMode;

		// Token: 0x04011454 RID: 70740
		[Token(Token = "0x4011454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		private MotionMode m_oldBlockMode;

		// Token: 0x04011456 RID: 70742
		[Token(Token = "0x4011456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		protected Collider2D m_mainTriggerCollider;

		// Token: 0x04011457 RID: 70743
		[Token(Token = "0x4011457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		private FP m_mainTriggerColliderRadius;

		// Token: 0x04011458 RID: 70744
		[Token(Token = "0x4011458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_initSideType;

		// Token: 0x04011459 RID: 70745
		[Token(Token = "0x4011459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_skinHolder;

		// Token: 0x0401145A RID: 70746
		[Token(Token = "0x401145A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_graphicHolderTransform;

		// Token: 0x0401145B RID: 70747
		[Token(Token = "0x401145B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_alive;

		// Token: 0x0401145C RID: 70748
		[Token(Token = "0x401145C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_advancedBuildState;

		// Token: 0x0401145D RID: 70749
		[Token(Token = "0x401145D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_aliveOrDying;

		// Token: 0x0401145E RID: 70750
		[Token(Token = "0x401145E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_disableClickCharacterInfo;

		// Token: 0x0401145F RID: 70751
		[Token(Token = "0x401145F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_canBlockEnemyOnRootTile;

		// Token: 0x04011460 RID: 70752
		[Token(Token = "0x4011460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_defaultMode;

		// Token: 0x04011461 RID: 70753
		[Token(Token = "0x4011461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_defaultModeIndex;

		// Token: 0x04011462 RID: 70754
		[Token(Token = "0x4011462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_cardUid;

		// Token: 0x04011463 RID: 70755
		[Token(Token = "0x4011463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_cardUid;

		// Token: 0x04011464 RID: 70756
		[Token(Token = "0x4011464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_tokenOrHostUid;

		// Token: 0x04011465 RID: 70757
		[Token(Token = "0x4011465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_characterId;

		// Token: 0x04011466 RID: 70758
		[Token(Token = "0x4011466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_playStartVocal;

		// Token: 0x04011467 RID: 70759
		[Token(Token = "0x4011467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_rootTile;

		// Token: 0x04011468 RID: 70760
		[Token(Token = "0x4011468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_oldTile;

		// Token: 0x04011469 RID: 70761
		[Token(Token = "0x4011469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_animator;

		// Token: 0x0401146A RID: 70762
		[Token(Token = "0x401146A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_isInCombat;

		// Token: 0x0401146B RID: 70763
		[Token(Token = "0x401146B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_hatred;

		// Token: 0x0401146C RID: 70764
		[Token(Token = "0x401146C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_maxEs;

		// Token: 0x0401146D RID: 70765
		[Token(Token = "0x401146D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_maxEsRatio;

		// Token: 0x0401146E RID: 70766
		[Token(Token = "0x401146E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_talentRange;

		// Token: 0x0401146F RID: 70767
		[Token(Token = "0x401146F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_originBuildCondition;

		// Token: 0x04011470 RID: 70768
		[Token(Token = "0x4011470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_buildCondition;

		// Token: 0x04011471 RID: 70769
		[Token(Token = "0x4011471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_additionalBuildCondition;

		// Token: 0x04011472 RID: 70770
		[Token(Token = "0x4011472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_additionalBuildType;

		// Token: 0x04011473 RID: 70771
		[Token(Token = "0x4011473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_addtionalMask;

		// Token: 0x04011474 RID: 70772
		[Token(Token = "0x4011474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_attack;

		// Token: 0x04011475 RID: 70773
		[Token(Token = "0x4011475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_rawAttackWithoutReplacement;

		// Token: 0x04011476 RID: 70774
		[Token(Token = "0x4011476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_combat;

		// Token: 0x04011477 RID: 70775
		[Token(Token = "0x4011477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_hasCombat;

		// Token: 0x04011478 RID: 70776
		[Token(Token = "0x4011478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_rawCombatWithoutReplacement;

		// Token: 0x04011479 RID: 70777
		[Token(Token = "0x4011479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_attackTrigger;

		// Token: 0x0401147A RID: 70778
		[Token(Token = "0x401147A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_skill;

		// Token: 0x0401147B RID: 70779
		[Token(Token = "0x401147B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_skillData;

		// Token: 0x0401147C RID: 70780
		[Token(Token = "0x401147C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_hideTileOption;

		// Token: 0x0401147D RID: 70781
		[Token(Token = "0x401147D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_hasSkill;

		// Token: 0x0401147E RID: 70782
		[Token(Token = "0x401147E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_showSkill;

		// Token: 0x0401147F RID: 70783
		[Token(Token = "0x401147F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_showHpSlider;

		// Token: 0x04011480 RID: 70784
		[Token(Token = "0x4011480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_showSpSlider;

		// Token: 0x04011481 RID: 70785
		[Token(Token = "0x4011481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_showShield;

		// Token: 0x04011482 RID: 70786
		[Token(Token = "0x4011482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_forceUseAllyHud;

		// Token: 0x04011483 RID: 70787
		[Token(Token = "0x4011483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_traitAbility;

		// Token: 0x04011484 RID: 70788
		[Token(Token = "0x4011484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_dontMoveCameraWhenFocus;

		// Token: 0x04011485 RID: 70789
		[Token(Token = "0x4011485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_disableCharInfoPanel;

		// Token: 0x04011486 RID: 70790
		[Token(Token = "0x4011486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_traitOrTraitAsTalentAbility;

		// Token: 0x04011487 RID: 70791
		[Token(Token = "0x4011487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_get_traitAsTalent;

		// Token: 0x04011488 RID: 70792
		[Token(Token = "0x4011488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x04011489 RID: 70793
		[Token(Token = "0x4011489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_get_defaultRangeId;

		// Token: 0x0401148A RID: 70794
		[Token(Token = "0x401148A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_get_isToken;

		// Token: 0x0401148B RID: 70795
		[Token(Token = "0x401148B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_get_originOccupiedRemainingCharacterCnt;

		// Token: 0x0401148C RID: 70796
		[Token(Token = "0x401148C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_get_occupiedRemainingCharacterCnt;

		// Token: 0x0401148D RID: 70797
		[Token(Token = "0x401148D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_get_originRemainingCharacterCntVolume;

		// Token: 0x0401148E RID: 70798
		[Token(Token = "0x401148E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_set_originRemainingCharacterCntVolume;

		// Token: 0x0401148F RID: 70799
		[Token(Token = "0x401148F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_get_remainingCharacterCntVolume;

		// Token: 0x04011490 RID: 70800
		[Token(Token = "0x4011490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_get_overflowOccupiedCnt;

		// Token: 0x04011491 RID: 70801
		[Token(Token = "0x4011491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_get_withdrawable;

		// Token: 0x04011492 RID: 70802
		[Token(Token = "0x4011492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_get_isManuallySpawned;

		// Token: 0x04011493 RID: 70803
		[Token(Token = "0x4011493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_get_manuallyWithdrawable;

		// Token: 0x04011494 RID: 70804
		[Token(Token = "0x4011494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_get_isMine;

		// Token: 0x04011495 RID: 70805
		[Token(Token = "0x4011495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_IsControllable;

		// Token: 0x04011496 RID: 70806
		[Token(Token = "0x4011496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_get_isBuiltPredefined;

		// Token: 0x04011497 RID: 70807
		[Token(Token = "0x4011497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_get_isPlayerCharacter;

		// Token: 0x04011498 RID: 70808
		[Token(Token = "0x4011498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_get_directionTransform;

		// Token: 0x04011499 RID: 70809
		[Token(Token = "0x4011499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_get_blockedEnemies;

		// Token: 0x0401149A RID: 70810
		[Token(Token = "0x401149A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_get_blockedTotalVolumn;

		// Token: 0x0401149B RID: 70811
		[Token(Token = "0x401149B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_get_directionIndicator;

		// Token: 0x0401149C RID: 70812
		[Token(Token = "0x401149C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_get_blockRadiusSquare;

		// Token: 0x0401149D RID: 70813
		[Token(Token = "0x401149D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_get_blockCircle;

		// Token: 0x0401149E RID: 70814
		[Token(Token = "0x401149E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_get_minBlockDistToTarget;

		// Token: 0x0401149F RID: 70815
		[Token(Token = "0x401149F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_get_traitBlackboard;

		// Token: 0x040114A0 RID: 70816
		[Token(Token = "0x40114A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_GetVoiceQuery;

		// Token: 0x040114A1 RID: 70817
		[Token(Token = "0x40114A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_get_blockMode;

		// Token: 0x040114A2 RID: 70818
		[Token(Token = "0x40114A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_get_ignoreBlockMode;

		// Token: 0x040114A3 RID: 70819
		[Token(Token = "0x40114A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_get_isFixedRotation;

		// Token: 0x040114A4 RID: 70820
		[Token(Token = "0x40114A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_get_initState;

		// Token: 0x040114A5 RID: 70821
		[Token(Token = "0x40114A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_get_delayToRecycle;

		// Token: 0x040114A6 RID: 70822
		[Token(Token = "0x40114A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_get_allowWithdrawGainCost;

		// Token: 0x040114A7 RID: 70823
		[Token(Token = "0x40114A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_SetExternWithdrawGainCostFlag;

		// Token: 0x040114A8 RID: 70824
		[Token(Token = "0x40114A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_get_stateMachine;

		// Token: 0x040114A9 RID: 70825
		[Token(Token = "0x40114A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x040114AA RID: 70826
		[Token(Token = "0x40114AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_set_data;

		// Token: 0x040114AB RID: 70827
		[Token(Token = "0x40114AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_get_sharedData;

		// Token: 0x040114AC RID: 70828
		[Token(Token = "0x40114AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_get_managedProjectiles;

		// Token: 0x040114AD RID: 70829
		[Token(Token = "0x40114AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_get_createdTime;

		// Token: 0x040114AE RID: 70830
		[Token(Token = "0x40114AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_get_deadTime;

		// Token: 0x040114AF RID: 70831
		[Token(Token = "0x40114AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_get_startEffect;

		// Token: 0x040114B0 RID: 70832
		[Token(Token = "0x40114B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_get_deadEffect;

		// Token: 0x040114B1 RID: 70833
		[Token(Token = "0x40114B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_get_hasReplacement;

		// Token: 0x040114B2 RID: 70834
		[Token(Token = "0x40114B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_get_isInSkillState;

		// Token: 0x040114B3 RID: 70835
		[Token(Token = "0x40114B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_get_isInAttackState;

		// Token: 0x040114B4 RID: 70836
		[Token(Token = "0x40114B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_get_isInCombatState;

		// Token: 0x040114B5 RID: 70837
		[Token(Token = "0x40114B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_get_isInRebornState;

		// Token: 0x040114B6 RID: 70838
		[Token(Token = "0x40114B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_get_isInIdletState;

		// Token: 0x040114B7 RID: 70839
		[Token(Token = "0x40114B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_get_isInDyingState;

		// Token: 0x040114B8 RID: 70840
		[Token(Token = "0x40114B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_get_canBeReplace;

		// Token: 0x040114B9 RID: 70841
		[Token(Token = "0x40114B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_get_skillUiFollowHeadPoint;

		// Token: 0x040114BA RID: 70842
		[Token(Token = "0x40114BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_get_alwaysBlockFree;

		// Token: 0x040114BB RID: 70843
		[Token(Token = "0x40114BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_PlayBornAnimationAndEffect;

		// Token: 0x040114BC RID: 70844
		[Token(Token = "0x40114BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_StopBornAnimationAndEffect;

		// Token: 0x040114BD RID: 70845
		[Token(Token = "0x40114BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_ResetBornAnimationAndEffect;

		// Token: 0x040114BE RID: 70846
		[Token(Token = "0x40114BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0__PlayUniEquipEffect;

		// Token: 0x040114BF RID: 70847
		[Token(Token = "0x40114BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_BuildAt;

		// Token: 0x040114C0 RID: 70848
		[Token(Token = "0x40114C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_BuildAsPredefined;

		// Token: 0x040114C1 RID: 70849
		[Token(Token = "0x40114C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_BuildAsRuntimeInst;

		// Token: 0x040114C2 RID: 70850
		[Token(Token = "0x40114C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_Born;

		// Token: 0x040114C3 RID: 70851
		[Token(Token = "0x40114C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_MakeDummy;

		// Token: 0x040114C4 RID: 70852
		[Token(Token = "0x40114C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_OpTrigSkill;

		// Token: 0x040114C5 RID: 70853
		[Token(Token = "0x40114C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_RemoteTrigSkill;

		// Token: 0x040114C6 RID: 70854
		[Token(Token = "0x40114C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_TriggerAutoSkill;

		// Token: 0x040114C7 RID: 70855
		[Token(Token = "0x40114C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_SwitchToAttackState;

		// Token: 0x040114C8 RID: 70856
		[Token(Token = "0x40114C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_SwitchToSkillState;

		// Token: 0x040114C9 RID: 70857
		[Token(Token = "0x40114C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_SwitchOutFromSkillState;

		// Token: 0x040114CA RID: 70858
		[Token(Token = "0x40114CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_CheckIsBornState;

		// Token: 0x040114CB RID: 70859
		[Token(Token = "0x40114CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_Withdraw;

		// Token: 0x040114CC RID: 70860
		[Token(Token = "0x40114CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_WithdrawByLevel;

		// Token: 0x040114CD RID: 70861
		[Token(Token = "0x40114CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_CheckBuildable;

		// Token: 0x040114CE RID: 70862
		[Token(Token = "0x40114CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_CheckRespawnSelfBuildable;

		// Token: 0x040114CF RID: 70863
		[Token(Token = "0x40114CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_LocateOnTile;

		// Token: 0x040114D0 RID: 70864
		[Token(Token = "0x40114D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_RechargeToken;

		// Token: 0x040114D1 RID: 70865
		[Token(Token = "0x40114D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_RefreshTokenDeployAndStackCnt;

		// Token: 0x040114D2 RID: 70866
		[Token(Token = "0x40114D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_FetchHost;

		// Token: 0x040114D3 RID: 70867
		[Token(Token = "0x40114D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_TryGetAtkAsHostBased;

		// Token: 0x040114D4 RID: 70868
		[Token(Token = "0x40114D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_ResetSearchBlockeeTicker;

		// Token: 0x040114D5 RID: 70869
		[Token(Token = "0x40114D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_SearchBlockeeImmediate;

		// Token: 0x040114D6 RID: 70870
		[Token(Token = "0x40114D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_FetchTokenOrHost;

		// Token: 0x040114D7 RID: 70871
		[Token(Token = "0x40114D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_GetCurrentModeRangeId;

		// Token: 0x040114D8 RID: 70872
		[Token(Token = "0x40114D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_GetModeRangeId;

		// Token: 0x040114D9 RID: 70873
		[Token(Token = "0x40114D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_GetRangeOfSkill;

		// Token: 0x040114DA RID: 70874
		[Token(Token = "0x40114DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_PlayAudioSignal;

		// Token: 0x040114DB RID: 70875
		[Token(Token = "0x40114DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0__GetCharacterSignal;

		// Token: 0x040114DC RID: 70876
		[Token(Token = "0x40114DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x040114DD RID: 70877
		[Token(Token = "0x40114DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix0_CheckUseIdForAudioSignal;

		// Token: 0x040114DE RID: 70878
		[Token(Token = "0x40114DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040114DF RID: 70879
		[Token(Token = "0x40114DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		private static DelegateBridge __Hotfix0_ChangeMotionMode;

		// Token: 0x040114E0 RID: 70880
		[Token(Token = "0x40114E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		private static DelegateBridge __Hotfix0_ResetMotionMode;

		// Token: 0x040114E1 RID: 70881
		[Token(Token = "0x40114E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		private static DelegateBridge __Hotfix0_ChangeBlockMode;

		// Token: 0x040114E2 RID: 70882
		[Token(Token = "0x40114E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private static DelegateBridge __Hotfix0_ResetBlockMode;

		// Token: 0x040114E3 RID: 70883
		[Token(Token = "0x40114E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private static DelegateBridge __Hotfix0_OnBlockModeChanged;

		// Token: 0x040114E4 RID: 70884
		[Token(Token = "0x40114E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		private static DelegateBridge __Hotfix0_FinishMe;

		// Token: 0x040114E5 RID: 70885
		[Token(Token = "0x40114E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private static DelegateBridge __Hotfix0_DoFakeDeath;

		// Token: 0x040114E6 RID: 70886
		[Token(Token = "0x40114E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		private static DelegateBridge __Hotfix0_DoReborn;

		// Token: 0x040114E7 RID: 70887
		[Token(Token = "0x40114E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private static DelegateBridge __Hotfix0_ForceDying;

		// Token: 0x040114E8 RID: 70888
		[Token(Token = "0x40114E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private static DelegateBridge __Hotfix0_RespawnSelf;

		// Token: 0x040114E9 RID: 70889
		[Token(Token = "0x40114E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		private static DelegateBridge __Hotfix0_MoveLikeRespawnSelf;

		// Token: 0x040114EA RID: 70890
		[Token(Token = "0x40114EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private static DelegateBridge __Hotfix0_FinishWithReason;

		// Token: 0x040114EB RID: 70891
		[Token(Token = "0x40114EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		private static DelegateBridge __Hotfix1_MoveLikeRespawnSelf;

		// Token: 0x040114EC RID: 70892
		[Token(Token = "0x40114EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		private static DelegateBridge __Hotfix0_MoveLikeRespawnExternal;

		// Token: 0x040114ED RID: 70893
		[Token(Token = "0x40114ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		private static DelegateBridge __Hotfix0__MoveLikeRespawn;

		// Token: 0x040114EE RID: 70894
		[Token(Token = "0x40114EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		private static DelegateBridge __Hotfix0_RespawnSelfAsPredefined;

		// Token: 0x040114EF RID: 70895
		[Token(Token = "0x40114EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		private static DelegateBridge __Hotfix0_GetDelayToRecycleTime;

		// Token: 0x040114F0 RID: 70896
		[Token(Token = "0x40114F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		private static DelegateBridge __Hotfix0_FinishWithReplace;

		// Token: 0x040114F1 RID: 70897
		[Token(Token = "0x40114F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		private static DelegateBridge __Hotfix0_ClearAbilities;

		// Token: 0x040114F2 RID: 70898
		[Token(Token = "0x40114F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		private static DelegateBridge __Hotfix0__ClearAbilityProjectilesIfNeeded;

		// Token: 0x040114F3 RID: 70899
		[Token(Token = "0x40114F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		private static DelegateBridge __Hotfix0__BuildAtInternal;

		// Token: 0x040114F4 RID: 70900
		[Token(Token = "0x40114F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		private static DelegateBridge __Hotfix0__InitAllModeDirection;

		// Token: 0x040114F5 RID: 70901
		[Token(Token = "0x40114F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		private static DelegateBridge __Hotfix0_LogSnapshotIfNot;

		// Token: 0x040114F6 RID: 70902
		[Token(Token = "0x40114F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		private static DelegateBridge __Hotfix0_CheckHasFilterTag;

		// Token: 0x040114F7 RID: 70903
		[Token(Token = "0x40114F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		private static DelegateBridge __Hotfix0_SetAdditionalBuildCondition;

		// Token: 0x040114F8 RID: 70904
		[Token(Token = "0x40114F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		private static DelegateBridge __Hotfix1_SetAdditionalBuildCondition;

		// Token: 0x040114F9 RID: 70905
		[Token(Token = "0x40114F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private static DelegateBridge __Hotfix0_AddOverlapSourceId;

		// Token: 0x040114FA RID: 70906
		[Token(Token = "0x40114FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		private static DelegateBridge __Hotfix0_RemoveOverlapSourceId;

		// Token: 0x040114FB RID: 70907
		[Token(Token = "0x40114FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		private static DelegateBridge __Hotfix0_ModifyOverlapTakeEffect;

		// Token: 0x040114FC RID: 70908
		[Token(Token = "0x40114FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		private static DelegateBridge __Hotfix0_GetEffectReplacePairs;

		// Token: 0x040114FD RID: 70909
		[Token(Token = "0x40114FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		private static DelegateBridge __Hotfix0_TryHookEffect;

		// Token: 0x040114FE RID: 70910
		[Token(Token = "0x40114FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		private static DelegateBridge __Hotfix0_TryHookAudio;

		// Token: 0x040114FF RID: 70911
		[Token(Token = "0x40114FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		private static DelegateBridge __Hotfix0_TryHookProjectile;

		// Token: 0x04011500 RID: 70912
		[Token(Token = "0x4011500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		private static DelegateBridge __Hotfix0_RegisterReplacement;

		// Token: 0x04011501 RID: 70913
		[Token(Token = "0x4011501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		private static DelegateBridge __Hotfix0_UnregisterReplacement;

		// Token: 0x04011502 RID: 70914
		[Token(Token = "0x4011502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		private static DelegateBridge __Hotfix0_CheckIsCurrentReplacement;

		// Token: 0x04011503 RID: 70915
		[Token(Token = "0x4011503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		private static DelegateBridge __Hotfix0_ClearReplacement;

		// Token: 0x04011504 RID: 70916
		[Token(Token = "0x4011504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		private static DelegateBridge __Hotfix0_GetStartEffect;

		// Token: 0x04011505 RID: 70917
		[Token(Token = "0x4011505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		private static DelegateBridge __Hotfix0_GetDeadEffect;

		// Token: 0x04011506 RID: 70918
		[Token(Token = "0x4011506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		private static DelegateBridge __Hotfix0_GetAttackBlackboard;

		// Token: 0x04011507 RID: 70919
		[Token(Token = "0x4011507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		private static DelegateBridge __Hotfix0__CheckCanSwithToAttackState;

		// Token: 0x04011508 RID: 70920
		[Token(Token = "0x4011508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		private static DelegateBridge __Hotfix0__SearchAttackTarget;

		// Token: 0x04011509 RID: 70921
		[Token(Token = "0x4011509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		private static DelegateBridge __Hotfix0__FetchCombatTarget;

		// Token: 0x0401150A RID: 70922
		[Token(Token = "0x401150A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		private static DelegateBridge __Hotfix0_TryFaceToIdleDirection;

		// Token: 0x0401150B RID: 70923
		[Token(Token = "0x401150B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		private static DelegateBridge __Hotfix0_isStillMotionTargetFreeWithImmuneFlag;

		// Token: 0x0401150C RID: 70924
		[Token(Token = "0x401150C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		private static DelegateBridge __Hotfix0_CheckInBlockRange;

		// Token: 0x0401150D RID: 70925
		[Token(Token = "0x401150D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		private static DelegateBridge __Hotfix0__SearchBlockee;

		// Token: 0x0401150E RID: 70926
		[Token(Token = "0x401150E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		private static DelegateBridge __Hotfix0__CheckBlockable;

		// Token: 0x0401150F RID: 70927
		[Token(Token = "0x401150F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		private static DelegateBridge __Hotfix0_CheckBlockVolumeNotExceeded;

		// Token: 0x04011510 RID: 70928
		[Token(Token = "0x4011510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		private static DelegateBridge __Hotfix0__ClearAllBlockees;

		// Token: 0x04011511 RID: 70929
		[Token(Token = "0x4011511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		private static DelegateBridge __Hotfix0__AddBlockee;

		// Token: 0x04011512 RID: 70930
		[Token(Token = "0x4011512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		private static DelegateBridge __Hotfix0_RemoveBlockee;

		// Token: 0x04011513 RID: 70931
		[Token(Token = "0x4011513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		private static DelegateBridge __Hotfix0_RecalculateBlockeesTotalVolume;

		// Token: 0x04011514 RID: 70932
		[Token(Token = "0x4011514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		private static DelegateBridge __Hotfix0_UpdateBlockees;

		// Token: 0x04011515 RID: 70933
		[Token(Token = "0x4011515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		private static DelegateBridge __Hotfix0_SetupSkin;

		// Token: 0x04011516 RID: 70934
		[Token(Token = "0x4011516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		private static DelegateBridge __Hotfix0_RecycleSkinIfNot;

		// Token: 0x04011517 RID: 70935
		[Token(Token = "0x4011517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04011518 RID: 70936
		[Token(Token = "0x4011518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011519 RID: 70937
		[Token(Token = "0x4011519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		private static DelegateBridge __Hotfix0_GetTileLocateHeight;

		// Token: 0x0401151A RID: 70938
		[Token(Token = "0x401151A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		private static DelegateBridge __Hotfix0_OnAwake;

		// Token: 0x0401151B RID: 70939
		[Token(Token = "0x401151B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x630")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401151C RID: 70940
		[Token(Token = "0x401151C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x638")]
		private static DelegateBridge __Hotfix0__SpawnDeckBuffs;

		// Token: 0x0401151D RID: 70941
		[Token(Token = "0x401151D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x640")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x0401151E RID: 70942
		[Token(Token = "0x401151E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x648")]
		private static DelegateBridge __Hotfix0_OnReborn;

		// Token: 0x0401151F RID: 70943
		[Token(Token = "0x401151F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x650")]
		private static DelegateBridge __Hotfix0_OnHpZero;

		// Token: 0x04011520 RID: 70944
		[Token(Token = "0x4011520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x658")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04011521 RID: 70945
		[Token(Token = "0x4011521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x660")]
		private static DelegateBridge __Hotfix0__AssignLocalPosInternal;

		// Token: 0x04011522 RID: 70946
		[Token(Token = "0x4011522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x668")]
		private static DelegateBridge __Hotfix0_OnLocate;

		// Token: 0x04011523 RID: 70947
		[Token(Token = "0x4011523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x670")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04011524 RID: 70948
		[Token(Token = "0x4011524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x678")]
		private static DelegateBridge __Hotfix0_ConstructStateMachine;

		// Token: 0x04011525 RID: 70949
		[Token(Token = "0x4011525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x680")]
		private static DelegateBridge __Hotfix0_OnAttributeDirty;

		// Token: 0x04011526 RID: 70950
		[Token(Token = "0x4011526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x688")]
		private static DelegateBridge __Hotfix0_OnDisappearChanged;

		// Token: 0x04011527 RID: 70951
		[Token(Token = "0x4011527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x690")]
		private static DelegateBridge __Hotfix0_CheckModeChangeBeforeAttack;

		// Token: 0x04011528 RID: 70952
		[Token(Token = "0x4011528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x698")]
		private static DelegateBridge __Hotfix0_OnBeforeAttack;

		// Token: 0x04011529 RID: 70953
		[Token(Token = "0x4011529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
		private static DelegateBridge __Hotfix0_OnAfterAttack;

		// Token: 0x0401152A RID: 70954
		[Token(Token = "0x401152A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
		private static DelegateBridge __Hotfix0_OnBeforeSkill;

		// Token: 0x0401152B RID: 70955
		[Token(Token = "0x401152B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
		private static DelegateBridge __Hotfix0_OnAfterSkill;

		// Token: 0x0401152C RID: 70956
		[Token(Token = "0x401152C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
		private static DelegateBridge __Hotfix0_OnSkillStart;

		// Token: 0x0401152D RID: 70957
		[Token(Token = "0x401152D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
		private static DelegateBridge __Hotfix0_OnToggleSkillStart;

		// Token: 0x0401152E RID: 70958
		[Token(Token = "0x401152E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
		private static DelegateBridge __Hotfix0_OnSkillRetriggered;

		// Token: 0x0401152F RID: 70959
		[Token(Token = "0x401152F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
		private static DelegateBridge __Hotfix0_OnSkillCastSucceed;

		// Token: 0x04011530 RID: 70960
		[Token(Token = "0x4011530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
		private static DelegateBridge __Hotfix0_OnSkillFinish;

		// Token: 0x04011531 RID: 70961
		[Token(Token = "0x4011531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E0")]
		private static DelegateBridge __Hotfix0_PopulateSnapshotToHashBuilder;

		// Token: 0x04011532 RID: 70962
		[Token(Token = "0x4011532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
		private static DelegateBridge __Hotfix0_PopulateSnapshotToStrBuilder;

		// Token: 0x04011533 RID: 70963
		[Token(Token = "0x4011533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
		private static DelegateBridge __Hotfix0_CreateSkill;

		// Token: 0x04011534 RID: 70964
		[Token(Token = "0x4011534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
		private static DelegateBridge __Hotfix0_BlockeeOffsetPosSet;

		// Token: 0x04011535 RID: 70965
		[Token(Token = "0x4011535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x700")]
		private static DelegateBridge __Hotfix0_UpdateHatred;

		// Token: 0x04011536 RID: 70966
		[Token(Token = "0x4011536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x708")]
		private static DelegateBridge __Hotfix1_UpdateHatred;

		// Token: 0x04011537 RID: 70967
		[Token(Token = "0x4011537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x710")]
		private static DelegateBridge __Hotfix0_EnsureSkillOnInAbnormalState;

		// Token: 0x04011538 RID: 70968
		[Token(Token = "0x4011538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x718")]
		private static DelegateBridge __Hotfix0__AssignData;

		// Token: 0x04011539 RID: 70969
		[Token(Token = "0x4011539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x720")]
		private static DelegateBridge __Hotfix0__PreprocessSkill;

		// Token: 0x0401153A RID: 70970
		[Token(Token = "0x401153A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x728")]
		private static DelegateBridge __Hotfix0__RecycleEquipIfNot;

		// Token: 0x0401153B RID: 70971
		[Token(Token = "0x401153B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x730")]
		private static DelegateBridge __Hotfix0__AssignSkill;

		// Token: 0x0401153C RID: 70972
		[Token(Token = "0x401153C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x738")]
		private static DelegateBridge __Hotfix0__PreprocessSkin;

		// Token: 0x0401153D RID: 70973
		[Token(Token = "0x401153D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x740")]
		private static DelegateBridge __Hotfix0__CheckDontCreateSkinBeforeGameLoaded;

		// Token: 0x0401153E RID: 70974
		[Token(Token = "0x401153E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x748")]
		private static DelegateBridge __Hotfix0__PreprocessEquip;

		// Token: 0x0401153F RID: 70975
		[Token(Token = "0x401153F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x750")]
		private static DelegateBridge __Hotfix0__PreprocessTalents;

		// Token: 0x04011540 RID: 70976
		[Token(Token = "0x4011540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x758")]
		private static DelegateBridge __Hotfix0__AssignTalents;

		// Token: 0x04011541 RID: 70977
		[Token(Token = "0x4011541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x760")]
		private static DelegateBridge __Hotfix0_ReassignTalents;

		// Token: 0x04011542 RID: 70978
		[Token(Token = "0x4011542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x768")]
		private static DelegateBridge __Hotfix0__AssignTrait;

		// Token: 0x04011543 RID: 70979
		[Token(Token = "0x4011543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x770")]
		private static DelegateBridge __Hotfix0__PreprocessTrait;

		// Token: 0x04011544 RID: 70980
		[Token(Token = "0x4011544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x778")]
		private static DelegateBridge __Hotfix0__EquipProcessTalents;

		// Token: 0x04011545 RID: 70981
		[Token(Token = "0x4011545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x780")]
		private static DelegateBridge __Hotfix0__EquipProcessTrait;

		// Token: 0x04011546 RID: 70982
		[Token(Token = "0x4011546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x788")]
		private static DelegateBridge __Hotfix0__GetDefaultModeIndex;

		// Token: 0x04011547 RID: 70983
		[Token(Token = "0x4011547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x790")]
		private static DelegateBridge __Hotfix0__GetDefaultRangeId;

		// Token: 0x04011548 RID: 70984
		[Token(Token = "0x4011548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x798")]
		private static DelegateBridge __Hotfix0_OnEquipProcessed;

		// Token: 0x04011549 RID: 70985
		[Token(Token = "0x4011549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A0")]
		private static DelegateBridge __Hotfix0_GetCurrentAttackOrCombatAbility;

		// Token: 0x0401154A RID: 70986
		[Token(Token = "0x401154A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A8")]
		private static DelegateBridge __Hotfix0_GetSpecialModeAttack;

		// Token: 0x0401154B RID: 70987
		[Token(Token = "0x401154B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B0")]
		private static DelegateBridge __Hotfix0_get_ColliderRadius;

		// Token: 0x0401154C RID: 70988
		[Token(Token = "0x401154C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B8")]
		private static DelegateBridge __Hotfix0_OnRallyPointLikeReborn;

		// Token: 0x0401154D RID: 70989
		[Token(Token = "0x401154D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C0")]
		private static DelegateBridge __Hotfix0_OnTokenCategoryChanged;

		// Token: 0x0401154E RID: 70990
		[Token(Token = "0x401154E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C8")]
		private static DelegateBridge __Hotfix0__ReactivateMainTriggerCollider;

		// Token: 0x0401154F RID: 70991
		[Token(Token = "0x401154F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D0")]
		private static DelegateBridge __Hotfix0_SetDontOccupyDeployCntFlag;

		// Token: 0x04011550 RID: 70992
		[Token(Token = "0x4011550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D8")]
		private static DelegateBridge __Hotfix0_SetDisableClickCharacterInfo;

		// Token: 0x04011551 RID: 70993
		[Token(Token = "0x4011551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E0")]
		private static DelegateBridge __Hotfix0_SetWithdrawCostRecoverRatio;

		// Token: 0x04011552 RID: 70994
		[Token(Token = "0x4011552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E8")]
		private static DelegateBridge __Hotfix0_UpdateMaxEs;

		// Token: 0x04011553 RID: 70995
		[Token(Token = "0x4011553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
		private static DelegateBridge __Hotfix0_OnEntityOverlapLikeOperationSucceed;

		// Token: 0x04011554 RID: 70996
		[Token(Token = "0x4011554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
		private static DelegateBridge __Hotfix0_OnEntityWillOverlap;

		// Token: 0x04011555 RID: 70997
		[Token(Token = "0x4011555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x800")]
		private static DelegateBridge __Hotfix0_GatherHudPluginTypes;

		// Token: 0x04011556 RID: 70998
		[Token(Token = "0x4011556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x808")]
		private static DelegateBridge __Hotfix0_get_hudPluginMask;

		// Token: 0x04011557 RID: 70999
		[Token(Token = "0x4011557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x810")]
		private static DelegateBridge __Hotfix0_GetBakeMuzzleDataPath;

		// Token: 0x04011558 RID: 71000
		[Token(Token = "0x4011558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x818")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020025A4 RID: 9636
		[Token(Token = "0x20025A4")]
		[Flags]
		public enum UseIdForAudioSignalMask : byte
		{
			// Token: 0x0401155A RID: 71002
			[Token(Token = "0x401155A")]
			NONE = 0,
			// Token: 0x0401155B RID: 71003
			[Token(Token = "0x401155B")]
			ON_UNIT_BORN = 1,
			// Token: 0x0401155C RID: 71004
			[Token(Token = "0x401155C")]
			ON_UNIT_DEAD = 2
		}

		// Token: 0x020025A5 RID: 9637
		[Token(Token = "0x20025A5")]
		public enum DisableClickCharacterInfoReasonMask : byte
		{
			// Token: 0x0401155E RID: 71006
			[Token(Token = "0x401155E")]
			OWNER_SETTING = 1,
			// Token: 0x0401155F RID: 71007
			[Token(Token = "0x401155F")]
			FOG,
			// Token: 0x04011560 RID: 71008
			[Token(Token = "0x4011560")]
			SANDBOX,
			// Token: 0x04011561 RID: 71009
			[Token(Token = "0x4011561")]
			RACING
		}

		// Token: 0x020025A6 RID: 9638
		[Token(Token = "0x20025A6")]
		public static class States
		{
			// Token: 0x0600F99C RID: 63900 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F99C")]
			[Address(RVA = "0x737C80", Offset = "0x736880", VA = "0x180737C80")]
			public static StateMachine ConstructStateMachine(Character owner)
			{
				return null;
			}

			// Token: 0x020025A7 RID: 9639
			[Token(Token = "0x20025A7")]
			public enum State
			{
				// Token: 0x04011563 RID: 71011
				[Token(Token = "0x4011563")]
				DEFAULT,
				// Token: 0x04011564 RID: 71012
				[Token(Token = "0x4011564")]
				IDLE,
				// Token: 0x04011565 RID: 71013
				[Token(Token = "0x4011565")]
				ATTACK,
				// Token: 0x04011566 RID: 71014
				[Token(Token = "0x4011566")]
				COMBAT,
				// Token: 0x04011567 RID: 71015
				[Token(Token = "0x4011567")]
				SKILL,
				// Token: 0x04011568 RID: 71016
				[Token(Token = "0x4011568")]
				STUN,
				// Token: 0x04011569 RID: 71017
				[Token(Token = "0x4011569")]
				DEAD,
				// Token: 0x0401156A RID: 71018
				[Token(Token = "0x401156A")]
				BORN,
				// Token: 0x0401156B RID: 71019
				[Token(Token = "0x401156B")]
				DISAPPEAR,
				// Token: 0x0401156C RID: 71020
				[Token(Token = "0x401156C")]
				FROZEN,
				// Token: 0x0401156D RID: 71021
				[Token(Token = "0x401156D")]
				REBORN,
				// Token: 0x0401156E RID: 71022
				[Token(Token = "0x401156E")]
				DYING,
				// Token: 0x0401156F RID: 71023
				[Token(Token = "0x401156F")]
				DIALOG,
				// Token: 0x04011570 RID: 71024
				[Token(Token = "0x4011570")]
				DOZE,
				// Token: 0x04011571 RID: 71025
				[Token(Token = "0x4011571")]
				TERMINAL = -1
			}

			// Token: 0x020025A8 RID: 9640
			[Token(Token = "0x20025A8")]
			public class Blackboard : StateMachine.IBlackboard
			{
				// Token: 0x170020FB RID: 8443
				// (get) Token: 0x0600F99D RID: 63901 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600F99E RID: 63902 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170020FB")]
				public Character owner
				{
					[Token(Token = "0x600F99D")]
					[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x600F99E")]
					[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x0600F99F RID: 63903 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F99F")]
				[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
				public Blackboard(Character owner)
				{
				}

				// Token: 0x0600F9A0 RID: 63904 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9A0")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
				public void OnReset()
				{
				}

				// Token: 0x0600F9A1 RID: 63905 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9A1")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
				public void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600F9A2 RID: 63906 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9A2")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
				public void OnStop()
				{
				}
			}

			// Token: 0x020025A9 RID: 9641
			[Token(Token = "0x20025A9")]
			private abstract class BasicState : HierachyStateMachine<Character.States.State, Character, Character.States.Blackboard>.StateNode, IHotfixable
			{
				// Token: 0x0600F9A3 RID: 63907 RVA: 0x0005DBE8 File Offset: 0x0005BDE8
				[Token(Token = "0x600F9A3")]
				[Address(RVA = "0x71B7C0", Offset = "0x71A3C0", VA = "0x18071B7C0")]
				protected bool ShouldSwitchToAbnormalState(Character.States.State currentStateAsCondition = Character.States.State.IDLE)
				{
					return default(bool);
				}

				// Token: 0x0600F9A4 RID: 63908 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9A4")]
				[Address(RVA = "0x71BAA0", Offset = "0x71A6A0", VA = "0x18071BAA0")]
				protected BasicState()
				{
				}

				// Token: 0x04011573 RID: 71027
				[Token(Token = "0x4011573")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_ShouldSwitchToAbnormalState;

				// Token: 0x04011574 RID: 71028
				[Token(Token = "0x4011574")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025AA RID: 9642
			[Token(Token = "0x20025AA")]
			private class BornState : Character.States.BasicState
			{
				// Token: 0x0600F9A5 RID: 63909 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9A5")]
				[Address(RVA = "0x71C130", Offset = "0x71AD30", VA = "0x18071C130", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600F9A6 RID: 63910 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9A6")]
				[Address(RVA = "0x71C380", Offset = "0x71AF80", VA = "0x18071C380", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600F9A7 RID: 63911 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9A7")]
				[Address(RVA = "0x71C2E0", Offset = "0x71AEE0", VA = "0x18071C2E0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600F9A8 RID: 63912 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9A8")]
				[Address(RVA = "0x71C5F0", Offset = "0x71B1F0", VA = "0x18071C5F0")]
				private void _OnLocate()
				{
				}

				// Token: 0x0600F9A9 RID: 63913 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9A9")]
				[Address(RVA = "0x71C710", Offset = "0x71B310", VA = "0x18071C710")]
				public BornState()
				{
				}

				// Token: 0x04011575 RID: 71029
				[Token(Token = "0x4011575")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_remainingTime;

				// Token: 0x04011576 RID: 71030
				[Token(Token = "0x4011576")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x04011577 RID: 71031
				[Token(Token = "0x4011577")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x04011578 RID: 71032
				[Token(Token = "0x4011578")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x04011579 RID: 71033
				[Token(Token = "0x4011579")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__OnLocate;

				// Token: 0x0401157A RID: 71034
				[Token(Token = "0x401157A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025AB RID: 9643
			[Token(Token = "0x20025AB")]
			private class IdleState : Character.States.BasicState
			{
				// Token: 0x0600F9AA RID: 63914 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9AA")]
				[Address(RVA = "0x735C70", Offset = "0x734870", VA = "0x180735C70", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600F9AB RID: 63915 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9AB")]
				[Address(RVA = "0x735D80", Offset = "0x734980", VA = "0x180735D80", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600F9AC RID: 63916 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9AC")]
				[Address(RVA = "0x735F10", Offset = "0x734B10", VA = "0x180735F10")]
				public IdleState()
				{
				}

				// Token: 0x0401157B RID: 71035
				[Token(Token = "0x401157B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x0401157C RID: 71036
				[Token(Token = "0x401157C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x0401157D RID: 71037
				[Token(Token = "0x401157D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025AC RID: 9644
			[Token(Token = "0x20025AC")]
			private class CombatState : Character.States.BasicState
			{
				// Token: 0x0600F9AD RID: 63917 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9AD")]
				[Address(RVA = "0x71C7F0", Offset = "0x71B3F0", VA = "0x18071C7F0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600F9AE RID: 63918 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9AE")]
				[Address(RVA = "0x71CB60", Offset = "0x71B760", VA = "0x18071CB60", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600F9AF RID: 63919 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9AF")]
				[Address(RVA = "0x71C990", Offset = "0x71B590", VA = "0x18071C990", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600F9B0 RID: 63920 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9B0")]
				[Address(RVA = "0x71CF80", Offset = "0x71BB80", VA = "0x18071CF80")]
				private void _NextCombatOrExit(bool firstAttack)
				{
				}

				// Token: 0x0600F9B1 RID: 63921 RVA: 0x0005DC00 File Offset: 0x0005BE00
				[Token(Token = "0x600F9B1")]
				[Address(RVA = "0x71D0A0", Offset = "0x71BCA0", VA = "0x18071D0A0")]
				private bool _StartAttack(Entity target, bool firstAttack)
				{
					return default(bool);
				}

				// Token: 0x0600F9B2 RID: 63922 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600F9B2")]
				[Address(RVA = "0x71CEF0", Offset = "0x71BAF0", VA = "0x18071CEF0")]
				private Enemy _GetTarget()
				{
					return null;
				}

				// Token: 0x0600F9B3 RID: 63923 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9B3")]
				[Address(RVA = "0x71D2D0", Offset = "0x71BED0", VA = "0x18071D2D0")]
				public CombatState()
				{
				}

				// Token: 0x0401157E RID: 71038
				[Token(Token = "0x401157E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_nextEscapeTime;

				// Token: 0x0401157F RID: 71039
				[Token(Token = "0x401157F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x04011580 RID: 71040
				[Token(Token = "0x4011580")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x04011581 RID: 71041
				[Token(Token = "0x4011581")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x04011582 RID: 71042
				[Token(Token = "0x4011582")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__NextCombatOrExit;

				// Token: 0x04011583 RID: 71043
				[Token(Token = "0x4011583")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0__StartAttack;

				// Token: 0x04011584 RID: 71044
				[Token(Token = "0x4011584")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0__GetTarget;

				// Token: 0x04011585 RID: 71045
				[Token(Token = "0x4011585")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025AD RID: 9645
			[Token(Token = "0x20025AD")]
			private class DeadState : Character.States.BasicState
			{
				// Token: 0x0600F9B5 RID: 63925 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9B5")]
				[Address(RVA = "0x71D420", Offset = "0x71C020", VA = "0x18071D420", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600F9B6 RID: 63926 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9B6")]
				[Address(RVA = "0x71D6A0", Offset = "0x71C2A0", VA = "0x18071D6A0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600F9B7 RID: 63927 RVA: 0x0005DC18 File Offset: 0x0005BE18
				[Token(Token = "0x600F9B7")]
				[Address(RVA = "0x71D3B0", Offset = "0x71BFB0", VA = "0x18071D3B0", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600F9B8 RID: 63928 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9B8")]
				[Address(RVA = "0x71D740", Offset = "0x71C340", VA = "0x18071D740")]
				private void _PlayAnimation()
				{
				}

				// Token: 0x0600F9B9 RID: 63929 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9B9")]
				[Address(RVA = "0x71DE60", Offset = "0x71CA60", VA = "0x18071DE60")]
				public DeadState()
				{
				}

				// Token: 0x04011586 RID: 71046
				[Token(Token = "0x4011586")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Tween m_tween;

				// Token: 0x04011587 RID: 71047
				[Token(Token = "0x4011587")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x04011588 RID: 71048
				[Token(Token = "0x4011588")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x04011589 RID: 71049
				[Token(Token = "0x4011589")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x0401158A RID: 71050
				[Token(Token = "0x401158A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__PlayAnimation;

				// Token: 0x0401158B RID: 71051
				[Token(Token = "0x401158B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025B0 RID: 9648
			[Token(Token = "0x20025B0")]
			private class DyingState : Character.States.BasicState
			{
				// Token: 0x0600F9C3 RID: 63939 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9C3")]
				[Address(RVA = "0x71F630", Offset = "0x71E230", VA = "0x18071F630", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600F9C4 RID: 63940 RVA: 0x0005DC78 File Offset: 0x0005BE78
				[Token(Token = "0x600F9C4")]
				[Address(RVA = "0x71F5C0", Offset = "0x71E1C0", VA = "0x18071F5C0", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600F9C5 RID: 63941 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9C5")]
				[Address(RVA = "0x71FC90", Offset = "0x71E890", VA = "0x18071FC90")]
				public DyingState()
				{
				}

				// Token: 0x04011593 RID: 71059
				[Token(Token = "0x4011593")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x04011594 RID: 71060
				[Token(Token = "0x4011594")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x04011595 RID: 71061
				[Token(Token = "0x4011595")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025B2 RID: 9650
			[Token(Token = "0x20025B2")]
			private class AttackState : Character.States.BasicState
			{
				// Token: 0x0600F9CA RID: 63946 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9CA")]
				[Address(RVA = "0x71A720", Offset = "0x719320", VA = "0x18071A720", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600F9CB RID: 63947 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9CB")]
				[Address(RVA = "0x71AAD0", Offset = "0x7196D0", VA = "0x18071AAD0", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600F9CC RID: 63948 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9CC")]
				[Address(RVA = "0x71A8D0", Offset = "0x7194D0", VA = "0x18071A8D0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600F9CD RID: 63949 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9CD")]
				[Address(RVA = "0x71B210", Offset = "0x719E10", VA = "0x18071B210")]
				private void _NextAttackOrExit()
				{
				}

				// Token: 0x0600F9CE RID: 63950 RVA: 0x0005DCA8 File Offset: 0x0005BEA8
				[Token(Token = "0x600F9CE")]
				[Address(RVA = "0x71B350", Offset = "0x719F50", VA = "0x18071B350")]
				private bool _StartAttack(bool firstAttack)
				{
					return default(bool);
				}

				// Token: 0x0600F9CF RID: 63951 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600F9CF")]
				[Address(RVA = "0x71B0C0", Offset = "0x719CC0", VA = "0x18071B0C0")]
				private Entity _GetTarget()
				{
					return null;
				}

				// Token: 0x0600F9D0 RID: 63952 RVA: 0x0005DCC0 File Offset: 0x0005BEC0
				[Token(Token = "0x600F9D0")]
				[Address(RVA = "0x71AF70", Offset = "0x719B70", VA = "0x18071AF70")]
				private bool _CheckSwitchToCombat()
				{
					return default(bool);
				}

				// Token: 0x0600F9D1 RID: 63953 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9D1")]
				[Address(RVA = "0x71B6E0", Offset = "0x71A2E0", VA = "0x18071B6E0")]
				public AttackState()
				{
				}

				// Token: 0x04011599 RID: 71065
				[Token(Token = "0x4011599")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_nextEscapeTime;

				// Token: 0x0401159A RID: 71066
				[Token(Token = "0x401159A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x0401159B RID: 71067
				[Token(Token = "0x401159B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x0401159C RID: 71068
				[Token(Token = "0x401159C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x0401159D RID: 71069
				[Token(Token = "0x401159D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__NextAttackOrExit;

				// Token: 0x0401159E RID: 71070
				[Token(Token = "0x401159E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0__StartAttack;

				// Token: 0x0401159F RID: 71071
				[Token(Token = "0x401159F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0__GetTarget;

				// Token: 0x040115A0 RID: 71072
				[Token(Token = "0x40115A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0__CheckSwitchToCombat;

				// Token: 0x040115A1 RID: 71073
				[Token(Token = "0x40115A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025B3 RID: 9651
			[Token(Token = "0x20025B3")]
			private class SkillState : Character.States.BasicState
			{
				// Token: 0x0600F9D3 RID: 63955 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9D3")]
				[Address(RVA = "0x7373E0", Offset = "0x735FE0", VA = "0x1807373E0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600F9D4 RID: 63956 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9D4")]
				[Address(RVA = "0x737660", Offset = "0x736260", VA = "0x180737660", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600F9D5 RID: 63957 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9D5")]
				[Address(RVA = "0x737560", Offset = "0x736160", VA = "0x180737560", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600F9D6 RID: 63958 RVA: 0x0005DCD8 File Offset: 0x0005BED8
				[Token(Token = "0x600F9D6")]
				[Address(RVA = "0x7379B0", Offset = "0x7365B0", VA = "0x1807379B0")]
				private bool _StartSkill()
				{
					return default(bool);
				}

				// Token: 0x0600F9D7 RID: 63959 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9D7")]
				[Address(RVA = "0x7378D0", Offset = "0x7364D0", VA = "0x1807378D0")]
				private void _DoStartSkill()
				{
				}

				// Token: 0x0600F9D8 RID: 63960 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9D8")]
				[Address(RVA = "0x737BA0", Offset = "0x7367A0", VA = "0x180737BA0")]
				public SkillState()
				{
				}

				// Token: 0x040115A2 RID: 71074
				[Token(Token = "0x40115A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_remainingEscapeTime;

				// Token: 0x040115A3 RID: 71075
				[Token(Token = "0x40115A3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040115A4 RID: 71076
				[Token(Token = "0x40115A4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040115A5 RID: 71077
				[Token(Token = "0x40115A5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040115A6 RID: 71078
				[Token(Token = "0x40115A6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__StartSkill;

				// Token: 0x040115A7 RID: 71079
				[Token(Token = "0x40115A7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0__DoStartSkill;

				// Token: 0x040115A8 RID: 71080
				[Token(Token = "0x40115A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025B5 RID: 9653
			[Token(Token = "0x20025B5")]
			private class StunState : Character.States.BasicState
			{
				// Token: 0x0600F9DB RID: 63963 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9DB")]
				[Address(RVA = "0x738A00", Offset = "0x737600", VA = "0x180738A00", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600F9DC RID: 63964 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9DC")]
				[Address(RVA = "0x738CA0", Offset = "0x7378A0", VA = "0x180738CA0", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600F9DD RID: 63965 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9DD")]
				[Address(RVA = "0x738BC0", Offset = "0x7377C0", VA = "0x180738BC0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600F9DE RID: 63966 RVA: 0x0005DCF0 File Offset: 0x0005BEF0
				[Token(Token = "0x600F9DE")]
				[Address(RVA = "0x738940", Offset = "0x737540", VA = "0x180738940", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600F9DF RID: 63967 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9DF")]
				[Address(RVA = "0x738D70", Offset = "0x737970", VA = "0x180738D70")]
				public StunState()
				{
				}

				// Token: 0x040115AC RID: 71084
				[Token(Token = "0x40115AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040115AD RID: 71085
				[Token(Token = "0x40115AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040115AE RID: 71086
				[Token(Token = "0x40115AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040115AF RID: 71087
				[Token(Token = "0x40115AF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x040115B0 RID: 71088
				[Token(Token = "0x40115B0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025B6 RID: 9654
			[Token(Token = "0x20025B6")]
			private class DisappearState : Character.States.BasicState
			{
				// Token: 0x0600F9E0 RID: 63968 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9E0")]
				[Address(RVA = "0x71EC50", Offset = "0x71D850", VA = "0x18071EC50", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600F9E1 RID: 63969 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9E1")]
				[Address(RVA = "0x71ED00", Offset = "0x71D900", VA = "0x18071ED00")]
				public DisappearState()
				{
				}

				// Token: 0x040115B1 RID: 71089
				[Token(Token = "0x40115B1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040115B2 RID: 71090
				[Token(Token = "0x40115B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025B7 RID: 9655
			[Token(Token = "0x20025B7")]
			private class DozeState : Character.States.BasicState, Attributes.IAttributesModifier
			{
				// Token: 0x170020FC RID: 8444
				// (get) Token: 0x0600F9E2 RID: 63970 RVA: 0x0005DD08 File Offset: 0x0005BF08
				[Token(Token = "0x170020FC")]
				public long attributeMask
				{
					[Token(Token = "0x600F9E2")]
					[Address(RVA = "0x71F560", Offset = "0x71E160", VA = "0x18071F560", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170020FD RID: 8445
				// (get) Token: 0x0600F9E3 RID: 63971 RVA: 0x0005DD20 File Offset: 0x0005BF20
				[Token(Token = "0x170020FD")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600F9E3")]
					[Address(RVA = "0x71F4A0", Offset = "0x71E0A0", VA = "0x18071F4A0", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170020FE RID: 8446
				// (get) Token: 0x0600F9E4 RID: 63972 RVA: 0x0005DD38 File Offset: 0x0005BF38
				[Token(Token = "0x170020FE")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600F9E4")]
					[Address(RVA = "0x71F500", Offset = "0x71E100", VA = "0x18071F500", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170020FF RID: 8447
				// (get) Token: 0x0600F9E5 RID: 63973 RVA: 0x0005DD50 File Offset: 0x0005BF50
				[Token(Token = "0x170020FF")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600F9E5")]
					[Address(RVA = "0x71F380", Offset = "0x71DF80", VA = "0x18071F380", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002100 RID: 8448
				// (get) Token: 0x0600F9E6 RID: 63974 RVA: 0x0005DD68 File Offset: 0x0005BF68
				[Token(Token = "0x17002100")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600F9E6")]
					[Address(RVA = "0x71F440", Offset = "0x71E040", VA = "0x18071F440", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002101 RID: 8449
				// (get) Token: 0x0600F9E7 RID: 63975 RVA: 0x0005DD80 File Offset: 0x0005BF80
				[Token(Token = "0x17002101")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600F9E7")]
					[Address(RVA = "0x71F3E0", Offset = "0x71DFE0", VA = "0x18071F3E0", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600F9E8 RID: 63976 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9E8")]
				[Address(RVA = "0x71EF50", Offset = "0x71DB50", VA = "0x18071EF50", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600F9E9 RID: 63977 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9E9")]
				[Address(RVA = "0x71F1E0", Offset = "0x71DDE0", VA = "0x18071F1E0", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600F9EA RID: 63978 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9EA")]
				[Address(RVA = "0x71F100", Offset = "0x71DD00", VA = "0x18071F100", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600F9EB RID: 63979 RVA: 0x0005DD98 File Offset: 0x0005BF98
				[Token(Token = "0x600F9EB")]
				[Address(RVA = "0x71EDB0", Offset = "0x71D9B0", VA = "0x18071EDB0", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600F9EC RID: 63980 RVA: 0x0005DDB0 File Offset: 0x0005BFB0
				[Token(Token = "0x600F9EC")]
				[Address(RVA = "0x71EE70", Offset = "0x71DA70", VA = "0x18071EE70", Slot = "20")]
				public bool GetValue(AttributeType attributeType, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600F9ED RID: 63981 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9ED")]
				[Address(RVA = "0x71F2D0", Offset = "0x71DED0", VA = "0x18071F2D0")]
				public DozeState()
				{
				}

				// Token: 0x040115B3 RID: 71091
				[Token(Token = "0x40115B3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private UnitAnimator.CurrentAniState animatorState;

				// Token: 0x040115B4 RID: 71092
				[Token(Token = "0x40115B4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x040115B5 RID: 71093
				[Token(Token = "0x40115B5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x040115B6 RID: 71094
				[Token(Token = "0x40115B6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x040115B7 RID: 71095
				[Token(Token = "0x40115B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x040115B8 RID: 71096
				[Token(Token = "0x40115B8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x040115B9 RID: 71097
				[Token(Token = "0x40115B9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x040115BA RID: 71098
				[Token(Token = "0x40115BA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040115BB RID: 71099
				[Token(Token = "0x40115BB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040115BC RID: 71100
				[Token(Token = "0x40115BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040115BD RID: 71101
				[Token(Token = "0x40115BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x040115BE RID: 71102
				[Token(Token = "0x40115BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x040115BF RID: 71103
				[Token(Token = "0x40115BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025B8 RID: 9656
			[Token(Token = "0x20025B8")]
			private class FreezeState : Character.States.BasicState, Attributes.IAttributesModifier
			{
				// Token: 0x17002102 RID: 8450
				// (get) Token: 0x0600F9EE RID: 63982 RVA: 0x0005DDC8 File Offset: 0x0005BFC8
				[Token(Token = "0x17002102")]
				public long attributeMask
				{
					[Token(Token = "0x600F9EE")]
					[Address(RVA = "0x735C10", Offset = "0x734810", VA = "0x180735C10", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002103 RID: 8451
				// (get) Token: 0x0600F9EF RID: 63983 RVA: 0x0005DDE0 File Offset: 0x0005BFE0
				[Token(Token = "0x17002103")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600F9EF")]
					[Address(RVA = "0x735B50", Offset = "0x734750", VA = "0x180735B50", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002104 RID: 8452
				// (get) Token: 0x0600F9F0 RID: 63984 RVA: 0x0005DDF8 File Offset: 0x0005BFF8
				[Token(Token = "0x17002104")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600F9F0")]
					[Address(RVA = "0x735BB0", Offset = "0x7347B0", VA = "0x180735BB0", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002105 RID: 8453
				// (get) Token: 0x0600F9F1 RID: 63985 RVA: 0x0005DE10 File Offset: 0x0005C010
				[Token(Token = "0x17002105")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600F9F1")]
					[Address(RVA = "0x735A30", Offset = "0x734630", VA = "0x180735A30", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002106 RID: 8454
				// (get) Token: 0x0600F9F2 RID: 63986 RVA: 0x0005DE28 File Offset: 0x0005C028
				[Token(Token = "0x17002106")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600F9F2")]
					[Address(RVA = "0x735AF0", Offset = "0x7346F0", VA = "0x180735AF0", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002107 RID: 8455
				// (get) Token: 0x0600F9F3 RID: 63987 RVA: 0x0005DE40 File Offset: 0x0005C040
				[Token(Token = "0x17002107")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600F9F3")]
					[Address(RVA = "0x735A90", Offset = "0x734690", VA = "0x180735A90", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600F9F4 RID: 63988 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9F4")]
				[Address(RVA = "0x7354E0", Offset = "0x7340E0", VA = "0x1807354E0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600F9F5 RID: 63989 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9F5")]
				[Address(RVA = "0x735890", Offset = "0x734490", VA = "0x180735890", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600F9F6 RID: 63990 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9F6")]
				[Address(RVA = "0x735700", Offset = "0x734300", VA = "0x180735700", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600F9F7 RID: 63991 RVA: 0x0005DE58 File Offset: 0x0005C058
				[Token(Token = "0x600F9F7")]
				[Address(RVA = "0x735340", Offset = "0x733F40", VA = "0x180735340", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600F9F8 RID: 63992 RVA: 0x0005DE70 File Offset: 0x0005C070
				[Token(Token = "0x600F9F8")]
				[Address(RVA = "0x735400", Offset = "0x734000", VA = "0x180735400", Slot = "20")]
				public bool GetValue(AttributeType attributeType, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600F9F9 RID: 63993 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F9F9")]
				[Address(RVA = "0x735980", Offset = "0x734580", VA = "0x180735980")]
				public FreezeState()
				{
				}

				// Token: 0x040115C0 RID: 71104
				[Token(Token = "0x40115C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private UnitAnimator.CurrentAniState animatorState;

				// Token: 0x040115C1 RID: 71105
				[Token(Token = "0x40115C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x040115C2 RID: 71106
				[Token(Token = "0x40115C2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x040115C3 RID: 71107
				[Token(Token = "0x40115C3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x040115C4 RID: 71108
				[Token(Token = "0x40115C4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x040115C5 RID: 71109
				[Token(Token = "0x40115C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x040115C6 RID: 71110
				[Token(Token = "0x40115C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x040115C7 RID: 71111
				[Token(Token = "0x40115C7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040115C8 RID: 71112
				[Token(Token = "0x40115C8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040115C9 RID: 71113
				[Token(Token = "0x40115C9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040115CA RID: 71114
				[Token(Token = "0x40115CA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x040115CB RID: 71115
				[Token(Token = "0x40115CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x040115CC RID: 71116
				[Token(Token = "0x40115CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025B9 RID: 9657
			[Token(Token = "0x20025B9")]
			private class RebornState : Character.States.BasicState, Attributes.IAttributesModifier
			{
				// Token: 0x17002108 RID: 8456
				// (get) Token: 0x0600F9FA RID: 63994 RVA: 0x0005DE88 File Offset: 0x0005C088
				[Token(Token = "0x17002108")]
				public long attributeMask
				{
					[Token(Token = "0x600F9FA")]
					[Address(RVA = "0x737380", Offset = "0x735F80", VA = "0x180737380", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002109 RID: 8457
				// (get) Token: 0x0600F9FB RID: 63995 RVA: 0x0005DEA0 File Offset: 0x0005C0A0
				[Token(Token = "0x17002109")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600F9FB")]
					[Address(RVA = "0x7372C0", Offset = "0x735EC0", VA = "0x1807372C0", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700210A RID: 8458
				// (get) Token: 0x0600F9FC RID: 63996 RVA: 0x0005DEB8 File Offset: 0x0005C0B8
				[Token(Token = "0x1700210A")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600F9FC")]
					[Address(RVA = "0x737320", Offset = "0x735F20", VA = "0x180737320", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700210B RID: 8459
				// (get) Token: 0x0600F9FD RID: 63997 RVA: 0x0005DED0 File Offset: 0x0005C0D0
				[Token(Token = "0x1700210B")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600F9FD")]
					[Address(RVA = "0x7371A0", Offset = "0x735DA0", VA = "0x1807371A0", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700210C RID: 8460
				// (get) Token: 0x0600F9FE RID: 63998 RVA: 0x0005DEE8 File Offset: 0x0005C0E8
				[Token(Token = "0x1700210C")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600F9FE")]
					[Address(RVA = "0x737260", Offset = "0x735E60", VA = "0x180737260", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700210D RID: 8461
				// (get) Token: 0x0600F9FF RID: 63999 RVA: 0x0005DF00 File Offset: 0x0005C100
				[Token(Token = "0x1700210D")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600F9FF")]
					[Address(RVA = "0x737200", Offset = "0x735E00", VA = "0x180737200", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600FA00 RID: 64000 RVA: 0x0005DF18 File Offset: 0x0005C118
				[Token(Token = "0x600FA00")]
				[Address(RVA = "0x7360B0", Offset = "0x734CB0", VA = "0x1807360B0", Slot = "20")]
				public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600FA01 RID: 64001 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FA01")]
				[Address(RVA = "0x736190", Offset = "0x734D90", VA = "0x180736190", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FA02 RID: 64002 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FA02")]
				[Address(RVA = "0x7367A0", Offset = "0x7353A0", VA = "0x1807367A0", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FA03 RID: 64003 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FA03")]
				[Address(RVA = "0x7365F0", Offset = "0x7351F0", VA = "0x1807365F0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FA04 RID: 64004 RVA: 0x0005DF30 File Offset: 0x0005C130
				[Token(Token = "0x600FA04")]
				[Address(RVA = "0x735FC0", Offset = "0x734BC0", VA = "0x180735FC0", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600FA05 RID: 64005 RVA: 0x0005DF48 File Offset: 0x0005C148
				[Token(Token = "0x600FA05")]
				[Address(RVA = "0x736B60", Offset = "0x735760", VA = "0x180736B60")]
				private float _PlayAnimation()
				{
					return 0f;
				}

				// Token: 0x0600FA06 RID: 64006 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FA06")]
				[Address(RVA = "0x7370F0", Offset = "0x735CF0", VA = "0x1807370F0")]
				public RebornState()
				{
				}

				// Token: 0x040115CD RID: 71117
				[Token(Token = "0x40115CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_remainingTime;

				// Token: 0x040115CE RID: 71118
				[Token(Token = "0x40115CE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Unit.RebornData m_data;

				// Token: 0x040115CF RID: 71119
				[Token(Token = "0x40115CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private ITweenHandler m_tween;

				// Token: 0x040115D0 RID: 71120
				[Token(Token = "0x40115D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private List<Effect> m_effectList;

				// Token: 0x040115D1 RID: 71121
				[Token(Token = "0x40115D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x040115D2 RID: 71122
				[Token(Token = "0x40115D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x040115D3 RID: 71123
				[Token(Token = "0x40115D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x040115D4 RID: 71124
				[Token(Token = "0x40115D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x040115D5 RID: 71125
				[Token(Token = "0x40115D5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x040115D6 RID: 71126
				[Token(Token = "0x40115D6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x040115D7 RID: 71127
				[Token(Token = "0x40115D7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x040115D8 RID: 71128
				[Token(Token = "0x40115D8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040115D9 RID: 71129
				[Token(Token = "0x40115D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040115DA RID: 71130
				[Token(Token = "0x40115DA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040115DB RID: 71131
				[Token(Token = "0x40115DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x040115DC RID: 71132
				[Token(Token = "0x40115DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0__PlayAnimation;

				// Token: 0x040115DD RID: 71133
				[Token(Token = "0x40115DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025BB RID: 9659
			[Token(Token = "0x20025BB")]
			private class DialogState : Character.States.BasicState, Attributes.IAttributesModifier
			{
				// Token: 0x1700210E RID: 8462
				// (get) Token: 0x0600FA0C RID: 64012 RVA: 0x0005DF78 File Offset: 0x0005C178
				[Token(Token = "0x1700210E")]
				public long attributeMask
				{
					[Token(Token = "0x600FA0C")]
					[Address(RVA = "0x71EBF0", Offset = "0x71D7F0", VA = "0x18071EBF0", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700210F RID: 8463
				// (get) Token: 0x0600FA0D RID: 64013 RVA: 0x0005DF90 File Offset: 0x0005C190
				[Token(Token = "0x1700210F")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600FA0D")]
					[Address(RVA = "0x71EB30", Offset = "0x71D730", VA = "0x18071EB30", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002110 RID: 8464
				// (get) Token: 0x0600FA0E RID: 64014 RVA: 0x0005DFA8 File Offset: 0x0005C1A8
				[Token(Token = "0x17002110")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600FA0E")]
					[Address(RVA = "0x71EB90", Offset = "0x71D790", VA = "0x18071EB90", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002111 RID: 8465
				// (get) Token: 0x0600FA0F RID: 64015 RVA: 0x0005DFC0 File Offset: 0x0005C1C0
				[Token(Token = "0x17002111")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600FA0F")]
					[Address(RVA = "0x71EA10", Offset = "0x71D610", VA = "0x18071EA10", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002112 RID: 8466
				// (get) Token: 0x0600FA10 RID: 64016 RVA: 0x0005DFD8 File Offset: 0x0005C1D8
				[Token(Token = "0x17002112")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600FA10")]
					[Address(RVA = "0x71EAD0", Offset = "0x71D6D0", VA = "0x18071EAD0", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002113 RID: 8467
				// (get) Token: 0x0600FA11 RID: 64017 RVA: 0x0005DFF0 File Offset: 0x0005C1F0
				[Token(Token = "0x17002113")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600FA11")]
					[Address(RVA = "0x71EA70", Offset = "0x71D670", VA = "0x18071EA70", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600FA12 RID: 64018 RVA: 0x0005E008 File Offset: 0x0005C208
				[Token(Token = "0x600FA12")]
				[Address(RVA = "0x71DF10", Offset = "0x71CB10", VA = "0x18071DF10", Slot = "20")]
				public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600FA13 RID: 64019 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FA13")]
				[Address(RVA = "0x71DFF0", Offset = "0x71CBF0", VA = "0x18071DFF0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FA14 RID: 64020 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FA14")]
				[Address(RVA = "0x71E370", Offset = "0x71CF70", VA = "0x18071E370", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FA15 RID: 64021 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FA15")]
				[Address(RVA = "0x71E200", Offset = "0x71CE00", VA = "0x18071E200", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FA16 RID: 64022 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FA16")]
				[Address(RVA = "0x71E580", Offset = "0x71D180", VA = "0x18071E580")]
				private void _PlayAnim(object param)
				{
				}

				// Token: 0x0600FA17 RID: 64023 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FA17")]
				[Address(RVA = "0x71E930", Offset = "0x71D530", VA = "0x18071E930")]
				public DialogState()
				{
				}

				// Token: 0x040115E0 RID: 71136
				[Token(Token = "0x40115E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_remainingEscapeTime;

				// Token: 0x040115E1 RID: 71137
				[Token(Token = "0x40115E1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Entity.AnimBundle m_lastPlayedBundle;

				// Token: 0x040115E2 RID: 71138
				[Token(Token = "0x40115E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x040115E3 RID: 71139
				[Token(Token = "0x40115E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x040115E4 RID: 71140
				[Token(Token = "0x40115E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x040115E5 RID: 71141
				[Token(Token = "0x40115E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x040115E6 RID: 71142
				[Token(Token = "0x40115E6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x040115E7 RID: 71143
				[Token(Token = "0x40115E7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x040115E8 RID: 71144
				[Token(Token = "0x40115E8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x040115E9 RID: 71145
				[Token(Token = "0x40115E9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040115EA RID: 71146
				[Token(Token = "0x40115EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040115EB RID: 71147
				[Token(Token = "0x40115EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040115EC RID: 71148
				[Token(Token = "0x40115EC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0__PlayAnim;

				// Token: 0x040115ED RID: 71149
				[Token(Token = "0x40115ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x020025BC RID: 9660
		[Token(Token = "0x20025BC")]
		public interface IReplacement
		{
			// Token: 0x17002114 RID: 8468
			// (get) Token: 0x0600FA18 RID: 64024
			[Token(Token = "0x17002114")]
			Ability ability { [Token(Token = "0x600FA18")] get; }

			// Token: 0x17002115 RID: 8469
			// (get) Token: 0x0600FA19 RID: 64025
			[Token(Token = "0x17002115")]
			TargetTrigger trigger { [Token(Token = "0x600FA19")] get; }

			// Token: 0x0600FA1A RID: 64026
			[Token(Token = "0x600FA1A")]
			bool TryHookSearchTarget(out bool isFound);
		}

		// Token: 0x020025BD RID: 9661
		[Token(Token = "0x20025BD")]
		private class BlockedEnemyManager
		{
			// Token: 0x17002116 RID: 8470
			// (get) Token: 0x0600FA1B RID: 64027 RVA: 0x0005E020 File Offset: 0x0005C220
			[Token(Token = "0x17002116")]
			public int count
			{
				[Token(Token = "0x600FA1B")]
				[Address(RVA = "0x71C080", Offset = "0x71AC80", VA = "0x18071C080")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002117 RID: 8471
			// (get) Token: 0x0600FA1C RID: 64028 RVA: 0x0005E038 File Offset: 0x0005C238
			[Token(Token = "0x17002117")]
			public int totalVolume
			{
				[Token(Token = "0x600FA1C")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002118 RID: 8472
			// (get) Token: 0x0600FA1D RID: 64029 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002118")]
			public List<Enemy> exposedRawList
			{
				[Token(Token = "0x600FA1D")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002119 RID: 8473
			[Token(Token = "0x17002119")]
			public Enemy this[int index]
			{
				[Token(Token = "0x600FA1E")]
				[Address(RVA = "0x71C020", Offset = "0x71AC20", VA = "0x18071C020")]
				get
				{
					return null;
				}
				[Token(Token = "0x600FA1F")]
				[Address(RVA = "0x71C0C0", Offset = "0x71ACC0", VA = "0x18071C0C0")]
				set
				{
				}
			}

			// Token: 0x0600FA20 RID: 64032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FA20")]
			[Address(RVA = "0x71BB10", Offset = "0x71A710", VA = "0x18071BB10")]
			public void Add(Enemy enemy)
			{
			}

			// Token: 0x0600FA21 RID: 64033 RVA: 0x0005E050 File Offset: 0x0005C250
			[Token(Token = "0x600FA21")]
			[Address(RVA = "0x71BE50", Offset = "0x71AA50", VA = "0x18071BE50")]
			public bool Remove(Enemy enemy)
			{
				return default(bool);
			}

			// Token: 0x0600FA22 RID: 64034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FA22")]
			[Address(RVA = "0x71BBD0", Offset = "0x71A7D0", VA = "0x18071BBD0")]
			public void Clear()
			{
			}

			// Token: 0x0600FA23 RID: 64035 RVA: 0x0005E068 File Offset: 0x0005C268
			[Token(Token = "0x600FA23")]
			[Address(RVA = "0x71BC40", Offset = "0x71A840", VA = "0x18071BC40")]
			public bool Contains(Enemy enemy)
			{
				return default(bool);
			}

			// Token: 0x0600FA24 RID: 64036 RVA: 0x0005E080 File Offset: 0x0005C280
			[Token(Token = "0x600FA24")]
			[Address(RVA = "0x71BCA0", Offset = "0x71A8A0", VA = "0x18071BCA0")]
			public int GetRemainingVolume(int maxVolume)
			{
				return 0;
			}

			// Token: 0x0600FA25 RID: 64037 RVA: 0x0005E098 File Offset: 0x0005C298
			[Token(Token = "0x600FA25")]
			[Address(RVA = "0x71BB90", Offset = "0x71A790", VA = "0x18071BB90")]
			public bool CheckVolumeNotExceeded(Enemy enemy, int maxVolume)
			{
				return default(bool);
			}

			// Token: 0x0600FA26 RID: 64038 RVA: 0x0005E0B0 File Offset: 0x0005C2B0
			[Token(Token = "0x600FA26")]
			[Address(RVA = "0x71BEE0", Offset = "0x71AAE0", VA = "0x18071BEE0")]
			public bool TryPickOneToRemoveIfVolumeExceeded(int newMaxVolume, out Enemy candidate)
			{
				return default(bool);
			}

			// Token: 0x0600FA27 RID: 64039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FA27")]
			[Address(RVA = "0x71BCB0", Offset = "0x71A8B0", VA = "0x18071BCB0")]
			public void RecalculateVolume()
			{
			}

			// Token: 0x0600FA28 RID: 64040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FA28")]
			[Address(RVA = "0x71BF90", Offset = "0x71AB90", VA = "0x18071BF90")]
			public BlockedEnemyManager()
			{
			}

			// Token: 0x040115EE RID: 71150
			[Token(Token = "0x40115EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_totalVolume;

			// Token: 0x040115EF RID: 71151
			[Token(Token = "0x40115EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<Enemy> m_blockedEnemies;
		}

		// Token: 0x020025BE RID: 9662
		[Token(Token = "0x20025BE")]
		public struct BuildParam
		{
			// Token: 0x040115F0 RID: 71152
			[Token(Token = "0x40115F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BattleCharacterData data;

			// Token: 0x040115F1 RID: 71153
			[Token(Token = "0x40115F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Tile tile;

			// Token: 0x040115F2 RID: 71154
			[Token(Token = "0x40115F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SharedConsts.Direction direction;

			// Token: 0x040115F3 RID: 71155
			[Token(Token = "0x40115F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int cost;

			// Token: 0x040115F4 RID: 71156
			[Token(Token = "0x40115F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SideType sideType;

			// Token: 0x040115F5 RID: 71157
			[Token(Token = "0x40115F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IList<DeckBuff> deckBuffs;

			// Token: 0x040115F6 RID: 71158
			[Token(Token = "0x40115F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IList<Torappu.Blackboard> deckBlackboards;

			// Token: 0x040115F7 RID: 71159
			[Token(Token = "0x40115F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlayerSide playerSide;

			// Token: 0x040115F8 RID: 71160
			[Token(Token = "0x40115F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool dontOccupyDeployCnt;

			// Token: 0x040115F9 RID: 71161
			[Token(Token = "0x40115F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AdditionalBuildCondition additionalBuildCondition;

			// Token: 0x040115FA RID: 71162
			[Token(Token = "0x40115FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Deck.Card.AdvancedCardBuildState advancedBuildState;
		}
	}
}
