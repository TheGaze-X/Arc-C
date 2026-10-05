using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044D6 RID: 17622
	[Token(Token = "0x20044D6")]
	public class RoguelikeTopicDifficultyOptionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x0601AE7E RID: 110206 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AE7F RID: 110207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FE0")]
		public Action<RoguelikeTopicMode> onDiffSelected
		{
			[Token(Token = "0x601AE7E")]
			[Address(RVA = "0x140A9C0", Offset = "0x14095C0", VA = "0x18140A9C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AE7F")]
			[Address(RVA = "0x140AA20", Offset = "0x1409620", VA = "0x18140AA20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AE80 RID: 110208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE80")]
		[Address(RVA = "0x140A5C0", Offset = "0x14091C0", VA = "0x18140A5C0")]
		public void Render(RoguelikeTopicDifficultyViewModel diffModel, bool isSelected)
		{
		}

		// Token: 0x0601AE81 RID: 110209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE81")]
		[Address(RVA = "0x140A830", Offset = "0x1409430", VA = "0x18140A830")]
		private void _SetImageColor(Graphic image, Color c)
		{
		}

		// Token: 0x0601AE82 RID: 110210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE82")]
		[Address(RVA = "0x140A4C0", Offset = "0x14090C0", VA = "0x18140A4C0")]
		public void OnDiffSelected()
		{
		}

		// Token: 0x0601AE83 RID: 110211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE83")]
		[Address(RVA = "0x140A960", Offset = "0x1409560", VA = "0x18140A960")]
		public RoguelikeTopicDifficultyOptionItemView()
		{
		}

		// Token: 0x040227A5 RID: 141221
		[Token(Token = "0x40227A5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x040227A6 RID: 141222
		[Token(Token = "0x40227A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Graphic _imgBg;

		// Token: 0x040227A7 RID: 141223
		[Token(Token = "0x40227A7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _imgGlow;

		// Token: 0x040227A8 RID: 141224
		[Token(Token = "0x40227A8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectedPartGo;

		// Token: 0x040227A9 RID: 141225
		[Token(Token = "0x40227A9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockedImg;

		// Token: 0x040227AB RID: 141227
		[Token(Token = "0x40227AB")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeTopicDifficultyViewModel m_diffModel;

		// Token: 0x040227AC RID: 141228
		[Token(Token = "0x40227AC")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isSelected;

		// Token: 0x040227AD RID: 141229
		[Token(Token = "0x40227AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onDiffSelected;

		// Token: 0x040227AE RID: 141230
		[Token(Token = "0x40227AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onDiffSelected;

		// Token: 0x040227AF RID: 141231
		[Token(Token = "0x40227AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040227B0 RID: 141232
		[Token(Token = "0x40227B0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetImageColor;

		// Token: 0x040227B1 RID: 141233
		[Token(Token = "0x40227B1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDiffSelected;

		// Token: 0x040227B2 RID: 141234
		[Token(Token = "0x40227B2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
