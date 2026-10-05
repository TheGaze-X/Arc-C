using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F2F RID: 24367
	[Token(Token = "0x2005F2F")]
	public class CharacterDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005372 RID: 21362
		// (set) Token: 0x06023493 RID: 144531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005372")]
		public float state
		{
			[Token(Token = "0x6023493")]
			[Address(RVA = "0x1DD4160", Offset = "0x1DD2D60", VA = "0x181DD4160")]
			set
			{
			}
		}

		// Token: 0x17005373 RID: 21363
		// (get) Token: 0x06023494 RID: 144532 RVA: 0x000C0798 File Offset: 0x000BE998
		// (set) Token: 0x06023495 RID: 144533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005373")]
		public bool autoActivateIllust
		{
			[Token(Token = "0x6023494")]
			[Address(RVA = "0x1DD3E10", Offset = "0x1DD2A10", VA = "0x181DD3E10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6023495")]
			[Address(RVA = "0x1DD4080", Offset = "0x1DD2C80", VA = "0x181DD4080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005374 RID: 21364
		// (get) Token: 0x06023496 RID: 144534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005374")]
		public UICharacterIllust illust
		{
			[Token(Token = "0x6023496")]
			[Address(RVA = "0x1DD3F40", Offset = "0x1DD2B40", VA = "0x181DD3F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005375 RID: 21365
		// (get) Token: 0x06023497 RID: 144535 RVA: 0x000C07B0 File Offset: 0x000BE9B0
		[Token(Token = "0x17005375")]
		public bool isReachMaxEvolve
		{
			[Token(Token = "0x6023497")]
			[Address(RVA = "0x1DD3FB0", Offset = "0x1DD2BB0", VA = "0x181DD3FB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06023498 RID: 144536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023498")]
		[Address(RVA = "0x1DD35D0", Offset = "0x1DD21D0", VA = "0x181DD35D0")]
		public void ConsumeNew()
		{
		}

		// Token: 0x06023499 RID: 144537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023499")]
		[Address(RVA = "0x1DD3C90", Offset = "0x1DD2890", VA = "0x181DD3C90")]
		public void TryConsumeSpCharMissionNew()
		{
		}

		// Token: 0x17005376 RID: 21366
		// (get) Token: 0x0602349A RID: 144538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005376")]
		public CharacterDetailViewModel model
		{
			[Token(Token = "0x602349A")]
			[Address(RVA = "0x1DD4020", Offset = "0x1DD2C20", VA = "0x181DD4020")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602349B RID: 144539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602349B")]
		[Address(RVA = "0x1DD3640", Offset = "0x1DD2240", VA = "0x181DD3640")]
		public CharacterIllustViewModel GetIllustViewModel()
		{
			return null;
		}

		// Token: 0x0602349C RID: 144540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602349C")]
		[Address(RVA = "0x1DD36C0", Offset = "0x1DD22C0", VA = "0x181DD36C0")]
		public SkillGroupViewModel GetSkillViewModel()
		{
			return null;
		}

		// Token: 0x0602349D RID: 144541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602349D")]
		[Address(RVA = "0x1DD31C0", Offset = "0x1DD1DC0", VA = "0x181DD31C0")]
		public void Apply(int selectIllustIndex)
		{
		}

		// Token: 0x17005377 RID: 21367
		// (get) Token: 0x0602349E RID: 144542 RVA: 0x000C07C8 File Offset: 0x000BE9C8
		// (set) Token: 0x0602349F RID: 144543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005377")]
		public int chrInstIdCache
		{
			[Token(Token = "0x602349E")]
			[Address(RVA = "0x1DD3E70", Offset = "0x1DD2A70", VA = "0x181DD3E70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602349F")]
			[Address(RVA = "0x1DD40F0", Offset = "0x1DD2CF0", VA = "0x181DD40F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005378 RID: 21368
		// (get) Token: 0x060234A0 RID: 144544 RVA: 0x000C07E0 File Offset: 0x000BE9E0
		[Token(Token = "0x17005378")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x60234A0")]
			[Address(RVA = "0x1DD3ED0", Offset = "0x1DD2AD0", VA = "0x181DD3ED0")]
			get
			{
				return EvolvePhase.PHASE_0;
			}
		}

		// Token: 0x060234A1 RID: 144545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234A1")]
		[Address(RVA = "0x1DD3560", Offset = "0x1DD2160", VA = "0x181DD3560")]
		public void BtnOnUpLvl()
		{
		}

		// Token: 0x060234A2 RID: 144546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234A2")]
		[Address(RVA = "0x1DD3310", Offset = "0x1DD1F10", VA = "0x181DD3310")]
		public void BtnOnSkillSelect()
		{
		}

		// Token: 0x060234A3 RID: 144547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234A3")]
		[Address(RVA = "0x1DD3220", Offset = "0x1DD1E20", VA = "0x181DD3220")]
		public void BtnOnEvolve()
		{
		}

		// Token: 0x060234A4 RID: 144548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234A4")]
		[Address(RVA = "0x1DD3470", Offset = "0x1DD2070", VA = "0x181DD3470")]
		public void BtnOnTrans()
		{
		}

		// Token: 0x060234A5 RID: 144549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234A5")]
		[Address(RVA = "0x1DD3380", Offset = "0x1DD1F80", VA = "0x181DD3380")]
		public void BtnOnSpCharMission()
		{
		}

		// Token: 0x060234A6 RID: 144550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234A6")]
		[Address(RVA = "0x1DD3290", Offset = "0x1DD1E90", VA = "0x181DD3290")]
		public void BtnOnPotential()
		{
		}

		// Token: 0x060234A7 RID: 144551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234A7")]
		[Address(RVA = "0x1DD33F0", Offset = "0x1DD1FF0", VA = "0x181DD33F0")]
		public void BtnOnTalent()
		{
		}

		// Token: 0x060234A8 RID: 144552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234A8")]
		[Address(RVA = "0x1DD34E0", Offset = "0x1DD20E0", VA = "0x181DD34E0")]
		public void BtnOnUniEquip()
		{
		}

		// Token: 0x060234A9 RID: 144553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234A9")]
		[Address(RVA = "0x1DD39A0", Offset = "0x1DD25A0", VA = "0x181DD39A0")]
		public void RefreshState(float state)
		{
		}

		// Token: 0x060234AA RID: 144554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234AA")]
		[Address(RVA = "0x1DD37C0", Offset = "0x1DD23C0", VA = "0x181DD37C0")]
		public void RefreshData()
		{
		}

		// Token: 0x060234AB RID: 144555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234AB")]
		[Address(RVA = "0x1DD3A50", Offset = "0x1DD2650", VA = "0x181DD3A50")]
		public void Render(int chrinstId, int state, bool haveLeft, bool haveRight, bool initAsTutorialTarget = false)
		{
		}

		// Token: 0x060234AC RID: 144556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234AC")]
		[Address(RVA = "0x1DD3740", Offset = "0x1DD2340", VA = "0x181DD3740")]
		public void OnProfessionDetail()
		{
		}

		// Token: 0x060234AD RID: 144557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234AD")]
		[Address(RVA = "0x1DD3D60", Offset = "0x1DD2960", VA = "0x181DD3D60")]
		public CharacterDetailView()
		{
		}

		// Token: 0x04030A74 RID: 199284
		[Token(Token = "0x4030A74")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterInfoIllustController _illustController;

		// Token: 0x04030A75 RID: 199285
		[Token(Token = "0x4030A75")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterInfoAttributeViewController _attribute;

		// Token: 0x04030A76 RID: 199286
		[Token(Token = "0x4030A76")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterDetailViewModel _viewModel;

		// Token: 0x04030A77 RID: 199287
		[Token(Token = "0x4030A77")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04030A78 RID: 199288
		[Token(Token = "0x4030A78")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TutorialObjectHolder _tutorialObjHolder;

		// Token: 0x04030A79 RID: 199289
		[Token(Token = "0x4030A79")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTrackPoint _skillTrackPoint;

		// Token: 0x04030A7A RID: 199290
		[Token(Token = "0x4030A7A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonTrackPoint _potentialTrackPoint;

		// Token: 0x04030A7B RID: 199291
		[Token(Token = "0x4030A7B")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public TrackPointViewProperty potentialTrackProp;

		// Token: 0x04030A7C RID: 199292
		[Token(Token = "0x4030A7C")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action onUpLevel;

		// Token: 0x04030A7D RID: 199293
		[Token(Token = "0x4030A7D")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action onSkillSelect;

		// Token: 0x04030A7E RID: 199294
		[Token(Token = "0x4030A7E")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action onEvolve;

		// Token: 0x04030A7F RID: 199295
		[Token(Token = "0x4030A7F")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action onTrans;

		// Token: 0x04030A80 RID: 199296
		[Token(Token = "0x4030A80")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action onSpCharMission;

		// Token: 0x04030A81 RID: 199297
		[Token(Token = "0x4030A81")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action OnPotential;

		// Token: 0x04030A82 RID: 199298
		[Token(Token = "0x4030A82")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action OnSubProf;

		// Token: 0x04030A83 RID: 199299
		[Token(Token = "0x4030A83")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action OnUniEquipClick;

		// Token: 0x04030A84 RID: 199300
		[Token(Token = "0x4030A84")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Action onProfessionDetailClick;

		// Token: 0x04030A85 RID: 199301
		[Token(Token = "0x4030A85")]
		[FieldOffset(Offset = "0xA0")]
		private float m_state;

		// Token: 0x04030A88 RID: 199304
		[Token(Token = "0x4030A88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x04030A89 RID: 199305
		[Token(Token = "0x4030A89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_autoActivateIllust;

		// Token: 0x04030A8A RID: 199306
		[Token(Token = "0x4030A8A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_autoActivateIllust;

		// Token: 0x04030A8B RID: 199307
		[Token(Token = "0x4030A8B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_illust;

		// Token: 0x04030A8C RID: 199308
		[Token(Token = "0x4030A8C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isReachMaxEvolve;

		// Token: 0x04030A8D RID: 199309
		[Token(Token = "0x4030A8D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ConsumeNew;

		// Token: 0x04030A8E RID: 199310
		[Token(Token = "0x4030A8E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryConsumeSpCharMissionNew;

		// Token: 0x04030A8F RID: 199311
		[Token(Token = "0x4030A8F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_model;

		// Token: 0x04030A90 RID: 199312
		[Token(Token = "0x4030A90")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetIllustViewModel;

		// Token: 0x04030A91 RID: 199313
		[Token(Token = "0x4030A91")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetSkillViewModel;

		// Token: 0x04030A92 RID: 199314
		[Token(Token = "0x4030A92")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x04030A93 RID: 199315
		[Token(Token = "0x4030A93")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_chrInstIdCache;

		// Token: 0x04030A94 RID: 199316
		[Token(Token = "0x4030A94")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_chrInstIdCache;

		// Token: 0x04030A95 RID: 199317
		[Token(Token = "0x4030A95")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x04030A96 RID: 199318
		[Token(Token = "0x4030A96")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_BtnOnUpLvl;

		// Token: 0x04030A97 RID: 199319
		[Token(Token = "0x4030A97")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_BtnOnSkillSelect;

		// Token: 0x04030A98 RID: 199320
		[Token(Token = "0x4030A98")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_BtnOnEvolve;

		// Token: 0x04030A99 RID: 199321
		[Token(Token = "0x4030A99")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_BtnOnTrans;

		// Token: 0x04030A9A RID: 199322
		[Token(Token = "0x4030A9A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_BtnOnSpCharMission;

		// Token: 0x04030A9B RID: 199323
		[Token(Token = "0x4030A9B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_BtnOnPotential;

		// Token: 0x04030A9C RID: 199324
		[Token(Token = "0x4030A9C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_BtnOnTalent;

		// Token: 0x04030A9D RID: 199325
		[Token(Token = "0x4030A9D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_BtnOnUniEquip;

		// Token: 0x04030A9E RID: 199326
		[Token(Token = "0x4030A9E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RefreshState;

		// Token: 0x04030A9F RID: 199327
		[Token(Token = "0x4030A9F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04030AA0 RID: 199328
		[Token(Token = "0x4030AA0")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030AA1 RID: 199329
		[Token(Token = "0x4030AA1")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnProfessionDetail;

		// Token: 0x04030AA2 RID: 199330
		[Token(Token = "0x4030AA2")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
