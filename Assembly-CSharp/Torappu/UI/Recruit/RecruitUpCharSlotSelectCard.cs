using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200470F RID: 18191
	[Token(Token = "0x200470F")]
	public class RecruitUpCharSlotSelectCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x0601B942 RID: 112962 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B943 RID: 112963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041A8")]
		public Action<int> onCardClick
		{
			[Token(Token = "0x601B942")]
			[Address(RVA = "0x14ED110", Offset = "0x14EBD10", VA = "0x1814ED110")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B943")]
			[Address(RVA = "0x14ED170", Offset = "0x14EBD70", VA = "0x1814ED170")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B944 RID: 112964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B944")]
		[Address(RVA = "0x14ECE00", Offset = "0x14EBA00", VA = "0x1814ECE00")]
		public void Render(int index, string charId)
		{
		}

		// Token: 0x0601B945 RID: 112965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B945")]
		[Address(RVA = "0x14ECCF0", Offset = "0x14EB8F0", VA = "0x1814ECCF0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601B946 RID: 112966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B946")]
		[Address(RVA = "0x14ED080", Offset = "0x14EBC80", VA = "0x1814ED080")]
		public RecruitUpCharSlotSelectCard()
		{
		}

		// Token: 0x04023B90 RID: 146320
		[Token(Token = "0x4023B90")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNoChar;

		// Token: 0x04023B91 RID: 146321
		[Token(Token = "0x4023B91")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelChar;

		// Token: 0x04023B92 RID: 146322
		[Token(Token = "0x4023B92")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgChar;

		// Token: 0x04023B93 RID: 146323
		[Token(Token = "0x4023B93")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgRarity;

		// Token: 0x04023B94 RID: 146324
		[Token(Token = "0x4023B94")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x04023B95 RID: 146325
		[Token(Token = "0x4023B95")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x04023B97 RID: 146327
		[Token(Token = "0x4023B97")]
		[FieldOffset(Offset = "0x50")]
		private int m_index;

		// Token: 0x04023B98 RID: 146328
		[Token(Token = "0x4023B98")]
		[FieldOffset(Offset = "0x58")]
		private string m_charId;

		// Token: 0x04023B99 RID: 146329
		[Token(Token = "0x4023B99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCardClick;

		// Token: 0x04023B9A RID: 146330
		[Token(Token = "0x4023B9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCardClick;

		// Token: 0x04023B9B RID: 146331
		[Token(Token = "0x4023B9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023B9C RID: 146332
		[Token(Token = "0x4023B9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04023B9D RID: 146333
		[Token(Token = "0x4023B9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
