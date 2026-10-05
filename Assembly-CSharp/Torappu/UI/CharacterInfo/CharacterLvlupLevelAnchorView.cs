using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F66 RID: 24422
	[Token(Token = "0x2005F66")]
	public class CharacterLvlupLevelAnchorView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060235BD RID: 144829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235BD")]
		[Address(RVA = "0x1E0CB60", Offset = "0x1E0B760", VA = "0x181E0CB60")]
		public void Render(CharacterLvlupViewModel viewModel)
		{
		}

		// Token: 0x060235BE RID: 144830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235BE")]
		[Address(RVA = "0x1E0CAF0", Offset = "0x1E0B6F0", VA = "0x181E0CAF0")]
		public void EventOnAnchorClick()
		{
		}

		// Token: 0x060235BF RID: 144831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235BF")]
		[Address(RVA = "0x1E0CD50", Offset = "0x1E0B950", VA = "0x181E0CD50")]
		public CharacterLvlupLevelAnchorView()
		{
		}

		// Token: 0x04030D13 RID: 199955
		[Token(Token = "0x4030D13")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objTopAnchor;

		// Token: 0x04030D14 RID: 199956
		[Token(Token = "0x4030D14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtTopLevel;

		// Token: 0x04030D15 RID: 199957
		[Token(Token = "0x4030D15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objNormalBottomAnchor;

		// Token: 0x04030D16 RID: 199958
		[Token(Token = "0x4030D16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtNormalBottomLevel;

		// Token: 0x04030D17 RID: 199959
		[Token(Token = "0x4030D17")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objScrollBottomAnchor;

		// Token: 0x04030D18 RID: 199960
		[Token(Token = "0x4030D18")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtScrollBottomLevel;

		// Token: 0x04030D19 RID: 199961
		[Token(Token = "0x4030D19")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action onMoveToMaxValidLevel;

		// Token: 0x04030D1A RID: 199962
		[Token(Token = "0x4030D1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030D1B RID: 199963
		[Token(Token = "0x4030D1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnAnchorClick;

		// Token: 0x04030D1C RID: 199964
		[Token(Token = "0x4030D1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
