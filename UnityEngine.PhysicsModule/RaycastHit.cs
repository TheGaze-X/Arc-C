using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[NativeHeader("Modules/Physics/RaycastHit.h")]
	[NativeHeader("PhysicsScriptingClasses.h")]
	[NativeHeader("Runtime/Interfaces/IRaycast.h")]
	[UsedByNativeCode]
	public struct RaycastHit
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x17000002")]
		public Collider collider
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x59CAC30", Offset = "0x59C9830", VA = "0x1859CAC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x17000003")]
		public Vector3 point
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x5920CC0", Offset = "0x591F8C0", VA = "0x185920CC0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000004")]
		public Vector3 normal
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x5920CE0", Offset = "0x591F8E0", VA = "0x185920CE0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x17000005")]
		public float distance
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x59BA3A0", Offset = "0x59B8FA0", VA = "0x1859BA3A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x17000006")]
		public Transform transform
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x59CADC0", Offset = "0x59C99C0", VA = "0x1859CADC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x17000007")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x59CAD10", Offset = "0x59C9910", VA = "0x1859CAD10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("point")]
		internal Vector3 m_Point;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xC")]
		[NativeName("normal")]
		internal Vector3 m_Normal;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x18")]
		[NativeName("faceID")]
		internal uint m_FaceID;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x1C")]
		[NativeName("distance")]
		internal float m_Distance;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		[NativeName("uv")]
		internal Vector2 m_UV;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x28")]
		[NativeName("collider")]
		internal int m_Collider;
	}
}
