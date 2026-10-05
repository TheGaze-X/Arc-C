using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003853 RID: 14419
	[Token(Token = "0x2003853")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(CanvasRenderer))]
	public class UIMeshImage : MaskableGraphic
	{
		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x06016D76 RID: 93558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003699")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6016D76")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016D77 RID: 93559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D77")]
		[Address(RVA = "0xF427A0", Offset = "0xF413A0", VA = "0x180F427A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06016D78 RID: 93560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D78")]
		[Address(RVA = "0xF427C0", Offset = "0xF413C0", VA = "0x180F427C0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06016D79 RID: 93561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D79")]
		[Address(RVA = "0xF42EA0", Offset = "0xF41AA0", VA = "0x180F42EA0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06016D7A RID: 93562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D7A")]
		[Address(RVA = "0xF42EF0", Offset = "0xF41AF0", VA = "0x180F42EF0")]
		public void SetActiveTexture(Texture texture)
		{
		}

		// Token: 0x06016D7B RID: 93563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D7B")]
		[Address(RVA = "0xF42F40", Offset = "0xF41B40", VA = "0x180F42F40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016D7C RID: 93564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D7C")]
		[Address(RVA = "0xF432D0", Offset = "0xF41ED0", VA = "0x180F432D0")]
		private void _SetMeshScale()
		{
		}

		// Token: 0x06016D7D RID: 93565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D7D")]
		[Address(RVA = "0xF43140", Offset = "0xF41D40", VA = "0x180F43140")]
		private void _MatchMeshWithRectTransform()
		{
		}

		// Token: 0x06016D7E RID: 93566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D7E")]
		[Address(RVA = "0xF43470", Offset = "0xF42070", VA = "0x180F43470")]
		public UIMeshImage()
		{
		}

		// Token: 0x0401B8C9 RID: 112841
		[Token(Token = "0x401B8C9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Texture _targetTexture;

		// Token: 0x0401B8CA RID: 112842
		[Token(Token = "0x401B8CA")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Mesh _targetMesh;

		// Token: 0x0401B8CB RID: 112843
		[Token(Token = "0x401B8CB")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Match")]
		private bool _matchRect;

		// Token: 0x0401B8CC RID: 112844
		[Token(Token = "0x401B8CC")]
		[FieldOffset(Offset = "0xF9")]
		[SerializeField]
		[Group("Match")]
		private bool _matchByWidth;

		// Token: 0x0401B8CD RID: 112845
		[Token(Token = "0x401B8CD")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private Vector3 _targetRotation;

		// Token: 0x0401B8CE RID: 112846
		[Token(Token = "0x401B8CE")]
		[FieldOffset(Offset = "0x108")]
		private bool m_inited;

		// Token: 0x0401B8CF RID: 112847
		[Token(Token = "0x401B8CF")]
		[FieldOffset(Offset = "0x10C")]
		private Vector3 m_origMeshScale;

		// Token: 0x0401B8D0 RID: 112848
		[Token(Token = "0x401B8D0")]
		[FieldOffset(Offset = "0x118")]
		private float m_cachedMatch;

		// Token: 0x0401B8D1 RID: 112849
		[Token(Token = "0x401B8D1")]
		[FieldOffset(Offset = "0x11C")]
		private float m_scaleRatio;

		// Token: 0x0401B8D2 RID: 112850
		[Token(Token = "0x401B8D2")]
		[FieldOffset(Offset = "0x120")]
		private Texture m_activeTexture;
	}
}
