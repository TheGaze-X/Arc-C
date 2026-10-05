using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AsyncLoader
{
	// Token: 0x020016D0 RID: 5840
	[Token(Token = "0x20016D0")]
	public abstract class AsyncTaskBase : IHotfixable, IDisposable, IComparable<AsyncTaskBase>
	{
		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x060093F0 RID: 37872 RVA: 0x00039BB8 File Offset: 0x00037DB8
		// (set) Token: 0x060093F1 RID: 37873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FDC")]
		public AsyncTaskBase.LoadState state
		{
			[Token(Token = "0x60093F0")]
			[Address(RVA = "0x2B26F70", Offset = "0x2B25B70", VA = "0x182B26F70")]
			[CompilerGenerated]
			get
			{
				return AsyncTaskBase.LoadState.NONE;
			}
			[Token(Token = "0x60093F1")]
			[Address(RVA = "0x2B27040", Offset = "0x2B25C40", VA = "0x182B27040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x060093F2 RID: 37874 RVA: 0x00039BD0 File Offset: 0x00037DD0
		// (set) Token: 0x060093F3 RID: 37875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FDD")]
		public bool isDiposed
		{
			[Token(Token = "0x60093F2")]
			[Address(RVA = "0x2B26F10", Offset = "0x2B25B10", VA = "0x182B26F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60093F3")]
			[Address(RVA = "0x2B26FD0", Offset = "0x2B25BD0", VA = "0x182B26FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060093F4 RID: 37876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093F4")]
		[Address(RVA = "0x2B26E10", Offset = "0x2B25A10", VA = "0x182B26E10")]
		public void MoveToState(AsyncTaskBase.LoadState state)
		{
		}

		// Token: 0x060093F5 RID: 37877 RVA: 0x00039BE8 File Offset: 0x00037DE8
		[Token(Token = "0x60093F5")]
		[Address(RVA = "0x2B26D60", Offset = "0x2B25960", VA = "0x182B26D60")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		// Token: 0x060093F6 RID: 37878 RVA: 0x00039C00 File Offset: 0x00037E00
		[Token(Token = "0x60093F6")]
		[Address(RVA = "0x2B26C20", Offset = "0x2B25820", VA = "0x182B26C20", Slot = "5")]
		public int CompareTo(AsyncTaskBase other)
		{
			return 0;
		}

		// Token: 0x060093F7 RID: 37879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093F7")]
		[Address(RVA = "0x2B26CA0", Offset = "0x2B258A0", VA = "0x182B26CA0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060093F8 RID: 37880
		[Token(Token = "0x60093F8")]
		public abstract bool WorkOnce(out uint cost);

		// Token: 0x060093F9 RID: 37881
		[Token(Token = "0x60093F9")]
		protected abstract void OnDisposed();

		// Token: 0x060093FA RID: 37882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093FA")]
		[Address(RVA = "0x2B26EB0", Offset = "0x2B25AB0", VA = "0x182B26EB0")]
		protected AsyncTaskBase()
		{
		}

		// Token: 0x040089C2 RID: 35266
		[Token(Token = "0x40089C2")]
		[FieldOffset(Offset = "0x10")]
		public AsyncOrder order;

		// Token: 0x040089C5 RID: 35269
		[Token(Token = "0x40089C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x040089C6 RID: 35270
		[Token(Token = "0x40089C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x040089C7 RID: 35271
		[Token(Token = "0x40089C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isDiposed;

		// Token: 0x040089C8 RID: 35272
		[Token(Token = "0x40089C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isDiposed;

		// Token: 0x040089C9 RID: 35273
		[Token(Token = "0x40089C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_MoveToState;

		// Token: 0x040089CA RID: 35274
		[Token(Token = "0x40089CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsLoaded;

		// Token: 0x040089CB RID: 35275
		[Token(Token = "0x40089CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040089CC RID: 35276
		[Token(Token = "0x40089CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x040089CD RID: 35277
		[Token(Token = "0x40089CD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020016D1 RID: 5841
		[Token(Token = "0x20016D1")]
		public enum LoadState
		{
			// Token: 0x040089CF RID: 35279
			[Token(Token = "0x40089CF")]
			NONE,
			// Token: 0x040089D0 RID: 35280
			[Token(Token = "0x40089D0")]
			LOADING,
			// Token: 0x040089D1 RID: 35281
			[Token(Token = "0x40089D1")]
			LOADED
		}
	}
}
