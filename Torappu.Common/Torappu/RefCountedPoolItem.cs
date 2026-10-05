using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	public abstract class RefCountedPoolItem<TObject> : IRefCountedPoolItem where TObject : class
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000053")]
		public string key
		{
			[Token(Token = "0x6000404")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000405")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00005264 File Offset: 0x00003464
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000054")]
		public int refCount
		{
			[Token(Token = "0x6000406")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000407")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000055")]
		public string persistTag
		{
			[Token(Token = "0x6000408")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000409")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600040A")]
		public void PoolOnly_SetPersistTag(string tag)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000527C File Offset: 0x0000347C
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000056")]
		public int maxRefAllowed
		{
			[Token(Token = "0x600040B")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600040C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600040D")]
		public void PoolOnly_SetMaxAllowed(int max)
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040E")]
		public TObject PoolOnly_AddRef(bool preload = false)
		{
			return null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00005294 File Offset: 0x00003494
		[Token(Token = "0x600040F")]
		public bool PoolOnly_DecRef()
		{
			return default(bool);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000410")]
		public virtual void OnAllocate(string key)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000411")]
		public virtual void OnRecycle()
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000412")]
		public object GetObject()
		{
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000413")]
		protected RefCountedPoolItem()
		{
		}

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x0")]
		public TObject obj;
	}
}
