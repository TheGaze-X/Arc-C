using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x0200022F RID: 559
	[Token(Token = "0x200022F")]
	internal struct CallbackArray<TDelegate> where TDelegate : Delegate
	{
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x170005C6")]
		public int length
		{
			[Token(Token = "0x6001469")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005C7 RID: 1479
		[Token(Token = "0x170005C7")]
		public TDelegate this[int index]
		{
			[Token(Token = "0x600146A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146B")]
		public void Clear()
		{
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146C")]
		public void AddCallback(TDelegate dlg)
		{
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146D")]
		public void RemoveCallback(TDelegate dlg)
		{
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146E")]
		public void LockForChanges()
		{
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146F")]
		public void UnlockForChanges()
		{
		}

		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		[FieldOffset(Offset = "0x0")]
		private bool m_CannotMutateCallbacksArray;

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0x0")]
		private InlinedArray<TDelegate> m_Callbacks;

		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x0")]
		private InlinedArray<TDelegate> m_CallbacksToAdd;

		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x0")]
		private InlinedArray<TDelegate> m_CallbacksToRemove;
	}
}
