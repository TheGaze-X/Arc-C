using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F78 RID: 24440
	[Token(Token = "0x2005F78")]
	public class CharacterInfoPotentialFavorNotifyView : UINotifyView<CharacterInfoPotentialFavorNotifyView.Param>
	{
		// Token: 0x060235EF RID: 144879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235EF")]
		[Address(RVA = "0x1E00020", Offset = "0x1DFEC20", VA = "0x181E00020", Slot = "9")]
		protected override void Render(CharacterInfoPotentialFavorNotifyView.Param param)
		{
		}

		// Token: 0x060235F0 RID: 144880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235F0")]
		[Address(RVA = "0x1E000F0", Offset = "0x1DFECF0", VA = "0x181E000F0")]
		public CharacterInfoPotentialFavorNotifyView()
		{
		}

		// Token: 0x04030DA9 RID: 200105
		[Token(Token = "0x4030DA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtToast;

		// Token: 0x04030DAA RID: 200106
		[Token(Token = "0x4030DAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030DAB RID: 200107
		[Token(Token = "0x4030DAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F79 RID: 24441
		[Token(Token = "0x2005F79")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060235F1 RID: 144881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235F1")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04030DAC RID: 200108
			[Token(Token = "0x4030DAC")]
			[FieldOffset(Offset = "0x10")]
			public string toastStr;
		}
	}
}
