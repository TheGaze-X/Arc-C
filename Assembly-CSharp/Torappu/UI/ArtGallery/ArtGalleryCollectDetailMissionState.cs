using System;
using Il2CppDummyDll;
using Torappu.UI.ArtMagazine;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065D1 RID: 26065
	[Token(Token = "0x20065D1")]
	public class ArtGalleryCollectDetailMissionState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x0602575B RID: 153435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602575B")]
		[Address(RVA = "0x2057AA0", Offset = "0x20566A0", VA = "0x182057AA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602575C RID: 153436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602575C")]
		[Address(RVA = "0x2057B00", Offset = "0x2056700", VA = "0x182057B00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602575D RID: 153437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602575D")]
		[Address(RVA = "0x2057F90", Offset = "0x2056B90", VA = "0x182057F90", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602575E RID: 153438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602575E")]
		[Address(RVA = "0x2057C40", Offset = "0x2056840", VA = "0x182057C40", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602575F RID: 153439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602575F")]
		[Address(RVA = "0x2058500", Offset = "0x2057100", VA = "0x182058500")]
		private void _OnClaimMissionRewards(ValueBundle msg)
		{
		}

		// Token: 0x06025760 RID: 153440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025760")]
		[Address(RVA = "0x2058010", Offset = "0x2056C10", VA = "0x182058010")]
		private void _ClaimCollectionRewards(string setId, string missionId)
		{
		}

		// Token: 0x06025761 RID: 153441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025761")]
		[Address(RVA = "0x20587A0", Offset = "0x20573A0", VA = "0x1820587A0")]
		private void _OnMissionRewardClaimed(ArtMagazineGetCollectionRewardsResponse response)
		{
		}

		// Token: 0x06025762 RID: 153442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025762")]
		[Address(RVA = "0x2058620", Offset = "0x2057220", VA = "0x182058620")]
		private void _OnMagazineLeafPreview(string leafId)
		{
		}

		// Token: 0x06025763 RID: 153443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025763")]
		[Address(RVA = "0x2058240", Offset = "0x2056E40", VA = "0x182058240")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025764 RID: 153444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025764")]
		[Address(RVA = "0x2058330", Offset = "0x2056F30", VA = "0x182058330")]
		private void _LoadData()
		{
		}

		// Token: 0x06025765 RID: 153445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025765")]
		[Address(RVA = "0x20589A0", Offset = "0x20575A0", VA = "0x1820589A0")]
		private void _UpdateData()
		{
		}

		// Token: 0x06025766 RID: 153446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025766")]
		[Address(RVA = "0x2058AF0", Offset = "0x20576F0", VA = "0x182058AF0")]
		public ArtGalleryCollectDetailMissionState()
		{
		}

		// Token: 0x06025767 RID: 153447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025767")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06025768 RID: 153448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025768")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403492E RID: 215342
		[Token(Token = "0x403492E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ArtGalleryCollectDetailMissionView _view;

		// Token: 0x0403492F RID: 215343
		[Token(Token = "0x403492F")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04034930 RID: 215344
		[Token(Token = "0x4034930")]
		[FieldOffset(Offset = "0x80")]
		private ArtGalleryCollectDetailMissionStateBean m_stateBean;

		// Token: 0x04034931 RID: 215345
		[Token(Token = "0x4034931")]
		public const int MSG_MAGAZINE_LEAF_PREVIEW = 0;

		// Token: 0x04034932 RID: 215346
		[Token(Token = "0x4034932")]
		public const int MSG_CLAIM_MISSION_REWARDS = 1;

		// Token: 0x04034933 RID: 215347
		[Token(Token = "0x4034933")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034934 RID: 215348
		[Token(Token = "0x4034934")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04034935 RID: 215349
		[Token(Token = "0x4034935")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04034936 RID: 215350
		[Token(Token = "0x4034936")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04034937 RID: 215351
		[Token(Token = "0x4034937")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnClaimMissionRewards;

		// Token: 0x04034938 RID: 215352
		[Token(Token = "0x4034938")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClaimCollectionRewards;

		// Token: 0x04034939 RID: 215353
		[Token(Token = "0x4034939")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnMissionRewardClaimed;

		// Token: 0x0403493A RID: 215354
		[Token(Token = "0x403493A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnMagazineLeafPreview;

		// Token: 0x0403493B RID: 215355
		[Token(Token = "0x403493B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403493C RID: 215356
		[Token(Token = "0x403493C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0403493D RID: 215357
		[Token(Token = "0x403493D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x0403493E RID: 215358
		[Token(Token = "0x403493E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
