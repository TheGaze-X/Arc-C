using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048C9 RID: 18633
	[Token(Token = "0x20048C9")]
	public class MiniActTrialRuleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C1BC RID: 115132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1BC")]
		[Address(RVA = "0x159C560", Offset = "0x159B160", VA = "0x18159C560")]
		public void Render(bool isTitle, string text)
		{
		}

		// Token: 0x0601C1BD RID: 115133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1BD")]
		[Address(RVA = "0x159C6D0", Offset = "0x159B2D0", VA = "0x18159C6D0")]
		public MiniActTrialRuleItemView()
		{
		}

		// Token: 0x04024BF4 RID: 150516
		[Token(Token = "0x4024BF4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _titlePartGo;

		// Token: 0x04024BF5 RID: 150517
		[Token(Token = "0x4024BF5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _contentPartGo;

		// Token: 0x04024BF6 RID: 150518
		[Token(Token = "0x4024BF6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04024BF7 RID: 150519
		[Token(Token = "0x4024BF7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x04024BF8 RID: 150520
		[Token(Token = "0x4024BF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024BF9 RID: 150521
		[Token(Token = "0x4024BF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
