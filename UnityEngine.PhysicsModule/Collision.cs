using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public class Collision
	{
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Vector3 m_Impulse;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal Vector3 m_RelativeVelocity;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Component m_Body;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal Collider m_Collider;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int m_ContactCount;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal ContactPoint[] m_ReusedContacts;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal ContactPoint[] m_LegacyContacts;
	}
}
