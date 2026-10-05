using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060005F8 RID: 1528 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005F9 RID: 1529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000B")]
		public event Action<BaseVisualElementPanel> panelChanged
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x5A8C4C0", Offset = "0x5A8B0C0", VA = "0x185A8C4C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x5A8C5C0", Offset = "0x5A8B1C0", VA = "0x185A8C5C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014B")]
		public BaseVisualElementPanel panel
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x5A8C670", Offset = "0x5A8B270", VA = "0x185A8C670", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700014C")]
		public VisualElement visualTree
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x5A8C570", Offset = "0x5A8B170", VA = "0x185A8C570")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060005FD RID: 1533
		[Token(Token = "0x1700014D")]
		public abstract ProfilerMarker profilerMarker { [Token(Token = "0x60005FD")] get; }

		// Token: 0x060005FE RID: 1534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x5A8C450", Offset = "0x5A8B050", VA = "0x185A8C450", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000600 RID: 1536
		[Token(Token = "0x6000600")]
		public abstract void Update();

		// Token: 0x06000601 RID: 1537
		[Token(Token = "0x6000601")]
		public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);

		// Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected BaseVisualTreeUpdater()
		{
		}

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x18")]
		private BaseVisualElementPanel m_Panel;
	}
}
