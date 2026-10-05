using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E06 RID: 15878
	[Token(Token = "0x2003E06")]
	public class RuneSquadCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x06018B4F RID: 101199 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018B50 RID: 101200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AE2")]
		public Action<RuneSquadCardView.Options> onClick
		{
			[Token(Token = "0x6018B4F")]
			[Address(RVA = "0x1136230", Offset = "0x1134E30", VA = "0x181136230")]
			get
			{
				return null;
			}
			[Token(Token = "0x6018B50")]
			[Address(RVA = "0x1136290", Offset = "0x1134E90", VA = "0x181136290")]
			set
			{
			}
		}

		// Token: 0x06018B51 RID: 101201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B51")]
		[Address(RVA = "0x1135F00", Offset = "0x1134B00", VA = "0x181135F00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018B52 RID: 101202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B52")]
		[Address(RVA = "0x1135D60", Offset = "0x1134960", VA = "0x181135D60")]
		public void RenderCard(RuneSquadCardView.Options options)
		{
		}

		// Token: 0x06018B53 RID: 101203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B53")]
		[Address(RVA = "0x1135D00", Offset = "0x1134900", VA = "0x181135D00")]
		public void EventOnClick()
		{
		}

		// Token: 0x06018B54 RID: 101204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B54")]
		[Address(RVA = "0x1136130", Offset = "0x1134D30", VA = "0x181136130")]
		private void _InvokeOnClick()
		{
		}

		// Token: 0x06018B55 RID: 101205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B55")]
		[Address(RVA = "0x11361C0", Offset = "0x1134DC0", VA = "0x1811361C0")]
		public RuneSquadCardView()
		{
		}

		// Token: 0x0401E4BE RID: 124094
		[Token(Token = "0x401E4BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0401E4BF RID: 124095
		[Token(Token = "0x401E4BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x0401E4C0 RID: 124096
		[Token(Token = "0x401E4C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0401E4C1 RID: 124097
		[Token(Token = "0x401E4C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 2f)]
		private float _cardScale;

		// Token: 0x0401E4C2 RID: 124098
		[Token(Token = "0x401E4C2")]
		[FieldOffset(Offset = "0x38")]
		private RuneSquadCardView.Options m_optionsCache;

		// Token: 0x0401E4C3 RID: 124099
		[Token(Token = "0x401E4C3")]
		[FieldOffset(Offset = "0x50")]
		private UICharacterCardPanel m_charCardPanel;

		// Token: 0x0401E4C4 RID: 124100
		[Token(Token = "0x401E4C4")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0401E4C5 RID: 124101
		[Token(Token = "0x401E4C5")]
		[FieldOffset(Offset = "0x5C")]
		private int m_indexCache;

		// Token: 0x0401E4C6 RID: 124102
		[Token(Token = "0x401E4C6")]
		[FieldOffset(Offset = "0x60")]
		private Action<RuneSquadCardView.Options> m_onClick;

		// Token: 0x0401E4C7 RID: 124103
		[Token(Token = "0x401E4C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0401E4C8 RID: 124104
		[Token(Token = "0x401E4C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0401E4C9 RID: 124105
		[Token(Token = "0x401E4C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E4CA RID: 124106
		[Token(Token = "0x401E4CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0401E4CB RID: 124107
		[Token(Token = "0x401E4CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0401E4CC RID: 124108
		[Token(Token = "0x401E4CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InvokeOnClick;

		// Token: 0x0401E4CD RID: 124109
		[Token(Token = "0x401E4CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E07 RID: 15879
		[Token(Token = "0x2003E07")]
		public struct Options
		{
			// Token: 0x0401E4CE RID: 124110
			[Token(Token = "0x401E4CE")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x0401E4CF RID: 124111
			[Token(Token = "0x401E4CF")]
			[FieldOffset(Offset = "0x8")]
			public CharacterCardViewModel charViewModel;

			// Token: 0x0401E4D0 RID: 124112
			[Token(Token = "0x401E4D0")]
			[FieldOffset(Offset = "0x10")]
			public bool isLocked;
		}
	}
}
