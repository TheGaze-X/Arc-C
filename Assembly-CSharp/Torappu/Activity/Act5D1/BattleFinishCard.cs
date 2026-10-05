using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007227 RID: 29223
	[Token(Token = "0x2007227")]
	public class BattleFinishCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x060296B7 RID: 169655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296B7")]
		[Address(RVA = "0x24D3C80", Offset = "0x24D2880", VA = "0x1824D3C80")]
		public void UpdateViewData(CharacterCardViewModel viewModel, bool isAssist)
		{
		}

		// Token: 0x060296B8 RID: 169656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296B8")]
		[Address(RVA = "0x24D3F30", Offset = "0x24D2B30", VA = "0x1824D3F30")]
		public BattleFinishCard()
		{
		}

		// Token: 0x0403B27E RID: 242302
		[Token(Token = "0x403B27E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0403B27F RID: 242303
		[Token(Token = "0x403B27F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageChrIcon;

		// Token: 0x0403B280 RID: 242304
		[Token(Token = "0x403B280")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNoSkill;

		// Token: 0x0403B281 RID: 242305
		[Token(Token = "0x403B281")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _iconSkill;

		// Token: 0x0403B282 RID: 242306
		[Token(Token = "0x403B282")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelPotential;

		// Token: 0x0403B283 RID: 242307
		[Token(Token = "0x403B283")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _iconPotential;

		// Token: 0x0403B284 RID: 242308
		[Token(Token = "0x403B284")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _iconEvolve;

		// Token: 0x0403B285 RID: 242309
		[Token(Token = "0x403B285")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0403B286 RID: 242310
		[Token(Token = "0x403B286")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateViewData;

		// Token: 0x0403B287 RID: 242311
		[Token(Token = "0x403B287")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
