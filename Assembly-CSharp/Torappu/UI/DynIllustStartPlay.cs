using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034E0 RID: 13536
	[Token(Token = "0x20034E0")]
	[RequireComponent(typeof(SkeletonAnimation))]
	public class DynIllustStartPlay : MonoBehaviour, IHotfixable
	{
		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x06015921 RID: 88353 RVA: 0x0008CA30 File Offset: 0x0008AC30
		[Token(Token = "0x170032FE")]
		[Inspect(Level = 2)]
		public bool isPlaying
		{
			[Token(Token = "0x6015921")]
			[Address(RVA = "0xE03F00", Offset = "0xE02B00", VA = "0x180E03F00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x06015922 RID: 88354 RVA: 0x0008CA48 File Offset: 0x0008AC48
		[Token(Token = "0x170032FF")]
		public DynIllustStartPlay.DynIllustStartParams param
		{
			[Token(Token = "0x6015922")]
			[Address(RVA = "0xE03FB0", Offset = "0xE02BB0", VA = "0x180E03FB0")]
			get
			{
				return default(DynIllustStartPlay.DynIllustStartParams);
			}
		}

		// Token: 0x06015923 RID: 88355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015923")]
		[Address(RVA = "0xE03720", Offset = "0xE02320", VA = "0x180E03720")]
		public void Play()
		{
		}

		// Token: 0x06015924 RID: 88356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015924")]
		[Address(RVA = "0xE038B0", Offset = "0xE024B0", VA = "0x180E038B0")]
		public void Stop()
		{
		}

		// Token: 0x06015925 RID: 88357 RVA: 0x0008CA60 File Offset: 0x0008AC60
		[Token(Token = "0x6015925")]
		[Address(RVA = "0xE03950", Offset = "0xE02550", VA = "0x180E03950")]
		public bool TryFetchAndAddCameras(List<Camera> cameras)
		{
			return default(bool);
		}

		// Token: 0x06015926 RID: 88358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015926")]
		[Address(RVA = "0xE03690", Offset = "0xE02290", VA = "0x180E03690")]
		public void CopyManualParam(DynIllustStartPlay src)
		{
		}

		// Token: 0x06015927 RID: 88359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015927")]
		[Address(RVA = "0xE03C10", Offset = "0xE02810", VA = "0x180E03C10")]
		private void Update()
		{
		}

		// Token: 0x06015928 RID: 88360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015928")]
		[Address(RVA = "0xE03D80", Offset = "0xE02980", VA = "0x180E03D80")]
		public DynIllustStartPlay()
		{
		}

		// Token: 0x04019DD9 RID: 105945
		[Token(Token = "0x4019DD9")]
		[NonSerialized]
		public const float DEFAULT_START_PLAY_DURATION = 8f;

		// Token: 0x04019DDA RID: 105946
		[Token(Token = "0x4019DDA")]
		[NonSerialized]
		public const float DEFAULT_CHAR_VOICE_OFFSET = 2f;

		// Token: 0x04019DDB RID: 105947
		[Token(Token = "0x4019DDB")]
		[NonSerialized]
		public const float MAIN_CAMERA_DEPTH = 41f;

		// Token: 0x04019DDC RID: 105948
		[Token(Token = "0x4019DDC")]
		[NonSerialized]
		public const float MAX_CAMERA_FAR_PLANE = 100f;

		// Token: 0x04019DDD RID: 105949
		[Token(Token = "0x4019DDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DynIllustStartPlay.DynIllustStartParams _params;

		// Token: 0x04019DDE RID: 105950
		[Token(Token = "0x4019DDE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DynIllustStartPlay.CameraSettings _mainCamera;

		// Token: 0x04019DDF RID: 105951
		[Token(Token = "0x4019DDF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<DynIllustStartPlay.CameraSettings> _exCameras;

		// Token: 0x04019DE0 RID: 105952
		[Token(Token = "0x4019DE0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _effects;

		// Token: 0x04019DE1 RID: 105953
		[Token(Token = "0x4019DE1")]
		[FieldOffset(Offset = "0x48")]
		private PeriodicTimer m_playingTimer;

		// Token: 0x04019DE2 RID: 105954
		[Token(Token = "0x4019DE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isPlaying;

		// Token: 0x04019DE3 RID: 105955
		[Token(Token = "0x4019DE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x04019DE4 RID: 105956
		[Token(Token = "0x4019DE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x04019DE5 RID: 105957
		[Token(Token = "0x4019DE5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04019DE6 RID: 105958
		[Token(Token = "0x4019DE6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryFetchAndAddCameras;

		// Token: 0x04019DE7 RID: 105959
		[Token(Token = "0x4019DE7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CopyManualParam;

		// Token: 0x04019DE8 RID: 105960
		[Token(Token = "0x4019DE8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04019DE9 RID: 105961
		[Token(Token = "0x4019DE9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034E1 RID: 13537
		[Token(Token = "0x20034E1")]
		[Serializable]
		public class CameraSettings
		{
			// Token: 0x17003300 RID: 13056
			// (get) Token: 0x06015929 RID: 88361 RVA: 0x0008CA78 File Offset: 0x0008AC78
			[Token(Token = "0x17003300")]
			public bool isValid
			{
				[Token(Token = "0x6015929")]
				[Address(RVA = "0xDFA370", Offset = "0xDF8F70", VA = "0x180DFA370")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601592A RID: 88362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601592A")]
			[Address(RVA = "0xDFA360", Offset = "0xDF8F60", VA = "0x180DFA360")]
			public CameraSettings()
			{
			}

			// Token: 0x04019DEA RID: 105962
			[Token(Token = "0x4019DEA")]
			[FieldOffset(Offset = "0x10")]
			public Camera camera;

			// Token: 0x04019DEB RID: 105963
			[Token(Token = "0x4019DEB")]
			[FieldOffset(Offset = "0x18")]
			public float depth;

			// Token: 0x04019DEC RID: 105964
			[Token(Token = "0x4019DEC")]
			[FieldOffset(Offset = "0x1C")]
			public LayerMask cullingMask;
		}

		// Token: 0x020034E2 RID: 13538
		[Token(Token = "0x20034E2")]
		[Serializable]
		public struct DynIllustStartParams
		{
			// Token: 0x04019DED RID: 105965
			[Token(Token = "0x4019DED")]
			[FieldOffset(Offset = "0x0")]
			[NonSerialized]
			public static DynIllustStartPlay.DynIllustStartParams DEFAULT;

			// Token: 0x04019DEE RID: 105966
			[Token(Token = "0x4019DEE")]
			[FieldOffset(Offset = "0x0")]
			public float duration;

			// Token: 0x04019DEF RID: 105967
			[Token(Token = "0x4019DEF")]
			[FieldOffset(Offset = "0x4")]
			public float charVoiceOffset;

			// Token: 0x04019DF0 RID: 105968
			[Token(Token = "0x4019DF0")]
			[FieldOffset(Offset = "0x8")]
			public Color fadeColor;
		}
	}
}
