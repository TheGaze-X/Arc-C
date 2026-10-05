using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035E5 RID: 13797
	[Token(Token = "0x20035E5")]
	public class CommonSquadAssistView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015F91 RID: 90001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F91")]
		[Address(RVA = "0xE75560", Offset = "0xE74160", VA = "0x180E75560")]
		private void _InitIfNot(CommonCharCardView cardAsset)
		{
		}

		// Token: 0x06015F92 RID: 90002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F92")]
		[Address(RVA = "0xE756C0", Offset = "0xE742C0", VA = "0x180E756C0")]
		private void _RenderCard(SharedCharData inputSharedCharacter, EvolvePhaseAndLevel maxEvolvePhaseAndLevel, bool isFriend)
		{
		}

		// Token: 0x06015F93 RID: 90003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F93")]
		[Address(RVA = "0xE75070", Offset = "0xE73C70", VA = "0x180E75070")]
		public void RenderView(CommonSquadGroupViewModel squadGroupViewModel, CommonCharCardView cardAsset)
		{
		}

		// Token: 0x06015F94 RID: 90004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F94")]
		[Address(RVA = "0xE758B0", Offset = "0xE744B0", VA = "0x180E758B0")]
		public CommonSquadAssistView()
		{
		}

		// Token: 0x0401A663 RID: 108131
		[Token(Token = "0x401A663")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0401A664 RID: 108132
		[Token(Token = "0x401A664")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x0401A665 RID: 108133
		[Token(Token = "0x401A665")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _cleanButton;

		// Token: 0x0401A666 RID: 108134
		[Token(Token = "0x401A666")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 1.5f)]
		private float _charCardScaler;

		// Token: 0x0401A667 RID: 108135
		[Token(Token = "0x401A667")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _activePart;

		// Token: 0x0401A668 RID: 108136
		[Token(Token = "0x401A668")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _inActivePart;

		// Token: 0x0401A669 RID: 108137
		[Token(Token = "0x401A669")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("This is nullable")]
		private GameObject _panelLocked;

		// Token: 0x0401A66A RID: 108138
		[Token(Token = "0x401A66A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0401A66B RID: 108139
		[Token(Token = "0x401A66B")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0401A66C RID: 108140
		[Token(Token = "0x401A66C")]
		[FieldOffset(Offset = "0x60")]
		private DefaultCommonCharCardViewModel m_cardViewModel;

		// Token: 0x0401A66D RID: 108141
		[Token(Token = "0x401A66D")]
		[FieldOffset(Offset = "0x68")]
		private CommonCharCardView m_cardView;

		// Token: 0x0401A66E RID: 108142
		[Token(Token = "0x401A66E")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401A66F RID: 108143
		[Token(Token = "0x401A66F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A670 RID: 108144
		[Token(Token = "0x401A670")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCard;

		// Token: 0x0401A671 RID: 108145
		[Token(Token = "0x401A671")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401A672 RID: 108146
		[Token(Token = "0x401A672")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
