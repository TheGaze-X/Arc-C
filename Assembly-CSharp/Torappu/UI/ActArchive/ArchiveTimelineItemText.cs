using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C32 RID: 27698
	[Token(Token = "0x2006C32")]
	public class ArchiveTimelineItemText : MonoBehaviour, IHotfixable
	{
		// Token: 0x060278A9 RID: 161961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278A9")]
		[Address(RVA = "0x22B7C20", Offset = "0x22B6820", VA = "0x1822B7C20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060278AA RID: 161962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278AA")]
		[Address(RVA = "0x22B7DA0", Offset = "0x22B69A0", VA = "0x1822B7DA0")]
		private void _OnLayoutRebuilt()
		{
		}

		// Token: 0x060278AB RID: 161963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278AB")]
		[Address(RVA = "0x22B79F0", Offset = "0x22B65F0", VA = "0x1822B79F0")]
		public void ApplyData(string text)
		{
		}

		// Token: 0x060278AC RID: 161964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278AC")]
		[Address(RVA = "0x22B7F30", Offset = "0x22B6B30", VA = "0x1822B7F30")]
		public ArchiveTimelineItemText()
		{
		}

		// Token: 0x04038100 RID: 229632
		[Token(Token = "0x4038100")]
		private const int SPACING_LEFT = 6;

		// Token: 0x04038101 RID: 229633
		[Token(Token = "0x4038101")]
		private const int SPACING_RIGHT = 6;

		// Token: 0x04038102 RID: 229634
		[Token(Token = "0x4038102")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _maxWidth;

		// Token: 0x04038103 RID: 229635
		[Token(Token = "0x4038103")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _transformText;

		// Token: 0x04038104 RID: 229636
		[Token(Token = "0x4038104")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _transformBkg;

		// Token: 0x04038105 RID: 229637
		[Token(Token = "0x4038105")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _text;

		// Token: 0x04038106 RID: 229638
		[Token(Token = "0x4038106")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04038107 RID: 229639
		[Token(Token = "0x4038107")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedText;

		// Token: 0x04038108 RID: 229640
		[Token(Token = "0x4038108")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038109 RID: 229641
		[Token(Token = "0x4038109")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnLayoutRebuilt;

		// Token: 0x0403810A RID: 229642
		[Token(Token = "0x403810A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403810B RID: 229643
		[Token(Token = "0x403810B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
