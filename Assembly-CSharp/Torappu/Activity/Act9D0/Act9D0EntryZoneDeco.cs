using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200718F RID: 29071
	[Token(Token = "0x200718F")]
	public class Act9D0EntryZoneDeco : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029428 RID: 169000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029428")]
		[Address(RVA = "0x2494950", Offset = "0x2493550", VA = "0x182494950")]
		public void OnEnable()
		{
		}

		// Token: 0x06029429 RID: 169001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029429")]
		[Address(RVA = "0x2494AA0", Offset = "0x24936A0", VA = "0x182494AA0")]
		private IEnumerator _TrackVisibility()
		{
			return null;
		}

		// Token: 0x0602942A RID: 169002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602942A")]
		[Address(RVA = "0x2494B50", Offset = "0x2493750", VA = "0x182494B50")]
		public Act9D0EntryZoneDeco()
		{
		}

		// Token: 0x0403AEDA RID: 241370
		[Token(Token = "0x403AEDA")]
		private const int TRACK_VISIBILITY_FRAME_CNT = 5;

		// Token: 0x0403AEDB RID: 241371
		[Token(Token = "0x403AEDB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act9D0EntryZoneView _zoneView;

		// Token: 0x0403AEDC RID: 241372
		[Token(Token = "0x403AEDC")]
		[FieldOffset(Offset = "0x20")]
		private int m_frameCounter;

		// Token: 0x0403AEDD RID: 241373
		[Token(Token = "0x403AEDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403AEDE RID: 241374
		[Token(Token = "0x403AEDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TrackVisibility;

		// Token: 0x0403AEDF RID: 241375
		[Token(Token = "0x403AEDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
