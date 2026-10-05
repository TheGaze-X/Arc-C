using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BB1 RID: 15281
	[Token(Token = "0x2003BB1")]
	public class VoicelangCardGridAdapter : LoopScrollAdapter<VoicelangCardGridAdapter.ViewHolder, VoicelangCardViewModel>
	{
		// Token: 0x06017F01 RID: 98049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017F01")]
		[Address(RVA = "0x106A4E0", Offset = "0x10690E0", VA = "0x18106A4E0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06017F02 RID: 98050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F02")]
		[Address(RVA = "0x106A590", Offset = "0x1069190", VA = "0x18106A590", Slot = "13")]
		public override void UpdateView(int position, GameObject view, VoicelangCardGridAdapter.ViewHolder holder, VoicelangCardViewModel data)
		{
		}

		// Token: 0x06017F03 RID: 98051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F03")]
		[Address(RVA = "0x106A730", Offset = "0x1069330", VA = "0x18106A730")]
		public VoicelangCardGridAdapter()
		{
		}

		// Token: 0x0401CF22 RID: 118562
		[Token(Token = "0x401CF22")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UISelectCardEvent m_onClick;

		// Token: 0x0401CF23 RID: 118563
		[Token(Token = "0x401CF23")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _characterPanelPrefab;

		// Token: 0x0401CF24 RID: 118564
		[Token(Token = "0x401CF24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401CF25 RID: 118565
		[Token(Token = "0x401CF25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401CF26 RID: 118566
		[Token(Token = "0x401CF26")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BB2 RID: 15282
		[Token(Token = "0x2003BB2")]
		public struct ViewHolder
		{
			// Token: 0x0401CF27 RID: 118567
			[Token(Token = "0x401CF27")]
			[FieldOffset(Offset = "0x0")]
			public VoicelangCardView panel;
		}
	}
}
