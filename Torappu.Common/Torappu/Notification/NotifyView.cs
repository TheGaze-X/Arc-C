using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Notification
{
	// Token: 0x020001FA RID: 506
	[Token(Token = "0x20001FA")]
	public abstract class NotifyView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700011C")]
		private protected NotifyViewLayouter layouter
		{
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x55722B0", Offset = "0x5570EB0", VA = "0x1855722B0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x5572370", Offset = "0x5570F70", VA = "0x185572370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00008024 File Offset: 0x00006224
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700011D")]
		public int viewId
		{
			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x5572310", Offset = "0x5570F10", VA = "0x185572310")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x55723F0", Offset = "0x5570FF0", VA = "0x1855723F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x5571F10", Offset = "0x5570B10", VA = "0x185571F10")]
		public void InitLayout(NotifyViewLayouter layouter, int viewId)
		{
		}

		// Token: 0x06000BE6 RID: 3046
		[Token(Token = "0x6000BE6")]
		public abstract void TriggerRender(NotifyViewParam param);

		// Token: 0x06000BE7 RID: 3047 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x5571B40", Offset = "0x5570740", VA = "0x185571B40")]
		protected void CancelAutoHide()
		{
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x5572050", Offset = "0x5570C50", VA = "0x185572050")]
		protected void ManualHide()
		{
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0000803C File Offset: 0x0000623C
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x5571D50", Offset = "0x5570950", VA = "0x185571D50")]
		protected bool CheckIfShowing()
		{
			return default(bool);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x5572250", Offset = "0x5570E50", VA = "0x185572250")]
		protected NotifyView()
		{
		}

		// Token: 0x04000B93 RID: 2963
		[Token(Token = "0x4000B93")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate246 __Hotfix0_get_layouter;

		// Token: 0x04000B94 RID: 2964
		[Token(Token = "0x4000B94")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate0 __Hotfix0_set_layouter;

		// Token: 0x04000B95 RID: 2965
		[Token(Token = "0x4000B95")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_viewId;

		// Token: 0x04000B96 RID: 2966
		[Token(Token = "0x4000B96")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate26 __Hotfix0_set_viewId;

		// Token: 0x04000B97 RID: 2967
		[Token(Token = "0x4000B97")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate117 __Hotfix0_InitLayout;

		// Token: 0x04000B98 RID: 2968
		[Token(Token = "0x4000B98")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0_CancelAutoHide;

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ManualHide;

		// Token: 0x04000B9A RID: 2970
		[Token(Token = "0x4000B9A")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate21 __Hotfix0_CheckIfShowing;

		// Token: 0x04000B9B RID: 2971
		[Token(Token = "0x4000B9B")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
