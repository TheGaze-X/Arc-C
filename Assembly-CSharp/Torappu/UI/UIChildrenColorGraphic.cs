using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020037E0 RID: 14304
	[Token(Token = "0x20037E0")]
	public class UIChildrenColorGraphic : MonoBehaviour
	{
		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x06016AD7 RID: 92887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700363E")]
		private Graphic[] allGraphics
		{
			[Token(Token = "0x6016AD7")]
			[Address(RVA = "0xF0FEC0", Offset = "0xF0EAC0", VA = "0x180F0FEC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016AD8 RID: 92888 RVA: 0x00092640 File Offset: 0x00090840
		[Token(Token = "0x6016AD8")]
		[Address(RVA = "0xF0FE70", Offset = "0xF0EA70", VA = "0x180F0FE70")]
		private bool _IsExcept(Graphic graphic)
		{
			return default(bool);
		}

		// Token: 0x06016AD9 RID: 92889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AD9")]
		[Address(RVA = "0xC96C40", Offset = "0xC95840", VA = "0x180C96C40")]
		public void ForceRefreshChildren()
		{
		}

		// Token: 0x06016ADA RID: 92890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ADA")]
		[Address(RVA = "0xF0FC80", Offset = "0xF0E880", VA = "0x180F0FC80")]
		public void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		// Token: 0x06016ADB RID: 92891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ADB")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIChildrenColorGraphic()
		{
		}

		// Token: 0x0401B554 RID: 111956
		[Token(Token = "0x401B554")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Graphic[] _exceptGraphics;

		// Token: 0x0401B555 RID: 111957
		[Token(Token = "0x401B555")]
		[FieldOffset(Offset = "0x20")]
		[Inspect]
		[ReadOnly]
		private Graphic[] m_allGraphics;
	}
}
