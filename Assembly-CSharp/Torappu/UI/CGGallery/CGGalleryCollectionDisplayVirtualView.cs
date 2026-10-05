using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006001 RID: 24577
	[Token(Token = "0x2006001")]
	public abstract class CGGalleryCollectionDisplayVirtualView<T> : UISimpleRecycleLayoutItemView, IUIIntegerLocateRegistry, IUILocateRegistry, IHotfixable where T : UISimpleRecycleLayoutItemViewModel
	{
		// Token: 0x170053EA RID: 21482
		// (get) Token: 0x0602385D RID: 145501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053EA")]
		public IReadOnlyCollection<int> metasObserved
		{
			[Token(Token = "0x602385D")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602385E RID: 145502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602385E")]
		public void OnMetaChange(int _, object rawMeta)
		{
		}

		// Token: 0x0602385F RID: 145503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602385F")]
		public void OnLocatedChange(int located)
		{
		}

		// Token: 0x06023860 RID: 145504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023860")]
		public void OnLocatingStateChange(bool locating)
		{
		}

		// Token: 0x1400008C RID: 140
		// (add) Token: 0x06023861 RID: 145505 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06023862 RID: 145506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400008C")]
		public event Action<int> requestLocate
		{
			[Token(Token = "0x6023861")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6023862")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06023863 RID: 145507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023863")]
		protected sealed override void Render(UISimpleRecycleLayoutItemViewModel rawModel, ValueBundle value, int index)
		{
		}

		// Token: 0x06023864 RID: 145508
		[Token(Token = "0x6023864")]
		protected abstract void RenderData(T model, CGGalleryFilterMode filterMode);

		// Token: 0x06023865 RID: 145509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023865")]
		protected void OnDisable()
		{
		}

		// Token: 0x06023866 RID: 145510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023866")]
		protected CGGalleryCollectionDisplayVirtualView()
		{
		}

		// Token: 0x04031266 RID: 201318
		[Token(Token = "0x4031266")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private UIAnimationLocation _offsetAnimation;

		// Token: 0x04031267 RID: 201319
		[Token(Token = "0x4031267")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _offsetMapDistance;

		// Token: 0x04031268 RID: 201320
		[Token(Token = "0x4031268")]
		[FieldOffset(Offset = "0x0")]
		private CGGalleryCollectionDisplayGroupView.DisplayAdapterBridge m_cachedBridge;

		// Token: 0x04031269 RID: 201321
		[Token(Token = "0x4031269")]
		[FieldOffset(Offset = "0x0")]
		private int m_cachedIndex;

		// Token: 0x0403126B RID: 201323
		[Token(Token = "0x403126B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_metasObserved;

		// Token: 0x0403126C RID: 201324
		[Token(Token = "0x403126C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMetaChange;

		// Token: 0x0403126D RID: 201325
		[Token(Token = "0x403126D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLocatedChange;

		// Token: 0x0403126E RID: 201326
		[Token(Token = "0x403126E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLocatingStateChange;

		// Token: 0x0403126F RID: 201327
		[Token(Token = "0x403126F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_requestLocate;

		// Token: 0x04031270 RID: 201328
		[Token(Token = "0x4031270")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_remove_requestLocate;

		// Token: 0x04031271 RID: 201329
		[Token(Token = "0x4031271")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031272 RID: 201330
		[Token(Token = "0x4031272")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04031273 RID: 201331
		[Token(Token = "0x4031273")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
