using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025EF RID: 9711
	[Token(Token = "0x20025EF")]
	[SelectionBase]
	public class EnemyGiantBoss : Enemy, IUseGiantBossInfoPanel, IPtrObject
	{
		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x0600FCB4 RID: 64692 RVA: 0x0005F700 File Offset: 0x0005D900
		[Token(Token = "0x170021E8")]
		private bool delayToAppear
		{
			[Token(Token = "0x600FCB4")]
			[Address(RVA = "0x743020", Offset = "0x741C20", VA = "0x180743020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x0600FCB5 RID: 64693 RVA: 0x0005F718 File Offset: 0x0005D918
		[Token(Token = "0x170021E9")]
		private bool inDelayAppear
		{
			[Token(Token = "0x600FCB5")]
			[Address(RVA = "0x743410", Offset = "0x742010", VA = "0x180743410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x0600FCB6 RID: 64694 RVA: 0x0005F730 File Offset: 0x0005D930
		[Token(Token = "0x170021EA")]
		public override bool isGiantBoss
		{
			[Token(Token = "0x600FCB6")]
			[Address(RVA = "0x7434A0", Offset = "0x7420A0", VA = "0x1807434A0", Slot = "199")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x0600FCB7 RID: 64695 RVA: 0x0005F748 File Offset: 0x0005D948
		[Token(Token = "0x170021EB")]
		public override FP maxEs
		{
			[Token(Token = "0x600FCB7")]
			[Address(RVA = "0x7437F0", Offset = "0x7423F0", VA = "0x1807437F0", Slot = "79")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x0600FCB8 RID: 64696 RVA: 0x0005F760 File Offset: 0x0005D960
		[Token(Token = "0x170021EC")]
		public override bool alive
		{
			[Token(Token = "0x600FCB8")]
			[Address(RVA = "0x742D50", Offset = "0x741950", VA = "0x180742D50", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x0600FCB9 RID: 64697 RVA: 0x0005F778 File Offset: 0x0005D978
		[Token(Token = "0x170021ED")]
		public Vector2 bossHudOffset
		{
			[Token(Token = "0x600FCB9")]
			[Address(RVA = "0x742F30", Offset = "0x741B30", VA = "0x180742F30", Slot = "222")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x0600FCBA RID: 64698 RVA: 0x0005F790 File Offset: 0x0005D990
		[Token(Token = "0x170021EE")]
		public Vector3 bossHudScale
		{
			[Token(Token = "0x600FCBA")]
			[Address(RVA = "0x742FA0", Offset = "0x741BA0", VA = "0x180742FA0", Slot = "223")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x0600FCBB RID: 64699 RVA: 0x0005F7A8 File Offset: 0x0005D9A8
		[Token(Token = "0x170021EF")]
		public Vector2 bossAvatarOffset
		{
			[Token(Token = "0x600FCBB")]
			[Address(RVA = "0x742E50", Offset = "0x741A50", VA = "0x180742E50", Slot = "224")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x0600FCBC RID: 64700 RVA: 0x0005F7C0 File Offset: 0x0005D9C0
		[Token(Token = "0x170021F0")]
		public Vector2 bossAvatarSize
		{
			[Token(Token = "0x600FCBC")]
			[Address(RVA = "0x742EC0", Offset = "0x741AC0", VA = "0x180742EC0", Slot = "225")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x0600FCBD RID: 64701 RVA: 0x0005F7D8 File Offset: 0x0005D9D8
		[Token(Token = "0x170021F1")]
		public bool hideAvatarBackground
		{
			[Token(Token = "0x600FCBD")]
			[Address(RVA = "0x743290", Offset = "0x741E90", VA = "0x180743290", Slot = "226")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x0600FCBE RID: 64702 RVA: 0x0005F7F0 File Offset: 0x0005D9F0
		[Token(Token = "0x170021F2")]
		public bool enableSpSliderWarning
		{
			[Token(Token = "0x600FCBE")]
			[Address(RVA = "0x7430B0", Offset = "0x741CB0", VA = "0x1807430B0", Slot = "227")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x0600FCBF RID: 64703 RVA: 0x0005F808 File Offset: 0x0005DA08
		[Token(Token = "0x170021F3")]
		public bool lockHudPosition
		{
			[Token(Token = "0x600FCBF")]
			[Address(RVA = "0x743730", Offset = "0x742330", VA = "0x180743730", Slot = "228")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x0600FCC0 RID: 64704 RVA: 0x0005F820 File Offset: 0x0005DA20
		[Token(Token = "0x170021F4")]
		public float hudDelayToAppear
		{
			[Token(Token = "0x600FCC0")]
			[Address(RVA = "0x7433B0", Offset = "0x741FB0", VA = "0x1807433B0", Slot = "229")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x0600FCC1 RID: 64705 RVA: 0x0005F838 File Offset: 0x0005DA38
		[Token(Token = "0x170021F5")]
		public bool hideHpSlider
		{
			[Token(Token = "0x600FCC1")]
			[Address(RVA = "0x7432F0", Offset = "0x741EF0", VA = "0x1807432F0", Slot = "230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x0600FCC2 RID: 64706 RVA: 0x0005F850 File Offset: 0x0005DA50
		[Token(Token = "0x170021F6")]
		public bool hideSpSlider
		{
			[Token(Token = "0x600FCC2")]
			[Address(RVA = "0x743350", Offset = "0x741F50", VA = "0x180743350", Slot = "231")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x0600FCC3 RID: 64707 RVA: 0x0005F868 File Offset: 0x0005DA68
		[Token(Token = "0x170021F7")]
		public BattleUIConst.GiantBossInfoType giantBossInfoType
		{
			[Token(Token = "0x600FCC3")]
			[Address(RVA = "0x743230", Offset = "0x741E30", VA = "0x180743230", Slot = "232")]
			get
			{
				return BattleUIConst.GiantBossInfoType.DEFAULT;
			}
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x0600FCC4 RID: 64708 RVA: 0x0005F880 File Offset: 0x0005DA80
		[Token(Token = "0x170021F8")]
		public bool isSkillAffecting
		{
			[Token(Token = "0x600FCC4")]
			[Address(RVA = "0x743560", Offset = "0x742160", VA = "0x180743560", Slot = "244")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x0600FCC5 RID: 64709 RVA: 0x0005F898 File Offset: 0x0005DA98
		[Token(Token = "0x170021F9")]
		public bool isSpCostSkill
		{
			[Token(Token = "0x600FCC5")]
			[Address(RVA = "0x743660", Offset = "0x742260", VA = "0x180743660", Slot = "245")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x0600FCC6 RID: 64710 RVA: 0x0005F8B0 File Offset: 0x0005DAB0
		[Token(Token = "0x170021FA")]
		public FP skillRemainingProgress
		{
			[Token(Token = "0x600FCC6")]
			[Address(RVA = "0x7438B0", Offset = "0x7424B0", VA = "0x1807438B0", Slot = "243")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x0600FCC7 RID: 64711 RVA: 0x0005F8C8 File Offset: 0x0005DAC8
		[Token(Token = "0x170021FB")]
		public new bool epIsFull
		{
			[Token(Token = "0x600FCC7")]
			[Address(RVA = "0x7431D0", Offset = "0x741DD0", VA = "0x1807431D0", Slot = "246")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x0600FCC8 RID: 64712 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
		[Token(Token = "0x170021FC")]
		public new ElementType minEpTypeToShow
		{
			[Token(Token = "0x600FCC8")]
			[Address(RVA = "0x743850", Offset = "0x742450", VA = "0x180743850", Slot = "247")]
			get
			{
				return ElementType.NONE;
			}
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x0600FCC9 RID: 64713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170021FD")]
		public new FP[] epArrayToShow
		{
			[Token(Token = "0x600FCC9")]
			[Address(RVA = "0x743110", Offset = "0x741D10", VA = "0x180743110", Slot = "248")]
			get
			{
				return null;
			}
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x0600FCCA RID: 64714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170021FE")]
		public new Entity.EPController epController
		{
			[Token(Token = "0x600FCCA")]
			[Address(RVA = "0x743170", Offset = "0x741D70", VA = "0x180743170", Slot = "249")]
			get
			{
				return null;
			}
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x0600FCCB RID: 64715 RVA: 0x0005F8F8 File Offset: 0x0005DAF8
		[Token(Token = "0x170021FF")]
		public new FP maxEp
		{
			[Token(Token = "0x600FCCB")]
			[Address(RVA = "0x743790", Offset = "0x742390", VA = "0x180743790", Slot = "250")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x0600FCCC RID: 64716 RVA: 0x0005F910 File Offset: 0x0005DB10
		[Token(Token = "0x17002200")]
		public new bool isInEpBreakRecovery
		{
			[Token(Token = "0x600FCCC")]
			[Address(RVA = "0x743500", Offset = "0x742100", VA = "0x180743500", Slot = "251")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x0600FCCD RID: 64717 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FCCE RID: 64718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002201")]
		public Action<Unit> actionOnTakeDamage
		{
			[Token(Token = "0x600FCCD")]
			[Address(RVA = "0x742CF0", Offset = "0x7418F0", VA = "0x180742CF0", Slot = "235")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600FCCE")]
			[Address(RVA = "0x743970", Offset = "0x742570", VA = "0x180743970", Slot = "236")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600FCCF RID: 64719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCCF")]
		[Address(RVA = "0x741F30", Offset = "0x740B30", VA = "0x180741F30", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600FCD0 RID: 64720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCD0")]
		[Address(RVA = "0x742100", Offset = "0x740D00", VA = "0x180742100", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600FCD1 RID: 64721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCD1")]
		[Address(RVA = "0x741CB0", Offset = "0x7408B0", VA = "0x180741CB0", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600FCD2 RID: 64722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCD2")]
		[Address(RVA = "0x741E10", Offset = "0x740A10", VA = "0x180741E10", Slot = "119")]
		protected override void OnFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600FCD3 RID: 64723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCD3")]
		[Address(RVA = "0x742980", Offset = "0x741580", VA = "0x180742980")]
		private void _OnOtherUnitDestroyed(object arg)
		{
		}

		// Token: 0x0600FCD4 RID: 64724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCD4")]
		[Address(RVA = "0x742290", Offset = "0x740E90", VA = "0x180742290", Slot = "27")]
		public override void OnTick(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600FCD5 RID: 64725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCD5")]
		[Address(RVA = "0x742890", Offset = "0x741490", VA = "0x180742890")]
		private void _DoDelayAppear()
		{
		}

		// Token: 0x0600FCD6 RID: 64726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCD6")]
		[Address(RVA = "0x742190", Offset = "0x740D90", VA = "0x180742190", Slot = "127")]
		protected override void OnTakeDamage(ref Modifier modifier, bool force)
		{
		}

		// Token: 0x0600FCD7 RID: 64727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCD7")]
		[Address(RVA = "0x741BF0", Offset = "0x7407F0", VA = "0x180741BF0", Slot = "172")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600FCD8 RID: 64728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCD8")]
		[Address(RVA = "0x7424E0", Offset = "0x7410E0", VA = "0x1807424E0")]
		private void _DoBorn()
		{
		}

		// Token: 0x0600FCD9 RID: 64729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCD9")]
		[Address(RVA = "0x742AC0", Offset = "0x7416C0", VA = "0x180742AC0")]
		public EnemyGiantBoss()
		{
		}

		// Token: 0x0600FCDA RID: 64730 RVA: 0x0005F928 File Offset: 0x0005DB28
		[Token(Token = "0x600FCDA")]
		[Address(RVA = "0x7424D0", Offset = "0x7410D0", VA = "0x1807424D0")]
		private bool <>xLuaBaseProxy_get_isGiantBoss()
		{
			return default(bool);
		}

		// Token: 0x0600FCDB RID: 64731 RVA: 0x0005F940 File Offset: 0x0005DB40
		[Token(Token = "0x600FCDB")]
		[Address(RVA = "0x6FEC40", Offset = "0x6FD840", VA = "0x1806FEC40")]
		private FP <>xLuaBaseProxy_get_maxEs()
		{
			return default(FP);
		}

		// Token: 0x0600FCDC RID: 64732 RVA: 0x0005F958 File Offset: 0x0005DB58
		[Token(Token = "0x600FCDC")]
		[Address(RVA = "0x6FEB60", Offset = "0x6FD760", VA = "0x1806FEB60")]
		private bool <>xLuaBaseProxy_get_alive()
		{
			return default(bool);
		}

		// Token: 0x0600FCDD RID: 64733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCDD")]
		[Address(RVA = "0x6F2E00", Offset = "0x6F1A00", VA = "0x1806F2E00")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600FCDE RID: 64734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCDE")]
		[Address(RVA = "0x6099C0", Offset = "0x6085C0", VA = "0x1806099C0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600FCDF RID: 64735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCDF")]
		[Address(RVA = "0x6099B0", Offset = "0x6085B0", VA = "0x1806099B0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600FCE0 RID: 64736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCE0")]
		[Address(RVA = "0x6F0040", Offset = "0x6EEC40", VA = "0x1806F0040")]
		private void <>xLuaBaseProxy_OnFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600FCE1 RID: 64737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCE1")]
		[Address(RVA = "0x6099E0", Offset = "0x6085E0", VA = "0x1806099E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600FCE2 RID: 64738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCE2")]
		[Address(RVA = "0x6F2140", Offset = "0x6F0D40", VA = "0x1806F2140")]
		private void <>xLuaBaseProxy_OnTakeDamage(ref Modifier P0, bool P1)
		{
		}

		// Token: 0x0600FCE3 RID: 64739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCE3")]
		[Address(RVA = "0x7424C0", Offset = "0x7410C0", VA = "0x1807424C0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x040118CC RID: 71884
		[Token(Token = "0x40118CC")]
		[FieldOffset(Offset = "0x528")]
		[SerializeField]
		private float _delayToAppear;

		// Token: 0x040118CD RID: 71885
		[Token(Token = "0x40118CD")]
		[FieldOffset(Offset = "0x530")]
		[SerializeField]
		private string _locateTileEffectKey;

		// Token: 0x040118CE RID: 71886
		[Token(Token = "0x40118CE")]
		[FieldOffset(Offset = "0x538")]
		[SerializeField]
		private AdvancedCharacterInst _tokenToSpawn;

		// Token: 0x040118CF RID: 71887
		[Token(Token = "0x40118CF")]
		[FieldOffset(Offset = "0x540")]
		[SerializeField]
		private bool _lockHudPosition;

		// Token: 0x040118D0 RID: 71888
		[Token(Token = "0x40118D0")]
		[FieldOffset(Offset = "0x544")]
		[SerializeField]
		private Vector2 _bossHudOffset;

		// Token: 0x040118D1 RID: 71889
		[Token(Token = "0x40118D1")]
		[FieldOffset(Offset = "0x54C")]
		[SerializeField]
		private Vector3 _bossHudScale;

		// Token: 0x040118D2 RID: 71890
		[Token(Token = "0x40118D2")]
		[FieldOffset(Offset = "0x558")]
		[SerializeField]
		private Vector2 _bossAvatarOffset;

		// Token: 0x040118D3 RID: 71891
		[Token(Token = "0x40118D3")]
		[FieldOffset(Offset = "0x560")]
		[SerializeField]
		private Vector2 _bossAvatarSize;

		// Token: 0x040118D4 RID: 71892
		[Token(Token = "0x40118D4")]
		[FieldOffset(Offset = "0x568")]
		[SerializeField]
		private bool _hideAvatarBackground;

		// Token: 0x040118D5 RID: 71893
		[Token(Token = "0x40118D5")]
		[FieldOffset(Offset = "0x569")]
		[SerializeField]
		private bool _enableSpSliderWarning;

		// Token: 0x040118D6 RID: 71894
		[Token(Token = "0x40118D6")]
		[FieldOffset(Offset = "0x56C")]
		[SerializeField]
		private float _hudDelayToAppear;

		// Token: 0x040118D7 RID: 71895
		[Token(Token = "0x40118D7")]
		[FieldOffset(Offset = "0x570")]
		[SerializeField]
		private bool _hideHpSlider;

		// Token: 0x040118D8 RID: 71896
		[Token(Token = "0x40118D8")]
		[FieldOffset(Offset = "0x571")]
		[SerializeField]
		private bool _hideSpSlider;

		// Token: 0x040118D9 RID: 71897
		[Token(Token = "0x40118D9")]
		[FieldOffset(Offset = "0x574")]
		[SerializeField]
		private BattleUIConst.GiantBossInfoType _giantBossInfoType;

		// Token: 0x040118DB RID: 71899
		[Token(Token = "0x40118DB")]
		[FieldOffset(Offset = "0x580")]
		private FP m_delayToAppear;

		// Token: 0x040118DC RID: 71900
		[Token(Token = "0x40118DC")]
		[FieldOffset(Offset = "0x588")]
		private FP m_delayToAppearRemain;

		// Token: 0x040118DD RID: 71901
		[Token(Token = "0x40118DD")]
		[FieldOffset(Offset = "0x590")]
		private int m_delayToWaitOtherFinish;

		// Token: 0x040118DE RID: 71902
		[Token(Token = "0x40118DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_delayToAppear;

		// Token: 0x040118DF RID: 71903
		[Token(Token = "0x40118DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_inDelayAppear;

		// Token: 0x040118E0 RID: 71904
		[Token(Token = "0x40118E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isGiantBoss;

		// Token: 0x040118E1 RID: 71905
		[Token(Token = "0x40118E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_maxEs;

		// Token: 0x040118E2 RID: 71906
		[Token(Token = "0x40118E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_alive;

		// Token: 0x040118E3 RID: 71907
		[Token(Token = "0x40118E3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_bossHudOffset;

		// Token: 0x040118E4 RID: 71908
		[Token(Token = "0x40118E4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bossHudScale;

		// Token: 0x040118E5 RID: 71909
		[Token(Token = "0x40118E5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_bossAvatarOffset;

		// Token: 0x040118E6 RID: 71910
		[Token(Token = "0x40118E6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_bossAvatarSize;

		// Token: 0x040118E7 RID: 71911
		[Token(Token = "0x40118E7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_hideAvatarBackground;

		// Token: 0x040118E8 RID: 71912
		[Token(Token = "0x40118E8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_enableSpSliderWarning;

		// Token: 0x040118E9 RID: 71913
		[Token(Token = "0x40118E9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_lockHudPosition;

		// Token: 0x040118EA RID: 71914
		[Token(Token = "0x40118EA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_hudDelayToAppear;

		// Token: 0x040118EB RID: 71915
		[Token(Token = "0x40118EB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_hideHpSlider;

		// Token: 0x040118EC RID: 71916
		[Token(Token = "0x40118EC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_hideSpSlider;

		// Token: 0x040118ED RID: 71917
		[Token(Token = "0x40118ED")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_giantBossInfoType;

		// Token: 0x040118EE RID: 71918
		[Token(Token = "0x40118EE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isSkillAffecting;

		// Token: 0x040118EF RID: 71919
		[Token(Token = "0x40118EF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isSpCostSkill;

		// Token: 0x040118F0 RID: 71920
		[Token(Token = "0x40118F0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_skillRemainingProgress;

		// Token: 0x040118F1 RID: 71921
		[Token(Token = "0x40118F1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_epIsFull;

		// Token: 0x040118F2 RID: 71922
		[Token(Token = "0x40118F2")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_minEpTypeToShow;

		// Token: 0x040118F3 RID: 71923
		[Token(Token = "0x40118F3")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_epArrayToShow;

		// Token: 0x040118F4 RID: 71924
		[Token(Token = "0x40118F4")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_epController;

		// Token: 0x040118F5 RID: 71925
		[Token(Token = "0x40118F5")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_maxEp;

		// Token: 0x040118F6 RID: 71926
		[Token(Token = "0x40118F6")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_isInEpBreakRecovery;

		// Token: 0x040118F7 RID: 71927
		[Token(Token = "0x40118F7")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_actionOnTakeDamage;

		// Token: 0x040118F8 RID: 71928
		[Token(Token = "0x40118F8")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_actionOnTakeDamage;

		// Token: 0x040118F9 RID: 71929
		[Token(Token = "0x40118F9")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040118FA RID: 71930
		[Token(Token = "0x40118FA")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x040118FB RID: 71931
		[Token(Token = "0x40118FB")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x040118FC RID: 71932
		[Token(Token = "0x40118FC")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040118FD RID: 71933
		[Token(Token = "0x40118FD")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnOtherUnitDestroyed;

		// Token: 0x040118FE RID: 71934
		[Token(Token = "0x40118FE")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040118FF RID: 71935
		[Token(Token = "0x40118FF")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__DoDelayAppear;

		// Token: 0x04011900 RID: 71936
		[Token(Token = "0x4011900")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x04011901 RID: 71937
		[Token(Token = "0x4011901")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04011902 RID: 71938
		[Token(Token = "0x4011902")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__DoBorn;

		// Token: 0x04011903 RID: 71939
		[Token(Token = "0x4011903")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
