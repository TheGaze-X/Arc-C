using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

namespace Torappu
{
	// Token: 0x020005E5 RID: 1509
	[Token(Token = "0x20005E5")]
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	public class BlurScreenTexGenerator : MonoBehaviour, IHotfixable
	{
		// Token: 0x060061D7 RID: 25047 RVA: 0x0002FEB0 File Offset: 0x0002E0B0
		[Token(Token = "0x60061D7")]
		[Address(RVA = "0x1DE8140", Offset = "0x1DE6D40", VA = "0x181DE8140")]
		public bool CheckIfTexEnabled()
		{
			return default(bool);
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060061D8 RID: 25048 RVA: 0x0002FEC8 File Offset: 0x0002E0C8
		[Token(Token = "0x17000CCB")]
		private bool initialized
		{
			[Token(Token = "0x60061D8")]
			[Address(RVA = "0x1DE97A0", Offset = "0x1DE83A0", VA = "0x181DE97A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060061D9 RID: 25049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D9")]
		[Address(RVA = "0x1DE8360", Offset = "0x1DE6F60", VA = "0x181DE8360")]
		public void SetConfig(BlurScreenTexGenerator.Config config)
		{
		}

		// Token: 0x060061DA RID: 25050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061DA")]
		[Address(RVA = "0x1DE8290", Offset = "0x1DE6E90", VA = "0x181DE8290")]
		public void SetBlurLevel(int blurLevel)
		{
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x0002FEE0 File Offset: 0x0002E0E0
		[Token(Token = "0x17000CCC")]
		public int blurLevel
		{
			[Token(Token = "0x60061DB")]
			[Address(RVA = "0x1DE9740", Offset = "0x1DE8340", VA = "0x181DE9740")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061DC")]
		[Address(RVA = "0x1DE85A0", Offset = "0x1DE71A0", VA = "0x181DE85A0")]
		private void _Cleanup()
		{
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x0002FEF8 File Offset: 0x0002E0F8
		[Token(Token = "0x60061DD")]
		[Address(RVA = "0x1DE90D0", Offset = "0x1DE7CD0", VA = "0x181DE90D0")]
		private bool _InitIfNot()
		{
			return default(bool);
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061DE")]
		[Address(RVA = "0x1DE95B0", Offset = "0x1DE81B0", VA = "0x181DE95B0")]
		private void _MarkEnabled(bool enable)
		{
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061DF")]
		[Address(RVA = "0x1DE8710", Offset = "0x1DE7310", VA = "0x181DE8710")]
		private static void _CommandOutputGlassMode(CommandBuffer cmd, RenderTargetIdentifier srcRT, Material mat, Vector2 size, int blurLevel, string outputTexName)
		{
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E0")]
		[Address(RVA = "0x1DE8C20", Offset = "0x1DE7820", VA = "0x181DE8C20")]
		private static void _CommandOutputGuassianMode(CommandBuffer cmd, RenderTargetIdentifier srcRT, Material mat, Vector2 size, int blurLevel, string outputTexName)
		{
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E1")]
		[Address(RVA = "0x1DE8210", Offset = "0x1DE6E10", VA = "0x181DE8210")]
		public void OnEnable()
		{
		}

		// Token: 0x060061E2 RID: 25058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E2")]
		[Address(RVA = "0x1DE81A0", Offset = "0x1DE6DA0", VA = "0x181DE81A0")]
		public void OnDisable()
		{
		}

		// Token: 0x060061E3 RID: 25059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E3")]
		[Address(RVA = "0x1DE84D0", Offset = "0x1DE70D0", VA = "0x181DE84D0")]
		private void Update()
		{
		}

		// Token: 0x060061E4 RID: 25060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E4")]
		[Address(RVA = "0x1DE9640", Offset = "0x1DE8240", VA = "0x181DE9640")]
		public BlurScreenTexGenerator()
		{
		}

		// Token: 0x04002B94 RID: 11156
		[Token(Token = "0x4002B94")]
		private const int BLUR_LEVEL_MIN = 1;

		// Token: 0x04002B95 RID: 11157
		[Token(Token = "0x4002B95")]
		private const int BLUR_LEVEL_MAX = 4;

		// Token: 0x04002B96 RID: 11158
		[Token(Token = "0x4002B96")]
		private const string BLUR_SAHDER = "Hidden/Torappu/PostEffect/SeparableGlassBlur";

		// Token: 0x04002B97 RID: 11159
		[Token(Token = "0x4002B97")]
		private const RenderTextureFormat TEX_FORMAT = RenderTextureFormat.ARGB32;

		// Token: 0x04002B98 RID: 11160
		[Token(Token = "0x4002B98")]
		private const CameraEvent CAMERA_EVT = CameraEvent.BeforeImageEffects;

		// Token: 0x04002B99 RID: 11161
		[Token(Token = "0x4002B99")]
		private const float BLUR_GUASSIAN_SIZE = 1.5f;

		// Token: 0x04002B9A RID: 11162
		[Token(Token = "0x4002B9A")]
		[FieldOffset(Offset = "0x18")]
		[ReadOnly]
		private int m_targetBlurLevel;

		// Token: 0x04002B9B RID: 11163
		[Token(Token = "0x4002B9B")]
		[FieldOffset(Offset = "0x1C")]
		[ReadOnly]
		private int m_downSample;

		// Token: 0x04002B9C RID: 11164
		[Token(Token = "0x4002B9C")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		private string m_outputTextureName;

		// Token: 0x04002B9D RID: 11165
		[Token(Token = "0x4002B9D")]
		[FieldOffset(Offset = "0x28")]
		private Material m_blurMat;

		// Token: 0x04002B9E RID: 11166
		[Token(Token = "0x4002B9E")]
		[FieldOffset(Offset = "0x30")]
		private BlurScreenTexGenerator.BlurMode m_blurMode;

		// Token: 0x04002B9F RID: 11167
		[Token(Token = "0x4002B9F")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		// Token: 0x04002BA0 RID: 11168
		[Token(Token = "0x4002BA0")]
		[FieldOffset(Offset = "0x40")]
		private CommandBuffer m_commandBuffer;

		// Token: 0x04002BA1 RID: 11169
		[Token(Token = "0x4002BA1")]
		[FieldOffset(Offset = "0x48")]
		private Vector2Int m_fullScreenSize;

		// Token: 0x04002BA2 RID: 11170
		[Token(Token = "0x4002BA2")]
		[FieldOffset(Offset = "0x50")]
		private Vector2Int m_initScreenSize;

		// Token: 0x04002BA3 RID: 11171
		[Token(Token = "0x4002BA3")]
		[FieldOffset(Offset = "0x58")]
		private int m_blurLevel;

		// Token: 0x04002BA4 RID: 11172
		[Token(Token = "0x4002BA4")]
		[FieldOffset(Offset = "0x60")]
		private Action<bool> m_onEnableStateChanged;

		// Token: 0x04002BA5 RID: 11173
		[Token(Token = "0x4002BA5")]
		[FieldOffset(Offset = "0x68")]
		private bool m_keepCameraTarget;

		// Token: 0x04002BA6 RID: 11174
		[Token(Token = "0x4002BA6")]
		[FieldOffset(Offset = "0x70")]
		private RenderTexture m_cameraTarget;

		// Token: 0x04002BA7 RID: 11175
		[Token(Token = "0x4002BA7")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isEnabled;

		// Token: 0x04002BA8 RID: 11176
		[Token(Token = "0x4002BA8")]
		[FieldOffset(Offset = "0x79")]
		private bool m_hasConfig;

		// Token: 0x04002BA9 RID: 11177
		[Token(Token = "0x4002BA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfTexEnabled;

		// Token: 0x04002BAA RID: 11178
		[Token(Token = "0x4002BAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_initialized;

		// Token: 0x04002BAB RID: 11179
		[Token(Token = "0x4002BAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetConfig;

		// Token: 0x04002BAC RID: 11180
		[Token(Token = "0x4002BAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetBlurLevel;

		// Token: 0x04002BAD RID: 11181
		[Token(Token = "0x4002BAD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_blurLevel;

		// Token: 0x04002BAE RID: 11182
		[Token(Token = "0x4002BAE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Cleanup;

		// Token: 0x04002BAF RID: 11183
		[Token(Token = "0x4002BAF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04002BB0 RID: 11184
		[Token(Token = "0x4002BB0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__MarkEnabled;

		// Token: 0x04002BB1 RID: 11185
		[Token(Token = "0x4002BB1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CommandOutputGlassMode;

		// Token: 0x04002BB2 RID: 11186
		[Token(Token = "0x4002BB2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CommandOutputGuassianMode;

		// Token: 0x04002BB3 RID: 11187
		[Token(Token = "0x4002BB3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04002BB4 RID: 11188
		[Token(Token = "0x4002BB4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04002BB5 RID: 11189
		[Token(Token = "0x4002BB5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04002BB6 RID: 11190
		[Token(Token = "0x4002BB6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020005E6 RID: 1510
		[Token(Token = "0x20005E6")]
		public enum BlurMode
		{
			// Token: 0x04002BB8 RID: 11192
			[Token(Token = "0x4002BB8")]
			GLASS,
			// Token: 0x04002BB9 RID: 11193
			[Token(Token = "0x4002BB9")]
			GUASSIAN
		}

		// Token: 0x020005E7 RID: 1511
		[Token(Token = "0x20005E7")]
		public struct Config
		{
			// Token: 0x04002BBA RID: 11194
			[Token(Token = "0x4002BBA")]
			[FieldOffset(Offset = "0x0")]
			public Material blurMat;

			// Token: 0x04002BBB RID: 11195
			[Token(Token = "0x4002BBB")]
			[FieldOffset(Offset = "0x8")]
			public BlurScreenTexGenerator.BlurMode blurMode;

			// Token: 0x04002BBC RID: 11196
			[Token(Token = "0x4002BBC")]
			[FieldOffset(Offset = "0xC")]
			public Vector2Int screenSize;

			// Token: 0x04002BBD RID: 11197
			[Token(Token = "0x4002BBD")]
			[FieldOffset(Offset = "0x14")]
			public int downSample;

			// Token: 0x04002BBE RID: 11198
			[Token(Token = "0x4002BBE")]
			[FieldOffset(Offset = "0x18")]
			public string outputTexName;

			// Token: 0x04002BBF RID: 11199
			[Token(Token = "0x4002BBF")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool> onEnableStateChanged;

			// Token: 0x04002BC0 RID: 11200
			[Token(Token = "0x4002BC0")]
			[FieldOffset(Offset = "0x28")]
			public bool keepCameraTarget;
		}
	}
}
