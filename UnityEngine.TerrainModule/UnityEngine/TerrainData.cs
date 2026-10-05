using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[NativeHeader("TerrainScriptingClasses.h")]
	[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
	[UsedByNativeCode]
	public sealed class TerrainData : Object
	{
		// Token: 0x0600000F RID: 15
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x59CD270", Offset = "0x59CBE70", VA = "0x1859CD270")]
		[ThreadSafe]
		[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern int GetBoundaryValue(TerrainData.BoundaryValueType type);

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x59CD510", Offset = "0x59CC110", VA = "0x1859CD510")]
		public TerrainData()
		{
		}

		// Token: 0x06000011 RID: 17
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x59CD2B0", Offset = "0x59CBEB0", VA = "0x1859CD2B0")]
		[FreeFunction("TerrainDataScriptingInterface::Create")]
		[MethodImpl(4096)]
		private static extern void Internal_Create([Writable] TerrainData terrainData);

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x17000005")]
		public Vector3 size
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x59CD5F0", Offset = "0x59CC1F0", VA = "0x1859CD5F0")]
			[NativeName("GetHeightmap().GetSize")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000013 RID: 19
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x59CD230", Offset = "0x59CBE30", VA = "0x1859CD230")]
		[NativeName("GetSplatDatabase().GetAlphamapResolution")]
		[RequiredByNativeCode]
		[MethodImpl(4096)]
		internal extern float GetAlphamapResolutionInternal();

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20
		[Token(Token = "0x17000006")]
		internal extern Terrain[] users { [Token(Token = "0x6000014")] [Address(RVA = "0x59CD640", Offset = "0x59CC240", VA = "0x1859CD640")] [MethodImpl(4096)] get; }

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x59CD5A0", Offset = "0x59CC1A0", VA = "0x1859CD5A0")]
		[MethodImpl(4096)]
		private extern void get_size_Injected(out Vector3 ret);

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int k_MaximumResolution;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x4")]
		internal static readonly int k_MinimumDetailResolutionPerPatch;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int k_MaximumDetailResolutionPerPatch;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0xC")]
		internal static readonly int k_MaximumDetailPatchCount;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int k_MaximumDetailsPerRes;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x14")]
		internal static readonly int k_MinimumAlphamapResolution;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly int k_MaximumAlphamapResolution;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x1C")]
		internal static readonly int k_MinimumBaseMapResolution;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly int k_MaximumBaseMapResolution;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		private enum BoundaryValueType
		{
			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			MaxHeightmapRes,
			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			MinDetailResPerPatch,
			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			MaxDetailResPerPatch,
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			MaxDetailPatchCount,
			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			MaxDetailsPerRes,
			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			MinAlphamapRes,
			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			MaxAlphamapRes,
			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			MinBaseMapRes,
			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			MaxBaseMapRes
		}
	}
}
