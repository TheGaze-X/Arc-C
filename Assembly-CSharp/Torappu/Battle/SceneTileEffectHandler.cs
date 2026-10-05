using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021F5 RID: 8693
	[Token(Token = "0x20021F5")]
	public class SceneTileEffectHandler : IHotfixable
	{
		// Token: 0x0600D98B RID: 55691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D98B")]
		[Address(RVA = "0x35ED070", Offset = "0x35EBC70", VA = "0x1835ED070")]
		public void Init()
		{
		}

		// Token: 0x0600D98C RID: 55692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D98C")]
		[Address(RVA = "0x35ED3E0", Offset = "0x35EBFE0", VA = "0x1835ED3E0")]
		public void SetTileStatus(GridPosition grid, bool isInside)
		{
		}

		// Token: 0x0600D98D RID: 55693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D98D")]
		[Address(RVA = "0x35ED0E0", Offset = "0x35EBCE0", VA = "0x1835ED0E0")]
		public void ReleaseResource()
		{
		}

		// Token: 0x0600D98E RID: 55694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D98E")]
		private static void _ResizeList<T>(List<List<T>> target, int height, int width)
		{
		}

		// Token: 0x0600D98F RID: 55695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D98F")]
		[Address(RVA = "0x35ED7C0", Offset = "0x35EC3C0", VA = "0x1835ED7C0")]
		private void _InitParams()
		{
		}

		// Token: 0x0600D990 RID: 55696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D990")]
		[Address(RVA = "0x35EDB30", Offset = "0x35EC730", VA = "0x1835EDB30")]
		private void _InitRTCamera()
		{
		}

		// Token: 0x0600D991 RID: 55697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D991")]
		[Address(RVA = "0x35EE060", Offset = "0x35ECC60", VA = "0x1835EE060")]
		private void _ManageMeshMatrix(GridPosition grid, bool exist)
		{
		}

		// Token: 0x0600D992 RID: 55698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D992")]
		[Address(RVA = "0x35ED480", Offset = "0x35EC080", VA = "0x1835ED480")]
		private GameObject _DrawMeshObjViaGrid(GridPosition grid)
		{
			return null;
		}

		// Token: 0x0600D993 RID: 55699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D993")]
		[Address(RVA = "0x35EE2F0", Offset = "0x35ECEF0", VA = "0x1835EE2F0")]
		public SceneTileEffectHandler()
		{
		}

		// Token: 0x0400EAB3 RID: 60083
		[Token(Token = "0x400EAB3")]
		private const string RT_HOLDER_STR = "RtHolder";

		// Token: 0x0400EAB4 RID: 60084
		[Token(Token = "0x400EAB4")]
		private const string MESH_HOLDER_STR = "MeshHolder";

		// Token: 0x0400EAB5 RID: 60085
		[Token(Token = "0x400EAB5")]
		private const string MESH_OEBJECT_STR = "MeshObj";

		// Token: 0x0400EAB6 RID: 60086
		[Token(Token = "0x400EAB6")]
		private const string RT_CAMERA_STR = "RtCamera";

		// Token: 0x0400EAB7 RID: 60087
		[Token(Token = "0x400EAB7")]
		private const string RT_TEXTURE_STR = "RtTexture";

		// Token: 0x0400EAB8 RID: 60088
		[Token(Token = "0x400EAB8")]
		private const string RT_SHADER_PATH = "Torappu/Particles/Additive";

		// Token: 0x0400EAB9 RID: 60089
		[Token(Token = "0x400EAB9")]
		private const int RT_TEXTURE_EDGE = 256;

		// Token: 0x0400EABA RID: 60090
		[Token(Token = "0x400EABA")]
		private const float RT_CAMERA_DELTA_Z = -50f;

		// Token: 0x0400EABB RID: 60091
		[Token(Token = "0x400EABB")]
		private const float RT_CAMERA_NEAR_PLANE = 0f;

		// Token: 0x0400EABC RID: 60092
		[Token(Token = "0x400EABC")]
		private const float RT_CAMERA_FAR_PLANE = 15f;

		// Token: 0x0400EABD RID: 60093
		[Token(Token = "0x400EABD")]
		private const float RT_CAMERA_SIZE = 30f;

		// Token: 0x0400EABE RID: 60094
		[Token(Token = "0x400EABE")]
		private const float MESH_DELTA_Z = 5f;

		// Token: 0x0400EABF RID: 60095
		[Token(Token = "0x400EABF")]
		[FieldOffset(Offset = "0x10")]
		private List<List<GameObject>> m_meshMatrixStorage;

		// Token: 0x0400EAC0 RID: 60096
		[Token(Token = "0x400EAC0")]
		[FieldOffset(Offset = "0x18")]
		private int m_mapWidth;

		// Token: 0x0400EAC1 RID: 60097
		[Token(Token = "0x400EAC1")]
		[FieldOffset(Offset = "0x1C")]
		private int m_mapHeight;

		// Token: 0x0400EAC2 RID: 60098
		[Token(Token = "0x400EAC2")]
		[FieldOffset(Offset = "0x20")]
		private Camera m_rtCamera;

		// Token: 0x0400EAC3 RID: 60099
		[Token(Token = "0x400EAC3")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture m_renderTexture;

		// Token: 0x0400EAC4 RID: 60100
		[Token(Token = "0x400EAC4")]
		[FieldOffset(Offset = "0x30")]
		private EasyMeshGenerator m_generator;

		// Token: 0x0400EAC5 RID: 60101
		[Token(Token = "0x400EAC5")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_Objholder;

		// Token: 0x0400EAC6 RID: 60102
		[Token(Token = "0x400EAC6")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_meshHolder;

		// Token: 0x0400EAC7 RID: 60103
		[Token(Token = "0x400EAC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400EAC8 RID: 60104
		[Token(Token = "0x400EAC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetTileStatus;

		// Token: 0x0400EAC9 RID: 60105
		[Token(Token = "0x400EAC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReleaseResource;

		// Token: 0x0400EACA RID: 60106
		[Token(Token = "0x400EACA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResizeList;

		// Token: 0x0400EACB RID: 60107
		[Token(Token = "0x400EACB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitParams;

		// Token: 0x0400EACC RID: 60108
		[Token(Token = "0x400EACC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitRTCamera;

		// Token: 0x0400EACD RID: 60109
		[Token(Token = "0x400EACD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ManageMeshMatrix;

		// Token: 0x0400EACE RID: 60110
		[Token(Token = "0x400EACE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DrawMeshObjViaGrid;

		// Token: 0x0400EACF RID: 60111
		[Token(Token = "0x400EACF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
