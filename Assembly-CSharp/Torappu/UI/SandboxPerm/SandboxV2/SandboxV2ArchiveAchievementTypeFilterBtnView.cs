using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004106 RID: 16646
	[Token(Token = "0x2004106")]
	public class SandboxV2ArchiveAchievementTypeFilterBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019BDA RID: 105434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BDA")]
		[Address(RVA = "0x1294490", Offset = "0x1293090", VA = "0x181294490")]
		public void Render(SandboxV2ArchiveAchievementTypeFilterBtnView.Params param)
		{
		}

		// Token: 0x06019BDB RID: 105435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BDB")]
		[Address(RVA = "0x1294420", Offset = "0x1293020", VA = "0x181294420")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06019BDC RID: 105436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BDC")]
		[Address(RVA = "0x1294600", Offset = "0x1293200", VA = "0x181294600")]
		public SandboxV2ArchiveAchievementTypeFilterBtnView()
		{
		}

		// Token: 0x040203F1 RID: 132081
		[Token(Token = "0x40203F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateFadeSwitcher _toggle;

		// Token: 0x040203F2 RID: 132082
		[Token(Token = "0x40203F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textNameSelected;

		// Token: 0x040203F3 RID: 132083
		[Token(Token = "0x40203F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textNameNotSelected;

		// Token: 0x040203F4 RID: 132084
		[Token(Token = "0x40203F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _line;

		// Token: 0x040203F5 RID: 132085
		[Token(Token = "0x40203F5")]
		[FieldOffset(Offset = "0x38")]
		private string m_type;

		// Token: 0x040203F6 RID: 132086
		[Token(Token = "0x40203F6")]
		[FieldOffset(Offset = "0x40")]
		private Action<string> m_OnClick;

		// Token: 0x040203F7 RID: 132087
		[Token(Token = "0x40203F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040203F8 RID: 132088
		[Token(Token = "0x40203F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x040203F9 RID: 132089
		[Token(Token = "0x40203F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004107 RID: 16647
		[Token(Token = "0x2004107")]
		public struct Params
		{
			// Token: 0x040203FA RID: 132090
			[Token(Token = "0x40203FA")]
			[FieldOffset(Offset = "0x0")]
			public string btnType;

			// Token: 0x040203FB RID: 132091
			[Token(Token = "0x40203FB")]
			[FieldOffset(Offset = "0x8")]
			public string name;

			// Token: 0x040203FC RID: 132092
			[Token(Token = "0x40203FC")]
			[FieldOffset(Offset = "0x10")]
			public bool showLine;

			// Token: 0x040203FD RID: 132093
			[Token(Token = "0x40203FD")]
			[FieldOffset(Offset = "0x11")]
			public bool isSelected;

			// Token: 0x040203FE RID: 132094
			[Token(Token = "0x40203FE")]
			[FieldOffset(Offset = "0x18")]
			public Action<string> onChangeType;
		}
	}
}
