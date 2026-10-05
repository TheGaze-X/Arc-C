using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	internal static class RemoteConfigSettingsHelper
	{
		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		[RequiredByNativeCode]
		internal enum Tag
		{
			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000007")]
			kUnknown,
			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000008")]
			kIntVal,
			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			kInt64Val,
			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			kUInt64Val,
			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			kDoubleVal,
			// Token: 0x0400000C RID: 12
			[Token(Token = "0x400000C")]
			kBoolVal,
			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			kStringVal,
			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			kArrayVal,
			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			kMixedArrayVal,
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			kMapVal,
			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			kMaxTags
		}
	}
}
