using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EE3 RID: 24291
	[Token(Token = "0x2005EE3")]
	public class CharacterInfoSpCharMissionState : PopupFloatState
	{
		// Token: 0x0602330B RID: 144139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602330B")]
		[Address(RVA = "0x1DB1BF0", Offset = "0x1DB07F0", VA = "0x181DB1BF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602330C RID: 144140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602330C")]
		[Address(RVA = "0x1DB1C50", Offset = "0x1DB0850", VA = "0x181DB1C50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602330D RID: 144141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602330D")]
		[Address(RVA = "0x1DB2320", Offset = "0x1DB0F20", VA = "0x181DB2320")]
		private void _EventOnJumpToCharClicked(SpCharMissionCharViewModel charModel)
		{
		}

		// Token: 0x0602330E RID: 144142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602330E")]
		[Address(RVA = "0x1DB20F0", Offset = "0x1DB0CF0", VA = "0x181DB20F0")]
		private void _EventOnGetRewardClicked(SpCharMissionObjViewModel missionModel)
		{
		}

		// Token: 0x0602330F RID: 144143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602330F")]
		[Address(RVA = "0x1DB2400", Offset = "0x1DB1000", VA = "0x181DB2400")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023310 RID: 144144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023310")]
		[Address(RVA = "0x1DB2540", Offset = "0x1DB1140", VA = "0x181DB2540")]
		private IEnumerator _ReceiveItemsCoroutine(List<ItemGet> items)
		{
			return null;
		}

		// Token: 0x06023311 RID: 144145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023311")]
		[Address(RVA = "0x1DB1FF0", Offset = "0x1DB0BF0", VA = "0x181DB1FF0")]
		private void _ConsumeSpCharMissionNew()
		{
		}

		// Token: 0x06023312 RID: 144146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023312")]
		[Address(RVA = "0x1DB25F0", Offset = "0x1DB11F0", VA = "0x181DB25F0")]
		private IEnumerator<KeyValuePair<string, TrackPointCacheGroup>> _TraceSpCharsMissionNew()
		{
			return null;
		}

		// Token: 0x06023313 RID: 144147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023313")]
		[Address(RVA = "0x1DB26A0", Offset = "0x1DB12A0", VA = "0x181DB26A0")]
		public CharacterInfoSpCharMissionState()
		{
		}

		// Token: 0x06023315 RID: 144149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023315")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040307E4 RID: 198628
		[Token(Token = "0x40307E4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CharacterInfoSpCharMissionView _view;

		// Token: 0x040307E5 RID: 198629
		[Token(Token = "0x40307E5")]
		[FieldOffset(Offset = "0x78")]
		private CharacterInfoSpCharMissionStateBean m_stateBean;

		// Token: 0x040307E6 RID: 198630
		[Token(Token = "0x40307E6")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x040307E7 RID: 198631
		[Token(Token = "0x40307E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040307E8 RID: 198632
		[Token(Token = "0x40307E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040307E9 RID: 198633
		[Token(Token = "0x40307E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnJumpToCharClicked;

		// Token: 0x040307EA RID: 198634
		[Token(Token = "0x40307EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnGetRewardClicked;

		// Token: 0x040307EB RID: 198635
		[Token(Token = "0x40307EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040307EC RID: 198636
		[Token(Token = "0x40307EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x040307ED RID: 198637
		[Token(Token = "0x40307ED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConsumeSpCharMissionNew;

		// Token: 0x040307EE RID: 198638
		[Token(Token = "0x40307EE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TraceSpCharsMissionNew;

		// Token: 0x040307EF RID: 198639
		[Token(Token = "0x40307EF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
