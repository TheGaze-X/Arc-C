using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Terrain/Public/Terrain.h")]
	[StaticAccessor("GetITerrainManager()", StaticAccessorType.Arrow)]
	[NativeHeader("TerrainScriptingClasses.h")]
	public sealed class Terrain : Behaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3
		[Token(Token = "0x17000001")]
		public extern TerrainData terrainData { [Token(Token = "0x6000003")] [Address(RVA = "0x59CF2E0", Offset = "0x59CDEE0", VA = "0x1859CF2E0")] [MethodImpl(4096)] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4
		[Token(Token = "0x17000002")]
		public extern bool allowAutoConnect { [Token(Token = "0x6000004")] [Address(RVA = "0x59CF260", Offset = "0x59CDE60", VA = "0x1859CF260")] [MethodImpl(4096)] get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5
		[Token(Token = "0x17000003")]
		public extern int groupingID { [Token(Token = "0x6000005")] [Address(RVA = "0x59CF2A0", Offset = "0x59CDEA0", VA = "0x1859CF2A0")] [MethodImpl(4096)] get; }

		// Token: 0x06000006 RID: 6
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x59CF1C0", Offset = "0x59CDDC0", VA = "0x1859CF1C0")]
		[MethodImpl(4096)]
		public extern void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom);

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7
		[Token(Token = "0x17000004")]
		[NativeProperty("ActiveTerrainsScriptingArray")]
		public static extern Terrain[] activeTerrains { [Token(Token = "0x6000007")] [Address(RVA = "0x59CF230", Offset = "0x59CDE30", VA = "0x1859CF230")] [MethodImpl(4096)] get; }

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Terrain()
		{
		}
	}
}
