using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F7A RID: 24442
	[Token(Token = "0x2005F7A")]
	public class CharacterInfoPotentialNotifyView : UINotifyView<CharacterInfoPotentialNotifyView.Param>
	{
		// Token: 0x060235F2 RID: 144882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235F2")]
		[Address(RVA = "0x1E01A80", Offset = "0x1E00680", VA = "0x181E01A80", Slot = "9")]
		protected override void Render(CharacterInfoPotentialNotifyView.Param param)
		{
		}

		// Token: 0x060235F3 RID: 144883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235F3")]
		[Address(RVA = "0x1E01B30", Offset = "0x1E00730", VA = "0x181E01B30")]
		public CharacterInfoPotentialNotifyView()
		{
		}

		// Token: 0x04030DAD RID: 200109
		[Token(Token = "0x4030DAD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSuc;

		// Token: 0x04030DAE RID: 200110
		[Token(Token = "0x4030DAE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelFail;

		// Token: 0x04030DAF RID: 200111
		[Token(Token = "0x4030DAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030DB0 RID: 200112
		[Token(Token = "0x4030DB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F7B RID: 24443
		[Token(Token = "0x2005F7B")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060235F4 RID: 144884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235F4")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04030DB1 RID: 200113
			[Token(Token = "0x4030DB1")]
			[FieldOffset(Offset = "0x10")]
			public bool isSuc;
		}
	}
}
