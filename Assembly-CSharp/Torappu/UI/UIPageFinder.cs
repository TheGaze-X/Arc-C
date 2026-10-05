using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003603 RID: 13827
	[Token(Token = "0x2003603")]
	public struct UIPageFinder
	{
		// Token: 0x06016054 RID: 90196 RVA: 0x0008F1C0 File Offset: 0x0008D3C0
		[Token(Token = "0x6016054")]
		[Address(RVA = "0xE8AB90", Offset = "0xE89790", VA = "0x180E8AB90")]
		public UIPageFinder.Interface Reset(Transform current)
		{
			return default(UIPageFinder.Interface);
		}

		// Token: 0x06016055 RID: 90197 RVA: 0x0008F1D8 File Offset: 0x0008D3D8
		[Token(Token = "0x6016055")]
		[Address(RVA = "0xE8ABD0", Offset = "0xE897D0", VA = "0x180E8ABD0")]
		public UIPageFinder.Interface Reset(MonoBehaviour customBehaviour)
		{
			return default(UIPageFinder.Interface);
		}

		// Token: 0x06016056 RID: 90198 RVA: 0x0008F1F0 File Offset: 0x0008D3F0
		[Token(Token = "0x6016056")]
		[Address(RVA = "0xE8A9D0", Offset = "0xE895D0", VA = "0x180E8A9D0")]
		public UIPageFinder.Interface Current(Transform current)
		{
			return default(UIPageFinder.Interface);
		}

		// Token: 0x06016057 RID: 90199 RVA: 0x0008F208 File Offset: 0x0008D408
		[Token(Token = "0x6016057")]
		[Address(RVA = "0xE8AB00", Offset = "0xE89700", VA = "0x180E8AB00")]
		public UIPageFinder.Interface Current(MonoBehaviour customBehaviour)
		{
			return default(UIPageFinder.Interface);
		}

		// Token: 0x0401A772 RID: 108402
		[Token(Token = "0x401A772")]
		[FieldOffset(Offset = "0x0")]
		private UIPage m_page;

		// Token: 0x0401A773 RID: 108403
		[Token(Token = "0x401A773")]
		[FieldOffset(Offset = "0x8")]
		private Transform m_curTrans;

		// Token: 0x02003604 RID: 13828
		[Token(Token = "0x2003604")]
		public struct Interface
		{
			// Token: 0x06016058 RID: 90200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016058")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public Interface(UIPage page)
			{
			}

			// Token: 0x06016059 RID: 90201 RVA: 0x0008F220 File Offset: 0x0008D420
			[Token(Token = "0x6016059")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			public static implicit operator UIPageFinder.Interface(UIPage page)
			{
				return default(UIPageFinder.Interface);
			}

			// Token: 0x0601605A RID: 90202 RVA: 0x0008F238 File Offset: 0x0008D438
			[Token(Token = "0x601605A")]
			[Address(RVA = "0xE7BFB0", Offset = "0xE7ABB0", VA = "0x180E7BFB0")]
			public bool IsSamePage(UIPage comparsion)
			{
				return default(bool);
			}

			// Token: 0x0601605B RID: 90203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601605B")]
			public TComp SingleComponent<TComp>() where TComp : PageSingleComponent
			{
				return null;
			}

			// Token: 0x0601605C RID: 90204 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601605C")]
			public TAsset LoadAsset<TAsset>(string path) where TAsset : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x0601605D RID: 90205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601605D")]
			[Address(RVA = "0xE7C1A0", Offset = "0xE7ADA0", VA = "0x180E7C1A0")]
			public void UnloadAsset(UnityEngine.Object asset)
			{
			}

			// Token: 0x0601605E RID: 90206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601605E")]
			[Address(RVA = "0xE7BE60", Offset = "0xE7AA60", VA = "0x180E7BE60")]
			public Coroutine CoroutineWithPage(IEnumerator routine)
			{
				return null;
			}

			// Token: 0x0601605F RID: 90207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601605F")]
			[Address(RVA = "0xE7BF00", Offset = "0xE7AB00", VA = "0x180E7BF00")]
			public UIPageCoroutineHost GetCoroutineHost()
			{
				return null;
			}

			// Token: 0x06016060 RID: 90208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016060")]
			[Address(RVA = "0xE7C010", Offset = "0xE7AC10", VA = "0x180E7C010")]
			public void StopPageCoroutine(Coroutine routine)
			{
			}

			// Token: 0x06016061 RID: 90209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016061")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			public ILoadAsset GetAssetLoader()
			{
				return null;
			}

			// Token: 0x06016062 RID: 90210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016062")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			public UnityEngine.Object UICompDialogHost()
			{
				return null;
			}

			// Token: 0x06016063 RID: 90211 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016063")]
			public UICompDialogMgr GetDialogMgr<PageType>() where PageType : UIPage, IDialogMgrHolder
			{
				return null;
			}

			// Token: 0x06016064 RID: 90212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016064")]
			[Address(RVA = "0xE7BAF0", Offset = "0xE7A6F0", VA = "0x180E7BAF0")]
			public void BindEffectHolder(UICommonPageEffectHolder effectHolder)
			{
			}

			// Token: 0x06016065 RID: 90213 RVA: 0x0008F250 File Offset: 0x0008D450
			[Token(Token = "0x6016065")]
			public bool PageMessage<PageType>(int key, ValueBundle msg) where PageType : UIPage, IValueMsgReceiver
			{
				return default(bool);
			}

			// Token: 0x06016066 RID: 90214 RVA: 0x0008F268 File Offset: 0x0008D468
			[Token(Token = "0x6016066")]
			public bool PageMessage<PageType>(int key) where PageType : UIPage, IValueMsgReceiver
			{
				return default(bool);
			}

			// Token: 0x06016067 RID: 90215 RVA: 0x0008F280 File Offset: 0x0008D480
			[Token(Token = "0x6016067")]
			public bool ComponentMessage<CompType>(int key, ValueBundle msg) where CompType : PageSingleComponent, IValueMsgReceiver
			{
				return default(bool);
			}

			// Token: 0x06016068 RID: 90216 RVA: 0x0008F298 File Offset: 0x0008D498
			[Token(Token = "0x6016068")]
			public bool ComponentMessage<CompType>(int key) where CompType : PageSingleComponent, IValueMsgReceiver
			{
				return default(bool);
			}

			// Token: 0x06016069 RID: 90217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016069")]
			[Address(RVA = "0xE7BBA0", Offset = "0xE7A7A0", VA = "0x180E7BBA0")]
			public void BindUpdate(ITimeWatcher watcher)
			{
			}

			// Token: 0x0601606A RID: 90218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601606A")]
			[Address(RVA = "0xE7C0A0", Offset = "0xE7ACA0", VA = "0x180E7C0A0")]
			public void UnbindUpdate(ITimeWatcher watcher)
			{
			}

			// Token: 0x0601606B RID: 90219 RVA: 0x0008F2B0 File Offset: 0x0008D4B0
			[Token(Token = "0x601606B")]
			[Address(RVA = "0xE7BCF0", Offset = "0xE7A8F0", VA = "0x180E7BCF0")]
			public bool CheckPageIsReady()
			{
				return default(bool);
			}

			// Token: 0x0601606C RID: 90220 RVA: 0x0008F2C8 File Offset: 0x0008D4C8
			[Token(Token = "0x601606C")]
			[Address(RVA = "0xE7BDD0", Offset = "0xE7A9D0", VA = "0x180E7BDD0")]
			public bool CheckPageValidButClosed()
			{
				return default(bool);
			}

			// Token: 0x0601606D RID: 90221 RVA: 0x0008F2E0 File Offset: 0x0008D4E0
			[Token(Token = "0x601606D")]
			private static bool _SendMessageImpl<TargetType>(MonoBehaviour target, int key, ValueBundle msg) where TargetType : MonoBehaviour, IValueMsgReceiver
			{
				return default(bool);
			}

			// Token: 0x0401A774 RID: 108404
			[Token(Token = "0x401A774")]
			[FieldOffset(Offset = "0x0")]
			private UIPage m_page;
		}
	}
}
