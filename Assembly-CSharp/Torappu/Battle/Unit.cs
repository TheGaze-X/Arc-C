using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using Torappu.Battle.Action;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200261A RID: 9754
	[Token(Token = "0x200261A")]
	public abstract class Unit : Entity, IEffectSource, IProjectileSource, IAbilitySource, IActionNodeSource, ISpecialAudioSignalSource, IBuffSource, ITalentOwner, IHudPluginSource
	{
		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x0600FE8A RID: 65162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700227C")]
		public Unit.PalsyController palsyController
		{
			[Token(Token = "0x600FE8A")]
			[Address(RVA = "0x772B30", Offset = "0x771730", VA = "0x180772B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x0600FE8B RID: 65163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700227D")]
		public virtual UnitMode defaultMode
		{
			[Token(Token = "0x600FE8B")]
			[Address(RVA = "0x770D80", Offset = "0x76F980", VA = "0x180770D80", Slot = "141")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x0600FE8C RID: 65164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700227E")]
		protected UnitMode currentMode
		{
			[Token(Token = "0x600FE8C")]
			[Address(RVA = "0x770C00", Offset = "0x76F800", VA = "0x180770C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x0600FE8D RID: 65165 RVA: 0x00060B70 File Offset: 0x0005ED70
		[Token(Token = "0x1700227F")]
		protected virtual bool needUpdateRootHeight
		{
			[Token(Token = "0x600FE8D")]
			[Address(RVA = "0x772830", Offset = "0x771430", VA = "0x180772830", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002280 RID: 8832
		// (set) Token: 0x0600FE8E RID: 65166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002280")]
		public GameObject colliderSprite
		{
			[Token(Token = "0x600FE8E")]
			[Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			set
			{
			}
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x0600FE8F RID: 65167 RVA: 0x00060B88 File Offset: 0x0005ED88
		[Token(Token = "0x17002281")]
		public int currentModeIndex
		{
			[Token(Token = "0x600FE8F")]
			[Address(RVA = "0x770AB0", Offset = "0x76F6B0", VA = "0x180770AB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x0600FE90 RID: 65168 RVA: 0x00060BA0 File Offset: 0x0005EDA0
		[Token(Token = "0x17002282")]
		public override int faceSign
		{
			[Token(Token = "0x600FE90")]
			[Address(RVA = "0x7711A0", Offset = "0x76FDA0", VA = "0x1807711A0", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x0600FE91 RID: 65169 RVA: 0x00060BB8 File Offset: 0x0005EDB8
		[Token(Token = "0x17002283")]
		public override bool faceToBack
		{
			[Token(Token = "0x600FE91")]
			[Address(RVA = "0x7712D0", Offset = "0x76FED0", VA = "0x1807712D0", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x0600FE92 RID: 65170 RVA: 0x00060BD0 File Offset: 0x0005EDD0
		[Token(Token = "0x17002284")]
		public override bool faceToDown
		{
			[Token(Token = "0x600FE92")]
			[Address(RVA = "0x771400", Offset = "0x770000", VA = "0x180771400", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x0600FE93 RID: 65171 RVA: 0x00060BE8 File Offset: 0x0005EDE8
		[Token(Token = "0x17002285")]
		public override SharedConsts.Direction faceLOrR
		{
			[Token(Token = "0x600FE93")]
			[Address(RVA = "0x771070", Offset = "0x76FC70", VA = "0x180771070", Slot = "57")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x0600FE94 RID: 65172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002286")]
		public virtual string talentRange
		{
			[Token(Token = "0x600FE94")]
			[Address(RVA = "0x7730B0", Offset = "0x771CB0", VA = "0x1807730B0", Slot = "143")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x0600FE95 RID: 65173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002287")]
		public virtual Ability combat
		{
			[Token(Token = "0x600FE95")]
			[Address(RVA = "0x7709F0", Offset = "0x76F5F0", VA = "0x1807709F0", Slot = "144")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x0600FE96 RID: 65174 RVA: 0x00060C00 File Offset: 0x0005EE00
		[Token(Token = "0x17002288")]
		public virtual bool hasCombat
		{
			[Token(Token = "0x600FE96")]
			[Address(RVA = "0x771B80", Offset = "0x770780", VA = "0x180771B80", Slot = "145")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x0600FE97 RID: 65175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002289")]
		public virtual Ability attack
		{
			[Token(Token = "0x600FE97")]
			[Address(RVA = "0x7707F0", Offset = "0x76F3F0", VA = "0x1807707F0", Slot = "146")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x0600FE98 RID: 65176 RVA: 0x00060C18 File Offset: 0x0005EE18
		[Token(Token = "0x1700228A")]
		public bool hasAttack
		{
			[Token(Token = "0x600FE98")]
			[Address(RVA = "0x771B10", Offset = "0x770710", VA = "0x180771B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x0600FE99 RID: 65177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700228B")]
		public virtual TargetTrigger attackTrigger
		{
			[Token(Token = "0x600FE99")]
			[Address(RVA = "0x770730", Offset = "0x76F330", VA = "0x180770730", Slot = "147")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x0600FE9A RID: 65178 RVA: 0x00060C30 File Offset: 0x0005EE30
		[Token(Token = "0x1700228C")]
		public override SourceApplyWay allApplyWay
		{
			[Token(Token = "0x600FE9A")]
			[Address(RVA = "0x770390", Offset = "0x76EF90", VA = "0x180770390", Slot = "49")]
			get
			{
				return SourceApplyWay.NONE;
			}
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x0600FE9B RID: 65179
		[Token(Token = "0x1700228D")]
		public abstract FP ColliderRadius { [Token(Token = "0x600FE9B")] get; }

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x0600FE9C RID: 65180
		[Token(Token = "0x1700228E")]
		public abstract bool isInCombat { [Token(Token = "0x600FE9C")] get; }

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x0600FE9D RID: 65181
		[Token(Token = "0x1700228F")]
		public abstract bool isInAttackState { [Token(Token = "0x600FE9D")] get; }

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x0600FE9E RID: 65182
		[Token(Token = "0x17002290")]
		public abstract bool isInCombatState { [Token(Token = "0x600FE9E")] get; }

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x0600FE9F RID: 65183
		[Token(Token = "0x17002291")]
		public abstract bool isInDyingState { [Token(Token = "0x600FE9F")] get; }

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x0600FEA0 RID: 65184
		[Token(Token = "0x17002292")]
		public abstract bool isInRebornState { [Token(Token = "0x600FEA0")] get; }

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x0600FEA1 RID: 65185 RVA: 0x00060C48 File Offset: 0x0005EE48
		[Token(Token = "0x17002293")]
		public override bool isHidden
		{
			[Token(Token = "0x600FEA1")]
			[Address(RVA = "0x7724F0", Offset = "0x7710F0", VA = "0x1807724F0", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x0600FEA2 RID: 65186 RVA: 0x00060C60 File Offset: 0x0005EE60
		[Token(Token = "0x17002294")]
		public virtual bool isMovingBySelf
		{
			[Token(Token = "0x600FEA2")]
			[Address(RVA = "0x772580", Offset = "0x771180", VA = "0x180772580", Slot = "154")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x0600FEA3 RID: 65187 RVA: 0x00060C78 File Offset: 0x0005EE78
		[Token(Token = "0x17002295")]
		public bool showDebugName
		{
			[Token(Token = "0x600FEA3")]
			[Address(RVA = "0x772D60", Offset = "0x771960", VA = "0x180772D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x0600FEA4 RID: 65188 RVA: 0x00060C90 File Offset: 0x0005EE90
		[Token(Token = "0x17002296")]
		public bool hasRangeToShow
		{
			[Token(Token = "0x600FEA4")]
			[Address(RVA = "0x771CB0", Offset = "0x7708B0", VA = "0x180771CB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x0600FEA5 RID: 65189 RVA: 0x00060CA8 File Offset: 0x0005EEA8
		[Token(Token = "0x17002297")]
		public bool hasExtraRangeToShow
		{
			[Token(Token = "0x600FEA5")]
			[Address(RVA = "0x771BF0", Offset = "0x7707F0", VA = "0x180771BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x0600FEA6 RID: 65190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002298")]
		public virtual IDrawableRange rangeToShow
		{
			[Token(Token = "0x600FEA6")]
			[Address(RVA = "0x772B90", Offset = "0x771790", VA = "0x180772B90", Slot = "155")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x0600FEA7 RID: 65191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002299")]
		public virtual IDrawableRange[] extraRangesToShow
		{
			[Token(Token = "0x600FEA7")]
			[Address(RVA = "0x770F80", Offset = "0x76FB80", VA = "0x180770F80", Slot = "156")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x0600FEA8 RID: 65192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700229A")]
		public virtual string defaultRangeId
		{
			[Token(Token = "0x600FEA8")]
			[Address(RVA = "0x770E00", Offset = "0x76FA00", VA = "0x180770E00", Slot = "157")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600FEA9 RID: 65193 RVA: 0x00060CC0 File Offset: 0x0005EEC0
		[Token(Token = "0x1700229B")]
		public override float graphicBoundRadius
		{
			[Token(Token = "0x600FEA9")]
			[Address(RVA = "0x7716E0", Offset = "0x7702E0", VA = "0x1807716E0", Slot = "70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x0600FEAA RID: 65194 RVA: 0x00060CD8 File Offset: 0x0005EED8
		[Token(Token = "0x1700229C")]
		public bool hideUIAttackRange
		{
			[Token(Token = "0x600FEAA")]
			[Address(RVA = "0x771F70", Offset = "0x770B70", VA = "0x180771F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x0600FEAB RID: 65195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700229D")]
		public virtual UnitAnimator animator
		{
			[Token(Token = "0x600FEAB")]
			[Address(RVA = "0x7704C0", Offset = "0x76F0C0", VA = "0x1807704C0", Slot = "158")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x0600FEAC RID: 65196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700229E")]
		public UnitAnimatorHooker animatorHooker
		{
			[Token(Token = "0x600FEAC")]
			[Address(RVA = "0x770450", Offset = "0x76F050", VA = "0x180770450")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x0600FEAD RID: 65197 RVA: 0x00060CF0 File Offset: 0x0005EEF0
		// (set) Token: 0x0600FEAE RID: 65198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700229F")]
		public override Color color
		{
			[Token(Token = "0x600FEAD")]
			[Address(RVA = "0x770920", Offset = "0x76F520", VA = "0x180770920", Slot = "63")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600FEAE")]
			[Address(RVA = "0x773260", Offset = "0x771E60", VA = "0x180773260", Slot = "64")]
			protected set
			{
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x0600FEAF RID: 65199 RVA: 0x00060D08 File Offset: 0x0005EF08
		[Token(Token = "0x170022A0")]
		public override Color defaultBodyColor
		{
			[Token(Token = "0x600FEAF")]
			[Address(RVA = "0x770C60", Offset = "0x76F860", VA = "0x180770C60", Slot = "69")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600FEB0 RID: 65200 RVA: 0x00060D20 File Offset: 0x0005EF20
		[Token(Token = "0x170022A1")]
		public Color originDefaultBodyColor
		{
			[Token(Token = "0x600FEB0")]
			[Address(RVA = "0x772AA0", Offset = "0x7716A0", VA = "0x180772AA0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x0600FEB1 RID: 65201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022A2")]
		public override Transform bodyTransform
		{
			[Token(Token = "0x600FEB1")]
			[Address(RVA = "0x7708B0", Offset = "0x76F4B0", VA = "0x1807708B0", Slot = "58")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x0600FEB2 RID: 65202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022A3")]
		public override Transform graphicTransform
		{
			[Token(Token = "0x600FEB2")]
			[Address(RVA = "0x771A60", Offset = "0x770660", VA = "0x180771A60", Slot = "59")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x0600FEB3 RID: 65203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022A4")]
		public override Transform graphicFootTransform
		{
			[Token(Token = "0x600FEB3")]
			[Address(RVA = "0x7717A0", Offset = "0x7703A0", VA = "0x1807717A0", Slot = "60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x0600FEB4 RID: 65204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022A5")]
		public override Transform graphicHolderTransform
		{
			[Token(Token = "0x600FEB4")]
			[Address(RVA = "0x7719E0", Offset = "0x7705E0", VA = "0x1807719E0", Slot = "61")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x0600FEB5 RID: 65205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022A6")]
		public override Transform uiPoint
		{
			[Token(Token = "0x600FEB5")]
			[Address(RVA = "0x773180", Offset = "0x771D80", VA = "0x180773180", Slot = "75")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x0600FEB6 RID: 65206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022A7")]
		public override Transform hitPoint
		{
			[Token(Token = "0x600FEB6")]
			[Address(RVA = "0x7720C0", Offset = "0x770CC0", VA = "0x1807720C0", Slot = "72")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x0600FEB7 RID: 65207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022A8")]
		public override Transform footPoint
		{
			[Token(Token = "0x600FEB7")]
			[Address(RVA = "0x771530", Offset = "0x770130", VA = "0x180771530", Slot = "71")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x0600FEB8 RID: 65208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022A9")]
		public override Transform muzzlePoint
		{
			[Token(Token = "0x600FEB8")]
			[Address(RVA = "0x7726A0", Offset = "0x7712A0", VA = "0x1807726A0", Slot = "73")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x0600FEB9 RID: 65209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022AA")]
		public override Transform headPoint
		{
			[Token(Token = "0x600FEB9")]
			[Address(RVA = "0x771DC0", Offset = "0x7709C0", VA = "0x180771DC0", Slot = "74")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x0600FEBA RID: 65210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022AB")]
		public override Transform effectTransform
		{
			[Token(Token = "0x600FEBA")]
			[Address(RVA = "0x770E60", Offset = "0x76FA60", VA = "0x180770E60", Slot = "76")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x0600FEBB RID: 65211 RVA: 0x00060D38 File Offset: 0x0005EF38
		[Token(Token = "0x170022AC")]
		public override EntityCategory category
		{
			[Token(Token = "0x600FEBB")]
			[Address(RVA = "0x762C50", Offset = "0x761850", VA = "0x180762C50", Slot = "47")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x0600FEBC RID: 65212 RVA: 0x00060D50 File Offset: 0x0005EF50
		[Token(Token = "0x170022AD")]
		public virtual FP hpToShow
		{
			[Token(Token = "0x600FEBC")]
			[Address(RVA = "0x75F0E0", Offset = "0x75DCE0", VA = "0x18075F0E0", Slot = "159")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x0600FEBD RID: 65213 RVA: 0x00060D68 File Offset: 0x0005EF68
		[Token(Token = "0x170022AE")]
		public virtual FP shieldToShow
		{
			[Token(Token = "0x600FEBD")]
			[Address(RVA = "0x772CE0", Offset = "0x7718E0", VA = "0x180772CE0", Slot = "160")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x0600FEBE RID: 65214 RVA: 0x00060D80 File Offset: 0x0005EF80
		[Token(Token = "0x170022AF")]
		public FP hpRatioToShow
		{
			[Token(Token = "0x600FEBE")]
			[Address(RVA = "0x7722F0", Offset = "0x770EF0", VA = "0x1807722F0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x0600FEBF RID: 65215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022B0")]
		public virtual FP[] epArrayToShow
		{
			[Token(Token = "0x600FEBF")]
			[Address(RVA = "0x770F20", Offset = "0x76FB20", VA = "0x180770F20", Slot = "161")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x0600FEC0 RID: 65216 RVA: 0x00060D98 File Offset: 0x0005EF98
		[Token(Token = "0x170022B1")]
		public ElementType minEpTypeToShow
		{
			[Token(Token = "0x600FEC0")]
			[Address(RVA = "0x772640", Offset = "0x771240", VA = "0x180772640", Slot = "162")]
			get
			{
				return ElementType.NONE;
			}
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x0600FEC1 RID: 65217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022B2")]
		public ShadowController shadowController
		{
			[Token(Token = "0x600FEC1")]
			[Address(RVA = "0x772C80", Offset = "0x771880", VA = "0x180772C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x0600FEC2 RID: 65218 RVA: 0x00060DB0 File Offset: 0x0005EFB0
		[Token(Token = "0x170022B3")]
		public FP graphicHeight
		{
			[Token(Token = "0x600FEC2")]
			[Address(RVA = "0x771850", Offset = "0x770450", VA = "0x180771850")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x0600FEC3 RID: 65219 RVA: 0x00060DC8 File Offset: 0x0005EFC8
		// (set) Token: 0x0600FEC4 RID: 65220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022B4")]
		public bool isDummy
		{
			[Token(Token = "0x600FEC3")]
			[Address(RVA = "0x772490", Offset = "0x771090", VA = "0x180772490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600FEC4")]
			[Address(RVA = "0x773340", Offset = "0x771F40", VA = "0x180773340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x0600FEC5 RID: 65221 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FEC6 RID: 65222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022B5")]
		public BasicTalent[] talents
		{
			[Token(Token = "0x600FEC5")]
			[Address(RVA = "0x773120", Offset = "0x771D20", VA = "0x180773120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600FEC6")]
			[Address(RVA = "0x7733B0", Offset = "0x771FB0", VA = "0x1807733B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600FEC7 RID: 65223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FEC7")]
		[Address(RVA = "0x768780", Offset = "0x767380", VA = "0x180768780", Slot = "163")]
		public virtual Entity FetchHost()
		{
			return null;
		}

		// Token: 0x0600FEC8 RID: 65224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEC8")]
		[Address(RVA = "0x76DFC0", Offset = "0x76CBC0", VA = "0x18076DFC0")]
		public void SetSpShowedBuff(ObjectPtr<Buff> buff, bool isSkillCountdown = false)
		{
		}

		// Token: 0x0600FEC9 RID: 65225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEC9")]
		[Address(RVA = "0x76DF10", Offset = "0x76CB10", VA = "0x18076DF10")]
		public void SetSpShowedBuff(ObjectPtr<Buff> buff, AdvancedSpShowBuffType advancedType)
		{
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x0600FECA RID: 65226 RVA: 0x00060DE0 File Offset: 0x0005EFE0
		[Token(Token = "0x170022B6")]
		public virtual Vector2 hudOffset
		{
			[Token(Token = "0x600FECA")]
			[Address(RVA = "0x757AF0", Offset = "0x7566F0", VA = "0x180757AF0", Slot = "164")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x0600FECB RID: 65227 RVA: 0x00060DF8 File Offset: 0x0005EFF8
		[Token(Token = "0x170022B7")]
		public bool hasSpShowedBuff
		{
			[Token(Token = "0x600FECB")]
			[Address(RVA = "0x771D40", Offset = "0x770940", VA = "0x180771D40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x0600FECC RID: 65228 RVA: 0x00060E10 File Offset: 0x0005F010
		[Token(Token = "0x170022B8")]
		public bool isSpShowedBuffCountdown
		{
			[Token(Token = "0x600FECC")]
			[Address(RVA = "0x7725E0", Offset = "0x7711E0", VA = "0x1807725E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x0600FECD RID: 65229 RVA: 0x00060E28 File Offset: 0x0005F028
		[Token(Token = "0x170022B9")]
		public virtual FP spShowedBuffProgress
		{
			[Token(Token = "0x600FECD")]
			[Address(RVA = "0x772DC0", Offset = "0x7719C0", VA = "0x180772DC0", Slot = "165")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x0600FECE RID: 65230 RVA: 0x00060E40 File Offset: 0x0005F040
		[Token(Token = "0x170022BA")]
		public virtual HudPluginMask hudPluginMask
		{
			[Token(Token = "0x600FECE")]
			[Address(RVA = "0x772410", Offset = "0x771010", VA = "0x180772410", Slot = "166")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x0600FECF RID: 65231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FECF")]
		[Address(RVA = "0x768FE0", Offset = "0x767BE0", VA = "0x180768FE0", Slot = "167")]
		public virtual void GatherHudPluginTypes(List<string> pluginNames)
		{
		}

		// Token: 0x0600FED0 RID: 65232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FED0")]
		[Address(RVA = "0x76D9E0", Offset = "0x76C5E0", VA = "0x18076D9E0")]
		protected void ReplaceHudPluginTypes(List<string> pluginNames, Unit.StringReplacePair replacePair)
		{
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x0600FED1 RID: 65233 RVA: 0x00060E58 File Offset: 0x0005F058
		[Token(Token = "0x170022BB")]
		public virtual bool enableNormalHud
		{
			[Token(Token = "0x600FED1")]
			[Address(RVA = "0x770EC0", Offset = "0x76FAC0", VA = "0x180770EC0", Slot = "168")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x0600FED2 RID: 65234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022BC")]
		public List<Tile> attackRangeTiles
		{
			[Token(Token = "0x600FED2")]
			[Address(RVA = "0x770520", Offset = "0x76F120", VA = "0x180770520")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x0600FED3 RID: 65235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022BD")]
		public List<Tile> originAttackRangeTiles
		{
			[Token(Token = "0x600FED3")]
			[Address(RVA = "0x772890", Offset = "0x771490", VA = "0x180772890")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600FED4 RID: 65236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FED4")]
		[Address(RVA = "0x769DE0", Offset = "0x7689E0", VA = "0x180769DE0")]
		public IDrawableRange GetRangeOfMode(int mode)
		{
			return null;
		}

		// Token: 0x0600FED5 RID: 65237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FED5")]
		[Address(RVA = "0x76E7C0", Offset = "0x76D3C0", VA = "0x18076E7C0")]
		public void ToggleMode(bool restartFSM)
		{
		}

		// Token: 0x0600FED6 RID: 65238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FED6")]
		[Address(RVA = "0x76E540", Offset = "0x76D140", VA = "0x18076E540")]
		public void SwitchMode(int index, bool restartFSM)
		{
		}

		// Token: 0x0600FED7 RID: 65239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FED7")]
		[Address(RVA = "0x76E460", Offset = "0x76D060", VA = "0x18076E460")]
		public void SwitchMode(int index, bool force, bool isInit, bool restartFSM)
		{
		}

		// Token: 0x0600FED8 RID: 65240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FED8")]
		[Address(RVA = "0x76E710", Offset = "0x76D310", VA = "0x18076E710")]
		public void SwitchToDefaultMode(bool restartFSM)
		{
		}

		// Token: 0x0600FED9 RID: 65241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FED9")]
		[Address(RVA = "0x7685D0", Offset = "0x7671D0", VA = "0x1807685D0")]
		public void EnableShadow(bool enable)
		{
		}

		// Token: 0x0600FEDA RID: 65242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEDA")]
		[Address(RVA = "0x768530", Offset = "0x767130", VA = "0x180768530")]
		public void EnableHoldEffect(bool enable)
		{
		}

		// Token: 0x0600FEDB RID: 65243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEDB")]
		[Address(RVA = "0x7686B0", Offset = "0x7672B0", VA = "0x1807686B0")]
		public void EnableVisualPart(bool enable)
		{
		}

		// Token: 0x0600FEDC RID: 65244 RVA: 0x00060E70 File Offset: 0x0005F070
		[Token(Token = "0x600FEDC")]
		[Address(RVA = "0x76E070", Offset = "0x76CC70", VA = "0x18076E070")]
		public bool SetSpineSkin(string skinKey)
		{
			return default(bool);
		}

		// Token: 0x0600FEDD RID: 65245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FEDD")]
		[Address(RVA = "0x7696D0", Offset = "0x7682D0", VA = "0x1807696D0")]
		public TargetSelector GetCurrentModeSelector()
		{
			return null;
		}

		// Token: 0x0600FEDE RID: 65246 RVA: 0x00060E88 File Offset: 0x0005F088
		[Token(Token = "0x600FEDE")]
		[Address(RVA = "0x76CF70", Offset = "0x76BB70", VA = "0x18076CF70")]
		public float PlayAnimation(string animKey, float speed)
		{
			return 0f;
		}

		// Token: 0x0600FEDF RID: 65247 RVA: 0x00060EA0 File Offset: 0x0005F0A0
		[Token(Token = "0x600FEDF")]
		[Address(RVA = "0x767BA0", Offset = "0x7667A0", VA = "0x180767BA0")]
		public bool ContainsAnimation(string animKey, bool allowEmpty)
		{
			return default(bool);
		}

		// Token: 0x0600FEE0 RID: 65248 RVA: 0x00060EB8 File Offset: 0x0005F0B8
		[Token(Token = "0x600FEE0")]
		[Address(RVA = "0x76CD80", Offset = "0x76B980", VA = "0x18076CD80")]
		public float PlayAnimationInFixedTime(string animKey, float time)
		{
			return 0f;
		}

		// Token: 0x0600FEE1 RID: 65249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEE1")]
		[Address(RVA = "0x76AA30", Offset = "0x769630", VA = "0x18076AA30")]
		public void ModifyDefaultColor(Color newColor)
		{
		}

		// Token: 0x0600FEE2 RID: 65250 RVA: 0x00060ED0 File Offset: 0x0005F0D0
		[Token(Token = "0x600FEE2")]
		[Address(RVA = "0x76D030", Offset = "0x76BC30", VA = "0x18076D030", Slot = "99")]
		public override float PlayAnimation(string animKey, bool forceFromStart = false, float speed = 1f, bool forcePlay = false)
		{
			return 0f;
		}

		// Token: 0x0600FEE3 RID: 65251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEE3")]
		[Address(RVA = "0x76EE20", Offset = "0x76DA20", VA = "0x18076EE20", Slot = "100")]
		public override void UpdateAnimPlaybackSpeed(float speed)
		{
		}

		// Token: 0x0600FEE4 RID: 65252 RVA: 0x00060EE8 File Offset: 0x0005F0E8
		[Token(Token = "0x600FEE4")]
		[Address(RVA = "0x7693F0", Offset = "0x767FF0", VA = "0x1807693F0", Slot = "101")]
		public override bool GetAnimationTime(string animKey, out float time)
		{
			return default(bool);
		}

		// Token: 0x0600FEE5 RID: 65253 RVA: 0x00060F00 File Offset: 0x0005F100
		[Token(Token = "0x600FEE5")]
		[Address(RVA = "0x7692A0", Offset = "0x767EA0", VA = "0x1807692A0", Slot = "102")]
		public override bool GetAnimationTime(string animKey, out float time, out float speed)
		{
			return default(bool);
		}

		// Token: 0x0600FEE6 RID: 65254 RVA: 0x00060F18 File Offset: 0x0005F118
		[Token(Token = "0x600FEE6")]
		[Address(RVA = "0x76EA00", Offset = "0x76D600", VA = "0x18076EA00", Slot = "104")]
		public override bool TryIgnoreEffect(string originEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600FEE7 RID: 65255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FEE7")]
		[Address(RVA = "0x769540", Offset = "0x768140", VA = "0x180769540")]
		public UnitAnimatorHooker GetAnimatorHooker(int modeIndex)
		{
			return null;
		}

		// Token: 0x0600FEE8 RID: 65256
		[Token(Token = "0x600FEE8")]
		public abstract void PlayAudioSignal(string ev, bool ignorePredefined);

		// Token: 0x0600FEE9 RID: 65257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEE9")]
		[Address(RVA = "0x76D610", Offset = "0x76C210", VA = "0x18076D610", Slot = "170")]
		public virtual void PreloadSpecialAudioSignals(string unitId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x0600FEEA RID: 65258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FEEA")]
		[Address(RVA = "0x769AA0", Offset = "0x7686A0", VA = "0x180769AA0", Slot = "89")]
		public override MountPoint GetMountPoint(Entity.MountPointType mountPoint)
		{
			return null;
		}

		// Token: 0x0600FEEB RID: 65259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FEEB")]
		[Address(RVA = "0x769990", Offset = "0x768590", VA = "0x180769990", Slot = "90")]
		public override MountPoint GetMountPointForEffect(Entity.MountPointType mountPoint)
		{
			return null;
		}

		// Token: 0x0600FEEC RID: 65260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FEEC")]
		[Address(RVA = "0x76FB60", Offset = "0x76E760", VA = "0x18076FB60")]
		private MountPoint _LazyLoadMountPoint(Transform mpTransform)
		{
			return null;
		}

		// Token: 0x0600FEED RID: 65261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FEED")]
		[Address(RVA = "0x769600", Offset = "0x768200", VA = "0x180769600", Slot = "171")]
		public virtual Blackboard GetAttackBlackboard(UnitMode mode)
		{
			return null;
		}

		// Token: 0x0600FEEE RID: 65262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEEE")]
		[Address(RVA = "0x76CB50", Offset = "0x76B750", VA = "0x18076CB50")]
		public void OverrideAttack(Ability ability, TargetTrigger trigger, bool cancel = false)
		{
		}

		// Token: 0x0600FEEF RID: 65263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEEF")]
		[Address(RVA = "0x76CC70", Offset = "0x76B870", VA = "0x18076CC70")]
		public void OverrideCombat(Ability ability, bool cancel = false)
		{
		}

		// Token: 0x0600FEF0 RID: 65264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEF0")]
		[Address(RVA = "0x768D80", Offset = "0x767980", VA = "0x180768D80", Slot = "172")]
		public virtual void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600FEF1 RID: 65265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEF1")]
		[Address(RVA = "0x768BF0", Offset = "0x7677F0", VA = "0x180768BF0", Slot = "138")]
		public void GatherBuffs(List<BuffData> buffs)
		{
		}

		// Token: 0x0600FEF2 RID: 65266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEF2")]
		[Address(RVA = "0x7690E0", Offset = "0x767CE0", VA = "0x1807690E0", Slot = "173")]
		public virtual void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0600FEF3 RID: 65267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEF3")]
		[Address(RVA = "0x768AF0", Offset = "0x7676F0", VA = "0x180768AF0", Slot = "174")]
		public virtual void GatherActionNodes(List<ActionNode> actions)
		{
		}

		// Token: 0x0600FEF4 RID: 65268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEF4")]
		[Address(RVA = "0x7687E0", Offset = "0x7673E0", VA = "0x1807687E0", Slot = "135")]
		public void GatherAbilities(string hostId, string tmplId, List<string> abilities)
		{
		}

		// Token: 0x0600FEF5 RID: 65269 RVA: 0x00060F30 File Offset: 0x0005F130
		[Token(Token = "0x600FEF5")]
		[Address(RVA = "0x76A9D0", Offset = "0x7695D0", VA = "0x18076A9D0")]
		public bool IsAttackRangeDirty()
		{
			return default(bool);
		}

		// Token: 0x0600FEF6 RID: 65270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FEF6")]
		[Address(RVA = "0x769860", Offset = "0x768460", VA = "0x180769860", Slot = "175")]
		public virtual string GetModeRangeId(UnitMode mode, RangeIdUsage usage)
		{
			return null;
		}

		// Token: 0x0600FEF7 RID: 65271 RVA: 0x00060F48 File Offset: 0x0005F148
		[Token(Token = "0x600FEF7")]
		[Address(RVA = "0x769910", Offset = "0x768510", VA = "0x180769910", Slot = "176")]
		public virtual float GetModeRangeRadius(UnitMode mode)
		{
			return 0f;
		}

		// Token: 0x0600FEF8 RID: 65272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEF8")]
		[Address(RVA = "0x76B730", Offset = "0x76A330", VA = "0x18076B730", Slot = "177")]
		public virtual void OnGameOver()
		{
		}

		// Token: 0x0600FEF9 RID: 65273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FEF9")]
		[Address(RVA = "0x769670", Offset = "0x768270", VA = "0x180769670", Slot = "178")]
		public virtual AbstractBasicAttack GetCurrentAttackOrCombatAbility()
		{
			return null;
		}

		// Token: 0x0600FEFA RID: 65274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEFA")]
		[Address(RVA = "0x76B970", Offset = "0x76A570", VA = "0x18076B970", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600FEFB RID: 65275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEFB")]
		[Address(RVA = "0x76BD20", Offset = "0x76A920", VA = "0x18076BD20", Slot = "31")]
		protected override void OnPostInit()
		{
		}

		// Token: 0x0600FEFC RID: 65276 RVA: 0x00060F60 File Offset: 0x0005F160
		[Token(Token = "0x600FEFC")]
		[Address(RVA = "0x76E1D0", Offset = "0x76CDD0", VA = "0x18076E1D0")]
		protected bool SwitchMode(UnitMode nextMode, bool force, bool isInit, bool restartFSM)
		{
			return default(bool);
		}

		// Token: 0x0600FEFD RID: 65277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEFD")]
		[Address(RVA = "0x766E20", Offset = "0x765A20", VA = "0x180766E20")]
		protected void ActivateMode(UnitMode next, UnitMode last, bool isInit)
		{
		}

		// Token: 0x0600FEFE RID: 65278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEFE")]
		[Address(RVA = "0x769FD0", Offset = "0x768BD0", VA = "0x180769FD0")]
		protected void InactiveMode(UnitMode mode, bool inactiveGameObject = true)
		{
		}

		// Token: 0x0600FEFF RID: 65279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FEFF")]
		[Address(RVA = "0x767720", Offset = "0x766320", VA = "0x180767720")]
		protected void AttachCommonAbilities()
		{
		}

		// Token: 0x0600FF00 RID: 65280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF00")]
		[Address(RVA = "0x76A3B0", Offset = "0x768FB0", VA = "0x18076A3B0")]
		protected void InitCommonAbilities()
		{
		}

		// Token: 0x0600FF01 RID: 65281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF01")]
		[Address(RVA = "0x767840", Offset = "0x766440", VA = "0x180767840")]
		protected void AttachRootDynamicAbilities()
		{
		}

		// Token: 0x0600FF02 RID: 65282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF02")]
		[Address(RVA = "0x76A670", Offset = "0x769270", VA = "0x18076A670")]
		protected void InitDynamicAbilities()
		{
		}

		// Token: 0x0600FF03 RID: 65283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF03")]
		[Address(RVA = "0x767060", Offset = "0x765C60", VA = "0x180767060", Slot = "179")]
		protected virtual void AssignDynamicAbility(IList<DynamicAbilityData> dynamicAbilities)
		{
		}

		// Token: 0x0600FF04 RID: 65284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF04")]
		[Address(RVA = "0x76F690", Offset = "0x76E290", VA = "0x18076F690")]
		private void _ClearRootDynamicAbilities()
		{
		}

		// Token: 0x0600FF05 RID: 65285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF05")]
		[Address(RVA = "0x76F500", Offset = "0x76E100", VA = "0x18076F500", Slot = "98")]
		protected override void UpdateBodyColor()
		{
		}

		// Token: 0x0600FF06 RID: 65286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF06")]
		[Address(RVA = "0x7691E0", Offset = "0x767DE0", VA = "0x1807691E0")]
		public static string GenerateTalentSignalId(string charId, string tmplId, string talentKey)
		{
			return null;
		}

		// Token: 0x0600FF07 RID: 65287 RVA: 0x00060F78 File Offset: 0x0005F178
		[Token(Token = "0x600FF07")]
		[Address(RVA = "0x767990", Offset = "0x766590", VA = "0x180767990")]
		protected bool CheckReborn(out Unit.RebornData rebornData)
		{
			return default(bool);
		}

		// Token: 0x0600FF08 RID: 65288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF08")]
		[Address(RVA = "0x767C70", Offset = "0x766870", VA = "0x180767C70", Slot = "180")]
		protected virtual void DoFakeDeath(Unit.RebornData rebornData)
		{
		}

		// Token: 0x0600FF09 RID: 65289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF09")]
		[Address(RVA = "0x767DF0", Offset = "0x7669F0", VA = "0x180767DF0", Slot = "181")]
		protected virtual void DoReborn(Unit.RebornData data)
		{
		}

		// Token: 0x0600FF0A RID: 65290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF0A")]
		[Address(RVA = "0x76A180", Offset = "0x768D80", VA = "0x18076A180")]
		public void InheritRebornHpRatio(FP hpRatio)
		{
		}

		// Token: 0x0600FF0B RID: 65291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF0B")]
		[Address(RVA = "0x76C7B0", Offset = "0x76B3B0", VA = "0x18076C7B0")]
		protected void OnStartAttack()
		{
		}

		// Token: 0x0600FF0C RID: 65292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF0C")]
		[Address(RVA = "0x76B470", Offset = "0x76A070", VA = "0x18076B470")]
		protected void OnFinishAttack()
		{
		}

		// Token: 0x0600FF0D RID: 65293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF0D")]
		[Address(RVA = "0x76B4D0", Offset = "0x76A0D0", VA = "0x18076B4D0", Slot = "119")]
		protected override void OnFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600FF0E RID: 65294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF0E")]
		[Address(RVA = "0x76C810", Offset = "0x76B410", VA = "0x18076C810", Slot = "182")]
		protected virtual void OnSwitchMode(UnitMode next, UnitMode last, bool restartFSM)
		{
		}

		// Token: 0x0600FF0F RID: 65295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF0F")]
		[Address(RVA = "0x76B2E0", Offset = "0x769EE0", VA = "0x18076B2E0", Slot = "123")]
		protected override void OnFaceChanged(Vector2 newDir, Vector2 oldDir, bool force, bool isIdle)
		{
		}

		// Token: 0x0600FF10 RID: 65296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF10")]
		[Address(RVA = "0x76AB40", Offset = "0x769740", VA = "0x18076AB40", Slot = "126")]
		public override void OnAttackRangeChanged()
		{
		}

		// Token: 0x0600FF11 RID: 65297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF11")]
		[Address(RVA = "0x76C930", Offset = "0x76B530", VA = "0x18076C930", Slot = "127")]
		protected override void OnTakeDamage(ref Modifier modifier, bool force)
		{
		}

		// Token: 0x0600FF12 RID: 65298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF12")]
		[Address(RVA = "0x76C4C0", Offset = "0x76B0C0", VA = "0x18076C4C0", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600FF13 RID: 65299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF13")]
		[Address(RVA = "0x76E5E0", Offset = "0x76D1E0", VA = "0x18076E5E0", Slot = "96")]
		public override void SwitchSide(SideType newSide)
		{
		}

		// Token: 0x0600FF14 RID: 65300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF14")]
		[Address(RVA = "0x76AFE0", Offset = "0x769BE0", VA = "0x18076AFE0", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600FF15 RID: 65301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF15")]
		[Address(RVA = "0x76AAB0", Offset = "0x7696B0", VA = "0x18076AAB0", Slot = "25")]
		public override void OnAllocate()
		{
		}

		// Token: 0x0600FF16 RID: 65302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF16")]
		[Address(RVA = "0x76C050", Offset = "0x76AC50", VA = "0x18076C050", Slot = "26")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0600FF17 RID: 65303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF17")]
		[Address(RVA = "0x76CA60", Offset = "0x76B660", VA = "0x18076CA60", Slot = "27")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600FF18 RID: 65304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF18")]
		[Address(RVA = "0x76BC10", Offset = "0x76A810", VA = "0x18076BC10", Slot = "28")]
		public override void OnLateTick(FP deltaTime)
		{
		}

		// Token: 0x0600FF19 RID: 65305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF19")]
		[Address(RVA = "0x76ACF0", Offset = "0x7698F0", VA = "0x18076ACF0", Slot = "183")]
		protected virtual void OnAwake()
		{
		}

		// Token: 0x0600FF1A RID: 65306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF1A")]
		[Address(RVA = "0x76D730", Offset = "0x76C330", VA = "0x18076D730", Slot = "139")]
		public void RecollectTalents()
		{
		}

		// Token: 0x0600FF1B RID: 65307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF1B")]
		[Address(RVA = "0x76B840", Offset = "0x76A440", VA = "0x18076B840", Slot = "117")]
		protected override void OnHpZero(bool noSource, bool skipReborn)
		{
		}

		// Token: 0x0600FF1C RID: 65308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF1C")]
		[Address(RVA = "0x76BE50", Offset = "0x76AA50", VA = "0x18076BE50", Slot = "184")]
		public virtual void OnReborn(Unit.RebornData rebornData)
		{
		}

		// Token: 0x0600FF1D RID: 65309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF1D")]
		[Address(RVA = "0x76ABB0", Offset = "0x7697B0", VA = "0x18076ABB0", Slot = "122")]
		protected override void OnAttributeDirty(AttributeType attributeType, FP oldValue)
		{
		}

		// Token: 0x0600FF1E RID: 65310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF1E")]
		[Address(RVA = "0x76D160", Offset = "0x76BD60", VA = "0x18076D160", Slot = "185")]
		public virtual void PopulateSnapshotToHashBuilder(HashCodeBuilder builder)
		{
		}

		// Token: 0x0600FF1F RID: 65311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF1F")]
		[Address(RVA = "0x76D3D0", Offset = "0x76BFD0", VA = "0x18076D3D0", Slot = "186")]
		public virtual void PopulateSnapshotToStrBuilder(StringBuilder builder)
		{
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x0600FF20 RID: 65312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022BE")]
		public virtual string hitRangeId
		{
			[Token(Token = "0x600FF20")]
			[Address(RVA = "0x772270", Offset = "0x770E70", VA = "0x180772270", Slot = "187")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x0600FF21 RID: 65313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022BF")]
		public Collider2D[] hitColliders
		{
			[Token(Token = "0x600FF21")]
			[Address(RVA = "0x772060", Offset = "0x770C60", VA = "0x180772060")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600FF22 RID: 65314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF22")]
		[Address(RVA = "0x76F800", Offset = "0x76E400", VA = "0x18076F800")]
		private void _InitUnitModes()
		{
		}

		// Token: 0x0600FF23 RID: 65315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF23")]
		[Address(RVA = "0x76F3C0", Offset = "0x76DFC0", VA = "0x18076F3C0")]
		public void UpdateAttackSelector(string blackboardKey, FP value, int modeIndex = -1)
		{
		}

		// Token: 0x0600FF24 RID: 65316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF24")]
		[Address(RVA = "0x770040", Offset = "0x76EC40", VA = "0x180770040")]
		private void _UpdateModeAttackSelector(UnitMode mode, string blackboardKey, FP value)
		{
		}

		// Token: 0x0600FF25 RID: 65317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF25")]
		[Address(RVA = "0x76EEF0", Offset = "0x76DAF0", VA = "0x18076EEF0")]
		public void UpdateAttackBlackboard(Blackboard newBlackboard, int modeIndex = -1)
		{
		}

		// Token: 0x0600FF26 RID: 65318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF26")]
		[Address(RVA = "0x76FF40", Offset = "0x76EB40", VA = "0x18076FF40")]
		private void _UpdateModeAttackBlackboard(UnitMode mode, Blackboard newBlackboard)
		{
		}

		// Token: 0x0600FF27 RID: 65319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF27")]
		[Address(RVA = "0x76F010", Offset = "0x76DC10", VA = "0x18076F010")]
		public void UpdateAttackRange(string newRangeId, int modeIndex)
		{
		}

		// Token: 0x0600FF28 RID: 65320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF28")]
		[Address(RVA = "0x76D7B0", Offset = "0x76C3B0", VA = "0x18076D7B0")]
		public void ReplaceAttackAndCombatDamageType(int modeIndex, DamageType damageType)
		{
		}

		// Token: 0x0600FF29 RID: 65321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF29")]
		[Address(RVA = "0x769C90", Offset = "0x768890", VA = "0x180769C90")]
		public string GetRangeIdByModeIndex(int modeIndex)
		{
			return null;
		}

		// Token: 0x0600FF2A RID: 65322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF2A")]
		[Address(RVA = "0x76DB70", Offset = "0x76C770", VA = "0x18076DB70", Slot = "87")]
		public override void SetGraphicHolderHeightOffset(FP heightOffset, FP duration, string audioSignalOnStop, bool useGlobalPos)
		{
		}

		// Token: 0x0600FF2B RID: 65323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF2B")]
		[Address(RVA = "0x768050", Offset = "0x766C50", VA = "0x180768050")]
		protected void DoSetGraphicHolderHeight(FP height, bool useGlobalPos = false)
		{
		}

		// Token: 0x0600FF2C RID: 65324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF2C")]
		[Address(RVA = "0x768390", Offset = "0x766F90", VA = "0x180768390")]
		protected void DoSetGraphicHolderPos(Vector3 graphicPos)
		{
		}

		// Token: 0x0600FF2D RID: 65325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF2D")]
		[Address(RVA = "0x76FDE0", Offset = "0x76E9E0", VA = "0x18076FDE0")]
		private void _ResetGraphicHolderHeight()
		{
		}

		// Token: 0x0600FF2E RID: 65326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF2E")]
		[Address(RVA = "0x76FA20", Offset = "0x76E620", VA = "0x18076FA20")]
		private void _KillGraphicHolderHeightTween()
		{
		}

		// Token: 0x0600FF2F RID: 65327 RVA: 0x00060F90 File Offset: 0x0005F190
		[Token(Token = "0x600FF2F")]
		[Address(RVA = "0x76E890", Offset = "0x76D490", VA = "0x18076E890")]
		public bool TryFindFirstCommonAbility(string searchName, out Ability result)
		{
			return default(bool);
		}

		// Token: 0x0600FF30 RID: 65328
		[Token(Token = "0x600FF30")]
		public abstract string GetBakeMuzzleDataPath();

		// Token: 0x0600FF31 RID: 65329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF31")]
		[Address(RVA = "0x76FE70", Offset = "0x76EA70", VA = "0x18076FE70")]
		private void _TouchBakeMuzzleData()
		{
		}

		// Token: 0x0600FF32 RID: 65330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF32")]
		[Address(RVA = "0x770180", Offset = "0x76ED80", VA = "0x180770180")]
		protected Unit()
		{
		}

		// Token: 0x0600FF35 RID: 65333 RVA: 0x00060FC0 File Offset: 0x0005F1C0
		[Token(Token = "0x600FF35")]
		[Address(RVA = "0x76ED10", Offset = "0x76D910", VA = "0x18076ED10")]
		private int <>xLuaBaseProxy_get_faceSign()
		{
			return 0;
		}

		// Token: 0x0600FF36 RID: 65334 RVA: 0x00060FD8 File Offset: 0x0005F1D8
		[Token(Token = "0x600FF36")]
		[Address(RVA = "0x76ED20", Offset = "0x76D920", VA = "0x18076ED20")]
		private bool <>xLuaBaseProxy_get_faceToBack()
		{
			return default(bool);
		}

		// Token: 0x0600FF37 RID: 65335 RVA: 0x00060FF0 File Offset: 0x0005F1F0
		[Token(Token = "0x600FF37")]
		[Address(RVA = "0x76ED30", Offset = "0x76D930", VA = "0x18076ED30")]
		private bool <>xLuaBaseProxy_get_faceToDown()
		{
			return default(bool);
		}

		// Token: 0x0600FF38 RID: 65336 RVA: 0x00061008 File Offset: 0x0005F208
		[Token(Token = "0x600FF38")]
		[Address(RVA = "0x76ED00", Offset = "0x76D900", VA = "0x18076ED00")]
		private SharedConsts.Direction <>xLuaBaseProxy_get_faceLOrR()
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x0600FF39 RID: 65337 RVA: 0x00061020 File Offset: 0x0005F220
		[Token(Token = "0x600FF39")]
		[Address(RVA = "0x76ED70", Offset = "0x76D970", VA = "0x18076ED70")]
		private bool <>xLuaBaseProxy_get_isHidden()
		{
			return default(bool);
		}

		// Token: 0x0600FF3A RID: 65338 RVA: 0x00061038 File Offset: 0x0005F238
		[Token(Token = "0x600FF3A")]
		[Address(RVA = "0x76ED40", Offset = "0x76D940", VA = "0x18076ED40")]
		private float <>xLuaBaseProxy_get_graphicBoundRadius()
		{
			return 0f;
		}

		// Token: 0x0600FF3B RID: 65339 RVA: 0x00061050 File Offset: 0x0005F250
		[Token(Token = "0x600FF3B")]
		[Address(RVA = "0x76ECC0", Offset = "0x76D8C0", VA = "0x18076ECC0")]
		private Color <>xLuaBaseProxy_get_defaultBodyColor()
		{
			return default(Color);
		}

		// Token: 0x0600FF3C RID: 65340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF3C")]
		[Address(RVA = "0x76ECB0", Offset = "0x76D8B0", VA = "0x18076ECB0")]
		private Transform <>xLuaBaseProxy_get_bodyTransform()
		{
			return null;
		}

		// Token: 0x0600FF3D RID: 65341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF3D")]
		[Address(RVA = "0x76ED60", Offset = "0x76D960", VA = "0x18076ED60")]
		private Transform <>xLuaBaseProxy_get_graphicTransform()
		{
			return null;
		}

		// Token: 0x0600FF3E RID: 65342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF3E")]
		[Address(RVA = "0x76ED50", Offset = "0x76D950", VA = "0x18076ED50")]
		private Transform <>xLuaBaseProxy_get_graphicFootTransform()
		{
			return null;
		}

		// Token: 0x0600FF3F RID: 65343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF3F")]
		[Address(RVA = "0x76ECF0", Offset = "0x76D8F0", VA = "0x18076ECF0")]
		private Transform <>xLuaBaseProxy_get_effectTransform()
		{
			return null;
		}

		// Token: 0x0600FF40 RID: 65344 RVA: 0x00061068 File Offset: 0x0005F268
		[Token(Token = "0x600FF40")]
		[Address(RVA = "0x76EC90", Offset = "0x76D890", VA = "0x18076EC90")]
		private bool <>xLuaBaseProxy_TryIgnoreEffect(string P0)
		{
			return default(bool);
		}

		// Token: 0x0600FF41 RID: 65345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF41")]
		[Address(RVA = "0x76EBB0", Offset = "0x76D7B0", VA = "0x18076EBB0")]
		private MountPoint <>xLuaBaseProxy_GetMountPoint(Entity.MountPointType P0)
		{
			return null;
		}

		// Token: 0x0600FF42 RID: 65346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF42")]
		[Address(RVA = "0x76EBA0", Offset = "0x76D7A0", VA = "0x18076EBA0")]
		private MountPoint <>xLuaBaseProxy_GetMountPointForEffect(Entity.MountPointType P0)
		{
			return null;
		}

		// Token: 0x0600FF43 RID: 65347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF43")]
		[Address(RVA = "0x76EC30", Offset = "0x76D830", VA = "0x18076EC30")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600FF44 RID: 65348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF44")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnPostInit()
		{
		}

		// Token: 0x0600FF45 RID: 65349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF45")]
		[Address(RVA = "0x76ECA0", Offset = "0x76D8A0", VA = "0x18076ECA0")]
		private void <>xLuaBaseProxy_UpdateBodyColor()
		{
		}

		// Token: 0x0600FF46 RID: 65350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF46")]
		[Address(RVA = "0x76EC10", Offset = "0x76D810", VA = "0x18076EC10")]
		private void <>xLuaBaseProxy_OnFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600FF47 RID: 65351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF47")]
		[Address(RVA = "0x76EBF0", Offset = "0x76D7F0", VA = "0x18076EBF0")]
		private void <>xLuaBaseProxy_OnFaceChanged(Vector2 P0, Vector2 P1, bool P2, bool P3)
		{
		}

		// Token: 0x0600FF48 RID: 65352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF48")]
		[Address(RVA = "0x76EBC0", Offset = "0x76D7C0", VA = "0x18076EBC0")]
		private void <>xLuaBaseProxy_OnAttackRangeChanged()
		{
		}

		// Token: 0x0600FF49 RID: 65353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF49")]
		[Address(RVA = "0x76EC60", Offset = "0x76D860", VA = "0x18076EC60")]
		private void <>xLuaBaseProxy_OnTakeDamage(ref Modifier P0, bool P1)
		{
		}

		// Token: 0x0600FF4A RID: 65354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF4A")]
		[Address(RVA = "0x76EC50", Offset = "0x76D850", VA = "0x18076EC50")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600FF4B RID: 65355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF4B")]
		[Address(RVA = "0x76EC80", Offset = "0x76D880", VA = "0x18076EC80")]
		private void <>xLuaBaseProxy_SwitchSide(SideType P0)
		{
		}

		// Token: 0x0600FF4C RID: 65356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF4C")]
		[Address(RVA = "0x76EBE0", Offset = "0x76D7E0", VA = "0x18076EBE0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600FF4D RID: 65357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF4D")]
		[Address(RVA = "0x5FDA10", Offset = "0x5FC610", VA = "0x1805FDA10")]
		private void <>xLuaBaseProxy_OnAllocate()
		{
		}

		// Token: 0x0600FF4E RID: 65358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF4E")]
		[Address(RVA = "0x76EC40", Offset = "0x76D840", VA = "0x18076EC40")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0600FF4F RID: 65359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF4F")]
		[Address(RVA = "0x76EC70", Offset = "0x76D870", VA = "0x18076EC70")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600FF50 RID: 65360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF50")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
		private void <>xLuaBaseProxy_OnLateTick(FP P0)
		{
		}

		// Token: 0x0600FF51 RID: 65361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF51")]
		[Address(RVA = "0x76EC20", Offset = "0x76D820", VA = "0x18076EC20")]
		private void <>xLuaBaseProxy_OnHpZero(bool P0, bool P1)
		{
		}

		// Token: 0x0600FF52 RID: 65362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF52")]
		[Address(RVA = "0x76EBD0", Offset = "0x76D7D0", VA = "0x18076EBD0")]
		private void <>xLuaBaseProxy_OnAttributeDirty(AttributeType P0, FP P1)
		{
		}

		// Token: 0x04011ADF RID: 72415
		[Token(Token = "0x4011ADF")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		protected UnitAnimator _animator;

		// Token: 0x04011AE0 RID: 72416
		[Token(Token = "0x4011AE0")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		protected UnitMode[] _modes;

		// Token: 0x04011AE1 RID: 72417
		[Token(Token = "0x4011AE1")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Ability[] _commonAbilities;

		// Token: 0x04011AE2 RID: 72418
		[Token(Token = "0x4011AE2")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Transform _uiMountPoint;

		// Token: 0x04011AE3 RID: 72419
		[Token(Token = "0x4011AE3")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private Transform _effectTransform;

		// Token: 0x04011AE4 RID: 72420
		[Token(Token = "0x4011AE4")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private ShadowController _shadow;

		// Token: 0x04011AE5 RID: 72421
		[Token(Token = "0x4011AE5")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Color _defaultBodyColor;

		// Token: 0x04011AE6 RID: 72422
		[Token(Token = "0x4011AE6")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private bool _hideShadowOnRecycle;

		// Token: 0x04011AE7 RID: 72423
		[Token(Token = "0x4011AE7")]
		[FieldOffset(Offset = "0x1C4")]
		[SerializeField]
		private float _overrideGraphicBound;

		// Token: 0x04011AE8 RID: 72424
		[Token(Token = "0x4011AE8")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private Unit.StringReplacePair[] _hudPluginReplacePairs;

		// Token: 0x04011AE9 RID: 72425
		[Token(Token = "0x4011AE9")]
		[FieldOffset(Offset = "0x1D0")]
		private Unit.PalsyController m_palsyController;

		// Token: 0x04011AEA RID: 72426
		[Token(Token = "0x4011AEA")]
		[FieldOffset(Offset = "0x1D8")]
		private GameObject _colliderSprite;

		// Token: 0x04011AEB RID: 72427
		[Token(Token = "0x4011AEB")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private bool _showDebugName;

		// Token: 0x04011AEC RID: 72428
		[Token(Token = "0x4011AEC")]
		[FieldOffset(Offset = "0x1E1")]
		private bool m_awaked;

		// Token: 0x04011AED RID: 72429
		[Token(Token = "0x4011AED")]
		[FieldOffset(Offset = "0x1E8")]
		private UnitMode m_currentMode;

		// Token: 0x04011AEE RID: 72430
		[Token(Token = "0x4011AEE")]
		[FieldOffset(Offset = "0x1F0")]
		private Ability m_overrideAttack;

		// Token: 0x04011AEF RID: 72431
		[Token(Token = "0x4011AEF")]
		[FieldOffset(Offset = "0x1F8")]
		private TargetTrigger m_overrideTrigger;

		// Token: 0x04011AF0 RID: 72432
		[Token(Token = "0x4011AF0")]
		[FieldOffset(Offset = "0x200")]
		private Ability m_overrideCombat;

		// Token: 0x04011AF1 RID: 72433
		[Token(Token = "0x4011AF1")]
		[FieldOffset(Offset = "0x208")]
		private Color m_defaultBodyColor;

		// Token: 0x04011AF2 RID: 72434
		[Token(Token = "0x4011AF2")]
		[FieldOffset(Offset = "0x218")]
		private List<MountPoint> m_mountPoints;

		// Token: 0x04011AF3 RID: 72435
		[Token(Token = "0x4011AF3")]
		[FieldOffset(Offset = "0x220")]
		private Vector3 m_originGraphicHolderPos;

		// Token: 0x04011AF4 RID: 72436
		[Token(Token = "0x4011AF4")]
		[FieldOffset(Offset = "0x230")]
		private ITweenHandler m_graphicHolderHeightTween;

		// Token: 0x04011AF5 RID: 72437
		[Token(Token = "0x4011AF5")]
		[FieldOffset(Offset = "0x238")]
		private Collider2D[] m_hitColliers;

		// Token: 0x04011AF8 RID: 72440
		[Token(Token = "0x4011AF8")]
		[FieldOffset(Offset = "0x250")]
		private List<KeyValuePair<Ability, Blackboard>> m_rootDynamicAbilities;

		// Token: 0x04011AF9 RID: 72441
		[Token(Token = "0x4011AF9")]
		[FieldOffset(Offset = "0x258")]
		protected ObjectPtr<Buff> m_spShowedBuff;

		// Token: 0x04011AFA RID: 72442
		[Token(Token = "0x4011AFA")]
		[FieldOffset(Offset = "0x268")]
		private bool m_isSpShowedBuffCountdown;

		// Token: 0x04011AFB RID: 72443
		[Token(Token = "0x4011AFB")]
		[FieldOffset(Offset = "0x26C")]
		private AdvancedSpShowBuffType m_advancedShowType;

		// Token: 0x04011AFC RID: 72444
		[Token(Token = "0x4011AFC")]
		[FieldOffset(Offset = "0x270")]
		private bool m_attackRangeDirty;

		// Token: 0x04011AFD RID: 72445
		[Token(Token = "0x4011AFD")]
		[FieldOffset(Offset = "0x278")]
		private List<Tile> m_attackRangeTiles;

		// Token: 0x04011AFE RID: 72446
		[Token(Token = "0x4011AFE")]
		[FieldOffset(Offset = "0x280")]
		private bool m_originAttackRangeDirty;

		// Token: 0x04011AFF RID: 72447
		[Token(Token = "0x4011AFF")]
		[FieldOffset(Offset = "0x288")]
		private List<Tile> m_originAttackRangeTiles;

		// Token: 0x04011B00 RID: 72448
		[Token(Token = "0x4011B00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_palsyController;

		// Token: 0x04011B01 RID: 72449
		[Token(Token = "0x4011B01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_defaultMode;

		// Token: 0x04011B02 RID: 72450
		[Token(Token = "0x4011B02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currentMode;

		// Token: 0x04011B03 RID: 72451
		[Token(Token = "0x4011B03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_needUpdateRootHeight;

		// Token: 0x04011B04 RID: 72452
		[Token(Token = "0x4011B04")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_colliderSprite;

		// Token: 0x04011B05 RID: 72453
		[Token(Token = "0x4011B05")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_currentModeIndex;

		// Token: 0x04011B06 RID: 72454
		[Token(Token = "0x4011B06")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_faceSign;

		// Token: 0x04011B07 RID: 72455
		[Token(Token = "0x4011B07")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_faceToBack;

		// Token: 0x04011B08 RID: 72456
		[Token(Token = "0x4011B08")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_faceToDown;

		// Token: 0x04011B09 RID: 72457
		[Token(Token = "0x4011B09")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_faceLOrR;

		// Token: 0x04011B0A RID: 72458
		[Token(Token = "0x4011B0A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_talentRange;

		// Token: 0x04011B0B RID: 72459
		[Token(Token = "0x4011B0B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_combat;

		// Token: 0x04011B0C RID: 72460
		[Token(Token = "0x4011B0C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_hasCombat;

		// Token: 0x04011B0D RID: 72461
		[Token(Token = "0x4011B0D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_attack;

		// Token: 0x04011B0E RID: 72462
		[Token(Token = "0x4011B0E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_hasAttack;

		// Token: 0x04011B0F RID: 72463
		[Token(Token = "0x4011B0F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_attackTrigger;

		// Token: 0x04011B10 RID: 72464
		[Token(Token = "0x4011B10")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_allApplyWay;

		// Token: 0x04011B11 RID: 72465
		[Token(Token = "0x4011B11")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isHidden;

		// Token: 0x04011B12 RID: 72466
		[Token(Token = "0x4011B12")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_isMovingBySelf;

		// Token: 0x04011B13 RID: 72467
		[Token(Token = "0x4011B13")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_showDebugName;

		// Token: 0x04011B14 RID: 72468
		[Token(Token = "0x4011B14")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_hasRangeToShow;

		// Token: 0x04011B15 RID: 72469
		[Token(Token = "0x4011B15")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_hasExtraRangeToShow;

		// Token: 0x04011B16 RID: 72470
		[Token(Token = "0x4011B16")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x04011B17 RID: 72471
		[Token(Token = "0x4011B17")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_extraRangesToShow;

		// Token: 0x04011B18 RID: 72472
		[Token(Token = "0x4011B18")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_defaultRangeId;

		// Token: 0x04011B19 RID: 72473
		[Token(Token = "0x4011B19")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_graphicBoundRadius;

		// Token: 0x04011B1A RID: 72474
		[Token(Token = "0x4011B1A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_hideUIAttackRange;

		// Token: 0x04011B1B RID: 72475
		[Token(Token = "0x4011B1B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_animator;

		// Token: 0x04011B1C RID: 72476
		[Token(Token = "0x4011B1C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_animatorHooker;

		// Token: 0x04011B1D RID: 72477
		[Token(Token = "0x4011B1D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x04011B1E RID: 72478
		[Token(Token = "0x4011B1E")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x04011B1F RID: 72479
		[Token(Token = "0x4011B1F")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_defaultBodyColor;

		// Token: 0x04011B20 RID: 72480
		[Token(Token = "0x4011B20")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_originDefaultBodyColor;

		// Token: 0x04011B21 RID: 72481
		[Token(Token = "0x4011B21")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_bodyTransform;

		// Token: 0x04011B22 RID: 72482
		[Token(Token = "0x4011B22")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_graphicTransform;

		// Token: 0x04011B23 RID: 72483
		[Token(Token = "0x4011B23")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_graphicFootTransform;

		// Token: 0x04011B24 RID: 72484
		[Token(Token = "0x4011B24")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_graphicHolderTransform;

		// Token: 0x04011B25 RID: 72485
		[Token(Token = "0x4011B25")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_uiPoint;

		// Token: 0x04011B26 RID: 72486
		[Token(Token = "0x4011B26")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_hitPoint;

		// Token: 0x04011B27 RID: 72487
		[Token(Token = "0x4011B27")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_footPoint;

		// Token: 0x04011B28 RID: 72488
		[Token(Token = "0x4011B28")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_muzzlePoint;

		// Token: 0x04011B29 RID: 72489
		[Token(Token = "0x4011B29")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_headPoint;

		// Token: 0x04011B2A RID: 72490
		[Token(Token = "0x4011B2A")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_effectTransform;

		// Token: 0x04011B2B RID: 72491
		[Token(Token = "0x4011B2B")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04011B2C RID: 72492
		[Token(Token = "0x4011B2C")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_hpToShow;

		// Token: 0x04011B2D RID: 72493
		[Token(Token = "0x4011B2D")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_shieldToShow;

		// Token: 0x04011B2E RID: 72494
		[Token(Token = "0x4011B2E")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_hpRatioToShow;

		// Token: 0x04011B2F RID: 72495
		[Token(Token = "0x4011B2F")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_epArrayToShow;

		// Token: 0x04011B30 RID: 72496
		[Token(Token = "0x4011B30")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_minEpTypeToShow;

		// Token: 0x04011B31 RID: 72497
		[Token(Token = "0x4011B31")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_shadowController;

		// Token: 0x04011B32 RID: 72498
		[Token(Token = "0x4011B32")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_get_graphicHeight;

		// Token: 0x04011B33 RID: 72499
		[Token(Token = "0x4011B33")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_isDummy;

		// Token: 0x04011B34 RID: 72500
		[Token(Token = "0x4011B34")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_set_isDummy;

		// Token: 0x04011B35 RID: 72501
		[Token(Token = "0x4011B35")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_get_talents;

		// Token: 0x04011B36 RID: 72502
		[Token(Token = "0x4011B36")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_set_talents;

		// Token: 0x04011B37 RID: 72503
		[Token(Token = "0x4011B37")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_FetchHost;

		// Token: 0x04011B38 RID: 72504
		[Token(Token = "0x4011B38")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_SetSpShowedBuff;

		// Token: 0x04011B39 RID: 72505
		[Token(Token = "0x4011B39")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix1_SetSpShowedBuff;

		// Token: 0x04011B3A RID: 72506
		[Token(Token = "0x4011B3A")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_get_hudOffset;

		// Token: 0x04011B3B RID: 72507
		[Token(Token = "0x4011B3B")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_get_hasSpShowedBuff;

		// Token: 0x04011B3C RID: 72508
		[Token(Token = "0x4011B3C")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_get_isSpShowedBuffCountdown;

		// Token: 0x04011B3D RID: 72509
		[Token(Token = "0x4011B3D")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_get_spShowedBuffProgress;

		// Token: 0x04011B3E RID: 72510
		[Token(Token = "0x4011B3E")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_get_hudPluginMask;

		// Token: 0x04011B3F RID: 72511
		[Token(Token = "0x4011B3F")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_GatherHudPluginTypes;

		// Token: 0x04011B40 RID: 72512
		[Token(Token = "0x4011B40")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_ReplaceHudPluginTypes;

		// Token: 0x04011B41 RID: 72513
		[Token(Token = "0x4011B41")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_get_enableNormalHud;

		// Token: 0x04011B42 RID: 72514
		[Token(Token = "0x4011B42")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_get_attackRangeTiles;

		// Token: 0x04011B43 RID: 72515
		[Token(Token = "0x4011B43")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_get_originAttackRangeTiles;

		// Token: 0x04011B44 RID: 72516
		[Token(Token = "0x4011B44")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_GetRangeOfMode;

		// Token: 0x04011B45 RID: 72517
		[Token(Token = "0x4011B45")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_ToggleMode;

		// Token: 0x04011B46 RID: 72518
		[Token(Token = "0x4011B46")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_SwitchMode;

		// Token: 0x04011B47 RID: 72519
		[Token(Token = "0x4011B47")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix1_SwitchMode;

		// Token: 0x04011B48 RID: 72520
		[Token(Token = "0x4011B48")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_SwitchToDefaultMode;

		// Token: 0x04011B49 RID: 72521
		[Token(Token = "0x4011B49")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_EnableShadow;

		// Token: 0x04011B4A RID: 72522
		[Token(Token = "0x4011B4A")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_EnableHoldEffect;

		// Token: 0x04011B4B RID: 72523
		[Token(Token = "0x4011B4B")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_EnableVisualPart;

		// Token: 0x04011B4C RID: 72524
		[Token(Token = "0x4011B4C")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_SetSpineSkin;

		// Token: 0x04011B4D RID: 72525
		[Token(Token = "0x4011B4D")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_GetCurrentModeSelector;

		// Token: 0x04011B4E RID: 72526
		[Token(Token = "0x4011B4E")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_PlayAnimation;

		// Token: 0x04011B4F RID: 72527
		[Token(Token = "0x4011B4F")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_ContainsAnimation;

		// Token: 0x04011B50 RID: 72528
		[Token(Token = "0x4011B50")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_PlayAnimationInFixedTime;

		// Token: 0x04011B51 RID: 72529
		[Token(Token = "0x4011B51")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_ModifyDefaultColor;

		// Token: 0x04011B52 RID: 72530
		[Token(Token = "0x4011B52")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix1_PlayAnimation;

		// Token: 0x04011B53 RID: 72531
		[Token(Token = "0x4011B53")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_UpdateAnimPlaybackSpeed;

		// Token: 0x04011B54 RID: 72532
		[Token(Token = "0x4011B54")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_GetAnimationTime;

		// Token: 0x04011B55 RID: 72533
		[Token(Token = "0x4011B55")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix1_GetAnimationTime;

		// Token: 0x04011B56 RID: 72534
		[Token(Token = "0x4011B56")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_TryIgnoreEffect;

		// Token: 0x04011B57 RID: 72535
		[Token(Token = "0x4011B57")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_GetAnimatorHooker;

		// Token: 0x04011B58 RID: 72536
		[Token(Token = "0x4011B58")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04011B59 RID: 72537
		[Token(Token = "0x4011B59")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_GetMountPoint;

		// Token: 0x04011B5A RID: 72538
		[Token(Token = "0x4011B5A")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_GetMountPointForEffect;

		// Token: 0x04011B5B RID: 72539
		[Token(Token = "0x4011B5B")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__LazyLoadMountPoint;

		// Token: 0x04011B5C RID: 72540
		[Token(Token = "0x4011B5C")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_GetAttackBlackboard;

		// Token: 0x04011B5D RID: 72541
		[Token(Token = "0x4011B5D")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_OverrideAttack;

		// Token: 0x04011B5E RID: 72542
		[Token(Token = "0x4011B5E")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_OverrideCombat;

		// Token: 0x04011B5F RID: 72543
		[Token(Token = "0x4011B5F")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04011B60 RID: 72544
		[Token(Token = "0x4011B60")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04011B61 RID: 72545
		[Token(Token = "0x4011B61")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04011B62 RID: 72546
		[Token(Token = "0x4011B62")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04011B63 RID: 72547
		[Token(Token = "0x4011B63")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_GatherAbilities;

		// Token: 0x04011B64 RID: 72548
		[Token(Token = "0x4011B64")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_IsAttackRangeDirty;

		// Token: 0x04011B65 RID: 72549
		[Token(Token = "0x4011B65")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_GetModeRangeId;

		// Token: 0x04011B66 RID: 72550
		[Token(Token = "0x4011B66")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_GetModeRangeRadius;

		// Token: 0x04011B67 RID: 72551
		[Token(Token = "0x4011B67")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x04011B68 RID: 72552
		[Token(Token = "0x4011B68")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_GetCurrentAttackOrCombatAbility;

		// Token: 0x04011B69 RID: 72553
		[Token(Token = "0x4011B69")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011B6A RID: 72554
		[Token(Token = "0x4011B6A")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_OnPostInit;

		// Token: 0x04011B6B RID: 72555
		[Token(Token = "0x4011B6B")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix2_SwitchMode;

		// Token: 0x04011B6C RID: 72556
		[Token(Token = "0x4011B6C")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_ActivateMode;

		// Token: 0x04011B6D RID: 72557
		[Token(Token = "0x4011B6D")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_InactiveMode;

		// Token: 0x04011B6E RID: 72558
		[Token(Token = "0x4011B6E")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_AttachCommonAbilities;

		// Token: 0x04011B6F RID: 72559
		[Token(Token = "0x4011B6F")]
		[FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_InitCommonAbilities;

		// Token: 0x04011B70 RID: 72560
		[Token(Token = "0x4011B70")]
		[FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_AttachRootDynamicAbilities;

		// Token: 0x04011B71 RID: 72561
		[Token(Token = "0x4011B71")]
		[FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_InitDynamicAbilities;

		// Token: 0x04011B72 RID: 72562
		[Token(Token = "0x4011B72")]
		[FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_AssignDynamicAbility;

		// Token: 0x04011B73 RID: 72563
		[Token(Token = "0x4011B73")]
		[FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0__ClearRootDynamicAbilities;

		// Token: 0x04011B74 RID: 72564
		[Token(Token = "0x4011B74")]
		[FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_UpdateBodyColor;

		// Token: 0x04011B75 RID: 72565
		[Token(Token = "0x4011B75")]
		[FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_GenerateTalentSignalId;

		// Token: 0x04011B76 RID: 72566
		[Token(Token = "0x4011B76")]
		[FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_CheckReborn;

		// Token: 0x04011B77 RID: 72567
		[Token(Token = "0x4011B77")]
		[FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_DoFakeDeath;

		// Token: 0x04011B78 RID: 72568
		[Token(Token = "0x4011B78")]
		[FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_DoReborn;

		// Token: 0x04011B79 RID: 72569
		[Token(Token = "0x4011B79")]
		[FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_InheritRebornHpRatio;

		// Token: 0x04011B7A RID: 72570
		[Token(Token = "0x4011B7A")]
		[FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_OnStartAttack;

		// Token: 0x04011B7B RID: 72571
		[Token(Token = "0x4011B7B")]
		[FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_OnFinishAttack;

		// Token: 0x04011B7C RID: 72572
		[Token(Token = "0x4011B7C")]
		[FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04011B7D RID: 72573
		[Token(Token = "0x4011B7D")]
		[FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_OnSwitchMode;

		// Token: 0x04011B7E RID: 72574
		[Token(Token = "0x4011B7E")]
		[FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_OnFaceChanged;

		// Token: 0x04011B7F RID: 72575
		[Token(Token = "0x4011B7F")]
		[FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_OnAttackRangeChanged;

		// Token: 0x04011B80 RID: 72576
		[Token(Token = "0x4011B80")]
		[FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x04011B81 RID: 72577
		[Token(Token = "0x4011B81")]
		[FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04011B82 RID: 72578
		[Token(Token = "0x4011B82")]
		[FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_SwitchSide;

		// Token: 0x04011B83 RID: 72579
		[Token(Token = "0x4011B83")]
		[FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04011B84 RID: 72580
		[Token(Token = "0x4011B84")]
		[FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x04011B85 RID: 72581
		[Token(Token = "0x4011B85")]
		[FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04011B86 RID: 72582
		[Token(Token = "0x4011B86")]
		[FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011B87 RID: 72583
		[Token(Token = "0x4011B87")]
		[FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_OnLateTick;

		// Token: 0x04011B88 RID: 72584
		[Token(Token = "0x4011B88")]
		[FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix0_OnAwake;

		// Token: 0x04011B89 RID: 72585
		[Token(Token = "0x4011B89")]
		[FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_RecollectTalents;

		// Token: 0x04011B8A RID: 72586
		[Token(Token = "0x4011B8A")]
		[FieldOffset(Offset = "0x450")]
		private static DelegateBridge __Hotfix0_OnHpZero;

		// Token: 0x04011B8B RID: 72587
		[Token(Token = "0x4011B8B")]
		[FieldOffset(Offset = "0x458")]
		private static DelegateBridge __Hotfix0_OnReborn;

		// Token: 0x04011B8C RID: 72588
		[Token(Token = "0x4011B8C")]
		[FieldOffset(Offset = "0x460")]
		private static DelegateBridge __Hotfix0_OnAttributeDirty;

		// Token: 0x04011B8D RID: 72589
		[Token(Token = "0x4011B8D")]
		[FieldOffset(Offset = "0x468")]
		private static DelegateBridge __Hotfix0_PopulateSnapshotToHashBuilder;

		// Token: 0x04011B8E RID: 72590
		[Token(Token = "0x4011B8E")]
		[FieldOffset(Offset = "0x470")]
		private static DelegateBridge __Hotfix0_PopulateSnapshotToStrBuilder;

		// Token: 0x04011B8F RID: 72591
		[Token(Token = "0x4011B8F")]
		[FieldOffset(Offset = "0x478")]
		private static DelegateBridge __Hotfix0_get_hitRangeId;

		// Token: 0x04011B90 RID: 72592
		[Token(Token = "0x4011B90")]
		[FieldOffset(Offset = "0x480")]
		private static DelegateBridge __Hotfix0_get_hitColliders;

		// Token: 0x04011B91 RID: 72593
		[Token(Token = "0x4011B91")]
		[FieldOffset(Offset = "0x488")]
		private static DelegateBridge __Hotfix0__InitUnitModes;

		// Token: 0x04011B92 RID: 72594
		[Token(Token = "0x4011B92")]
		[FieldOffset(Offset = "0x490")]
		private static DelegateBridge __Hotfix0_UpdateAttackSelector;

		// Token: 0x04011B93 RID: 72595
		[Token(Token = "0x4011B93")]
		[FieldOffset(Offset = "0x498")]
		private static DelegateBridge __Hotfix0__UpdateModeAttackSelector;

		// Token: 0x04011B94 RID: 72596
		[Token(Token = "0x4011B94")]
		[FieldOffset(Offset = "0x4A0")]
		private static DelegateBridge __Hotfix0_UpdateAttackBlackboard;

		// Token: 0x04011B95 RID: 72597
		[Token(Token = "0x4011B95")]
		[FieldOffset(Offset = "0x4A8")]
		private static DelegateBridge __Hotfix0__UpdateModeAttackBlackboard;

		// Token: 0x04011B96 RID: 72598
		[Token(Token = "0x4011B96")]
		[FieldOffset(Offset = "0x4B0")]
		private static DelegateBridge __Hotfix0_UpdateAttackRange;

		// Token: 0x04011B97 RID: 72599
		[Token(Token = "0x4011B97")]
		[FieldOffset(Offset = "0x4B8")]
		private static DelegateBridge __Hotfix0_ReplaceAttackAndCombatDamageType;

		// Token: 0x04011B98 RID: 72600
		[Token(Token = "0x4011B98")]
		[FieldOffset(Offset = "0x4C0")]
		private static DelegateBridge __Hotfix0_GetRangeIdByModeIndex;

		// Token: 0x04011B99 RID: 72601
		[Token(Token = "0x4011B99")]
		[FieldOffset(Offset = "0x4C8")]
		private static DelegateBridge __Hotfix0_SetGraphicHolderHeightOffset;

		// Token: 0x04011B9A RID: 72602
		[Token(Token = "0x4011B9A")]
		[FieldOffset(Offset = "0x4D0")]
		private static DelegateBridge __Hotfix0_DoSetGraphicHolderHeight;

		// Token: 0x04011B9B RID: 72603
		[Token(Token = "0x4011B9B")]
		[FieldOffset(Offset = "0x4D8")]
		private static DelegateBridge __Hotfix0_DoSetGraphicHolderPos;

		// Token: 0x04011B9C RID: 72604
		[Token(Token = "0x4011B9C")]
		[FieldOffset(Offset = "0x4E0")]
		private static DelegateBridge __Hotfix0__ResetGraphicHolderHeight;

		// Token: 0x04011B9D RID: 72605
		[Token(Token = "0x4011B9D")]
		[FieldOffset(Offset = "0x4E8")]
		private static DelegateBridge __Hotfix0__KillGraphicHolderHeightTween;

		// Token: 0x04011B9E RID: 72606
		[Token(Token = "0x4011B9E")]
		[FieldOffset(Offset = "0x4F0")]
		private static DelegateBridge __Hotfix0_TryFindFirstCommonAbility;

		// Token: 0x04011B9F RID: 72607
		[Token(Token = "0x4011B9F")]
		[FieldOffset(Offset = "0x4F8")]
		private static DelegateBridge __Hotfix0__TouchBakeMuzzleData;

		// Token: 0x04011BA0 RID: 72608
		[Token(Token = "0x4011BA0")]
		[FieldOffset(Offset = "0x500")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200261B RID: 9755
		[Token(Token = "0x200261B")]
		public struct RebornData
		{
			// Token: 0x04011BA1 RID: 72609
			[Token(Token = "0x4011BA1")]
			[FieldOffset(Offset = "0x0")]
			public int modeIndex;

			// Token: 0x04011BA2 RID: 72610
			[Token(Token = "0x4011BA2")]
			[FieldOffset(Offset = "0x4")]
			public bool keepAlive;

			// Token: 0x04011BA3 RID: 72611
			[Token(Token = "0x4011BA3")]
			[FieldOffset(Offset = "0x8")]
			public FP rebornTime;

			// Token: 0x04011BA4 RID: 72612
			[Token(Token = "0x4011BA4")]
			[FieldOffset(Offset = "0x10")]
			public FP hpRatio;

			// Token: 0x04011BA5 RID: 72613
			[Token(Token = "0x4011BA5")]
			[FieldOffset(Offset = "0x18")]
			public BuffData[] buffs;

			// Token: 0x04011BA6 RID: 72614
			[Token(Token = "0x4011BA6")]
			[FieldOffset(Offset = "0x20")]
			public Blackboard blackboard;

			// Token: 0x04011BA7 RID: 72615
			[Token(Token = "0x4011BA7")]
			[FieldOffset(Offset = "0x28")]
			public string[] effects;

			// Token: 0x04011BA8 RID: 72616
			[Token(Token = "0x4011BA8")]
			[FieldOffset(Offset = "0x30")]
			public FP hpRechargeRatio;

			// Token: 0x04011BA9 RID: 72617
			[Token(Token = "0x4011BA9")]
			[FieldOffset(Offset = "0x38")]
			public List<string> buffsRetainedWhenReborn;

			// Token: 0x04011BAA RID: 72618
			[Token(Token = "0x4011BAA")]
			[FieldOffset(Offset = "0x40")]
			public bool clearEffectsAfterReborn;

			// Token: 0x04011BAB RID: 72619
			[Token(Token = "0x4011BAB")]
			[FieldOffset(Offset = "0x41")]
			public bool rebornAfterWave;

			// Token: 0x04011BAC RID: 72620
			[Token(Token = "0x4011BAC")]
			[FieldOffset(Offset = "0x44")]
			public int rebornAfterWaveCnt;
		}

		// Token: 0x0200261C RID: 9756
		[Token(Token = "0x200261C")]
		public class PalsyController : IHotfixable
		{
			// Token: 0x170022C0 RID: 8896
			// (get) Token: 0x0600FF53 RID: 65363 RVA: 0x00061080 File Offset: 0x0005F280
			[Token(Token = "0x170022C0")]
			public int currentPalsyMaxStackCnt
			{
				[Token(Token = "0x600FF53")]
				[Address(RVA = "0x784010", Offset = "0x782C10", VA = "0x180784010")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600FF54 RID: 65364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FF54")]
			[Address(RVA = "0x7838B0", Offset = "0x7824B0", VA = "0x1807838B0")]
			public void Reset(Unit owner)
			{
			}

			// Token: 0x0600FF55 RID: 65365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FF55")]
			[Address(RVA = "0x783440", Offset = "0x782040", VA = "0x180783440")]
			public void AddPalsyLimit(Buff source)
			{
			}

			// Token: 0x0600FF56 RID: 65366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FF56")]
			[Address(RVA = "0x783730", Offset = "0x782330", VA = "0x180783730")]
			public void RemovePalsyLimit(Buff source)
			{
			}

			// Token: 0x0600FF57 RID: 65367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FF57")]
			[Address(RVA = "0x783610", Offset = "0x782210", VA = "0x180783610")]
			public void OnPalsyStackAdd(Buff palsyBuff)
			{
			}

			// Token: 0x0600FF58 RID: 65368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FF58")]
			[Address(RVA = "0x7839E0", Offset = "0x7825E0", VA = "0x1807839E0")]
			public void TryOverflowPalsy()
			{
			}

			// Token: 0x0600FF59 RID: 65369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FF59")]
			[Address(RVA = "0x783AE0", Offset = "0x7826E0", VA = "0x180783AE0")]
			private void _TryOverflow(Buff.OverrideGroup overrideGroup, int addedStack)
			{
			}

			// Token: 0x0600FF5A RID: 65370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FF5A")]
			[Address(RVA = "0x783C80", Offset = "0x782880", VA = "0x180783C80")]
			private void _UpdateMaxStackCntChanges(int originCnt)
			{
			}

			// Token: 0x0600FF5B RID: 65371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FF5B")]
			[Address(RVA = "0x783F60", Offset = "0x782B60", VA = "0x180783F60")]
			public PalsyController()
			{
			}

			// Token: 0x04011BAD RID: 72621
			[Token(Token = "0x4011BAD")]
			[FieldOffset(Offset = "0x10")]
			private Unit m_owner;

			// Token: 0x04011BAE RID: 72622
			[Token(Token = "0x4011BAE")]
			[FieldOffset(Offset = "0x18")]
			private List<ObjectPtr<Buff>> m_maxStackCntHolder;

			// Token: 0x04011BAF RID: 72623
			[Token(Token = "0x4011BAF")]
			[FieldOffset(Offset = "0x20")]
			private int m_limitedPalsyStackCnt;

			// Token: 0x04011BB0 RID: 72624
			[Token(Token = "0x4011BB0")]
			[FieldOffset(Offset = "0x24")]
			private int m_defaultPalsyStackCnt;

			// Token: 0x04011BB1 RID: 72625
			[Token(Token = "0x4011BB1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_currentPalsyMaxStackCnt;

			// Token: 0x04011BB2 RID: 72626
			[Token(Token = "0x4011BB2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x04011BB3 RID: 72627
			[Token(Token = "0x4011BB3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_AddPalsyLimit;

			// Token: 0x04011BB4 RID: 72628
			[Token(Token = "0x4011BB4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RemovePalsyLimit;

			// Token: 0x04011BB5 RID: 72629
			[Token(Token = "0x4011BB5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnPalsyStackAdd;

			// Token: 0x04011BB6 RID: 72630
			[Token(Token = "0x4011BB6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_TryOverflowPalsy;

			// Token: 0x04011BB7 RID: 72631
			[Token(Token = "0x4011BB7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__TryOverflow;

			// Token: 0x04011BB8 RID: 72632
			[Token(Token = "0x4011BB8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__UpdateMaxStackCntChanges;

			// Token: 0x04011BB9 RID: 72633
			[Token(Token = "0x4011BB9")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200261D RID: 9757
		[Token(Token = "0x200261D")]
		[Serializable]
		public struct StringReplacePair
		{
			// Token: 0x04011BBA RID: 72634
			[Token(Token = "0x4011BBA")]
			[FieldOffset(Offset = "0x0")]
			public string from;

			// Token: 0x04011BBB RID: 72635
			[Token(Token = "0x4011BBB")]
			[FieldOffset(Offset = "0x8")]
			public string to;
		}

		// Token: 0x0200261E RID: 9758
		[Token(Token = "0x200261E")]
		private class RangeIdHitRangeProvider : Entity.IHitRangeProvider, IHotfixable
		{
			// Token: 0x0600FF5C RID: 65372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FF5C")]
			[Address(RVA = "0x784440", Offset = "0x783040", VA = "0x180784440")]
			public RangeIdHitRangeProvider(ObjectPtr<Unit> owner)
			{
			}

			// Token: 0x170022C1 RID: 8897
			// (get) Token: 0x0600FF5D RID: 65373 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170022C1")]
			public string providerId
			{
				[Token(Token = "0x600FF5D")]
				[Address(RVA = "0x7844C0", Offset = "0x7830C0", VA = "0x1807844C0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600FF5E RID: 65374 RVA: 0x00061098 File Offset: 0x0005F298
			[Token(Token = "0x600FF5E")]
			[Address(RVA = "0x7840D0", Offset = "0x782CD0", VA = "0x1807840D0", Slot = "4")]
			public bool IsInHitRange(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x0600FF5F RID: 65375 RVA: 0x000610B0 File Offset: 0x0005F2B0
			[Token(Token = "0x600FF5F")]
			[Address(RVA = "0x7843B0", Offset = "0x782FB0", VA = "0x1807843B0", Slot = "5")]
			public bool IsTargetIn(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x04011BBC RID: 72636
			[Token(Token = "0x4011BBC")]
			public const string RANGE_ID_HIT_RANGE_CHECKER_PROVIDER = "RANGE_ID_HIT_RANGE_CHECKER_PROVIDER";

			// Token: 0x04011BBD RID: 72637
			[Token(Token = "0x4011BBD")]
			[FieldOffset(Offset = "0x10")]
			private RangeData m_data;

			// Token: 0x04011BBE RID: 72638
			[Token(Token = "0x4011BBE")]
			[FieldOffset(Offset = "0x18")]
			private ObjectPtr<Unit> m_owner;

			// Token: 0x04011BBF RID: 72639
			[Token(Token = "0x4011BBF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04011BC0 RID: 72640
			[Token(Token = "0x4011BC0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_providerId;

			// Token: 0x04011BC1 RID: 72641
			[Token(Token = "0x4011BC1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsInHitRange;

			// Token: 0x04011BC2 RID: 72642
			[Token(Token = "0x4011BC2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsTargetIn;
		}
	}
}
