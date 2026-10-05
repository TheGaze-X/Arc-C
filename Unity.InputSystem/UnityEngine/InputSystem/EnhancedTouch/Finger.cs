using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.EnhancedTouch
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	public class Finger
	{
		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003C5")]
		public Touchscreen screen
		{
			[Token(Token = "0x6000E4C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x170003C6")]
		public int index
		{
			[Token(Token = "0x6000E4D")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x170003C7")]
		public bool isActive
		{
			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0x56D5B90", Offset = "0x56D4790", VA = "0x1856D5B90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x170003C8")]
		public Vector2 screenPosition
		{
			[Token(Token = "0x6000E4F")]
			[Address(RVA = "0x56D5D00", Offset = "0x56D4900", VA = "0x1856D5D00")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00007128 File Offset: 0x00005328
		[Token(Token = "0x170003C9")]
		public Touch lastTouch
		{
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x56D5C20", Offset = "0x56D4820", VA = "0x1856D5C20")]
			get
			{
				return default(Touch);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x170003CA")]
		public Touch currentTouch
		{
			[Token(Token = "0x6000E51")]
			[Address(RVA = "0x56D5950", Offset = "0x56D4550", VA = "0x1856D5950")]
			get
			{
				return default(Touch);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x170003CB")]
		public TouchHistory touchHistory
		{
			[Token(Token = "0x6000E52")]
			[Address(RVA = "0x56D5E40", Offset = "0x56D4A40", VA = "0x1856D5E40")]
			get
			{
				return default(TouchHistory);
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x56D55D0", Offset = "0x56D41D0", VA = "0x1856D55D0")]
		internal Finger(Touchscreen screen, int index, InputUpdateType updateMask)
		{
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x56D5530", Offset = "0x56D4130", VA = "0x1856D5530")]
		private static bool ShouldRecordTouch(InputControl control, double time, InputEventPtr eventPtr)
		{
			return default(bool);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x56D5250", Offset = "0x56D3E50", VA = "0x1856D5250")]
		private void OnTouchRecorded(InputStateHistory.Record record)
		{
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00007188 File Offset: 0x00005388
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x56D4CD0", Offset = "0x56D38D0", VA = "0x1856D4CD0")]
		private Touch FindTouch(uint uniqueId)
		{
			return default(Touch);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000071A0 File Offset: 0x000053A0
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x56D4F90", Offset = "0x56D3B90", VA = "0x1856D4F90")]
		internal TouchHistory GetTouchHistory(Touch touch)
		{
			return default(TouchHistory);
		}

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x20")]
		internal readonly InputStateHistory<TouchState> m_StateHistory;
	}
}
