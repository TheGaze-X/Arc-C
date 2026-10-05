using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066FC RID: 26364
	[Token(Token = "0x20066FC")]
	public class HandBookV2MapForceLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025D6E RID: 154990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D6E")]
		[Address(RVA = "0x20C5D90", Offset = "0x20C4990", VA = "0x1820C5D90")]
		private void _Render(Vector2 pos1, Vector2 pos2)
		{
		}

		// Token: 0x06025D6F RID: 154991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D6F")]
		[Address(RVA = "0x20C5CF0", Offset = "0x20C48F0", VA = "0x1820C5CF0")]
		public void Render(HandBookV2ForceLineViewModel lineModel)
		{
		}

		// Token: 0x06025D70 RID: 154992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D70")]
		[Address(RVA = "0x20C5FC0", Offset = "0x20C4BC0", VA = "0x1820C5FC0")]
		public HandBookV2MapForceLineView()
		{
		}

		// Token: 0x04035327 RID: 217895
		[Token(Token = "0x4035327")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04035328 RID: 217896
		[Token(Token = "0x4035328")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035329 RID: 217897
		[Token(Token = "0x4035329")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
