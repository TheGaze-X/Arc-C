using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x0200025B RID: 603
	[Token(Token = "0x200025B")]
	internal sealed class SavedStructState<T> : ISavedState where T : struct
	{
		// Token: 0x060015CF RID: 5583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CF")]
		internal SavedStructState(ref T state, SavedStructState<T>.TypedRestore restoreAction, [Optional] Action staticDisposeCurrentState)
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D0")]
		public void StaticDisposeCurrentState()
		{
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D1")]
		public void RestoreSavedState()
		{
		}

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T m_State;

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SavedStructState<T>.TypedRestore m_RestoreAction;

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action m_StaticDisposeCurrentState;

		// Token: 0x0200025C RID: 604
		// (Invoke) Token: 0x060015D3 RID: 5587
		[Token(Token = "0x200025C")]
		public delegate void TypedRestore(ref T state);
	}
}
