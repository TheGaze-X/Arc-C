using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003856 RID: 14422
	[Token(Token = "0x2003856")]
	[RequireComponent(typeof(RectTransform))]
	public class UIRadarMap : MaskableGraphic, IHotfixable
	{
		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x06016D90 RID: 93584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700369B")]
		private RectTransform rect
		{
			[Token(Token = "0x6016D90")]
			[Address(RVA = "0xF4C110", Offset = "0xF4AD10", VA = "0x180F4C110")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016D91 RID: 93585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D91")]
		[Address(RVA = "0xF4BF90", Offset = "0xF4AB90", VA = "0x180F4BF90")]
		public void Render(int vertexCount, IList<float> length, bool isClockwise = false)
		{
		}

		// Token: 0x06016D92 RID: 93586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D92")]
		[Address(RVA = "0xF4B9F0", Offset = "0xF4A5F0", VA = "0x180F4B9F0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06016D93 RID: 93587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D93")]
		[Address(RVA = "0xF4C0A0", Offset = "0xF4ACA0", VA = "0x180F4C0A0")]
		public UIRadarMap()
		{
		}

		// Token: 0x06016D94 RID: 93588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D94")]
		[Address(RVA = "0xDEFAD0", Offset = "0xDEE6D0", VA = "0x180DEFAD0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x0401B8DA RID: 112858
		[Token(Token = "0x401B8DA")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private int _vertexCount;

		// Token: 0x0401B8DB RID: 112859
		[Token(Token = "0x401B8DB")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Tooltip("Use normalized length from 0 to 1.\n1 means min of rect transform width and height.")]
		private float[] _edgeLength;

		// Token: 0x0401B8DC RID: 112860
		[Token(Token = "0x401B8DC")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private int _startDegree;

		// Token: 0x0401B8DD RID: 112861
		[Token(Token = "0x401B8DD")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private bool _isClockwise;

		// Token: 0x0401B8DE RID: 112862
		[Token(Token = "0x401B8DE")]
		[FieldOffset(Offset = "0x100")]
		private RectTransform m_rect;

		// Token: 0x0401B8DF RID: 112863
		[Token(Token = "0x401B8DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rect;

		// Token: 0x0401B8E0 RID: 112864
		[Token(Token = "0x401B8E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401B8E1 RID: 112865
		[Token(Token = "0x401B8E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x0401B8E2 RID: 112866
		[Token(Token = "0x401B8E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
