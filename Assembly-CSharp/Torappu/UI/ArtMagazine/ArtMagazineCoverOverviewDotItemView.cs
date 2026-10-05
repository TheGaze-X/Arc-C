using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006536 RID: 25910
	[Token(Token = "0x2006536")]
	public class ArtMagazineCoverOverviewDotItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060253DD RID: 152541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253DD")]
		[Address(RVA = "0x202F3D0", Offset = "0x202DFD0", VA = "0x18202F3D0")]
		public void Render(bool isCur)
		{
		}

		// Token: 0x060253DE RID: 152542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253DE")]
		[Address(RVA = "0x202F530", Offset = "0x202E130", VA = "0x18202F530")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060253DF RID: 152543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253DF")]
		[Address(RVA = "0x202F620", Offset = "0x202E220", VA = "0x18202F620")]
		public ArtMagazineCoverOverviewDotItemView()
		{
		}

		// Token: 0x040343EC RID: 213996
		[Token(Token = "0x40343EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasCur;

		// Token: 0x040343ED RID: 213997
		[Token(Token = "0x40343ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeDur;

		// Token: 0x040343EE RID: 213998
		[Token(Token = "0x40343EE")]
		[FieldOffset(Offset = "0x24")]
		private bool m_isInited;

		// Token: 0x040343EF RID: 213999
		[Token(Token = "0x40343EF")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_tweenCur;

		// Token: 0x040343F0 RID: 214000
		[Token(Token = "0x40343F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040343F1 RID: 214001
		[Token(Token = "0x40343F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040343F2 RID: 214002
		[Token(Token = "0x40343F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
