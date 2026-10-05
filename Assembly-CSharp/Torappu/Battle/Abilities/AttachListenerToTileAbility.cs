using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002ADD RID: 10973
	[Token(Token = "0x2002ADD")]
	public class AttachListenerToTileAbility : CastOnTileAbility
	{
		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x060124AC RID: 74924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700281C")]
		private Dictionary<Tile, int> tileCastedStatus
		{
			[Token(Token = "0x60124AC")]
			[Address(RVA = "0xA50FB0", Offset = "0xA4FBB0", VA = "0x180A50FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060124AD RID: 74925 RVA: 0x00070110 File Offset: 0x0006E310
		[Token(Token = "0x60124AD")]
		[Address(RVA = "0xA4ED20", Offset = "0xA4D920", VA = "0x180A4ED20", Slot = "89")]
		protected override bool CheckIsDamageOrHealSource()
		{
			return default(bool);
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x060124AE RID: 74926 RVA: 0x00070128 File Offset: 0x0006E328
		[Token(Token = "0x1700281D")]
		public override bool isReady
		{
			[Token(Token = "0x60124AE")]
			[Address(RVA = "0xA50F50", Offset = "0xA4FB50", VA = "0x180A50F50", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060124AF RID: 74927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60124AF")]
		[Address(RVA = "0xA4F390", Offset = "0xA4DF90", VA = "0x180A4F390", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x060124B0 RID: 74928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124B0")]
		[Address(RVA = "0xA4F240", Offset = "0xA4DE40", VA = "0x180A4F240", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060124B1 RID: 74929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124B1")]
		[Address(RVA = "0xA4E6D0", Offset = "0xA4D2D0", VA = "0x180A4E6D0", Slot = "95")]
		protected override void Awake()
		{
		}

		// Token: 0x060124B2 RID: 74930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124B2")]
		[Address(RVA = "0xA4F0B0", Offset = "0xA4DCB0", VA = "0x180A4F0B0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060124B3 RID: 74931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124B3")]
		[Address(RVA = "0xA4ED80", Offset = "0xA4D980", VA = "0x180A4ED80", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060124B4 RID: 74932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124B4")]
		[Address(RVA = "0xA4EF20", Offset = "0xA4DB20", VA = "0x180A4EF20", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x060124B5 RID: 74933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124B5")]
		[Address(RVA = "0xA4F4F0", Offset = "0xA4E0F0", VA = "0x180A4F4F0", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x060124B6 RID: 74934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124B6")]
		[Address(RVA = "0xA4FAF0", Offset = "0xA4E6F0", VA = "0x180A4FAF0", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x060124B7 RID: 74935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124B7")]
		[Address(RVA = "0xA4F590", Offset = "0xA4E190", VA = "0x180A4F590", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x060124B8 RID: 74936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124B8")]
		[Address(RVA = "0xA501A0", Offset = "0xA4EDA0", VA = "0x180A501A0")]
		private void _ClearListeners()
		{
		}

		// Token: 0x060124B9 RID: 74937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124B9")]
		[Address(RVA = "0xA4FF80", Offset = "0xA4EB80", VA = "0x180A4FF80")]
		private void _ClearEffects()
		{
		}

		// Token: 0x060124BA RID: 74938 RVA: 0x00070140 File Offset: 0x0006E340
		[Token(Token = "0x60124BA")]
		[Address(RVA = "0xA4EAC0", Offset = "0xA4D6C0", VA = "0x180A4EAC0", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x060124BB RID: 74939 RVA: 0x00070158 File Offset: 0x0006E358
		[Token(Token = "0x60124BB")]
		[Address(RVA = "0xA4E880", Offset = "0xA4D480", VA = "0x180A4E880", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x060124BC RID: 74940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124BC")]
		[Address(RVA = "0xA4E330", Offset = "0xA4CF30", VA = "0x180A4E330")]
		public void AttachToTile(Tile tile, out bool newTile)
		{
		}

		// Token: 0x060124BD RID: 74941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124BD")]
		[Address(RVA = "0xA503A0", Offset = "0xA4EFA0", VA = "0x180A503A0")]
		protected void _HoldCastedEffectOnTile(Tile tile)
		{
		}

		// Token: 0x060124BE RID: 74942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124BE")]
		[Address(RVA = "0xA50C90", Offset = "0xA4F890", VA = "0x180A50C90")]
		private void _OnUnitReborn(object arg)
		{
		}

		// Token: 0x060124BF RID: 74943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124BF")]
		[Address(RVA = "0xA50880", Offset = "0xA4F480", VA = "0x180A50880")]
		private void _OnRallyPointReborn(object arg)
		{
		}

		// Token: 0x060124C0 RID: 74944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124C0")]
		[Address(RVA = "0xA50AE0", Offset = "0xA4F6E0", VA = "0x180A50AE0")]
		private void _OnTileOptionsChangedViaMode(object arg)
		{
		}

		// Token: 0x060124C1 RID: 74945 RVA: 0x00070170 File Offset: 0x0006E370
		[Token(Token = "0x60124C1")]
		[Address(RVA = "0xA4F400", Offset = "0xA4E000", VA = "0x180A4F400")]
		public int GetTileCastedTimes(Tile tile)
		{
			return 0;
		}

		// Token: 0x060124C2 RID: 74946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124C2")]
		[Address(RVA = "0xA4F690", Offset = "0xA4E290", VA = "0x180A4F690")]
		public void RefreshTileStatus()
		{
		}

		// Token: 0x060124C3 RID: 74947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124C3")]
		[Address(RVA = "0xA4FB60", Offset = "0xA4E760", VA = "0x180A4FB60")]
		public void SyncStatusFromOtherAbility(AttachListenerToTileAbility ability)
		{
		}

		// Token: 0x060124C4 RID: 74948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124C4")]
		[Address(RVA = "0xA4F860", Offset = "0xA4E460", VA = "0x180A4F860")]
		public void RemoveTileListener(Tile tile)
		{
		}

		// Token: 0x060124C5 RID: 74949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124C5")]
		[Address(RVA = "0xA50E40", Offset = "0xA4FA40", VA = "0x180A50E40")]
		public AttachListenerToTileAbility()
		{
		}

		// Token: 0x060124C6 RID: 74950 RVA: 0x00070188 File Offset: 0x0006E388
		[Token(Token = "0x60124C6")]
		[Address(RVA = "0xA1E4D0", Offset = "0xA1D0D0", VA = "0x180A1E4D0")]
		private bool <>xLuaBaseProxy_CheckIsDamageOrHealSource()
		{
			return default(bool);
		}

		// Token: 0x060124C7 RID: 74951 RVA: 0x000701A0 File Offset: 0x0006E3A0
		[Token(Token = "0x60124C7")]
		[Address(RVA = "0xA38720", Offset = "0xA37320", VA = "0x180A38720")]
		private bool <>xLuaBaseProxy_get_isReady()
		{
			return default(bool);
		}

		// Token: 0x060124C8 RID: 74952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124C8")]
		[Address(RVA = "0xA4FF50", Offset = "0xA4EB50", VA = "0x180A4FF50")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x060124C9 RID: 74953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124C9")]
		[Address(RVA = "0xA4FF40", Offset = "0xA4EB40", VA = "0x180A4FF40")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x060124CA RID: 74954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124CA")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060124CB RID: 74955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124CB")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x060124CC RID: 74956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124CC")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x060124CD RID: 74957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124CD")]
		[Address(RVA = "0xA4FF60", Offset = "0xA4EB60", VA = "0x180A4FF60")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x060124CE RID: 74958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124CE")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x060124CF RID: 74959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124CF")]
		[Address(RVA = "0xA4FF70", Offset = "0xA4EB70", VA = "0x180A4FF70")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x060124D0 RID: 74960 RVA: 0x000701B8 File Offset: 0x0006E3B8
		[Token(Token = "0x60124D0")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x060124D1 RID: 74961 RVA: 0x000701D0 File Offset: 0x0006E3D0
		[Token(Token = "0x60124D1")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x04014AE0 RID: 84704
		[Token(Token = "0x4014AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[SerializeField]
		[Group("AttachListener")]
		private AttachListenerToTileAbility.AttachEffectSetting[] _effectSettings;

		// Token: 0x04014AE1 RID: 84705
		[Token(Token = "0x4014AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[SerializeField]
		[Group("AttachListener")]
		private bool _dontCreateNewEffectWhenCastedTimesSame;

		// Token: 0x04014AE2 RID: 84706
		[Token(Token = "0x4014AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x209")]
		[SerializeField]
		[Group("AttachListener")]
		private bool _playAudioWhenEffectChanged;

		// Token: 0x04014AE3 RID: 84707
		[Token(Token = "0x4014AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		[Group("AttachListener")]
		private string _audioSignal;

		// Token: 0x04014AE4 RID: 84708
		[Token(Token = "0x4014AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[SerializeField]
		[Group("AttachListener")]
		private bool _fixCastToTarget;

		// Token: 0x04014AE5 RID: 84709
		[Token(Token = "0x4014AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
		[SerializeField]
		[Group("AttachListener")]
		private bool _fixCastDirectly;

		// Token: 0x04014AE6 RID: 84710
		[Token(Token = "0x4014AE6")]
		private const int DEFAULT_MAX_CASTED_TIMES = 100000;

		// Token: 0x04014AE7 RID: 84711
		[Token(Token = "0x4014AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		protected AttachListenerToTileAbility.AttachableTileListener[] m_listeners;

		// Token: 0x04014AE8 RID: 84712
		[Token(Token = "0x4014AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		protected Dictionary<Tile, int> m_tileCastedStatus;

		// Token: 0x04014AE9 RID: 84713
		[Token(Token = "0x4014AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Dictionary<Tile, ObjectPtr<Effect>> m_castedTileEffect;

		// Token: 0x04014AEA RID: 84714
		[Token(Token = "0x4014AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		protected int m_maxCastedTimes;

		// Token: 0x04014AEB RID: 84715
		[Token(Token = "0x4014AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tileCastedStatus;

		// Token: 0x04014AEC RID: 84716
		[Token(Token = "0x4014AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIsDamageOrHealSource;

		// Token: 0x04014AED RID: 84717
		[Token(Token = "0x4014AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x04014AEE RID: 84718
		[Token(Token = "0x4014AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014AEF RID: 84719
		[Token(Token = "0x4014AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014AF0 RID: 84720
		[Token(Token = "0x4014AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04014AF1 RID: 84721
		[Token(Token = "0x4014AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014AF2 RID: 84722
		[Token(Token = "0x4014AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014AF3 RID: 84723
		[Token(Token = "0x4014AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014AF4 RID: 84724
		[Token(Token = "0x4014AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014AF5 RID: 84725
		[Token(Token = "0x4014AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014AF6 RID: 84726
		[Token(Token = "0x4014AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014AF7 RID: 84727
		[Token(Token = "0x4014AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ClearListeners;

		// Token: 0x04014AF8 RID: 84728
		[Token(Token = "0x4014AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ClearEffects;

		// Token: 0x04014AF9 RID: 84729
		[Token(Token = "0x4014AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x04014AFA RID: 84730
		[Token(Token = "0x4014AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x04014AFB RID: 84731
		[Token(Token = "0x4014AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_AttachToTile;

		// Token: 0x04014AFC RID: 84732
		[Token(Token = "0x4014AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HoldCastedEffectOnTile;

		// Token: 0x04014AFD RID: 84733
		[Token(Token = "0x4014AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnUnitReborn;

		// Token: 0x04014AFE RID: 84734
		[Token(Token = "0x4014AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnRallyPointReborn;

		// Token: 0x04014AFF RID: 84735
		[Token(Token = "0x4014AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnTileOptionsChangedViaMode;

		// Token: 0x04014B00 RID: 84736
		[Token(Token = "0x4014B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetTileCastedTimes;

		// Token: 0x04014B01 RID: 84737
		[Token(Token = "0x4014B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RefreshTileStatus;

		// Token: 0x04014B02 RID: 84738
		[Token(Token = "0x4014B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SyncStatusFromOtherAbility;

		// Token: 0x04014B03 RID: 84739
		[Token(Token = "0x4014B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_RemoveTileListener;

		// Token: 0x04014B04 RID: 84740
		[Token(Token = "0x4014B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002ADE RID: 10974
		[Token(Token = "0x2002ADE")]
		[Serializable]
		public struct AttachEffectSetting
		{
			// Token: 0x04014B05 RID: 84741
			[Token(Token = "0x4014B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string effectKey;

			// Token: 0x04014B06 RID: 84742
			[Token(Token = "0x4014B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int castedTimeThreshold;

			// Token: 0x04014B07 RID: 84743
			[Token(Token = "0x4014B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string audioSignal;

			// Token: 0x04014B08 RID: 84744
			[Token(Token = "0x4014B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string startEffectKey;
		}

		// Token: 0x02002ADF RID: 10975
		[Token(Token = "0x2002ADF")]
		public abstract class AttachableTileListener : MonoBehaviour, ITileListener, IHotfixable
		{
			// Token: 0x1700281E RID: 10270
			// (get) Token: 0x060124D2 RID: 74962 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060124D3 RID: 74963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700281E")]
			private protected AttachListenerToTileAbility ability
			{
				[Token(Token = "0x60124D2")]
				[Address(RVA = "0xA513F0", Offset = "0xA4FFF0", VA = "0x180A513F0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x60124D3")]
				[Address(RVA = "0xA51500", Offset = "0xA50100", VA = "0x180A51500")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700281F RID: 10271
			// (get) Token: 0x060124D4 RID: 74964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700281F")]
			protected Entity owner
			{
				[Token(Token = "0x60124D4")]
				[Address(RVA = "0xA51450", Offset = "0xA50050", VA = "0x180A51450")]
				get
				{
					return null;
				}
			}

			// Token: 0x060124D5 RID: 74965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60124D5")]
			[Address(RVA = "0xA51080", Offset = "0xA4FC80", VA = "0x180A51080")]
			public void Init(AttachListenerToTileAbility ability)
			{
			}

			// Token: 0x060124D6 RID: 74966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60124D6")]
			[Address(RVA = "0xA51010", Offset = "0xA4FC10", VA = "0x180A51010", Slot = "7")]
			public virtual void DoSetData(Ability.Options options)
			{
			}

			// Token: 0x060124D7 RID: 74967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60124D7")]
			[Address(RVA = "0xA511B0", Offset = "0xA4FDB0", VA = "0x180A511B0", Slot = "8")]
			public virtual void OnDetached()
			{
			}

			// Token: 0x060124D8 RID: 74968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60124D8")]
			[Address(RVA = "0xA51130", Offset = "0xA4FD30", VA = "0x180A51130", Slot = "9")]
			public virtual void OnCasted(Tile tile, int times)
			{
			}

			// Token: 0x060124D9 RID: 74969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60124D9")]
			[Address(RVA = "0xA51330", Offset = "0xA4FF30", VA = "0x180A51330", Slot = "10")]
			public virtual void OnRefresh(Tile tile)
			{
			}

			// Token: 0x060124DA RID: 74970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60124DA")]
			[Address(RVA = "0xA512D0", Offset = "0xA4FED0", VA = "0x180A512D0", Slot = "11")]
			public virtual void OnLocatedCharacterUpdate(Character character)
			{
			}

			// Token: 0x060124DB RID: 74971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60124DB")]
			[Address(RVA = "0xA51210", Offset = "0xA4FE10", VA = "0x180A51210", Slot = "12")]
			public virtual void OnEntityEnter(Entity entity)
			{
			}

			// Token: 0x060124DC RID: 74972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60124DC")]
			[Address(RVA = "0xA51270", Offset = "0xA4FE70", VA = "0x180A51270", Slot = "13")]
			public virtual void OnEntityLeave(Entity entity)
			{
			}

			// Token: 0x060124DD RID: 74973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60124DD")]
			[Address(RVA = "0xA51390", Offset = "0xA4FF90", VA = "0x180A51390")]
			protected AttachableTileListener()
			{
			}

			// Token: 0x04014B0A RID: 84746
			[Token(Token = "0x4014B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_ability;

			// Token: 0x04014B0B RID: 84747
			[Token(Token = "0x4014B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_ability;

			// Token: 0x04014B0C RID: 84748
			[Token(Token = "0x4014B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x04014B0D RID: 84749
			[Token(Token = "0x4014B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04014B0E RID: 84750
			[Token(Token = "0x4014B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_DoSetData;

			// Token: 0x04014B0F RID: 84751
			[Token(Token = "0x4014B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnDetached;

			// Token: 0x04014B10 RID: 84752
			[Token(Token = "0x4014B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnCasted;

			// Token: 0x04014B11 RID: 84753
			[Token(Token = "0x4014B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnRefresh;

			// Token: 0x04014B12 RID: 84754
			[Token(Token = "0x4014B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnLocatedCharacterUpdate;

			// Token: 0x04014B13 RID: 84755
			[Token(Token = "0x4014B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnEntityEnter;

			// Token: 0x04014B14 RID: 84756
			[Token(Token = "0x4014B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnEntityLeave;

			// Token: 0x04014B15 RID: 84757
			[Token(Token = "0x4014B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
