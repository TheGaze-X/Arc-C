using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Notification
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	public abstract class NotifyViewLayouter
	{
		// Token: 0x06000BC2 RID: 3010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC2")]
		public ViewType CreateNotifyView<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options) where ViewType : NotifyView where ParamType : NotifyViewParam
		{
			return null;
		}

		// Token: 0x06000BC3 RID: 3011
		[Token(Token = "0x6000BC3")]
		protected abstract ViewType InstNotifyView<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options) where ViewType : NotifyView where ParamType : NotifyViewParam;

		// Token: 0x06000BC4 RID: 3012
		[Token(Token = "0x6000BC4")]
		public abstract void AddNotifyView<ViewType, ParamType>(NotifyView notifyView, NotifyViewOptions<ViewType, ParamType> options) where ViewType : NotifyView where ParamType : NotifyViewParam;

		// Token: 0x06000BC5 RID: 3013
		[Token(Token = "0x6000BC5")]
		public abstract void RemoveNotifyView(int viewId);

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000BC6 RID: 3014
		[Token(Token = "0x17000117")]
		public abstract NotifyViewHost host { [Token(Token = "0x6000BC6")] get; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00007FDC File Offset: 0x000061DC
		[Token(Token = "0x17000118")]
		public virtual float toastPreDelay
		{
			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x5571A20", Offset = "0x5570620", VA = "0x185571A20")]
		protected void ManualDestroyNotifyView(int viewId, GameObject gameObj)
		{
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected NotifyViewLayouter()
		{
		}
	}
}
