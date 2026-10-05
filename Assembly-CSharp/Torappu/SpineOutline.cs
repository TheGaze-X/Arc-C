using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200057A RID: 1402
	[Token(Token = "0x200057A")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class SpineOutline : MonoBehaviour
	{
		// Token: 0x06005BBB RID: 23483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBB")]
		[Address(RVA = "0x1AFC400", Offset = "0x1AFB000", VA = "0x181AFC400")]
		private void _Init()
		{
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBC")]
		[Address(RVA = "0x1AFC3F0", Offset = "0x1AFAFF0", VA = "0x181AFC3F0")]
		private void OnValidate()
		{
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBD")]
		[Address(RVA = "0x1AFC3F0", Offset = "0x1AFAFF0", VA = "0x181AFC3F0")]
		private void Start()
		{
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBE")]
		[Address(RVA = "0x1AFBED0", Offset = "0x1AFAAD0", VA = "0x181AFBED0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBF")]
		[Address(RVA = "0x1AFC630", Offset = "0x1AFB230", VA = "0x181AFC630")]
		public SpineOutline()
		{
		}

		// Token: 0x0400213D RID: 8509
		[Token(Token = "0x400213D")]
		private const string OUTLINE_SHADER_NAME = "Torappu/Spine/Skeleton (Outline)";

		// Token: 0x0400213E RID: 8510
		[Token(Token = "0x400213E")]
		private const float OFFSET_Z = 0.001f;

		// Token: 0x0400213F RID: 8511
		[Token(Token = "0x400213F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Shader _shader;

		// Token: 0x04002140 RID: 8512
		[Token(Token = "0x4002140")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _outlineSize;

		// Token: 0x04002141 RID: 8513
		[Token(Token = "0x4002141")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Color _outlineColor;

		// Token: 0x04002142 RID: 8514
		[Token(Token = "0x4002142")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _useEightWays;

		// Token: 0x04002143 RID: 8515
		[Token(Token = "0x4002143")]
		[FieldOffset(Offset = "0x38")]
		private Material m_material;

		// Token: 0x04002144 RID: 8516
		[Token(Token = "0x4002144")]
		[FieldOffset(Offset = "0x40")]
		private MeshRenderer m_meshRenderer;

		// Token: 0x04002145 RID: 8517
		[Token(Token = "0x4002145")]
		[FieldOffset(Offset = "0x48")]
		private MeshFilter m_meshFilter;
	}
}
