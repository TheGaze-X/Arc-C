using System;
using Il2CppDummyDll;

namespace UnityEngine.XR
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Flags]
	public enum InputTrackingState : uint
	{
		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		None = 0U,
		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		Position = 1U,
		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		Rotation = 2U,
		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		Velocity = 4U,
		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		AngularVelocity = 8U,
		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		Acceleration = 16U,
		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		AngularAcceleration = 32U,
		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		All = 63U
	}
}
