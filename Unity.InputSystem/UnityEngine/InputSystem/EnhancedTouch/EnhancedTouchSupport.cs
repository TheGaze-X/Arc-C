using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.EnhancedTouch
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public static class EnhancedTouchSupport
	{
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x170003C4")]
		public static bool enabled
		{
			[Token(Token = "0x6000E43")]
			[Address(RVA = "0x56D3E10", Offset = "0x56D2A10", VA = "0x1856D3E10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x56D2FD0", Offset = "0x56D1BD0", VA = "0x1856D2FD0")]
		public static void Enable()
		{
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x56D2E40", Offset = "0x56D1A40", VA = "0x1856D2E40")]
		public static void Disable()
		{
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x56D3970", Offset = "0x56D2570", VA = "0x1856D3970")]
		internal static void Reset()
		{
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x56D3A30", Offset = "0x56D2630", VA = "0x1856D3A30")]
		private static void SetUpState()
		{
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x56D3BE0", Offset = "0x56D27E0", VA = "0x1856D3BE0")]
		internal static void TearDownState()
		{
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x56D3140", Offset = "0x56D1D40", VA = "0x1856D3140")]
		private static void OnDeviceChange(InputDevice device, InputDeviceChange change)
		{
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x56D38F0", Offset = "0x56D24F0", VA = "0x1856D38F0")]
		private static void OnSettingsChange()
		{
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x56D2DA0", Offset = "0x56D19A0", VA = "0x1856D2DA0")]
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal static void CheckEnabled()
		{
		}

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x0")]
		private static int s_Enabled;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x4")]
		private static InputSettings.UpdateMode s_UpdateMode;
	}
}
