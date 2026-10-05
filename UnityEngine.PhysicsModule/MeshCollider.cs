using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
	[NativeHeader("Modules/Physics/MeshCollider.h")]
	public class MeshCollider : Collider
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005A RID: 90
		// (set) Token: 0x0600005B RID: 91
		[Token(Token = "0x17000013")]
		public extern Mesh sharedMesh { [Token(Token = "0x600005A")] [Address(RVA = "0x59C74F0", Offset = "0x59C60F0", VA = "0x1859C74F0")] [MethodImpl(4096)] get; [Token(Token = "0x600005B")] [Address(RVA = "0x59C75C0", Offset = "0x59C61C0", VA = "0x1859C75C0")] [MethodImpl(4096)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005C RID: 92
		// (set) Token: 0x0600005D RID: 93
		[Token(Token = "0x17000014")]
		public extern bool convex { [Token(Token = "0x600005C")] [Address(RVA = "0x59C7470", Offset = "0x59C6070", VA = "0x1859C7470")] [MethodImpl(4096)] get; [Token(Token = "0x600005D")] [Address(RVA = "0x59C7530", Offset = "0x59C6130", VA = "0x1859C7530")] [MethodImpl(4096)] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005E RID: 94
		// (set) Token: 0x0600005F RID: 95
		[Token(Token = "0x17000015")]
		public extern MeshColliderCookingOptions cookingOptions { [Token(Token = "0x600005E")] [Address(RVA = "0x59C74B0", Offset = "0x59C60B0", VA = "0x1859C74B0")] [MethodImpl(4096)] get; [Token(Token = "0x600005F")] [Address(RVA = "0x59C7580", Offset = "0x59C6180", VA = "0x1859C7580")] [MethodImpl(4096)] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Configuring smooth sphere collisions is no longer needed.", true)]
		public bool smoothSphereCollisions
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x3E67470", Offset = "0x3E66070", VA = "0x183E67470")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		[Obsolete("MeshCollider.skinWidth is no longer used.")]
		public float skinWidth
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x592D910", Offset = "0x592C510", VA = "0x18592D910")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000023E8 File Offset: 0x000005E8
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		[Obsolete("MeshCollider.inflateMesh is no longer supported. The new cooking algorithm doesn't need inflation to be used.")]
		public bool inflateMesh
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x591F3A0", Offset = "0x591DFA0", VA = "0x18591F3A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public MeshCollider()
		{
		}
	}
}
