using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E0A RID: 15882
	[Token(Token = "0x2003E0A")]
	public class SquadAssistCardView : DataBinder<SquadGroupViewProperty>
	{
		// Token: 0x06018B60 RID: 101216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B60")]
		[Address(RVA = "0x11374C0", Offset = "0x11360C0", VA = "0x1811374C0")]
		private void _RenderCard(SharedCharData inputSharedCharacter, EvolvePhaseAndLevel maxEvolvePhaseAndLevel, bool isFriend)
		{
		}

		// Token: 0x06018B61 RID: 101217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B61")]
		[Address(RVA = "0x11371E0", Offset = "0x1135DE0", VA = "0x1811371E0", Slot = "7")]
		public override void OnValueChanged(SquadGroupViewProperty property)
		{
		}

		// Token: 0x06018B62 RID: 101218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B62")]
		[Address(RVA = "0x1137770", Offset = "0x1136370", VA = "0x181137770")]
		public SquadAssistCardView()
		{
		}

		// Token: 0x0401E4E2 RID: 124130
		[Token(Token = "0x401E4E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0401E4E3 RID: 124131
		[Token(Token = "0x401E4E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x0401E4E4 RID: 124132
		[Token(Token = "0x401E4E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _cleanButton;

		// Token: 0x0401E4E5 RID: 124133
		[Token(Token = "0x401E4E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(0f, 1.5f)]
		private float _charCardScaler;

		// Token: 0x0401E4E6 RID: 124134
		[Token(Token = "0x401E4E6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _activePart;

		// Token: 0x0401E4E7 RID: 124135
		[Token(Token = "0x401E4E7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _unactivePart;

		// Token: 0x0401E4E8 RID: 124136
		[Token(Token = "0x401E4E8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("This is nullable")]
		private GameObject _panelLocked;

		// Token: 0x0401E4E9 RID: 124137
		[Token(Token = "0x401E4E9")]
		[FieldOffset(Offset = "0x58")]
		private UICharacterCardPanel m_characterCard;

		// Token: 0x0401E4EA RID: 124138
		[Token(Token = "0x401E4EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RenderCard;

		// Token: 0x0401E4EB RID: 124139
		[Token(Token = "0x401E4EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401E4EC RID: 124140
		[Token(Token = "0x401E4EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
