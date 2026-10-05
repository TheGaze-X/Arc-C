using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066F6 RID: 26358
	[Token(Token = "0x20066F6")]
	public class HandBookV2MapBorderView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025D4D RID: 154957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D4D")]
		[Address(RVA = "0x20C3BA0", Offset = "0x20C27A0", VA = "0x1820C3BA0")]
		public void Render(HandBookV2ForceViewModel viewModel, Dictionary<int, string> pointIndex2ForceIdMap)
		{
		}

		// Token: 0x06025D4E RID: 154958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D4E")]
		[Address(RVA = "0x20C3E90", Offset = "0x20C2A90", VA = "0x1820C3E90")]
		private void _RenderBorders(HandBookV2PointData pointData, bool isForceUnlock)
		{
		}

		// Token: 0x06025D4F RID: 154959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D4F")]
		[Address(RVA = "0x20C4050", Offset = "0x20C2C50", VA = "0x1820C4050")]
		public HandBookV2MapBorderView()
		{
		}

		// Token: 0x040352DF RID: 217823
		[Token(Token = "0x40352DF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2MapBorderItemView _itemTemplate;

		// Token: 0x040352E0 RID: 217824
		[Token(Token = "0x40352E0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x040352E1 RID: 217825
		[Token(Token = "0x40352E1")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, HandBookV2MapBorderItemView> m_pointIdx2BorderItemMap;

		// Token: 0x040352E2 RID: 217826
		[Token(Token = "0x40352E2")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, string> m_pointIdx2ForceIdMap;

		// Token: 0x040352E3 RID: 217827
		[Token(Token = "0x40352E3")]
		[FieldOffset(Offset = "0x38")]
		private HandBookV2ForceViewModel m_forceViewModel;

		// Token: 0x040352E4 RID: 217828
		[Token(Token = "0x40352E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040352E5 RID: 217829
		[Token(Token = "0x40352E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderBorders;

		// Token: 0x040352E6 RID: 217830
		[Token(Token = "0x40352E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
