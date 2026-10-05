using System;
using Il2CppDummyDll;

namespace UnityEngine.XR
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[Flags]
	public enum InputDeviceCharacteristics : uint
	{
		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		None = 0U,
		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		HeadMounted = 1U,
		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		Camera = 2U,
		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		HeldInHand = 4U,
		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		HandTracking = 8U,
		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		EyeTracking = 16U,
		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		TrackedDevice = 32U,
		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		Controller = 64U,
		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		TrackingReference = 128U,
		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		Left = 256U,
		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		Right = 512U,
		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		Simulated6DOF = 1024U
	}
}
