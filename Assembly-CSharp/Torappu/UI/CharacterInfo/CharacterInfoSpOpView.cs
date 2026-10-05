using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F36 RID: 24374
	[Token(Token = "0x2005F36")]
	public class CharacterInfoSpOpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060234C3 RID: 144579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234C3")]
		[Address(RVA = "0x1DDC1C0", Offset = "0x1DDADC0", VA = "0x181DDC1C0")]
		public void Render(SpecialOperatorInfoViewModel model)
		{
		}

		// Token: 0x060234C4 RID: 144580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234C4")]
		[Address(RVA = "0x1DDC410", Offset = "0x1DDB010", VA = "0x181DDC410")]
		public CharacterInfoSpOpView()
		{
		}

		// Token: 0x04030AF0 RID: 199408
		[Token(Token = "0x4030AF0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _normalEvolveGos;

		// Token: 0x04030AF1 RID: 199409
		[Token(Token = "0x4030AF1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _spOpEvolvePanel;

		// Token: 0x04030AF2 RID: 199410
		[Token(Token = "0x4030AF2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgTargetTypeIcon;

		// Token: 0x04030AF3 RID: 199411
		[Token(Token = "0x4030AF3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _noticeText;

		// Token: 0x04030AF4 RID: 199412
		[Token(Token = "0x4030AF4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _btnText;

		// Token: 0x04030AF5 RID: 199413
		[Token(Token = "0x4030AF5")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedTypeIcon;

		// Token: 0x04030AF6 RID: 199414
		[Token(Token = "0x4030AF6")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04030AF7 RID: 199415
		[Token(Token = "0x4030AF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030AF8 RID: 199416
		[Token(Token = "0x4030AF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
