using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	internal class VisualTreeStyleUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x17000143")]
		public override ProfilerMarker profilerMarker
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x5AA5F10", Offset = "0x5AA4B10", VA = "0x185AA5F10", Slot = "10")]
			get
			{
				return default(ProfilerMarker);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x5AA5820", Offset = "0x5AA4420", VA = "0x185AA5820", Slot = "13")]
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x5AA58E0", Offset = "0x5AA44E0", VA = "0x185AA58E0", Slot = "12")]
		public override void Update()
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x5AA56E0", Offset = "0x5AA42E0", VA = "0x185AA56E0")]
		private void ApplyStyles()
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x5AA5E10", Offset = "0x5AA4A10", VA = "0x185AA5E10")]
		public VisualTreeStyleUpdater()
		{
		}

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<VisualElement> m_ApplyStyleUpdateList;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<VisualElement> m_TransitionPropertyUpdateList;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IsApplyingStyles;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x34")]
		private uint m_Version;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x38")]
		private uint m_LastVersion;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x40")]
		private VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_Description;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker s_ProfilerMarker;
	}
}
