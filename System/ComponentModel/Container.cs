using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000203 RID: 515
	[Token(Token = "0x2000203")]
	public class Container : IContainer, IDisposable
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x4B2ACF0", Offset = "0x4B298F0", VA = "0x184B2ACF0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x5158CD0", Offset = "0x51578D0", VA = "0x185158CD0", Slot = "9")]
		public virtual void Add(IComponent component)
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x51589C0", Offset = "0x51575C0", VA = "0x1851589C0", Slot = "10")]
		public virtual void Add(IComponent component, string name)
		{
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x5158D20", Offset = "0x5157920", VA = "0x185158D20", Slot = "11")]
		protected virtual ISite CreateSite(IComponent component, string name)
		{
			return null;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x5158DD0", Offset = "0x51579D0", VA = "0x185158DD0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x5158E40", Offset = "0x5157A40", VA = "0x185158E40", Slot = "12")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x5159210", Offset = "0x5157E10", VA = "0x185159210", Slot = "13")]
		protected virtual object GetService(Type service)
		{
			return null;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D5")]
		public virtual ComponentCollection Components
		{
			[Token(Token = "0x6000D8F")]
			[Address(RVA = "0x51598B0", Offset = "0x51584B0", VA = "0x1851598B0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x51592B0", Offset = "0x5157EB0", VA = "0x1851592B0", Slot = "15")]
		public virtual void Remove(IComponent component)
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x51592C0", Offset = "0x5157EC0", VA = "0x1851592C0")]
		private void Remove(IComponent component, bool preserveSite)
		{
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x51592A0", Offset = "0x5157EA0", VA = "0x1851592A0")]
		protected void RemoveWithoutUnsiting(IComponent component)
		{
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x51594F0", Offset = "0x51580F0", VA = "0x1851594F0", Slot = "16")]
		protected virtual void ValidateName(IComponent component, string name)
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x5159840", Offset = "0x5158440", VA = "0x185159840")]
		public Container()
		{
		}

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x10")]
		private ISite[] sites;

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x18")]
		private int siteCount;

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x20")]
		private ComponentCollection components;

		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x28")]
		private ContainerFilterService filter;

		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x30")]
		private bool checkedFilter;

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x38")]
		private object syncObj;

		// Token: 0x02000204 RID: 516
		[Token(Token = "0x2000204")]
		private class Site : ISite, IServiceProvider
		{
			// Token: 0x06000D95 RID: 3477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D95")]
			[Address(RVA = "0x22FF1A0", Offset = "0x22FDDA0", VA = "0x1822FF1A0")]
			internal Site(IComponent component, Container container, string name)
			{
			}

			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D6")]
			public IComponent Component
			{
				[Token(Token = "0x6000D96")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D7")]
			public IContainer Container
			{
				[Token(Token = "0x6000D97")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D98 RID: 3480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D98")]
			[Address(RVA = "0x5174090", Offset = "0x5172C90", VA = "0x185174090", Slot = "9")]
			public object GetService(Type service)
			{
				return null;
			}

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x06000D99 RID: 3481 RVA: 0x000074B8 File Offset: 0x000056B8
			[Token(Token = "0x170002D8")]
			public bool DesignMode
			{
				[Token(Token = "0x6000D99")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170002D9 RID: 729
			// (get) Token: 0x06000D9A RID: 3482 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000D9B RID: 3483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170002D9")]
			public string Name
			{
				[Token(Token = "0x6000D9A")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "7")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D9B")]
				[Address(RVA = "0x5174170", Offset = "0x5172D70", VA = "0x185174170", Slot = "8")]
				set
				{
				}
			}

			// Token: 0x0400078C RID: 1932
			[Token(Token = "0x400078C")]
			[FieldOffset(Offset = "0x10")]
			private IComponent component;

			// Token: 0x0400078D RID: 1933
			[Token(Token = "0x400078D")]
			[FieldOffset(Offset = "0x18")]
			private Container container;

			// Token: 0x0400078E RID: 1934
			[Token(Token = "0x400078E")]
			[FieldOffset(Offset = "0x20")]
			private string name;
		}
	}
}
