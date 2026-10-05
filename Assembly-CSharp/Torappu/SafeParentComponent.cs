using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000575 RID: 1397
	[Token(Token = "0x2000575")]
	public class SafeParentComponent : MonoBehaviour
	{
		// Token: 0x06005BA5 RID: 23461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0x1AFA8E0", Offset = "0x1AF94E0", VA = "0x181AFA8E0")]
		public void SetParentSafe(Transform child, Action<Transform> onChildAdded)
		{
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0x1AFA720", Offset = "0x1AF9320", VA = "0x181AFA720")]
		public void CancelSetParent(Transform child)
		{
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0x1AFA790", Offset = "0x1AF9390", VA = "0x181AFA790", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x0002EED8 File Offset: 0x0002D0D8
		[Token(Token = "0x6005BA8")]
		[Address(RVA = "0x1AFAA70", Offset = "0x1AF9670", VA = "0x181AFAA70")]
		private int _GetId(Transform child)
		{
			return 0;
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0x1AFAA90", Offset = "0x1AF9690", VA = "0x181AFAA90")]
		public SafeParentComponent()
		{
		}

		// Token: 0x0400212E RID: 8494
		[Token(Token = "0x400212E")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<int, SafeParentComponent.Wrapper> m_cachedChildren;

		// Token: 0x02000576 RID: 1398
		[Token(Token = "0x2000576")]
		private struct Wrapper
		{
			// Token: 0x0400212F RID: 8495
			[Token(Token = "0x400212F")]
			[FieldOffset(Offset = "0x0")]
			public Action<Transform> onChildAdded;

			// Token: 0x04002130 RID: 8496
			[Token(Token = "0x4002130")]
			[FieldOffset(Offset = "0x8")]
			public Transform child;
		}
	}
}
