using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Spine;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002169 RID: 8553
	[Token(Token = "0x2002169")]
	public class BakeMuzzleController : IHotfixable
	{
		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x0600D2AC RID: 53932 RVA: 0x0004BF30 File Offset: 0x0004A130
		// (set) Token: 0x0600D2AD RID: 53933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700194F")]
		public bool isValid
		{
			[Token(Token = "0x600D2AC")]
			[Address(RVA = "0x35319A0", Offset = "0x35305A0", VA = "0x1835319A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D2AD")]
			[Address(RVA = "0x3531C10", Offset = "0x3530810", VA = "0x183531C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x0600D2AE RID: 53934 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D2AF RID: 53935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001950")]
		public string animationName
		{
			[Token(Token = "0x600D2AE")]
			[Address(RVA = "0x3531870", Offset = "0x3530470", VA = "0x183531870")]
			get
			{
				return null;
			}
			[Token(Token = "0x600D2AF")]
			[Address(RVA = "0x3531A90", Offset = "0x3530690", VA = "0x183531A90")]
			set
			{
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x0600D2B0 RID: 53936 RVA: 0x0004BF48 File Offset: 0x0004A148
		// (set) Token: 0x0600D2B1 RID: 53937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001951")]
		public bool loop
		{
			[Token(Token = "0x600D2B0")]
			[Address(RVA = "0x3531A20", Offset = "0x3530620", VA = "0x183531A20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D2B1")]
			[Address(RVA = "0x3531CA0", Offset = "0x35308A0", VA = "0x183531CA0")]
			set
			{
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x0600D2B2 RID: 53938 RVA: 0x0004BF60 File Offset: 0x0004A160
		[Token(Token = "0x17001952")]
		public FP animationTime
		{
			[Token(Token = "0x600D2B2")]
			[Address(RVA = "0x35318F0", Offset = "0x35304F0", VA = "0x1835318F0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x0600D2B3 RID: 53939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001953")]
		public string activeFace
		{
			[Token(Token = "0x600D2B3")]
			[Address(RVA = "0x3531800", Offset = "0x3530400", VA = "0x183531800")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D2B4 RID: 53940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2B4")]
		[Address(RVA = "0x352D000", Offset = "0x352BC00", VA = "0x18352D000")]
		public void TryInitialize(SpineAnimator host)
		{
		}

		// Token: 0x0600D2B5 RID: 53941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2B5")]
		[Address(RVA = "0x352CC00", Offset = "0x352B800", VA = "0x18352CC00")]
		public void OnTick(FP delta)
		{
		}

		// Token: 0x0600D2B6 RID: 53942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2B6")]
		[Address(RVA = "0x352CE50", Offset = "0x352BA50", VA = "0x18352CE50")]
		public void OnUpdate(FP delta)
		{
		}

		// Token: 0x0600D2B7 RID: 53943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2B7")]
		[Address(RVA = "0x352C400", Offset = "0x352B000", VA = "0x18352C400")]
		public void OnSetAnimation(string animationName, bool loop)
		{
		}

		// Token: 0x0600D2B8 RID: 53944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2B8")]
		[Address(RVA = "0x352C120", Offset = "0x352AD20", VA = "0x18352C120")]
		public void OnAddAnimation(string animName, bool loop, float delay)
		{
		}

		// Token: 0x0600D2B9 RID: 53945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2B9")]
		[Address(RVA = "0x352C750", Offset = "0x352B350", VA = "0x18352C750")]
		public void OnSetRawAnimationName(string animationName)
		{
		}

		// Token: 0x0600D2BA RID: 53946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2BA")]
		[Address(RVA = "0x352C2A0", Offset = "0x352AEA0", VA = "0x18352C2A0")]
		public void OnAnimatorStop()
		{
		}

		// Token: 0x0600D2BB RID: 53947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2BB")]
		[Address(RVA = "0x352CDB0", Offset = "0x352B9B0", VA = "0x18352CDB0")]
		public void OnUpdateTimeScale(float speed)
		{
		}

		// Token: 0x0600D2BC RID: 53948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2BC")]
		[Address(RVA = "0x352C7F0", Offset = "0x352B3F0", VA = "0x18352C7F0")]
		public void OnSyncAnimationState(IFaceConfiguration to, IFaceConfiguration from)
		{
		}

		// Token: 0x0600D2BD RID: 53949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2BD")]
		[Address(RVA = "0x352C330", Offset = "0x352AF30", VA = "0x18352C330")]
		public void OnReset()
		{
		}

		// Token: 0x0600D2BE RID: 53950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D2BE")]
		[Address(RVA = "0x352BFB0", Offset = "0x352ABB0", VA = "0x18352BFB0")]
		public MountPoint GetMountPoint(Entity.MountPointType mountType)
		{
			return null;
		}

		// Token: 0x0600D2BF RID: 53951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2BF")]
		[Address(RVA = "0x352DE10", Offset = "0x352CA10", VA = "0x18352DE10")]
		private void _InitBakedData(string animName, string activeFaceKey)
		{
		}

		// Token: 0x0600D2C0 RID: 53952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2C0")]
		[Address(RVA = "0x352E920", Offset = "0x352D520", VA = "0x18352E920")]
		private void _UpdateBakedData()
		{
		}

		// Token: 0x0600D2C1 RID: 53953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2C1")]
		[Address(RVA = "0x352D410", Offset = "0x352C010", VA = "0x18352D410")]
		private void _CheckBakedEvent()
		{
		}

		// Token: 0x0600D2C2 RID: 53954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2C2")]
		[Address(RVA = "0x352D5E0", Offset = "0x352C1E0", VA = "0x18352D5E0")]
		private void _ClearMixingData()
		{
		}

		// Token: 0x0600D2C3 RID: 53955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2C3")]
		[Address(RVA = "0x352D6B0", Offset = "0x352C2B0", VA = "0x18352D6B0")]
		private void _ClearSpineMixingData()
		{
		}

		// Token: 0x0600D2C4 RID: 53956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2C4")]
		[Address(RVA = "0x352EB40", Offset = "0x352D740", VA = "0x18352EB40")]
		private void _UpdateCachePointDict(Dictionary<int, BakedMountPointData> bpDict)
		{
		}

		// Token: 0x0600D2C5 RID: 53957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2C5")]
		[Address(RVA = "0x352D7D0", Offset = "0x352C3D0", VA = "0x18352D7D0")]
		private void _GetInterpolatedTransform(BakedMountPointData bpData, float animTime, out Vector3 position, out Quaternion rotation, out Vector3 scale)
		{
		}

		// Token: 0x0600D2C6 RID: 53958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2C6")]
		[Address(RVA = "0x352FB70", Offset = "0x352E770", VA = "0x18352FB70")]
		private void _UpdateMixCachePoint(Dictionary<int, BakedMountPointData> bakedMountPointDict, Dictionary<int, BakedMountPointData> mixMountPointDict)
		{
		}

		// Token: 0x0600D2C7 RID: 53959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2C7")]
		[Address(RVA = "0x35312C0", Offset = "0x352FEC0", VA = "0x1835312C0")]
		private void _UpdateMixingAnim()
		{
		}

		// Token: 0x0600D2C8 RID: 53960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2C8")]
		[Address(RVA = "0x352E570", Offset = "0x352D170", VA = "0x18352E570")]
		private void _InitMixingFromBakedData()
		{
		}

		// Token: 0x0600D2C9 RID: 53961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2C9")]
		[Address(RVA = "0x352E6F0", Offset = "0x352D2F0", VA = "0x18352E6F0")]
		private void _InitSpineMixingData(TrackEntry currentTrack)
		{
		}

		// Token: 0x0600D2CA RID: 53962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2CA")]
		[Address(RVA = "0x352E880", Offset = "0x352D480", VA = "0x18352E880")]
		private void _MarkInvalidAndClear()
		{
		}

		// Token: 0x0600D2CB RID: 53963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2CB")]
		[Address(RVA = "0x35315A0", Offset = "0x35301A0", VA = "0x1835315A0")]
		public BakeMuzzleController()
		{
		}

		// Token: 0x0400E18D RID: 57741
		[Token(Token = "0x400E18D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Array MOUNT_POINT_ENUMS;

		// Token: 0x0400E18E RID: 57742
		[Token(Token = "0x400E18E")]
		[FieldOffset(Offset = "0x10")]
		private SpineAnimator m_host;

		// Token: 0x0400E18F RID: 57743
		[Token(Token = "0x400E18F")]
		[FieldOffset(Offset = "0x18")]
		private BakedSpineData m_spineBakedData;

		// Token: 0x0400E190 RID: 57744
		[Token(Token = "0x400E190")]
		[FieldOffset(Offset = "0x20")]
		private float m_currentAnimSpeed;

		// Token: 0x0400E191 RID: 57745
		[Token(Token = "0x400E191")]
		[FieldOffset(Offset = "0x24")]
		private float m_currentAnimTime;

		// Token: 0x0400E192 RID: 57746
		[Token(Token = "0x400E192")]
		[FieldOffset(Offset = "0x28")]
		private float m_previousAnimTime;

		// Token: 0x0400E193 RID: 57747
		[Token(Token = "0x400E193")]
		[FieldOffset(Offset = "0x2C")]
		private float m_loopTime;

		// Token: 0x0400E194 RID: 57748
		[Token(Token = "0x400E194")]
		[FieldOffset(Offset = "0x30")]
		private string m_activeFaceKey;

		// Token: 0x0400E195 RID: 57749
		[Token(Token = "0x400E195")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isLoop;

		// Token: 0x0400E196 RID: 57750
		[Token(Token = "0x400E196")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isPlaying;

		// Token: 0x0400E197 RID: 57751
		[Token(Token = "0x400E197")]
		[FieldOffset(Offset = "0x40")]
		private FP m_animLength;

		// Token: 0x0400E198 RID: 57752
		[Token(Token = "0x400E198")]
		[FieldOffset(Offset = "0x48")]
		private BakedEventTimeline m_bakedEventTimeline;

		// Token: 0x0400E199 RID: 57753
		[Token(Token = "0x400E199")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, BakedMountPointData> m_bakedMountPointDict;

		// Token: 0x0400E19A RID: 57754
		[Token(Token = "0x400E19A")]
		[FieldOffset(Offset = "0x58")]
		private bool[] m_hasTriggeredEvent;

		// Token: 0x0400E19B RID: 57755
		[Token(Token = "0x400E19B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isMixing;

		// Token: 0x0400E19C RID: 57756
		[Token(Token = "0x400E19C")]
		[FieldOffset(Offset = "0x68")]
		private FP m_mixDelay;

		// Token: 0x0400E19D RID: 57757
		[Token(Token = "0x400E19D")]
		[FieldOffset(Offset = "0x70")]
		private string m_targetAnimName;

		// Token: 0x0400E19E RID: 57758
		[Token(Token = "0x400E19E")]
		[FieldOffset(Offset = "0x78")]
		private FP m_animLastTime;

		// Token: 0x0400E19F RID: 57759
		[Token(Token = "0x400E19F")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isSpineMixing;

		// Token: 0x0400E1A0 RID: 57760
		[Token(Token = "0x400E1A0")]
		[FieldOffset(Offset = "0x88")]
		private FP m_spineMixDuration;

		// Token: 0x0400E1A1 RID: 57761
		[Token(Token = "0x400E1A1")]
		[FieldOffset(Offset = "0x90")]
		private string m_mixingFromAnimName;

		// Token: 0x0400E1A2 RID: 57762
		[Token(Token = "0x400E1A2")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<int, BakedMountPointData> m_mixingFromBakedMPDict;

		// Token: 0x0400E1A3 RID: 57763
		[Token(Token = "0x400E1A3")]
		[FieldOffset(Offset = "0xA0")]
		private string m_mixingFromFaceKey;

		// Token: 0x0400E1A4 RID: 57764
		[Token(Token = "0x400E1A4")]
		[FieldOffset(Offset = "0xA8")]
		private FP m_mixingFromTime;

		// Token: 0x0400E1A5 RID: 57765
		[Token(Token = "0x400E1A5")]
		[FieldOffset(Offset = "0xB0")]
		private FP m_mixingEnd;

		// Token: 0x0400E1A6 RID: 57766
		[Token(Token = "0x400E1A6")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<Entity.MountPointType, CachePointData> m_cachePointDict;

		// Token: 0x0400E1A8 RID: 57768
		[Token(Token = "0x400E1A8")]
		[FieldOffset(Offset = "0xC8")]
		private string m_animationName;

		// Token: 0x0400E1A9 RID: 57769
		[Token(Token = "0x400E1A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0400E1AA RID: 57770
		[Token(Token = "0x400E1AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isValid;

		// Token: 0x0400E1AB RID: 57771
		[Token(Token = "0x400E1AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_animationName;

		// Token: 0x0400E1AC RID: 57772
		[Token(Token = "0x400E1AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_animationName;

		// Token: 0x0400E1AD RID: 57773
		[Token(Token = "0x400E1AD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_loop;

		// Token: 0x0400E1AE RID: 57774
		[Token(Token = "0x400E1AE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_loop;

		// Token: 0x0400E1AF RID: 57775
		[Token(Token = "0x400E1AF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_animationTime;

		// Token: 0x0400E1B0 RID: 57776
		[Token(Token = "0x400E1B0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_activeFace;

		// Token: 0x0400E1B1 RID: 57777
		[Token(Token = "0x400E1B1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryInitialize;

		// Token: 0x0400E1B2 RID: 57778
		[Token(Token = "0x400E1B2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400E1B3 RID: 57779
		[Token(Token = "0x400E1B3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0400E1B4 RID: 57780
		[Token(Token = "0x400E1B4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnSetAnimation;

		// Token: 0x0400E1B5 RID: 57781
		[Token(Token = "0x400E1B5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnAddAnimation;

		// Token: 0x0400E1B6 RID: 57782
		[Token(Token = "0x400E1B6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnSetRawAnimationName;

		// Token: 0x0400E1B7 RID: 57783
		[Token(Token = "0x400E1B7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnAnimatorStop;

		// Token: 0x0400E1B8 RID: 57784
		[Token(Token = "0x400E1B8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnUpdateTimeScale;

		// Token: 0x0400E1B9 RID: 57785
		[Token(Token = "0x400E1B9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnSyncAnimationState;

		// Token: 0x0400E1BA RID: 57786
		[Token(Token = "0x400E1BA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400E1BB RID: 57787
		[Token(Token = "0x400E1BB")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetMountPoint;

		// Token: 0x0400E1BC RID: 57788
		[Token(Token = "0x400E1BC")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InitBakedData;

		// Token: 0x0400E1BD RID: 57789
		[Token(Token = "0x400E1BD")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__UpdateBakedData;

		// Token: 0x0400E1BE RID: 57790
		[Token(Token = "0x400E1BE")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CheckBakedEvent;

		// Token: 0x0400E1BF RID: 57791
		[Token(Token = "0x400E1BF")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ClearMixingData;

		// Token: 0x0400E1C0 RID: 57792
		[Token(Token = "0x400E1C0")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ClearSpineMixingData;

		// Token: 0x0400E1C1 RID: 57793
		[Token(Token = "0x400E1C1")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__UpdateCachePointDict;

		// Token: 0x0400E1C2 RID: 57794
		[Token(Token = "0x400E1C2")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GetInterpolatedTransform;

		// Token: 0x0400E1C3 RID: 57795
		[Token(Token = "0x400E1C3")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UpdateMixCachePoint;

		// Token: 0x0400E1C4 RID: 57796
		[Token(Token = "0x400E1C4")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__UpdateMixingAnim;

		// Token: 0x0400E1C5 RID: 57797
		[Token(Token = "0x400E1C5")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__InitMixingFromBakedData;

		// Token: 0x0400E1C6 RID: 57798
		[Token(Token = "0x400E1C6")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__InitSpineMixingData;

		// Token: 0x0400E1C7 RID: 57799
		[Token(Token = "0x400E1C7")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__MarkInvalidAndClear;

		// Token: 0x0400E1C8 RID: 57800
		[Token(Token = "0x400E1C8")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
