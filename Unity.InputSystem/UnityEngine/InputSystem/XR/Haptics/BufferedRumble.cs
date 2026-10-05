using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.XR.Haptics
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	public struct BufferedRumble
	{
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00005D90 File Offset: 0x00003F90
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000329")]
		public HapticCapabilities capabilities
		{
			[Token(Token = "0x6000C31")]
			[Address(RVA = "0x361F7D0", Offset = "0x361E3D0", VA = "0x18361F7D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(HapticCapabilities);
			}
			[Token(Token = "0x6000C32")]
			[Address(RVA = "0x361F830", Offset = "0x361E430", VA = "0x18361F830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032A")]
		private InputDevice device
		{
			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x569C900", Offset = "0x569B500", VA = "0x18569C900")]
		public BufferedRumble(InputDevice device)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x569C680", Offset = "0x569B280", VA = "0x18569C680")]
		public void EnqueueRumble(byte[] samples)
		{
		}
	}
}
