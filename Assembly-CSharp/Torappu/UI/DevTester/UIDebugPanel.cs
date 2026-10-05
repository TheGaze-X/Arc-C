using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050FC RID: 20732
	[Token(Token = "0x20050FC")]
	public class UIDebugPanel : MonoBehaviour
	{
		// Token: 0x0601EA11 RID: 125457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA11")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIDebugPanel()
		{
		}

		// Token: 0x040290F9 RID: 168185
		[Token(Token = "0x40290F9")]
		[FieldOffset(Offset = "0x0")]
		public static bool enableDebug;

		// Token: 0x040290FA RID: 168186
		[Token(Token = "0x40290FA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x040290FB RID: 168187
		[Token(Token = "0x40290FB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIDebugPerformanceSettings _panelPerformanceSettings;

		// Token: 0x040290FC RID: 168188
		[Token(Token = "0x40290FC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelRoguelikeContent;

		// Token: 0x040290FD RID: 168189
		[Token(Token = "0x40290FD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAutoChessContent;

		// Token: 0x040290FE RID: 168190
		[Token(Token = "0x40290FE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelDynamicIllustContent;

		// Token: 0x040290FF RID: 168191
		[Token(Token = "0x40290FF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelBuildingCharacterCheckerContent;

		// Token: 0x04029100 RID: 168192
		[Token(Token = "0x4029100")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelHolder;

		// Token: 0x04029101 RID: 168193
		[Token(Token = "0x4029101")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textUid;

		// Token: 0x04029102 RID: 168194
		[Token(Token = "0x4029102")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIDebugNetworkSetttings _networkSettings;

		// Token: 0x04029103 RID: 168195
		[Token(Token = "0x4029103")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIDebugVersionInfo _versionInfo;

		// Token: 0x04029104 RID: 168196
		[Token(Token = "0x4029104")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIDebugRemoteConfigInfo _remoteConfigInfo;

		// Token: 0x04029105 RID: 168197
		[Token(Token = "0x4029105")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIDebugNetworkConfigInfo _networkConfigInfo;

		// Token: 0x04029106 RID: 168198
		[Token(Token = "0x4029106")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InputField _unlockStageInput;

		// Token: 0x04029107 RID: 168199
		[Token(Token = "0x4029107")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private InputField _roguelikeItemInput;

		// Token: 0x04029108 RID: 168200
		[Token(Token = "0x4029108")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InputField _roguelikeEventInput;

		// Token: 0x04029109 RID: 168201
		[Token(Token = "0x4029109")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Toggle _avgForceSkippableToggle;

		// Token: 0x0402910A RID: 168202
		[Token(Token = "0x402910A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Toggle _pcModeToggle;

		// Token: 0x0402910B RID: 168203
		[Token(Token = "0x402910B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Toggle _festivalVoiceAllValidToggle;

		// Token: 0x0402910C RID: 168204
		[Token(Token = "0x402910C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Toggle _buttonMultiClick;

		// Token: 0x0402910D RID: 168205
		[Token(Token = "0x402910D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Toggle _toggleSkipBackflow;

		// Token: 0x0402910E RID: 168206
		[Token(Token = "0x402910E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _point;

		// Token: 0x0402910F RID: 168207
		[Token(Token = "0x402910F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIDebugResolutionScaler _panelResolutionScaler;

		// Token: 0x020050FD RID: 20733
		[Token(Token = "0x20050FD")]
		public class SyncDataRequest
		{
			// Token: 0x0601EA13 RID: 125459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA13")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SyncDataRequest()
			{
			}

			// Token: 0x04029110 RID: 168208
			[Token(Token = "0x4029110")]
			[FieldOffset(Offset = "0x10")]
			public PlatformKey platform;
		}

		// Token: 0x020050FE RID: 20734
		[Token(Token = "0x20050FE")]
		public class SyncDataResponse
		{
			// Token: 0x0601EA14 RID: 125460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA14")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SyncDataResponse()
			{
			}

			// Token: 0x04029111 RID: 168209
			[Token(Token = "0x4029111")]
			[FieldOffset(Offset = "0x10")]
			public JObject user;

			// Token: 0x04029112 RID: 168210
			[Token(Token = "0x4029112")]
			[FieldOffset(Offset = "0x18")]
			public long ts;

			// Token: 0x04029113 RID: 168211
			[Token(Token = "0x4029113")]
			[FieldOffset(Offset = "0x20")]
			public int result;
		}
	}
}
