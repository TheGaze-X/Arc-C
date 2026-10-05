using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x0200058C RID: 1420
	[Token(Token = "0x200058C")]
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Time Cheating Detector")]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_time_cheating_detector.html")]
	public class TimeCheatingDetector : ActDetectorBase
	{
		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600309A RID: 12442 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600309B RID: 12443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001D")]
		public event Action<TimeCheatingDetector.ErrorKind> Error
		{
			[Token(Token = "0x600309A")]
			[Address(RVA = "0x541CC80", Offset = "0x541B880", VA = "0x18541CC80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600309B")]
			[Address(RVA = "0x541CFF0", Offset = "0x541BBF0", VA = "0x18541CFF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600309C RID: 12444 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600309D RID: 12445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001E")]
		public event Action CheckPassed
		{
			[Token(Token = "0x600309C")]
			[Address(RVA = "0x541CBE0", Offset = "0x541B7E0", VA = "0x18541CBE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600309D")]
			[Address(RVA = "0x541CF50", Offset = "0x541BB50", VA = "0x18541CF50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600309E RID: 12446 RVA: 0x000153C0 File Offset: 0x000135C0
		// (set) Token: 0x0600309F RID: 12447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000700")]
		public bool IsCheckingForCheat
		{
			[Token(Token = "0x600309E")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600309F")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060030A0 RID: 12448 RVA: 0x000153D8 File Offset: 0x000135D8
		// (set) Token: 0x060030A1 RID: 12449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000701")]
		public TimeCheatingDetector.ErrorKind LastError
		{
			[Token(Token = "0x60030A0")]
			[Address(RVA = "0x32FB190", Offset = "0x32F9D90", VA = "0x1832FB190")]
			[CompilerGenerated]
			get
			{
				return TimeCheatingDetector.ErrorKind.NoError;
			}
			[Token(Token = "0x60030A1")]
			[Address(RVA = "0x541D100", Offset = "0x541BD00", VA = "0x18541D100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x000153F0 File Offset: 0x000135F0
		// (set) Token: 0x060030A3 RID: 12451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000702")]
		public TimeCheatingDetector.TimeCheatingDetectorResult LastResult
		{
			[Token(Token = "0x60030A2")]
			[Address(RVA = "0x4D1DE30", Offset = "0x4D1CA30", VA = "0x184D1DE30")]
			[CompilerGenerated]
			get
			{
				return TimeCheatingDetector.TimeCheatingDetectorResult.Unknown;
			}
			[Token(Token = "0x60030A3")]
			[Address(RVA = "0x4D1D360", Offset = "0x4D1BF60", VA = "0x184D1D360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000703")]
		public static TimeCheatingDetector Instance
		{
			[Token(Token = "0x60030A4")]
			[Address(RVA = "0x541CF10", Offset = "0x541BB10", VA = "0x18541CF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030A5")]
			[Address(RVA = "0x541D0A0", Offset = "0x541BCA0", VA = "0x18541D0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000704")]
		private static TimeCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x60030A6")]
			[Address(RVA = "0x541CD30", Offset = "0x541B930", VA = "0x18541CD30")]
			get
			{
				return null;
			}
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x541C860", Offset = "0x541B460", VA = "0x18541C860")]
		[Obsolete("Please use StartDetection(int, ...) instead.")]
		public static void StartDetection(Action detectionCallback, int interval)
		{
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x541C640", Offset = "0x541B240", VA = "0x18541C640")]
		[Obsolete("Please use StartDetection(int, ...) instead.")]
		public static void StartDetection(Action detectionCallback, Action<TimeCheatingDetector.ErrorKind> errorCallback, int interval)
		{
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x541AFE0", Offset = "0x5419BE0", VA = "0x18541AFE0")]
		public static TimeCheatingDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x541C6A0", Offset = "0x541B2A0", VA = "0x18541C6A0")]
		public static void StartDetection([Optional] Action detectionCallback, [Optional] Action<TimeCheatingDetector.ErrorKind> errorCallback, [Optional] Action checkPassedCallback)
		{
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x541C5D0", Offset = "0x541B1D0", VA = "0x18541C5D0")]
		public static void StartDetection(float intervalMinutes, [Optional] Action detectionCallback, [Optional] Action<TimeCheatingDetector.ErrorKind> errorCallback, [Optional] Action checkPassedCallback)
		{
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AC")]
		[Address(RVA = "0x541C950", Offset = "0x541B550", VA = "0x18541C950")]
		public static void StopDetection()
		{
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("Please use Instance.Error event instead.", true)]
		public static void SetErrorCallback(Action<TimeCheatingDetector.ErrorKind> errorCallback)
		{
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x541B370", Offset = "0x5419F70", VA = "0x18541B370")]
		public static void Dispose()
		{
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x541AFF0", Offset = "0x5419BF0", VA = "0x18541AFF0")]
		private void Awake()
		{
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x541BD00", Offset = "0x541A900", VA = "0x18541BD00", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B1")]
		[Address(RVA = "0x541BD50", Offset = "0x541A950", VA = "0x18541BD50")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x541BD50", Offset = "0x541A950", VA = "0x18541BD50")]
		private void OnLevelLoadedCallback()
		{
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x541BC90", Offset = "0x541A890", VA = "0x18541BC90")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B4")]
		[Address(RVA = "0x541CA30", Offset = "0x541B630", VA = "0x18541CA30")]
		private void Update()
		{
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x00015408 File Offset: 0x00013608
		[Token(Token = "0x60030B5")]
		[Address(RVA = "0x541B5C0", Offset = "0x541A1C0", VA = "0x18541B5C0")]
		public bool ForceCheck()
		{
			return default(bool);
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B6")]
		[Address(RVA = "0x541B450", Offset = "0x541A050", VA = "0x18541B450")]
		public IEnumerator ForceCheckEnumerator()
		{
			return null;
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B7")]
		[Address(RVA = "0x541B4D0", Offset = "0x541A0D0", VA = "0x18541B4D0")]
		public Task<TimeCheatingDetector.TimeCheatingDetectorResult> ForceCheckTask()
		{
			return null;
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B8")]
		[Address(RVA = "0x541C300", Offset = "0x541AF00", VA = "0x18541C300")]
		private void StartDetectionInternal(float checkInterval, Action detectionCallback, Action checkPassedCallback, Action<TimeCheatingDetector.ErrorKind> errorCallback)
		{
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B9")]
		[Address(RVA = "0x541C2D0", Offset = "0x541AED0", VA = "0x18541C2D0", Slot = "12")]
		protected override void StartDetectionAutomatically()
		{
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x00015420 File Offset: 0x00013620
		[Token(Token = "0x60030BA")]
		[Address(RVA = "0x541B240", Offset = "0x5419E40", VA = "0x18541B240", Slot = "8")]
		protected override bool DetectorHasCallbacks()
		{
			return default(bool);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BB")]
		[Address(RVA = "0x541C2B0", Offset = "0x541AEB0", VA = "0x18541C2B0", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BC")]
		[Address(RVA = "0x541C8B0", Offset = "0x541B4B0", VA = "0x18541C8B0", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BD")]
		[Address(RVA = "0x541B260", Offset = "0x5419E60", VA = "0x18541B260", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BE")]
		[Address(RVA = "0x541B170", Offset = "0x5419D70", VA = "0x18541B170")]
		private IEnumerator CheckForCheat()
		{
			return null;
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BF")]
		[Address(RVA = "0x541B760", Offset = "0x541A360", VA = "0x18541B760")]
		private IEnumerator GetOnlineTimeInternal()
		{
			return null;
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C0")]
		[Address(RVA = "0x541BE40", Offset = "0x541AA40", VA = "0x18541BE40")]
		private void OnSocketConnectedOrSent(object sender, SocketAsyncEventArgs e)
		{
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C1")]
		[Address(RVA = "0x541C060", Offset = "0x541AC60", VA = "0x18541C060")]
		private void OnSocketReceive(object sender, SocketAsyncEventArgs e)
		{
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C2")]
		[Address(RVA = "0x541B1E0", Offset = "0x5419DE0", VA = "0x18541B1E0")]
		private void CloseSocket()
		{
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C3")]
		[Address(RVA = "0x541BB10", Offset = "0x541A710", VA = "0x18541BB10")]
		private void HandleSocketException(Exception exception)
		{
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x00015438 File Offset: 0x00013638
		[Token(Token = "0x60030C4")]
		[Address(RVA = "0x541B6D0", Offset = "0x541A2D0", VA = "0x18541B6D0")]
		private double GetLocalTime()
		{
			return 0.0;
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x00015450 File Offset: 0x00013650
		[Token(Token = "0x60030C5")]
		[Address(RVA = "0x541B7D0", Offset = "0x541A3D0", VA = "0x18541B7D0")]
		public static double GetOnlineTime(string server)
		{
			return 0.0;
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C6")]
		[Address(RVA = "0x541CAC0", Offset = "0x541B6C0", VA = "0x18541CAC0")]
		public TimeCheatingDetector()
		{
		}

		// Token: 0x04001A9C RID: 6812
		[Token(Token = "0x4001A9C")]
		internal const string ComponentName = "Time Cheating Detector";

		// Token: 0x04001A9D RID: 6813
		[Token(Token = "0x4001A9D")]
		private const string LogPrefix = "[ACTk] Time Cheating Detector: ";

		// Token: 0x04001A9E RID: 6814
		[Token(Token = "0x4001A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		// Token: 0x04001A9F RID: 6815
		[Token(Token = "0x4001A9F")]
		private const int NtpDataBufferLength = 48;

		// Token: 0x04001AA2 RID: 6818
		[Token(Token = "0x4001AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 60f)]
		[Tooltip("Time (in minutes) between detector checks.")]
		public float interval;

		// Token: 0x04001AA3 RID: 6819
		[Token(Token = "0x4001AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Maximum allowed difference between online and offline time, in minutes.")]
		public int threshold;

		// Token: 0x04001AA4 RID: 6820
		[Token(Token = "0x4001AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string timeServer;

		// Token: 0x04001AA8 RID: 6824
		[Token(Token = "0x4001AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly DateTime date1900;

		// Token: 0x04001AA9 RID: 6825
		[Token(Token = "0x4001AA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly WaitForEndOfFrame cachedEndOfFrame;

		// Token: 0x04001AAA RID: 6826
		[Token(Token = "0x4001AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Socket asyncSocket;

		// Token: 0x04001AAB RID: 6827
		[Token(Token = "0x4001AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private byte[] ntpData;

		// Token: 0x04001AAC RID: 6828
		[Token(Token = "0x4001AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private byte[] targetIP;

		// Token: 0x04001AAD RID: 6829
		[Token(Token = "0x4001AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private IPEndPoint targetEndpoint;

		// Token: 0x04001AAE RID: 6830
		[Token(Token = "0x4001AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SocketAsyncEventArgs connectArgs;

		// Token: 0x04001AAF RID: 6831
		[Token(Token = "0x4001AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private SocketAsyncEventArgs sendArgs;

		// Token: 0x04001AB0 RID: 6832
		[Token(Token = "0x4001AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SocketAsyncEventArgs receiveArgs;

		// Token: 0x04001AB1 RID: 6833
		[Token(Token = "0x4001AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float timeElapsed;

		// Token: 0x04001AB2 RID: 6834
		[Token(Token = "0x4001AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private double lastOnlineTime;

		// Token: 0x04001AB3 RID: 6835
		[Token(Token = "0x4001AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool gettingOnlineTimeAsync;

		// Token: 0x04001AB4 RID: 6836
		[Token(Token = "0x4001AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private TimeCheatingDetector.ErrorKind asyncError;

		// Token: 0x0200058D RID: 1421
		[Token(Token = "0x200058D")]
		public enum TimeCheatingDetectorResult
		{
			// Token: 0x04001AB7 RID: 6839
			[Token(Token = "0x4001AB7")]
			Unknown,
			// Token: 0x04001AB8 RID: 6840
			[Token(Token = "0x4001AB8")]
			CheckPassed = 5,
			// Token: 0x04001AB9 RID: 6841
			[Token(Token = "0x4001AB9")]
			CheatDetected = 10,
			// Token: 0x04001ABA RID: 6842
			[Token(Token = "0x4001ABA")]
			Error = 15
		}

		// Token: 0x0200058E RID: 1422
		[Token(Token = "0x200058E")]
		public enum ErrorKind
		{
			// Token: 0x04001ABC RID: 6844
			[Token(Token = "0x4001ABC")]
			NoError,
			// Token: 0x04001ABD RID: 6845
			[Token(Token = "0x4001ABD")]
			CantResolveHost = 5,
			// Token: 0x04001ABE RID: 6846
			[Token(Token = "0x4001ABE")]
			Unknown = 10
		}
	}
}
