using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Physics/MessageParameters.h")]
	public struct ContactPoint
	{
		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x0")]
		internal Vector3 m_Point;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0xC")]
		internal Vector3 m_Normal;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x18")]
		internal int m_ThisColliderInstanceID;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x1C")]
		internal int m_OtherColliderInstanceID;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x20")]
		internal float m_Separation;
	}
}
