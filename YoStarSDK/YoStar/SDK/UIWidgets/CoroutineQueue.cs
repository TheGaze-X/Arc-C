using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	public class CoroutineQueue
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x5C25DF0", Offset = "0x5C249F0", VA = "0x185C25DF0")]
		public CoroutineQueue(MonoBehaviour coroutineOwner)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x5C25D00", Offset = "0x5C24900", VA = "0x185C25D00")]
		public void Start()
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x5C25DA0", Offset = "0x5C249A0", VA = "0x185C25DA0")]
		public void Stop()
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x5C25C20", Offset = "0x5C24820", VA = "0x185C25C20")]
		public void EnqueueAction(IEnumerator aAction)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x5C25C80", Offset = "0x5C24880", VA = "0x185C25C80")]
		private IEnumerator Process()
		{
			return null;
		}

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x10")]
		private MonoBehaviour m_Owner;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine m_InternalCoroutine;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x20")]
		private Queue<IEnumerator> actions;
	}
}
