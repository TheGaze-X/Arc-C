using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040DA RID: 16602
	[Token(Token = "0x20040DA")]
	public class SandboxV2AdminMainScienceTypeSelectView : DataBinder<SandboxV2AdminMainSciencePanelModelProperty>
	{
		// Token: 0x06019AE0 RID: 105184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AE0")]
		[Address(RVA = "0x1281000", Offset = "0x127FC00", VA = "0x181281000")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019AE1 RID: 105185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AE1")]
		[Address(RVA = "0x1280D30", Offset = "0x127F930", VA = "0x181280D30")]
		private void _InitDataIfNot(SandboxV2AdminMainSciencePanelModel viewModel)
		{
		}

		// Token: 0x06019AE2 RID: 105186 RVA: 0x0009F108 File Offset: 0x0009D308
		[Token(Token = "0x6019AE2")]
		[Address(RVA = "0x1280CA0", Offset = "0x127F8A0", VA = "0x181280CA0")]
		private bool _GenTypeLockStatus(SandboxV2AdminMainScienceType type, SandboxV2AdminMainSciencePanelModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06019AE3 RID: 105187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AE3")]
		[Address(RVA = "0x1280B40", Offset = "0x127F740", VA = "0x181280B40")]
		private void _EventSelectChanged(int idx)
		{
		}

		// Token: 0x06019AE4 RID: 105188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AE4")]
		[Address(RVA = "0x1281440", Offset = "0x1280040", VA = "0x181281440")]
		private void _RefreshTitle(SandboxV2AdminMainSciencePanelModel viewModel)
		{
		}

		// Token: 0x06019AE5 RID: 105189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AE5")]
		[Address(RVA = "0x1281300", Offset = "0x127FF00", VA = "0x181281300")]
		private void _RefreshSelectorProgress(SandboxV2AdminMainSciencePanelModel viewModel)
		{
		}

		// Token: 0x06019AE6 RID: 105190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AE6")]
		[Address(RVA = "0x1280820", Offset = "0x127F420", VA = "0x181280820", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainSciencePanelModelProperty property)
		{
		}

		// Token: 0x06019AE7 RID: 105191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AE7")]
		[Address(RVA = "0x1281220", Offset = "0x127FE20", VA = "0x181281220")]
		public void _OnTypeSelectChanged(SandboxV2AdminMainScienceType selectType)
		{
		}

		// Token: 0x06019AE8 RID: 105192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AE8")]
		[Address(RVA = "0x12815C0", Offset = "0x12801C0", VA = "0x1812815C0")]
		public SandboxV2AdminMainScienceTypeSelectView()
		{
		}

		// Token: 0x040201CF RID: 131535
		[Token(Token = "0x40201CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2AdminMainScienceTypeSelector _selectorPrefab;

		// Token: 0x040201D0 RID: 131536
		[Token(Token = "0x40201D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2ScienceTypeDefine[] _typeDefine;

		// Token: 0x040201D1 RID: 131537
		[Token(Token = "0x40201D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _scienceTitle;

		// Token: 0x040201D2 RID: 131538
		[Token(Token = "0x40201D2")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2AdminMainSciencePanelModelProperty m_cachedProp;

		// Token: 0x040201D3 RID: 131539
		[Token(Token = "0x40201D3")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2AdminMainScienceTypeSelector m_selector;

		// Token: 0x040201D4 RID: 131540
		[Token(Token = "0x40201D4")]
		[FieldOffset(Offset = "0x48")]
		private List<SandboxV2AdminMainScienceTypeItemData> m_itemDatas;

		// Token: 0x040201D5 RID: 131541
		[Token(Token = "0x40201D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040201D6 RID: 131542
		[Token(Token = "0x40201D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitDataIfNot;

		// Token: 0x040201D7 RID: 131543
		[Token(Token = "0x40201D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenTypeLockStatus;

		// Token: 0x040201D8 RID: 131544
		[Token(Token = "0x40201D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventSelectChanged;

		// Token: 0x040201D9 RID: 131545
		[Token(Token = "0x40201D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshTitle;

		// Token: 0x040201DA RID: 131546
		[Token(Token = "0x40201DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshSelectorProgress;

		// Token: 0x040201DB RID: 131547
		[Token(Token = "0x40201DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040201DC RID: 131548
		[Token(Token = "0x40201DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnTypeSelectChanged;

		// Token: 0x040201DD RID: 131549
		[Token(Token = "0x40201DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
