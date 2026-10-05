using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	[Serializable]
	public class MeshGenerator
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x000045EC File Offset: 0x000027EC
		[Token(Token = "0x170001BF")]
		public int VertexCount
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x4E94DE0", Offset = "0x4E939E0", VA = "0x184E94DE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00004604 File Offset: 0x00002804
		[Token(Token = "0x170001C0")]
		public MeshGeneratorBuffers Buffers
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x4E94D40", Offset = "0x4E93940", VA = "0x184E94D40")]
			get
			{
				return default(MeshGeneratorBuffers);
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x4E94A20", Offset = "0x4E93620", VA = "0x184E94A20")]
		public MeshGenerator()
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x4E93180", Offset = "0x4E91D80", VA = "0x184E93180")]
		public static void GenerateSingleSubmeshInstruction(SkeletonRendererInstruction instructionOutput, Skeleton skeleton, Material material)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x4E93E10", Offset = "0x4E92A10", VA = "0x184E93E10")]
		public static bool RequiresMultipleSubmeshesByDrawOrder(Skeleton skeleton)
		{
			return default(bool);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x4E93720", Offset = "0x4E92320", VA = "0x184E93720")]
		public static void GenerateSkeletonRendererInstruction(SkeletonRendererInstruction instructionOutput, Skeleton skeleton, Dictionary<Slot, Material> customSlotMaterials, List<Slot> separatorSlots, bool generateMeshOverride, bool immutableTriangles = false)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x4E94780", Offset = "0x4E93380", VA = "0x184E94780")]
		public static void TryReplaceMaterials(ExposedList<SubmeshInstruction> workingSubmeshInstructions, Dictionary<Material, Material> customMaterialOverride)
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x4E8FBF0", Offset = "0x4E8E7F0", VA = "0x184E8FBF0")]
		public void Begin()
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x4E8EE40", Offset = "0x4E8DA40", VA = "0x184E8EE40")]
		public void AddSubmesh(SubmeshInstruction instruction, bool updateTriangles = true)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x4E91270", Offset = "0x4E8FE70", VA = "0x184E91270")]
		public void BuildMesh(SkeletonRendererInstruction instruction, bool updateTriangles)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x4E8FCD0", Offset = "0x4E8E8D0", VA = "0x184E8FCD0")]
		public void BuildMeshWithArrays(SkeletonRendererInstruction instruction, bool updateTriangles)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x4E93FE0", Offset = "0x4E92BE0", VA = "0x184E93FE0")]
		public void ScaleVertexData(float scale)
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x4E8EC10", Offset = "0x4E8D810", VA = "0x184E8EC10")]
		private void AddAttachmentTintBlack(float r2, float g2, float b2, float a, int vertexCount)
		{
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x4E92BD0", Offset = "0x4E917D0", VA = "0x184E92BD0")]
		public void FillVertexData(Mesh mesh, [Optional] Vector3? overrideBoundsCenter, bool reverseMesh = false)
		{
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x4E915B0", Offset = "0x4E901B0", VA = "0x184E915B0")]
		public void FillLateVertexData(Mesh mesh)
		{
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x4E929C0", Offset = "0x4E915C0", VA = "0x184E929C0")]
		public void FillTriangles(Mesh mesh, bool reverseMesh = false)
		{
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x4E91330", Offset = "0x4E8FF30", VA = "0x184E91330")]
		public void EnsureVertexCapacity(int minimumVertexCount, bool inlcudeTintBlack = false, bool includeTangents = false, bool includeNormals = false)
		{
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x4E94650", Offset = "0x4E93250", VA = "0x184E94650")]
		public void TrimExcess()
		{
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x4E94230", Offset = "0x4E92E30", VA = "0x184E94230")]
		internal static void SolveTangents2DEnsureSize(ref Vector4[] tangentBuffer, ref Vector2[] tempTanBuffer, int vertexCount, int vertexBufferLength)
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x4E942F0", Offset = "0x4E92EF0", VA = "0x184E942F0")]
		internal static void SolveTangents2DTriangles(Vector2[] tempTanBuffer, int[] triangles, int triangleCount, Vector3[] vertices, Vector2[] uvs, int vertexCount)
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x4E940A0", Offset = "0x4E92CA0", VA = "0x184E940A0")]
		internal static void SolveTangents2DBuffer(Vector4[] tangents, Vector2[] tempTanBuffer, int vertexCount)
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x4E92170", Offset = "0x4E90D70", VA = "0x184E92170")]
		public static void FillMeshLocal(Mesh mesh, RegionAttachment regionAttachment)
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x4E91980", Offset = "0x4E90580", VA = "0x184E91980")]
		public static void FillMeshLocal(Mesh mesh, MeshAttachment meshAttachment, SkeletonData skeletonData)
		{
		}

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MeshGenerator.Settings settings;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		private const float BoundsMinDefault = float.PositiveInfinity;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		private const float BoundsMaxDefault = float.NegativeInfinity;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private readonly ExposedList<Vector3> vertexBuffer;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private readonly ExposedList<Vector2> uvBuffer;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		private readonly ExposedList<Color32> colorBuffer;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private readonly ExposedList<ExposedList<int>> submeshes;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private Vector2 meshBoundsMin;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private Vector2 meshBoundsMax;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private float meshBoundsThickness;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[NonSerialized]
		private int submeshIndex;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private SkeletonClipping clipper;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private float[] tempVerts;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private int[] regionTriangles;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Vector3[] normals;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private Vector4[] tangents;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private Vector2[] tempTanBuffer;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private ExposedList<Vector2> uv2;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private ExposedList<Vector2> uv3;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Vector3> AttachmentVerts;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Vector2> AttachmentUVs;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Color32> AttachmentColors32;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<int> AttachmentIndices;

		// Token: 0x020000AE RID: 174
		[Token(Token = "0x20000AE")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00004634 File Offset: 0x00002834
			[Token(Token = "0x170001C1")]
			public static MeshGenerator.Settings Default
			{
				[Token(Token = "0x60006B7")]
				[Address(RVA = "0x4E953C0", Offset = "0x4E93FC0", VA = "0x184E953C0")]
				get
				{
					return default(MeshGenerator.Settings);
				}
			}

			// Token: 0x04000431 RID: 1073
			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool useClipping;

			// Token: 0x04000432 RID: 1074
			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(-0.1f, 0f)]
			[Space]
			public float zSpacing;

			// Token: 0x04000433 RID: 1075
			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Space]
			[Header("Vertex Data")]
			public bool pmaVertexColors;

			// Token: 0x04000434 RID: 1076
			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool tintBlack;

			// Token: 0x04000435 RID: 1077
			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			[Tooltip("Enable when using Additive blend mode at SkeletonGraphic under a CanvasGroup. When enabled, Additive alpha value is stored at uv2.g instead of color.a to capture CanvasGroup modifying color.a.")]
			public bool canvasGroupTintBlack;

			// Token: 0x04000436 RID: 1078
			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			public bool calculateTangents;

			// Token: 0x04000437 RID: 1079
			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool addNormals;

			// Token: 0x04000438 RID: 1080
			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool immutableTriangles;
		}
	}
}
