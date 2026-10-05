using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020EB RID: 8427
	[Token(Token = "0x20020EB")]
	public abstract class AbilityStandard : Ability
	{
		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x0600CE55 RID: 52821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700187B")]
		public List<ObjectPtr<Entity>> castTargets
		{
			[Token(Token = "0x600CE55")]
			[Address(RVA = "0x34F35C0", Offset = "0x34F21C0", VA = "0x1834F35C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x0600CE56 RID: 52822 RVA: 0x0004A7A8 File Offset: 0x000489A8
		[Token(Token = "0x1700187C")]
		public KeyValuePair<Vector2, ObjectPtr<Entity>> inputTarget
		{
			[Token(Token = "0x600CE56")]
			[Address(RVA = "0x34F3680", Offset = "0x34F2280", VA = "0x1834F3680")]
			get
			{
				return default(KeyValuePair<Vector2, ObjectPtr<Entity>>);
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x0600CE57 RID: 52823
		[Token(Token = "0x1700187D")]
		public abstract AbilityStandard.SelectTargetSource selectTargetSource { [Token(Token = "0x600CE57")] get; }

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x0600CE58 RID: 52824 RVA: 0x0004A7C0 File Offset: 0x000489C0
		[Token(Token = "0x1700187E")]
		public virtual AbilityStandard.SelectTargetTiming selectTargetTiming
		{
			[Token(Token = "0x600CE58")]
			[Address(RVA = "0x34F3950", Offset = "0x34F2550", VA = "0x1834F3950", Slot = "66")]
			get
			{
				return AbilityStandard.SelectTargetTiming.AT_BEGINING;
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x0600CE59 RID: 52825 RVA: 0x0004A7D8 File Offset: 0x000489D8
		// (set) Token: 0x0600CE5A RID: 52826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700187F")]
		public float playbackSpeed
		{
			[Token(Token = "0x600CE59")]
			[Address(RVA = "0x34F3890", Offset = "0x34F2490", VA = "0x1834F3890")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600CE5A")]
			[Address(RVA = "0x34F3AF0", Offset = "0x34F26F0", VA = "0x1834F3AF0")]
			private set
			{
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x0600CE5B RID: 52827
		[Token(Token = "0x17001880")]
		protected abstract bool alwaysIncludeTarget { [Token(Token = "0x600CE5B")] get; }

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x0600CE5C RID: 52828 RVA: 0x0004A7F0 File Offset: 0x000489F0
		[Token(Token = "0x17001881")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x600CE5C")]
			[Address(RVA = "0x34F3540", Offset = "0x34F2140", VA = "0x1834F3540", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x0600CE5D RID: 52829 RVA: 0x0004A808 File Offset: 0x00048A08
		[Token(Token = "0x17001882")]
		protected virtual bool onlyTrigAudioSignalForFirstSpell
		{
			[Token(Token = "0x600CE5D")]
			[Address(RVA = "0x34F3830", Offset = "0x34F2430", VA = "0x1834F3830", Slot = "68")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x0600CE5E RID: 52830 RVA: 0x0004A820 File Offset: 0x00048A20
		[Token(Token = "0x17001883")]
		protected virtual bool onlyTrigAudioSignalForFirstHit
		{
			[Token(Token = "0x600CE5E")]
			[Address(RVA = "0x34F37D0", Offset = "0x34F23D0", VA = "0x1834F37D0", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x0600CE5F RID: 52831 RVA: 0x0004A838 File Offset: 0x00048A38
		// (set) Token: 0x0600CE60 RID: 52832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001884")]
		public int spellCnt
		{
			[Token(Token = "0x600CE5F")]
			[Address(RVA = "0x34F39B0", Offset = "0x34F25B0", VA = "0x1834F39B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600CE60")]
			[Address(RVA = "0x34F3B60", Offset = "0x34F2760", VA = "0x1834F3B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x0600CE61 RID: 52833 RVA: 0x0004A850 File Offset: 0x00048A50
		// (set) Token: 0x0600CE62 RID: 52834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001885")]
		private protected bool firstAttack
		{
			[Token(Token = "0x600CE61")]
			[Address(RVA = "0x34F3620", Offset = "0x34F2220", VA = "0x1834F3620")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600CE62")]
			[Address(RVA = "0x34F3A10", Offset = "0x34F2610", VA = "0x1834F3A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x0600CE63 RID: 52835 RVA: 0x0004A868 File Offset: 0x00048A68
		[Token(Token = "0x17001886")]
		public override ActionPurposeMask purposeMask
		{
			[Token(Token = "0x600CE63")]
			[Address(RVA = "0x34F38F0", Offset = "0x34F24F0", VA = "0x1834F38F0", Slot = "23")]
			get
			{
				return ActionPurposeMask.NONE;
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x0600CE64 RID: 52836 RVA: 0x0004A880 File Offset: 0x00048A80
		// (set) Token: 0x0600CE65 RID: 52837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001887")]
		public bool isAttackFinished
		{
			[Token(Token = "0x600CE64")]
			[Address(RVA = "0x34F3710", Offset = "0x34F2310", VA = "0x1834F3710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600CE65")]
			[Address(RVA = "0x34F3A80", Offset = "0x34F2680", VA = "0x1834F3A80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x0600CE66 RID: 52838 RVA: 0x0004A898 File Offset: 0x00048A98
		[Token(Token = "0x17001888")]
		public override bool isPredelay
		{
			[Token(Token = "0x600CE66")]
			[Address(RVA = "0x34F3770", Offset = "0x34F2370", VA = "0x1834F3770", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CE67 RID: 52839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE67")]
		[Address(RVA = "0x34EF120", Offset = "0x34EDD20", VA = "0x1834EF120", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0600CE68 RID: 52840 RVA: 0x0004A8B0 File Offset: 0x00048AB0
		[Token(Token = "0x600CE68")]
		[Address(RVA = "0x34F3270", Offset = "0x34F1E70", VA = "0x1834F3270")]
		private bool _CheckGameObjectActiveBeforeCast()
		{
			return default(bool);
		}

		// Token: 0x0600CE69 RID: 52841 RVA: 0x0004A8C8 File Offset: 0x00048AC8
		[Token(Token = "0x600CE69")]
		[Address(RVA = "0x34EE170", Offset = "0x34ECD70", VA = "0x1834EE170", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x0600CE6A RID: 52842 RVA: 0x0004A8E0 File Offset: 0x00048AE0
		[Token(Token = "0x600CE6A")]
		[Address(RVA = "0x34EDBC0", Offset = "0x34EC7C0", VA = "0x1834EDBC0", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x0600CE6B RID: 52843 RVA: 0x0004A8F8 File Offset: 0x00048AF8
		[Token(Token = "0x600CE6B")]
		[Address(RVA = "0x34EDEA0", Offset = "0x34ECAA0", VA = "0x1834EDEA0", Slot = "34")]
		public override bool CastToInputPosition(Vector2 inputPos, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x0600CE6C RID: 52844 RVA: 0x0004A910 File Offset: 0x00048B10
		[Token(Token = "0x600CE6C")]
		[Address(RVA = "0x34EFA50", Offset = "0x34EE650", VA = "0x1834EFA50", Slot = "70")]
		protected virtual Vector2 GetCastDirectlyMapPosition()
		{
			return default(Vector2);
		}

		// Token: 0x0600CE6D RID: 52845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE6D")]
		[Address(RVA = "0x34F22B0", Offset = "0x34F0EB0", VA = "0x1834F22B0", Slot = "39")]
		public override void StopAffect()
		{
		}

		// Token: 0x0600CE6E RID: 52846 RVA: 0x0004A928 File Offset: 0x00048B28
		[Token(Token = "0x600CE6E")]
		[Address(RVA = "0x34EE5E0", Offset = "0x34ED1E0", VA = "0x1834EE5E0", Slot = "59")]
		public override bool CheckAtPreCastPhase()
		{
			return default(bool);
		}

		// Token: 0x0600CE6F RID: 52847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CE6F")]
		public T GetFirstBehaviourOrNull<T>() where T : AbilityStandard.Behaviour
		{
			return null;
		}

		// Token: 0x0600CE70 RID: 52848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE70")]
		[Address(RVA = "0x34EE830", Offset = "0x34ED430", VA = "0x1834EE830", Slot = "41")]
		protected override void CleanupForNextCast()
		{
		}

		// Token: 0x0600CE71 RID: 52849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE71")]
		[Address(RVA = "0x34F1170", Offset = "0x34EFD70", VA = "0x1834F1170", Slot = "71")]
		protected virtual void OnEvent(AbilityStandard.Event ev, bool runAction = true)
		{
		}

		// Token: 0x0600CE72 RID: 52850
		[Token(Token = "0x600CE72")]
		protected abstract IList<ActionNode> GetEventActions(AbilityStandard.Event ev);

		// Token: 0x0600CE73 RID: 52851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE73")]
		[Address(RVA = "0x34EF5E0", Offset = "0x34EE1E0", VA = "0x1834EF5E0", Slot = "49")]
		public override void GatherBuffs(List<BuffData> buffs)
		{
		}

		// Token: 0x0600CE74 RID: 52852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE74")]
		[Address(RVA = "0x34EF700", Offset = "0x34EE300", VA = "0x1834EF700", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600CE75 RID: 52853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE75")]
		[Address(RVA = "0x34EF820", Offset = "0x34EE420", VA = "0x1834EF820", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0600CE76 RID: 52854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE76")]
		[Address(RVA = "0x34EF4D0", Offset = "0x34EE0D0", VA = "0x1834EF4D0", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x0600CE77 RID: 52855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE77")]
		[Address(RVA = "0x34F1F80", Offset = "0x34F0B80", VA = "0x1834F1F80")]
		public void PlayCheckPointSignal([Optional] object arg)
		{
		}

		// Token: 0x0600CE78 RID: 52856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE78")]
		[Address(RVA = "0x34F0360", Offset = "0x34EEF60", VA = "0x1834F0360", Slot = "73")]
		protected virtual void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x0600CE79 RID: 52857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE79")]
		[Address(RVA = "0x34EE8E0", Offset = "0x34ED4E0", VA = "0x1834EE8E0", Slot = "74")]
		protected virtual void DoApplyActionsOnTarget(Entity target, IList<ActionNode> actions)
		{
		}

		// Token: 0x0600CE7A RID: 52858
		[Token(Token = "0x600CE7A")]
		protected abstract IEnumerator OnWaitForPreDelay();

		// Token: 0x0600CE7B RID: 52859
		[Token(Token = "0x600CE7B")]
		protected abstract IEnumerator OnWaitForPostDelay();

		// Token: 0x0600CE7C RID: 52860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CE7C")]
		[Address(RVA = "0x34F1EF0", Offset = "0x34F0AF0", VA = "0x1834F1EF0", Slot = "77")]
		protected virtual IEnumerator OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x0600CE7D RID: 52861 RVA: 0x0004A940 File Offset: 0x00048B40
		[Token(Token = "0x600CE7D")]
		[Address(RVA = "0x34F1890", Offset = "0x34F0490", VA = "0x1834F1890", Slot = "78")]
		protected virtual bool OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x0600CE7E RID: 52862 RVA: 0x0004A958 File Offset: 0x00048B58
		[Token(Token = "0x600CE7E")]
		[Address(RVA = "0x34EEEE0", Offset = "0x34EDAE0", VA = "0x1834EEEE0", Slot = "79")]
		protected virtual bool DoOnHasNoTarget(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x0600CE7F RID: 52863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE7F")]
		[Address(RVA = "0x34F0A90", Offset = "0x34EF690", VA = "0x1834F0A90", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x0600CE80 RID: 52864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE80")]
		[Address(RVA = "0x34EFE40", Offset = "0x34EEA40", VA = "0x1834EFE40", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x0600CE81 RID: 52865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE81")]
		[Address(RVA = "0x34EFAE0", Offset = "0x34EE6E0", VA = "0x1834EFAE0", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x0600CE82 RID: 52866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE82")]
		[Address(RVA = "0x34F17C0", Offset = "0x34F03C0", VA = "0x1834F17C0", Slot = "55")]
		public override void OnOverload()
		{
		}

		// Token: 0x0600CE83 RID: 52867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE83")]
		[Address(RVA = "0x34F0EA0", Offset = "0x34EFAA0", VA = "0x1834F0EA0", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x0600CE84 RID: 52868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE84")]
		[Address(RVA = "0x34EFBA0", Offset = "0x34EE7A0", VA = "0x1834EFBA0", Slot = "80")]
		protected virtual void OnAttackFinished(object arg)
		{
		}

		// Token: 0x0600CE85 RID: 52869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE85")]
		[Address(RVA = "0x34F1D10", Offset = "0x34F0910", VA = "0x1834F1D10", Slot = "81")]
		protected virtual void OnStunnedChanged(object arg)
		{
		}

		// Token: 0x0600CE86 RID: 52870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE86")]
		[Address(RVA = "0x34F14A0", Offset = "0x34F00A0", VA = "0x1834F14A0", Slot = "82")]
		protected virtual void OnFrozenChanged(object arg)
		{
		}

		// Token: 0x0600CE87 RID: 52871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE87")]
		[Address(RVA = "0x34F1560", Offset = "0x34F0160", VA = "0x1834F1560", Slot = "83")]
		protected virtual void OnLevitateChanged(object arg)
		{
		}

		// Token: 0x0600CE88 RID: 52872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE88")]
		[Address(RVA = "0x34F1DD0", Offset = "0x34F09D0", VA = "0x1834F1DD0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600CE89 RID: 52873 RVA: 0x0004A970 File Offset: 0x00048B70
		[Token(Token = "0x600CE89")]
		[Address(RVA = "0x34EE4E0", Offset = "0x34ED0E0", VA = "0x1834EE4E0", Slot = "84")]
		protected virtual bool CheckActiveBuffs(Entity target, IList<BuffData> buffs)
		{
			return default(bool);
		}

		// Token: 0x0600CE8A RID: 52874 RVA: 0x0004A988 File Offset: 0x00048B88
		[Token(Token = "0x600CE8A")]
		[Address(RVA = "0x34EE9D0", Offset = "0x34ED5D0", VA = "0x1834EE9D0", Slot = "85")]
		protected virtual bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x0600CE8B RID: 52875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CE8B")]
		[Address(RVA = "0x34F3300", Offset = "0x34F1F00", VA = "0x1834F3300")]
		private IEnumerator _DoCast()
		{
			return null;
		}

		// Token: 0x0600CE8C RID: 52876 RVA: 0x0004A9A0 File Offset: 0x00048BA0
		[Token(Token = "0x600CE8C")]
		[Address(RVA = "0x34F26B0", Offset = "0x34F12B0", VA = "0x1834F26B0", Slot = "86")]
		protected virtual bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x0600CE8D RID: 52877 RVA: 0x0004A9B8 File Offset: 0x00048BB8
		[Token(Token = "0x600CE8D")]
		[Address(RVA = "0x34EE570", Offset = "0x34ED170", VA = "0x1834EE570", Slot = "87")]
		protected virtual bool CheckAnotherSpell(int spellCnt)
		{
			return default(bool);
		}

		// Token: 0x0600CE8E RID: 52878 RVA: 0x0004A9D0 File Offset: 0x00048BD0
		[Token(Token = "0x600CE8E")]
		[Address(RVA = "0x34EE690", Offset = "0x34ED290", VA = "0x1834EE690")]
		protected bool CheckFinished()
		{
			return default(bool);
		}

		// Token: 0x0600CE8F RID: 52879 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		[Token(Token = "0x600CE8F")]
		[Address(RVA = "0x34EF2E0", Offset = "0x34EDEE0", VA = "0x1834EF2E0")]
		protected bool DoUpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing)
		{
			return default(bool);
		}

		// Token: 0x0600CE90 RID: 52880 RVA: 0x0004AA00 File Offset: 0x00048C00
		[Token(Token = "0x600CE90")]
		[Address(RVA = "0x34F2620", Offset = "0x34F1220", VA = "0x1834F2620", Slot = "88")]
		protected virtual bool UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float animSpeed)
		{
			return default(bool);
		}

		// Token: 0x0600CE91 RID: 52881 RVA: 0x0004AA18 File Offset: 0x00048C18
		[Token(Token = "0x600CE91")]
		[Address(RVA = "0x34EE790", Offset = "0x34ED390", VA = "0x1834EE790", Slot = "89")]
		protected virtual bool CheckIsDamageOrHealSource()
		{
			return default(bool);
		}

		// Token: 0x0600CE92 RID: 52882 RVA: 0x0004AA30 File Offset: 0x00048C30
		[Token(Token = "0x600CE92")]
		[Address(RVA = "0x34EF970", Offset = "0x34EE570", VA = "0x1834EF970", Slot = "90")]
		protected virtual ActionPurposeMask GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE93")]
		[Address(RVA = "0x34EEDC0", Offset = "0x34ED9C0", VA = "0x1834EEDC0", Slot = "91")]
		protected virtual void DoEmitAudioSignalForSpellOn()
		{
		}

		// Token: 0x0600CE94 RID: 52884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE94")]
		[Address(RVA = "0x34EEC20", Offset = "0x34ED820", VA = "0x1834EEC20", Slot = "92")]
		protected virtual void DoEmitAudioSignalForHit(Entity target)
		{
		}

		// Token: 0x0600CE95 RID: 52885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE95")]
		[Address(RVA = "0x34F2180", Offset = "0x34F0D80", VA = "0x1834F2180", Slot = "58")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x0600CE96 RID: 52886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE96")]
		[Address(RVA = "0x34F16F0", Offset = "0x34F02F0", VA = "0x1834F16F0", Slot = "93")]
		protected virtual void OnOutputAttackOrHeal()
		{
		}

		// Token: 0x0600CE97 RID: 52887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE97")]
		[Address(RVA = "0x34F1620", Offset = "0x34F0220", VA = "0x1834F1620", Slot = "94")]
		protected virtual void OnOutputAttackOrHealEachSpell()
		{
		}

		// Token: 0x0600CE98 RID: 52888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE98")]
		[Address(RVA = "0x34EDA90", Offset = "0x34EC690", VA = "0x1834EDA90", Slot = "95")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600CE99 RID: 52889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE99")]
		[Address(RVA = "0x34F33B0", Offset = "0x34F1FB0", VA = "0x1834F33B0")]
		protected AbilityStandard()
		{
		}

		// Token: 0x0600CE9A RID: 52890 RVA: 0x0004AA48 File Offset: 0x00048C48
		[Token(Token = "0x600CE9A")]
		[Address(RVA = "0x34F25C0", Offset = "0x34F11C0", VA = "0x1834F25C0")]
		private bool <>xLuaBaseProxy_get_isPredelay()
		{
			return default(bool);
		}

		// Token: 0x0600CE9B RID: 52891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE9B")]
		[Address(RVA = "0x34F2410", Offset = "0x34F1010", VA = "0x1834F2410")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0600CE9C RID: 52892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE9C")]
		[Address(RVA = "0x34F25B0", Offset = "0x34F11B0", VA = "0x1834F25B0")]
		private void <>xLuaBaseProxy_StopAffect()
		{
		}

		// Token: 0x0600CE9D RID: 52893 RVA: 0x0004AA60 File Offset: 0x00048C60
		[Token(Token = "0x600CE9D")]
		[Address(RVA = "0x34F23A0", Offset = "0x34F0FA0", VA = "0x1834F23A0")]
		private bool <>xLuaBaseProxy_CheckAtPreCastPhase()
		{
			return default(bool);
		}

		// Token: 0x0600CE9E RID: 52894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE9E")]
		[Address(RVA = "0x34F2400", Offset = "0x34F1000", VA = "0x1834F2400")]
		private void <>xLuaBaseProxy_CleanupForNextCast()
		{
		}

		// Token: 0x0600CE9F RID: 52895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE9F")]
		[Address(RVA = "0x34F2440", Offset = "0x34F1040", VA = "0x1834F2440")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0600CEA0 RID: 52896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEA0")]
		[Address(RVA = "0x34F2450", Offset = "0x34F1050", VA = "0x1834F2450")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600CEA1 RID: 52897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEA1")]
		[Address(RVA = "0x34F2460", Offset = "0x34F1060", VA = "0x1834F2460")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x0600CEA2 RID: 52898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEA2")]
		[Address(RVA = "0x34F24C0", Offset = "0x34F10C0", VA = "0x1834F24C0")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0600CEA3 RID: 52899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEA3")]
		[Address(RVA = "0x34F2530", Offset = "0x34F1130", VA = "0x1834F2530")]
		private void <>xLuaBaseProxy_OnOverload()
		{
		}

		// Token: 0x0600CEA4 RID: 52900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEA4")]
		[Address(RVA = "0x34F2590", Offset = "0x34F1190", VA = "0x1834F2590")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600CEA5 RID: 52901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEA5")]
		[Address(RVA = "0x34F25A0", Offset = "0x34F11A0", VA = "0x1834F25A0")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x0400DBE0 RID: 56288
		[Token(Token = "0x400DBE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected bool _ignoreIfOwnerDead;

		// Token: 0x0400DBE1 RID: 56289
		[Token(Token = "0x400DBE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		[SerializeField]
		protected bool _forceAsDmgOrHealAbility;

		// Token: 0x0400DBE2 RID: 56290
		[Token(Token = "0x400DBE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected List<ObjectPtr<Entity>> m_castTargets;

		// Token: 0x0400DBE3 RID: 56291
		[Token(Token = "0x400DBE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected KeyValuePair<Vector2, ObjectPtr<Entity>> m_inputTarget;

		// Token: 0x0400DBE4 RID: 56292
		[Token(Token = "0x400DBE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float m_playbackSpeed;

		// Token: 0x0400DBE5 RID: 56293
		[Token(Token = "0x400DBE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected AbilityStandard.Behaviour[] m_behaviours;

		// Token: 0x0400DBE6 RID: 56294
		[Token(Token = "0x400DBE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool m_isDmgOrHealAbility;

		// Token: 0x0400DBE7 RID: 56295
		[Token(Token = "0x400DBE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected ActionPurposeMask m_purposeMask;

		// Token: 0x0400DBEB RID: 56299
		[Token(Token = "0x400DBEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		private bool m_isPredelay;

		// Token: 0x0400DBEC RID: 56300
		[Token(Token = "0x400DBEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_castTargets;

		// Token: 0x0400DBED RID: 56301
		[Token(Token = "0x400DBED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_inputTarget;

		// Token: 0x0400DBEE RID: 56302
		[Token(Token = "0x400DBEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetTiming;

		// Token: 0x0400DBEF RID: 56303
		[Token(Token = "0x400DBEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_playbackSpeed;

		// Token: 0x0400DBF0 RID: 56304
		[Token(Token = "0x400DBF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_playbackSpeed;

		// Token: 0x0400DBF1 RID: 56305
		[Token(Token = "0x400DBF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x0400DBF2 RID: 56306
		[Token(Token = "0x400DBF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onlyTrigAudioSignalForFirstSpell;

		// Token: 0x0400DBF3 RID: 56307
		[Token(Token = "0x400DBF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_onlyTrigAudioSignalForFirstHit;

		// Token: 0x0400DBF4 RID: 56308
		[Token(Token = "0x400DBF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_spellCnt;

		// Token: 0x0400DBF5 RID: 56309
		[Token(Token = "0x400DBF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_spellCnt;

		// Token: 0x0400DBF6 RID: 56310
		[Token(Token = "0x400DBF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_firstAttack;

		// Token: 0x0400DBF7 RID: 56311
		[Token(Token = "0x400DBF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_firstAttack;

		// Token: 0x0400DBF8 RID: 56312
		[Token(Token = "0x400DBF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_purposeMask;

		// Token: 0x0400DBF9 RID: 56313
		[Token(Token = "0x400DBF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isAttackFinished;

		// Token: 0x0400DBFA RID: 56314
		[Token(Token = "0x400DBFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_isAttackFinished;

		// Token: 0x0400DBFB RID: 56315
		[Token(Token = "0x400DBFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_isPredelay;

		// Token: 0x0400DBFC RID: 56316
		[Token(Token = "0x400DBFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0400DBFD RID: 56317
		[Token(Token = "0x400DBFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckGameObjectActiveBeforeCast;

		// Token: 0x0400DBFE RID: 56318
		[Token(Token = "0x400DBFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x0400DBFF RID: 56319
		[Token(Token = "0x400DBFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x0400DC00 RID: 56320
		[Token(Token = "0x400DC00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CastToInputPosition;

		// Token: 0x0400DC01 RID: 56321
		[Token(Token = "0x400DC01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetCastDirectlyMapPosition;

		// Token: 0x0400DC02 RID: 56322
		[Token(Token = "0x400DC02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_StopAffect;

		// Token: 0x0400DC03 RID: 56323
		[Token(Token = "0x400DC03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckAtPreCastPhase;

		// Token: 0x0400DC04 RID: 56324
		[Token(Token = "0x400DC04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetFirstBehaviourOrNull;

		// Token: 0x0400DC05 RID: 56325
		[Token(Token = "0x400DC05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CleanupForNextCast;

		// Token: 0x0400DC06 RID: 56326
		[Token(Token = "0x400DC06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0400DC07 RID: 56327
		[Token(Token = "0x400DC07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400DC08 RID: 56328
		[Token(Token = "0x400DC08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400DC09 RID: 56329
		[Token(Token = "0x400DC09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x0400DC0A RID: 56330
		[Token(Token = "0x400DC0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0400DC0B RID: 56331
		[Token(Token = "0x400DC0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_PlayCheckPointSignal;

		// Token: 0x0400DC0C RID: 56332
		[Token(Token = "0x400DC0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x0400DC0D RID: 56333
		[Token(Token = "0x400DC0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_DoApplyActionsOnTarget;

		// Token: 0x0400DC0E RID: 56334
		[Token(Token = "0x400DC0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnWaitForTriggerDelta;

		// Token: 0x0400DC0F RID: 56335
		[Token(Token = "0x400DC0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnSpellStart;

		// Token: 0x0400DC10 RID: 56336
		[Token(Token = "0x400DC10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_DoOnHasNoTarget;

		// Token: 0x0400DC11 RID: 56337
		[Token(Token = "0x400DC11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0400DC12 RID: 56338
		[Token(Token = "0x400DC12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x0400DC13 RID: 56339
		[Token(Token = "0x400DC13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x0400DC14 RID: 56340
		[Token(Token = "0x400DC14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_OnOverload;

		// Token: 0x0400DC15 RID: 56341
		[Token(Token = "0x400DC15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x0400DC16 RID: 56342
		[Token(Token = "0x400DC16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_OnAttackFinished;

		// Token: 0x0400DC17 RID: 56343
		[Token(Token = "0x400DC17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_OnStunnedChanged;

		// Token: 0x0400DC18 RID: 56344
		[Token(Token = "0x400DC18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_OnFrozenChanged;

		// Token: 0x0400DC19 RID: 56345
		[Token(Token = "0x400DC19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OnLevitateChanged;

		// Token: 0x0400DC1A RID: 56346
		[Token(Token = "0x400DC1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400DC1B RID: 56347
		[Token(Token = "0x400DC1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_CheckActiveBuffs;

		// Token: 0x0400DC1C RID: 56348
		[Token(Token = "0x400DC1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x0400DC1D RID: 56349
		[Token(Token = "0x400DC1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__DoCast;

		// Token: 0x0400DC1E RID: 56350
		[Token(Token = "0x400DC1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x0400DC1F RID: 56351
		[Token(Token = "0x400DC1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_CheckAnotherSpell;

		// Token: 0x0400DC20 RID: 56352
		[Token(Token = "0x400DC20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_CheckFinished;

		// Token: 0x0400DC21 RID: 56353
		[Token(Token = "0x400DC21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_DoUpdatePlaybackSpeed;

		// Token: 0x0400DC22 RID: 56354
		[Token(Token = "0x400DC22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x0400DC23 RID: 56355
		[Token(Token = "0x400DC23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_CheckIsDamageOrHealSource;

		// Token: 0x0400DC24 RID: 56356
		[Token(Token = "0x400DC24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_GeneratePurposeMask;

		// Token: 0x0400DC25 RID: 56357
		[Token(Token = "0x400DC25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_DoEmitAudioSignalForSpellOn;

		// Token: 0x0400DC26 RID: 56358
		[Token(Token = "0x400DC26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_DoEmitAudioSignalForHit;

		// Token: 0x0400DC27 RID: 56359
		[Token(Token = "0x400DC27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x0400DC28 RID: 56360
		[Token(Token = "0x400DC28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_OnOutputAttackOrHeal;

		// Token: 0x0400DC29 RID: 56361
		[Token(Token = "0x400DC29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_OnOutputAttackOrHealEachSpell;

		// Token: 0x0400DC2A RID: 56362
		[Token(Token = "0x400DC2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400DC2B RID: 56363
		[Token(Token = "0x400DC2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020020EC RID: 8428
		[Token(Token = "0x20020EC")]
		[LuaCallCSharp(GenFlag.No)]
		[GCOptimize(OptimizeFlag.Default)]
		public enum Event
		{
			// Token: 0x0400DC2D RID: 56365
			[Token(Token = "0x400DC2D")]
			ON_ATTACHED,
			// Token: 0x0400DC2E RID: 56366
			[Token(Token = "0x400DC2E")]
			ON_DETACHED,
			// Token: 0x0400DC2F RID: 56367
			[Token(Token = "0x400DC2F")]
			ON_CAST_START,
			// Token: 0x0400DC30 RID: 56368
			[Token(Token = "0x400DC30")]
			ON_CAST_END,
			// Token: 0x0400DC31 RID: 56369
			[Token(Token = "0x400DC31")]
			ON_SPELL_ON,
			// Token: 0x0400DC32 RID: 56370
			[Token(Token = "0x400DC32")]
			ON_SPELL_END,
			// Token: 0x0400DC33 RID: 56371
			[Token(Token = "0x400DC33")]
			ON_ATTACK_FINISH,
			// Token: 0x0400DC34 RID: 56372
			[Token(Token = "0x400DC34")]
			ON_ATTACK_CHECK_POINT,
			// Token: 0x0400DC35 RID: 56373
			[Token(Token = "0x400DC35")]
			ON_OVERLOAD
		}

		// Token: 0x020020ED RID: 8429
		[Token(Token = "0x20020ED")]
		public enum SelectTargetSource
		{
			// Token: 0x0400DC37 RID: 56375
			[Token(Token = "0x400DC37")]
			NONE,
			// Token: 0x0400DC38 RID: 56376
			[Token(Token = "0x400DC38")]
			FROM_OWNER,
			// Token: 0x0400DC39 RID: 56377
			[Token(Token = "0x400DC39")]
			INPUT_TARGET,
			// Token: 0x0400DC3A RID: 56378
			[Token(Token = "0x400DC3A")]
			INPUT_POINT,
			// Token: 0x0400DC3B RID: 56379
			[Token(Token = "0x400DC3B")]
			INPUT_GRID_POS
		}

		// Token: 0x020020EE RID: 8430
		[Token(Token = "0x20020EE")]
		public enum SelectTargetTiming
		{
			// Token: 0x0400DC3D RID: 56381
			[Token(Token = "0x400DC3D")]
			AT_BEGINING,
			// Token: 0x0400DC3E RID: 56382
			[Token(Token = "0x400DC3E")]
			BEFORE_SPELL_START,
			// Token: 0x0400DC3F RID: 56383
			[Token(Token = "0x400DC3F")]
			RESELECT_IF_TARGET_DEAD,
			// Token: 0x0400DC40 RID: 56384
			[Token(Token = "0x400DC40")]
			BEFORE_FIRST_SPELL_START
		}

		// Token: 0x020020EF RID: 8431
		[Token(Token = "0x20020EF")]
		public enum UpdatePlaybackSpeedTiming
		{
			// Token: 0x0400DC42 RID: 56386
			[Token(Token = "0x400DC42")]
			FORCE_UPDATE,
			// Token: 0x0400DC43 RID: 56387
			[Token(Token = "0x400DC43")]
			ON_CAST_START,
			// Token: 0x0400DC44 RID: 56388
			[Token(Token = "0x400DC44")]
			RECOVER_FROM_INTERRUPT
		}

		// Token: 0x020020F0 RID: 8432
		[Token(Token = "0x20020F0")]
		public abstract class Behaviour : MonoBehaviour, IHotfixable
		{
			// Token: 0x17001889 RID: 6281
			// (get) Token: 0x0600CEA6 RID: 52902 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CEA7 RID: 52903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001889")]
			private protected AbilityStandard ability
			{
				[Token(Token = "0x600CEA6")]
				[Address(RVA = "0x34FAF40", Offset = "0x34F9B40", VA = "0x1834FAF40")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600CEA7")]
				[Address(RVA = "0x34FB590", Offset = "0x34FA190", VA = "0x1834FB590")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700188A RID: 6282
			// (get) Token: 0x0600CEA8 RID: 52904 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700188A")]
			protected Entity owner
			{
				[Token(Token = "0x600CEA8")]
				[Address(RVA = "0x34FB310", Offset = "0x34F9F10", VA = "0x1834FB310")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700188B RID: 6283
			// (get) Token: 0x0600CEA9 RID: 52905 RVA: 0x0004AA78 File Offset: 0x00048C78
			[Token(Token = "0x1700188B")]
			protected bool firstAttack
			{
				[Token(Token = "0x600CEA9")]
				[Address(RVA = "0x34FB050", Offset = "0x34F9C50", VA = "0x1834FB050")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700188C RID: 6284
			// (get) Token: 0x0600CEAA RID: 52906 RVA: 0x0004AA90 File Offset: 0x00048C90
			[Token(Token = "0x1700188C")]
			protected KeyValuePair<Vector2, ObjectPtr<Entity>> inputTarget
			{
				[Token(Token = "0x600CEAA")]
				[Address(RVA = "0x34FB130", Offset = "0x34F9D30", VA = "0x1834FB130")]
				get
				{
					return default(KeyValuePair<Vector2, ObjectPtr<Entity>>);
				}
			}

			// Token: 0x1700188D RID: 6285
			// (get) Token: 0x0600CEAB RID: 52907 RVA: 0x0004AAA8 File Offset: 0x00048CA8
			[Token(Token = "0x1700188D")]
			protected virtual float playbackSpeed
			{
				[Token(Token = "0x600CEAB")]
				[Address(RVA = "0x34FB3C0", Offset = "0x34F9FC0", VA = "0x1834FB3C0", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700188E RID: 6286
			// (get) Token: 0x0600CEAC RID: 52908 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700188E")]
			protected List<ObjectPtr<Entity>> castTargets
			{
				[Token(Token = "0x600CEAC")]
				[Address(RVA = "0x34FAFA0", Offset = "0x34F9BA0", VA = "0x1834FAFA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700188F RID: 6287
			// (get) Token: 0x0600CEAD RID: 52909 RVA: 0x0004AAC0 File Offset: 0x00048CC0
			[Token(Token = "0x1700188F")]
			protected Ability.Options options
			{
				[Token(Token = "0x600CEAD")]
				[Address(RVA = "0x34FB200", Offset = "0x34F9E00", VA = "0x1834FB200")]
				get
				{
					return default(Ability.Options);
				}
			}

			// Token: 0x17001890 RID: 6288
			// (get) Token: 0x0600CEAE RID: 52910 RVA: 0x0004AAD8 File Offset: 0x00048CD8
			[Token(Token = "0x17001890")]
			protected int spellCnt
			{
				[Token(Token = "0x600CEAE")]
				[Address(RVA = "0x34FB4B0", Offset = "0x34FA0B0", VA = "0x1834FB4B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600CEAF RID: 52911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEAF")]
			[Address(RVA = "0x34FAA10", Offset = "0x34F9610", VA = "0x1834FAA10", Slot = "5")]
			public virtual void Init(AbilityStandard ability)
			{
			}

			// Token: 0x0600CEB0 RID: 52912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEB0")]
			[Address(RVA = "0x34FADF0", Offset = "0x34F99F0", VA = "0x1834FADF0", Slot = "6")]
			public virtual void SetData(Blackboard blackboard)
			{
			}

			// Token: 0x0600CEB1 RID: 52913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEB1")]
			[Address(RVA = "0x34FABE0", Offset = "0x34F97E0", VA = "0x1834FABE0", Slot = "7")]
			public virtual void OnCastStart()
			{
			}

			// Token: 0x0600CEB2 RID: 52914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEB2")]
			[Address(RVA = "0x34FAAC0", Offset = "0x34F96C0", VA = "0x1834FAAC0", Slot = "8")]
			public virtual void OnAttackTimeChanged(FP newValue)
			{
			}

			// Token: 0x0600CEB3 RID: 52915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEB3")]
			[Address(RVA = "0x34FAB20", Offset = "0x34F9720", VA = "0x1834FAB20", Slot = "9")]
			public virtual void OnCastFinish(Ability.FinishReason reason)
			{
			}

			// Token: 0x0600CEB4 RID: 52916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEB4")]
			[Address(RVA = "0x34FAC40", Offset = "0x34F9840", VA = "0x1834FAC40", Slot = "10")]
			public virtual void OnEvent(AbilityStandard.Event ev)
			{
			}

			// Token: 0x0600CEB5 RID: 52917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEB5")]
			[Address(RVA = "0x34FAB80", Offset = "0x34F9780", VA = "0x1834FAB80", Slot = "11")]
			public virtual void OnCastOnTarget(Entity target)
			{
			}

			// Token: 0x0600CEB6 RID: 52918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEB6")]
			[Address(RVA = "0x34FACA0", Offset = "0x34F98A0", VA = "0x1834FACA0", Slot = "12")]
			public virtual void OnStopAffect()
			{
			}

			// Token: 0x0600CEB7 RID: 52919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEB7")]
			[Address(RVA = "0x34FAD00", Offset = "0x34F9900", VA = "0x1834FAD00", Slot = "13")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600CEB8 RID: 52920 RVA: 0x0004AAF0 File Offset: 0x00048CF0
			[Token(Token = "0x600CEB8")]
			[Address(RVA = "0x34FAE50", Offset = "0x34F9A50", VA = "0x1834FAE50", Slot = "14")]
			public virtual bool UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float playbackSpeed)
			{
				return default(bool);
			}

			// Token: 0x0600CEB9 RID: 52921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEB9")]
			[Address(RVA = "0x34FAD60", Offset = "0x34F9960", VA = "0x1834FAD60", Slot = "15")]
			public virtual void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
			{
			}

			// Token: 0x0600CEBA RID: 52922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CEBA")]
			[Address(RVA = "0x34FAEE0", Offset = "0x34F9AE0", VA = "0x1834FAEE0")]
			protected Behaviour()
			{
			}

			// Token: 0x0400DC46 RID: 56390
			[Token(Token = "0x400DC46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_ability;

			// Token: 0x0400DC47 RID: 56391
			[Token(Token = "0x400DC47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_ability;

			// Token: 0x0400DC48 RID: 56392
			[Token(Token = "0x400DC48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x0400DC49 RID: 56393
			[Token(Token = "0x400DC49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_firstAttack;

			// Token: 0x0400DC4A RID: 56394
			[Token(Token = "0x400DC4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_inputTarget;

			// Token: 0x0400DC4B RID: 56395
			[Token(Token = "0x400DC4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_playbackSpeed;

			// Token: 0x0400DC4C RID: 56396
			[Token(Token = "0x400DC4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_castTargets;

			// Token: 0x0400DC4D RID: 56397
			[Token(Token = "0x400DC4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_options;

			// Token: 0x0400DC4E RID: 56398
			[Token(Token = "0x400DC4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_spellCnt;

			// Token: 0x0400DC4F RID: 56399
			[Token(Token = "0x400DC4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400DC50 RID: 56400
			[Token(Token = "0x400DC50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x0400DC51 RID: 56401
			[Token(Token = "0x400DC51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnCastStart;

			// Token: 0x0400DC52 RID: 56402
			[Token(Token = "0x400DC52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

			// Token: 0x0400DC53 RID: 56403
			[Token(Token = "0x400DC53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_OnCastFinish;

			// Token: 0x0400DC54 RID: 56404
			[Token(Token = "0x400DC54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_OnEvent;

			// Token: 0x0400DC55 RID: 56405
			[Token(Token = "0x400DC55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_OnCastOnTarget;

			// Token: 0x0400DC56 RID: 56406
			[Token(Token = "0x400DC56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnStopAffect;

			// Token: 0x0400DC57 RID: 56407
			[Token(Token = "0x400DC57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0400DC58 RID: 56408
			[Token(Token = "0x400DC58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

			// Token: 0x0400DC59 RID: 56409
			[Token(Token = "0x400DC59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

			// Token: 0x0400DC5A RID: 56410
			[Token(Token = "0x400DC5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
