using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	internal class VisualElementFocusChangeTarget : FocusChangeDirection
	{
		// Token: 0x06000576 RID: 1398 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x5A9F1A0", Offset = "0x5A9DDA0", VA = "0x185A9F1A0")]
		public static VisualElementFocusChangeTarget GetPooled(Focusable target)
		{
			return null;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x5A9F110", Offset = "0x5A9DD10", VA = "0x185A9F110", Slot = "5")]
		protected override void Dispose()
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x5A9F0D0", Offset = "0x5A9DCD0", VA = "0x185A9F0D0", Slot = "6")]
		internal override void ApplyTo(FocusController focusController, Focusable f)
		{
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x5A9F2E0", Offset = "0x5A9DEE0", VA = "0x185A9F2E0")]
		public VisualElementFocusChangeTarget()
		{
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013B")]
		public Focusable target
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<VisualElementFocusChangeTarget> Pool;
	}
}
