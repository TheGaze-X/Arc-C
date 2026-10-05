using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000588 RID: 1416
	[Token(Token = "0x2000588")]
	[AddComponentMenu("")]
	public abstract class ActDetectorBase : MonoBehaviour
	{
		// Token: 0x1400001C RID: 28
		// (add) Token: 0x0600305A RID: 12378 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600305B RID: 12379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001C")]
		public event Action CheatDetected
		{
			[Token(Token = "0x600305A")]
			[Address(RVA = "0x53FBAD0", Offset = "0x53FA6D0", VA = "0x1853FBAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600305B")]
			[Address(RVA = "0x53FBB70", Offset = "0x53FA770", VA = "0x1853FBB70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x00015330 File Offset: 0x00013530
		[Token(Token = "0x170006F9")]
		public bool IsRunning
		{
			[Token(Token = "0x600305C")]
			[Address(RVA = "0xF02F50", Offset = "0xF01B50", VA = "0x180F02F50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600305D")]
		[Address(RVA = "0x53FB960", Offset = "0x53FA560", VA = "0x1853FB960")]
		private void Start()
		{
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600305E")]
		[Address(RVA = "0x325ECC0", Offset = "0x325D8C0", VA = "0x18325ECC0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600305F")]
		[Address(RVA = "0x3104A50", Offset = "0x3103650", VA = "0x183104A50")]
		private void OnDisable()
		{
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003060")]
		[Address(RVA = "0x3264D80", Offset = "0x3263980", VA = "0x183264D80")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003061")]
		[Address(RVA = "0x53FB7E0", Offset = "0x53FA3E0", VA = "0x1853FB7E0", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003062")]
		[Address(RVA = "0x53FB740", Offset = "0x53FA340", VA = "0x1853FB740", Slot = "5")]
		internal virtual void OnCheatingDetected()
		{
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x6003063")]
		[Address(RVA = "0x53FB5B0", Offset = "0x53FA1B0", VA = "0x1853FB5B0", Slot = "6")]
		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003064")]
		[Address(RVA = "0x53FB560", Offset = "0x53FA160", VA = "0x1853FB560", Slot = "7")]
		protected virtual void DisposeInternal()
		{
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x00015360 File Offset: 0x00013560
		[Token(Token = "0x6003065")]
		[Address(RVA = "0x53FB550", Offset = "0x53FA150", VA = "0x1853FB550", Slot = "8")]
		protected virtual bool DetectorHasCallbacks()
		{
			return default(bool);
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003066")]
		[Address(RVA = "0x53FBA80", Offset = "0x53FA680", VA = "0x1853FBA80", Slot = "9")]
		protected virtual void StopDetectionInternal()
		{
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003067")]
		[Address(RVA = "0x53FB900", Offset = "0x53FA500", VA = "0x1853FB900", Slot = "10")]
		protected virtual void PauseDetector()
		{
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x00015378 File Offset: 0x00013578
		[Token(Token = "0x6003068")]
		[Address(RVA = "0x53FB910", Offset = "0x53FA510", VA = "0x1853FB910", Slot = "11")]
		protected virtual bool ResumeDetector()
		{
			return default(bool);
		}

		// Token: 0x06003069 RID: 12393
		[Token(Token = "0x6003069")]
		protected abstract void StartDetectionAutomatically();

		// Token: 0x0600306A RID: 12394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306A")]
		[Address(RVA = "0x53FBAB0", Offset = "0x53FA6B0", VA = "0x1853FBAB0")]
		protected ActDetectorBase()
		{
		}

		// Token: 0x04001A74 RID: 6772
		[Token(Token = "0x4001A74")]
		protected const string ContainerName = "Anti-Cheat Toolkit Detectors";

		// Token: 0x04001A75 RID: 6773
		[Token(Token = "0x4001A75")]
		protected const string MenuPath = "Code Stage/Anti-Cheat Toolkit/";

		// Token: 0x04001A76 RID: 6774
		[Token(Token = "0x4001A76")]
		protected const string GameObjectMenuPath = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";

		// Token: 0x04001A77 RID: 6775
		[Token(Token = "0x4001A77")]
		[FieldOffset(Offset = "0x0")]
		protected static GameObject detectorsContainer;

		// Token: 0x04001A78 RID: 6776
		[Token(Token = "0x4001A78")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Automatically start detector. Detection Event will be called on detection.")]
		public bool autoStart;

		// Token: 0x04001A79 RID: 6777
		[Token(Token = "0x4001A79")]
		[FieldOffset(Offset = "0x19")]
		[Tooltip("Detector will survive new level (scene) load if checked.")]
		public bool keepAlive;

		// Token: 0x04001A7A RID: 6778
		[Token(Token = "0x4001A7A")]
		[FieldOffset(Offset = "0x1A")]
		[Tooltip("Automatically dispose Detector after firing callback.")]
		public bool autoDispose;

		// Token: 0x04001A7C RID: 6780
		[Token(Token = "0x4001A7C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected UnityEvent detectionEvent;

		// Token: 0x04001A7D RID: 6781
		[Token(Token = "0x4001A7D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool detectionEventHasListener;

		// Token: 0x04001A7E RID: 6782
		[Token(Token = "0x4001A7E")]
		[FieldOffset(Offset = "0x31")]
		protected bool started;

		// Token: 0x04001A7F RID: 6783
		[Token(Token = "0x4001A7F")]
		[FieldOffset(Offset = "0x32")]
		protected bool isRunning;
	}
}
