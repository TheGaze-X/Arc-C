using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main11
{
	// Token: 0x02006A2C RID: 27180
	[Token(Token = "0x2006A2C")]
	public class Main11RecordNoteDotItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026D9D RID: 159133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D9D")]
		[Address(RVA = "0x21F2BF0", Offset = "0x21F17F0", VA = "0x1821F2BF0")]
		public void Render(ZoneRecordViewModel viewModel, bool selected)
		{
		}

		// Token: 0x06026D9E RID: 159134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D9E")]
		[Address(RVA = "0x21F2E20", Offset = "0x21F1A20", VA = "0x1821F2E20")]
		private void _InitIfNot(ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026D9F RID: 159135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D9F")]
		[Address(RVA = "0x21F2F90", Offset = "0x21F1B90", VA = "0x1821F2F90")]
		public Main11RecordNoteDotItemView()
		{
		}

		// Token: 0x04036ED3 RID: 224979
		[Token(Token = "0x4036ED3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _stageId;

		// Token: 0x04036ED4 RID: 224980
		[Token(Token = "0x4036ED4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _txtCol;

		// Token: 0x04036ED5 RID: 224981
		[Token(Token = "0x4036ED5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasSelect;

		// Token: 0x04036ED6 RID: 224982
		[Token(Token = "0x4036ED6")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedRecordId;

		// Token: 0x04036ED7 RID: 224983
		[Token(Token = "0x4036ED7")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04036ED8 RID: 224984
		[Token(Token = "0x4036ED8")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_selectTween;

		// Token: 0x04036ED9 RID: 224985
		[Token(Token = "0x4036ED9")]
		private const float ALPHA_DURATION = 0.3f;

		// Token: 0x04036EDA RID: 224986
		[Token(Token = "0x4036EDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036EDB RID: 224987
		[Token(Token = "0x4036EDB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036EDC RID: 224988
		[Token(Token = "0x4036EDC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
