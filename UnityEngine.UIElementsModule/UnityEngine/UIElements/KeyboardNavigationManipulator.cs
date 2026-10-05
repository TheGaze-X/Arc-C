using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	public class KeyboardNavigationManipulator : Manipulator
	{
		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
		public KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x5A36910", Offset = "0x5A35510", VA = "0x185A36910", Slot = "5")]
		protected override void RegisterCallbacksOnTarget()
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x5A36D00", Offset = "0x5A35900", VA = "0x185A36D00", Slot = "6")]
		protected override void UnregisterCallbacksFromTarget()
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x5A36550", Offset = "0x5A35150", VA = "0x185A36550")]
		internal void OnKeyDown(KeyDownEvent evt)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x5A36840", Offset = "0x5A35440", VA = "0x185A36840")]
		private void OnRuntimeKeyDown(KeyDownEvent evt)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x5A36420", Offset = "0x5A35020", VA = "0x185A36420")]
		private void OnEditorKeyDown(KeyDownEvent evt)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x5A36790", Offset = "0x5A35390", VA = "0x185A36790")]
		private void OnNavigationCancel(NavigationCancelEvent evt)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x5A36820", Offset = "0x5A35420", VA = "0x185A36820")]
		private void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x5A367B0", Offset = "0x5A353B0", VA = "0x185A367B0")]
		private void OnNavigationMove(NavigationMoveEvent evt)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x5A36400", Offset = "0x5A35000", VA = "0x185A36400")]
		private void Invoke(KeyboardNavigationOperation operation, EventBase evt)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x5A36C40", Offset = "0x5A35840", VA = "0x185A36C40")]
		[CompilerGenerated]
		internal static KeyboardNavigationOperation <OnRuntimeKeyDown>g__GetOperation|5_0(ref KeyboardNavigationManipulator.<>c__DisplayClass5_0 A_0)
		{
			return KeyboardNavigationOperation.None;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x5A36B10", Offset = "0x5A35710", VA = "0x185A36B10")]
		[CompilerGenerated]
		internal static KeyboardNavigationOperation <OnEditorKeyDown>g__GetOperation|6_0(ref KeyboardNavigationManipulator.<>c__DisplayClass6_0 A_0)
		{
			return KeyboardNavigationOperation.None;
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action<KeyboardNavigationOperation, EventBase> m_Action;
	}
}
