using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005251 RID: 21073
	[Token(Token = "0x2005251")]
	public class RoguelikeFragmentRollNodeDialogPlugin : RoguelikeDungeonRollNodeDialogPlugin
	{
		// Token: 0x0601F159 RID: 127321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F159")]
		[Address(RVA = "0x18DA4A0", Offset = "0x18D90A0", VA = "0x1818DA4A0", Slot = "4")]
		public override void Render(RoguelikeDungeonRollNodeDialog.Options options)
		{
		}

		// Token: 0x0601F15A RID: 127322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F15A")]
		[Address(RVA = "0x18DA7F0", Offset = "0x18D93F0", VA = "0x1818DA7F0")]
		public RoguelikeFragmentRollNodeDialogPlugin()
		{
		}

		// Token: 0x04029B23 RID: 170787
		[Token(Token = "0x4029B23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04029B24 RID: 170788
		[Token(Token = "0x4029B24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _freeDesc;

		// Token: 0x04029B25 RID: 170789
		[Token(Token = "0x4029B25")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelDesc;

		// Token: 0x04029B26 RID: 170790
		[Token(Token = "0x4029B26")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelFree;

		// Token: 0x04029B27 RID: 170791
		[Token(Token = "0x4029B27")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04029B28 RID: 170792
		[Token(Token = "0x4029B28")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _descItemCount;

		// Token: 0x04029B29 RID: 170793
		[Token(Token = "0x4029B29")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _descLeftCount;

		// Token: 0x04029B2A RID: 170794
		[Token(Token = "0x4029B2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029B2B RID: 170795
		[Token(Token = "0x4029B2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
