using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BFB RID: 11259
	[Token(Token = "0x2002BFB")]
	public class SelectTileEffectEmitter : AbstractEffectEmitter
	{
		// Token: 0x06013040 RID: 77888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013040")]
		[Address(RVA = "0xAEA880", Offset = "0xAE9480", VA = "0x180AEA880", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013041 RID: 77889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013041")]
		[Address(RVA = "0xAEA6D0", Offset = "0xAE92D0", VA = "0x180AEA6D0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013042 RID: 77890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013042")]
		[Address(RVA = "0xAEA660", Offset = "0xAE9260", VA = "0x180AEA660", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06013043 RID: 77891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013043")]
		[Address(RVA = "0xAEA5E0", Offset = "0xAE91E0", VA = "0x180AEA5E0", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06013044 RID: 77892 RVA: 0x000745C8 File Offset: 0x000727C8
		[Token(Token = "0x6013044")]
		[Address(RVA = "0xAEA9B0", Offset = "0xAE95B0", VA = "0x180AEA9B0")]
		protected bool TryGetEffect(out string[] effect)
		{
			return default(bool);
		}

		// Token: 0x06013045 RID: 77893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013045")]
		[Address(RVA = "0xAEA4E0", Offset = "0xAE90E0", VA = "0x180AEA4E0", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06013046 RID: 77894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013046")]
		[Address(RVA = "0xAEB060", Offset = "0xAE9C60", VA = "0x180AEB060")]
		private void _ClearEffects()
		{
		}

		// Token: 0x06013047 RID: 77895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013047")]
		[Address(RVA = "0xAEB200", Offset = "0xAE9E00", VA = "0x180AEB200")]
		public SelectTileEffectEmitter()
		{
		}

		// Token: 0x06013049 RID: 77897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013049")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0601304A RID: 77898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601304A")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0601304B RID: 77899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601304B")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601304C RID: 77900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601304C")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x040157A0 RID: 87968
		[Token(Token = "0x40157A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TargetSelector _selector;

		// Token: 0x040157A1 RID: 87969
		[Token(Token = "0x40157A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectTileEffectEmitter.DirectionType _directionType;

		// Token: 0x040157A2 RID: 87970
		[Token(Token = "0x40157A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string[] _castEffectsUp;

		// Token: 0x040157A3 RID: 87971
		[Token(Token = "0x40157A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] _castEffectsDown;

		// Token: 0x040157A4 RID: 87972
		[Token(Token = "0x40157A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string[] _castEffectsLeft;

		// Token: 0x040157A5 RID: 87973
		[Token(Token = "0x40157A5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string[] _castEffectsRight;

		// Token: 0x040157A6 RID: 87974
		[Token(Token = "0x40157A6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AbilityStandard.Event _playCastEffectOnEvent;

		// Token: 0x040157A7 RID: 87975
		[Token(Token = "0x40157A7")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private AbilityStandard.Event _stopCastEffectOnEvent;

		// Token: 0x040157A8 RID: 87976
		[Token(Token = "0x40157A8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _castOnce;

		// Token: 0x040157A9 RID: 87977
		[Token(Token = "0x40157A9")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool _holdByOwner;

		// Token: 0x040157AA RID: 87978
		[Token(Token = "0x40157AA")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_hasCast;

		// Token: 0x040157AB RID: 87979
		[Token(Token = "0x40157AB")]
		[FieldOffset(Offset = "0x60")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x040157AC RID: 87980
		[Token(Token = "0x40157AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040157AD RID: 87981
		[Token(Token = "0x40157AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040157AE RID: 87982
		[Token(Token = "0x40157AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040157AF RID: 87983
		[Token(Token = "0x40157AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x040157B0 RID: 87984
		[Token(Token = "0x40157B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetEffect;

		// Token: 0x040157B1 RID: 87985
		[Token(Token = "0x40157B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040157B2 RID: 87986
		[Token(Token = "0x40157B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearEffects;

		// Token: 0x040157B3 RID: 87987
		[Token(Token = "0x40157B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BFC RID: 11260
		[Token(Token = "0x2002BFC")]
		public enum DirectionType
		{
			// Token: 0x040157B5 RID: 87989
			[Token(Token = "0x40157B5")]
			NONE,
			// Token: 0x040157B6 RID: 87990
			[Token(Token = "0x40157B6")]
			L_OR_R,
			// Token: 0x040157B7 RID: 87991
			[Token(Token = "0x40157B7")]
			U_OR_D,
			// Token: 0x040157B8 RID: 87992
			[Token(Token = "0x40157B8")]
			FOUR_DIR,
			// Token: 0x040157B9 RID: 87993
			[Token(Token = "0x40157B9")]
			UD_OR_LR,
			// Token: 0x040157BA RID: 87994
			[Token(Token = "0x40157BA")]
			FOUR_DIR_FIXED,
			// Token: 0x040157BB RID: 87995
			[Token(Token = "0x40157BB")]
			L_OR_R_NOT_UD
		}
	}
}
