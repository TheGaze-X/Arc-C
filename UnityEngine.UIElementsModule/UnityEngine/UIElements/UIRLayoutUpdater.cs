using System;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000207 RID: 519
	[Token(Token = "0x2000207")]
	internal class UIRLayoutUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x00006D80 File Offset: 0x00004F80
		[Token(Token = "0x17000331")]
		public override ProfilerMarker profilerMarker
		{
			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0x5B18110", Offset = "0x5B16D10", VA = "0x185B18110", Slot = "10")]
			get
			{
				return default(ProfilerMarker);
			}
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x5B17570", Offset = "0x5B16170", VA = "0x185B17570", Slot = "13")]
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x5B17DC0", Offset = "0x5B169C0", VA = "0x185B17DC0", Slot = "12")]
		public override void Update()
		{
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x5B175E0", Offset = "0x5B161E0", VA = "0x185B175E0")]
		private void UpdateSubTree(VisualElement ve, int currentLayoutPass, bool isDisplayed = true)
		{
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public UIRLayoutUpdater()
		{
		}

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_Description;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker s_ProfilerMarker;
	}
}
