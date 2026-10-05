using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F76 RID: 24438
	[Token(Token = "0x2005F76")]
	public class CharacterInfoLevelUpNotifyView : UINotifyView<CharacterInfoLevelUpNotifyView.Param>
	{
		// Token: 0x060235EC RID: 144876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235EC")]
		[Address(RVA = "0x1DFFE70", Offset = "0x1DFEA70", VA = "0x181DFFE70", Slot = "9")]
		protected override void Render(CharacterInfoLevelUpNotifyView.Param param)
		{
		}

		// Token: 0x060235ED RID: 144877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235ED")]
		[Address(RVA = "0x1DFFFB0", Offset = "0x1DFEBB0", VA = "0x181DFFFB0")]
		public CharacterInfoLevelUpNotifyView()
		{
		}

		// Token: 0x04030DA4 RID: 200100
		[Token(Token = "0x4030DA4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x04030DA5 RID: 200101
		[Token(Token = "0x4030DA5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04030DA6 RID: 200102
		[Token(Token = "0x4030DA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030DA7 RID: 200103
		[Token(Token = "0x4030DA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F77 RID: 24439
		[Token(Token = "0x2005F77")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060235EE RID: 144878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235EE")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04030DA8 RID: 200104
			[Token(Token = "0x4030DA8")]
			[FieldOffset(Offset = "0x10")]
			public int level;
		}
	}
}
