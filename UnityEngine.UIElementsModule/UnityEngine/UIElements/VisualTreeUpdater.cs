using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	internal sealed class VisualTreeUpdater : IDisposable
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x5AA6970", Offset = "0x5AA5570", VA = "0x185AA6970")]
		public VisualTreeUpdater(BaseVisualElementPanel panel)
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x5AA63F0", Offset = "0x5AA4FF0", VA = "0x185AA63F0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x5AA67B0", Offset = "0x5AA53B0", VA = "0x185AA67B0")]
		public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase)
		{
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x5AA6560", Offset = "0x5AA5160", VA = "0x185AA6560")]
		public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005ED")]
		public void SetUpdater<T>(VisualTreeUpdatePhase phase) where T : IVisualTreeUpdater, new()
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x5AA6520", Offset = "0x5AA5120", VA = "0x185AA6520")]
		public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
		{
			return null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x5AA66B0", Offset = "0x5AA52B0", VA = "0x185AA66B0")]
		private void SetDefaultUpdaters()
		{
		}

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x10")]
		private BaseVisualElementPanel m_Panel;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x18")]
		private VisualTreeUpdater.UpdaterArray m_UpdaterArray;

		// Token: 0x020000DB RID: 219
		[Token(Token = "0x20000DB")]
		private class UpdaterArray
		{
			// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x5A9A5C0", Offset = "0x5A991C0", VA = "0x185A9A5C0")]
			public UpdaterArray()
			{
			}

			// Token: 0x17000147 RID: 327
			[Token(Token = "0x17000147")]
			public IVisualTreeUpdater this[VisualTreeUpdatePhase phase]
			{
				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x187C640", Offset = "0x187B240", VA = "0x18187C640")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x5A9A620", Offset = "0x5A99220", VA = "0x185A9A620")]
				set
				{
				}
			}

			// Token: 0x17000148 RID: 328
			[Token(Token = "0x17000148")]
			public IVisualTreeUpdater this[int index]
			{
				[Token(Token = "0x60005F3")]
				[Address(RVA = "0x187C640", Offset = "0x187B240", VA = "0x18187C640")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000300 RID: 768
			[Token(Token = "0x4000300")]
			[FieldOffset(Offset = "0x10")]
			private IVisualTreeUpdater[] m_VisualTreeUpdaters;
		}
	}
}
