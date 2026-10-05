using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004E9C RID: 20124
	[Token(Token = "0x2004E9C")]
	public class FifthAnnivAttrDeltaItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E058 RID: 122968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E058")]
		[Address(RVA = "0x17B2610", Offset = "0x17B1210", VA = "0x1817B2610")]
		public void Render(int attrIdx, int attrVal)
		{
		}

		// Token: 0x0601E059 RID: 122969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E059")]
		[Address(RVA = "0x17B2830", Offset = "0x17B1430", VA = "0x1817B2830")]
		public FifthAnnivAttrDeltaItemView()
		{
		}

		// Token: 0x04027EA5 RID: 163493
		[Token(Token = "0x4027EA5")]
		private const string POSITIVE_NUM_STR = "+{0}";

		// Token: 0x04027EA6 RID: 163494
		[Token(Token = "0x4027EA6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlasIcon;

		// Token: 0x04027EA7 RID: 163495
		[Token(Token = "0x4027EA7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x04027EA8 RID: 163496
		[Token(Token = "0x4027EA8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textVal;

		// Token: 0x04027EA9 RID: 163497
		[Token(Token = "0x4027EA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorReduce;

		// Token: 0x04027EAA RID: 163498
		[Token(Token = "0x4027EAA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorAdd;

		// Token: 0x04027EAB RID: 163499
		[Token(Token = "0x4027EAB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027EAC RID: 163500
		[Token(Token = "0x4027EAC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
