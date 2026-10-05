using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Scripts.UI.Squad;
using Torappu.UI;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E84 RID: 28292
	[Token(Token = "0x2006E84")]
	public class VecBreakSquadStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005F10 RID: 24336
		// (get) Token: 0x0602843C RID: 164924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F10")]
		public SquadGroupViewProperty squadGroupProp
		{
			[Token(Token = "0x602843C")]
			[Address(RVA = "0x23A53F0", Offset = "0x23A3FF0", VA = "0x1823A53F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F11 RID: 24337
		// (get) Token: 0x0602843D RID: 164925 RVA: 0x000D1178 File Offset: 0x000CF378
		// (set) Token: 0x0602843E RID: 164926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F11")]
		public ProfessionCategory assistProfession
		{
			[Token(Token = "0x602843D")]
			[Address(RVA = "0x23A5310", Offset = "0x23A3F10", VA = "0x1823A5310")]
			get
			{
				return ProfessionCategory.NONE;
			}
			[Token(Token = "0x602843E")]
			[Address(RVA = "0x23A5450", Offset = "0x23A4050", VA = "0x1823A5450")]
			set
			{
			}
		}

		// Token: 0x17005F12 RID: 24338
		// (get) Token: 0x0602843F RID: 164927 RVA: 0x000D1190 File Offset: 0x000CF390
		// (set) Token: 0x06028440 RID: 164928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F12")]
		public VecBreakSquadStateBean.FriendAssistDataStruct friendDataCache
		{
			[Token(Token = "0x602843F")]
			[Address(RVA = "0x23A5370", Offset = "0x23A3F70", VA = "0x1823A5370")]
			get
			{
				return default(VecBreakSquadStateBean.FriendAssistDataStruct);
			}
			[Token(Token = "0x6028440")]
			[Address(RVA = "0x23A54C0", Offset = "0x23A40C0", VA = "0x1823A54C0")]
			set
			{
			}
		}

		// Token: 0x06028441 RID: 164929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028441")]
		[Address(RVA = "0x23A3DD0", Offset = "0x23A29D0", VA = "0x1823A3DD0")]
		public void LoadData(VecBreakSquadPage.InputParams inputParams)
		{
		}

		// Token: 0x06028442 RID: 164930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028442")]
		[Address(RVA = "0x23A4290", Offset = "0x23A2E90", VA = "0x1823A4290")]
		public void RefreshData()
		{
		}

		// Token: 0x06028443 RID: 164931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028443")]
		[Address(RVA = "0x23A43E0", Offset = "0x23A2FE0", VA = "0x1823A43E0")]
		public void SaveAllSquadDataToLocalCache()
		{
		}

		// Token: 0x06028444 RID: 164932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028444")]
		[Address(RVA = "0x23A44C0", Offset = "0x23A30C0", VA = "0x1823A44C0")]
		public SquadViewModel TryGetSquadViewModel()
		{
			return null;
		}

		// Token: 0x06028445 RID: 164933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028445")]
		[Address(RVA = "0x23A3BB0", Offset = "0x23A27B0", VA = "0x1823A3BB0")]
		public void ClearAssistCharIfConflict(IList<SquadItemStruct> squadMembers)
		{
		}

		// Token: 0x06028446 RID: 164934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028446")]
		[Address(RVA = "0x23A37A0", Offset = "0x23A23A0", VA = "0x1823A37A0")]
		public void ApplyToFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
		}

		// Token: 0x06028447 RID: 164935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028447")]
		[Address(RVA = "0x23A4110", Offset = "0x23A2D10", VA = "0x1823A4110")]
		public void ReceiveFromFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
		}

		// Token: 0x06028448 RID: 164936 RVA: 0x000D11A8 File Offset: 0x000CF3A8
		[Token(Token = "0x6028448")]
		[Address(RVA = "0x23A38B0", Offset = "0x23A24B0", VA = "0x1823A38B0")]
		public bool CheckIfCharRuneValid(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x06028449 RID: 164937 RVA: 0x000D11C0 File Offset: 0x000CF3C0
		[Token(Token = "0x6028449")]
		[Address(RVA = "0x23A3970", Offset = "0x23A2570", VA = "0x1823A3970")]
		public bool CheckIfFriendLegal()
		{
			return default(bool);
		}

		// Token: 0x0602844A RID: 164938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602844A")]
		[Address(RVA = "0x23A4560", Offset = "0x23A3160", VA = "0x1823A4560")]
		public void TryRestrictSquadMembers()
		{
		}

		// Token: 0x0602844B RID: 164939 RVA: 0x000D11D8 File Offset: 0x000CF3D8
		[Token(Token = "0x602844B")]
		[Address(RVA = "0x23A3FC0", Offset = "0x23A2BC0", VA = "0x1823A3FC0")]
		public int MaxNum4CharSelect()
		{
			return 0;
		}

		// Token: 0x0602844C RID: 164940 RVA: 0x000D11F0 File Offset: 0x000CF3F0
		[Token(Token = "0x602844C")]
		[Address(RVA = "0x23A3C50", Offset = "0x23A2850", VA = "0x1823A3C50")]
		public bool IsCurrentSquadEmpty()
		{
			return default(bool);
		}

		// Token: 0x0602844D RID: 164941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602844D")]
		[Address(RVA = "0x23A5150", Offset = "0x23A3D50", VA = "0x1823A5150")]
		private void _TryRefreshData()
		{
		}

		// Token: 0x0602844E RID: 164942 RVA: 0x000D1208 File Offset: 0x000CF408
		[Token(Token = "0x602844E")]
		[Address(RVA = "0x23A49F0", Offset = "0x23A35F0", VA = "0x1823A49F0")]
		private int _GetCurSquadValidMemberNum()
		{
			return 0;
		}

		// Token: 0x0602844F RID: 164943 RVA: 0x000D1220 File Offset: 0x000CF420
		[Token(Token = "0x602844F")]
		[Address(RVA = "0x23A4F10", Offset = "0x23A3B10", VA = "0x1823A4F10")]
		private SquadMaxNumInfo _GetSquadMaxRawNumInfo()
		{
			return default(SquadMaxNumInfo);
		}

		// Token: 0x06028450 RID: 164944 RVA: 0x000D1238 File Offset: 0x000CF438
		[Token(Token = "0x6028450")]
		[Address(RVA = "0x23A4C40", Offset = "0x23A3840", VA = "0x1823A4C40")]
		private int _GetSquadAssistNum()
		{
			return 0;
		}

		// Token: 0x06028451 RID: 164945 RVA: 0x000D1250 File Offset: 0x000CF450
		[Token(Token = "0x6028451")]
		[Address(RVA = "0x23A4E00", Offset = "0x23A3A00", VA = "0x1823A4E00")]
		private int _GetSquadMaxCharCount()
		{
			return 0;
		}

		// Token: 0x06028452 RID: 164946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028452")]
		[Address(RVA = "0x23A4AC0", Offset = "0x23A36C0", VA = "0x1823A4AC0")]
		private ExternalRuneChecker _GetExternalRuneChecker()
		{
			return null;
		}

		// Token: 0x06028453 RID: 164947 RVA: 0x000D1268 File Offset: 0x000CF468
		[Token(Token = "0x6028453")]
		[Address(RVA = "0x23A4E90", Offset = "0x23A3A90", VA = "0x1823A4E90")]
		private SquadMaxNumInfo _GetSquadMaxLimitNumInfo()
		{
			return default(SquadMaxNumInfo);
		}

		// Token: 0x06028454 RID: 164948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028454")]
		[Address(RVA = "0x23A5260", Offset = "0x23A3E60", VA = "0x1823A5260")]
		public VecBreakSquadStateBean()
		{
		}

		// Token: 0x040393A4 RID: 234404
		[Token(Token = "0x40393A4")]
		[FieldOffset(Offset = "0x10")]
		private SquadGroupViewProperty m_squadProperty;

		// Token: 0x040393A5 RID: 234405
		[Token(Token = "0x40393A5")]
		[FieldOffset(Offset = "0x18")]
		private ProfessionCategory m_assistProfession;

		// Token: 0x040393A6 RID: 234406
		[Token(Token = "0x40393A6")]
		[FieldOffset(Offset = "0x20")]
		private VecBreakSquadStateBean.FriendAssistDataStruct m_friendDataCache;

		// Token: 0x040393A7 RID: 234407
		[Token(Token = "0x40393A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadGroupProp;

		// Token: 0x040393A8 RID: 234408
		[Token(Token = "0x40393A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_assistProfession;

		// Token: 0x040393A9 RID: 234409
		[Token(Token = "0x40393A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_assistProfession;

		// Token: 0x040393AA RID: 234410
		[Token(Token = "0x40393AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_friendDataCache;

		// Token: 0x040393AB RID: 234411
		[Token(Token = "0x40393AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_friendDataCache;

		// Token: 0x040393AC RID: 234412
		[Token(Token = "0x40393AC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040393AD RID: 234413
		[Token(Token = "0x40393AD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040393AE RID: 234414
		[Token(Token = "0x40393AE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SaveAllSquadDataToLocalCache;

		// Token: 0x040393AF RID: 234415
		[Token(Token = "0x40393AF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryGetSquadViewModel;

		// Token: 0x040393B0 RID: 234416
		[Token(Token = "0x40393B0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ClearAssistCharIfConflict;

		// Token: 0x040393B1 RID: 234417
		[Token(Token = "0x40393B1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ApplyToFriendAssistBean;

		// Token: 0x040393B2 RID: 234418
		[Token(Token = "0x40393B2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ReceiveFromFriendAssistBean;

		// Token: 0x040393B3 RID: 234419
		[Token(Token = "0x40393B3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckIfCharRuneValid;

		// Token: 0x040393B4 RID: 234420
		[Token(Token = "0x40393B4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckIfFriendLegal;

		// Token: 0x040393B5 RID: 234421
		[Token(Token = "0x40393B5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TryRestrictSquadMembers;

		// Token: 0x040393B6 RID: 234422
		[Token(Token = "0x40393B6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_MaxNum4CharSelect;

		// Token: 0x040393B7 RID: 234423
		[Token(Token = "0x40393B7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsCurrentSquadEmpty;

		// Token: 0x040393B8 RID: 234424
		[Token(Token = "0x40393B8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TryRefreshData;

		// Token: 0x040393B9 RID: 234425
		[Token(Token = "0x40393B9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetCurSquadValidMemberNum;

		// Token: 0x040393BA RID: 234426
		[Token(Token = "0x40393BA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetSquadMaxRawNumInfo;

		// Token: 0x040393BB RID: 234427
		[Token(Token = "0x40393BB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetSquadAssistNum;

		// Token: 0x040393BC RID: 234428
		[Token(Token = "0x40393BC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetSquadMaxCharCount;

		// Token: 0x040393BD RID: 234429
		[Token(Token = "0x40393BD")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetExternalRuneChecker;

		// Token: 0x040393BE RID: 234430
		[Token(Token = "0x40393BE")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetSquadMaxLimitNumInfo;

		// Token: 0x040393BF RID: 234431
		[Token(Token = "0x40393BF")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E85 RID: 28293
		[Token(Token = "0x2006E85")]
		private class SquadConstrainPolicy : SquadGroupConstrainPolicy
		{
			// Token: 0x06028455 RID: 164949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028455")]
			[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
			public SquadConstrainPolicy(VecBreakSquadStateBean closure)
			{
			}

			// Token: 0x06028456 RID: 164950 RVA: 0x000D1280 File Offset: 0x000CF480
			[Token(Token = "0x6028456")]
			[Address(RVA = "0x2397160", Offset = "0x2395D60", VA = "0x182397160", Slot = "4")]
			public override bool CheckIfAssistLocked()
			{
				return default(bool);
			}

			// Token: 0x06028457 RID: 164951 RVA: 0x000D1298 File Offset: 0x000CF498
			[Token(Token = "0x6028457")]
			[Address(RVA = "0x23972D0", Offset = "0x2395ED0", VA = "0x1823972D0", Slot = "5")]
			public override bool CheckIfSquadSlotLocked(SquadViewModel squad, int index)
			{
				return default(bool);
			}

			// Token: 0x040393C0 RID: 234432
			[Token(Token = "0x40393C0")]
			[FieldOffset(Offset = "0x10")]
			private VecBreakSquadStateBean m_closure;
		}

		// Token: 0x02006E86 RID: 28294
		[Token(Token = "0x2006E86")]
		public struct FriendAssistDataStruct
		{
			// Token: 0x040393C1 RID: 234433
			[Token(Token = "0x40393C1")]
			[FieldOffset(Offset = "0x0")]
			public GetFriendAssistCharListResponse friendAssistResp;

			// Token: 0x040393C2 RID: 234434
			[Token(Token = "0x40393C2")]
			[FieldOffset(Offset = "0x8")]
			public bool isFromRemote;
		}
	}
}
