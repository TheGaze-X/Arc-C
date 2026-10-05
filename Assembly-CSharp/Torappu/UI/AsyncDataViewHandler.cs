using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037D8 RID: 14296
	[Token(Token = "0x20037D8")]
	public class AsyncDataViewHandler<ViewType, DataType> : AsyncGameObjectLoader.Handler where ViewType : Component, IAsyncDataView<DataType>
	{
		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x06016AB0 RID: 92848 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016AB1 RID: 92849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003637")]
		private protected ViewType view
		{
			[Token(Token = "0x6016AB0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6016AB1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x06016AB2 RID: 92850 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016AB3 RID: 92851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003638")]
		private protected DataType data
		{
			[Token(Token = "0x6016AB2")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6016AB3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06016AB4 RID: 92852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AB4")]
		protected sealed override void OnGameObjectLoaded(GameObject obj)
		{
		}

		// Token: 0x06016AB5 RID: 92853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AB5")]
		public void UpdateData(DataType data)
		{
		}

		// Token: 0x06016AB6 RID: 92854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AB6")]
		public AsyncDataViewHandler()
		{
		}

		// Token: 0x0401B51F RID: 111903
		[Token(Token = "0x401B51F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_view;

		// Token: 0x0401B520 RID: 111904
		[Token(Token = "0x401B520")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_view;

		// Token: 0x0401B521 RID: 111905
		[Token(Token = "0x401B521")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x0401B522 RID: 111906
		[Token(Token = "0x401B522")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_data;

		// Token: 0x0401B523 RID: 111907
		[Token(Token = "0x401B523")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnGameObjectLoaded;

		// Token: 0x0401B524 RID: 111908
		[Token(Token = "0x401B524")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401B525 RID: 111909
		[Token(Token = "0x401B525")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
