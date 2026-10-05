using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003802 RID: 14338
	[Token(Token = "0x2003802")]
	[RequireComponent(typeof(Image))]
	public class UIImageFastRectMask : BaseMeshEffect
	{
		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x06016B64 RID: 93028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700364D")]
		private Image image
		{
			[Token(Token = "0x6016B64")]
			[Address(RVA = "0xF169A0", Offset = "0xF155A0", VA = "0x180F169A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016B65 RID: 93029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B65")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06016B66 RID: 93030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B66")]
		[Address(RVA = "0xF15E30", Offset = "0xF14A30", VA = "0x180F15E30", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		// Token: 0x06016B67 RID: 93031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B67")]
		[Address(RVA = "0xF16940", Offset = "0xF15540", VA = "0x180F16940", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06016B68 RID: 93032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B68")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIImageFastRectMask()
		{
		}

		// Token: 0x0401B5E5 RID: 112101
		[Token(Token = "0x401B5E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _bestFitRect;

		// Token: 0x0401B5E6 RID: 112102
		[Token(Token = "0x401B5E6")]
		[FieldOffset(Offset = "0x28")]
		private Image m_image;
	}
}
