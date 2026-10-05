using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu.UI
{
	// Token: 0x020038CB RID: 14539
	[Token(Token = "0x20038CB")]
	[RequireComponent(typeof(RectTransform))]
	public class UIBackgroundLayout : UIBehaviour
	{
		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x06016FEB RID: 94187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170036E3")]
		public RectTransform rectTrans
		{
			[Token(Token = "0x6016FEB")]
			[Address(RVA = "0xF75800", Offset = "0xF74400", VA = "0x180F75800")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016FEC RID: 94188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FEC")]
		[Address(RVA = "0xF755A0", Offset = "0xF741A0", VA = "0x180F755A0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x06016FED RID: 94189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FED")]
		[Address(RVA = "0xF755A0", Offset = "0xF741A0", VA = "0x180F755A0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06016FEE RID: 94190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FEE")]
		[Address(RVA = "0xF755A0", Offset = "0xF741A0", VA = "0x180F755A0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06016FEF RID: 94191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FEF")]
		[Address(RVA = "0xF755C0", Offset = "0xF741C0", VA = "0x180F755C0")]
		private void _UpdateRectTransform()
		{
		}

		// Token: 0x06016FF0 RID: 94192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FF0")]
		[Address(RVA = "0xF757E0", Offset = "0xF743E0", VA = "0x180F757E0")]
		public UIBackgroundLayout()
		{
		}

		// Token: 0x0401BC20 RID: 113696
		[Token(Token = "0x401BC20")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _ratio;

		// Token: 0x0401BC21 RID: 113697
		[Token(Token = "0x401BC21")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_rectTrans;

		// Token: 0x0401BC22 RID: 113698
		[Token(Token = "0x401BC22")]
		[FieldOffset(Offset = "0x28")]
		private float m_curRatio;
	}
}
