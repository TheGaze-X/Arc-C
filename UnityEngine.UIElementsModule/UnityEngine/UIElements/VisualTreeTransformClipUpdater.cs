using System;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	internal class VisualTreeTransformClipUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x17000146")]
		public override ProfilerMarker profilerMarker
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x5AA63A0", Offset = "0x5AA4FA0", VA = "0x185AA63A0", Slot = "10")]
			get
			{
				return default(ProfilerMarker);
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x5AA6110", Offset = "0x5AA4D10", VA = "0x185AA6110", Slot = "13")]
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x5AA5FD0", Offset = "0x5AA4BD0", VA = "0x185AA5FD0")]
		private static void DirtyHierarchy(VisualElement ve, bool mustDirtyWorldTransform, bool mustDirtyWorldClip)
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x5AA5F60", Offset = "0x5AA4B60", VA = "0x185AA5F60")]
		private static void DirtyBoundingBoxHierarchy(VisualElement ve)
		{
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x5AA6270", Offset = "0x5AA4E70", VA = "0x185AA6270", Slot = "12")]
		public override void Update()
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x5AA6390", Offset = "0x5AA4F90", VA = "0x185AA6390")]
		public VisualTreeTransformClipUpdater()
		{
		}

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x20")]
		private uint m_Version;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x24")]
		private uint m_LastVersion;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_Description;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker s_ProfilerMarker;
	}
}
