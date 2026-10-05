using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	[DesignerCategory("Component")]
	[TypeConverter(typeof(ComponentConverter))]
	public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider
	{
		// Token: 0x06000B98 RID: 2968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MarshalByValueComponent()
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x4B2ACF0", Offset = "0x4B298F0", VA = "0x184B2ACF0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000B9A RID: 2970 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000B9B RID: 2971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000009")]
		public event EventHandler Disposed
		{
			[Token(Token = "0x6000B9A")]
			[Address(RVA = "0x514B110", Offset = "0x5149D10", VA = "0x18514B110", Slot = "6")]
			add
			{
			}
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x514B2C0", Offset = "0x5149EC0", VA = "0x18514B2C0", Slot = "7")]
			remove
			{
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025D")]
		protected EventHandlerList Events
		{
			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0x514B240", Offset = "0x5149E40", VA = "0x18514B240")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700025E")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ISite Site
		{
			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x514AC30", Offset = "0x5149830", VA = "0x18514AC30", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x514ACA0", Offset = "0x51498A0", VA = "0x18514ACA0", Slot = "12")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025F")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IContainer Container
		{
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x514B1A0", Offset = "0x5149DA0", VA = "0x18514B1A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x514AF10", Offset = "0x5149B10", VA = "0x18514AF10", Slot = "14")]
		public virtual object GetService(Type service)
		{
			return null;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x17000260")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual bool DesignMode
		{
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x514B1F0", Offset = "0x5149DF0", VA = "0x18514B1F0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x514AF70", Offset = "0x5149B70", VA = "0x18514AF70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object s_eventDisposed;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x10")]
		private ISite _site;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x18")]
		private EventHandlerList _events;
	}
}
