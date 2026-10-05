using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000201 RID: 513
	[Token(Token = "0x2000201")]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[DesignerCategory("Component")]
	public class Component : MarshalByRefObject, IComponent, IDisposable
	{
		// Token: 0x06000D75 RID: 3445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x51584F0", Offset = "0x51570F0", VA = "0x1851584F0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x170002CF")]
		protected virtual bool CanRaiseEvents
		{
			[Token(Token = "0x6000D76")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x00007470 File Offset: 0x00005670
		[Token(Token = "0x170002D0")]
		internal bool CanRaiseEventsInternal
		{
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x78A370", Offset = "0x788F70", VA = "0x18078A370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000D78 RID: 3448 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000D79 RID: 3449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000D")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public event EventHandler Disposed
		{
			[Token(Token = "0x6000D78")]
			[Address(RVA = "0x5158770", Offset = "0x5157370", VA = "0x185158770", Slot = "8")]
			add
			{
			}
			[Token(Token = "0x6000D79")]
			[Address(RVA = "0x5158930", Offset = "0x5157530", VA = "0x185158930", Slot = "9")]
			remove
			{
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D1")]
		protected EventHandlerList Events
		{
			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0x51588A0", Offset = "0x51574A0", VA = "0x1851588A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D2")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ISite Site
		{
			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x5158290", Offset = "0x5156E90", VA = "0x185158290", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x5158300", Offset = "0x5156F00", VA = "0x185158300", Slot = "14")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D3")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IContainer Container
		{
			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x5158800", Offset = "0x5157400", VA = "0x185158800")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x5158570", Offset = "0x5157170", VA = "0x185158570", Slot = "15")]
		protected virtual object GetService(Type service)
		{
			return null;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x170002D4")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		protected bool DesignMode
		{
			[Token(Token = "0x6000D81")]
			[Address(RVA = "0x5158850", Offset = "0x5157450", VA = "0x185158850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x51585D0", Offset = "0x51571D0", VA = "0x1851585D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Component()
		{
		}

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object EventDisposed;

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ISite site;

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private EventHandlerList events;
	}
}
