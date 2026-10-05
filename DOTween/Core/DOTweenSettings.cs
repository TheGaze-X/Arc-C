using System;
using DG.Tweening.Core.Enums;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	public class DOTweenSettings : ScriptableObject
	{
		// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x375A120", Offset = "0x3758D20", VA = "0x18375A120")]
		public DOTweenSettings()
		{
		}

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		public const string AssetName = "DOTweenSettings";

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		public const string AssetFullFilename = "DOTweenSettings.asset";

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x18")]
		public bool useSafeMode;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x20")]
		public DOTweenSettings.SafeModeOptions safeModeOptions;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x28")]
		public float timeScale;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x2C")]
		public float unscaledTimeScale;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x30")]
		public bool useSmoothDeltaTime;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x34")]
		public float maxSmoothUnscaledTime;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x38")]
		public RewindCallbackMode rewindCallbackMode;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x3C")]
		public bool showUnityEditorReport;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x40")]
		public LogBehaviour logBehaviour;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x44")]
		public bool drawGizmos;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x45")]
		public bool defaultRecyclable;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x48")]
		public AutoPlay defaultAutoPlay;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x4C")]
		public UpdateType defaultUpdateType;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x50")]
		public bool defaultTimeScaleIndependent;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x54")]
		public Ease defaultEaseType;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x58")]
		public float defaultEaseOvershootOrAmplitude;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x5C")]
		public float defaultEasePeriod;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x60")]
		public bool defaultAutoKill;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x64")]
		public LoopType defaultLoopType;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x68")]
		public bool debugMode;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x69")]
		public bool debugStoreTargetId;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x6A")]
		public bool showPreviewPanel;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x6C")]
		public DOTweenSettings.SettingsLocation storeSettingsLocation;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x70")]
		public DOTweenSettings.ModulesSetup modules;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x78")]
		public bool createASMDEF;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x79")]
		public bool showPlayingTweens;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x7A")]
		public bool showPausedTweens;

		// Token: 0x020000AD RID: 173
		[Token(Token = "0x20000AD")]
		public enum SettingsLocation
		{
			// Token: 0x04000205 RID: 517
			[Token(Token = "0x4000205")]
			AssetsDirectory,
			// Token: 0x04000206 RID: 518
			[Token(Token = "0x4000206")]
			DOTweenDirectory,
			// Token: 0x04000207 RID: 519
			[Token(Token = "0x4000207")]
			DemigiantDirectory
		}

		// Token: 0x020000AE RID: 174
		[Token(Token = "0x20000AE")]
		[Serializable]
		public class SafeModeOptions
		{
			// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x2646870", Offset = "0x2645470", VA = "0x182646870")]
			public SafeModeOptions()
			{
			}

			// Token: 0x04000208 RID: 520
			[Token(Token = "0x4000208")]
			[FieldOffset(Offset = "0x10")]
			public SafeModeLogBehaviour logBehaviour;

			// Token: 0x04000209 RID: 521
			[Token(Token = "0x4000209")]
			[FieldOffset(Offset = "0x14")]
			public NestedTweenFailureBehaviour nestedTweenFailureBehaviour;
		}

		// Token: 0x020000AF RID: 175
		[Token(Token = "0x20000AF")]
		[Serializable]
		public class ModulesSetup
		{
			// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x375DAC0", Offset = "0x375C6C0", VA = "0x18375DAC0")]
			public ModulesSetup()
			{
			}

			// Token: 0x0400020A RID: 522
			[Token(Token = "0x400020A")]
			[FieldOffset(Offset = "0x10")]
			public bool showPanel;

			// Token: 0x0400020B RID: 523
			[Token(Token = "0x400020B")]
			[FieldOffset(Offset = "0x11")]
			public bool audioEnabled;

			// Token: 0x0400020C RID: 524
			[Token(Token = "0x400020C")]
			[FieldOffset(Offset = "0x12")]
			public bool physicsEnabled;

			// Token: 0x0400020D RID: 525
			[Token(Token = "0x400020D")]
			[FieldOffset(Offset = "0x13")]
			public bool physics2DEnabled;

			// Token: 0x0400020E RID: 526
			[Token(Token = "0x400020E")]
			[FieldOffset(Offset = "0x14")]
			public bool spriteEnabled;

			// Token: 0x0400020F RID: 527
			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x15")]
			public bool uiEnabled;

			// Token: 0x04000210 RID: 528
			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0x16")]
			public bool textMeshProEnabled;

			// Token: 0x04000211 RID: 529
			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x17")]
			public bool tk2DEnabled;

			// Token: 0x04000212 RID: 530
			[Token(Token = "0x4000212")]
			[FieldOffset(Offset = "0x18")]
			public bool deAudioEnabled;

			// Token: 0x04000213 RID: 531
			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x19")]
			public bool deUnityExtendedEnabled;

			// Token: 0x04000214 RID: 532
			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x1A")]
			public bool epoOutlineEnabled;
		}
	}
}
