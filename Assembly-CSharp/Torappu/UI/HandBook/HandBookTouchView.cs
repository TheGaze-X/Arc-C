using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066A8 RID: 26280
	[Token(Token = "0x20066A8")]
	public class HandBookTouchView : MonoBehaviour
	{
		// Token: 0x06025BFA RID: 154618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BFA")]
		[Address(RVA = "0x20B2840", Offset = "0x20B1440", VA = "0x1820B2840")]
		private void Start()
		{
		}

		// Token: 0x06025BFB RID: 154619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BFB")]
		[Address(RVA = "0x20B29F0", Offset = "0x20B15F0", VA = "0x1820B29F0")]
		private void _OnScaleChanged(float scale)
		{
		}

		// Token: 0x06025BFC RID: 154620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BFC")]
		[Address(RVA = "0x20B2AC0", Offset = "0x20B16C0", VA = "0x1820B2AC0")]
		private void _OnScaleStart(float scale)
		{
		}

		// Token: 0x06025BFD RID: 154621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BFD")]
		[Address(RVA = "0x20B2A90", Offset = "0x20B1690", VA = "0x1820B2A90")]
		private void _OnScaleEnd(float scale)
		{
		}

		// Token: 0x06025BFE RID: 154622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BFE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookTouchView()
		{
		}

		// Token: 0x040350ED RID: 217325
		[Token(Token = "0x40350ED")]
		[FieldOffset(Offset = "0x18")]
		public HandBookCommonStateBean statebean;

		// Token: 0x040350EE RID: 217326
		[Token(Token = "0x40350EE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UITouchZoom _touchZoom;

		// Token: 0x040350EF RID: 217327
		[Token(Token = "0x40350EF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;
	}
}
