using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x060005B6 RID: 1462
		[Token(Token = "0x60005B6")]
		protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type);

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x5A8BED0", Offset = "0x5A8AAD0", VA = "0x185A8BED0", Slot = "13")]
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x5A8C370", Offset = "0x5A8AF70", VA = "0x185A8C370", Slot = "12")]
		public override void Update()
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x5A8C1F0", Offset = "0x5A8ADF0", VA = "0x185A8C1F0")]
		private void ProcessNewChange(VisualElement ve)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x5A8C100", Offset = "0x5A8AD00", VA = "0x185A8C100")]
		private void ProcessAddOrMove(VisualElement ve)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x5A8C2C0", Offset = "0x5A8AEC0", VA = "0x185A8C2C0")]
		private void ProcessRemove(VisualElement ve)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x5A8C440", Offset = "0x5A8B040", VA = "0x185A8C440")]
		protected BaseVisualTreeHierarchyTrackerUpdater()
		{
		}

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x20")]
		private BaseVisualTreeHierarchyTrackerUpdater.State m_State;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x28")]
		private VisualElement m_CurrentChangeElement;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x30")]
		private VisualElement m_CurrentChangeParent;

		// Token: 0x020000D2 RID: 210
		[Token(Token = "0x20000D2")]
		private enum State
		{
			// Token: 0x040002D5 RID: 725
			[Token(Token = "0x40002D5")]
			Waiting,
			// Token: 0x040002D6 RID: 726
			[Token(Token = "0x40002D6")]
			TrackingAddOrMove,
			// Token: 0x040002D7 RID: 727
			[Token(Token = "0x40002D7")]
			TrackingRemove
		}
	}
}
