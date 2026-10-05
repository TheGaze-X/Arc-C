using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Assist
{
	// Token: 0x02001E07 RID: 7687
	[Token(Token = "0x2001E07")]
	public class AssistReportFavorView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BDCD RID: 48589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCD")]
		[Address(RVA = "0x339C560", Offset = "0x339B160", VA = "0x18339C560")]
		public void Render(List<BuildingFavorReport> favor)
		{
		}

		// Token: 0x0600BDCE RID: 48590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCE")]
		[Address(RVA = "0x339C7A0", Offset = "0x339B3A0", VA = "0x18339C7A0")]
		public AssistReportFavorView()
		{
		}

		// Token: 0x0400BE78 RID: 48760
		[Token(Token = "0x400BE78")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelControlTitle;

		// Token: 0x0400BE79 RID: 48761
		[Token(Token = "0x400BE79")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0400BE7A RID: 48762
		[Token(Token = "0x400BE7A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AssistReportFavorItem _item;

		// Token: 0x0400BE7B RID: 48763
		[Token(Token = "0x400BE7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400BE7C RID: 48764
		[Token(Token = "0x400BE7C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
