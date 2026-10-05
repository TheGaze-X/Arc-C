using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x0200789A RID: 30874
	[Token(Token = "0x200789A")]
	public class Act1LockAssistCardView : DataBinder<SquadGroupViewProperty>
	{
		// Token: 0x0602B48A RID: 177290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B48A")]
		[Address(RVA = "0x27068C0", Offset = "0x27054C0", VA = "0x1827068C0")]
		private void _RenderCard(SharedCharData inputSharedCharacter, EvolvePhaseAndLevel maxEvolvePhaseAndLevel)
		{
		}

		// Token: 0x0602B48B RID: 177291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B48B")]
		[Address(RVA = "0x2706B30", Offset = "0x2705730", VA = "0x182706B30")]
		private void _RenderEmptyPanel(string portraitId)
		{
		}

		// Token: 0x0602B48C RID: 177292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B48C")]
		[Address(RVA = "0x2706430", Offset = "0x2705030", VA = "0x182706430", Slot = "7")]
		public override void OnValueChanged(SquadGroupViewProperty property)
		{
		}

		// Token: 0x0602B48D RID: 177293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B48D")]
		[Address(RVA = "0x2706C60", Offset = "0x2705860", VA = "0x182706C60")]
		public Act1LockAssistCardView()
		{
		}

		// Token: 0x0403E8CF RID: 256207
		[Token(Token = "0x403E8CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0403E8D0 RID: 256208
		[Token(Token = "0x403E8D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _portraitImg;

		// Token: 0x0403E8D1 RID: 256209
		[Token(Token = "0x403E8D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x0403E8D2 RID: 256210
		[Token(Token = "0x403E8D2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _cleanButton;

		// Token: 0x0403E8D3 RID: 256211
		[Token(Token = "0x403E8D3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 1.5f)]
		private float _charCardScaler;

		// Token: 0x0403E8D4 RID: 256212
		[Token(Token = "0x403E8D4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _activePart;

		// Token: 0x0403E8D5 RID: 256213
		[Token(Token = "0x403E8D5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _unactivePart;

		// Token: 0x0403E8D6 RID: 256214
		[Token(Token = "0x403E8D6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x0403E8D7 RID: 256215
		[Token(Token = "0x403E8D7")]
		[FieldOffset(Offset = "0x60")]
		private UICharacterCardPanel m_characterCard;

		// Token: 0x0403E8D8 RID: 256216
		[Token(Token = "0x403E8D8")]
		[FieldOffset(Offset = "0x68")]
		private string m_portrait;

		// Token: 0x0403E8D9 RID: 256217
		[Token(Token = "0x403E8D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RenderCard;

		// Token: 0x0403E8DA RID: 256218
		[Token(Token = "0x403E8DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderEmptyPanel;

		// Token: 0x0403E8DB RID: 256219
		[Token(Token = "0x403E8DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E8DC RID: 256220
		[Token(Token = "0x403E8DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
