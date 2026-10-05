using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D8D RID: 15757
	[Token(Token = "0x2003D8D")]
	public class TemplateMissionCommonRewardActivityItemView : AbstractTemplateMissionRewardItemView
	{
		// Token: 0x06018830 RID: 100400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018830")]
		[Address(RVA = "0x110EE40", Offset = "0x110DA40", VA = "0x18110EE40", Slot = "4")]
		public override void Render(AbstractTemplateMissionRewardItemViewModel viewModel)
		{
		}

		// Token: 0x06018831 RID: 100401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018831")]
		[Address(RVA = "0x110F120", Offset = "0x110DD20", VA = "0x18110F120")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018832 RID: 100402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018832")]
		[Address(RVA = "0x110F2E0", Offset = "0x110DEE0", VA = "0x18110F2E0")]
		public TemplateMissionCommonRewardActivityItemView()
		{
		}

		// Token: 0x0401E0AE RID: 123054
		[Token(Token = "0x401E0AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCont;

		// Token: 0x0401E0AF RID: 123055
		[Token(Token = "0x401E0AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public TemplateActivityCommonItemView _prefab;

		// Token: 0x0401E0B0 RID: 123056
		[Token(Token = "0x401E0B0")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401E0B1 RID: 123057
		[Token(Token = "0x401E0B1")]
		[FieldOffset(Offset = "0x38")]
		private TemplateActivityCommonItemView m_view;

		// Token: 0x0401E0B2 RID: 123058
		[Token(Token = "0x401E0B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E0B3 RID: 123059
		[Token(Token = "0x401E0B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E0B4 RID: 123060
		[Token(Token = "0x401E0B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
