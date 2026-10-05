using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Fx
{
	// Token: 0x02002030 RID: 8240
	[Token(Token = "0x2002030")]
	public class FxDynIllustCameraShake : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600CB13 RID: 51987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CB13")]
		[Address(RVA = "0x34C1E80", Offset = "0x34C0A80", VA = "0x1834C1E80")]
		private IEnumerator Shake(FxDynIllustCameraShake.ShakeTrig shake)
		{
			return null;
		}

		// Token: 0x0600CB14 RID: 51988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB14")]
		[Address(RVA = "0x34C1B70", Offset = "0x34C0770", VA = "0x1834C1B70")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CB15 RID: 51989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB15")]
		[Address(RVA = "0x34C19C0", Offset = "0x34C05C0", VA = "0x1834C19C0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600CB16 RID: 51990 RVA: 0x000497B8 File Offset: 0x000479B8
		[Token(Token = "0x600CB16")]
		[Address(RVA = "0x34C1F50", Offset = "0x34C0B50", VA = "0x1834C1F50")]
		private bool _CheckDynIllustMgr()
		{
			return default(bool);
		}

		// Token: 0x0600CB17 RID: 51991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB17")]
		[Address(RVA = "0x34C2070", Offset = "0x34C0C70", VA = "0x1834C2070")]
		public FxDynIllustCameraShake()
		{
		}

		// Token: 0x0400D500 RID: 54528
		[Token(Token = "0x400D500")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<FxDynIllustCameraShake.ShakeTrig> _shakeTrigs;

		// Token: 0x0400D501 RID: 54529
		[Token(Token = "0x400D501")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private int m_Counter;

		// Token: 0x0400D502 RID: 54530
		[Token(Token = "0x400D502")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private Camera m_camera;

		// Token: 0x0400D503 RID: 54531
		[Token(Token = "0x400D503")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Shake;

		// Token: 0x0400D504 RID: 54532
		[Token(Token = "0x400D504")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400D505 RID: 54533
		[Token(Token = "0x400D505")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400D506 RID: 54534
		[Token(Token = "0x400D506")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckDynIllustMgr;

		// Token: 0x0400D507 RID: 54535
		[Token(Token = "0x400D507")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002031 RID: 8241
		[Token(Token = "0x2002031")]
		[Serializable]
		public class ShakeTrig
		{
			// Token: 0x17001806 RID: 6150
			// (get) Token: 0x0600CB18 RID: 51992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001806")]
			public WaitForSeconds waitDelay
			{
				[Token(Token = "0x600CB18")]
				[Address(RVA = "0x34CE210", Offset = "0x34CCE10", VA = "0x1834CE210")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001807 RID: 6151
			// (get) Token: 0x0600CB19 RID: 51993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001807")]
			public WaitForSeconds waitDuration
			{
				[Token(Token = "0x600CB19")]
				[Address(RVA = "0x34CE2B0", Offset = "0x34CCEB0", VA = "0x1834CE2B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600CB1A RID: 51994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CB1A")]
			[Address(RVA = "0x34CE1C0", Offset = "0x34CCDC0", VA = "0x1834CE1C0")]
			public void ClearTween()
			{
			}

			// Token: 0x0600CB1B RID: 51995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CB1B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShakeTrig()
			{
			}

			// Token: 0x0400D508 RID: 54536
			[Token(Token = "0x400D508")]
			[FieldOffset(Offset = "0x10")]
			public float delay;

			// Token: 0x0400D509 RID: 54537
			[Token(Token = "0x400D509")]
			[FieldOffset(Offset = "0x14")]
			public float duration;

			// Token: 0x0400D50A RID: 54538
			[Token(Token = "0x400D50A")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 strength;

			// Token: 0x0400D50B RID: 54539
			[Token(Token = "0x400D50B")]
			[FieldOffset(Offset = "0x24")]
			public int vibrato;

			// Token: 0x0400D50C RID: 54540
			[Token(Token = "0x400D50C")]
			[FieldOffset(Offset = "0x28")]
			public float randomness;

			// Token: 0x0400D50D RID: 54541
			[Token(Token = "0x400D50D")]
			[FieldOffset(Offset = "0x2C")]
			public bool fadeOut;

			// Token: 0x0400D50E RID: 54542
			[Token(Token = "0x400D50E")]
			[FieldOffset(Offset = "0x30")]
			[NonSerialized]
			private WaitForSeconds m_waitDelay;

			// Token: 0x0400D50F RID: 54543
			[Token(Token = "0x400D50F")]
			[FieldOffset(Offset = "0x38")]
			[NonSerialized]
			private WaitForSeconds m_waitDuration;

			// Token: 0x0400D510 RID: 54544
			[Token(Token = "0x400D510")]
			[FieldOffset(Offset = "0x40")]
			[NonSerialized]
			public Tweener tween;
		}
	}
}
