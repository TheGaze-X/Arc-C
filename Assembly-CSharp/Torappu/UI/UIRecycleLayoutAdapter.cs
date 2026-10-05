using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038F3 RID: 14579
	[Token(Token = "0x20038F3")]
	public abstract class UIRecycleLayoutAdapter : IHotfixable
	{
		// Token: 0x060170B9 RID: 94393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170B9")]
		[Address(RVA = "0xF7A230", Offset = "0xF78E30", VA = "0x180F7A230")]
		public void Init(UIRecycleLayoutGroup.IViewHandler handler)
		{
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x060170BA RID: 94394 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060170BB RID: 94395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170036FF")]
		private protected UIRecycleLayoutGroup.IViewHandler viewHandler
		{
			[Token(Token = "0x60170BA")]
			[Address(RVA = "0xF7A340", Offset = "0xF78F40", VA = "0x180F7A340")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60170BB")]
			[Address(RVA = "0xF7A3A0", Offset = "0xF78FA0", VA = "0x180F7A3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060170BC RID: 94396
		[Token(Token = "0x60170BC")]
		public abstract IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild();

		// Token: 0x060170BD RID: 94397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170BD")]
		[Address(RVA = "0xF7A2E0", Offset = "0xF78EE0", VA = "0x180F7A2E0")]
		protected UIRecycleLayoutAdapter()
		{
		}

		// Token: 0x0401BD15 RID: 113941
		[Token(Token = "0x401BD15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401BD16 RID: 113942
		[Token(Token = "0x401BD16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_viewHandler;

		// Token: 0x0401BD17 RID: 113943
		[Token(Token = "0x401BD17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_viewHandler;

		// Token: 0x0401BD18 RID: 113944
		[Token(Token = "0x401BD18")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038F4 RID: 14580
		[Token(Token = "0x20038F4")]
		public interface ICustomViewType
		{
			// Token: 0x17003700 RID: 14080
			// (get) Token: 0x060170BE RID: 94398
			[Token(Token = "0x17003700")]
			int viewType { [Token(Token = "0x60170BE")] get; }
		}

		// Token: 0x020038F5 RID: 14581
		[Token(Token = "0x20038F5")]
		public interface ICustomSpacing
		{
			// Token: 0x060170BF RID: 94399
			[Token(Token = "0x60170BF")]
			float GetCustomSpacing();
		}

		// Token: 0x020038F6 RID: 14582
		[Token(Token = "0x20038F6")]
		public interface IVirtualView : IHotfixable
		{
			// Token: 0x060170C0 RID: 94400
			[Token(Token = "0x60170C0")]
			void AttachView(GameObject view);

			// Token: 0x060170C1 RID: 94401
			[Token(Token = "0x60170C1")]
			void DetachView();

			// Token: 0x060170C2 RID: 94402
			[Token(Token = "0x60170C2")]
			GameObject GetAttachedView();

			// Token: 0x060170C3 RID: 94403
			[Token(Token = "0x60170C3")]
			int GetViewID();

			// Token: 0x060170C4 RID: 94404
			[Token(Token = "0x60170C4")]
			GameObject GetPrefab();

			// Token: 0x060170C5 RID: 94405
			[Token(Token = "0x60170C5")]
			float GetPreferSize();
		}

		// Token: 0x020038F7 RID: 14583
		[Token(Token = "0x20038F7")]
		public abstract class VirtualView<TView> : UIRecycleLayoutAdapter.IVirtualView, IHotfixable where TView : Component
		{
			// Token: 0x17003701 RID: 14081
			// (get) Token: 0x060170C6 RID: 94406 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060170C7 RID: 94407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003701")]
			private protected TView view
			{
				[Token(Token = "0x60170C6")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x60170C7")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060170C8 RID: 94408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60170C8")]
			public void AttachView(GameObject gameObj)
			{
			}

			// Token: 0x060170C9 RID: 94409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60170C9")]
			public void DetachView()
			{
			}

			// Token: 0x060170CA RID: 94410 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60170CA")]
			public GameObject GetAttachedView()
			{
				return null;
			}

			// Token: 0x060170CB RID: 94411 RVA: 0x00094920 File Offset: 0x00092B20
			[Token(Token = "0x60170CB")]
			public int GetViewID()
			{
				return 0;
			}

			// Token: 0x060170CC RID: 94412
			[Token(Token = "0x60170CC")]
			protected abstract void OnViewAttached();

			// Token: 0x060170CD RID: 94413
			[Token(Token = "0x60170CD")]
			protected abstract void OnViewDetached();

			// Token: 0x060170CE RID: 94414
			[Token(Token = "0x60170CE")]
			public abstract GameObject GetPrefab();

			// Token: 0x060170CF RID: 94415
			[Token(Token = "0x60170CF")]
			public abstract float GetPreferSize();

			// Token: 0x060170D0 RID: 94416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60170D0")]
			protected VirtualView()
			{
			}

			// Token: 0x0401BD19 RID: 113945
			[Token(Token = "0x401BD19")]
			[FieldOffset(Offset = "0x0")]
			private GameObject m_gameObj;

			// Token: 0x0401BD1B RID: 113947
			[Token(Token = "0x401BD1B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_view;

			// Token: 0x0401BD1C RID: 113948
			[Token(Token = "0x401BD1C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_view;

			// Token: 0x0401BD1D RID: 113949
			[Token(Token = "0x401BD1D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_AttachView;

			// Token: 0x0401BD1E RID: 113950
			[Token(Token = "0x401BD1E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DetachView;

			// Token: 0x0401BD1F RID: 113951
			[Token(Token = "0x401BD1F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetAttachedView;

			// Token: 0x0401BD20 RID: 113952
			[Token(Token = "0x401BD20")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetViewID;

			// Token: 0x0401BD21 RID: 113953
			[Token(Token = "0x401BD21")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
