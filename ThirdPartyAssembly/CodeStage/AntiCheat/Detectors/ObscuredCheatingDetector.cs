using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x0200058A RID: 1418
	[Token(Token = "0x200058A")]
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Obscured Cheating Detector")]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_obscured_cheating_detector.html")]
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		// Token: 0x06003072 RID: 12402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003072")]
		[Address(RVA = "0x53FC0F0", Offset = "0x53FACF0", VA = "0x1853FC0F0")]
		public static ObscuredCheatingDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003073")]
		[Address(RVA = "0x53FC750", Offset = "0x53FB350", VA = "0x1853FC750")]
		public static void StartDetection()
		{
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003074")]
		[Address(RVA = "0x53FC720", Offset = "0x53FB320", VA = "0x1853FC720")]
		public static void StartDetection(Action callback)
		{
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003075")]
		[Address(RVA = "0x53FC850", Offset = "0x53FB450", VA = "0x1853FC850")]
		public static void StopDetection()
		{
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003076")]
		[Address(RVA = "0x53FC390", Offset = "0x53FAF90", VA = "0x1853FC390")]
		public static void Dispose()
		{
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003078 RID: 12408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FB")]
		public static ObscuredCheatingDetector Instance
		{
			[Token(Token = "0x6003077")]
			[Address(RVA = "0x53FCBD0", Offset = "0x53FB7D0", VA = "0x1853FCBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003078")]
			[Address(RVA = "0x53FCC10", Offset = "0x53FB810", VA = "0x1853FCC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06003079 RID: 12409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FC")]
		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x6003079")]
			[Address(RVA = "0x53FC9F0", Offset = "0x53FB5F0", VA = "0x1853FC9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x00015390 File Offset: 0x00013590
		[Token(Token = "0x170006FD")]
		internal static bool ExistsAndIsRunning
		{
			[Token(Token = "0x600307A")]
			[Address(RVA = "0x53FC970", Offset = "0x53FB570", VA = "0x1853FC970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307B")]
		[Address(RVA = "0x53FC930", Offset = "0x53FB530", VA = "0x1853FC930")]
		private ObscuredCheatingDetector()
		{
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307C")]
		[Address(RVA = "0x53FC100", Offset = "0x53FAD00", VA = "0x1853FC100")]
		private void Awake()
		{
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307D")]
		[Address(RVA = "0x53FC470", Offset = "0x53FB070", VA = "0x1853FC470", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307E")]
		[Address(RVA = "0x53FC4C0", Offset = "0x53FB0C0", VA = "0x1853FC4C0")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307F")]
		[Address(RVA = "0x53FC4C0", Offset = "0x53FB0C0", VA = "0x1853FC4C0")]
		private void OnLevelLoadedCallback()
		{
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003080")]
		[Address(RVA = "0x53FC5C0", Offset = "0x53FB1C0", VA = "0x1853FC5C0")]
		private void StartDetectionInternal(Action callback)
		{
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003081")]
		[Address(RVA = "0x53FC5B0", Offset = "0x53FB1B0", VA = "0x1853FC5B0", Slot = "12")]
		protected override void StartDetectionAutomatically()
		{
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003082")]
		[Address(RVA = "0x53FC280", Offset = "0x53FAE80", VA = "0x1853FC280", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		// Token: 0x04001A82 RID: 6786
		[Token(Token = "0x4001A82")]
		internal const string ComponentName = "Obscured Cheating Detector";

		// Token: 0x04001A83 RID: 6787
		[Token(Token = "0x4001A83")]
		internal const string FinalLogPrefix = "[ACTk] Obscured Cheating Detector: ";

		// Token: 0x04001A84 RID: 6788
		[Token(Token = "0x4001A84")]
		[FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		// Token: 0x04001A85 RID: 6789
		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredDouble. Increase in case of false positives.")]
		public double doubleEpsilon;

		// Token: 0x04001A86 RID: 6790
		[Token(Token = "0x4001A86")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredFloat. Increase in case of false positives.")]
		public float floatEpsilon;

		// Token: 0x04001A87 RID: 6791
		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector2. Increase in case of false positives.")]
		public float vector2Epsilon;

		// Token: 0x04001A88 RID: 6792
		[Token(Token = "0x4001A88")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector3. Increase in case of false positives.")]
		public float vector3Epsilon;

		// Token: 0x04001A89 RID: 6793
		[Token(Token = "0x4001A89")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredQuaternion. Increase in case of false positives.")]
		public float quaternionEpsilon;
	}
}
