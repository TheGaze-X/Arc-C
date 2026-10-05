using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x1700014F")]
		public override ProfilerMarker profilerMarker
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x5AA3580", Offset = "0x5AA2180", VA = "0x185AA3580", Slot = "10")]
			get
			{
				return default(ProfilerMarker);
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x5AA1ED0", Offset = "0x5AA0AD0", VA = "0x185AA1ED0")]
		private IBinding GetBindingObjectFromElement(VisualElement ve)
		{
			return null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x5AA24B0", Offset = "0x5AA10B0", VA = "0x185AA24B0")]
		private void StartTracking(VisualElement ve)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x5AA2650", Offset = "0x5AA1250", VA = "0x185AA2650")]
		private void StopTracking(VisualElement ve)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000150")]
		public Dictionary<object, object> temporaryObjectCache
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x5AA1E40", Offset = "0x5AA0A40", VA = "0x185AA1E40")]
		public static IBinding GetAdditionalBinding(VisualElement ve)
		{
			return null;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x5AA2380", Offset = "0x5AA0F80", VA = "0x185AA2380")]
		private void StartTrackingRecursive(VisualElement ve)
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x5AA2530", Offset = "0x5AA1130", VA = "0x185AA2530")]
		private void StopTrackingRecursive(VisualElement ve)
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x5AA2010", Offset = "0x5AA0C10", VA = "0x185AA2010", Slot = "13")]
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x5AA1FE0", Offset = "0x5AA0BE0", VA = "0x185AA1FE0", Slot = "14")]
		protected override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type)
		{
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x5AA1E00", Offset = "0x5AA0A00", VA = "0x185AA1E00")]
		private static long CurrentTime()
		{
			return 0L;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x5AA2100", Offset = "0x5AA0D00", VA = "0x185AA2100")]
		public void PerformTrackingOperations()
		{
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x5AA2C20", Offset = "0x5AA1820", VA = "0x185AA2C20", Slot = "12")]
		public override void Update()
		{
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x5AA26D0", Offset = "0x5AA12D0", VA = "0x185AA26D0")]
		private void UpdateBindings()
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x5AA33B0", Offset = "0x5AA1FB0", VA = "0x185AA33B0")]
		public VisualTreeBindingsUpdater()
		{
		}

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x0")]
		private static readonly PropertyName s_BindingRequestObjectVEPropertyName;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x4")]
		private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string s_Description;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ProfilerMarker s_ProfilerMarker;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x18")]
		private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker s_MarkerUpdate;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker s_MarkerPoll;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x38")]
		private readonly HashSet<VisualElement> m_ElementsWithBindings;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x40")]
		private readonly HashSet<VisualElement> m_ElementsToAdd;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x48")]
		private readonly HashSet<VisualElement> m_ElementsToRemove;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x50")]
		private long m_LastUpdateTime;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x58")]
		private HashSet<VisualElement> m_ElementsToBind;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x68")]
		private List<IBinding> updatedBindings;
	}
}
