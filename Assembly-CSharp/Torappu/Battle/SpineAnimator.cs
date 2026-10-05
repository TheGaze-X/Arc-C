using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200212E RID: 8494
	[Token(Token = "0x200212E")]
	public abstract class SpineAnimator : UnitAnimator, IEffectSource, IProjectileSource, IOnPrefabUpdated
	{
		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x0600D0A0 RID: 53408 RVA: 0x0004B3A8 File Offset: 0x000495A8
		// (set) Token: 0x0600D0A1 RID: 53409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170018F0")]
		public override Color color
		{
			[Token(Token = "0x600D0A0")]
			[Address(RVA = "0x3521B10", Offset = "0x3520710", VA = "0x183521B10", Slot = "5")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600D0A1")]
			[Address(RVA = "0x3521E30", Offset = "0x3520A30", VA = "0x183521E30", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x0600D0A2 RID: 53410 RVA: 0x0004B3C0 File Offset: 0x000495C0
		// (set) Token: 0x0600D0A3 RID: 53411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170018F1")]
		public bool lockColor
		{
			[Token(Token = "0x600D0A2")]
			[Address(RVA = "0x3521BC0", Offset = "0x35207C0", VA = "0x183521BC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D0A3")]
			[Address(RVA = "0x3521F40", Offset = "0x3520B40", VA = "0x183521F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x0600D0A4 RID: 53412 RVA: 0x0004B3D8 File Offset: 0x000495D8
		// (set) Token: 0x0600D0A5 RID: 53413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170018F2")]
		public bool useBakeMuzzle
		{
			[Token(Token = "0x600D0A4")]
			[Address(RVA = "0x3521D40", Offset = "0x3520940", VA = "0x183521D40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D0A5")]
			[Address(RVA = "0x3521FB0", Offset = "0x3520BB0", VA = "0x183521FB0")]
			private set
			{
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x0600D0A6 RID: 53414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018F3")]
		public string bakeMuzzleAnimName
		{
			[Token(Token = "0x600D0A6")]
			[Address(RVA = "0x35219C0", Offset = "0x35205C0", VA = "0x1835219C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x0600D0A7 RID: 53415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018F4")]
		public string bakeMuzzleFaceKey
		{
			[Token(Token = "0x600D0A7")]
			[Address(RVA = "0x3521A30", Offset = "0x3520630", VA = "0x183521A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x0600D0A8 RID: 53416 RVA: 0x0004B3F0 File Offset: 0x000495F0
		[Token(Token = "0x170018F5")]
		public FP bakeMuzzleTime
		{
			[Token(Token = "0x600D0A8")]
			[Address(RVA = "0x3521AA0", Offset = "0x35206A0", VA = "0x183521AA0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x0600D0A9 RID: 53417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018F6")]
		public override CharacterSkinHooker skinHooker
		{
			[Token(Token = "0x600D0A9")]
			[Address(RVA = "0x3521C20", Offset = "0x3520820", VA = "0x183521C20", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x0600D0AA RID: 53418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018F7")]
		public CharacterAudioHooker audioHooker
		{
			[Token(Token = "0x600D0AA")]
			[Address(RVA = "0x3521960", Offset = "0x3520560", VA = "0x183521960")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x0600D0AB RID: 53419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018F8")]
		public SpineSkinAudioHooker spineSkinHooker
		{
			[Token(Token = "0x600D0AB")]
			[Address(RVA = "0x3521CE0", Offset = "0x35208E0", VA = "0x183521CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x0600D0AC RID: 53420 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D0AD RID: 53421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170018F9")]
		public SpineAnimator.AnimationData[] animations
		{
			[Token(Token = "0x600D0AC")]
			[Address(RVA = "0x3521900", Offset = "0x3520500", VA = "0x183521900")]
			get
			{
				return null;
			}
			[Token(Token = "0x600D0AD")]
			[Address(RVA = "0x3521DB0", Offset = "0x35209B0", VA = "0x183521DB0")]
			set
			{
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x0600D0AE RID: 53422
		[Token(Token = "0x170018FA")]
		public abstract SkeletonAnimation skeleton { [Token(Token = "0x600D0AE")] get; }

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x0600D0AF RID: 53423
		[Token(Token = "0x170018FB")]
		public abstract string bakedDataKey { [Token(Token = "0x600D0AF")] get; }

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600D0B0 RID: 53424
		[Token(Token = "0x170018FC")]
		public abstract FaceSwitcher faceSwitcher { [Token(Token = "0x600D0B0")] get; }

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x0600D0B1 RID: 53425 RVA: 0x0004B408 File Offset: 0x00049608
		[Token(Token = "0x170018FD")]
		protected virtual bool useNewSpineFormat
		{
			[Token(Token = "0x600D0B1")]
			[Address(RVA = "0x350BA60", Offset = "0x350A660", VA = "0x18350BA60", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x0600D0B2 RID: 53426 RVA: 0x0004B420 File Offset: 0x00049620
		[Token(Token = "0x170018FE")]
		public float spineScale
		{
			[Token(Token = "0x600D0B2")]
			[Address(RVA = "0x3521C80", Offset = "0x3520880", VA = "0x183521C80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600D0B3 RID: 53427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0B3")]
		[Address(RVA = "0x351C550", Offset = "0x351B150", VA = "0x18351C550", Slot = "21")]
		public override void Init(Unit host)
		{
		}

		// Token: 0x0600D0B4 RID: 53428
		[Token(Token = "0x600D0B4")]
		public abstract string GetFaceKey(IFaceConfiguration faceConfig);

		// Token: 0x0600D0B5 RID: 53429
		[Token(Token = "0x600D0B5")]
		public abstract IFaceConfiguration GetFaceConfiguration(string faceKey);

		// Token: 0x0600D0B6 RID: 53430
		[Token(Token = "0x600D0B6")]
		public abstract IFaceConfiguration GetActiveFace();

		// Token: 0x0600D0B7 RID: 53431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D0B7")]
		[Address(RVA = "0x351B5C0", Offset = "0x351A1C0", VA = "0x18351B5C0")]
		public string GetActiveFaceKey()
		{
			return null;
		}

		// Token: 0x0600D0B8 RID: 53432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0B8")]
		[Address(RVA = "0x351C9D0", Offset = "0x351B5D0", VA = "0x18351C9D0")]
		private void OnMeshUpdated(SkeletonRenderer render)
		{
		}

		// Token: 0x0600D0B9 RID: 53433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0B9")]
		[Address(RVA = "0x351E650", Offset = "0x351D250", VA = "0x18351E650", Slot = "23")]
		public override void Stop()
		{
		}

		// Token: 0x0600D0BA RID: 53434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0BA")]
		[Address(RVA = "0x351AF20", Offset = "0x3519B20", VA = "0x18351AF20", Slot = "44")]
		protected override void DoResetColor(UnitAnimator oldAnimator)
		{
		}

		// Token: 0x0600D0BB RID: 53435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0BB")]
		[Address(RVA = "0x351CAE0", Offset = "0x351B6E0", VA = "0x18351CAE0", Slot = "26")]
		public override void OnReset(UnitAnimator old)
		{
		}

		// Token: 0x0600D0BC RID: 53436 RVA: 0x0004B438 File Offset: 0x00049638
		[Token(Token = "0x600D0BC")]
		[Address(RVA = "0x351BAA0", Offset = "0x351A6A0", VA = "0x18351BAA0", Slot = "39")]
		public override UnitAnimator.CurrentAniState GetCurrentAniState()
		{
			return default(UnitAnimator.CurrentAniState);
		}

		// Token: 0x0600D0BD RID: 53437 RVA: 0x0004B450 File Offset: 0x00049650
		[Token(Token = "0x600D0BD")]
		[Address(RVA = "0x351E510", Offset = "0x351D110", VA = "0x18351E510")]
		public bool SetSpineSkin(string skinKey)
		{
			return default(bool);
		}

		// Token: 0x0600D0BE RID: 53438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0BE")]
		[Address(RVA = "0x351F960", Offset = "0x351E560", VA = "0x18351F960", Slot = "25")]
		public override void UpdateTimeScale(float speed)
		{
		}

		// Token: 0x0600D0BF RID: 53439 RVA: 0x0004B468 File Offset: 0x00049668
		[Token(Token = "0x600D0BF")]
		[Address(RVA = "0x351D570", Offset = "0x351C170", VA = "0x18351D570", Slot = "40")]
		protected override float PlayAnimationInternal(string animKey, bool forceFromStart, float speed)
		{
			return 0f;
		}

		// Token: 0x0600D0C0 RID: 53440 RVA: 0x0004B480 File Offset: 0x00049680
		[Token(Token = "0x600D0C0")]
		[Address(RVA = "0x351AE20", Offset = "0x3519A20", VA = "0x18351AE20", Slot = "41")]
		protected override bool ContainsAnimationInternal(string animKey, bool allowEmpty)
		{
			return default(bool);
		}

		// Token: 0x0600D0C1 RID: 53441 RVA: 0x0004B498 File Offset: 0x00049698
		[Token(Token = "0x600D0C1")]
		[Address(RVA = "0x351B830", Offset = "0x351A430", VA = "0x18351B830", Slot = "42")]
		protected override bool GetAnimationTimeInternal(string animKey, out float time)
		{
			return default(bool);
		}

		// Token: 0x0600D0C2 RID: 53442 RVA: 0x0004B4B0 File Offset: 0x000496B0
		[Token(Token = "0x600D0C2")]
		[Address(RVA = "0x351B910", Offset = "0x351A510", VA = "0x18351B910", Slot = "43")]
		protected override bool GetAnimationTimeInternal(string animKey, out float time, out float speed)
		{
			return default(bool);
		}

		// Token: 0x0600D0C3 RID: 53443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0C3")]
		[Address(RVA = "0x351CDA0", Offset = "0x351B9A0", VA = "0x18351CDA0", Slot = "33")]
		public override void OnTakeDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600D0C4 RID: 53444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0C4")]
		[Address(RVA = "0x351C950", Offset = "0x351B550", VA = "0x18351C950", Slot = "27")]
		public override void OnFinish()
		{
		}

		// Token: 0x0600D0C5 RID: 53445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0C5")]
		[Address(RVA = "0x351D1E0", Offset = "0x351BDE0", VA = "0x18351D1E0", Slot = "28")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600D0C6 RID: 53446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0C6")]
		[Address(RVA = "0x35210D0", Offset = "0x351FCD0", VA = "0x1835210D0")]
		private void _TickSpineManually(FP deltaTime)
		{
		}

		// Token: 0x0600D0C7 RID: 53447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0C7")]
		[Address(RVA = "0x351FAD0", Offset = "0x351E6D0", VA = "0x18351FAD0")]
		private void Update()
		{
		}

		// Token: 0x0600D0C8 RID: 53448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0C8")]
		[Address(RVA = "0x3520DD0", Offset = "0x351F9D0", VA = "0x183520DD0")]
		private void _SetupInitSpineSkin()
		{
		}

		// Token: 0x0600D0C9 RID: 53449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0C9")]
		[Address(RVA = "0x351D350", Offset = "0x351BF50", VA = "0x18351D350", Slot = "29")]
		public override void OnUnitPostInit()
		{
		}

		// Token: 0x0600D0CA RID: 53450 RVA: 0x0004B4C8 File Offset: 0x000496C8
		[Token(Token = "0x600D0CA")]
		[Address(RVA = "0x351F080", Offset = "0x351DC80", VA = "0x18351F080", Slot = "35")]
		public override bool TryHookEffect(string originEffectKey, out string newEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600D0CB RID: 53451 RVA: 0x0004B4E0 File Offset: 0x000496E0
		[Token(Token = "0x600D0CB")]
		[Address(RVA = "0x351EE40", Offset = "0x351DA40", VA = "0x18351EE40", Slot = "37")]
		public override bool TryHookAudio(string signal, string subSignal, out string newSignal, out string newSubsignal)
		{
			return default(bool);
		}

		// Token: 0x0600D0CC RID: 53452 RVA: 0x0004B4F8 File Offset: 0x000496F8
		[Token(Token = "0x600D0CC")]
		[Address(RVA = "0x351F1A0", Offset = "0x351DDA0", VA = "0x18351F1A0", Slot = "38")]
		public override bool TryHookProjectile(string originProjectileKey, out string graphicProjectileKey, out string logicProjectile, out Entity.MountPointType muzzlePoint)
		{
			return default(bool);
		}

		// Token: 0x0600D0CD RID: 53453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0CD")]
		[Address(RVA = "0x351B3B0", Offset = "0x3519FB0", VA = "0x18351B3B0", Slot = "4")]
		public new void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600D0CE RID: 53454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0CE")]
		[Address(RVA = "0x351B2C0", Offset = "0x3519EC0", VA = "0x18351B2C0")]
		public void GatherEffectsBlackList(List<string> blackList, List<string> blackListIncludeSkin)
		{
		}

		// Token: 0x0600D0CF RID: 53455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0CF")]
		[Address(RVA = "0x351B4E0", Offset = "0x351A0E0", VA = "0x18351B4E0", Slot = "47")]
		public void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0600D0D0 RID: 53456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0D0")]
		[Address(RVA = "0x351ACA0", Offset = "0x35198A0", VA = "0x18351ACA0", Slot = "46")]
		protected override void Awake()
		{
		}

		// Token: 0x0600D0D1 RID: 53457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0D1")]
		[Address(RVA = "0x351CA80", Offset = "0x351B680", VA = "0x18351CA80", Slot = "48")]
		public void OnPrefabUpdated()
		{
		}

		// Token: 0x0600D0D2 RID: 53458 RVA: 0x0004B510 File Offset: 0x00049710
		[Token(Token = "0x600D0D2")]
		[Address(RVA = "0x351D740", Offset = "0x351C340", VA = "0x18351D740")]
		protected float PlayAnimation(SpineAnimator.AnimationData data, bool forceFromStart, float speed)
		{
			return 0f;
		}

		// Token: 0x0600D0D3 RID: 53459 RVA: 0x0004B528 File Offset: 0x00049728
		[Token(Token = "0x600D0D3")]
		[Address(RVA = "0x351EB80", Offset = "0x351D780", VA = "0x18351EB80")]
		protected bool TryApplyCustomMixAnimSettings(string sourceAnimName, string targetAnimName, bool loop)
		{
			return default(bool);
		}

		// Token: 0x0600D0D4 RID: 53460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0D4")]
		[Address(RVA = "0x351E3C0", Offset = "0x351CFC0", VA = "0x18351E3C0", Slot = "56")]
		protected virtual void SetSpineSkinInternal(SpineAnimator.SpineSkinData data)
		{
		}

		// Token: 0x0600D0D5 RID: 53461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D0D5")]
		[Address(RVA = "0x351B750", Offset = "0x351A350", VA = "0x18351B750", Slot = "57")]
		protected virtual SpineAnimator.AnimationData GetAnimationData(string animKey, bool ignoreInvalid)
		{
			return null;
		}

		// Token: 0x0600D0D6 RID: 53462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D0D6")]
		[Address(RVA = "0x351BF90", Offset = "0x351AB90", VA = "0x18351BF90")]
		protected SpineAnimator.SpineSkinData GetSpineSkinData(string skinKey)
		{
			return null;
		}

		// Token: 0x0600D0D7 RID: 53463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D0D7")]
		[Address(RVA = "0x351BB30", Offset = "0x351A730", VA = "0x18351BB30")]
		protected Skin GetOrCreateSpineSkin(SpineAnimator.SpineSkinData data, SkeletonAnimation skel)
		{
			return null;
		}

		// Token: 0x0600D0D8 RID: 53464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0D8")]
		[Address(RVA = "0x351C050", Offset = "0x351AC50", VA = "0x18351C050", Slot = "58")]
		protected virtual void InitAnimationDataIfNot()
		{
		}

		// Token: 0x0600D0D9 RID: 53465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0D9")]
		[Address(RVA = "0x351F430", Offset = "0x351E030", VA = "0x18351F430", Slot = "59")]
		protected virtual void UpdateAnimationData(bool checkMissing)
		{
		}

		// Token: 0x0600D0DA RID: 53466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0DA")]
		[Address(RVA = "0x351F6F0", Offset = "0x351E2F0", VA = "0x18351F6F0", Slot = "60")]
		protected virtual void UpdateSpineSkinData()
		{
		}

		// Token: 0x0600D0DB RID: 53467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0DB")]
		[Address(RVA = "0x351E1B0", Offset = "0x351CDB0", VA = "0x18351E1B0")]
		protected void ResetSkeletonToDefaultPose(SkeletonAnimation skeleton)
		{
		}

		// Token: 0x0600D0DC RID: 53468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0DC")]
		[Address(RVA = "0x3520BC0", Offset = "0x351F7C0", VA = "0x183520BC0")]
		private void _RegisterSkeletonEvents(SkeletonAnimation skeleton)
		{
		}

		// Token: 0x0600D0DD RID: 53469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0DD")]
		[Address(RVA = "0x351C7D0", Offset = "0x351B3D0", VA = "0x18351C7D0")]
		protected void MakeDisappearNextFrame(SkeletonAnimation skeleton)
		{
		}

		// Token: 0x0600D0DE RID: 53470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0DE")]
		[Address(RVA = "0x351C2C0", Offset = "0x351AEC0", VA = "0x18351C2C0", Slot = "61")]
		public virtual void InitShaders()
		{
		}

		// Token: 0x0600D0DF RID: 53471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0DF")]
		[Address(RVA = "0x350B780", Offset = "0x350A380", VA = "0x18350B780", Slot = "62")]
		public virtual void ReplaceShader()
		{
		}

		// Token: 0x0600D0E0 RID: 53472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0E0")]
		[Address(RVA = "0x351DBB0", Offset = "0x351C7B0", VA = "0x18351DBB0")]
		protected void ReplaceSkeletonAtlasShaders(SkeletonAnimation spine, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x0600D0E1 RID: 53473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0E1")]
		[Address(RVA = "0x351DF70", Offset = "0x351CB70", VA = "0x18351DF70")]
		protected void ResetSkeletonAtlasShaders(SkeletonAnimation spine)
		{
		}

		// Token: 0x0600D0E2 RID: 53474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0E2")]
		[Address(RVA = "0x350B870", Offset = "0x350A470", VA = "0x18350B870", Slot = "63")]
		public virtual void UpdateBaseline()
		{
		}

		// Token: 0x0600D0E3 RID: 53475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D0E3")]
		[Address(RVA = "0x351B9F0", Offset = "0x351A5F0", VA = "0x18351B9F0", Slot = "64")]
		public virtual MountPoint GetBakeMountPoint(Entity.MountPointType mountType)
		{
			return null;
		}

		// Token: 0x0600D0E4 RID: 53476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0E4")]
		[Address(RVA = "0x351C360", Offset = "0x351AF60", VA = "0x18351C360", Slot = "65")]
		protected virtual void InitSkeletonAnimation(SkeletonAnimation skeleton)
		{
		}

		// Token: 0x0600D0E5 RID: 53477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0E5")]
		[Address(RVA = "0x351E780", Offset = "0x351D380", VA = "0x18351E780")]
		protected void SyncAnimationState(IFaceConfiguration toFace, IFaceConfiguration fromFace)
		{
		}

		// Token: 0x0600D0E6 RID: 53478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0E6")]
		[Address(RVA = "0x3520330", Offset = "0x351EF30", VA = "0x183520330")]
		protected void _ForceUpdateAnimation(SkeletonAnimation skeleton)
		{
		}

		// Token: 0x0600D0E7 RID: 53479 RVA: 0x0004B540 File Offset: 0x00049740
		[Token(Token = "0x600D0E7")]
		[Address(RVA = "0x35213A0", Offset = "0x351FFA0", VA = "0x1835213A0")]
		protected bool _TryGotoMixTarget(SkeletonAnimation from, SkeletonAnimation to)
		{
			return default(bool);
		}

		// Token: 0x0600D0E8 RID: 53480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0E8")]
		[Address(RVA = "0x351B000", Offset = "0x3519C00", VA = "0x18351B000", Slot = "45")]
		protected override void DoUpdateFaceSign(int faceSign)
		{
		}

		// Token: 0x0600D0E9 RID: 53481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0E9")]
		[Address(RVA = "0x351B1B0", Offset = "0x3519DB0", VA = "0x18351B1B0")]
		protected void FlipSkeletonAnimation(SkeletonAnimation skeleton, int faceSign)
		{
		}

		// Token: 0x0600D0EA RID: 53482
		[Token(Token = "0x600D0EA")]
		protected abstract void ForEachSkeleton(Action<SkeletonAnimation> func);

		// Token: 0x0600D0EB RID: 53483
		[Token(Token = "0x600D0EB")]
		public abstract void ForEachFaceConfiguration(Action<IFaceConfiguration> func);

		// Token: 0x0600D0EC RID: 53484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0EC")]
		[Address(RVA = "0x35204E0", Offset = "0x351F0E0", VA = "0x1835204E0")]
		private void _OnEvent(TrackEntry entry, Spine.Event e)
		{
		}

		// Token: 0x0600D0ED RID: 53485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D0ED")]
		[Address(RVA = "0x3520D00", Offset = "0x351F900", VA = "0x183520D00")]
		private IEnumerator _ResetSetAlphaInFirstFrame(SkeletonAnimation skeleton)
		{
			return null;
		}

		// Token: 0x0600D0EE RID: 53486 RVA: 0x0004B558 File Offset: 0x00049758
		[Token(Token = "0x600D0EE")]
		[Address(RVA = "0x3520200", Offset = "0x351EE00", VA = "0x183520200")]
		private bool _CheckShowDamageFlash(ref Modifier modifier)
		{
			return default(bool);
		}

		// Token: 0x0600D0EF RID: 53487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0EF")]
		[Address(RVA = "0x3520A10", Offset = "0x351F610", VA = "0x183520A10")]
		private void _PlayBattleAudio(string signalId)
		{
		}

		// Token: 0x0600D0F0 RID: 53488 RVA: 0x0004B570 File Offset: 0x00049770
		[Token(Token = "0x600D0F0")]
		[Address(RVA = "0x350B7F0", Offset = "0x350A3F0", VA = "0x18350B7F0", Slot = "68")]
		protected virtual bool TryGetSpinePrefix(out string prefix)
		{
			return default(bool);
		}

		// Token: 0x0600D0F1 RID: 53489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D0F1")]
		[Address(RVA = "0x351B680", Offset = "0x351A280", VA = "0x18351B680")]
		protected string GetAnimName(SpineAnimator.AnimationData data)
		{
			return null;
		}

		// Token: 0x0600D0F2 RID: 53490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0F2")]
		[Address(RVA = "0x351FDE0", Offset = "0x351E9E0", VA = "0x18351FDE0")]
		private void _CheckMesh()
		{
		}

		// Token: 0x0600D0F3 RID: 53491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D0F3")]
		[Address(RVA = "0x351BE10", Offset = "0x351AA10", VA = "0x18351BE10")]
		public static SkeletonAnimation GetSkeletonOrNull(UnitAnimator animator)
		{
			return null;
		}

		// Token: 0x0600D0F4 RID: 53492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0F4")]
		[Address(RVA = "0x35216D0", Offset = "0x35202D0", VA = "0x1835216D0")]
		protected SpineAnimator()
		{
		}

		// Token: 0x0600D0F6 RID: 53494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D0F6")]
		[Address(RVA = "0x350E8C0", Offset = "0x350D4C0", VA = "0x18350E8C0")]
		private CharacterSkinHooker <>xLuaBaseProxy_get_skinHooker()
		{
			return null;
		}

		// Token: 0x0600D0F7 RID: 53495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0F7")]
		[Address(RVA = "0x3514160", Offset = "0x3512D60", VA = "0x183514160")]
		private void <>xLuaBaseProxy_Init(Unit P0)
		{
		}

		// Token: 0x0600D0F8 RID: 53496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0F8")]
		[Address(RVA = "0x350E890", Offset = "0x350D490", VA = "0x18350E890")]
		private void <>xLuaBaseProxy_Stop()
		{
		}

		// Token: 0x0600D0F9 RID: 53497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0F9")]
		[Address(RVA = "0x3514130", Offset = "0x3512D30", VA = "0x183514130")]
		private void <>xLuaBaseProxy_DoResetColor(UnitAnimator P0)
		{
		}

		// Token: 0x0600D0FA RID: 53498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0FA")]
		[Address(RVA = "0x351F3D0", Offset = "0x351DFD0", VA = "0x18351F3D0")]
		private void <>xLuaBaseProxy_OnReset(UnitAnimator P0)
		{
		}

		// Token: 0x0600D0FB RID: 53499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0FB")]
		[Address(RVA = "0x351F420", Offset = "0x351E020", VA = "0x18351F420")]
		private void <>xLuaBaseProxy_UpdateTimeScale(float P0)
		{
		}

		// Token: 0x0600D0FC RID: 53500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0FC")]
		[Address(RVA = "0x3514170", Offset = "0x3512D70", VA = "0x183514170")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600D0FD RID: 53501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0FD")]
		[Address(RVA = "0x351F3E0", Offset = "0x351DFE0", VA = "0x18351F3E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600D0FE RID: 53502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D0FE")]
		[Address(RVA = "0x351F3F0", Offset = "0x351DFF0", VA = "0x18351F3F0")]
		private void <>xLuaBaseProxy_OnUnitPostInit()
		{
		}

		// Token: 0x0600D0FF RID: 53503 RVA: 0x0004B588 File Offset: 0x00049788
		[Token(Token = "0x600D0FF")]
		[Address(RVA = "0x350E8A0", Offset = "0x350D4A0", VA = "0x18350E8A0")]
		private bool <>xLuaBaseProxy_TryHookEffect(string P0, out string P1)
		{
			return default(bool);
		}

		// Token: 0x0600D100 RID: 53504 RVA: 0x0004B5A0 File Offset: 0x000497A0
		[Token(Token = "0x600D100")]
		[Address(RVA = "0x351F400", Offset = "0x351E000", VA = "0x18351F400")]
		private bool <>xLuaBaseProxy_TryHookAudio(string P0, string P1, out string P2, out string P3)
		{
			return default(bool);
		}

		// Token: 0x0600D101 RID: 53505 RVA: 0x0004B5B8 File Offset: 0x000497B8
		[Token(Token = "0x600D101")]
		[Address(RVA = "0x351F410", Offset = "0x351E010", VA = "0x18351F410")]
		private bool <>xLuaBaseProxy_TryHookProjectile(string P0, out string P1, out string P2, out Entity.MountPointType P3)
		{
			return default(bool);
		}

		// Token: 0x0600D102 RID: 53506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D102")]
		[Address(RVA = "0x350E880", Offset = "0x350D480", VA = "0x18350E880")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x0600D103 RID: 53507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D103")]
		[Address(RVA = "0x3514140", Offset = "0x3512D40", VA = "0x183514140")]
		private void <>xLuaBaseProxy_DoUpdateFaceSign(int P0)
		{
		}

		// Token: 0x0400DF06 RID: 57094
		[Token(Token = "0x400DF06")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_options")]
		private SpineAnimator.AnimationData[] _animations;

		// Token: 0x0400DF07 RID: 57095
		[Token(Token = "0x400DF07")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SpineAnimator.SpineSkinData[] _spineSkins;

		// Token: 0x0400DF08 RID: 57096
		[Token(Token = "0x400DF08")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SpineAnimator.CustomMixAnimSetting[] _mixSettings;

		// Token: 0x0400DF09 RID: 57097
		[Token(Token = "0x400DF09")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private float _spineScale;

		// Token: 0x0400DF0A RID: 57098
		[Token(Token = "0x400DF0A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _enableShowDamageFlash;

		// Token: 0x0400DF0B RID: 57099
		[Token(Token = "0x400DF0B")]
		[FieldOffset(Offset = "0x5D")]
		[SerializeField]
		private bool _cacheBoundsCenter;

		// Token: 0x0400DF0C RID: 57100
		[Token(Token = "0x400DF0C")]
		[FieldOffset(Offset = "0x5E")]
		[SerializeField]
		private bool _resetSkinToInitial;

		// Token: 0x0400DF0D RID: 57101
		[Token(Token = "0x400DF0D")]
		[FieldOffset(Offset = "0x5F")]
		protected bool m_initDataFlag;

		// Token: 0x0400DF0E RID: 57102
		[Token(Token = "0x400DF0E")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, SpineAnimator.AnimationData> m_animationDict;

		// Token: 0x0400DF0F RID: 57103
		[Token(Token = "0x400DF0F")]
		[FieldOffset(Offset = "0x68")]
		protected Dictionary<string, SpineAnimator.SpineSkinData> m_spineSkinDataDict;

		// Token: 0x0400DF10 RID: 57104
		[Token(Token = "0x400DF10")]
		[FieldOffset(Offset = "0x70")]
		protected Dictionary<SkeletonAnimation, Dictionary<string, Skin>> m_spineSkinCache;

		// Token: 0x0400DF11 RID: 57105
		[Token(Token = "0x400DF11")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_lastTween;

		// Token: 0x0400DF12 RID: 57106
		[Token(Token = "0x400DF12")]
		[FieldOffset(Offset = "0x80")]
		protected BakeMuzzleController bakeMuzzleController;

		// Token: 0x0400DF13 RID: 57107
		[Token(Token = "0x400DF13")]
		[FieldOffset(Offset = "0x88")]
		protected float m_originFaceSwitcherX;

		// Token: 0x0400DF14 RID: 57108
		[Token(Token = "0x400DF14")]
		[FieldOffset(Offset = "0x90")]
		private FP m_skipTickTime;

		// Token: 0x0400DF15 RID: 57109
		[Token(Token = "0x400DF15")]
		[FieldOffset(Offset = "0x98")]
		private float m_resetAlphaCache;

		// Token: 0x0400DF17 RID: 57111
		[Token(Token = "0x400DF17")]
		[FieldOffset(Offset = "0xA0")]
		private CharacterSkinHooker m_skinHooker;

		// Token: 0x0400DF18 RID: 57112
		[Token(Token = "0x400DF18")]
		[FieldOffset(Offset = "0xA8")]
		private CharacterAudioHooker m_audioHooker;

		// Token: 0x0400DF19 RID: 57113
		[Token(Token = "0x400DF19")]
		[FieldOffset(Offset = "0xB0")]
		private SpineSkinAudioHooker m_spineSkinHooker;

		// Token: 0x0400DF1A RID: 57114
		[Token(Token = "0x400DF1A")]
		[FieldOffset(Offset = "0xB8")]
		private BoneFollower[] m_boneFollowers;

		// Token: 0x0400DF1B RID: 57115
		[Token(Token = "0x400DF1B")]
		[FieldOffset(Offset = "0xC0")]
		private ConstMuzzle[] m_constMuzzles;

		// Token: 0x0400DF1C RID: 57116
		[Token(Token = "0x400DF1C")]
		[FieldOffset(Offset = "0xC8")]
		private UnitAnimator.CurrentAniState m_currentAniState;

		// Token: 0x0400DF1D RID: 57117
		[Token(Token = "0x400DF1D")]
		[FieldOffset(Offset = "0xD8")]
		private SpineEffectEmitter m_spineEffectEmitter;

		// Token: 0x0400DF1E RID: 57118
		[Token(Token = "0x400DF1E")]
		private const string RUNTIME_SKIN_NAME = "RuntimeSkin";

		// Token: 0x0400DF1F RID: 57119
		[Token(Token = "0x400DF1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x0400DF20 RID: 57120
		[Token(Token = "0x400DF20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x0400DF21 RID: 57121
		[Token(Token = "0x400DF21")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lockColor;

		// Token: 0x0400DF22 RID: 57122
		[Token(Token = "0x400DF22")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_lockColor;

		// Token: 0x0400DF23 RID: 57123
		[Token(Token = "0x400DF23")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_useBakeMuzzle;

		// Token: 0x0400DF24 RID: 57124
		[Token(Token = "0x400DF24")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_useBakeMuzzle;

		// Token: 0x0400DF25 RID: 57125
		[Token(Token = "0x400DF25")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bakeMuzzleAnimName;

		// Token: 0x0400DF26 RID: 57126
		[Token(Token = "0x400DF26")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_bakeMuzzleFaceKey;

		// Token: 0x0400DF27 RID: 57127
		[Token(Token = "0x400DF27")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_bakeMuzzleTime;

		// Token: 0x0400DF28 RID: 57128
		[Token(Token = "0x400DF28")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_skinHooker;

		// Token: 0x0400DF29 RID: 57129
		[Token(Token = "0x400DF29")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_audioHooker;

		// Token: 0x0400DF2A RID: 57130
		[Token(Token = "0x400DF2A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_spineSkinHooker;

		// Token: 0x0400DF2B RID: 57131
		[Token(Token = "0x400DF2B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_animations;

		// Token: 0x0400DF2C RID: 57132
		[Token(Token = "0x400DF2C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_animations;

		// Token: 0x0400DF2D RID: 57133
		[Token(Token = "0x400DF2D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_useNewSpineFormat;

		// Token: 0x0400DF2E RID: 57134
		[Token(Token = "0x400DF2E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_spineScale;

		// Token: 0x0400DF2F RID: 57135
		[Token(Token = "0x400DF2F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DF30 RID: 57136
		[Token(Token = "0x400DF30")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetActiveFaceKey;

		// Token: 0x0400DF31 RID: 57137
		[Token(Token = "0x400DF31")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnMeshUpdated;

		// Token: 0x0400DF32 RID: 57138
		[Token(Token = "0x400DF32")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400DF33 RID: 57139
		[Token(Token = "0x400DF33")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_DoResetColor;

		// Token: 0x0400DF34 RID: 57140
		[Token(Token = "0x400DF34")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400DF35 RID: 57141
		[Token(Token = "0x400DF35")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetCurrentAniState;

		// Token: 0x0400DF36 RID: 57142
		[Token(Token = "0x400DF36")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SetSpineSkin;

		// Token: 0x0400DF37 RID: 57143
		[Token(Token = "0x400DF37")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_UpdateTimeScale;

		// Token: 0x0400DF38 RID: 57144
		[Token(Token = "0x400DF38")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_PlayAnimationInternal;

		// Token: 0x0400DF39 RID: 57145
		[Token(Token = "0x400DF39")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ContainsAnimationInternal;

		// Token: 0x0400DF3A RID: 57146
		[Token(Token = "0x400DF3A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetAnimationTimeInternal;

		// Token: 0x0400DF3B RID: 57147
		[Token(Token = "0x400DF3B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix1_GetAnimationTimeInternal;

		// Token: 0x0400DF3C RID: 57148
		[Token(Token = "0x400DF3C")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x0400DF3D RID: 57149
		[Token(Token = "0x400DF3D")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400DF3E RID: 57150
		[Token(Token = "0x400DF3E")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400DF3F RID: 57151
		[Token(Token = "0x400DF3F")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__TickSpineManually;

		// Token: 0x0400DF40 RID: 57152
		[Token(Token = "0x400DF40")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400DF41 RID: 57153
		[Token(Token = "0x400DF41")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__SetupInitSpineSkin;

		// Token: 0x0400DF42 RID: 57154
		[Token(Token = "0x400DF42")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnUnitPostInit;

		// Token: 0x0400DF43 RID: 57155
		[Token(Token = "0x400DF43")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_TryHookEffect;

		// Token: 0x0400DF44 RID: 57156
		[Token(Token = "0x400DF44")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_TryHookAudio;

		// Token: 0x0400DF45 RID: 57157
		[Token(Token = "0x400DF45")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_TryHookProjectile;

		// Token: 0x0400DF46 RID: 57158
		[Token(Token = "0x400DF46")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400DF47 RID: 57159
		[Token(Token = "0x400DF47")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GatherEffectsBlackList;

		// Token: 0x0400DF48 RID: 57160
		[Token(Token = "0x400DF48")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x0400DF49 RID: 57161
		[Token(Token = "0x400DF49")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400DF4A RID: 57162
		[Token(Token = "0x400DF4A")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_OnPrefabUpdated;

		// Token: 0x0400DF4B RID: 57163
		[Token(Token = "0x400DF4B")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_PlayAnimation;

		// Token: 0x0400DF4C RID: 57164
		[Token(Token = "0x400DF4C")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_TryApplyCustomMixAnimSettings;

		// Token: 0x0400DF4D RID: 57165
		[Token(Token = "0x400DF4D")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_SetSpineSkinInternal;

		// Token: 0x0400DF4E RID: 57166
		[Token(Token = "0x400DF4E")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_GetAnimationData;

		// Token: 0x0400DF4F RID: 57167
		[Token(Token = "0x400DF4F")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_GetSpineSkinData;

		// Token: 0x0400DF50 RID: 57168
		[Token(Token = "0x400DF50")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_GetOrCreateSpineSkin;

		// Token: 0x0400DF51 RID: 57169
		[Token(Token = "0x400DF51")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_InitAnimationDataIfNot;

		// Token: 0x0400DF52 RID: 57170
		[Token(Token = "0x400DF52")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_UpdateAnimationData;

		// Token: 0x0400DF53 RID: 57171
		[Token(Token = "0x400DF53")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_UpdateSpineSkinData;

		// Token: 0x0400DF54 RID: 57172
		[Token(Token = "0x400DF54")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_ResetSkeletonToDefaultPose;

		// Token: 0x0400DF55 RID: 57173
		[Token(Token = "0x400DF55")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__RegisterSkeletonEvents;

		// Token: 0x0400DF56 RID: 57174
		[Token(Token = "0x400DF56")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_MakeDisappearNextFrame;

		// Token: 0x0400DF57 RID: 57175
		[Token(Token = "0x400DF57")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_InitShaders;

		// Token: 0x0400DF58 RID: 57176
		[Token(Token = "0x400DF58")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_ReplaceShader;

		// Token: 0x0400DF59 RID: 57177
		[Token(Token = "0x400DF59")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_ReplaceSkeletonAtlasShaders;

		// Token: 0x0400DF5A RID: 57178
		[Token(Token = "0x400DF5A")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_ResetSkeletonAtlasShaders;

		// Token: 0x0400DF5B RID: 57179
		[Token(Token = "0x400DF5B")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_UpdateBaseline;

		// Token: 0x0400DF5C RID: 57180
		[Token(Token = "0x400DF5C")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_GetBakeMountPoint;

		// Token: 0x0400DF5D RID: 57181
		[Token(Token = "0x400DF5D")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_InitSkeletonAnimation;

		// Token: 0x0400DF5E RID: 57182
		[Token(Token = "0x400DF5E")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_SyncAnimationState;

		// Token: 0x0400DF5F RID: 57183
		[Token(Token = "0x400DF5F")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__ForceUpdateAnimation;

		// Token: 0x0400DF60 RID: 57184
		[Token(Token = "0x400DF60")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__TryGotoMixTarget;

		// Token: 0x0400DF61 RID: 57185
		[Token(Token = "0x400DF61")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_DoUpdateFaceSign;

		// Token: 0x0400DF62 RID: 57186
		[Token(Token = "0x400DF62")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_FlipSkeletonAnimation;

		// Token: 0x0400DF63 RID: 57187
		[Token(Token = "0x400DF63")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__OnEvent;

		// Token: 0x0400DF64 RID: 57188
		[Token(Token = "0x400DF64")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__ResetSetAlphaInFirstFrame;

		// Token: 0x0400DF65 RID: 57189
		[Token(Token = "0x400DF65")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__CheckShowDamageFlash;

		// Token: 0x0400DF66 RID: 57190
		[Token(Token = "0x400DF66")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__PlayBattleAudio;

		// Token: 0x0400DF67 RID: 57191
		[Token(Token = "0x400DF67")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_TryGetSpinePrefix;

		// Token: 0x0400DF68 RID: 57192
		[Token(Token = "0x400DF68")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_GetAnimName;

		// Token: 0x0400DF69 RID: 57193
		[Token(Token = "0x400DF69")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0__CheckMesh;

		// Token: 0x0400DF6A RID: 57194
		[Token(Token = "0x400DF6A")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_GetSkeletonOrNull;

		// Token: 0x0400DF6B RID: 57195
		[Token(Token = "0x400DF6B")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200212F RID: 8495
		[Token(Token = "0x200212F")]
		[Serializable]
		public class AnimationData
		{
			// Token: 0x0600D104 RID: 53508 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D104")]
			[Address(RVA = "0x3509430", Offset = "0x3508030", VA = "0x183509430")]
			public string GetAnimName()
			{
				return null;
			}

			// Token: 0x0600D105 RID: 53509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D105")]
			[Address(RVA = "0x35250C0", Offset = "0x3523CC0", VA = "0x1835250C0")]
			public string GetAnimNameWithPrefix(string prefix)
			{
				return null;
			}

			// Token: 0x0600D106 RID: 53510 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D106")]
			[Address(RVA = "0x3525110", Offset = "0x3523D10", VA = "0x183525110", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600D107 RID: 53511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D107")]
			[Address(RVA = "0x35254D0", Offset = "0x35240D0", VA = "0x1835254D0")]
			public AnimationData()
			{
			}

			// Token: 0x0400DF6C RID: 57196
			[Token(Token = "0x400DF6C")]
			[FieldOffset(Offset = "0x10")]
			public string animKey;

			// Token: 0x0400DF6D RID: 57197
			[Token(Token = "0x400DF6D")]
			[FieldOffset(Offset = "0x18")]
			public string animName;

			// Token: 0x0400DF6E RID: 57198
			[Token(Token = "0x400DF6E")]
			[FieldOffset(Offset = "0x20")]
			public bool loop;

			// Token: 0x0400DF6F RID: 57199
			[Token(Token = "0x400DF6F")]
			[FieldOffset(Offset = "0x24")]
			public float speed;

			// Token: 0x0400DF70 RID: 57200
			[Token(Token = "0x400DF70")]
			[FieldOffset(Offset = "0x28")]
			public bool ignoreMissing;

			// Token: 0x0400DF71 RID: 57201
			[Token(Token = "0x400DF71")]
			[FieldOffset(Offset = "0x2C")]
			[NonSerialized]
			public float time;

			// Token: 0x0400DF72 RID: 57202
			[Token(Token = "0x400DF72")]
			[FieldOffset(Offset = "0x30")]
			[NonSerialized]
			public bool valid;
		}

		// Token: 0x02002130 RID: 8496
		[Token(Token = "0x2002130")]
		[Serializable]
		public class SpineSkinData
		{
			// Token: 0x0600D108 RID: 53512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D108")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SpineSkinData()
			{
			}

			// Token: 0x0400DF73 RID: 57203
			[Token(Token = "0x400DF73")]
			[FieldOffset(Offset = "0x10")]
			public string skinKey;

			// Token: 0x0400DF74 RID: 57204
			[Token(Token = "0x400DF74")]
			[FieldOffset(Offset = "0x18")]
			public string[] skinPaths;
		}

		// Token: 0x02002131 RID: 8497
		[Token(Token = "0x2002131")]
		[Serializable]
		public struct CustomMixAnimSetting
		{
			// Token: 0x0600D109 RID: 53513 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D109")]
			[Address(RVA = "0x3535B40", Offset = "0x3534740", VA = "0x183535B40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400DF75 RID: 57205
			[Token(Token = "0x400DF75")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Must specify raw animName rather than animKey.")]
			public string sourceAnimName;

			// Token: 0x0400DF76 RID: 57206
			[Token(Token = "0x400DF76")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Must specify raw animName rather than animKey.")]
			public string targetAnimName;

			// Token: 0x0400DF77 RID: 57207
			[Token(Token = "0x400DF77")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Must specify raw animName rather than animKey.")]
			public string mixAnimName;

			// Token: 0x0400DF78 RID: 57208
			[Token(Token = "0x400DF78")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Must specify raw animName rather than animKey.")]
			public string illegalSourceAnimName;

			// Token: 0x0400DF79 RID: 57209
			[Token(Token = "0x400DF79")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Must specify raw animName rather than animKey.")]
			public string illegalTargetAnimName;

			// Token: 0x0400DF7A RID: 57210
			[Token(Token = "0x400DF7A")]
			[FieldOffset(Offset = "0x28")]
			public bool acceptAllSource;
		}
	}
}
