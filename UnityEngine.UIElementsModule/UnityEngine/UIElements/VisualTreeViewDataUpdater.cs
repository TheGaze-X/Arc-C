using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	internal class VisualTreeViewDataUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x1700014E")]
		public override ProfilerMarker profilerMarker
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x5AA70F0", Offset = "0x5AA5CF0", VA = "0x185AA70F0", Slot = "10")]
			get
			{
				return default(ProfilerMarker);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x5AA6B20", Offset = "0x5AA5720", VA = "0x185AA6B20", Slot = "13")]
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x5AA6CD0", Offset = "0x5AA58D0", VA = "0x185AA6CD0", Slot = "12")]
		public override void Update()
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x5AA6E30", Offset = "0x5AA5A30", VA = "0x185AA6E30")]
		private void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence)
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x5AA6C20", Offset = "0x5AA5820", VA = "0x185AA6C20")]
		private void PropagateToParents(VisualElement ve)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x5AA7030", Offset = "0x5AA5C30", VA = "0x185AA7030")]
		public VisualTreeViewDataUpdater()
		{
		}

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<VisualElement> m_UpdateList;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<VisualElement> m_ParentList;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x30")]
		private uint m_Version;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x34")]
		private uint m_LastVersion;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_Description;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker s_ProfilerMarker;
	}
}
