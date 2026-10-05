using System;
using Il2CppDummyDll;

namespace UnityEngine.XR
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Flags]
	internal enum AvailableTrackingData
	{
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		None = 0,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		PositionAvailable = 1,
		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		RotationAvailable = 2,
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		VelocityAvailable = 4,
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		AngularVelocityAvailable = 8,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		AccelerationAvailable = 16,
		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		AngularAccelerationAvailable = 32
	}
}
