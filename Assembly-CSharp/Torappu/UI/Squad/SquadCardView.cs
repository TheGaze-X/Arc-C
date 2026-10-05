using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E0C RID: 15884
	[Token(Token = "0x2003E0C")]
	public class SquadCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x06018B63 RID: 101219 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018B64 RID: 101220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AE5")]
		public Action<int> onClick
		{
			[Token(Token = "0x6018B63")]
			[Address(RVA = "0x1138640", Offset = "0x1137240", VA = "0x181138640")]
			get
			{
				return null;
			}
			[Token(Token = "0x6018B64")]
			[Address(RVA = "0x1138710", Offset = "0x1137310", VA = "0x181138710")]
			set
			{
			}
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x06018B65 RID: 101221 RVA: 0x0009B7D8 File Offset: 0x000999D8
		// (set) Token: 0x06018B66 RID: 101222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AE6")]
		public bool isEmpty
		{
			[Token(Token = "0x6018B65")]
			[Address(RVA = "0x11385E0", Offset = "0x11371E0", VA = "0x1811385E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018B66")]
			[Address(RVA = "0x11386A0", Offset = "0x11372A0", VA = "0x1811386A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06018B67 RID: 101223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B67")]
		[Address(RVA = "0x1137F60", Offset = "0x1136B60", VA = "0x181137F60")]
		public void RenderCard(int index, SquadCardViewModel viewModel)
		{
		}

		// Token: 0x06018B68 RID: 101224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B68")]
		[Address(RVA = "0x1137E40", Offset = "0x1136A40", VA = "0x181137E40")]
		public void EventOnClick()
		{
		}

		// Token: 0x06018B69 RID: 101225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B69")]
		[Address(RVA = "0x11384A0", Offset = "0x11370A0", VA = "0x1811384A0")]
		private void _OnClick(int chrInstId)
		{
		}

		// Token: 0x06018B6A RID: 101226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B6A")]
		[Address(RVA = "0x1138570", Offset = "0x1137170", VA = "0x181138570")]
		public SquadCardView()
		{
		}

		// Token: 0x0401E4F1 RID: 124145
		[Token(Token = "0x401E4F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0401E4F2 RID: 124146
		[Token(Token = "0x401E4F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x0401E4F3 RID: 124147
		[Token(Token = "0x401E4F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0f, 1.5f)]
		private float _charCardScaler;

		// Token: 0x0401E4F4 RID: 124148
		[Token(Token = "0x401E4F4")]
		[FieldOffset(Offset = "0x30")]
		private UICharacterCardPanel m_characterCard;

		// Token: 0x0401E4F5 RID: 124149
		[Token(Token = "0x401E4F5")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_cardBanObj;

		// Token: 0x0401E4F6 RID: 124150
		[Token(Token = "0x401E4F6")]
		[FieldOffset(Offset = "0x40")]
		private int m_indexCache;

		// Token: 0x0401E4F7 RID: 124151
		[Token(Token = "0x401E4F7")]
		[FieldOffset(Offset = "0x48")]
		private Action<int> m_onClick;

		// Token: 0x0401E4F8 RID: 124152
		[Token(Token = "0x401E4F8")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isEmptyNotClickable;

		// Token: 0x0401E4FA RID: 124154
		[Token(Token = "0x401E4FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0401E4FB RID: 124155
		[Token(Token = "0x401E4FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0401E4FC RID: 124156
		[Token(Token = "0x401E4FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0401E4FD RID: 124157
		[Token(Token = "0x401E4FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isEmpty;

		// Token: 0x0401E4FE RID: 124158
		[Token(Token = "0x401E4FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0401E4FF RID: 124159
		[Token(Token = "0x401E4FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0401E500 RID: 124160
		[Token(Token = "0x401E500")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnClick;

		// Token: 0x0401E501 RID: 124161
		[Token(Token = "0x401E501")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
