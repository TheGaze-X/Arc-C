using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004746 RID: 18246
	[Token(Token = "0x2004746")]
	public class RecruitRateUp6DetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA36 RID: 113206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA36")]
		[Address(RVA = "0x15041D0", Offset = "0x1502DD0", VA = "0x1815041D0")]
		public void Render(GachaDetailData.GachaObject obj, bool hasRateUp)
		{
		}

		// Token: 0x0601BA37 RID: 113207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA37")]
		[Address(RVA = "0x1504340", Offset = "0x1502F40", VA = "0x181504340")]
		public RecruitRateUp6DetailView()
		{
		}

		// Token: 0x04023DA5 RID: 146853
		[Token(Token = "0x4023DA5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x04023DA6 RID: 146854
		[Token(Token = "0x4023DA6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _normalHeight;

		// Token: 0x04023DA7 RID: 146855
		[Token(Token = "0x4023DA7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _descGO;

		// Token: 0x04023DA8 RID: 146856
		[Token(Token = "0x4023DA8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04023DA9 RID: 146857
		[Token(Token = "0x4023DA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023DAA RID: 146858
		[Token(Token = "0x4023DAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
