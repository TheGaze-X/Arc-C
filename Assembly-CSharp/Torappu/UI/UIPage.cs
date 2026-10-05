using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Network;
using Torappu.Resource;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003611 RID: 13841
	[Token(Token = "0x2003611")]
	[DisallowMultipleComponent]
	[LuaCallCSharp(GenFlag.No)]
	public class UIPage : MonoBehaviour, IHotfixable, ILoadAsset, IPageProvider
	{
		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x06016096 RID: 90262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034F1")]
		[Inspect(Level = 2)]
		protected List<UnityEngine.Object> inspectPageAssets
		{
			[Token(Token = "0x6016096")]
			[Address(RVA = "0xE8E720", Offset = "0xE8D320", VA = "0x180E8E720")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x06016097 RID: 90263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034F2")]
		public BaseAssetLoader.IAssets assets
		{
			[Token(Token = "0x6016097")]
			[Address(RVA = "0xE8E5D0", Offset = "0xE8D1D0", VA = "0x180E8E5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016098 RID: 90264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016098")]
		[Address(RVA = "0xE8BB60", Offset = "0xE8A760", VA = "0x180E8BB60")]
		public AutoReleasableGroup EnsureReleasables()
		{
			return null;
		}

		// Token: 0x06016099 RID: 90265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016099")]
		[Address(RVA = "0xE8E060", Offset = "0xE8CC60", VA = "0x180E8E060")]
		public UIPage()
		{
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0601609A RID: 90266 RVA: 0x0008F310 File Offset: 0x0008D510
		[Token(Token = "0x170034F3")]
		public UIPage.Cores cores
		{
			[Token(Token = "0x601609A")]
			[Address(RVA = "0xE8E690", Offset = "0xE8D290", VA = "0x180E8E690")]
			get
			{
				return default(UIPage.Cores);
			}
		}

		// Token: 0x0601609B RID: 90267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601609B")]
		[Address(RVA = "0xE8D1F0", Offset = "0xE8BDF0", VA = "0x180E8D1F0")]
		private void _ForceUpdateCache()
		{
		}

		// Token: 0x0601609C RID: 90268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601609C")]
		[Address(RVA = "0xE8D850", Offset = "0xE8C450", VA = "0x180E8D850")]
		private void _InitCanvasSortingInfo(SortingInfo sortingInfo)
		{
		}

		// Token: 0x0601609D RID: 90269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601609D")]
		[Address(RVA = "0xE8CE70", Offset = "0xE8BA70", VA = "0x180E8CE70")]
		private void _AdjustCanvasSortingLayers(SortingInfo sortingInfo)
		{
		}

		// Token: 0x0601609E RID: 90270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601609E")]
		[Address(RVA = "0xE8DE50", Offset = "0xE8CA50", VA = "0x180E8DE50")]
		private void _RestoreCanvasSortingLayers()
		{
		}

		// Token: 0x0601609F RID: 90271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601609F")]
		[Address(RVA = "0xE8CD20", Offset = "0xE8B920", VA = "0x180E8CD20")]
		private void _AddCanvasTrace(Canvas canvas)
		{
		}

		// Token: 0x060160A0 RID: 90272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160A0")]
		[Address(RVA = "0xE8DBA0", Offset = "0xE8C7A0", VA = "0x180E8DBA0")]
		private void _RemoveCanvasTrace(Canvas canvas)
		{
		}

		// Token: 0x060160A1 RID: 90273 RVA: 0x0008F328 File Offset: 0x0008D528
		[Token(Token = "0x60160A1")]
		[Address(RVA = "0xE8DAC0", Offset = "0xE8C6C0", VA = "0x180E8DAC0")]
		private bool _IsCanvasTraced(Canvas canvas)
		{
			return default(bool);
		}

		// Token: 0x060160A2 RID: 90274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160A2")]
		[Address(RVA = "0xE8C030", Offset = "0xE8AC30", VA = "0x180E8C030", Slot = "8")]
		protected virtual void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x060160A3 RID: 90275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160A3")]
		[Address(RVA = "0xE8C2C0", Offset = "0xE8AEC0", VA = "0x180E8C2C0", Slot = "9")]
		protected virtual void OnReuse(DataBundle savedInstance)
		{
		}

		// Token: 0x060160A4 RID: 90276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160A4")]
		[Address(RVA = "0xE8C320", Offset = "0xE8AF20", VA = "0x180E8C320", Slot = "10")]
		protected virtual void OnStart()
		{
		}

		// Token: 0x060160A5 RID: 90277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160A5")]
		[Address(RVA = "0xE8C610", Offset = "0xE8B210", VA = "0x180E8C610", Slot = "11")]
		protected virtual IEnumerator ResetForVirtualStackCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x060160A6 RID: 90278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160A6")]
		[Address(RVA = "0xE8C6B0", Offset = "0xE8B2B0", VA = "0x180E8C6B0", Slot = "12")]
		public virtual IEnumerator ShowCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x060160A7 RID: 90279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160A7")]
		[Address(RVA = "0xE8BD70", Offset = "0xE8A970", VA = "0x180E8BD70", Slot = "13")]
		protected virtual IEnumerator HideCoroutine(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x060160A8 RID: 90280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160A8")]
		[Address(RVA = "0xE8C380", Offset = "0xE8AF80", VA = "0x180E8C380", Slot = "14")]
		protected virtual void OnStop()
		{
		}

		// Token: 0x060160A9 RID: 90281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160A9")]
		[Address(RVA = "0xE8C260", Offset = "0xE8AE60", VA = "0x180E8C260", Slot = "15")]
		protected virtual void OnRecycle()
		{
		}

		// Token: 0x060160AA RID: 90282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160AA")]
		[Address(RVA = "0xE8C090", Offset = "0xE8AC90", VA = "0x180E8C090", Slot = "16")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060160AB RID: 90283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160AB")]
		[Address(RVA = "0xE8C200", Offset = "0xE8AE00", VA = "0x180E8C200", Slot = "17")]
		protected virtual void OnPageRouted()
		{
		}

		// Token: 0x060160AC RID: 90284 RVA: 0x0008F340 File Offset: 0x0008D540
		[Token(Token = "0x60160AC")]
		[Address(RVA = "0xE8B850", Offset = "0xE8A450", VA = "0x180E8B850", Slot = "18")]
		public virtual bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x060160AD RID: 90285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160AD")]
		[Address(RVA = "0xE8C140", Offset = "0xE8AD40", VA = "0x180E8C140", Slot = "19")]
		protected virtual IEnumerator OnPageReservedDuringReset(UIPageStackParam param)
		{
			return null;
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x060160AE RID: 90286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034F4")]
		public UIPage page
		{
			[Token(Token = "0x60160AE")]
			[Address(RVA = "0xE8EAA0", Offset = "0xE8D6A0", VA = "0x180E8EAA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x060160AF RID: 90287 RVA: 0x0008F358 File Offset: 0x0008D558
		[Token(Token = "0x170034F5")]
		public bool isClosed
		{
			[Token(Token = "0x60160AF")]
			[Address(RVA = "0xE8E830", Offset = "0xE8D430", VA = "0x180E8E830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x060160B0 RID: 90288 RVA: 0x0008F370 File Offset: 0x0008D570
		[Token(Token = "0x170034F6")]
		public bool isReady
		{
			[Token(Token = "0x60160B0")]
			[Address(RVA = "0xE8E980", Offset = "0xE8D580", VA = "0x180E8E980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x060160B1 RID: 90289 RVA: 0x0008F388 File Offset: 0x0008D588
		[Token(Token = "0x170034F7")]
		public bool isAboutToClose
		{
			[Token(Token = "0x60160B1")]
			[Address(RVA = "0xE8E790", Offset = "0xE8D390", VA = "0x180E8E790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060160B2 RID: 90290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160B2")]
		[Address(RVA = "0xE8BC30", Offset = "0xE8A830", VA = "0x180E8BC30")]
		public object GetArguments()
		{
			return null;
		}

		// Token: 0x060160B3 RID: 90291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160B3")]
		public ArgType GetArguments<ArgType>()
		{
			return null;
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x060160B4 RID: 90292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034F8")]
		public string pageName
		{
			[Token(Token = "0x60160B4")]
			[Address(RVA = "0xE8EA40", Offset = "0xE8D640", VA = "0x180E8EA40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060160B5 RID: 90293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160B5")]
		[Address(RVA = "0xE8B460", Offset = "0xE8A060", VA = "0x180E8B460")]
		public void ClosePage()
		{
		}

		// Token: 0x060160B6 RID: 90294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160B6")]
		public T SingleComponent<T>() where T : PageSingleComponent
		{
			return null;
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x060160B7 RID: 90295 RVA: 0x0008F3A0 File Offset: 0x0008D5A0
		[Token(Token = "0x170034F9")]
		public bool useRecycle
		{
			[Token(Token = "0x60160B7")]
			[Address(RVA = "0xE8EB60", Offset = "0xE8D760", VA = "0x180E8EB60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x060160B8 RID: 90296 RVA: 0x0008F3B8 File Offset: 0x0008D5B8
		[Token(Token = "0x170034FA")]
		public virtual AVGPageKey avgPage
		{
			[Token(Token = "0x60160B8")]
			[Address(RVA = "0xE8E630", Offset = "0xE8D230", VA = "0x180E8E630", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x060160B9 RID: 90297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034FB")]
		public virtual string musicSubSignal
		{
			[Token(Token = "0x60160B9")]
			[Address(RVA = "0xE8E9E0", Offset = "0xE8D5E0", VA = "0x180E8E9E0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x060160BA RID: 90298 RVA: 0x0008F3D0 File Offset: 0x0008D5D0
		[Token(Token = "0x170034FC")]
		public virtual bool shouldTrigAudioSignal
		{
			[Token(Token = "0x60160BA")]
			[Address(RVA = "0xE8EB00", Offset = "0xE8D700", VA = "0x180E8EB00", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060160BB RID: 90299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160BB")]
		[Address(RVA = "0xE8BFD0", Offset = "0xE8ABD0", VA = "0x180E8BFD0")]
		public void NotifyCanvasOrCameraChanged()
		{
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x060160BC RID: 90300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034FD")]
		public List<Canvas> allCanvas
		{
			[Token(Token = "0x60160BC")]
			[Address(RVA = "0xE8E4D0", Offset = "0xE8D0D0", VA = "0x180E8E4D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x060160BD RID: 90301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034FE")]
		public List<Canvas> allRootCanvas
		{
			[Token(Token = "0x60160BD")]
			[Address(RVA = "0xE8E550", Offset = "0xE8D150", VA = "0x180E8E550")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x060160BE RID: 90302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034FF")]
		public List<Camera> allCameras
		{
			[Token(Token = "0x60160BE")]
			[Address(RVA = "0xE8E460", Offset = "0xE8D060", VA = "0x180E8E460")]
			get
			{
				return null;
			}
		}

		// Token: 0x060160BF RID: 90303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160BF")]
		[Address(RVA = "0xE8C3E0", Offset = "0xE8AFE0", VA = "0x180E8C3E0")]
		public void RegisterCanvas(Canvas target)
		{
		}

		// Token: 0x060160C0 RID: 90304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160C0")]
		[Address(RVA = "0xE8CB10", Offset = "0xE8B710", VA = "0x180E8CB10")]
		public void UnregisterCanvas(Canvas target)
		{
		}

		// Token: 0x060160C1 RID: 90305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160C1")]
		[Address(RVA = "0xE8C540", Offset = "0xE8B140", VA = "0x180E8C540")]
		public void RegisterUIRenderer(IPageUIRenderer renderer)
		{
		}

		// Token: 0x060160C2 RID: 90306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160C2")]
		[Address(RVA = "0xE8CC80", Offset = "0xE8B880", VA = "0x180E8CC80")]
		public void UnregisterUIRenderer(IPageUIRenderer renderer)
		{
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x060160C3 RID: 90307 RVA: 0x0008F3E8 File Offset: 0x0008D5E8
		[Token(Token = "0x17003500")]
		public bool isComplex
		{
			[Token(Token = "0x60160C3")]
			[Address(RVA = "0xE8E910", Offset = "0xE8D510", VA = "0x180E8E910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060160C4 RID: 90308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160C4")]
		[Address(RVA = "0xE8B380", Offset = "0xE89F80", VA = "0x180E8B380")]
		public void BindUpdate(ITimeWatcher watcher)
		{
		}

		// Token: 0x060160C5 RID: 90309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160C5")]
		[Address(RVA = "0xE8C9F0", Offset = "0xE8B5F0", VA = "0x180E8C9F0")]
		public void UnbindUpdate(ITimeWatcher watcher)
		{
		}

		// Token: 0x060160C6 RID: 90310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160C6")]
		[Address(RVA = "0xE8B8C0", Offset = "0xE8A4C0", VA = "0x180E8B8C0", Slot = "23")]
		public virtual void DisplayWholePage(bool isShow)
		{
		}

		// Token: 0x060160C7 RID: 90311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160C7")]
		[Address(RVA = "0xE8BEF0", Offset = "0xE8AAF0", VA = "0x180E8BEF0")]
		public void MarkPageReady()
		{
		}

		// Token: 0x060160C8 RID: 90312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160C8")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060160C9 RID: 90313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160C9")]
		[Address(RVA = "0xE8BE50", Offset = "0xE8AA50", VA = "0x180E8BE50", Slot = "5")]
		public UnityEngine.Object LoadAsset(string path)
		{
			return null;
		}

		// Token: 0x060160CA RID: 90314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160CA")]
		[Address(RVA = "0xE8CA80", Offset = "0xE8B680", VA = "0x180E8CA80", Slot = "6")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x060160CB RID: 90315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160CB")]
		public UISender.ResultHandler<ResType> SendRequest<ResType>(Request request) where ResType : class
		{
			return null;
		}

		// Token: 0x060160CC RID: 90316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160CC")]
		[Address(RVA = "0xE8B5D0", Offset = "0xE8A1D0", VA = "0x180E8B5D0")]
		public Coroutine CoroutineWithPage(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x060160CD RID: 90317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160CD")]
		[Address(RVA = "0xE8C770", Offset = "0xE8B370", VA = "0x180E8C770")]
		public void StopPageCoroutine(Coroutine coroutine)
		{
		}

		// Token: 0x060160CE RID: 90318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160CE")]
		[Address(RVA = "0xE8B110", Offset = "0xE89D10", VA = "0x180E8B110")]
		public UIPageAssetGroup AchieveAssetGroup(Component component)
		{
			return null;
		}

		// Token: 0x060160CF RID: 90319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160CF")]
		[Address(RVA = "0xE8BC90", Offset = "0xE8A890", VA = "0x180E8BC90")]
		public UIPage.UIBlockHandler GetPageBlockHandler()
		{
			return null;
		}

		// Token: 0x060160D0 RID: 90320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160D0")]
		[Address(RVA = "0xE8DCA0", Offset = "0xE8C8A0", VA = "0x180E8DCA0")]
		private static void _RemoveInvalidCanvas(IList<Canvas> canvasList)
		{
		}

		// Token: 0x060160D1 RID: 90321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160D1")]
		[Address(RVA = "0xE8DFE0", Offset = "0xE8CBE0", VA = "0x180E8DFE0")]
		private void _TriggerPageAction(Action<UIPage> action)
		{
		}

		// Token: 0x060160D2 RID: 90322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160D2")]
		[Address(RVA = "0xE8D900", Offset = "0xE8C500", VA = "0x180E8D900")]
		private void _InitTimeTracerGroupIfNot()
		{
		}

		// Token: 0x060160D3 RID: 90323 RVA: 0x0008F400 File Offset: 0x0008D600
		[Token(Token = "0x60160D3")]
		[Address(RVA = "0xE8D5B0", Offset = "0xE8C1B0", VA = "0x180E8D5B0")]
		private int _GetAssetGroup()
		{
			return 0;
		}

		// Token: 0x060160D4 RID: 90324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160D4")]
		[Address(RVA = "0xE8D980", Offset = "0xE8C580", VA = "0x180E8D980")]
		private void _InitUIRendererLayers(SortingInfo sortingInfo)
		{
		}

		// Token: 0x060160D5 RID: 90325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160D5")]
		[Address(RVA = "0xE8CF30", Offset = "0xE8BB30", VA = "0x180E8CF30")]
		private void _AdjustUIRendererLayers(SortingInfo sortingInfo)
		{
		}

		// Token: 0x060160D6 RID: 90326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160D6")]
		[Address(RVA = "0xE8DED0", Offset = "0xE8CAD0", VA = "0x180E8DED0")]
		private void _RestoreUIRendererLayers()
		{
		}

		// Token: 0x060160D7 RID: 90327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160D7")]
		[Address(RVA = "0xE8B2C0", Offset = "0xE89EC0", VA = "0x180E8B2C0")]
		protected IEnumerator BasicShowEffect(bool isFromStack)
		{
			return null;
		}

		// Token: 0x060160D8 RID: 90328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160D8")]
		[Address(RVA = "0xE8B1E0", Offset = "0xE89DE0", VA = "0x180E8B1E0")]
		protected IEnumerator BasicHideEffect(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x060160D9 RID: 90329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60160D9")]
		[Address(RVA = "0xE8D610", Offset = "0xE8C210", VA = "0x180E8D610")]
		private static void _InitBeforeRender(string logToken, string accessToken)
		{
		}

		// Token: 0x060160DA RID: 90330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60160DA")]
		[Address(RVA = "0xE8D070", Offset = "0xE8BC70", VA = "0x180E8D070")]
		private static string _ChangeRandomName(string fieldName, string code1, string code2)
		{
			return null;
		}

		// Token: 0x0401A7A0 RID: 108448
		[Token(Token = "0x401A7A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Whether the page should be recycled to reuse when popped out")]
		private bool _useRecycle;

		// Token: 0x0401A7A1 RID: 108449
		[Token(Token = "0x401A7A1")]
		[FieldOffset(Offset = "0x20")]
		[Inspect(Level = 2)]
		[ReadOnly]
		private ListDict<string, PageSingleComponent> m_singleComps;

		// Token: 0x0401A7A2 RID: 108450
		[Token(Token = "0x401A7A2")]
		[FieldOffset(Offset = "0x28")]
		[Inspect(Level = 2)]
		[ReadOnly]
		private List<UIPageListener> m_listeners;

		// Token: 0x0401A7A3 RID: 108451
		[Token(Token = "0x401A7A3")]
		[FieldOffset(Offset = "0x30")]
		[Inspect(Level = 2)]
		[ReadOnly]
		private UIPage.PageState m_pageState;

		// Token: 0x0401A7A4 RID: 108452
		[Token(Token = "0x401A7A4")]
		[FieldOffset(Offset = "0x38")]
		private object m_args;

		// Token: 0x0401A7A5 RID: 108453
		[Token(Token = "0x401A7A5")]
		[FieldOffset(Offset = "0x40")]
		private string m_pageName;

		// Token: 0x0401A7A6 RID: 108454
		[Token(Token = "0x401A7A6")]
		[FieldOffset(Offset = "0x48")]
		private UIPage.Cores m_core;

		// Token: 0x0401A7A7 RID: 108455
		[Token(Token = "0x401A7A7")]
		[FieldOffset(Offset = "0x78")]
		private UIPage.PageAssets m_assets;

		// Token: 0x0401A7A8 RID: 108456
		[Token(Token = "0x401A7A8")]
		[FieldOffset(Offset = "0x80")]
		private int m_timeTracerGroup;

		// Token: 0x0401A7A9 RID: 108457
		[Token(Token = "0x401A7A9")]
		[FieldOffset(Offset = "0x88")]
		private List<UIPage.CoroutineId> m_activeCoroWithPage;

		// Token: 0x0401A7AA RID: 108458
		[Token(Token = "0x401A7AA")]
		[FieldOffset(Offset = "0x90")]
		private Queue<UIPage.CoroutineId> m_coroutinePool;

		// Token: 0x0401A7AB RID: 108459
		[Token(Token = "0x401A7AB")]
		[FieldOffset(Offset = "0x98")]
		private List<IPageUIRenderer> m_registeredUIRenderers;

		// Token: 0x0401A7AC RID: 108460
		[Token(Token = "0x401A7AC")]
		[FieldOffset(Offset = "0xA0")]
		protected UIPage.Plugin plugin;

		// Token: 0x0401A7AD RID: 108461
		[Token(Token = "0x401A7AD")]
		[FieldOffset(Offset = "0xA8")]
		private List<Canvas> m_allRootCanvas;

		// Token: 0x0401A7AE RID: 108462
		[Token(Token = "0x401A7AE")]
		[FieldOffset(Offset = "0xB0")]
		private UICanvasSortingInfoStorage m_canvasSortingInfo;

		// Token: 0x0401A7AF RID: 108463
		[Token(Token = "0x401A7AF")]
		[FieldOffset(Offset = "0xB8")]
		private ListDict<Canvas, int> m_tracedCanvasLayers;

		// Token: 0x0401A7B0 RID: 108464
		[Token(Token = "0x401A7B0")]
		[FieldOffset(Offset = "0xC0")]
		private List<Canvas> m_allCanvas;

		// Token: 0x0401A7B1 RID: 108465
		[Token(Token = "0x401A7B1")]
		[FieldOffset(Offset = "0xC8")]
		private List<Camera> m_allCameras;

		// Token: 0x0401A7B2 RID: 108466
		[Token(Token = "0x401A7B2")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isComplex;

		// Token: 0x0401A7B3 RID: 108467
		[Token(Token = "0x401A7B3")]
		[FieldOffset(Offset = "0xD1")]
		private bool m_isCacheDirty;

		// Token: 0x0401A7B4 RID: 108468
		[Token(Token = "0x401A7B4")]
		[FieldOffset(Offset = "0xD2")]
		private bool m_makeCacheDirtyDuringNextTrans;

		// Token: 0x0401A7B5 RID: 108469
		[Token(Token = "0x401A7B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inspectPageAssets;

		// Token: 0x0401A7B6 RID: 108470
		[Token(Token = "0x401A7B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_assets;

		// Token: 0x0401A7B7 RID: 108471
		[Token(Token = "0x401A7B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EnsureReleasables;

		// Token: 0x0401A7B8 RID: 108472
		[Token(Token = "0x401A7B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A7B9 RID: 108473
		[Token(Token = "0x401A7B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cores;

		// Token: 0x0401A7BA RID: 108474
		[Token(Token = "0x401A7BA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ForceUpdateCache;

		// Token: 0x0401A7BB RID: 108475
		[Token(Token = "0x401A7BB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitCanvasSortingInfo;

		// Token: 0x0401A7BC RID: 108476
		[Token(Token = "0x401A7BC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AdjustCanvasSortingLayers;

		// Token: 0x0401A7BD RID: 108477
		[Token(Token = "0x401A7BD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RestoreCanvasSortingLayers;

		// Token: 0x0401A7BE RID: 108478
		[Token(Token = "0x401A7BE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AddCanvasTrace;

		// Token: 0x0401A7BF RID: 108479
		[Token(Token = "0x401A7BF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RemoveCanvasTrace;

		// Token: 0x0401A7C0 RID: 108480
		[Token(Token = "0x401A7C0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__IsCanvasTraced;

		// Token: 0x0401A7C1 RID: 108481
		[Token(Token = "0x401A7C1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401A7C2 RID: 108482
		[Token(Token = "0x401A7C2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnReuse;

		// Token: 0x0401A7C3 RID: 108483
		[Token(Token = "0x401A7C3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0401A7C4 RID: 108484
		[Token(Token = "0x401A7C4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ResetForVirtualStackCoroutine;

		// Token: 0x0401A7C5 RID: 108485
		[Token(Token = "0x401A7C5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401A7C6 RID: 108486
		[Token(Token = "0x401A7C6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401A7C7 RID: 108487
		[Token(Token = "0x401A7C7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0401A7C8 RID: 108488
		[Token(Token = "0x401A7C8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0401A7C9 RID: 108489
		[Token(Token = "0x401A7C9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401A7CA RID: 108490
		[Token(Token = "0x401A7CA")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x0401A7CB RID: 108491
		[Token(Token = "0x401A7CB")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x0401A7CC RID: 108492
		[Token(Token = "0x401A7CC")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnPageReservedDuringReset;

		// Token: 0x0401A7CD RID: 108493
		[Token(Token = "0x401A7CD")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0401A7CE RID: 108494
		[Token(Token = "0x401A7CE")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_isClosed;

		// Token: 0x0401A7CF RID: 108495
		[Token(Token = "0x401A7CF")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x0401A7D0 RID: 108496
		[Token(Token = "0x401A7D0")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_isAboutToClose;

		// Token: 0x0401A7D1 RID: 108497
		[Token(Token = "0x401A7D1")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetArguments;

		// Token: 0x0401A7D2 RID: 108498
		[Token(Token = "0x401A7D2")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix1_GetArguments;

		// Token: 0x0401A7D3 RID: 108499
		[Token(Token = "0x401A7D3")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_pageName;

		// Token: 0x0401A7D4 RID: 108500
		[Token(Token = "0x401A7D4")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_ClosePage;

		// Token: 0x0401A7D5 RID: 108501
		[Token(Token = "0x401A7D5")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_SingleComponent;

		// Token: 0x0401A7D6 RID: 108502
		[Token(Token = "0x401A7D6")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_useRecycle;

		// Token: 0x0401A7D7 RID: 108503
		[Token(Token = "0x401A7D7")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x0401A7D8 RID: 108504
		[Token(Token = "0x401A7D8")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_musicSubSignal;

		// Token: 0x0401A7D9 RID: 108505
		[Token(Token = "0x401A7D9")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_shouldTrigAudioSignal;

		// Token: 0x0401A7DA RID: 108506
		[Token(Token = "0x401A7DA")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_NotifyCanvasOrCameraChanged;

		// Token: 0x0401A7DB RID: 108507
		[Token(Token = "0x401A7DB")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_allCanvas;

		// Token: 0x0401A7DC RID: 108508
		[Token(Token = "0x401A7DC")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_allRootCanvas;

		// Token: 0x0401A7DD RID: 108509
		[Token(Token = "0x401A7DD")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_allCameras;

		// Token: 0x0401A7DE RID: 108510
		[Token(Token = "0x401A7DE")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_RegisterCanvas;

		// Token: 0x0401A7DF RID: 108511
		[Token(Token = "0x401A7DF")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_UnregisterCanvas;

		// Token: 0x0401A7E0 RID: 108512
		[Token(Token = "0x401A7E0")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_RegisterUIRenderer;

		// Token: 0x0401A7E1 RID: 108513
		[Token(Token = "0x401A7E1")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_UnregisterUIRenderer;

		// Token: 0x0401A7E2 RID: 108514
		[Token(Token = "0x401A7E2")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_isComplex;

		// Token: 0x0401A7E3 RID: 108515
		[Token(Token = "0x401A7E3")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_BindUpdate;

		// Token: 0x0401A7E4 RID: 108516
		[Token(Token = "0x401A7E4")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_UnbindUpdate;

		// Token: 0x0401A7E5 RID: 108517
		[Token(Token = "0x401A7E5")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_DisplayWholePage;

		// Token: 0x0401A7E6 RID: 108518
		[Token(Token = "0x401A7E6")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_MarkPageReady;

		// Token: 0x0401A7E7 RID: 108519
		[Token(Token = "0x401A7E7")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0401A7E8 RID: 108520
		[Token(Token = "0x401A7E8")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix1_LoadAsset;

		// Token: 0x0401A7E9 RID: 108521
		[Token(Token = "0x401A7E9")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x0401A7EA RID: 108522
		[Token(Token = "0x401A7EA")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x0401A7EB RID: 108523
		[Token(Token = "0x401A7EB")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_CoroutineWithPage;

		// Token: 0x0401A7EC RID: 108524
		[Token(Token = "0x401A7EC")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_StopPageCoroutine;

		// Token: 0x0401A7ED RID: 108525
		[Token(Token = "0x401A7ED")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_AchieveAssetGroup;

		// Token: 0x0401A7EE RID: 108526
		[Token(Token = "0x401A7EE")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_GetPageBlockHandler;

		// Token: 0x0401A7EF RID: 108527
		[Token(Token = "0x401A7EF")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__RemoveInvalidCanvas;

		// Token: 0x0401A7F0 RID: 108528
		[Token(Token = "0x401A7F0")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__TriggerPageAction;

		// Token: 0x0401A7F1 RID: 108529
		[Token(Token = "0x401A7F1")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__InitTimeTracerGroupIfNot;

		// Token: 0x0401A7F2 RID: 108530
		[Token(Token = "0x401A7F2")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__GetAssetGroup;

		// Token: 0x0401A7F3 RID: 108531
		[Token(Token = "0x401A7F3")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__InitUIRendererLayers;

		// Token: 0x0401A7F4 RID: 108532
		[Token(Token = "0x401A7F4")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__AdjustUIRendererLayers;

		// Token: 0x0401A7F5 RID: 108533
		[Token(Token = "0x401A7F5")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__RestoreUIRendererLayers;

		// Token: 0x0401A7F6 RID: 108534
		[Token(Token = "0x401A7F6")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_BasicShowEffect;

		// Token: 0x0401A7F7 RID: 108535
		[Token(Token = "0x401A7F7")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_BasicHideEffect;

		// Token: 0x0401A7F8 RID: 108536
		[Token(Token = "0x401A7F8")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__InitBeforeRender;

		// Token: 0x0401A7F9 RID: 108537
		[Token(Token = "0x401A7F9")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__ChangeRandomName;

		// Token: 0x02003612 RID: 13842
		[Token(Token = "0x2003612")]
		public class Plugin
		{
			// Token: 0x17003501 RID: 13569
			// (get) Token: 0x060160DB RID: 90331 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003501")]
			protected UIPage page
			{
				[Token(Token = "0x60160DB")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060160DC RID: 90332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160DC")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "4")]
			public virtual void BindPage(UIPage context)
			{
			}

			// Token: 0x060160DD RID: 90333 RVA: 0x0008F418 File Offset: 0x0008D618
			[Token(Token = "0x60160DD")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
			public virtual bool OverrideCreate(Action<DataBundle> onCreate, DataBundle savedInst)
			{
				return default(bool);
			}

			// Token: 0x060160DE RID: 90334 RVA: 0x0008F430 File Offset: 0x0008D630
			[Token(Token = "0x60160DE")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
			public virtual bool OverrideReuse(Action<DataBundle> reuse, DataBundle savedInst)
			{
				return default(bool);
			}

			// Token: 0x060160DF RID: 90335 RVA: 0x0008F448 File Offset: 0x0008D648
			[Token(Token = "0x60160DF")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			public virtual bool OverrideStart(Action onStart)
			{
				return default(bool);
			}

			// Token: 0x060160E0 RID: 90336 RVA: 0x0008F460 File Offset: 0x0008D660
			[Token(Token = "0x60160E0")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			public virtual bool OverrideStop(Action onStop)
			{
				return default(bool);
			}

			// Token: 0x060160E1 RID: 90337 RVA: 0x0008F478 File Offset: 0x0008D678
			[Token(Token = "0x60160E1")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "9")]
			public virtual bool OverrideRecycle(Action onRecycle)
			{
				return default(bool);
			}

			// Token: 0x060160E2 RID: 90338 RVA: 0x0008F490 File Offset: 0x0008D690
			[Token(Token = "0x60160E2")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			public virtual bool OverridePageRouted(Action onPageRouted)
			{
				return default(bool);
			}

			// Token: 0x060160E3 RID: 90339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160E3")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
			public virtual void OnDestroy()
			{
			}

			// Token: 0x060160E4 RID: 90340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160E4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Plugin()
			{
			}

			// Token: 0x0401A7FA RID: 108538
			[Token(Token = "0x401A7FA")]
			[FieldOffset(Offset = "0x10")]
			private UIPage m_page;
		}

		// Token: 0x02003613 RID: 13843
		[Token(Token = "0x2003613")]
		private enum PageState
		{
			// Token: 0x0401A7FC RID: 108540
			[Token(Token = "0x401A7FC")]
			NONE,
			// Token: 0x0401A7FD RID: 108541
			[Token(Token = "0x401A7FD")]
			CREATED = 10,
			// Token: 0x0401A7FE RID: 108542
			[Token(Token = "0x401A7FE")]
			STARTED = 20,
			// Token: 0x0401A7FF RID: 108543
			[Token(Token = "0x401A7FF")]
			READY = 30,
			// Token: 0x0401A800 RID: 108544
			[Token(Token = "0x401A800")]
			ROUTED = 40,
			// Token: 0x0401A801 RID: 108545
			[Token(Token = "0x401A801")]
			HIDING = 45,
			// Token: 0x0401A802 RID: 108546
			[Token(Token = "0x401A802")]
			STOPPED = 50,
			// Token: 0x0401A803 RID: 108547
			[Token(Token = "0x401A803")]
			RECYCLED = 60
		}

		// Token: 0x02003614 RID: 13844
		[Token(Token = "0x2003614")]
		public struct Cores : IHotfixable
		{
			// Token: 0x17003502 RID: 13570
			// (get) Token: 0x060160E5 RID: 90341 RVA: 0x0008F4A8 File Offset: 0x0008D6A8
			// (set) Token: 0x060160E6 RID: 90342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003502")]
			public bool isAboutToBeDisposed
			{
				[Token(Token = "0x60160E5")]
				[Address(RVA = "0xE91890", Offset = "0xE90490", VA = "0x180E91890")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x60160E6")]
				[Address(RVA = "0xE91B40", Offset = "0xE90740", VA = "0x180E91B40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17003503 RID: 13571
			// (get) Token: 0x060160E7 RID: 90343 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060160E8 RID: 90344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003503")]
			public UIDisposableSender pageSender
			{
				[Token(Token = "0x60160E7")]
				[Address(RVA = "0xE91A30", Offset = "0xE90630", VA = "0x180E91A30")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x60160E8")]
				[Address(RVA = "0xE91C70", Offset = "0xE90870", VA = "0x180E91C70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17003504 RID: 13572
			// (get) Token: 0x060160E9 RID: 90345 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060160EA RID: 90346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003504")]
			public UIPage.UIBlockHandler pageBlockHandler
			{
				[Token(Token = "0x60160E9")]
				[Address(RVA = "0xE919B0", Offset = "0xE905B0", VA = "0x180E919B0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x60160EA")]
				[Address(RVA = "0xE91BD0", Offset = "0xE907D0", VA = "0x180E91BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17003505 RID: 13573
			// (get) Token: 0x060160EB RID: 90347 RVA: 0x0008F4C0 File Offset: 0x0008D6C0
			[Token(Token = "0x17003505")]
			public bool isEmpty
			{
				[Token(Token = "0x60160EB")]
				[Address(RVA = "0xE91910", Offset = "0xE90510", VA = "0x180E91910")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003506 RID: 13574
			// (get) Token: 0x060160EC RID: 90348 RVA: 0x0008F4D8 File Offset: 0x0008D6D8
			// (set) Token: 0x060160ED RID: 90349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003506")]
			public bool hideIntoStack
			{
				[Token(Token = "0x60160EC")]
				[Address(RVA = "0xE91810", Offset = "0xE90410", VA = "0x180E91810")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x60160ED")]
				[Address(RVA = "0xE91AB0", Offset = "0xE906B0", VA = "0x180E91AB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060160EE RID: 90350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160EE")]
			[Address(RVA = "0xE91680", Offset = "0xE90280", VA = "0x180E91680")]
			public Cores(UIPage page)
			{
			}

			// Token: 0x060160EF RID: 90351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160EF")]
			[Address(RVA = "0xE8F340", Offset = "0xE8DF40", VA = "0x180E8F340")]
			public void RegisterSingleComponent(PageSingleComponent comp)
			{
			}

			// Token: 0x060160F0 RID: 90352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160F0")]
			[Address(RVA = "0xE8F620", Offset = "0xE8E220", VA = "0x180E8F620")]
			public void SetArguments(object args)
			{
			}

			// Token: 0x060160F1 RID: 90353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160F1")]
			[Address(RVA = "0xE8F6C0", Offset = "0xE8E2C0", VA = "0x180E8F6C0")]
			public void SetPageName(string name)
			{
			}

			// Token: 0x060160F2 RID: 90354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160F2")]
			[Address(RVA = "0xE8F760", Offset = "0xE8E360", VA = "0x180E8F760")]
			public void SetPlugin(UIPage.Plugin plugin)
			{
			}

			// Token: 0x060160F3 RID: 90355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160F3")]
			[Address(RVA = "0xE8F290", Offset = "0xE8DE90", VA = "0x180E8F290")]
			public void NotifyBindToCoreComp()
			{
			}

			// Token: 0x060160F4 RID: 90356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160F4")]
			[Address(RVA = "0xE8F840", Offset = "0xE8E440", VA = "0x180E8F840")]
			public void TriggerCreate(DataBundle savedInstance)
			{
			}

			// Token: 0x060160F5 RID: 90357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160F5")]
			[Address(RVA = "0xE901A0", Offset = "0xE8EDA0", VA = "0x180E901A0")]
			public void TriggerReuse(DataBundle savedInstance)
			{
			}

			// Token: 0x060160F6 RID: 90358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160F6")]
			[Address(RVA = "0xE905F0", Offset = "0xE8F1F0", VA = "0x180E905F0")]
			public void TriggerStart()
			{
			}

			// Token: 0x060160F7 RID: 90359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160F7")]
			[Address(RVA = "0xE90810", Offset = "0xE8F410", VA = "0x180E90810")]
			public void TriggerStop()
			{
			}

			// Token: 0x060160F8 RID: 90360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160F8")]
			[Address(RVA = "0xE8FF20", Offset = "0xE8EB20", VA = "0x180E8FF20")]
			public void TriggerRecycle()
			{
			}

			// Token: 0x060160F9 RID: 90361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160F9")]
			[Address(RVA = "0xE903C0", Offset = "0xE8EFC0", VA = "0x180E903C0")]
			public void TriggerRouted()
			{
			}

			// Token: 0x060160FA RID: 90362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160FA")]
			[Address(RVA = "0xE8FCA0", Offset = "0xE8E8A0", VA = "0x180E8FCA0")]
			public void TriggerPageReady()
			{
			}

			// Token: 0x060160FB RID: 90363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160FB")]
			[Address(RVA = "0xE8FA60", Offset = "0xE8E660", VA = "0x180E8FA60")]
			public void TriggerDestroy()
			{
			}

			// Token: 0x060160FC RID: 90364 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60160FC")]
			[Address(RVA = "0xE8FB80", Offset = "0xE8E780", VA = "0x180E8FB80")]
			public IEnumerator TriggerHideCoroutine(bool isIntoStack, bool isRemoveVirtualTop)
			{
				return null;
			}

			// Token: 0x060160FD RID: 90365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160FD")]
			[Address(RVA = "0xE8EEC0", Offset = "0xE8DAC0", VA = "0x180E8EEC0")]
			public void AddListener(UIPageListener listener)
			{
			}

			// Token: 0x060160FE RID: 90366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160FE")]
			[Address(RVA = "0xE8F120", Offset = "0xE8DD20", VA = "0x180E8F120")]
			public void ClearDisplayCacheIfNeeeded()
			{
			}

			// Token: 0x060160FF RID: 90367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60160FF")]
			[Address(RVA = "0xE8F1C0", Offset = "0xE8DDC0", VA = "0x180E8F1C0")]
			public void InitSortingLayers(SortingInfo sortingInfo)
			{
			}

			// Token: 0x06016100 RID: 90368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016100")]
			[Address(RVA = "0xE8F050", Offset = "0xE8DC50", VA = "0x180E8F050")]
			public void AdjustUISortingLayers(SortingInfo sortingInfo)
			{
			}

			// Token: 0x06016101 RID: 90369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016101")]
			[Address(RVA = "0xE8F580", Offset = "0xE8E180", VA = "0x180E8F580")]
			public void RestoreUISortingLayers()
			{
			}

			// Token: 0x06016102 RID: 90370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016102")]
			[Address(RVA = "0xE8FDF0", Offset = "0xE8E9F0", VA = "0x180E8FDF0")]
			public IEnumerator TriggerPageReservedDuringReset(UIPageStackParam param)
			{
				return null;
			}

			// Token: 0x06016103 RID: 90371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016103")]
			[Address(RVA = "0xE90A40", Offset = "0xE8F640", VA = "0x180E90A40")]
			private void _OnCreateCore()
			{
			}

			// Token: 0x06016104 RID: 90372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016104")]
			[Address(RVA = "0xE90CA0", Offset = "0xE8F8A0", VA = "0x180E90CA0")]
			private void _OnReuseCore()
			{
			}

			// Token: 0x06016105 RID: 90373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016105")]
			[Address(RVA = "0xE90DC0", Offset = "0xE8F9C0", VA = "0x180E90DC0")]
			private void _OnStartCore()
			{
			}

			// Token: 0x06016106 RID: 90374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016106")]
			[Address(RVA = "0xE91370", Offset = "0xE8FF70", VA = "0x180E91370")]
			private void _TryModifyPageMusic()
			{
			}

			// Token: 0x06016107 RID: 90375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016107")]
			[Address(RVA = "0xE90C30", Offset = "0xE8F830", VA = "0x180E90C30")]
			private void _OnRecycleCore()
			{
			}

			// Token: 0x06016108 RID: 90376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016108")]
			[Address(RVA = "0xE90EB0", Offset = "0xE8FAB0", VA = "0x180E90EB0")]
			private void _OnStopCore()
			{
			}

			// Token: 0x06016109 RID: 90377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016109")]
			[Address(RVA = "0xE90B30", Offset = "0xE8F730", VA = "0x180E90B30")]
			private void _OnDestroyCore()
			{
			}

			// Token: 0x0401A804 RID: 108548
			[Token(Token = "0x401A804")]
			[FieldOffset(Offset = "0x0")]
			private UIPage m_page;

			// Token: 0x0401A808 RID: 108552
			[Token(Token = "0x401A808")]
			[FieldOffset(Offset = "0x20")]
			public AutoReleasableGroup autoReleaseGroup;

			// Token: 0x0401A80A RID: 108554
			[Token(Token = "0x401A80A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isAboutToBeDisposed;

			// Token: 0x0401A80B RID: 108555
			[Token(Token = "0x401A80B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isAboutToBeDisposed;

			// Token: 0x0401A80C RID: 108556
			[Token(Token = "0x401A80C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_pageSender;

			// Token: 0x0401A80D RID: 108557
			[Token(Token = "0x401A80D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_pageSender;

			// Token: 0x0401A80E RID: 108558
			[Token(Token = "0x401A80E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_pageBlockHandler;

			// Token: 0x0401A80F RID: 108559
			[Token(Token = "0x401A80F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_pageBlockHandler;

			// Token: 0x0401A810 RID: 108560
			[Token(Token = "0x401A810")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x0401A811 RID: 108561
			[Token(Token = "0x401A811")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_hideIntoStack;

			// Token: 0x0401A812 RID: 108562
			[Token(Token = "0x401A812")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_set_hideIntoStack;

			// Token: 0x0401A813 RID: 108563
			[Token(Token = "0x401A813")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401A814 RID: 108564
			[Token(Token = "0x401A814")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_RegisterSingleComponent;

			// Token: 0x0401A815 RID: 108565
			[Token(Token = "0x401A815")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_SetArguments;

			// Token: 0x0401A816 RID: 108566
			[Token(Token = "0x401A816")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_SetPageName;

			// Token: 0x0401A817 RID: 108567
			[Token(Token = "0x401A817")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_SetPlugin;

			// Token: 0x0401A818 RID: 108568
			[Token(Token = "0x401A818")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_NotifyBindToCoreComp;

			// Token: 0x0401A819 RID: 108569
			[Token(Token = "0x401A819")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_TriggerCreate;

			// Token: 0x0401A81A RID: 108570
			[Token(Token = "0x401A81A")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_TriggerReuse;

			// Token: 0x0401A81B RID: 108571
			[Token(Token = "0x401A81B")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_TriggerStart;

			// Token: 0x0401A81C RID: 108572
			[Token(Token = "0x401A81C")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_TriggerStop;

			// Token: 0x0401A81D RID: 108573
			[Token(Token = "0x401A81D")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_TriggerRecycle;

			// Token: 0x0401A81E RID: 108574
			[Token(Token = "0x401A81E")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_TriggerRouted;

			// Token: 0x0401A81F RID: 108575
			[Token(Token = "0x401A81F")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_TriggerPageReady;

			// Token: 0x0401A820 RID: 108576
			[Token(Token = "0x401A820")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_TriggerDestroy;

			// Token: 0x0401A821 RID: 108577
			[Token(Token = "0x401A821")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_TriggerHideCoroutine;

			// Token: 0x0401A822 RID: 108578
			[Token(Token = "0x401A822")]
			[FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_AddListener;

			// Token: 0x0401A823 RID: 108579
			[Token(Token = "0x401A823")]
			[FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_ClearDisplayCacheIfNeeeded;

			// Token: 0x0401A824 RID: 108580
			[Token(Token = "0x401A824")]
			[FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_InitSortingLayers;

			// Token: 0x0401A825 RID: 108581
			[Token(Token = "0x401A825")]
			[FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_AdjustUISortingLayers;

			// Token: 0x0401A826 RID: 108582
			[Token(Token = "0x401A826")]
			[FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_RestoreUISortingLayers;

			// Token: 0x0401A827 RID: 108583
			[Token(Token = "0x401A827")]
			[FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_TriggerPageReservedDuringReset;

			// Token: 0x0401A828 RID: 108584
			[Token(Token = "0x401A828")]
			[FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0__OnCreateCore;

			// Token: 0x0401A829 RID: 108585
			[Token(Token = "0x401A829")]
			[FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0__OnReuseCore;

			// Token: 0x0401A82A RID: 108586
			[Token(Token = "0x401A82A")]
			[FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0__OnStartCore;

			// Token: 0x0401A82B RID: 108587
			[Token(Token = "0x401A82B")]
			[FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0__TryModifyPageMusic;

			// Token: 0x0401A82C RID: 108588
			[Token(Token = "0x401A82C")]
			[FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0__OnRecycleCore;

			// Token: 0x0401A82D RID: 108589
			[Token(Token = "0x401A82D")]
			[FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0__OnStopCore;

			// Token: 0x0401A82E RID: 108590
			[Token(Token = "0x401A82E")]
			[FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0__OnDestroyCore;
		}

		// Token: 0x02003617 RID: 13847
		[Token(Token = "0x2003617")]
		private class PageAssets : BaseAssetLoader.IAssets, IHotfixable
		{
			// Token: 0x06016116 RID: 90390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016116")]
			[Address(RVA = "0xE93760", Offset = "0xE92360", VA = "0x180E93760")]
			public PageAssets(UIPage closure)
			{
			}

			// Token: 0x1700350B RID: 13579
			// (get) Token: 0x06016117 RID: 90391 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700350B")]
			public List<UnityEngine.Object> inspectAssets
			{
				[Token(Token = "0x6016117")]
				[Address(RVA = "0xE93830", Offset = "0xE92430", VA = "0x180E93830")]
				get
				{
					return null;
				}
			}

			// Token: 0x06016118 RID: 90392 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016118")]
			[Address(RVA = "0xE931A0", Offset = "0xE91DA0", VA = "0x180E931A0")]
			public UIPageAssetGroup AchieveAsssetGroup(int assetGroupId)
			{
				return null;
			}

			// Token: 0x06016119 RID: 90393 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016119")]
			public T LoadAsset<T>(string path) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x0601611A RID: 90394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601611A")]
			[Address(RVA = "0xE93640", Offset = "0xE92240", VA = "0x180E93640")]
			public void UnloadAsset(UnityEngine.Object asset)
			{
			}

			// Token: 0x0601611B RID: 90395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601611B")]
			[Address(RVA = "0xE93350", Offset = "0xE91F50", VA = "0x180E93350")]
			public void ClearAllAssets()
			{
			}

			// Token: 0x0401A838 RID: 108600
			[Token(Token = "0x401A838")]
			[FieldOffset(Offset = "0x10")]
			private UIPage m_closure;

			// Token: 0x0401A839 RID: 108601
			[Token(Token = "0x401A839")]
			[FieldOffset(Offset = "0x18")]
			private HashSet<UnityEngine.Object> m_loadedAssets;

			// Token: 0x0401A83A RID: 108602
			[Token(Token = "0x401A83A")]
			[FieldOffset(Offset = "0x20")]
			private ListDict<int, UIPageAssetGroup> m_assetGroups;

			// Token: 0x0401A83B RID: 108603
			[Token(Token = "0x401A83B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401A83C RID: 108604
			[Token(Token = "0x401A83C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_inspectAssets;

			// Token: 0x0401A83D RID: 108605
			[Token(Token = "0x401A83D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_AchieveAsssetGroup;

			// Token: 0x0401A83E RID: 108606
			[Token(Token = "0x401A83E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LoadAsset;

			// Token: 0x0401A83F RID: 108607
			[Token(Token = "0x401A83F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UnloadAsset;

			// Token: 0x0401A840 RID: 108608
			[Token(Token = "0x401A840")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ClearAllAssets;
		}

		// Token: 0x02003618 RID: 13848
		[Token(Token = "0x2003618")]
		public class UIBlockHandler : IRefCountInstance, IHotfixable
		{
			// Token: 0x0601611C RID: 90396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601611C")]
			[Address(RVA = "0xEA3360", Offset = "0xEA1F60", VA = "0x180EA3360")]
			public UIBlockHandler(UIPage page)
			{
			}

			// Token: 0x0601611D RID: 90397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601611D")]
			[Address(RVA = "0xEA2FC0", Offset = "0xEA1BC0", VA = "0x180EA2FC0", Slot = "4")]
			public void Retain()
			{
			}

			// Token: 0x0601611E RID: 90398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601611E")]
			[Address(RVA = "0xEA2E30", Offset = "0xEA1A30", VA = "0x180EA2E30", Slot = "5")]
			public void Release()
			{
			}

			// Token: 0x0601611F RID: 90399 RVA: 0x0008F520 File Offset: 0x0008D720
			[Token(Token = "0x601611F")]
			[Address(RVA = "0xEA2D70", Offset = "0xEA1970", VA = "0x180EA2D70", Slot = "6")]
			public long GetInstSignature()
			{
				return 0L;
			}

			// Token: 0x06016120 RID: 90400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016120")]
			[Address(RVA = "0xEA3110", Offset = "0xEA1D10", VA = "0x180EA3110")]
			private void _OnRefActive()
			{
			}

			// Token: 0x06016121 RID: 90401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016121")]
			[Address(RVA = "0xEA3210", Offset = "0xEA1E10", VA = "0x180EA3210")]
			private void _OnRefInactive()
			{
			}

			// Token: 0x0401A841 RID: 108609
			[Token(Token = "0x401A841")]
			[FieldOffset(Offset = "0x10")]
			private int m_refCount;

			// Token: 0x0401A842 RID: 108610
			[Token(Token = "0x401A842")]
			[FieldOffset(Offset = "0x18")]
			private UIPage m_page;

			// Token: 0x0401A843 RID: 108611
			[Token(Token = "0x401A843")]
			[FieldOffset(Offset = "0x20")]
			private int m_signature;

			// Token: 0x0401A844 RID: 108612
			[Token(Token = "0x401A844")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401A845 RID: 108613
			[Token(Token = "0x401A845")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Retain;

			// Token: 0x0401A846 RID: 108614
			[Token(Token = "0x401A846")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Release;

			// Token: 0x0401A847 RID: 108615
			[Token(Token = "0x401A847")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetInstSignature;

			// Token: 0x0401A848 RID: 108616
			[Token(Token = "0x401A848")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__OnRefActive;

			// Token: 0x0401A849 RID: 108617
			[Token(Token = "0x401A849")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__OnRefInactive;
		}

		// Token: 0x02003619 RID: 13849
		[Token(Token = "0x2003619")]
		private class CoroutineId
		{
			// Token: 0x06016122 RID: 90402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016122")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private CoroutineId()
			{
			}

			// Token: 0x1700350C RID: 13580
			// (get) Token: 0x06016123 RID: 90403 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016124 RID: 90404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700350C")]
			public IEnumerator routine
			{
				[Token(Token = "0x6016123")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6016124")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06016125 RID: 90405 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016125")]
			[Address(RVA = "0xE91EA0", Offset = "0xE90AA0", VA = "0x180E91EA0")]
			public Coroutine GetCoroutine()
			{
				return null;
			}

			// Token: 0x06016126 RID: 90406 RVA: 0x0008F538 File Offset: 0x0008D738
			[Token(Token = "0x6016126")]
			[Address(RVA = "0xE91FA0", Offset = "0xE90BA0", VA = "0x180E91FA0")]
			public bool Match(Coroutine target)
			{
				return default(bool);
			}

			// Token: 0x06016127 RID: 90407 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016127")]
			[Address(RVA = "0xE91D10", Offset = "0xE90910", VA = "0x180E91D10")]
			public static UIPage.CoroutineId Alloc(Coroutine coro, IEnumerator routine, Queue<UIPage.CoroutineId> pool)
			{
				return null;
			}

			// Token: 0x06016128 RID: 90408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016128")]
			[Address(RVA = "0xE91E20", Offset = "0xE90A20", VA = "0x180E91E20")]
			public static void Dealloc(UIPage.CoroutineId id, Queue<UIPage.CoroutineId> pool)
			{
			}

			// Token: 0x0401A84A RID: 108618
			[Token(Token = "0x401A84A")]
			[FieldOffset(Offset = "0x10")]
			private WeakReference m_coroutine;
		}
	}
}
