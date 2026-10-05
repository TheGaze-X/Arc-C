using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066FD RID: 26365
	[Token(Token = "0x20066FD")]
	public class HandBookV2MapForceShadowView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025D71 RID: 154993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D71")]
		[Address(RVA = "0x20C62D0", Offset = "0x20C4ED0", VA = "0x1820C62D0")]
		private void _RenderDot(HandBookV2PointData pointData)
		{
		}

		// Token: 0x06025D72 RID: 154994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D72")]
		[Address(RVA = "0x20C6020", Offset = "0x20C4C20", VA = "0x1820C6020")]
		public void Render(HandBookV2ForceViewModel viewModel)
		{
		}

		// Token: 0x06025D73 RID: 154995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D73")]
		[Address(RVA = "0x20C6490", Offset = "0x20C5090", VA = "0x1820C6490")]
		public HandBookV2MapForceShadowView()
		{
		}

		// Token: 0x0403532A RID: 217898
		[Token(Token = "0x403532A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _shadowColor;

		// Token: 0x0403532B RID: 217899
		[Token(Token = "0x403532B")]
		[FieldOffset(Offset = "0x28")]
		private readonly Vector2 SHADOW_OFFSET;

		// Token: 0x0403532C RID: 217900
		[Token(Token = "0x403532C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HandBookV2AlphaHexagonView _shadowTemplate;

		// Token: 0x0403532D RID: 217901
		[Token(Token = "0x403532D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403532E RID: 217902
		[Token(Token = "0x403532E")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, HandBookV2AlphaHexagonView> m_pointIndex2ShadowGoMap;

		// Token: 0x0403532F RID: 217903
		[Token(Token = "0x403532F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RenderDot;

		// Token: 0x04035330 RID: 217904
		[Token(Token = "0x4035330")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035331 RID: 217905
		[Token(Token = "0x4035331")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
