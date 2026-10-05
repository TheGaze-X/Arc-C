using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	public struct MeshGenerationResult : IEquatable<MeshGenerationResult>
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x1700000D")]
		public readonly MeshId MeshId
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0")]
			[CompilerGenerated]
			get
			{
				return default(MeshId);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000E")]
		public readonly Mesh Mesh
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000F")]
		public readonly MeshCollider MeshCollider
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x17000010")]
		public readonly MeshGenerationStatus Status
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return MeshGenerationStatus.Success;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x17000011")]
		public readonly MeshVertexAttributes Attributes
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			[CompilerGenerated]
			get
			{
				return MeshVertexAttributes.None;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x17000012")]
		public readonly Vector3 Position
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x34BF5A0", Offset = "0x34BE1A0", VA = "0x1834BF5A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x17000013")]
		public readonly Quaternion Rotation
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x5BA2F80", Offset = "0x5BA1B80", VA = "0x185BA2F80")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x17000014")]
		public readonly Vector3 Scale
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x5BA2F90", Offset = "0x5BA1B90", VA = "0x185BA2F90")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x5BA29B0", Offset = "0x5BA15B0", VA = "0x185BA29B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x5BA2A90", Offset = "0x5BA1690", VA = "0x185BA2A90", Slot = "4")]
		public bool Equals(MeshGenerationResult other)
		{
			return default(bool);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x5BA2CD0", Offset = "0x5BA18D0", VA = "0x185BA2CD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
