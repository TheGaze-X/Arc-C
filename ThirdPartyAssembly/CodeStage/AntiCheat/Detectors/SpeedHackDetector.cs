using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x0200058B RID: 1419
	[Token(Token = "0x200058B")]
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Speed Hack Detector")]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_speed_hack_detector.html")]
	public class SpeedHackDetector : ActDetectorBase
	{
		// Token: 0x06003083 RID: 12419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003083")]
		[Address(RVA = "0x5419F10", Offset = "0x5418B10", VA = "0x185419F10")]
		public static SpeedHackDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003084")]
		[Address(RVA = "0x541A890", Offset = "0x5419490", VA = "0x18541A890")]
		public static void StartDetection()
		{
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003085")]
		[Address(RVA = "0x541A800", Offset = "0x5419400", VA = "0x18541A800")]
		public static void StartDetection(Action callback)
		{
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003086")]
		[Address(RVA = "0x541A690", Offset = "0x5419290", VA = "0x18541A690")]
		public static void StartDetection(Action callback, float interval)
		{
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003087")]
		[Address(RVA = "0x541A780", Offset = "0x5419380", VA = "0x18541A780")]
		public static void StartDetection(Action callback, float interval, byte maxFalsePositives)
		{
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003088")]
		[Address(RVA = "0x541A710", Offset = "0x5419310", VA = "0x18541A710")]
		public static void StartDetection(Action callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003089")]
		[Address(RVA = "0x541AA60", Offset = "0x5419660", VA = "0x18541AA60")]
		public static void StopDetection()
		{
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600308A")]
		[Address(RVA = "0x541A1B0", Offset = "0x5418DB0", VA = "0x18541A1B0")]
		public static void Dispose()
		{
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600308C RID: 12428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FE")]
		public static SpeedHackDetector Instance
		{
			[Token(Token = "0x600308B")]
			[Address(RVA = "0x541AF40", Offset = "0x5419B40", VA = "0x18541AF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600308C")]
			[Address(RVA = "0x541AF80", Offset = "0x5419B80", VA = "0x18541AF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FF")]
		private static SpeedHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x600308D")]
			[Address(RVA = "0x541AD60", Offset = "0x5419960", VA = "0x18541AD60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600308E")]
		[Address(RVA = "0x541AD30", Offset = "0x5419930", VA = "0x18541AD30")]
		private SpeedHackDetector()
		{
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600308F")]
		[Address(RVA = "0x5419F20", Offset = "0x5418B20", VA = "0x185419F20")]
		private void Awake()
		{
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003090")]
		[Address(RVA = "0x541A300", Offset = "0x5418F00", VA = "0x18541A300", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003091")]
		[Address(RVA = "0x541A350", Offset = "0x5418F50", VA = "0x18541A350")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003092")]
		[Address(RVA = "0x541A350", Offset = "0x5418F50", VA = "0x18541A350")]
		private void OnLevelLoadedCallback()
		{
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003093")]
		[Address(RVA = "0x541A2F0", Offset = "0x5418EF0", VA = "0x18541A2F0")]
		private void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003094")]
		[Address(RVA = "0x541AB40", Offset = "0x5419740", VA = "0x18541AB40")]
		private void Update()
		{
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003095")]
		[Address(RVA = "0x541A500", Offset = "0x5419100", VA = "0x18541A500")]
		private void StartDetectionInternal(Action callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003096")]
		[Address(RVA = "0x541A4D0", Offset = "0x54190D0", VA = "0x18541A4D0", Slot = "12")]
		protected override void StartDetectionAutomatically()
		{
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003097")]
		[Address(RVA = "0x541A0A0", Offset = "0x5418CA0", VA = "0x18541A0A0", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003098")]
		[Address(RVA = "0x541A440", Offset = "0x5419040", VA = "0x18541A440")]
		private void ResetStartTicks()
		{
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x000153A8 File Offset: 0x000135A8
		[Token(Token = "0x6003099")]
		[Address(RVA = "0x541A290", Offset = "0x5418E90", VA = "0x18541A290")]
		private long GetReliableTicks()
		{
			return 0L;
		}

		// Token: 0x04001A8B RID: 6795
		[Token(Token = "0x4001A8B")]
		internal const string ComponentName = "Speed Hack Detector";

		// Token: 0x04001A8C RID: 6796
		[Token(Token = "0x4001A8C")]
		internal const string LogPrefix = "[ACTk] Speed Hack Detector: ";

		// Token: 0x04001A8D RID: 6797
		[Token(Token = "0x4001A8D")]
		private const long TicksPerSecond = 10000000L;

		// Token: 0x04001A8E RID: 6798
		[Token(Token = "0x4001A8E")]
		private const int Threshold = 5000000;

		// Token: 0x04001A8F RID: 6799
		[Token(Token = "0x4001A8F")]
		private const float ThresholdFloat = 0.5f;

		// Token: 0x04001A90 RID: 6800
		[Token(Token = "0x4001A90")]
		[FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		// Token: 0x04001A91 RID: 6801
		[Token(Token = "0x4001A91")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Time (in seconds) between detector checks.")]
		public float interval;

		// Token: 0x04001A92 RID: 6802
		[Token(Token = "0x4001A92")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Maximum false positives count allowed before registering speed hack.")]
		public byte maxFalsePositives;

		// Token: 0x04001A93 RID: 6803
		[Token(Token = "0x4001A93")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Amount of sequential successful checks before clearing internal false positives counter.\nSet 0 to disable Cool Down feature.")]
		public int coolDown;

		// Token: 0x04001A94 RID: 6804
		[Token(Token = "0x4001A94")]
		[FieldOffset(Offset = "0x44")]
		private byte currentFalsePositives;

		// Token: 0x04001A95 RID: 6805
		[Token(Token = "0x4001A95")]
		[FieldOffset(Offset = "0x48")]
		private int currentCooldownShots;

		// Token: 0x04001A96 RID: 6806
		[Token(Token = "0x4001A96")]
		[FieldOffset(Offset = "0x50")]
		private long ticksOnStart;

		// Token: 0x04001A97 RID: 6807
		[Token(Token = "0x4001A97")]
		[FieldOffset(Offset = "0x58")]
		private long vulnerableTicksOnStart;

		// Token: 0x04001A98 RID: 6808
		[Token(Token = "0x4001A98")]
		[FieldOffset(Offset = "0x60")]
		private long previousTicks;

		// Token: 0x04001A99 RID: 6809
		[Token(Token = "0x4001A99")]
		[FieldOffset(Offset = "0x68")]
		private long previousIntervalTicks;

		// Token: 0x04001A9A RID: 6810
		[Token(Token = "0x4001A9A")]
		[FieldOffset(Offset = "0x70")]
		private float vulnerableTimeOnStart;
	}
}
