using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FF6 RID: 28662
	[Token(Token = "0x2006FF6")]
	public class ActMultiV3StageListItemModeStarCountView : ActMultiV3StageListItemModeView
	{
		// Token: 0x06028B29 RID: 166697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B29")]
		[Address(RVA = "0x240FD60", Offset = "0x240E960", VA = "0x18240FD60", Slot = "4")]
		public override void Render(ActMultiV3StageItemViewModel viewModel)
		{
		}

		// Token: 0x06028B2A RID: 166698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B2A")]
		[Address(RVA = "0x240FED0", Offset = "0x240EAD0", VA = "0x18240FED0")]
		public ActMultiV3StageListItemModeStarCountView()
		{
		}

		// Token: 0x0403A010 RID: 237584
		[Token(Token = "0x403A010")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage[] _imgStarList;

		// Token: 0x0403A011 RID: 237585
		[Token(Token = "0x403A011")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0403A012 RID: 237586
		[Token(Token = "0x403A012")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _imgGrayStarSpriteName;

		// Token: 0x0403A013 RID: 237587
		[Token(Token = "0x403A013")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _imgRedStarSpriteName;

		// Token: 0x0403A014 RID: 237588
		[Token(Token = "0x403A014")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A015 RID: 237589
		[Token(Token = "0x403A015")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
