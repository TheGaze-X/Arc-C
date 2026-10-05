using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A03 RID: 10755
	[Token(Token = "0x2002A03")]
	public class LegionUICharacterStatusController : MonoBehaviour, IHotfixable, IEffectSource
	{
		// Token: 0x06011D75 RID: 73077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D75")]
		[Address(RVA = "0x9AF190", Offset = "0x9ADD90", VA = "0x1809AF190", Slot = "4")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011D76 RID: 73078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D76")]
		[Address(RVA = "0x9AFAF0", Offset = "0x9AE6F0", VA = "0x1809AFAF0")]
		public void OnInit(LegionUIPlugin plugin)
		{
		}

		// Token: 0x06011D77 RID: 73079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D77")]
		[Address(RVA = "0x9AFA70", Offset = "0x9AE670", VA = "0x1809AFA70")]
		public void OnGameReady(UIController uiController)
		{
		}

		// Token: 0x06011D78 RID: 73080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D78")]
		[Address(RVA = "0x9AFC90", Offset = "0x9AE890", VA = "0x1809AFC90")]
		public void PreloadAssets(Transform parent)
		{
		}

		// Token: 0x06011D79 RID: 73081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D79")]
		[Address(RVA = "0x9AFBA0", Offset = "0x9AE7A0", VA = "0x1809AFBA0")]
		public void OnUnitBorn(Unit unit)
		{
		}

		// Token: 0x06011D7A RID: 73082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D7A")]
		[Address(RVA = "0x9AF220", Offset = "0x9ADE20", VA = "0x1809AF220")]
		public void OnCardMenuShow(Deck.Card card)
		{
		}

		// Token: 0x06011D7B RID: 73083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D7B")]
		[Address(RVA = "0x9AF2C0", Offset = "0x9ADEC0", VA = "0x1809AF2C0")]
		public void OnCharacterMenuHide()
		{
		}

		// Token: 0x06011D7C RID: 73084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D7C")]
		[Address(RVA = "0x9AF340", Offset = "0x9ADF40", VA = "0x1809AF340")]
		public void OnCharacterMenuShow(Character character)
		{
		}

		// Token: 0x06011D7D RID: 73085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D7D")]
		[Address(RVA = "0x9AF480", Offset = "0x9AE080", VA = "0x1809AF480")]
		public void OnDummyTouchedToTile(Character character, Tile tile)
		{
		}

		// Token: 0x06011D7E RID: 73086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D7E")]
		[Address(RVA = "0x9B0360", Offset = "0x9AEF60", VA = "0x1809B0360")]
		private void _ApplyCharacterInReplaceGraphicPosition(Character character, bool isReset)
		{
		}

		// Token: 0x06011D7F RID: 73087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D7F")]
		[Address(RVA = "0x9AFEA0", Offset = "0x9AEAA0", VA = "0x1809AFEA0")]
		private void _ApplyCharacterInReplaceEffect(Character character, bool isReset)
		{
		}

		// Token: 0x06011D80 RID: 73088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D80")]
		[Address(RVA = "0x9B0780", Offset = "0x9AF380", VA = "0x1809B0780")]
		private void _RefreshCharacterBuffDetail(List<LegionModeProfessionBuffStatus> statusList)
		{
		}

		// Token: 0x06011D81 RID: 73089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011D81")]
		[Address(RVA = "0x9B0700", Offset = "0x9AF300", VA = "0x1809B0700")]
		private List<LegionModeProfessionBuffStatus> _GetCharacterProfessionStatus(uint characterUid)
		{
			return null;
		}

		// Token: 0x06011D82 RID: 73090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D82")]
		[Address(RVA = "0x9B0900", Offset = "0x9AF500", VA = "0x1809B0900")]
		public LegionUICharacterStatusController()
		{
		}

		// Token: 0x040140B8 RID: 82104
		[Token(Token = "0x40140B8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("CharacterExInfo")]
		private UICharacterTabGroupAddtion _characterAddtionTabBuffDetail;

		// Token: 0x040140B9 RID: 82105
		[Token(Token = "0x40140B9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("CharacterExInfo")]
		private UIBattleLegionCharacterMenuPanel _perspectiveCharacterMenuPrefab;

		// Token: 0x040140BA RID: 82106
		[Token(Token = "0x40140BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("DummyInReplace")]
		private Vector3 _dummyInReplaceOffset;

		// Token: 0x040140BB RID: 82107
		[Token(Token = "0x40140BB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Group("DummyInReplace")]
		private bool _dummyInReplacePlayAnim;

		// Token: 0x040140BC RID: 82108
		[Token(Token = "0x40140BC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("DummyInReplace")]
		private float _dummyInReplaceAnimTimeScale;

		// Token: 0x040140BD RID: 82109
		[Token(Token = "0x40140BD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("DummyInReplace")]
		private string[] _dummyInReplaceEffects;

		// Token: 0x040140BE RID: 82110
		[Token(Token = "0x40140BE")]
		[FieldOffset(Offset = "0x48")]
		private List<ProfessionCategory> m_highLightProfessionList;

		// Token: 0x040140BF RID: 82111
		[Token(Token = "0x40140BF")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 m_dummyPosition;

		// Token: 0x040140C0 RID: 82112
		[Token(Token = "0x40140C0")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, Vector3> m_cachedDummyOriginPos;

		// Token: 0x040140C1 RID: 82113
		[Token(Token = "0x40140C1")]
		[FieldOffset(Offset = "0x68")]
		private List<ObjectPtr<Effect>> m_dummyInReplaceEffects;

		// Token: 0x040140C2 RID: 82114
		[Token(Token = "0x40140C2")]
		[FieldOffset(Offset = "0x70")]
		private UIBattleLegionCharacterMenuPanel m_perspectiveCharacterPanel;

		// Token: 0x040140C3 RID: 82115
		[Token(Token = "0x40140C3")]
		[FieldOffset(Offset = "0x78")]
		private UICharacterTabGroupAddtion m_characterAddtionTabBuffDetail;

		// Token: 0x040140C4 RID: 82116
		[Token(Token = "0x40140C4")]
		[FieldOffset(Offset = "0x80")]
		private EasyInstancePool m_characterTabBuffDetailList;

		// Token: 0x040140C5 RID: 82117
		[Token(Token = "0x40140C5")]
		[FieldOffset(Offset = "0x88")]
		private LegionUIPlugin m_parentPlugin;

		// Token: 0x040140C6 RID: 82118
		[Token(Token = "0x40140C6")]
		[FieldOffset(Offset = "0x90")]
		private GameModeFactory.LegionGameMode m_manager;

		// Token: 0x040140C7 RID: 82119
		[Token(Token = "0x40140C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040140C8 RID: 82120
		[Token(Token = "0x40140C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040140C9 RID: 82121
		[Token(Token = "0x40140C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x040140CA RID: 82122
		[Token(Token = "0x40140CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreloadAssets;

		// Token: 0x040140CB RID: 82123
		[Token(Token = "0x40140CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUnitBorn;

		// Token: 0x040140CC RID: 82124
		[Token(Token = "0x40140CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCardMenuShow;

		// Token: 0x040140CD RID: 82125
		[Token(Token = "0x40140CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuHide;

		// Token: 0x040140CE RID: 82126
		[Token(Token = "0x40140CE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuShow;

		// Token: 0x040140CF RID: 82127
		[Token(Token = "0x40140CF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDummyTouchedToTile;

		// Token: 0x040140D0 RID: 82128
		[Token(Token = "0x40140D0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ApplyCharacterInReplaceGraphicPosition;

		// Token: 0x040140D1 RID: 82129
		[Token(Token = "0x40140D1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ApplyCharacterInReplaceEffect;

		// Token: 0x040140D2 RID: 82130
		[Token(Token = "0x40140D2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RefreshCharacterBuffDetail;

		// Token: 0x040140D3 RID: 82131
		[Token(Token = "0x40140D3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetCharacterProfessionStatus;

		// Token: 0x040140D4 RID: 82132
		[Token(Token = "0x40140D4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
