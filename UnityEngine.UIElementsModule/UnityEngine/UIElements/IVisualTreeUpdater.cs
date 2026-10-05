using System;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	internal interface IVisualTreeUpdater : IDisposable
	{
		// Token: 0x17000149 RID: 329
		// (set) Token: 0x060005F4 RID: 1524
		[Token(Token = "0x17000149")]
		BaseVisualElementPanel panel { [Token(Token = "0x60005F4")] set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005F5 RID: 1525
		[Token(Token = "0x1700014A")]
		ProfilerMarker profilerMarker { [Token(Token = "0x60005F5")] get; }

		// Token: 0x060005F6 RID: 1526
		[Token(Token = "0x60005F6")]
		void Update();

		// Token: 0x060005F7 RID: 1527
		[Token(Token = "0x60005F7")]
		void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
	}
}
