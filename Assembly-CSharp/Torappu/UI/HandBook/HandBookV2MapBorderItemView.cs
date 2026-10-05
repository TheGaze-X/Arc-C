using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066F5 RID: 26357
	[Token(Token = "0x20066F5")]
	public class HandBookV2MapBorderItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025D4B RID: 154955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D4B")]
		[Address(RVA = "0x20C3820", Offset = "0x20C2420", VA = "0x1820C3820")]
		public void Render(Dictionary<int, string> pointIdx2ForceIdMap, string forceId, HandBookV2PointData pointData, string color, bool isForceUnlock)
		{
		}

		// Token: 0x06025D4C RID: 154956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D4C")]
		[Address(RVA = "0x20C3B40", Offset = "0x20C2740", VA = "0x1820C3B40")]
		public HandBookV2MapBorderItemView()
		{
		}

		// Token: 0x040352DA RID: 217818
		[Token(Token = "0x40352DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image[] _lineList;

		// Token: 0x040352DB RID: 217819
		[Token(Token = "0x40352DB")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, string> m_pointIdx2ForceIdMap;

		// Token: 0x040352DC RID: 217820
		[Token(Token = "0x40352DC")]
		[FieldOffset(Offset = "0x28")]
		private string m_forceId;

		// Token: 0x040352DD RID: 217821
		[Token(Token = "0x40352DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040352DE RID: 217822
		[Token(Token = "0x40352DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
