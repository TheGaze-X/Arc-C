using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004987 RID: 18823
	[Token(Token = "0x2004987")]
	public class MedalListTitleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C5D4 RID: 116180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5D4")]
		[Address(RVA = "0x15D4B80", Offset = "0x15D3780", VA = "0x1815D4B80")]
		public void RenderTitle(MedalGroupViewModel groupViewModel)
		{
		}

		// Token: 0x0601C5D5 RID: 116181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5D5")]
		[Address(RVA = "0x15D4AF0", Offset = "0x15D36F0", VA = "0x1815D4AF0")]
		public void OnClick()
		{
		}

		// Token: 0x0601C5D6 RID: 116182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5D6")]
		[Address(RVA = "0x15D4D30", Offset = "0x15D3930", VA = "0x1815D4D30")]
		public MedalListTitleView()
		{
		}

		// Token: 0x04025241 RID: 152129
		[Token(Token = "0x4025241")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x04025242 RID: 152130
		[Token(Token = "0x4025242")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _titleImage;

		// Token: 0x04025243 RID: 152131
		[Token(Token = "0x4025243")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _container;

		// Token: 0x04025244 RID: 152132
		[Token(Token = "0x4025244")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyState;

		// Token: 0x04025245 RID: 152133
		[Token(Token = "0x4025245")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public UIStringEvent clickToGroupEvent;

		// Token: 0x04025246 RID: 152134
		[Token(Token = "0x4025246")]
		[FieldOffset(Offset = "0x40")]
		private MedalGroupViewModel m_cacheViewModel;

		// Token: 0x04025247 RID: 152135
		[Token(Token = "0x4025247")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderTitle;

		// Token: 0x04025248 RID: 152136
		[Token(Token = "0x4025248")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04025249 RID: 152137
		[Token(Token = "0x4025249")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
