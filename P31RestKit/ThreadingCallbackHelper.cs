using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Prime31
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class ThreadingCallbackHelper : MonoBehaviour
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4E160F0", Offset = "0x4E14CF0", VA = "0x184E160F0")]
		public void addActionToQueue(Action action)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4E15EA0", Offset = "0x4E14AA0", VA = "0x184E15EA0")]
		private void Update()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x4E161A0", Offset = "0x4E14DA0", VA = "0x184E161A0")]
		public void disableIfEmpty()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x4E16030", Offset = "0x4E14C30", VA = "0x184E16030")]
		public ThreadingCallbackHelper()
		{
		}

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x18")]
		private List<Action> _actions;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x20")]
		private List<Action> _currentActions;
	}
}
