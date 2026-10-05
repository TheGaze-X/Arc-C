using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public class Collision2D
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x59C2DE0", Offset = "0x59C19E0", VA = "0x1859C2DE0")]
		private ContactPoint2D[] GetContacts_Internal()
		{
			return null;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public Collider2D collider
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x59C2E80", Offset = "0x59C1A80", VA = "0x1859C2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public Rigidbody2D rigidbody
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x59C3090", Offset = "0x59C1C90", VA = "0x1859C3090")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public GameObject gameObject
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x59C2F60", Offset = "0x59C1B60", VA = "0x1859C2F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x59C2DF0", Offset = "0x59C19F0", VA = "0x1859C2DF0")]
		public int GetContacts(ContactPoint2D[] contacts)
		{
			return 0;
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int m_Collider;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int m_OtherCollider;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int m_Rigidbody;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int m_OtherRigidbody;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Vector2 m_RelativeVelocity;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int m_Enabled;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int m_ContactCount;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal ContactPoint2D[] m_ReusedContacts;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal ContactPoint2D[] m_LegacyContacts;
	}
}
