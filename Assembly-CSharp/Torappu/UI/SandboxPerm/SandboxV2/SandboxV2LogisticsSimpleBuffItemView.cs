using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200433E RID: 17214
	[Token(Token = "0x200433E")]
	public class SandboxV2LogisticsSimpleBuffItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A70D RID: 108301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A70D")]
		[Address(RVA = "0x138BED0", Offset = "0x138AAD0", VA = "0x18138BED0")]
		public void Render(SandboxV2LogisticsBuffViewModel buffViewModel)
		{
		}

		// Token: 0x0601A70E RID: 108302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A70E")]
		[Address(RVA = "0x138C160", Offset = "0x138AD60", VA = "0x18138C160")]
		public SandboxV2LogisticsSimpleBuffItemView()
		{
		}

		// Token: 0x040219A6 RID: 137638
		[Token(Token = "0x40219A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x040219A7 RID: 137639
		[Token(Token = "0x40219A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Graphic _graphicBg;

		// Token: 0x040219A8 RID: 137640
		[Token(Token = "0x40219A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtBuff;

		// Token: 0x040219A9 RID: 137641
		[Token(Token = "0x40219A9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorBgNormal;

		// Token: 0x040219AA RID: 137642
		[Token(Token = "0x40219AA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorBgFull;

		// Token: 0x040219AB RID: 137643
		[Token(Token = "0x40219AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorIconNormal;

		// Token: 0x040219AC RID: 137644
		[Token(Token = "0x40219AC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorIconFull;

		// Token: 0x040219AD RID: 137645
		[Token(Token = "0x40219AD")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040219AE RID: 137646
		[Token(Token = "0x40219AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040219AF RID: 137647
		[Token(Token = "0x40219AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
