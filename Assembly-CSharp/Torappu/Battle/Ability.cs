using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020E1 RID: 8417
	[Token(Token = "0x20020E1")]
	public abstract class Ability : Entity.FriendComponent, IEffectSource, IProjectileSource, IActionNodeSource, IBuffSource, IPtrObject, ISpecialAudioSignalSource, IHotfixable, RandomExtensions.IPRDRandomEntity
	{
		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x0600CDEA RID: 52714 RVA: 0x0004A4F0 File Offset: 0x000486F0
		[Token(Token = "0x17001857")]
		public uint instanceUid
		{
			[Token(Token = "0x600CDEA")]
			[Address(RVA = "0x34F6BA0", Offset = "0x34F57A0", VA = "0x1834F6BA0", Slot = "8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x0600CDEB RID: 52715 RVA: 0x0004A508 File Offset: 0x00048708
		[Token(Token = "0x17001858")]
		public PlayerSide playerSide
		{
			[Token(Token = "0x600CDEB")]
			[Address(RVA = "0x34F7330", Offset = "0x34F5F30", VA = "0x1834F7330")]
			get
			{
				return PlayerSide.DEFAULT;
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x0600CDEC RID: 52716 RVA: 0x0004A520 File Offset: 0x00048720
		// (set) Token: 0x0600CDED RID: 52717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001859")]
		private protected uint abilityUniqueId
		{
			[Token(Token = "0x600CDEC")]
			[Address(RVA = "0x34F66C0", Offset = "0x34F52C0", VA = "0x1834F66C0")]
			[CompilerGenerated]
			protected get
			{
				return 0U;
			}
			[Token(Token = "0x600CDED")]
			[Address(RVA = "0x34F7780", Offset = "0x34F6380", VA = "0x1834F7780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x0600CDEE RID: 52718
		[Token(Token = "0x1700185A")]
		public abstract Ability.Category category { [Token(Token = "0x600CDEE")] get; }

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x0600CDEF RID: 52719 RVA: 0x0004A538 File Offset: 0x00048738
		[Token(Token = "0x1700185B")]
		public Ability.FamilyGroup familyGroup
		{
			[Token(Token = "0x600CDEF")]
			[Address(RVA = "0x34F6A70", Offset = "0x34F5670", VA = "0x1834F6A70")]
			get
			{
				return Ability.FamilyGroup.ATTACK;
			}
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x0600CDF0 RID: 52720 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDF1 RID: 52721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700185C")]
		public Blackboard blackboard
		{
			[Token(Token = "0x600CDF0")]
			[Address(RVA = "0x34F6780", Offset = "0x34F5380", VA = "0x1834F6780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600CDF1")]
			[Address(RVA = "0x34F77F0", Offset = "0x34F63F0", VA = "0x1834F77F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x0600CDF2 RID: 52722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700185D")]
		public string signalId
		{
			[Token(Token = "0x600CDF2")]
			[Address(RVA = "0x34F7650", Offset = "0x34F6250", VA = "0x1834F7650")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x0600CDF3 RID: 52723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700185E")]
		public string extraDataId
		{
			[Token(Token = "0x600CDF3")]
			[Address(RVA = "0x34F6A10", Offset = "0x34F5610", VA = "0x1834F6A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x0600CDF4 RID: 52724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700185F")]
		public string rangeId
		{
			[Token(Token = "0x600CDF4")]
			[Address(RVA = "0x34F73E0", Offset = "0x34F5FE0", VA = "0x1834F73E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x0600CDF5 RID: 52725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001860")]
		public string searchName
		{
			[Token(Token = "0x600CDF5")]
			[Address(RVA = "0x34F7570", Offset = "0x34F6170", VA = "0x1834F7570")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x0600CDF6 RID: 52726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001861")]
		public Entity owner
		{
			[Token(Token = "0x600CDF6")]
			[Address(RVA = "0x34F71F0", Offset = "0x34F5DF0", VA = "0x1834F71F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x0600CDF7 RID: 52727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001862")]
		public Context context
		{
			[Token(Token = "0x600CDF7")]
			[Address(RVA = "0x34F6840", Offset = "0x34F5440", VA = "0x1834F6840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x0600CDF8 RID: 52728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001863")]
		public virtual TargetSelector selector
		{
			[Token(Token = "0x600CDF8")]
			[Address(RVA = "0x34F75F0", Offset = "0x34F61F0", VA = "0x1834F75F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x0600CDF9 RID: 52729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001864")]
		public virtual IDrawableRange rangeToShow
		{
			[Token(Token = "0x600CDF9")]
			[Address(RVA = "0x34F74A0", Offset = "0x34F60A0", VA = "0x1834F74A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x0600CDFA RID: 52730
		[Token(Token = "0x17001865")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public abstract FP cooldown { [Token(Token = "0x600CDFA")] get; }

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x0600CDFB RID: 52731 RVA: 0x0004A550 File Offset: 0x00048750
		[Token(Token = "0x17001866")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public FP remainingTime
		{
			[Token(Token = "0x600CDFB")]
			[Address(RVA = "0x34F7500", Offset = "0x34F6100", VA = "0x1834F7500")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x0600CDFC RID: 52732 RVA: 0x0004A568 File Offset: 0x00048768
		[Token(Token = "0x17001867")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public FP cooldownProgress
		{
			[Token(Token = "0x600CDFC")]
			[Address(RVA = "0x34F68C0", Offset = "0x34F54C0", VA = "0x1834F68C0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x0600CDFD RID: 52733 RVA: 0x0004A580 File Offset: 0x00048780
		[Token(Token = "0x17001868")]
		public FP periodTime
		{
			[Token(Token = "0x600CDFD")]
			[Address(RVA = "0x34F72C0", Offset = "0x34F5EC0", VA = "0x1834F72C0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x0600CDFE RID: 52734
		[Token(Token = "0x17001869")]
		public abstract bool allowNoTarget { [Token(Token = "0x600CDFE")] get; }

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x0600CDFF RID: 52735 RVA: 0x0004A598 File Offset: 0x00048798
		[Token(Token = "0x1700186A")]
		protected bool isCastable
		{
			[Token(Token = "0x600CDFF")]
			[Address(RVA = "0x34F6CF0", Offset = "0x34F58F0", VA = "0x1834F6CF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x0600CE00 RID: 52736 RVA: 0x0004A5B0 File Offset: 0x000487B0
		[Token(Token = "0x1700186B")]
		public virtual bool isReady
		{
			[Token(Token = "0x600CE00")]
			[Address(RVA = "0x34F6F80", Offset = "0x34F5B80", VA = "0x1834F6F80", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x0600CE01 RID: 52737 RVA: 0x0004A5C8 File Offset: 0x000487C8
		[Token(Token = "0x1700186C")]
		public bool isReadyIgnoreAttachAndCooldown
		{
			[Token(Token = "0x600CE01")]
			[Address(RVA = "0x34F6EC0", Offset = "0x34F5AC0", VA = "0x1834F6EC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x0600CE02 RID: 52738 RVA: 0x0004A5E0 File Offset: 0x000487E0
		[Token(Token = "0x1700186D")]
		protected bool isCooledDown
		{
			[Token(Token = "0x600CE02")]
			[Address(RVA = "0x34F6E30", Offset = "0x34F5A30", VA = "0x1834F6E30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x0600CE03 RID: 52739 RVA: 0x0004A5F8 File Offset: 0x000487F8
		[Token(Token = "0x1700186E")]
		public virtual bool isAffecting
		{
			[Token(Token = "0x600CE03")]
			[Address(RVA = "0x34F6C00", Offset = "0x34F5800", VA = "0x1834F6C00", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x0600CE04 RID: 52740 RVA: 0x0004A610 File Offset: 0x00048810
		// (set) Token: 0x0600CE05 RID: 52741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700186F")]
		public bool isCasting
		{
			[Token(Token = "0x600CE04")]
			[Address(RVA = "0x34F6DD0", Offset = "0x34F59D0", VA = "0x1834F6DD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600CE05")]
			[Address(RVA = "0x34F7950", Offset = "0x34F6550", VA = "0x1834F7950")]
			set
			{
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x0600CE06 RID: 52742 RVA: 0x0004A628 File Offset: 0x00048828
		// (set) Token: 0x0600CE07 RID: 52743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001870")]
		public bool isAttached
		{
			[Token(Token = "0x600CE06")]
			[Address(RVA = "0x34F6C90", Offset = "0x34F5890", VA = "0x1834F6C90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600CE07")]
			[Address(RVA = "0x34F78E0", Offset = "0x34F64E0", VA = "0x1834F78E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x0600CE08 RID: 52744 RVA: 0x0004A640 File Offset: 0x00048840
		[Token(Token = "0x17001871")]
		public virtual bool canSelectCamouflageTarget
		{
			[Token(Token = "0x600CE08")]
			[Address(RVA = "0x34F67E0", Offset = "0x34F53E0", VA = "0x1834F67E0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x0600CE09 RID: 52745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001872")]
		public List<uint> passiveBuffUids
		{
			[Token(Token = "0x600CE09")]
			[Address(RVA = "0x34F7260", Offset = "0x34F5E60", VA = "0x1834F7260")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x0600CE0A RID: 52746 RVA: 0x0004A658 File Offset: 0x00048858
		[Token(Token = "0x17001873")]
		public virtual FP escapeTime
		{
			[Token(Token = "0x600CE0A")]
			[Address(RVA = "0x34F6990", Offset = "0x34F5590", VA = "0x1834F6990", Slot = "21")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x0600CE0B RID: 52747 RVA: 0x0004A670 File Offset: 0x00048870
		[Token(Token = "0x17001874")]
		public virtual SourceApplyWay applyWay
		{
			[Token(Token = "0x600CE0B")]
			[Address(RVA = "0x34F6720", Offset = "0x34F5320", VA = "0x1834F6720", Slot = "22")]
			get
			{
				return SourceApplyWay.NONE;
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x0600CE0C RID: 52748 RVA: 0x0004A688 File Offset: 0x00048888
		// (set) Token: 0x0600CE0D RID: 52749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001875")]
		public Ability.Options options
		{
			[Token(Token = "0x600CE0C")]
			[Address(RVA = "0x34F7160", Offset = "0x34F5D60", VA = "0x1834F7160")]
			[CompilerGenerated]
			get
			{
				return default(Ability.Options);
			}
			[Token(Token = "0x600CE0D")]
			[Address(RVA = "0x34F79C0", Offset = "0x34F65C0", VA = "0x1834F79C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x0600CE0E RID: 52750
		[Token(Token = "0x17001876")]
		[Inspect(InspectorLevel.Debug)]
		public abstract ActionPurposeMask purposeMask { [Token(Token = "0x600CE0E")] get; }

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x0600CE0F RID: 52751 RVA: 0x0004A6A0 File Offset: 0x000488A0
		[Token(Token = "0x17001877")]
		public virtual bool isPredelay
		{
			[Token(Token = "0x600CE0F")]
			[Address(RVA = "0x34F25C0", Offset = "0x34F11C0", VA = "0x1834F25C0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x0600CE10 RID: 52752 RVA: 0x0004A6B8 File Offset: 0x000488B8
		// (set) Token: 0x0600CE11 RID: 52753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001878")]
		public bool damageMissFlag
		{
			[Token(Token = "0x600CE10")]
			[Address(RVA = "0x34F6930", Offset = "0x34F5530", VA = "0x1834F6930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600CE11")]
			[Address(RVA = "0x34F7870", Offset = "0x34F6470", VA = "0x1834F7870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x0600CE12 RID: 52754 RVA: 0x0004A6D0 File Offset: 0x000488D0
		// (set) Token: 0x0600CE13 RID: 52755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001879")]
		public Ability.FinishReason abilityFinishReason
		{
			[Token(Token = "0x600CE12")]
			[Address(RVA = "0x34F6660", Offset = "0x34F5260", VA = "0x1834F6660")]
			[CompilerGenerated]
			get
			{
				return Ability.FinishReason.NORMAL_EXIT;
			}
			[Token(Token = "0x600CE13")]
			[Address(RVA = "0x34F7710", Offset = "0x34F6310", VA = "0x1834F7710")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x0600CE14 RID: 52756 RVA: 0x0004A6E8 File Offset: 0x000488E8
		[Token(Token = "0x1700187A")]
		public virtual bool ignorePalsyInterrupt
		{
			[Token(Token = "0x600CE14")]
			[Address(RVA = "0x34F6B40", Offset = "0x34F5740", VA = "0x1834F6B40", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CE15 RID: 52757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE15")]
		[Address(RVA = "0x34F5CA0", Offset = "0x34F48A0", VA = "0x1834F5CA0")]
		public void SetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0600CE16 RID: 52758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE16")]
		[Address(RVA = "0x34F4840", Offset = "0x34F3440", VA = "0x1834F4840", Slot = "26")]
		protected virtual void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0600CE17 RID: 52759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE17")]
		[Address(RVA = "0x34F5F30", Offset = "0x34F4B30", VA = "0x1834F5F30", Slot = "27")]
		public virtual void UpdateBlackboard(Blackboard extraBlackboard)
		{
		}

		// Token: 0x0600CE18 RID: 52760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE18")]
		[Address(RVA = "0x34F6440", Offset = "0x34F5040", VA = "0x1834F6440", Slot = "28")]
		public virtual void UpdateSelector()
		{
		}

		// Token: 0x0600CE19 RID: 52761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE19")]
		[Address(RVA = "0x34F3EF0", Offset = "0x34F2AF0", VA = "0x1834F3EF0")]
		public void Attach(Entity owner)
		{
		}

		// Token: 0x0600CE1A RID: 52762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE1A")]
		[Address(RVA = "0x34F4220", Offset = "0x34F2E20", VA = "0x1834F4220")]
		public void Detach()
		{
		}

		// Token: 0x0600CE1B RID: 52763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE1B")]
		[Address(RVA = "0x34F47C0", Offset = "0x34F33C0", VA = "0x1834F47C0")]
		public void DoReset()
		{
		}

		// Token: 0x0600CE1C RID: 52764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE1C")]
		[Address(RVA = "0x34F42F0", Offset = "0x34F2EF0", VA = "0x1834F42F0", Slot = "29")]
		protected virtual void DoAttach(Entity owner)
		{
		}

		// Token: 0x0600CE1D RID: 52765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE1D")]
		[Address(RVA = "0x34F4540", Offset = "0x34F3140", VA = "0x1834F4540", Slot = "30")]
		protected virtual void DoDetach()
		{
		}

		// Token: 0x0600CE1E RID: 52766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE1E")]
		[Address(RVA = "0x34F5600", Offset = "0x34F4200", VA = "0x1834F5600", Slot = "31")]
		public virtual void OnOwnerLocated()
		{
		}

		// Token: 0x0600CE1F RID: 52767
		[Token(Token = "0x600CE1F")]
		public abstract bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true);

		// Token: 0x0600CE20 RID: 52768
		[Token(Token = "0x600CE20")]
		public abstract bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true);

		// Token: 0x0600CE21 RID: 52769
		[Token(Token = "0x600CE21")]
		public abstract bool CastToInputPosition(Vector2 inputPos, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true);

		// Token: 0x0600CE22 RID: 52770 RVA: 0x0004A700 File Offset: 0x00048900
		[Token(Token = "0x600CE22")]
		[Address(RVA = "0x34F5280", Offset = "0x34F3E80", VA = "0x1834F5280", Slot = "35")]
		public virtual bool InterruptIfNot()
		{
			return default(bool);
		}

		// Token: 0x0600CE23 RID: 52771 RVA: 0x0004A718 File Offset: 0x00048918
		[Token(Token = "0x600CE23")]
		[Address(RVA = "0x34F4700", Offset = "0x34F3300", VA = "0x1834F4700", Slot = "36")]
		public virtual bool DoFinish(Ability.FinishReason reason, bool resetCd)
		{
			return default(bool);
		}

		// Token: 0x0600CE24 RID: 52772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE24")]
		[Address(RVA = "0x34F5A40", Offset = "0x34F4640", VA = "0x1834F5A40", Slot = "37")]
		public virtual void ResetCooldown(bool waitFirstPeriod)
		{
		}

		// Token: 0x0600CE25 RID: 52773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE25")]
		[Address(RVA = "0x34F62B0", Offset = "0x34F4EB0", VA = "0x1834F62B0")]
		protected void UpdateCooldown(bool waitFirstPeriod)
		{
		}

		// Token: 0x0600CE26 RID: 52774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE26")]
		[Address(RVA = "0x34F6370", Offset = "0x34F4F70", VA = "0x1834F6370", Slot = "38")]
		public virtual void UpdateCooldown(FP newPeriod, bool waitFirstPeriod, bool keepPassedTime = false)
		{
		}

		// Token: 0x0600CE27 RID: 52775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE27")]
		[Address(RVA = "0x34F60C0", Offset = "0x34F4CC0", VA = "0x1834F60C0")]
		public void UpdateCooldownToMatch(Ability another, bool resetPeriodToMatch = false)
		{
		}

		// Token: 0x0600CE28 RID: 52776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE28")]
		[Address(RVA = "0x34F5EB0", Offset = "0x34F4AB0", VA = "0x1834F5EB0", Slot = "39")]
		public virtual void StopAffect()
		{
		}

		// Token: 0x0600CE29 RID: 52777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE29")]
		[Address(RVA = "0x34F61D0", Offset = "0x34F4DD0", VA = "0x1834F61D0")]
		public void UpdateCooldownWhenFinish(Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x0600CE2A RID: 52778 RVA: 0x0004A730 File Offset: 0x00048930
		[Token(Token = "0x600CE2A")]
		[Address(RVA = "0x34F5310", Offset = "0x34F3F10", VA = "0x1834F5310")]
		public bool IsOnFirstCastFrame()
		{
			return default(bool);
		}

		// Token: 0x0600CE2B RID: 52779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE2B")]
		[Address(RVA = "0x34F5B30", Offset = "0x34F4730", VA = "0x1834F5B30", Slot = "40")]
		protected virtual void Reset()
		{
		}

		// Token: 0x0600CE2C RID: 52780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE2C")]
		[Address(RVA = "0x34F3FD0", Offset = "0x34F2BD0", VA = "0x1834F3FD0", Slot = "41")]
		protected virtual void CleanupForNextCast()
		{
		}

		// Token: 0x0600CE2D RID: 52781
		[Token(Token = "0x600CE2D")]
		protected abstract IList<BuffData> GetPassiveBuffs();

		// Token: 0x0600CE2E RID: 52782
		[Token(Token = "0x600CE2E")]
		public abstract IList<BuffData> GetActiveBuffs();

		// Token: 0x0600CE2F RID: 52783
		[Token(Token = "0x600CE2F")]
		public abstract IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile);

		// Token: 0x0600CE30 RID: 52784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CE30")]
		[Address(RVA = "0x34F4F20", Offset = "0x34F3B20", VA = "0x1834F4F20", Slot = "45")]
		public virtual IList<IAbilityAttachment> GetAbilityAttachments()
		{
			return null;
		}

		// Token: 0x0600CE31 RID: 52785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE31")]
		[Address(RVA = "0x34F4EA0", Offset = "0x34F3AA0", VA = "0x1834F4EA0", Slot = "46")]
		public virtual void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600CE32 RID: 52786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE32")]
		[Address(RVA = "0x34F2460", Offset = "0x34F1060", VA = "0x1834F2460", Slot = "47")]
		public virtual void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0600CE33 RID: 52787
		[Token(Token = "0x600CE33")]
		public abstract void GatherActionNodes(List<ActionNode> results);

		// Token: 0x0600CE34 RID: 52788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE34")]
		[Address(RVA = "0x34F4D90", Offset = "0x34F3990", VA = "0x1834F4D90", Slot = "49")]
		public virtual void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600CE35 RID: 52789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE35")]
		[Address(RVA = "0x34F24C0", Offset = "0x34F10C0", VA = "0x1834F24C0", Slot = "50")]
		protected virtual void OnCastStart()
		{
		}

		// Token: 0x0600CE36 RID: 52790
		[Token(Token = "0x600CE36")]
		protected abstract void OnCastEnd(Ability.FinishReason reason);

		// Token: 0x0600CE37 RID: 52791
		[Token(Token = "0x600CE37")]
		protected abstract void OnAttached();

		// Token: 0x0600CE38 RID: 52792
		[Token(Token = "0x600CE38")]
		protected abstract void OnDetached();

		// Token: 0x0600CE39 RID: 52793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE39")]
		[Address(RVA = "0x34F5660", Offset = "0x34F4260", VA = "0x1834F5660", Slot = "54")]
		public virtual void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600CE3A RID: 52794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE3A")]
		[Address(RVA = "0x34F2530", Offset = "0x34F1130", VA = "0x1834F2530", Slot = "55")]
		public virtual void OnOverload()
		{
		}

		// Token: 0x0600CE3B RID: 52795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE3B")]
		[Address(RVA = "0x34F55A0", Offset = "0x34F41A0", VA = "0x1834F55A0", Slot = "56")]
		public virtual void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x0600CE3C RID: 52796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE3C")]
		[Address(RVA = "0x34F5470", Offset = "0x34F4070", VA = "0x1834F5470", Slot = "57")]
		public virtual void OnAbilityExtendUpdated(FP extend)
		{
		}

		// Token: 0x0600CE3D RID: 52797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE3D")]
		[Address(RVA = "0x34F5700", Offset = "0x34F4300", VA = "0x1834F5700", Slot = "58")]
		public virtual void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x0600CE3E RID: 52798 RVA: 0x0004A748 File Offset: 0x00048948
		[Token(Token = "0x600CE3E")]
		[Address(RVA = "0x34F23A0", Offset = "0x34F0FA0", VA = "0x1834F23A0", Slot = "59")]
		public virtual bool CheckAtPreCastPhase()
		{
			return default(bool);
		}

		// Token: 0x0600CE3F RID: 52799 RVA: 0x0004A760 File Offset: 0x00048960
		[Token(Token = "0x600CE3F")]
		[Address(RVA = "0x34F4B60", Offset = "0x34F3760", VA = "0x1834F4B60", Slot = "60")]
		protected virtual bool FinishIfNot(Ability.FinishReason reason, bool resetCd)
		{
			return default(bool);
		}

		// Token: 0x0600CE40 RID: 52800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE40")]
		[Address(RVA = "0x34F3BD0", Offset = "0x34F27D0", VA = "0x1834F3BD0", Slot = "61")]
		protected virtual void AddPassiveBuffs()
		{
		}

		// Token: 0x0600CE41 RID: 52801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE41")]
		[Address(RVA = "0x34F40E0", Offset = "0x34F2CE0", VA = "0x1834F40E0", Slot = "62")]
		protected virtual void ClearPassiveBuffs()
		{
		}

		// Token: 0x0600CE42 RID: 52802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE42")]
		[Address(RVA = "0x34F5790", Offset = "0x34F4390", VA = "0x1834F5790", Slot = "63")]
		protected virtual void PreprocessActionsForProjectile(IList<ActionNode> actions)
		{
		}

		// Token: 0x0600CE43 RID: 52803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE43")]
		[Address(RVA = "0x34F59C0", Offset = "0x34F45C0", VA = "0x1834F59C0")]
		protected void RegisterFinishCallbackOnce(Ability.FinishCallbackDelegate func)
		{
		}

		// Token: 0x0600CE44 RID: 52804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE44")]
		[Address(RVA = "0x34F4070", Offset = "0x34F2C70", VA = "0x1834F4070")]
		protected void ClearFinishCallbackOnce()
		{
		}

		// Token: 0x0600CE45 RID: 52805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE45")]
		[Address(RVA = "0x34F5E00", Offset = "0x34F4A00", VA = "0x1834F5E00")]
		protected void StartCastingInternal()
		{
		}

		// Token: 0x0600CE46 RID: 52806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE46")]
		[Address(RVA = "0x34F41C0", Offset = "0x34F2DC0", VA = "0x1834F41C0", Slot = "64")]
		public virtual void ClearProjectile()
		{
		}

		// Token: 0x0600CE47 RID: 52807 RVA: 0x0004A778 File Offset: 0x00048978
		[Token(Token = "0x600CE47")]
		[Address(RVA = "0x34F50B0", Offset = "0x34F3CB0", VA = "0x1834F50B0", Slot = "10")]
		public RandomExtensions.PRDEntityHash GetPRDEntityHash(RandomExtensions.PRDRandomCategory category)
		{
			return default(RandomExtensions.PRDEntityHash);
		}

		// Token: 0x0600CE48 RID: 52808 RVA: 0x0004A790 File Offset: 0x00048990
		[Token(Token = "0x600CE48")]
		[Address(RVA = "0x34F3E60", Offset = "0x34F2A60", VA = "0x1834F3E60", Slot = "11")]
		public int AllocatePRDEntitySubHash(RandomExtensions.PRDRandomCategory category, RandomExtensions.IPRDRandomEntity child)
		{
			return 0;
		}

		// Token: 0x0600CE49 RID: 52809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE49")]
		[Address(RVA = "0x34F5AD0", Offset = "0x34F46D0", VA = "0x1834F5AD0", Slot = "12")]
		public void ResetPRDEntity()
		{
		}

		// Token: 0x0600CE4A RID: 52810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE4A")]
		[Address(RVA = "0x34F53A0", Offset = "0x34F3FA0", VA = "0x1834F53A0")]
		public void ModifyOptions(Ability.Options newOptions)
		{
		}

		// Token: 0x0600CE4B RID: 52811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE4B")]
		[Address(RVA = "0x34F6560", Offset = "0x34F5160", VA = "0x1834F6560")]
		protected Ability()
		{
		}

		// Token: 0x0400DB50 RID: 56144
		[Token(Token = "0x400DB50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Action onCastStart;

		// Token: 0x0400DB51 RID: 56145
		[Token(Token = "0x400DB51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Ability.FinishCallbackDelegate onCastFinish;

		// Token: 0x0400DB52 RID: 56146
		[Token(Token = "0x400DB52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TargetSelector _selector;

		// Token: 0x0400DB53 RID: 56147
		[Token(Token = "0x400DB53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Ability.Metadata _metadata;

		// Token: 0x0400DB54 RID: 56148
		[Token(Token = "0x400DB54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _interruptAbilityOnDetach;

		// Token: 0x0400DB55 RID: 56149
		[Token(Token = "0x400DB55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _attachPassiveBuffsOnDummy;

		// Token: 0x0400DB56 RID: 56150
		[Token(Token = "0x400DB56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ObjectPtr<Entity> m_owner;

		// Token: 0x0400DB57 RID: 56151
		[Token(Token = "0x400DB57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_isCasting;

		// Token: 0x0400DB58 RID: 56152
		[Token(Token = "0x400DB58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private uint m_castStartFrameCnt;

		// Token: 0x0400DB59 RID: 56153
		[Token(Token = "0x400DB59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Ability.FinishCallbackDelegate m_onCastedOnce;

		// Token: 0x0400DB5A RID: 56154
		[Token(Token = "0x400DB5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected PeriodicTimer m_cooldownTimer;

		// Token: 0x0400DB5B RID: 56155
		[Token(Token = "0x400DB5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected List<uint> m_passiveBuffUids;

		// Token: 0x0400DB63 RID: 56163
		[Token(Token = "0x400DB63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		private bool m_isPRDEntityHashAllocated;

		// Token: 0x0400DB64 RID: 56164
		[Token(Token = "0x400DB64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private RandomExtensions.PRDEntityHash m_prdEntityHash;

		// Token: 0x0400DB65 RID: 56165
		[Token(Token = "0x400DB65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instanceUid;

		// Token: 0x0400DB66 RID: 56166
		[Token(Token = "0x400DB66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_playerSide;

		// Token: 0x0400DB67 RID: 56167
		[Token(Token = "0x400DB67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_abilityUniqueId;

		// Token: 0x0400DB68 RID: 56168
		[Token(Token = "0x400DB68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_abilityUniqueId;

		// Token: 0x0400DB69 RID: 56169
		[Token(Token = "0x400DB69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_familyGroup;

		// Token: 0x0400DB6A RID: 56170
		[Token(Token = "0x400DB6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_blackboard;

		// Token: 0x0400DB6B RID: 56171
		[Token(Token = "0x400DB6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_blackboard;

		// Token: 0x0400DB6C RID: 56172
		[Token(Token = "0x400DB6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_signalId;

		// Token: 0x0400DB6D RID: 56173
		[Token(Token = "0x400DB6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_extraDataId;

		// Token: 0x0400DB6E RID: 56174
		[Token(Token = "0x400DB6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_rangeId;

		// Token: 0x0400DB6F RID: 56175
		[Token(Token = "0x400DB6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_searchName;

		// Token: 0x0400DB70 RID: 56176
		[Token(Token = "0x400DB70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x0400DB71 RID: 56177
		[Token(Token = "0x400DB71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_context;

		// Token: 0x0400DB72 RID: 56178
		[Token(Token = "0x400DB72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_selector;

		// Token: 0x0400DB73 RID: 56179
		[Token(Token = "0x400DB73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x0400DB74 RID: 56180
		[Token(Token = "0x400DB74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_remainingTime;

		// Token: 0x0400DB75 RID: 56181
		[Token(Token = "0x400DB75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_cooldownProgress;

		// Token: 0x0400DB76 RID: 56182
		[Token(Token = "0x400DB76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_periodTime;

		// Token: 0x0400DB77 RID: 56183
		[Token(Token = "0x400DB77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_isCastable;

		// Token: 0x0400DB78 RID: 56184
		[Token(Token = "0x400DB78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x0400DB79 RID: 56185
		[Token(Token = "0x400DB79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_isReadyIgnoreAttachAndCooldown;

		// Token: 0x0400DB7A RID: 56186
		[Token(Token = "0x400DB7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_isCooledDown;

		// Token: 0x0400DB7B RID: 56187
		[Token(Token = "0x400DB7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x0400DB7C RID: 56188
		[Token(Token = "0x400DB7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_isCasting;

		// Token: 0x0400DB7D RID: 56189
		[Token(Token = "0x400DB7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_isCasting;

		// Token: 0x0400DB7E RID: 56190
		[Token(Token = "0x400DB7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_isAttached;

		// Token: 0x0400DB7F RID: 56191
		[Token(Token = "0x400DB7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_isAttached;

		// Token: 0x0400DB80 RID: 56192
		[Token(Token = "0x400DB80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_canSelectCamouflageTarget;

		// Token: 0x0400DB81 RID: 56193
		[Token(Token = "0x400DB81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_passiveBuffUids;

		// Token: 0x0400DB82 RID: 56194
		[Token(Token = "0x400DB82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_escapeTime;

		// Token: 0x0400DB83 RID: 56195
		[Token(Token = "0x400DB83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_applyWay;

		// Token: 0x0400DB84 RID: 56196
		[Token(Token = "0x400DB84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x0400DB85 RID: 56197
		[Token(Token = "0x400DB85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_set_options;

		// Token: 0x0400DB86 RID: 56198
		[Token(Token = "0x400DB86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_isPredelay;

		// Token: 0x0400DB87 RID: 56199
		[Token(Token = "0x400DB87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_damageMissFlag;

		// Token: 0x0400DB88 RID: 56200
		[Token(Token = "0x400DB88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_damageMissFlag;

		// Token: 0x0400DB89 RID: 56201
		[Token(Token = "0x400DB89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_abilityFinishReason;

		// Token: 0x0400DB8A RID: 56202
		[Token(Token = "0x400DB8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_set_abilityFinishReason;

		// Token: 0x0400DB8B RID: 56203
		[Token(Token = "0x400DB8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_ignorePalsyInterrupt;

		// Token: 0x0400DB8C RID: 56204
		[Token(Token = "0x400DB8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0400DB8D RID: 56205
		[Token(Token = "0x400DB8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0400DB8E RID: 56206
		[Token(Token = "0x400DB8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_UpdateBlackboard;

		// Token: 0x0400DB8F RID: 56207
		[Token(Token = "0x400DB8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_UpdateSelector;

		// Token: 0x0400DB90 RID: 56208
		[Token(Token = "0x400DB90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_Attach;

		// Token: 0x0400DB91 RID: 56209
		[Token(Token = "0x400DB91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_Detach;

		// Token: 0x0400DB92 RID: 56210
		[Token(Token = "0x400DB92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_DoReset;

		// Token: 0x0400DB93 RID: 56211
		[Token(Token = "0x400DB93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0400DB94 RID: 56212
		[Token(Token = "0x400DB94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x0400DB95 RID: 56213
		[Token(Token = "0x400DB95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_OnOwnerLocated;

		// Token: 0x0400DB96 RID: 56214
		[Token(Token = "0x400DB96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_InterruptIfNot;

		// Token: 0x0400DB97 RID: 56215
		[Token(Token = "0x400DB97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_DoFinish;

		// Token: 0x0400DB98 RID: 56216
		[Token(Token = "0x400DB98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_ResetCooldown;

		// Token: 0x0400DB99 RID: 56217
		[Token(Token = "0x400DB99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_UpdateCooldown;

		// Token: 0x0400DB9A RID: 56218
		[Token(Token = "0x400DB9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix1_UpdateCooldown;

		// Token: 0x0400DB9B RID: 56219
		[Token(Token = "0x400DB9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_UpdateCooldownToMatch;

		// Token: 0x0400DB9C RID: 56220
		[Token(Token = "0x400DB9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_StopAffect;

		// Token: 0x0400DB9D RID: 56221
		[Token(Token = "0x400DB9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_UpdateCooldownWhenFinish;

		// Token: 0x0400DB9E RID: 56222
		[Token(Token = "0x400DB9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_IsOnFirstCastFrame;

		// Token: 0x0400DB9F RID: 56223
		[Token(Token = "0x400DB9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400DBA0 RID: 56224
		[Token(Token = "0x400DBA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_CleanupForNextCast;

		// Token: 0x0400DBA1 RID: 56225
		[Token(Token = "0x400DBA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_GetAbilityAttachments;

		// Token: 0x0400DBA2 RID: 56226
		[Token(Token = "0x400DBA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400DBA3 RID: 56227
		[Token(Token = "0x400DBA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x0400DBA4 RID: 56228
		[Token(Token = "0x400DBA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400DBA5 RID: 56229
		[Token(Token = "0x400DBA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0400DBA6 RID: 56230
		[Token(Token = "0x400DBA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400DBA7 RID: 56231
		[Token(Token = "0x400DBA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_OnOverload;

		// Token: 0x0400DBA8 RID: 56232
		[Token(Token = "0x400DBA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x0400DBA9 RID: 56233
		[Token(Token = "0x400DBA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_OnAbilityExtendUpdated;

		// Token: 0x0400DBAA RID: 56234
		[Token(Token = "0x400DBAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x0400DBAB RID: 56235
		[Token(Token = "0x400DBAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_CheckAtPreCastPhase;

		// Token: 0x0400DBAC RID: 56236
		[Token(Token = "0x400DBAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_FinishIfNot;

		// Token: 0x0400DBAD RID: 56237
		[Token(Token = "0x400DBAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_AddPassiveBuffs;

		// Token: 0x0400DBAE RID: 56238
		[Token(Token = "0x400DBAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_ClearPassiveBuffs;

		// Token: 0x0400DBAF RID: 56239
		[Token(Token = "0x400DBAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_PreprocessActionsForProjectile;

		// Token: 0x0400DBB0 RID: 56240
		[Token(Token = "0x400DBB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_RegisterFinishCallbackOnce;

		// Token: 0x0400DBB1 RID: 56241
		[Token(Token = "0x400DBB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_ClearFinishCallbackOnce;

		// Token: 0x0400DBB2 RID: 56242
		[Token(Token = "0x400DBB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_StartCastingInternal;

		// Token: 0x0400DBB3 RID: 56243
		[Token(Token = "0x400DBB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_ClearProjectile;

		// Token: 0x0400DBB4 RID: 56244
		[Token(Token = "0x400DBB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_GetPRDEntityHash;

		// Token: 0x0400DBB5 RID: 56245
		[Token(Token = "0x400DBB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_AllocatePRDEntitySubHash;

		// Token: 0x0400DBB6 RID: 56246
		[Token(Token = "0x400DBB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_ResetPRDEntity;

		// Token: 0x0400DBB7 RID: 56247
		[Token(Token = "0x400DBB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_ModifyOptions;

		// Token: 0x0400DBB8 RID: 56248
		[Token(Token = "0x400DBB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020020E2 RID: 8418
		// (Invoke) Token: 0x0600CE4D RID: 52813
		[Token(Token = "0x20020E2")]
		public delegate void FinishCallbackDelegate(Ability ability, Ability.FinishReason reason, bool resetCd);

		// Token: 0x020020E3 RID: 8419
		[Token(Token = "0x20020E3")]
		public struct Options
		{
			// Token: 0x0400DBB9 RID: 56249
			[Token(Token = "0x400DBB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Blackboard blackboard;

			// Token: 0x0400DBBA RID: 56250
			[Token(Token = "0x400DBBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string signalId;

			// Token: 0x0400DBBB RID: 56251
			[Token(Token = "0x400DBBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string rangeId;

			// Token: 0x0400DBBC RID: 56252
			[Token(Token = "0x400DBBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float rangeRadius;

			// Token: 0x0400DBBD RID: 56253
			[Token(Token = "0x400DBBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Ability.FamilyGroup familyGroup;
		}

		// Token: 0x020020E4 RID: 8420
		[Token(Token = "0x20020E4")]
		[Serializable]
		public struct Metadata
		{
			// Token: 0x0400DBBE RID: 56254
			[Token(Token = "0x400DBBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string namedAsAlias;

			// Token: 0x0400DBBF RID: 56255
			[Token(Token = "0x400DBBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string blackboardPrefix;
		}

		// Token: 0x020020E5 RID: 8421
		[Token(Token = "0x20020E5")]
		public enum FamilyGroup
		{
			// Token: 0x0400DBC1 RID: 56257
			[Token(Token = "0x400DBC1")]
			ATTACK,
			// Token: 0x0400DBC2 RID: 56258
			[Token(Token = "0x400DBC2")]
			COMBAT,
			// Token: 0x0400DBC3 RID: 56259
			[Token(Token = "0x400DBC3")]
			SKILL,
			// Token: 0x0400DBC4 RID: 56260
			[Token(Token = "0x400DBC4")]
			TALENT,
			// Token: 0x0400DBC5 RID: 56261
			[Token(Token = "0x400DBC5")]
			GENERAL,
			// Token: 0x0400DBC6 RID: 56262
			[Token(Token = "0x400DBC6")]
			E_NUM
		}

		// Token: 0x020020E6 RID: 8422
		[Token(Token = "0x20020E6")]
		public enum FamilyGroupMask
		{
			// Token: 0x0400DBC8 RID: 56264
			[Token(Token = "0x400DBC8")]
			NONE,
			// Token: 0x0400DBC9 RID: 56265
			[Token(Token = "0x400DBC9")]
			ATTACK,
			// Token: 0x0400DBCA RID: 56266
			[Token(Token = "0x400DBCA")]
			COMBAT,
			// Token: 0x0400DBCB RID: 56267
			[Token(Token = "0x400DBCB")]
			SKILL = 4,
			// Token: 0x0400DBCC RID: 56268
			[Token(Token = "0x400DBCC")]
			TALENT = 8,
			// Token: 0x0400DBCD RID: 56269
			[Token(Token = "0x400DBCD")]
			GENERAL = 16,
			// Token: 0x0400DBCE RID: 56270
			[Token(Token = "0x400DBCE")]
			ATTACK_OR_COMBAT = 3,
			// Token: 0x0400DBCF RID: 56271
			[Token(Token = "0x400DBCF")]
			ALL = 31,
			// Token: 0x0400DBD0 RID: 56272
			[Token(Token = "0x400DBD0")]
			EXCEPT_GENERAL = 15
		}

		// Token: 0x020020E7 RID: 8423
		[Token(Token = "0x20020E7")]
		public enum Category
		{
			// Token: 0x0400DBD2 RID: 56274
			[Token(Token = "0x400DBD2")]
			NONE,
			// Token: 0x0400DBD3 RID: 56275
			[Token(Token = "0x400DBD3")]
			PASSIVE = 2,
			// Token: 0x0400DBD4 RID: 56276
			[Token(Token = "0x400DBD4")]
			ACTIVE = 4
		}

		// Token: 0x020020E8 RID: 8424
		[Token(Token = "0x20020E8")]
		public enum FinishReason
		{
			// Token: 0x0400DBD6 RID: 56278
			[Token(Token = "0x400DBD6")]
			NORMAL_EXIT,
			// Token: 0x0400DBD7 RID: 56279
			[Token(Token = "0x400DBD7")]
			INTERRUPTED,
			// Token: 0x0400DBD8 RID: 56280
			[Token(Token = "0x400DBD8")]
			OWNER_DEAD,
			// Token: 0x0400DBD9 RID: 56281
			[Token(Token = "0x400DBD9")]
			TARGET_DEAD,
			// Token: 0x0400DBDA RID: 56282
			[Token(Token = "0x400DBDA")]
			PALSY
		}
	}
}
