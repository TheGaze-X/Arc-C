using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A11 RID: 27153
	[Token(Token = "0x2006A11")]
	public class Main12RecordNoteDotItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026D1F RID: 159007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D1F")]
		[Address(RVA = "0x21D5BB0", Offset = "0x21D47B0", VA = "0x1821D5BB0")]
		public void Render(ZoneRecordViewModel viewModel, bool selected)
		{
		}

		// Token: 0x06026D20 RID: 159008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D20")]
		[Address(RVA = "0x21D5DE0", Offset = "0x21D49E0", VA = "0x1821D5DE0")]
		private void _InitIfNot(ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026D21 RID: 159009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D21")]
		[Address(RVA = "0x21D5F50", Offset = "0x21D4B50", VA = "0x1821D5F50")]
		public Main12RecordNoteDotItemView()
		{
		}

		// Token: 0x04036DB0 RID: 224688
		[Token(Token = "0x4036DB0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _stageId;

		// Token: 0x04036DB1 RID: 224689
		[Token(Token = "0x4036DB1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _txtCol;

		// Token: 0x04036DB2 RID: 224690
		[Token(Token = "0x4036DB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasSelect;

		// Token: 0x04036DB3 RID: 224691
		[Token(Token = "0x4036DB3")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedRecordId;

		// Token: 0x04036DB4 RID: 224692
		[Token(Token = "0x4036DB4")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04036DB5 RID: 224693
		[Token(Token = "0x4036DB5")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_selectTween;

		// Token: 0x04036DB6 RID: 224694
		[Token(Token = "0x4036DB6")]
		private const float ALPHA_DURATION = 0.3f;

		// Token: 0x04036DB7 RID: 224695
		[Token(Token = "0x4036DB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036DB8 RID: 224696
		[Token(Token = "0x4036DB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036DB9 RID: 224697
		[Token(Token = "0x4036DB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
