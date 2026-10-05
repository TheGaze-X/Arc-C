using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002080 RID: 8320
	[Token(Token = "0x2002080")]
	public class CrossDayCondTriggerHolder : TrackTriggerHolder<CrossDayCondTrigger>, IVersionTrackTriggerHolder
	{
		// Token: 0x0600CD32 RID: 52530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD32")]
		[Address(RVA = "0x34FC8C0", Offset = "0x34FB4C0", VA = "0x1834FC8C0", Slot = "7")]
		protected override void OnTriggerAdded(CrossDayCondTrigger trigger)
		{
		}

		// Token: 0x0600CD33 RID: 52531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD33")]
		[Address(RVA = "0x34FC860", Offset = "0x34FB460", VA = "0x1834FC860", Slot = "8")]
		public void OnEnterGame()
		{
		}

		// Token: 0x0600CD34 RID: 52532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD34")]
		[Address(RVA = "0x34FC800", Offset = "0x34FB400", VA = "0x1834FC800", Slot = "9")]
		public void OnCrossDay()
		{
		}

		// Token: 0x0600CD35 RID: 52533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD35")]
		[Address(RVA = "0x34FCCF0", Offset = "0x34FB8F0", VA = "0x1834FCCF0")]
		private void _UpdateTracks()
		{
		}

		// Token: 0x0600CD36 RID: 52534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD36")]
		[Address(RVA = "0x34FC9C0", Offset = "0x34FB5C0", VA = "0x1834FC9C0")]
		private void _InitCrossDayTypesIfNot()
		{
		}

		// Token: 0x0600CD37 RID: 52535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD37")]
		[Address(RVA = "0x34FCA90", Offset = "0x34FB690", VA = "0x1834FCA90")]
		private void _LoadTypeDataFromActivity()
		{
		}

		// Token: 0x0600CD38 RID: 52536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD38")]
		[Address(RVA = "0x34FD0A0", Offset = "0x34FBCA0", VA = "0x1834FD0A0")]
		public CrossDayCondTriggerHolder()
		{
		}

		// Token: 0x0400D875 RID: 55413
		[Token(Token = "0x400D875")]
		public const string CROSS_DAY_TRACK_TYPE_FORMAT = "CROSS_DAY_{0}";

		// Token: 0x0400D876 RID: 55414
		[Token(Token = "0x400D876")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, CrossDayCondTriggerHolder.TriggerType> m_triggerTypes;

		// Token: 0x0400D877 RID: 55415
		[Token(Token = "0x400D877")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, CrossDayTrackTypeData> m_typeTrackDataMap;

		// Token: 0x0400D878 RID: 55416
		[Token(Token = "0x400D878")]
		[FieldOffset(Offset = "0x30")]
		private bool m_typeInited;

		// Token: 0x0400D879 RID: 55417
		[Token(Token = "0x400D879")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTriggerAdded;

		// Token: 0x0400D87A RID: 55418
		[Token(Token = "0x400D87A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnterGame;

		// Token: 0x0400D87B RID: 55419
		[Token(Token = "0x400D87B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCrossDay;

		// Token: 0x0400D87C RID: 55420
		[Token(Token = "0x400D87C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateTracks;

		// Token: 0x0400D87D RID: 55421
		[Token(Token = "0x400D87D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitCrossDayTypesIfNot;

		// Token: 0x0400D87E RID: 55422
		[Token(Token = "0x400D87E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadTypeDataFromActivity;

		// Token: 0x0400D87F RID: 55423
		[Token(Token = "0x400D87F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002081 RID: 8321
		[Token(Token = "0x2002081")]
		private class TriggerType
		{
			// Token: 0x0600CD39 RID: 52537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CD39")]
			[Address(RVA = "0x3505A90", Offset = "0x3504690", VA = "0x183505A90")]
			public TriggerType()
			{
			}

			// Token: 0x0400D880 RID: 55424
			[Token(Token = "0x400D880")]
			[FieldOffset(Offset = "0x10")]
			public long startTs;

			// Token: 0x0400D881 RID: 55425
			[Token(Token = "0x400D881")]
			[FieldOffset(Offset = "0x18")]
			public long expireTs;

			// Token: 0x0400D882 RID: 55426
			[Token(Token = "0x400D882")]
			[FieldOffset(Offset = "0x20")]
			public List<CrossDayCondTrigger> triggers;
		}
	}
}
