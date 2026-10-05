using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
	[RequiredByNativeCode(Optional = false, GenerateProxy = true)]
	[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
	public struct ContactPoint2D
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x17000008")]
		public Vector2 point
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x3BFB910", Offset = "0x3BFA510", VA = "0x183BFB910")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("point")]
		private Vector2 m_Point;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x8")]
		[NativeName("normal")]
		private Vector2 m_Normal;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x10")]
		[NativeName("relativeVelocity")]
		private Vector2 m_RelativeVelocity;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x18")]
		[NativeName("separation")]
		private float m_Separation;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x1C")]
		[NativeName("normalImpulse")]
		private float m_NormalImpulse;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x20")]
		[NativeName("tangentImpulse")]
		private float m_TangentImpulse;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x24")]
		[NativeName("collider")]
		private int m_Collider;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x28")]
		[NativeName("otherCollider")]
		private int m_OtherCollider;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x2C")]
		[NativeName("rigidbody")]
		private int m_Rigidbody;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x30")]
		[NativeName("otherRigidbody")]
		private int m_OtherRigidbody;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x34")]
		[NativeName("enabled")]
		private int m_Enabled;
	}
}
