using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	internal class VisualElementAnimationSystem : BaseVisualTreeUpdater
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x17000141")]
		public override ProfilerMarker profilerMarker
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x5A9E9D0", Offset = "0x5A9D5D0", VA = "0x185A9E9D0", Slot = "10")]
			get
			{
				return default(ProfilerMarker);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x17000142")]
		private static ProfilerMarker stylePropertyAnimationProfilerMarker
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x5A9EA20", Offset = "0x5A9D620", VA = "0x185A9EA20")]
			get
			{
				return default(ProfilerMarker);
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x5A9E220", Offset = "0x5A9CE20", VA = "0x185A9E220")]
		public void UnregisterAnimation(IValueAnimationUpdate anim)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x5A9E280", Offset = "0x5A9CE80", VA = "0x185A9E280")]
		public void UnregisterAnimations(List<IValueAnimationUpdate> anims)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x5A9E080", Offset = "0x5A9CC80", VA = "0x185A9E080")]
		public void RegisterAnimation(IValueAnimationUpdate anim)
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x5A9E0E0", Offset = "0x5A9CCE0", VA = "0x185A9E0E0")]
		public void RegisterAnimations(List<IValueAnimationUpdate> anims)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x5A9E3C0", Offset = "0x5A9CFC0", VA = "0x185A9E3C0", Slot = "12")]
		public override void Update()
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x5A9E8F0", Offset = "0x5A9D4F0", VA = "0x185A9E8F0")]
		public VisualElementAnimationSystem()
		{
		}

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<IValueAnimationUpdate> m_Animations;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x28")]
		private List<IValueAnimationUpdate> m_IterationList;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x30")]
		private bool m_HasNewAnimations;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x31")]
		private bool m_IterationListDirty;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_Description;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker s_ProfilerMarker;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string s_StylePropertyAnimationDescription;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x18")]
		private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x38")]
		private long lastUpdate;
	}
}
