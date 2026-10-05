using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Assist
{
	// Token: 0x02001E05 RID: 7685
	[Token(Token = "0x2001E05")]
	public class AssistReportDailyView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BDC8 RID: 48584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC8")]
		[Address(RVA = "0x339BEE0", Offset = "0x339AAE0", VA = "0x18339BEE0")]
		public void Render(BuildingDailyReport report)
		{
		}

		// Token: 0x0600BDC9 RID: 48585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC9")]
		[Address(RVA = "0x339BE20", Offset = "0x339AA20", VA = "0x18339BE20")]
		public void RenderNull(int index)
		{
		}

		// Token: 0x0600BDCA RID: 48586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCA")]
		[Address(RVA = "0x339C110", Offset = "0x339AD10", VA = "0x18339C110")]
		public AssistReportDailyView()
		{
		}

		// Token: 0x0400BE69 RID: 48745
		[Token(Token = "0x400BE69")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AssistReportManuView _manuView;

		// Token: 0x0400BE6A RID: 48746
		[Token(Token = "0x400BE6A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AssistReportShopView _shopView;

		// Token: 0x0400BE6B RID: 48747
		[Token(Token = "0x400BE6B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AssistReportFavorView _favorView;

		// Token: 0x0400BE6C RID: 48748
		[Token(Token = "0x400BE6C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _timeText;

		// Token: 0x0400BE6D RID: 48749
		[Token(Token = "0x400BE6D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _nullPart;

		// Token: 0x0400BE6E RID: 48750
		[Token(Token = "0x400BE6E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _firstDayNullPart;

		// Token: 0x0400BE6F RID: 48751
		[Token(Token = "0x400BE6F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _reportObjPart;

		// Token: 0x0400BE70 RID: 48752
		[Token(Token = "0x400BE70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400BE71 RID: 48753
		[Token(Token = "0x400BE71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderNull;

		// Token: 0x0400BE72 RID: 48754
		[Token(Token = "0x400BE72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
