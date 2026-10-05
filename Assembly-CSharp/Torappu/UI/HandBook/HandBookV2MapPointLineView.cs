using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200670B RID: 26379
	[Token(Token = "0x200670B")]
	public class HandBookV2MapPointLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025DB6 RID: 155062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DB6")]
		[Address(RVA = "0x20E2770", Offset = "0x20E1370", VA = "0x1820E2770")]
		private void _Render(Vector2 pos1, Vector2 pos2)
		{
		}

		// Token: 0x06025DB7 RID: 155063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DB7")]
		[Address(RVA = "0x20E2420", Offset = "0x20E1020", VA = "0x1820E2420")]
		public void Render(HandBookV2PointLineViewModel lineModel)
		{
		}

		// Token: 0x06025DB8 RID: 155064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DB8")]
		[Address(RVA = "0x20E2980", Offset = "0x20E1580", VA = "0x1820E2980")]
		public HandBookV2MapPointLineView()
		{
		}

		// Token: 0x040353B6 RID: 218038
		[Token(Token = "0x40353B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgLine;

		// Token: 0x040353B7 RID: 218039
		[Token(Token = "0x40353B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040353B8 RID: 218040
		[Token(Token = "0x40353B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040353B9 RID: 218041
		[Token(Token = "0x40353B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
