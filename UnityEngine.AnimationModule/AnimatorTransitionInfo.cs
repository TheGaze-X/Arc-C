using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorTransitionInfo
	{
		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("fullPathHash")]
		private int m_FullPath;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x4")]
		[NativeName("userNameHash")]
		private int m_UserName;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x8")]
		[NativeName("nameHash")]
		private int m_Name;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0xC")]
		[NativeName("hasFixedDuration")]
		private bool m_HasFixedDuration;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x10")]
		[NativeName("duration")]
		private float m_Duration;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x14")]
		[NativeName("normalizedTime")]
		private float m_NormalizedTime;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		[NativeName("anyState")]
		private bool m_AnyState;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x1C")]
		[NativeName("transitionType")]
		private int m_TransitionType;
	}
}
