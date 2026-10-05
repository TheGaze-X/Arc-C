using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200693D RID: 26941
	[Token(Token = "0x200693D")]
	public class StageZoneCrisisV2TempItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602693F RID: 158015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602693F")]
		[Address(RVA = "0x21B8540", Offset = "0x21B7140", VA = "0x1821B8540")]
		public void Render(int index, CrisisV2ZoneEntryModel.Temp viewModel)
		{
		}

		// Token: 0x06026940 RID: 158016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026940")]
		[Address(RVA = "0x21B8730", Offset = "0x21B7330", VA = "0x1821B8730")]
		public StageZoneCrisisV2TempItem()
		{
		}

		// Token: 0x040366B7 RID: 222903
		[Token(Token = "0x40366B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _indexText;

		// Token: 0x040366B8 RID: 222904
		[Token(Token = "0x40366B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _notOpen;

		// Token: 0x040366B9 RID: 222905
		[Token(Token = "0x40366B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _rewardAvail;

		// Token: 0x040366BA RID: 222906
		[Token(Token = "0x40366BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _commonState;

		// Token: 0x040366BB RID: 222907
		[Token(Token = "0x40366BB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _backImg;

		// Token: 0x040366BC RID: 222908
		[Token(Token = "0x40366BC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040366BD RID: 222909
		[Token(Token = "0x40366BD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _coloredObject;

		// Token: 0x040366BE RID: 222910
		[Token(Token = "0x40366BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040366BF RID: 222911
		[Token(Token = "0x40366BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
