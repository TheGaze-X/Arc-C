using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F72 RID: 24434
	[Token(Token = "0x2005F72")]
	public class CharacterInfoBuildingBuffUnlockNotifyView : UINotifyView<CharacterInfoBuildingBuffUnlockNotifyView.Param>
	{
		// Token: 0x060235E6 RID: 144870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235E6")]
		[Address(RVA = "0x1DFE360", Offset = "0x1DFCF60", VA = "0x181DFE360", Slot = "9")]
		protected override void Render(CharacterInfoBuildingBuffUnlockNotifyView.Param param)
		{
		}

		// Token: 0x060235E7 RID: 144871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235E7")]
		[Address(RVA = "0x1DFE6D0", Offset = "0x1DFD2D0", VA = "0x181DFE6D0")]
		public CharacterInfoBuildingBuffUnlockNotifyView()
		{
		}

		// Token: 0x04030D96 RID: 200086
		[Token(Token = "0x4030D96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04030D97 RID: 200087
		[Token(Token = "0x4030D97")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _buffIcon;

		// Token: 0x04030D98 RID: 200088
		[Token(Token = "0x4030D98")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _buffName;

		// Token: 0x04030D99 RID: 200089
		[Token(Token = "0x4030D99")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _bkg;

		// Token: 0x04030D9A RID: 200090
		[Token(Token = "0x4030D9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030D9B RID: 200091
		[Token(Token = "0x4030D9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F73 RID: 24435
		[Token(Token = "0x2005F73")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060235E8 RID: 144872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235E8")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04030D9C RID: 200092
			[Token(Token = "0x4030D9C")]
			[FieldOffset(Offset = "0x10")]
			public string buffId;
		}
	}
}
