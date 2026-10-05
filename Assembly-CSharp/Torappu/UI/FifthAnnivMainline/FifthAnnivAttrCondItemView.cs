using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004E9B RID: 20123
	[Token(Token = "0x2004E9B")]
	public class FifthAnnivAttrCondItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E056 RID: 122966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E056")]
		[Address(RVA = "0x17B23D0", Offset = "0x17B0FD0", VA = "0x1817B23D0")]
		public void Render(int attrIdx, int attrCond, int attrCurr)
		{
		}

		// Token: 0x0601E057 RID: 122967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E057")]
		[Address(RVA = "0x17B25B0", Offset = "0x17B11B0", VA = "0x1817B25B0")]
		public FifthAnnivAttrCondItemView()
		{
		}

		// Token: 0x04027E9E RID: 163486
		[Token(Token = "0x4027E9E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlasIcon;

		// Token: 0x04027E9F RID: 163487
		[Token(Token = "0x4027E9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x04027EA0 RID: 163488
		[Token(Token = "0x4027EA0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textVal;

		// Token: 0x04027EA1 RID: 163489
		[Token(Token = "0x4027EA1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorComplete;

		// Token: 0x04027EA2 RID: 163490
		[Token(Token = "0x4027EA2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorIncomplete;

		// Token: 0x04027EA3 RID: 163491
		[Token(Token = "0x4027EA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027EA4 RID: 163492
		[Token(Token = "0x4027EA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
