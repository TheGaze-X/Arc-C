using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FBE RID: 24510
	[Token(Token = "0x2005FBE")]
	public class SpCharMissionCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170053A8 RID: 21416
		// (get) Token: 0x06023734 RID: 145204 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023735 RID: 145205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053A8")]
		public Action<SpCharMissionCharViewModel> onJumpToClicked
		{
			[Token(Token = "0x6023734")]
			[Address(RVA = "0x1E260C0", Offset = "0x1E24CC0", VA = "0x181E260C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023735")]
			[Address(RVA = "0x1E26120", Offset = "0x1E24D20", VA = "0x181E26120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023736 RID: 145206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023736")]
		[Address(RVA = "0x1E25B50", Offset = "0x1E24750", VA = "0x181E25B50")]
		public void InitIfNot(CharacterInfoSpCharMissionView context)
		{
		}

		// Token: 0x06023737 RID: 145207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023737")]
		[Address(RVA = "0x1E25DA0", Offset = "0x1E249A0", VA = "0x181E25DA0")]
		public void Render(SpCharMissionCharViewModel viewModel)
		{
		}

		// Token: 0x06023738 RID: 145208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023738")]
		[Address(RVA = "0x1E25A40", Offset = "0x1E24640", VA = "0x181E25A40")]
		public void EventOnJumpToClicked()
		{
		}

		// Token: 0x06023739 RID: 145209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023739")]
		[Address(RVA = "0x1E26060", Offset = "0x1E24C60", VA = "0x181E26060")]
		public SpCharMissionCharView()
		{
		}

		// Token: 0x04031058 RID: 200792
		[Token(Token = "0x4031058")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<SpCharMissionObjView> _missionObjViews;

		// Token: 0x04031059 RID: 200793
		[Token(Token = "0x4031059")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403105A RID: 200794
		[Token(Token = "0x403105A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imagePortrait;

		// Token: 0x0403105B RID: 200795
		[Token(Token = "0x403105B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _buttonJumpTo;

		// Token: 0x0403105C RID: 200796
		[Token(Token = "0x403105C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCurrent;

		// Token: 0x0403105D RID: 200797
		[Token(Token = "0x403105D")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x0403105E RID: 200798
		[Token(Token = "0x403105E")]
		[FieldOffset(Offset = "0x48")]
		private SpCharMissionCharViewModel m_cacheModel;

		// Token: 0x04031060 RID: 200800
		[Token(Token = "0x4031060")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onJumpToClicked;

		// Token: 0x04031061 RID: 200801
		[Token(Token = "0x4031061")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onJumpToClicked;

		// Token: 0x04031062 RID: 200802
		[Token(Token = "0x4031062")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04031063 RID: 200803
		[Token(Token = "0x4031063")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031064 RID: 200804
		[Token(Token = "0x4031064")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnJumpToClicked;

		// Token: 0x04031065 RID: 200805
		[Token(Token = "0x4031065")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
