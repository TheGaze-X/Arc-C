using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001975 RID: 6517
	[Token(Token = "0x2001975")]
	public class DIYComfortDetailLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A3A6 RID: 41894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3A6")]
		[Address(RVA = "0x31D7360", Offset = "0x31D5F60", VA = "0x1831D7360")]
		private void Awake()
		{
		}

		// Token: 0x0600A3A7 RID: 41895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3A7")]
		[Address(RVA = "0x31D7400", Offset = "0x31D6000", VA = "0x1831D7400")]
		public void Setup(DIYComfortDetailView.DIYComfortDetailLine line)
		{
		}

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3A8")]
		[Address(RVA = "0x31D75F0", Offset = "0x31D61F0", VA = "0x1831D75F0")]
		public DIYComfortDetailLineView()
		{
		}

		// Token: 0x04009A3F RID: 39487
		[Token(Token = "0x4009A3F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _label0;

		// Token: 0x04009A40 RID: 39488
		[Token(Token = "0x4009A40")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _label1;

		// Token: 0x04009A41 RID: 39489
		[Token(Token = "0x4009A41")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _label2;

		// Token: 0x04009A42 RID: 39490
		[Token(Token = "0x4009A42")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _highlight;

		// Token: 0x04009A43 RID: 39491
		[Token(Token = "0x4009A43")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _highlightColor;

		// Token: 0x04009A44 RID: 39492
		[Token(Token = "0x4009A44")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _normalColor;

		// Token: 0x04009A45 RID: 39493
		[Token(Token = "0x4009A45")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _label2ZeroColor;

		// Token: 0x04009A46 RID: 39494
		[Token(Token = "0x4009A46")]
		[FieldOffset(Offset = "0x68")]
		private Color m_label2OriginColor;

		// Token: 0x04009A47 RID: 39495
		[Token(Token = "0x4009A47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04009A48 RID: 39496
		[Token(Token = "0x4009A48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009A49 RID: 39497
		[Token(Token = "0x4009A49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
