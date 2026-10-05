using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	public class ButtonControl : AxisControl
	{
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x0000A380 File Offset: 0x00008580
		[Token(Token = "0x17000583")]
		public float pressPointOrDefault
		{
			[Token(Token = "0x6001369")]
			[Address(RVA = "0x55FABB0", Offset = "0x55F97B0", VA = "0x1855FABB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x55FAA70", Offset = "0x55F9670", VA = "0x1855FAA70")]
		public ButtonControl()
		{
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x55F9710", Offset = "0x55F8310", VA = "0x1855F9710")]
		[MethodImpl(256)]
		public new bool IsValueConsideredPressed(float value)
		{
			return default(bool);
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x17000584")]
		public bool isPressed
		{
			[Token(Token = "0x600136C")]
			[Address(RVA = "0x55FAB20", Offset = "0x55F9720", VA = "0x1855FAB20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[Token(Token = "0x17000585")]
		public bool wasPressedThisFrame
		{
			[Token(Token = "0x600136D")]
			[Address(RVA = "0x55FAC00", Offset = "0x55F9800", VA = "0x1855FAC00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x17000586")]
		public bool wasReleasedThisFrame
		{
			[Token(Token = "0x600136E")]
			[Address(RVA = "0x55FACF0", Offset = "0x55F98F0", VA = "0x1855FACF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000B96 RID: 2966
		[Token(Token = "0x4000B96")]
		[FieldOffset(Offset = "0x130")]
		public float pressPoint;

		// Token: 0x04000B97 RID: 2967
		[Token(Token = "0x4000B97")]
		[FieldOffset(Offset = "0x0")]
		internal static float s_GlobalDefaultButtonPressPoint;

		// Token: 0x04000B98 RID: 2968
		[Token(Token = "0x4000B98")]
		[FieldOffset(Offset = "0x4")]
		internal static float s_GlobalDefaultButtonReleaseThreshold;

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		internal const float kMinButtonPressPoint = 0.0001f;
	}
}
