using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066AE RID: 26286
	[Token(Token = "0x20066AE")]
	[RequireComponent(typeof(Animator))]
	public abstract class HandBookCommonLineRender : MonoBehaviour
	{
		// Token: 0x1700596E RID: 22894
		// (get) Token: 0x06025C10 RID: 154640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700596E")]
		public Transform startPoint
		{
			[Token(Token = "0x6025C10")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700596F RID: 22895
		// (get) Token: 0x06025C11 RID: 154641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700596F")]
		public Transform endPoint
		{
			[Token(Token = "0x6025C11")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025C12 RID: 154642
		[Token(Token = "0x6025C12")]
		public abstract void Render(bool renderFlag = true, float zoomValue = 0f, bool quickAnim = false);

		// Token: 0x06025C13 RID: 154643
		[Token(Token = "0x6025C13")]
		public abstract void InitLine(Transform startPos, Transform endPos, HandBookLineViewModel viewModel);

		// Token: 0x06025C14 RID: 154644
		[Token(Token = "0x6025C14")]
		public abstract void OnValueChanged(HandBookScrollViewProperty property);

		// Token: 0x06025C15 RID: 154645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C15")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected HandBookCommonLineRender()
		{
		}

		// Token: 0x0403511F RID: 217375
		[Token(Token = "0x403511F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Animator animator;

		// Token: 0x04035120 RID: 217376
		[Token(Token = "0x4035120")]
		[FieldOffset(Offset = "0x20")]
		protected Transform m_startPoint;

		// Token: 0x04035121 RID: 217377
		[Token(Token = "0x4035121")]
		[FieldOffset(Offset = "0x28")]
		protected Transform m_endPoint;

		// Token: 0x04035122 RID: 217378
		[Token(Token = "0x4035122")]
		[FieldOffset(Offset = "0x30")]
		public HandBookLineViewModel viewModel;
	}
}
