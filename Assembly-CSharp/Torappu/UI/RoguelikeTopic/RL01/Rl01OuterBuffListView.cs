using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004648 RID: 17992
	[Token(Token = "0x2004648")]
	public class Rl01OuterBuffListView : DataBinder<RoguelikeTopicOuterBuffListProperty>
	{
		// Token: 0x0601B51F RID: 111903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B51F")]
		[Address(RVA = "0x14A4E00", Offset = "0x14A3A00", VA = "0x1814A4E00", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicOuterBuffListProperty property)
		{
		}

		// Token: 0x0601B520 RID: 111904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B520")]
		[Address(RVA = "0x14A4FD0", Offset = "0x14A3BD0", VA = "0x1814A4FD0")]
		public Rl01OuterBuffListView()
		{
		}

		// Token: 0x040234B2 RID: 144562
		[Token(Token = "0x40234B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rl01OuterBuffLayout _layout;

		// Token: 0x040234B3 RID: 144563
		[Token(Token = "0x40234B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x040234B4 RID: 144564
		[Token(Token = "0x40234B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040234B5 RID: 144565
		[Token(Token = "0x40234B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
