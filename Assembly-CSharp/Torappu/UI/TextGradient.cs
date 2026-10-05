using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x0200347C RID: 13436
	[Token(Token = "0x200347C")]
	[AddComponentMenu("Torappu/UI/Effects/Gradient")]
	public class TextGradient : BaseMeshEffect
	{
		// Token: 0x06015702 RID: 87810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015702")]
		[Address(RVA = "0xDEC860", Offset = "0xDEB460", VA = "0x180DEC860", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		// Token: 0x06015703 RID: 87811 RVA: 0x0008BEF0 File Offset: 0x0008A0F0
		[Token(Token = "0x6015703")]
		[Address(RVA = "0xDECD70", Offset = "0xDEB970", VA = "0x180DECD70")]
		private Color _GetTargetColor(float time)
		{
			return default(Color);
		}

		// Token: 0x06015704 RID: 87812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015704")]
		[Address(RVA = "0xDEC960", Offset = "0xDEB560", VA = "0x180DEC960")]
		private void _ApplyGradient(List<UIVertex> vertexList, int start, int end)
		{
		}

		// Token: 0x06015705 RID: 87813 RVA: 0x0008BF08 File Offset: 0x0008A108
		[Token(Token = "0x6015705")]
		[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
		private bool _UseGradient()
		{
			return default(bool);
		}

		// Token: 0x06015706 RID: 87814 RVA: 0x0008BF20 File Offset: 0x0008A120
		[Token(Token = "0x6015706")]
		[Address(RVA = "0xDECE40", Offset = "0xDEBA40", VA = "0x180DECE40")]
		private bool _UseColor()
		{
			return default(bool);
		}

		// Token: 0x06015707 RID: 87815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015707")]
		[Address(RVA = "0xDECE50", Offset = "0xDEBA50", VA = "0x180DECE50")]
		public TextGradient()
		{
		}

		// Token: 0x04019AAE RID: 105134
		[Token(Token = "0x4019AAE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _useGradient;

		// Token: 0x04019AAF RID: 105135
		[Token(Token = "0x4019AAF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Inspect("_UseColor")]
		private Color32 rightColor;

		// Token: 0x04019AB0 RID: 105136
		[Token(Token = "0x4019AB0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inspect("_UseColor")]
		private Color32 leftColor;

		// Token: 0x04019AB1 RID: 105137
		[Token(Token = "0x4019AB1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Inspect("_UseGradient")]
		private Gradient _gradient;

		// Token: 0x04019AB2 RID: 105138
		[Token(Token = "0x4019AB2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float delta;
	}
}
