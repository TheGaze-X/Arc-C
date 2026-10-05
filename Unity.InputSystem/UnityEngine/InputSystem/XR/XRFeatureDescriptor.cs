using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	[Serializable]
	public struct XRFeatureDescriptor
	{
		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x8")]
		public List<UsageHint> usageHints;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x10")]
		public FeatureType featureType;

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x14")]
		public uint customSize;
	}
}
