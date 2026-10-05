using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Config
{
	// Token: 0x02000249 RID: 585
	[Token(Token = "0x2000249")]
	public abstract class SingletonDynGameConfig<TSelf, TData> : Singleton<TSelf>, IDynGameConfig, IDisposable where TSelf : class where TData : class
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700015B")]
		public TData data
		{
			[Token(Token = "0x6000D45")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D46")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000D47 RID: 3399
		[Token(Token = "0x6000D47")]
		public abstract string ConfigName();

		// Token: 0x06000D48 RID: 3400
		[Token(Token = "0x6000D48")]
		public abstract bool DistinctChannel();

		// Token: 0x06000D49 RID: 3401
		[Token(Token = "0x6000D49")]
		public abstract bool DistinctPlatform();

		// Token: 0x06000D4A RID: 3402 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D4A")]
		protected virtual void BeforeReset()
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4B")]
		public Type GetDataType()
		{
			return null;
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D4C")]
		public void SetData(object data)
		{
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D4D")]
		public void ResetData()
		{
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D4E")]
		public void Dispose()
		{
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D4F")]
		protected SingletonDynGameConfig()
		{
		}
	}
}
