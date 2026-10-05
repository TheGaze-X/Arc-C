using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200266B RID: 9835
	[Token(Token = "0x200266B")]
	[RequireComponent(typeof(SkeletonAnimation), typeof(MeshFilter), typeof(MeshRenderer))]
	public class SpineDepthOnlyGhost : MonoBehaviour
	{
		// Token: 0x06010162 RID: 65890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010162")]
		[Address(RVA = "0x7D10F0", Offset = "0x7CFCF0", VA = "0x1807D10F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06010163 RID: 65891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010163")]
		[Address(RVA = "0x7D0F70", Offset = "0x7CFB70", VA = "0x1807D0F70")]
		private void LateUpdate()
		{
		}

		// Token: 0x06010164 RID: 65892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010164")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public SpineDepthOnlyGhost()
		{
		}

		// Token: 0x04011E4A RID: 73290
		[Token(Token = "0x4011E4A")]
		private const string DEPTHONLY_SHADER_NAME = "Torappu/Spine/Skeleton (DepthOnly)";

		// Token: 0x04011E4B RID: 73291
		[Token(Token = "0x4011E4B")]
		private const string DEPTHONLY_MATERIAL_KEY = "SPINE_DEPTH_ONLY";

		// Token: 0x04011E4C RID: 73292
		[Token(Token = "0x4011E4C")]
		[FieldOffset(Offset = "0x0")]
		private static Shader s_shader;

		// Token: 0x04011E4D RID: 73293
		[Token(Token = "0x4011E4D")]
		[FieldOffset(Offset = "0x18")]
		[Inspect]
		[ReadOnly]
		private bool m_inited;

		// Token: 0x04011E4E RID: 73294
		[Token(Token = "0x4011E4E")]
		[FieldOffset(Offset = "0x20")]
		[Inspect]
		[ReadOnly]
		private Material m_material;

		// Token: 0x04011E4F RID: 73295
		[Token(Token = "0x4011E4F")]
		[FieldOffset(Offset = "0x28")]
		private MeshFilter m_meshFilter;
	}
}
