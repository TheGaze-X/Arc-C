using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002147 RID: 8519
	[Token(Token = "0x2002147")]
	public abstract class UnitAnimator : MonoBehaviour, IEffectSource, IHotfixable
	{
		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x0600D170 RID: 53616
		// (set) Token: 0x0600D171 RID: 53617
		[Token(Token = "0x17001909")]
		public abstract Color color { [Token(Token = "0x600D170")] get; [Token(Token = "0x600D171")] set; }

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x0600D172 RID: 53618 RVA: 0x0004B780 File Offset: 0x00049980
		[Token(Token = "0x1700190A")]
		public virtual int faceSign
		{
			[Token(Token = "0x600D172")]
			[Address(RVA = "0x353E300", Offset = "0x353CF00", VA = "0x18353E300", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x0600D173 RID: 53619 RVA: 0x0004B798 File Offset: 0x00049998
		[Token(Token = "0x1700190B")]
		public virtual bool faceToBack
		{
			[Token(Token = "0x600D173")]
			[Address(RVA = "0x353E360", Offset = "0x353CF60", VA = "0x18353E360", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x0600D174 RID: 53620 RVA: 0x0004B7B0 File Offset: 0x000499B0
		[Token(Token = "0x1700190C")]
		public virtual bool faceToDown
		{
			[Token(Token = "0x600D174")]
			[Address(RVA = "0x353ABC0", Offset = "0x35397C0", VA = "0x18353ABC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x0600D175 RID: 53621 RVA: 0x0004B7C8 File Offset: 0x000499C8
		[Token(Token = "0x1700190D")]
		public virtual SharedConsts.Direction faceLOrR
		{
			[Token(Token = "0x600D175")]
			[Address(RVA = "0x353E270", Offset = "0x353CE70", VA = "0x18353E270", Slot = "10")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x0600D176 RID: 53622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700190E")]
		public virtual Renderer meshRenderer
		{
			[Token(Token = "0x600D176")]
			[Address(RVA = "0x353E640", Offset = "0x353D240", VA = "0x18353E640", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x0600D177 RID: 53623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700190F")]
		public virtual MeshFilter meshFilter
		{
			[Token(Token = "0x600D177")]
			[Address(RVA = "0x353E5E0", Offset = "0x353D1E0", VA = "0x18353E5E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001910 RID: 6416
		// (set) Token: 0x0600D178 RID: 53624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001910")]
		public float scale
		{
			[Token(Token = "0x600D178")]
			[Address(RVA = "0x353E780", Offset = "0x353D380", VA = "0x18353E780")]
			set
			{
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x0600D179 RID: 53625
		[Token(Token = "0x17001911")]
		public abstract Transform graphicTransform { [Token(Token = "0x600D179")] get; }

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x0600D17A RID: 53626
		[Token(Token = "0x17001912")]
		public abstract Transform hitTransform { [Token(Token = "0x600D17A")] get; }

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x0600D17B RID: 53627
		[Token(Token = "0x17001913")]
		public abstract Transform footTransform { [Token(Token = "0x600D17B")] get; }

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x0600D17C RID: 53628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001914")]
		public virtual Transform graphicFootTransform
		{
			[Token(Token = "0x600D17C")]
			[Address(RVA = "0x353E3C0", Offset = "0x353CFC0", VA = "0x18353E3C0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x0600D17D RID: 53629
		[Token(Token = "0x17001915")]
		public abstract Transform headTransform { [Token(Token = "0x600D17D")] get; }

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x0600D17E RID: 53630
		[Token(Token = "0x17001916")]
		public abstract Transform shadowTransform { [Token(Token = "0x600D17E")] get; }

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x0600D17F RID: 53631
		[Token(Token = "0x17001917")]
		protected abstract Transform muzzleTransform { [Token(Token = "0x600D17F")] get; }

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x0600D180 RID: 53632 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D181 RID: 53633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001918")]
		public Unit host
		{
			[Token(Token = "0x600D180")]
			[Address(RVA = "0x353E580", Offset = "0x353D180", VA = "0x18353E580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D181")]
			[Address(RVA = "0x353E700", Offset = "0x353D300", VA = "0x18353E700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x0600D182 RID: 53634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001919")]
		public virtual CharacterSkinHooker skinHooker
		{
			[Token(Token = "0x600D182")]
			[Address(RVA = "0x353E6A0", Offset = "0x353D2A0", VA = "0x18353E6A0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x0600D183 RID: 53635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700191A")]
		protected UnitAnimatorHooker hooker
		{
			[Token(Token = "0x600D183")]
			[Address(RVA = "0x353E440", Offset = "0x353D040", VA = "0x18353E440")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D184 RID: 53636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D184")]
		[Address(RVA = "0x353D440", Offset = "0x353C040", VA = "0x18353D440", Slot = "21")]
		public virtual void Init(Unit host)
		{
		}

		// Token: 0x0600D185 RID: 53637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D185")]
		[Address(RVA = "0x353CE90", Offset = "0x353BA90", VA = "0x18353CE90", Slot = "22")]
		public virtual void EnableVisualPart(bool enable)
		{
		}

		// Token: 0x0600D186 RID: 53638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D186")]
		[Address(RVA = "0x353DD90", Offset = "0x353C990", VA = "0x18353DD90", Slot = "23")]
		public virtual void Stop()
		{
		}

		// Token: 0x0600D187 RID: 53639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D187")]
		[Address(RVA = "0x353DE40", Offset = "0x353CA40", VA = "0x18353DE40", Slot = "24")]
		public virtual void SyncFrom(UnitAnimator from)
		{
		}

		// Token: 0x0600D188 RID: 53640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D188")]
		[Address(RVA = "0x353CEF0", Offset = "0x353BAF0", VA = "0x18353CEF0")]
		public Transform FetchMuzzleTransform()
		{
			return null;
		}

		// Token: 0x0600D189 RID: 53641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D189")]
		[Address(RVA = "0x353E1A0", Offset = "0x353CDA0", VA = "0x18353E1A0", Slot = "25")]
		public virtual void UpdateTimeScale(float speed)
		{
		}

		// Token: 0x0600D18A RID: 53642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D18A")]
		[Address(RVA = "0x353D820", Offset = "0x353C420", VA = "0x18353D820", Slot = "26")]
		public virtual void OnReset(UnitAnimator oldAnimator)
		{
		}

		// Token: 0x0600D18B RID: 53643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D18B")]
		[Address(RVA = "0x353D760", Offset = "0x353C360", VA = "0x18353D760", Slot = "27")]
		public virtual void OnFinish()
		{
		}

		// Token: 0x0600D18C RID: 53644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D18C")]
		[Address(RVA = "0x353D970", Offset = "0x353C570", VA = "0x18353D970", Slot = "28")]
		public virtual void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600D18D RID: 53645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D18D")]
		[Address(RVA = "0x353DA70", Offset = "0x353C670", VA = "0x18353DA70", Slot = "29")]
		public virtual void OnUnitPostInit()
		{
		}

		// Token: 0x0600D18E RID: 53646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D18E")]
		[Address(RVA = "0x353D7C0", Offset = "0x353C3C0", VA = "0x18353D7C0", Slot = "30")]
		public virtual void OnGameOver()
		{
		}

		// Token: 0x0600D18F RID: 53647 RVA: 0x0004B7E0 File Offset: 0x000499E0
		[Token(Token = "0x600D18F")]
		[Address(RVA = "0x353DAD0", Offset = "0x353C6D0", VA = "0x18353DAD0")]
		public float PlayAnimation(string animKey, bool forceFromStart, float speed)
		{
			return 0f;
		}

		// Token: 0x0600D190 RID: 53648 RVA: 0x0004B7F8 File Offset: 0x000499F8
		[Token(Token = "0x600D190")]
		[Address(RVA = "0x353CA10", Offset = "0x353B610", VA = "0x18353CA10")]
		public bool ContainsAnimation(string animKey, bool allowEmpty)
		{
			return default(bool);
		}

		// Token: 0x0600D191 RID: 53649 RVA: 0x0004B810 File Offset: 0x00049A10
		[Token(Token = "0x600D191")]
		[Address(RVA = "0x353D0E0", Offset = "0x353BCE0", VA = "0x18353D0E0")]
		public bool GetAnimationTime(string animKey, out float time)
		{
			return default(bool);
		}

		// Token: 0x0600D192 RID: 53650 RVA: 0x0004B828 File Offset: 0x00049A28
		[Token(Token = "0x600D192")]
		[Address(RVA = "0x353D250", Offset = "0x353BE50", VA = "0x18353D250")]
		public bool GetAnimationTime(string animKey, out float time, out float speed)
		{
			return default(bool);
		}

		// Token: 0x0600D193 RID: 53651 RVA: 0x0004B840 File Offset: 0x00049A40
		[Token(Token = "0x600D193")]
		[Address(RVA = "0x353E130", Offset = "0x353CD30", VA = "0x18353E130", Slot = "31")]
		public virtual bool TryLoadEffectOverrideMap(ref ListDict<string, string> effectMap)
		{
			return default(bool);
		}

		// Token: 0x0600D194 RID: 53652
		[Token(Token = "0x600D194")]
		public abstract void OnFaceChanged(Vector2 newDir, Vector2 oldDir, bool force, bool isIdle);

		// Token: 0x0600D195 RID: 53653
		[Token(Token = "0x600D195")]
		public abstract void OnTakeDamage(ref Modifier modifier);

		// Token: 0x0600D196 RID: 53654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D196")]
		[Address(RVA = "0x353D3D0", Offset = "0x353BFD0", VA = "0x18353D3D0", Slot = "34")]
		public virtual Transform GetMountPoint(Entity.MountPointType mountPointType)
		{
			return null;
		}

		// Token: 0x0600D197 RID: 53655 RVA: 0x0004B858 File Offset: 0x00049A58
		[Token(Token = "0x600D197")]
		[Address(RVA = "0x353DF60", Offset = "0x353CB60", VA = "0x18353DF60", Slot = "35")]
		public virtual bool TryHookEffect(string originEffectKey, out string newEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600D198 RID: 53656 RVA: 0x0004B870 File Offset: 0x00049A70
		[Token(Token = "0x600D198")]
		[Address(RVA = "0x353E0C0", Offset = "0x353CCC0", VA = "0x18353E0C0", Slot = "36")]
		public virtual bool TryIgnoreEffect(string originEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600D199 RID: 53657 RVA: 0x0004B888 File Offset: 0x00049A88
		[Token(Token = "0x600D199")]
		[Address(RVA = "0x353DEA0", Offset = "0x353CAA0", VA = "0x18353DEA0", Slot = "37")]
		public virtual bool TryHookAudio(string signal, string subSignal, out string newSignal, out string newSubsignal)
		{
			return default(bool);
		}

		// Token: 0x0600D19A RID: 53658 RVA: 0x0004B8A0 File Offset: 0x00049AA0
		[Token(Token = "0x600D19A")]
		[Address(RVA = "0x353E000", Offset = "0x353CC00", VA = "0x18353E000", Slot = "38")]
		public virtual bool TryHookProjectile(string originProjectileKey, out string graphicProjectileKey, out string logicProjectile, out Entity.MountPointType muzzlePoint)
		{
			return default(bool);
		}

		// Token: 0x0600D19B RID: 53659
		[Token(Token = "0x600D19B")]
		public abstract UnitAnimator.CurrentAniState GetCurrentAniState();

		// Token: 0x0600D19C RID: 53660
		[Token(Token = "0x600D19C")]
		protected abstract float PlayAnimationInternal(string animKey, bool forceFromStart, float speed);

		// Token: 0x0600D19D RID: 53661
		[Token(Token = "0x600D19D")]
		protected abstract bool ContainsAnimationInternal(string animKey, bool allowEmpty);

		// Token: 0x0600D19E RID: 53662
		[Token(Token = "0x600D19E")]
		protected abstract bool GetAnimationTimeInternal(string animKey, out float time);

		// Token: 0x0600D19F RID: 53663
		[Token(Token = "0x600D19F")]
		protected abstract bool GetAnimationTimeInternal(string animKey, out float time, out float speed);

		// Token: 0x0600D1A0 RID: 53664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1A0")]
		[Address(RVA = "0x353CB80", Offset = "0x353B780", VA = "0x18353CB80", Slot = "44")]
		protected virtual void DoResetColor(UnitAnimator oldAnimator)
		{
		}

		// Token: 0x0600D1A1 RID: 53665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1A1")]
		[Address(RVA = "0x353D610", Offset = "0x353C210", VA = "0x18353D610")]
		public void OnEvent(UnitAnimator.Behaviour.Event @event, ValueBundle arg)
		{
		}

		// Token: 0x0600D1A2 RID: 53666 RVA: 0x0004B8B8 File Offset: 0x00049AB8
		[Token(Token = "0x600D1A2")]
		[Address(RVA = "0x353C910", Offset = "0x353B510", VA = "0x18353C910")]
		public static SharedConsts.Direction CalculateDirection(Vector2 newDir, Vector2 oldDir)
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x0600D1A3 RID: 53667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1A3")]
		[Address(RVA = "0x353DCD0", Offset = "0x353C8D0", VA = "0x18353DCD0")]
		protected void SetLeftOrRight(SharedConsts.Direction lOrR)
		{
		}

		// Token: 0x0600D1A4 RID: 53668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1A4")]
		[Address(RVA = "0x353CD60", Offset = "0x353B960", VA = "0x18353CD60", Slot = "45")]
		protected virtual void DoUpdateFaceSign(int faceSign)
		{
		}

		// Token: 0x0600D1A5 RID: 53669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1A5")]
		[Address(RVA = "0x353C850", Offset = "0x353B450", VA = "0x18353C850", Slot = "46")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600D1A6 RID: 53670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1A6")]
		[Address(RVA = "0x353CFD0", Offset = "0x353BBD0", VA = "0x18353CFD0", Slot = "4")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600D1A7 RID: 53671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1A7")]
		[Address(RVA = "0x353E200", Offset = "0x353CE00", VA = "0x18353E200")]
		protected UnitAnimator()
		{
		}

		// Token: 0x0400DFF4 RID: 57332
		[Token(Token = "0x400DFF4")]
		private const float L_OR_R_THRESHOLD = 0.05f;

		// Token: 0x0400DFF5 RID: 57333
		[Token(Token = "0x400DFF5")]
		[FieldOffset(Offset = "0x18")]
		private int m_faceSign;

		// Token: 0x0400DFF6 RID: 57334
		[Token(Token = "0x400DFF6")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 m_originScale;

		// Token: 0x0400DFF7 RID: 57335
		[Token(Token = "0x400DFF7")]
		[FieldOffset(Offset = "0x28")]
		private TransformGroup m_muzzlesGroup;

		// Token: 0x0400DFF8 RID: 57336
		[Token(Token = "0x400DFF8")]
		[FieldOffset(Offset = "0x30")]
		protected UnitAnimator.Behaviour[] m_behaviours;

		// Token: 0x0400DFFA RID: 57338
		[Token(Token = "0x400DFFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_faceSign;

		// Token: 0x0400DFFB RID: 57339
		[Token(Token = "0x400DFFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_faceToBack;

		// Token: 0x0400DFFC RID: 57340
		[Token(Token = "0x400DFFC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_faceToDown;

		// Token: 0x0400DFFD RID: 57341
		[Token(Token = "0x400DFFD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_faceLOrR;

		// Token: 0x0400DFFE RID: 57342
		[Token(Token = "0x400DFFE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_meshRenderer;

		// Token: 0x0400DFFF RID: 57343
		[Token(Token = "0x400DFFF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_meshFilter;

		// Token: 0x0400E000 RID: 57344
		[Token(Token = "0x400E000")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_scale;

		// Token: 0x0400E001 RID: 57345
		[Token(Token = "0x400E001")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_graphicFootTransform;

		// Token: 0x0400E002 RID: 57346
		[Token(Token = "0x400E002")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_host;

		// Token: 0x0400E003 RID: 57347
		[Token(Token = "0x400E003")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_host;

		// Token: 0x0400E004 RID: 57348
		[Token(Token = "0x400E004")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_skinHooker;

		// Token: 0x0400E005 RID: 57349
		[Token(Token = "0x400E005")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_hooker;

		// Token: 0x0400E006 RID: 57350
		[Token(Token = "0x400E006")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400E007 RID: 57351
		[Token(Token = "0x400E007")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EnableVisualPart;

		// Token: 0x0400E008 RID: 57352
		[Token(Token = "0x400E008")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400E009 RID: 57353
		[Token(Token = "0x400E009")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SyncFrom;

		// Token: 0x0400E00A RID: 57354
		[Token(Token = "0x400E00A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_FetchMuzzleTransform;

		// Token: 0x0400E00B RID: 57355
		[Token(Token = "0x400E00B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_UpdateTimeScale;

		// Token: 0x0400E00C RID: 57356
		[Token(Token = "0x400E00C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400E00D RID: 57357
		[Token(Token = "0x400E00D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400E00E RID: 57358
		[Token(Token = "0x400E00E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400E00F RID: 57359
		[Token(Token = "0x400E00F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnUnitPostInit;

		// Token: 0x0400E010 RID: 57360
		[Token(Token = "0x400E010")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0400E011 RID: 57361
		[Token(Token = "0x400E011")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_PlayAnimation;

		// Token: 0x0400E012 RID: 57362
		[Token(Token = "0x400E012")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ContainsAnimation;

		// Token: 0x0400E013 RID: 57363
		[Token(Token = "0x400E013")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetAnimationTime;

		// Token: 0x0400E014 RID: 57364
		[Token(Token = "0x400E014")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix1_GetAnimationTime;

		// Token: 0x0400E015 RID: 57365
		[Token(Token = "0x400E015")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_TryLoadEffectOverrideMap;

		// Token: 0x0400E016 RID: 57366
		[Token(Token = "0x400E016")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetMountPoint;

		// Token: 0x0400E017 RID: 57367
		[Token(Token = "0x400E017")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_TryHookEffect;

		// Token: 0x0400E018 RID: 57368
		[Token(Token = "0x400E018")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_TryIgnoreEffect;

		// Token: 0x0400E019 RID: 57369
		[Token(Token = "0x400E019")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_TryHookAudio;

		// Token: 0x0400E01A RID: 57370
		[Token(Token = "0x400E01A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_TryHookProjectile;

		// Token: 0x0400E01B RID: 57371
		[Token(Token = "0x400E01B")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_DoResetColor;

		// Token: 0x0400E01C RID: 57372
		[Token(Token = "0x400E01C")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0400E01D RID: 57373
		[Token(Token = "0x400E01D")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CalculateDirection;

		// Token: 0x0400E01E RID: 57374
		[Token(Token = "0x400E01E")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_SetLeftOrRight;

		// Token: 0x0400E01F RID: 57375
		[Token(Token = "0x400E01F")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_DoUpdateFaceSign;

		// Token: 0x0400E020 RID: 57376
		[Token(Token = "0x400E020")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400E021 RID: 57377
		[Token(Token = "0x400E021")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400E022 RID: 57378
		[Token(Token = "0x400E022")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002148 RID: 8520
		[Token(Token = "0x2002148")]
		public abstract class Behaviour : MonoBehaviour, IHotfixable
		{
			// Token: 0x1700191B RID: 6427
			// (get) Token: 0x0600D1A8 RID: 53672 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D1A9 RID: 53673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700191B")]
			private protected UnitAnimator animator
			{
				[Token(Token = "0x600D1A8")]
				[Address(RVA = "0x3533540", Offset = "0x3532140", VA = "0x183533540")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600D1A9")]
				[Address(RVA = "0x35335A0", Offset = "0x35321A0", VA = "0x1835335A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600D1AA RID: 53674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D1AA")]
			[Address(RVA = "0x35332E0", Offset = "0x3531EE0", VA = "0x1835332E0", Slot = "4")]
			public virtual void Init(UnitAnimator unitAnimator)
			{
			}

			// Token: 0x0600D1AB RID: 53675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D1AB")]
			[Address(RVA = "0x3533420", Offset = "0x3532020", VA = "0x183533420", Slot = "5")]
			public virtual void OnFinish()
			{
			}

			// Token: 0x0600D1AC RID: 53676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D1AC")]
			[Address(RVA = "0x3533480", Offset = "0x3532080", VA = "0x183533480", Slot = "6")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600D1AD RID: 53677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D1AD")]
			[Address(RVA = "0x3533390", Offset = "0x3531F90", VA = "0x183533390", Slot = "7")]
			public virtual void OnEvent(UnitAnimator.Behaviour.Event ev, ValueBundle arg)
			{
			}

			// Token: 0x0600D1AE RID: 53678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D1AE")]
			[Address(RVA = "0x35334E0", Offset = "0x35320E0", VA = "0x1835334E0")]
			protected Behaviour()
			{
			}

			// Token: 0x0400E024 RID: 57380
			[Token(Token = "0x400E024")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_animator;

			// Token: 0x0400E025 RID: 57381
			[Token(Token = "0x400E025")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_animator;

			// Token: 0x0400E026 RID: 57382
			[Token(Token = "0x400E026")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400E027 RID: 57383
			[Token(Token = "0x400E027")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnFinish;

			// Token: 0x0400E028 RID: 57384
			[Token(Token = "0x400E028")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0400E029 RID: 57385
			[Token(Token = "0x400E029")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnEvent;

			// Token: 0x0400E02A RID: 57386
			[Token(Token = "0x400E02A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02002149 RID: 8521
			[Token(Token = "0x2002149")]
			public enum Event
			{
				// Token: 0x0400E02C RID: 57388
				[Token(Token = "0x400E02C")]
				ON_SPINE_ANIMATOR_RESET_SKELETON,
				// Token: 0x0400E02D RID: 57389
				[Token(Token = "0x400E02D")]
				ON_ANIMATION_STOP,
				// Token: 0x0400E02E RID: 57390
				[Token(Token = "0x400E02E")]
				ON_PLAY_ANIMATION,
				// Token: 0x0400E02F RID: 57391
				[Token(Token = "0x400E02F")]
				ON_CUSTOM_TRIGGER,
				// Token: 0x0400E030 RID: 57392
				[Token(Token = "0x400E030")]
				ENUM
			}
		}

		// Token: 0x0200214A RID: 8522
		[Token(Token = "0x200214A")]
		public struct CurrentAniState
		{
			// Token: 0x0400E031 RID: 57393
			[Token(Token = "0x400E031")]
			[FieldOffset(Offset = "0x0")]
			public string animKey;

			// Token: 0x0400E032 RID: 57394
			[Token(Token = "0x400E032")]
			[FieldOffset(Offset = "0x8")]
			public float playSpeed;
		}
	}
}
