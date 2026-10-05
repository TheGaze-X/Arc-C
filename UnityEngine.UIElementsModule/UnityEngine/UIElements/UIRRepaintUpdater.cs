using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	internal class UIRRepaintUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x06000DFC RID: 3580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x5B194B0", Offset = "0x5B180B0", VA = "0x185B194B0")]
		public UIRRepaintUpdater()
		{
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x17000335")]
		public override ProfilerMarker profilerMarker
		{
			[Token(Token = "0x6000DFD")]
			[Address(RVA = "0x5B19540", Offset = "0x5B18140", VA = "0x185B19540", Slot = "10")]
			get
			{
				return default(ProfilerMarker);
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x17000336")]
		public bool drawStats
		{
			[Token(Token = "0x6000DFE")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x17000337")]
		public bool breakBatches
		{
			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0x4E1BBB0", Offset = "0x4E1A7B0", VA = "0x184E1BBB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x5B19060", Offset = "0x5B17C60", VA = "0x185B19060", Slot = "13")]
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x5B19250", Offset = "0x5B17E50", VA = "0x185B19250", Slot = "12")]
		public override void Update()
		{
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x5B18360", Offset = "0x5B16F60", VA = "0x185B18360", Slot = "14")]
		protected virtual RenderChain CreateRenderChain()
		{
			return null;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x5B18B00", Offset = "0x5B17700", VA = "0x185B18B00")]
		private static void OnGraphicsResourcesRecreate(bool recreate)
		{
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x5B18CA0", Offset = "0x5B178A0", VA = "0x185B18CA0")]
		private void OnPanelChanged(BaseVisualElementPanel obj)
		{
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x5B18160", Offset = "0x5B16D60", VA = "0x185B18160")]
		private void AttachToPanel()
		{
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x5B184D0", Offset = "0x5B170D0", VA = "0x185B184D0")]
		private void DetachFromPanel()
		{
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x5B186D0", Offset = "0x5B172D0", VA = "0x185B186D0")]
		private void InitRenderChain()
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x5B183D0", Offset = "0x5B16FD0", VA = "0x185B183D0")]
		internal void DestroyRenderChain()
		{
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x5B18C90", Offset = "0x5B17890", VA = "0x185B18C90")]
		private void OnPanelAtlasChanged()
		{
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x5B18CC0", Offset = "0x5B178C0", VA = "0x185B18CC0")]
		private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType)
		{
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x5B18D00", Offset = "0x5B17900", VA = "0x185B18D00")]
		private void OnPanelStandardShaderChanged()
		{
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x5B18EB0", Offset = "0x5B17AB0", VA = "0x185B18EB0")]
		private void OnPanelStandardWorldSpaceShaderChanged()
		{
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x5B191B0", Offset = "0x5B17DB0", VA = "0x185B191B0")]
		private void ResetAllElementsDataRecursive(VisualElement ve)
		{
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00006F60 File Offset: 0x00005160
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000338")]
		private protected bool disposed
		{
			[Token(Token = "0x6000E0F")]
			[Address(RVA = "0xF02F50", Offset = "0xF01B50", VA = "0x180F02F50")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E10")]
			[Address(RVA = "0x508CC00", Offset = "0x508B800", VA = "0x18508CC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x5B186A0", Offset = "0x5B172A0", VA = "0x185B186A0", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x20")]
		private BaseVisualElementPanel attachedPanel;

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0x28")]
		internal RenderChain renderChain;

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_Description;

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker s_ProfilerMarker;
	}
}
