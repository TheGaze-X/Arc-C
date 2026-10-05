using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003610 RID: 13840
	[Token(Token = "0x2003610")]
	public class UIPageListener : IHotfixable
	{
		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x06016092 RID: 90258 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016093 RID: 90259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034F0")]
		public UIPage page
		{
			[Token(Token = "0x6016092")]
			[Address(RVA = "0xE8B030", Offset = "0xE89C30", VA = "0x180E8B030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6016093")]
			[Address(RVA = "0xE8B090", Offset = "0xE89C90", VA = "0x180E8B090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06016094 RID: 90260 RVA: 0x0008F2F8 File Offset: 0x0008D4F8
		[Token(Token = "0x6016094")]
		[Address(RVA = "0xE8AC70", Offset = "0xE89870", VA = "0x180E8AC70")]
		public bool BindListener(MonoBehaviour owner)
		{
			return default(bool);
		}

		// Token: 0x06016095 RID: 90261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016095")]
		[Address(RVA = "0xE8AFD0", Offset = "0xE89BD0", VA = "0x180E8AFD0")]
		public UIPageListener()
		{
		}

		// Token: 0x0401A792 RID: 108434
		[Token(Token = "0x401A792")]
		[FieldOffset(Offset = "0x10")]
		public Action onCreate;

		// Token: 0x0401A793 RID: 108435
		[Token(Token = "0x401A793")]
		[FieldOffset(Offset = "0x18")]
		public Action onReuse;

		// Token: 0x0401A794 RID: 108436
		[Token(Token = "0x401A794")]
		[FieldOffset(Offset = "0x20")]
		public Action onStart;

		// Token: 0x0401A795 RID: 108437
		[Token(Token = "0x401A795")]
		[FieldOffset(Offset = "0x28")]
		public Action onPageReady;

		// Token: 0x0401A796 RID: 108438
		[Token(Token = "0x401A796")]
		[FieldOffset(Offset = "0x30")]
		public Action onPageRouted;

		// Token: 0x0401A797 RID: 108439
		[Token(Token = "0x401A797")]
		[FieldOffset(Offset = "0x38")]
		public Action onStop;

		// Token: 0x0401A798 RID: 108440
		[Token(Token = "0x401A798")]
		[FieldOffset(Offset = "0x40")]
		public Action onRecycle;

		// Token: 0x0401A799 RID: 108441
		[Token(Token = "0x401A799")]
		[FieldOffset(Offset = "0x48")]
		public Action onDestroy;

		// Token: 0x0401A79A RID: 108442
		[Token(Token = "0x401A79A")]
		[FieldOffset(Offset = "0x50")]
		public Action<bool> beforeHideCoroutine;

		// Token: 0x0401A79C RID: 108444
		[Token(Token = "0x401A79C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0401A79D RID: 108445
		[Token(Token = "0x401A79D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0401A79E RID: 108446
		[Token(Token = "0x401A79E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x0401A79F RID: 108447
		[Token(Token = "0x401A79F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
