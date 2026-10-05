using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	public struct Bone
	{
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00005C70 File Offset: 0x00003E70
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000315")]
		public uint parentBoneIndex
		{
			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000C01")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			set
			{
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00005C88 File Offset: 0x00003E88
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000316")]
		public Vector3 position
		{
			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x4007540", Offset = "0x4006140", VA = "0x184007540")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x569C670", Offset = "0x569B270", VA = "0x18569C670")]
			set
			{
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00005CA0 File Offset: 0x00003EA0
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000317")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x4E6DD0", Offset = "0x4E59D0", VA = "0x1804E6DD0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x4E6EA0", Offset = "0x4E5AA0", VA = "0x1804E6EA0")]
			set
			{
			}
		}

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x0")]
		public uint m_ParentBoneIndex;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x4")]
		public Vector3 m_Position;

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x10")]
		public Quaternion m_Rotation;
	}
}
