using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066AF RID: 26287
	[Token(Token = "0x20066AF")]
	[RequireComponent(typeof(LineRenderer))]
	public class HandBookNormalLine : HandBookCommonLineRender
	{
		// Token: 0x06025C16 RID: 154646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C16")]
		[Address(RVA = "0x20AE670", Offset = "0x20AD270", VA = "0x1820AE670", Slot = "5")]
		public override void InitLine(Transform startPos, Transform endPos, HandBookLineViewModel viewModel)
		{
		}

		// Token: 0x06025C17 RID: 154647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C17")]
		[Address(RVA = "0x20AE720", Offset = "0x20AD320", VA = "0x1820AE720", Slot = "6")]
		public override void OnValueChanged(HandBookScrollViewProperty property)
		{
		}

		// Token: 0x06025C18 RID: 154648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C18")]
		[Address(RVA = "0x20AE7C0", Offset = "0x20AD3C0", VA = "0x1820AE7C0", Slot = "4")]
		public override void Render(bool renderFlag = true, float zoomValue = 0f, bool quickAnim = false)
		{
		}

		// Token: 0x06025C19 RID: 154649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C19")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookNormalLine()
		{
		}

		// Token: 0x04035123 RID: 217379
		[Token(Token = "0x4035123")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LineRenderer _lineRender;
	}
}
