using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000589 RID: 1417
	[Token(Token = "0x2000589")]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_injection_detector.html")]
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Injection Detector")]
	public class InjectionDetector : ActDetectorBase
	{
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FA")]
		public static InjectionDetector Instance
		{
			[Token(Token = "0x600306B")]
			[Address(RVA = "0x53FC090", Offset = "0x53FAC90", VA = "0x1853FC090")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306C")]
		[Address(RVA = "0x53FBF70", Offset = "0x53FAB70", VA = "0x1853FBF70")]
		public static void StartDetection()
		{
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306D")]
		[Address(RVA = "0x53FBFD0", Offset = "0x53FABD0", VA = "0x1853FBFD0")]
		public static void StartDetection(Action<string> callback)
		{
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306E")]
		[Address(RVA = "0x53FC030", Offset = "0x53FAC30", VA = "0x1853FC030")]
		public static void StopDetection()
		{
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306F")]
		[Address(RVA = "0x53FBEB0", Offset = "0x53FAAB0", VA = "0x1853FBEB0")]
		public static void Dispose()
		{
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003070")]
		[Address(RVA = "0x53FBF10", Offset = "0x53FAB10", VA = "0x1853FBF10", Slot = "12")]
		protected override void StartDetectionAutomatically()
		{
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003071")]
		[Address(RVA = "0x53FBAB0", Offset = "0x53FA6B0", VA = "0x1853FBAB0")]
		public InjectionDetector()
		{
		}

		// Token: 0x04001A80 RID: 6784
		[Token(Token = "0x4001A80")]
		internal const string ComponentName = "Injection Detector";

		// Token: 0x04001A81 RID: 6785
		[Token(Token = "0x4001A81")]
		internal const string FinalLogPrefix = "[ACTk] Injection Detector: ";
	}
}
