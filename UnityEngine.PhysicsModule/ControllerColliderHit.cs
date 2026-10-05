using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public class ControllerColliderHit
	{
		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal CharacterController m_Controller;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Collider m_Collider;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Vector3 m_Point;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal Vector3 m_Normal;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Vector3 m_MoveDirection;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal float m_MoveLength;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal int m_Push;
	}
}
