using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CharSelect;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B90 RID: 7056
	[Token(Token = "0x2001B90")]
	public class BuildingPrivateSelectMaskPlugin : CharSelectCardMaskPlugin
	{
		// Token: 0x0600B064 RID: 45156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B064")]
		[Address(RVA = "0x32A5920", Offset = "0x32A4520", VA = "0x1832A5920", Slot = "4")]
		public override void Init(CharSelectCardView cardView, CharSelectStateBean stateBean, object context)
		{
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B065")]
		[Address(RVA = "0x32A59C0", Offset = "0x32A45C0", VA = "0x1832A59C0", Slot = "5")]
		public override void Render(CharacterCardViewModel cardModel)
		{
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B066")]
		[Address(RVA = "0x32A5C40", Offset = "0x32A4840", VA = "0x1832A5C40")]
		public BuildingPrivateSelectMaskPlugin()
		{
		}

		// Token: 0x0400AACB RID: 43723
		[Token(Token = "0x400AACB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelPrivateTag;

		// Token: 0x0400AACC RID: 43724
		[Token(Token = "0x400AACC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtRoomCode;

		// Token: 0x0400AACD RID: 43725
		[Token(Token = "0x400AACD")]
		[FieldOffset(Offset = "0x28")]
		private CharSelectStateBean m_stateBean;

		// Token: 0x0400AACE RID: 43726
		[Token(Token = "0x400AACE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400AACF RID: 43727
		[Token(Token = "0x400AACF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AAD0 RID: 43728
		[Token(Token = "0x400AAD0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
