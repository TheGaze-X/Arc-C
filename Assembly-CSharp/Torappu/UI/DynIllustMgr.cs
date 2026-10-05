using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using Torappu.Resource;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034CB RID: 13515
	[Token(Token = "0x20034CB")]
	public class DynIllustMgr : SingletonMonoBehaviour<DynIllustMgr>, ISingletonNotAutoCreate
	{
		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x06015899 RID: 88217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032E9")]
		private IConverter plainTextConverter
		{
			[Token(Token = "0x6015899")]
			[Address(RVA = "0xDFFC70", Offset = "0xDFE870", VA = "0x180DFFC70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0601589A RID: 88218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032EA")]
		private IConverter decrypter
		{
			[Token(Token = "0x601589A")]
			[Address(RVA = "0xDFFAB0", Offset = "0xDFE6B0", VA = "0x180DFFAB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0601589B RID: 88219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032EB")]
		public Camera dynIllustCam
		{
			[Token(Token = "0x601589B")]
			[Address(RVA = "0xDFFB50", Offset = "0xDFE750", VA = "0x180DFFB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0601589C RID: 88220 RVA: 0x0008C850 File Offset: 0x0008AA50
		// (set) Token: 0x0601589D RID: 88221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170032EC")]
		public bool pause
		{
			[Token(Token = "0x601589C")]
			[Address(RVA = "0xDFFBB0", Offset = "0xDFE7B0", VA = "0x180DFFBB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601589D")]
			[Address(RVA = "0xDFFCF0", Offset = "0xDFE8F0", VA = "0x180DFFCF0")]
			set
			{
			}
		}

		// Token: 0x0601589E RID: 88222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601589E")]
		[Address(RVA = "0xDFF7D0", Offset = "0xDFE3D0", VA = "0x180DFF7D0")]
		private void _UpdateTickFuncStatus(bool needTick)
		{
		}

		// Token: 0x0601589F RID: 88223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601589F")]
		[Address(RVA = "0xDFF390", Offset = "0xDFDF90", VA = "0x180DFF390")]
		private void _OnWillRenderCanvas()
		{
		}

		// Token: 0x060158A0 RID: 88224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158A0")]
		[Address(RVA = "0xDFE620", Offset = "0xDFD220", VA = "0x180DFE620")]
		public void TriggerIllustActive(UICharacterDynIllust targetIllust)
		{
		}

		// Token: 0x060158A1 RID: 88225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60158A1")]
		private TAsset _LoadAssetByDynIllust<TAsset>(string dynIllustId, string path) where TAsset : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060158A2 RID: 88226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158A2")]
		[Address(RVA = "0xDFF500", Offset = "0xDFE100", VA = "0x180DFF500")]
		private void _UnloadAssetByDynIllust(string dynIllustId, UnityEngine.Object asset)
		{
		}

		// Token: 0x060158A3 RID: 88227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158A3")]
		[Address(RVA = "0xDFDD30", Offset = "0xDFC930", VA = "0x180DFDD30")]
		public void ClearAll()
		{
		}

		// Token: 0x060158A4 RID: 88228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60158A4")]
		[Address(RVA = "0xDFDFF0", Offset = "0xDFCBF0", VA = "0x180DFDFF0")]
		public DynIllustView Load(CharUISkinStruct skin, Transform parent)
		{
			return null;
		}

		// Token: 0x060158A5 RID: 88229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158A5")]
		[Address(RVA = "0xDFE740", Offset = "0xDFD340", VA = "0x180DFE740")]
		public void Unload(DynIllustBase res)
		{
		}

		// Token: 0x060158A6 RID: 88230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60158A6")]
		[Address(RVA = "0xDFDA20", Offset = "0xDFC620", VA = "0x180DFDA20")]
		public DynIllustBase Active(DynIllustView view)
		{
			return null;
		}

		// Token: 0x060158A7 RID: 88231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158A7")]
		[Address(RVA = "0xDFE4C0", Offset = "0xDFD0C0", VA = "0x180DFE4C0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060158A8 RID: 88232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158A8")]
		[Address(RVA = "0xDFE440", Offset = "0xDFD040", VA = "0x180DFE440", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x060158A9 RID: 88233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032ED")]
		public AbstractAssetLoader assetLoader
		{
			[Token(Token = "0x60158A9")]
			[Address(RVA = "0xDFFA00", Offset = "0xDFE600", VA = "0x180DFFA00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060158AA RID: 88234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158AA")]
		[Address(RVA = "0xDFEE00", Offset = "0xDFDA00", VA = "0x180DFEE00")]
		private void _InitDisplay()
		{
		}

		// Token: 0x060158AB RID: 88235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60158AB")]
		[Address(RVA = "0xDFE940", Offset = "0xDFD540", VA = "0x180DFE940")]
		private DynIllustView _CreateIllustView(DynIllustBase res, Transform parent, DynIllustMgr.Context context)
		{
			return null;
		}

		// Token: 0x060158AC RID: 88236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158AC")]
		[Address(RVA = "0xDFF410", Offset = "0xDFE010", VA = "0x180DFF410")]
		private void _RefreshViewContent(DynIllustView view)
		{
		}

		// Token: 0x060158AD RID: 88237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60158AD")]
		[Address(RVA = "0xDFEC40", Offset = "0xDFD840", VA = "0x180DFEC40")]
		private RenderTexture _CreateRTForDynIllust()
		{
			return null;
		}

		// Token: 0x060158AE RID: 88238 RVA: 0x0008C868 File Offset: 0x0008AA68
		[Token(Token = "0x60158AE")]
		[Address(RVA = "0xDFDF20", Offset = "0xDFCB20", VA = "0x180DFDF20")]
		public static int GetRTSizeByRuntimePlatform(RuntimePlatform platform)
		{
			return 0;
		}

		// Token: 0x060158AF RID: 88239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158AF")]
		[Address(RVA = "0xDFF930", Offset = "0xDFE530", VA = "0x180DFF930")]
		public DynIllustMgr()
		{
		}

		// Token: 0x04019D10 RID: 105744
		[Token(Token = "0x4019D10")]
		public const int RT_WIDTH = 2048;

		// Token: 0x04019D11 RID: 105745
		[Token(Token = "0x4019D11")]
		public const int RT_HEIGHT = 2048;

		// Token: 0x04019D12 RID: 105746
		[Token(Token = "0x4019D12")]
		public const int ADAPTIVE_RT_SIZE = 2048;

		// Token: 0x04019D13 RID: 105747
		[Token(Token = "0x4019D13")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isTicking;

		// Token: 0x04019D14 RID: 105748
		[Token(Token = "0x4019D14")]
		[FieldOffset(Offset = "0x20")]
		private DynIllustMgr.IRenderStrategy m_renderStrategy;

		// Token: 0x04019D15 RID: 105749
		[Token(Token = "0x4019D15")]
		[FieldOffset(Offset = "0x28")]
		private AbstractAssetLoader m_assetLoader;

		// Token: 0x04019D16 RID: 105750
		[Token(Token = "0x4019D16")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture m_rt;

		// Token: 0x04019D17 RID: 105751
		[Token(Token = "0x4019D17")]
		[FieldOffset(Offset = "0x38")]
		private Material m_mat;

		// Token: 0x04019D18 RID: 105752
		[Token(Token = "0x4019D18")]
		[FieldOffset(Offset = "0x40")]
		private Camera m_cam;

		// Token: 0x04019D19 RID: 105753
		[Token(Token = "0x4019D19")]
		[FieldOffset(Offset = "0x48")]
		private DynIllustBase m_activedIllust;

		// Token: 0x04019D1A RID: 105754
		[Token(Token = "0x4019D1A")]
		[FieldOffset(Offset = "0x50")]
		private float m_activedIllustCameraSize;

		// Token: 0x04019D1B RID: 105755
		[Token(Token = "0x4019D1B")]
		[FieldOffset(Offset = "0x58")]
		private DynIllustBase m_illustInstance;

		// Token: 0x04019D1C RID: 105756
		[Token(Token = "0x4019D1C")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, Dictionary<string, UnityEngine.Object>> m_dynIllustLoadedAssets;

		// Token: 0x04019D1D RID: 105757
		[Token(Token = "0x4019D1D")]
		[FieldOffset(Offset = "0x0")]
		private static IConverter m_decrypter;

		// Token: 0x04019D1E RID: 105758
		[Token(Token = "0x4019D1E")]
		[FieldOffset(Offset = "0x68")]
		private IConverter m_plainTextConverter;

		// Token: 0x04019D1F RID: 105759
		[Token(Token = "0x4019D1F")]
		[FieldOffset(Offset = "0x70")]
		private IWillRenderCanvasTask m_willRenderTask;

		// Token: 0x04019D20 RID: 105760
		[Token(Token = "0x4019D20")]
		public const ConverterFactory.ConverterType LIPSYNC_CONVERTER_TYPE = ConverterFactory.ConverterType.FLAT_BUFFER;

		// Token: 0x04019D21 RID: 105761
		[Token(Token = "0x4019D21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_plainTextConverter;

		// Token: 0x04019D22 RID: 105762
		[Token(Token = "0x4019D22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_decrypter;

		// Token: 0x04019D23 RID: 105763
		[Token(Token = "0x4019D23")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_dynIllustCam;

		// Token: 0x04019D24 RID: 105764
		[Token(Token = "0x4019D24")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_pause;

		// Token: 0x04019D25 RID: 105765
		[Token(Token = "0x4019D25")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_pause;

		// Token: 0x04019D26 RID: 105766
		[Token(Token = "0x4019D26")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateTickFuncStatus;

		// Token: 0x04019D27 RID: 105767
		[Token(Token = "0x4019D27")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnWillRenderCanvas;

		// Token: 0x04019D28 RID: 105768
		[Token(Token = "0x4019D28")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TriggerIllustActive;

		// Token: 0x04019D29 RID: 105769
		[Token(Token = "0x4019D29")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadAssetByDynIllust;

		// Token: 0x04019D2A RID: 105770
		[Token(Token = "0x4019D2A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UnloadAssetByDynIllust;

		// Token: 0x04019D2B RID: 105771
		[Token(Token = "0x4019D2B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ClearAll;

		// Token: 0x04019D2C RID: 105772
		[Token(Token = "0x4019D2C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04019D2D RID: 105773
		[Token(Token = "0x4019D2D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Unload;

		// Token: 0x04019D2E RID: 105774
		[Token(Token = "0x4019D2E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Active;

		// Token: 0x04019D2F RID: 105775
		[Token(Token = "0x4019D2F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04019D30 RID: 105776
		[Token(Token = "0x4019D30")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019D31 RID: 105777
		[Token(Token = "0x4019D31")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x04019D32 RID: 105778
		[Token(Token = "0x4019D32")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitDisplay;

		// Token: 0x04019D33 RID: 105779
		[Token(Token = "0x4019D33")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CreateIllustView;

		// Token: 0x04019D34 RID: 105780
		[Token(Token = "0x4019D34")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RefreshViewContent;

		// Token: 0x04019D35 RID: 105781
		[Token(Token = "0x4019D35")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CreateRTForDynIllust;

		// Token: 0x04019D36 RID: 105782
		[Token(Token = "0x4019D36")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetRTSizeByRuntimePlatform;

		// Token: 0x04019D37 RID: 105783
		[Token(Token = "0x4019D37")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034CC RID: 13516
		[Token(Token = "0x20034CC")]
		private interface IRenderStrategy : IHotfixable
		{
			// Token: 0x060158B0 RID: 88240
			[Token(Token = "0x60158B0")]
			void CalcRenderTextureSize(out int width, out int height);

			// Token: 0x060158B1 RID: 88241
			[Token(Token = "0x60158B1")]
			void AddRawImageComponent(GameObject gameObject);

			// Token: 0x060158B2 RID: 88242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158B2")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "2")]
			void TriggerIllustActive(UICharacterDynIllust targetIllust)
			{
			}

			// Token: 0x060158B3 RID: 88243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158B3")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "3")]
			void OnWillRenderCanvas()
			{
			}
		}

		// Token: 0x020034CD RID: 13517
		[Token(Token = "0x20034CD")]
		private class LegacyRenderStrategy : DynIllustMgr.IRenderStrategy, IHotfixable
		{
			// Token: 0x060158B4 RID: 88244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158B4")]
			[Address(RVA = "0xE057C0", Offset = "0xE043C0", VA = "0x180E057C0")]
			public LegacyRenderStrategy(DynIllustMgr closure)
			{
			}

			// Token: 0x060158B5 RID: 88245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158B5")]
			[Address(RVA = "0xE05590", Offset = "0xE04190", VA = "0x180E05590", Slot = "5")]
			public void AddRawImageComponent(GameObject gameObject)
			{
			}

			// Token: 0x060158B6 RID: 88246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158B6")]
			[Address(RVA = "0xE05650", Offset = "0xE04250", VA = "0x180E05650", Slot = "4")]
			public void CalcRenderTextureSize(out int width, out int height)
			{
			}

			// Token: 0x04019D38 RID: 105784
			[Token(Token = "0x4019D38")]
			[FieldOffset(Offset = "0x10")]
			private DynIllustMgr m_closure;

			// Token: 0x04019D39 RID: 105785
			[Token(Token = "0x4019D39")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019D3A RID: 105786
			[Token(Token = "0x4019D3A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_AddRawImageComponent;

			// Token: 0x04019D3B RID: 105787
			[Token(Token = "0x4019D3B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CalcRenderTextureSize;
		}

		// Token: 0x020034CE RID: 13518
		[Token(Token = "0x20034CE")]
		private class AdaptiveRenderStrategy : DynIllustMgr.IRenderStrategy, IHotfixable, AdaptiveDynIllustUpdater.IContext
		{
			// Token: 0x060158B7 RID: 88247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158B7")]
			[Address(RVA = "0xDF8670", Offset = "0xDF7270", VA = "0x180DF8670")]
			public AdaptiveRenderStrategy(DynIllustMgr closure)
			{
			}

			// Token: 0x060158B8 RID: 88248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158B8")]
			[Address(RVA = "0xDF80B0", Offset = "0xDF6CB0", VA = "0x180DF80B0", Slot = "8")]
			public void FetchDynIllustList(List<UICharacterDynIllust> outputList)
			{
			}

			// Token: 0x060158B9 RID: 88249 RVA: 0x0008C880 File Offset: 0x0008AA80
			[Token(Token = "0x60158B9")]
			[Address(RVA = "0xDF8240", Offset = "0xDF6E40", VA = "0x180DF8240", Slot = "9")]
			public float GetIllustInstCameraSize()
			{
				return 0f;
			}

			// Token: 0x060158BA RID: 88250 RVA: 0x0008C898 File Offset: 0x0008AA98
			[Token(Token = "0x60158BA")]
			[Address(RVA = "0xDF82B0", Offset = "0xDF6EB0", VA = "0x180DF82B0", Slot = "10")]
			public Vector3 GetRTCameraPos()
			{
				return default(Vector3);
			}

			// Token: 0x060158BB RID: 88251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158BB")]
			[Address(RVA = "0xDF7E00", Offset = "0xDF6A00", VA = "0x180DF7E00", Slot = "11")]
			public void AdjustCamera(DynIllustGeometryUtils.Output output)
			{
			}

			// Token: 0x060158BC RID: 88252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158BC")]
			[Address(RVA = "0xDF7D40", Offset = "0xDF6940", VA = "0x180DF7D40", Slot = "5")]
			public void AddRawImageComponent(GameObject gameObject)
			{
			}

			// Token: 0x060158BD RID: 88253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158BD")]
			[Address(RVA = "0xDF8020", Offset = "0xDF6C20", VA = "0x180DF8020", Slot = "4")]
			public void CalcRenderTextureSize(out int width, out int height)
			{
			}

			// Token: 0x060158BE RID: 88254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158BE")]
			[Address(RVA = "0xDF84F0", Offset = "0xDF70F0", VA = "0x180DF84F0", Slot = "6")]
			public void TriggerIllustActive(UICharacterDynIllust illust)
			{
			}

			// Token: 0x060158BF RID: 88255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158BF")]
			[Address(RVA = "0xDF8480", Offset = "0xDF7080", VA = "0x180DF8480", Slot = "7")]
			public void OnWillRenderCanvas()
			{
			}

			// Token: 0x04019D3C RID: 105788
			[Token(Token = "0x4019D3C")]
			[FieldOffset(Offset = "0x10")]
			private DynIllustMgr m_closure;

			// Token: 0x04019D3D RID: 105789
			[Token(Token = "0x4019D3D")]
			[FieldOffset(Offset = "0x18")]
			private AdaptiveDynIllustUpdater m_updater;

			// Token: 0x04019D3E RID: 105790
			[Token(Token = "0x4019D3E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019D3F RID: 105791
			[Token(Token = "0x4019D3F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_FetchDynIllustList;

			// Token: 0x04019D40 RID: 105792
			[Token(Token = "0x4019D40")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetIllustInstCameraSize;

			// Token: 0x04019D41 RID: 105793
			[Token(Token = "0x4019D41")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetRTCameraPos;

			// Token: 0x04019D42 RID: 105794
			[Token(Token = "0x4019D42")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AdjustCamera;

			// Token: 0x04019D43 RID: 105795
			[Token(Token = "0x4019D43")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AddRawImageComponent;

			// Token: 0x04019D44 RID: 105796
			[Token(Token = "0x4019D44")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CalcRenderTextureSize;

			// Token: 0x04019D45 RID: 105797
			[Token(Token = "0x4019D45")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_TriggerIllustActive;

			// Token: 0x04019D46 RID: 105798
			[Token(Token = "0x4019D46")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnWillRenderCanvas;
		}

		// Token: 0x020034CF RID: 13519
		[Token(Token = "0x20034CF")]
		public class Context : IHotfixable
		{
			// Token: 0x060158C0 RID: 88256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158C0")]
			[Address(RVA = "0xDFA8D0", Offset = "0xDF94D0", VA = "0x180DFA8D0")]
			public Context(DynIllustMgr closure)
			{
			}

			// Token: 0x060158C1 RID: 88257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60158C1")]
			public TAsset LoadAsset<TAsset>(string path) where TAsset : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x060158C2 RID: 88258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158C2")]
			[Address(RVA = "0xDFA7F0", Offset = "0xDF93F0", VA = "0x180DFA7F0")]
			public void UnloadAsset(UnityEngine.Object asset)
			{
			}

			// Token: 0x060158C3 RID: 88259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60158C3")]
			[Address(RVA = "0xDFA600", Offset = "0xDF9200", VA = "0x180DFA600")]
			public IConverter GetConverter()
			{
				return null;
			}

			// Token: 0x04019D47 RID: 105799
			[Token(Token = "0x4019D47")]
			[FieldOffset(Offset = "0x10")]
			private DynIllustMgr m_closure;

			// Token: 0x04019D48 RID: 105800
			[Token(Token = "0x4019D48")]
			[FieldOffset(Offset = "0x18")]
			public string dynIllustId;

			// Token: 0x04019D49 RID: 105801
			[Token(Token = "0x4019D49")]
			[FieldOffset(Offset = "0x20")]
			public CharUISkinStruct skin;

			// Token: 0x04019D4A RID: 105802
			[Token(Token = "0x4019D4A")]
			[FieldOffset(Offset = "0x38")]
			public bool isSpecialDynIllust;

			// Token: 0x04019D4B RID: 105803
			[Token(Token = "0x4019D4B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019D4C RID: 105804
			[Token(Token = "0x4019D4C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_LoadAsset;

			// Token: 0x04019D4D RID: 105805
			[Token(Token = "0x4019D4D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UnloadAsset;

			// Token: 0x04019D4E RID: 105806
			[Token(Token = "0x4019D4E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetConverter;
		}
	}
}
