using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E0D RID: 15885
	[Token(Token = "0x2003E0D")]
	public class SquadCardViewWithPredefine : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x06018B6B RID: 101227 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018B6C RID: 101228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AE7")]
		public Action<SquadCardViewWithPredefine.Options> onClick
		{
			[Token(Token = "0x6018B6B")]
			[Address(RVA = "0x1137D60", Offset = "0x1136960", VA = "0x181137D60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6018B6C")]
			[Address(RVA = "0x1137DC0", Offset = "0x11369C0", VA = "0x181137DC0")]
			set
			{
			}
		}

		// Token: 0x06018B6D RID: 101229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B6D")]
		[Address(RVA = "0x1137A30", Offset = "0x1136630", VA = "0x181137A30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018B6E RID: 101230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B6E")]
		[Address(RVA = "0x1137850", Offset = "0x1136450", VA = "0x181137850")]
		public void RenderCard(SquadCardViewWithPredefine.Options options)
		{
		}

		// Token: 0x06018B6F RID: 101231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B6F")]
		[Address(RVA = "0x11377F0", Offset = "0x11363F0", VA = "0x1811377F0")]
		public void EventOnClick()
		{
		}

		// Token: 0x06018B70 RID: 101232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B70")]
		[Address(RVA = "0x1137C60", Offset = "0x1136860", VA = "0x181137C60")]
		private void _InvokeOnClick()
		{
		}

		// Token: 0x06018B71 RID: 101233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B71")]
		[Address(RVA = "0x1137CF0", Offset = "0x11368F0", VA = "0x181137CF0")]
		public SquadCardViewWithPredefine()
		{
		}

		// Token: 0x0401E502 RID: 124162
		[Token(Token = "0x401E502")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0401E503 RID: 124163
		[Token(Token = "0x401E503")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x0401E504 RID: 124164
		[Token(Token = "0x401E504")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0401E505 RID: 124165
		[Token(Token = "0x401E505")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelPredefined;

		// Token: 0x0401E506 RID: 124166
		[Token(Token = "0x401E506")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(0f, 2f)]
		private float _cardScale;

		// Token: 0x0401E507 RID: 124167
		[Token(Token = "0x401E507")]
		[FieldOffset(Offset = "0x40")]
		private SquadCardViewWithPredefine.Options m_optionsCache;

		// Token: 0x0401E508 RID: 124168
		[Token(Token = "0x401E508")]
		[FieldOffset(Offset = "0x58")]
		private UICharacterCardPanel m_charCardPanel;

		// Token: 0x0401E509 RID: 124169
		[Token(Token = "0x401E509")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0401E50A RID: 124170
		[Token(Token = "0x401E50A")]
		[FieldOffset(Offset = "0x64")]
		private int m_indexCache;

		// Token: 0x0401E50B RID: 124171
		[Token(Token = "0x401E50B")]
		[FieldOffset(Offset = "0x68")]
		private Action<SquadCardViewWithPredefine.Options> m_onClick;

		// Token: 0x0401E50C RID: 124172
		[Token(Token = "0x401E50C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0401E50D RID: 124173
		[Token(Token = "0x401E50D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0401E50E RID: 124174
		[Token(Token = "0x401E50E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E50F RID: 124175
		[Token(Token = "0x401E50F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0401E510 RID: 124176
		[Token(Token = "0x401E510")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0401E511 RID: 124177
		[Token(Token = "0x401E511")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InvokeOnClick;

		// Token: 0x0401E512 RID: 124178
		[Token(Token = "0x401E512")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E0E RID: 15886
		[Token(Token = "0x2003E0E")]
		public struct Options
		{
			// Token: 0x0401E513 RID: 124179
			[Token(Token = "0x401E513")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x0401E514 RID: 124180
			[Token(Token = "0x401E514")]
			[FieldOffset(Offset = "0x8")]
			public CharacterCardViewModel charViewModel;

			// Token: 0x0401E515 RID: 124181
			[Token(Token = "0x401E515")]
			[FieldOffset(Offset = "0x10")]
			public bool isLocked;

			// Token: 0x0401E516 RID: 124182
			[Token(Token = "0x401E516")]
			[FieldOffset(Offset = "0x11")]
			public bool isPredefined;
		}
	}
}
