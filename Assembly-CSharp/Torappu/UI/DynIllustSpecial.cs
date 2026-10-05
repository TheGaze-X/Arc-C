using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using Torappu.LipSync;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034D1 RID: 13521
	[Token(Token = "0x20034D1")]
	[RequireComponent(typeof(LipSyncSpineBlendAnimation))]
	public class DynIllustSpecial : DynIllustBase
	{
		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x060158C9 RID: 88265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032EE")]
		public LipSyncSpineBlendAnimation lipSyncSpineBlendAnimation
		{
			[Token(Token = "0x60158C9")]
			[Address(RVA = "0xE01890", Offset = "0xE00490", VA = "0x180E01890")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x060158CA RID: 88266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032EF")]
		public string skinId
		{
			[Token(Token = "0x60158CA")]
			[Address(RVA = "0xE01C70", Offset = "0xE00870", VA = "0x180E01C70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x060158CB RID: 88267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032F0")]
		public string charId
		{
			[Token(Token = "0x60158CB")]
			[Address(RVA = "0xE01770", Offset = "0xE00370", VA = "0x180E01770")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x060158CC RID: 88268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032F1")]
		public List<string> lipSyncNames
		{
			[Token(Token = "0x60158CC")]
			[Address(RVA = "0xE01830", Offset = "0xE00430", VA = "0x180E01830")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x060158CD RID: 88269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032F2")]
		public List<LipSyncData> lipSyncDatas
		{
			[Token(Token = "0x60158CD")]
			[Address(RVA = "0xE017D0", Offset = "0xE003D0", VA = "0x180E017D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x060158CE RID: 88270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032F3")]
		public List<DynIllustSpecial.VoiceToActionId> voiceToActionIds
		{
			[Token(Token = "0x60158CE")]
			[Address(RVA = "0xE01CD0", Offset = "0xE008D0", VA = "0x180E01CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x060158CF RID: 88271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032F4")]
		public override SkeletonAnimation skeleton
		{
			[Token(Token = "0x60158CF")]
			[Address(RVA = "0xE01C10", Offset = "0xE00810", VA = "0x180E01C10", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x060158D0 RID: 88272 RVA: 0x0008C8B0 File Offset: 0x0008AAB0
		[Token(Token = "0x170032F5")]
		public override float playingActionDur
		{
			[Token(Token = "0x60158D0")]
			[Address(RVA = "0xE018F0", Offset = "0xE004F0", VA = "0x180E018F0", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x060158D1 RID: 88273 RVA: 0x0008C8C8 File Offset: 0x0008AAC8
		[Token(Token = "0x170032F6")]
		public override float playingTime
		{
			[Token(Token = "0x60158D1")]
			[Address(RVA = "0xE01A70", Offset = "0xE00670", VA = "0x180E01A70", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x060158D2 RID: 88274 RVA: 0x0008C8E0 File Offset: 0x0008AAE0
		[Token(Token = "0x170032F7")]
		protected override bool actionDataInitialized
		{
			[Token(Token = "0x60158D2")]
			[Address(RVA = "0xE015F0", Offset = "0xE001F0", VA = "0x180E015F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060158D3 RID: 88275 RVA: 0x0008C8F8 File Offset: 0x0008AAF8
		[Token(Token = "0x60158D3")]
		[Address(RVA = "0xE006A0", Offset = "0xDFF2A0", VA = "0x180E006A0", Slot = "10")]
		protected override bool SupportNormalActionType(DynIllustAction action)
		{
			return default(bool);
		}

		// Token: 0x060158D4 RID: 88276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158D4")]
		[Address(RVA = "0xE00570", Offset = "0xDFF170", VA = "0x180E00570", Slot = "8")]
		public override void SetContext(DynIllustMgr.Context context)
		{
		}

		// Token: 0x060158D5 RID: 88277 RVA: 0x0008C910 File Offset: 0x0008AB10
		[Token(Token = "0x60158D5")]
		[Address(RVA = "0xE00140", Offset = "0xDFED40", VA = "0x180E00140", Slot = "11")]
		public override float GetActionDur(DynIllustBase.DynIllustActionQuery action)
		{
			return 0f;
		}

		// Token: 0x060158D6 RID: 88278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158D6")]
		[Address(RVA = "0xE00090", Offset = "0xDFEC90", VA = "0x180E00090", Slot = "17")]
		public override void ChangeAction(DynIllustBase.DynIllustActionQuery action, float loop)
		{
		}

		// Token: 0x060158D7 RID: 88279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60158D7")]
		[Address(RVA = "0xE00330", Offset = "0xDFEF30", VA = "0x180E00330")]
		public string GetActionNameByVoiceId(string voiceId)
		{
			return null;
		}

		// Token: 0x060158D8 RID: 88280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158D8")]
		[Address(RVA = "0xE00FD0", Offset = "0xDFFBD0", VA = "0x180E00FD0")]
		private void _EnsureVoiceToActionIdCache()
		{
		}

		// Token: 0x060158D9 RID: 88281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158D9")]
		[Address(RVA = "0xE00E60", Offset = "0xDFFA60", VA = "0x180E00E60")]
		private void _EnsureActionIdToLipSyncDataCache()
		{
		}

		// Token: 0x060158DA RID: 88282 RVA: 0x0008C928 File Offset: 0x0008AB28
		[Token(Token = "0x60158DA")]
		[Address(RVA = "0xE01190", Offset = "0xDFFD90", VA = "0x180E01190")]
		private int _GetActionAnimIdx(DynIllustBase.DynIllustActionQuery action)
		{
			return 0;
		}

		// Token: 0x060158DB RID: 88283 RVA: 0x0008C940 File Offset: 0x0008AB40
		[Token(Token = "0x60158DB")]
		[Address(RVA = "0xE01420", Offset = "0xE00020", VA = "0x180E01420")]
		private bool _IsBlendAnimationAction(DynIllustBase.DynIllustActionQuery action)
		{
			return default(bool);
		}

		// Token: 0x060158DC RID: 88284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158DC")]
		[Address(RVA = "0xE00740", Offset = "0xDFF340", VA = "0x180E00740")]
		protected void _ApplyAnimation()
		{
		}

		// Token: 0x060158DD RID: 88285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158DD")]
		[Address(RVA = "0xE014C0", Offset = "0xE000C0", VA = "0x180E014C0")]
		public DynIllustSpecial()
		{
		}

		// Token: 0x060158DE RID: 88286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158DE")]
		[Address(RVA = "0xE00730", Offset = "0xDFF330", VA = "0x180E00730")]
		private void <>xLuaBaseProxy_SetContext(DynIllustMgr.Context P0)
		{
		}

		// Token: 0x060158DF RID: 88287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158DF")]
		[Address(RVA = "0xE00710", Offset = "0xDFF310", VA = "0x180E00710")]
		private void <>xLuaBaseProxy_ChangeAction(DynIllustBase.DynIllustActionQuery P0, float P1)
		{
		}

		// Token: 0x04019D4F RID: 105807
		[Token(Token = "0x4019D4F")]
		private const string ACTION_NAME_SPECIAL = "line_sp";

		// Token: 0x04019D50 RID: 105808
		[Token(Token = "0x4019D50")]
		private const string ACTION_NAME_IDLE = "line_idle";

		// Token: 0x04019D51 RID: 105809
		[Token(Token = "0x4019D51")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SkeletonAnimation _skeleton;

		// Token: 0x04019D52 RID: 105810
		[Token(Token = "0x4019D52")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<string> _lipSyncNames;

		// Token: 0x04019D53 RID: 105811
		[Token(Token = "0x4019D53")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<LipSyncData> _lipSyncDatas;

		// Token: 0x04019D54 RID: 105812
		[Token(Token = "0x4019D54")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private LipSyncSpineBlendAnimation _blendAnimation;

		// Token: 0x04019D55 RID: 105813
		[Token(Token = "0x4019D55")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string _charId;

		// Token: 0x04019D56 RID: 105814
		[Token(Token = "0x4019D56")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private string _skinId;

		// Token: 0x04019D57 RID: 105815
		[Token(Token = "0x4019D57")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private List<DynIllustSpecial.VoiceToActionId> _voiceToActionIds;

		// Token: 0x04019D58 RID: 105816
		[Token(Token = "0x4019D58")]
		[FieldOffset(Offset = "0xD8")]
		private Spine.Animation m_playingAnim;

		// Token: 0x04019D59 RID: 105817
		[Token(Token = "0x4019D59")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<string, string> m_cachedVoiceToActionId;

		// Token: 0x04019D5A RID: 105818
		[Token(Token = "0x4019D5A")]
		[FieldOffset(Offset = "0xE8")]
		private Dictionary<string, int> m_cachedActionIdToLipSyncData;

		// Token: 0x04019D5B RID: 105819
		[Token(Token = "0x4019D5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lipSyncSpineBlendAnimation;

		// Token: 0x04019D5C RID: 105820
		[Token(Token = "0x4019D5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_skinId;

		// Token: 0x04019D5D RID: 105821
		[Token(Token = "0x4019D5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x04019D5E RID: 105822
		[Token(Token = "0x4019D5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_lipSyncNames;

		// Token: 0x04019D5F RID: 105823
		[Token(Token = "0x4019D5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_lipSyncDatas;

		// Token: 0x04019D60 RID: 105824
		[Token(Token = "0x4019D60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_voiceToActionIds;

		// Token: 0x04019D61 RID: 105825
		[Token(Token = "0x4019D61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_skeleton;

		// Token: 0x04019D62 RID: 105826
		[Token(Token = "0x4019D62")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_playingActionDur;

		// Token: 0x04019D63 RID: 105827
		[Token(Token = "0x4019D63")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_playingTime;

		// Token: 0x04019D64 RID: 105828
		[Token(Token = "0x4019D64")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_actionDataInitialized;

		// Token: 0x04019D65 RID: 105829
		[Token(Token = "0x4019D65")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SupportNormalActionType;

		// Token: 0x04019D66 RID: 105830
		[Token(Token = "0x4019D66")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetContext;

		// Token: 0x04019D67 RID: 105831
		[Token(Token = "0x4019D67")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetActionDur;

		// Token: 0x04019D68 RID: 105832
		[Token(Token = "0x4019D68")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ChangeAction;

		// Token: 0x04019D69 RID: 105833
		[Token(Token = "0x4019D69")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetActionNameByVoiceId;

		// Token: 0x04019D6A RID: 105834
		[Token(Token = "0x4019D6A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EnsureVoiceToActionIdCache;

		// Token: 0x04019D6B RID: 105835
		[Token(Token = "0x4019D6B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EnsureActionIdToLipSyncDataCache;

		// Token: 0x04019D6C RID: 105836
		[Token(Token = "0x4019D6C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetActionAnimIdx;

		// Token: 0x04019D6D RID: 105837
		[Token(Token = "0x4019D6D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__IsBlendAnimationAction;

		// Token: 0x04019D6E RID: 105838
		[Token(Token = "0x4019D6E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ApplyAnimation;

		// Token: 0x04019D6F RID: 105839
		[Token(Token = "0x4019D6F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034D2 RID: 13522
		[Token(Token = "0x20034D2")]
		[Serializable]
		public class VoiceToActionId
		{
			// Token: 0x060158E0 RID: 88288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158E0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VoiceToActionId()
			{
			}

			// Token: 0x04019D70 RID: 105840
			[Token(Token = "0x4019D70")]
			[FieldOffset(Offset = "0x10")]
			public string voiceName;

			// Token: 0x04019D71 RID: 105841
			[Token(Token = "0x4019D71")]
			[FieldOffset(Offset = "0x18")]
			public string actionId;
		}
	}
}
