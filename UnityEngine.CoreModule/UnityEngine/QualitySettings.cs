using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[NativeHeader("Runtime/Graphics/QualitySettings.h")]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
	public sealed class QualitySettings : Object
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000347 RID: 839
		// (set) Token: 0x06000348 RID: 840
		[Token(Token = "0x170000C4")]
		public static extern int pixelLightCount { [Token(Token = "0x6000347")] [Address(RVA = "0x592D7E0", Offset = "0x592C3E0", VA = "0x18592D7E0")] [MethodImpl(4096)] get; [Token(Token = "0x6000348")] [Address(RVA = "0x592E210", Offset = "0x592CE10", VA = "0x18592E210")] [MethodImpl(4096)] set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000349 RID: 841
		// (set) Token: 0x0600034A RID: 842
		[Token(Token = "0x170000C5")]
		[NativeProperty("ShadowQuality")]
		public static extern ShadowQuality shadows { [Token(Token = "0x6000349")] [Address(RVA = "0x5936850", Offset = "0x5935450", VA = "0x185936850")] [MethodImpl(4096)] get; [Token(Token = "0x600034A")] [Address(RVA = "0x59368C0", Offset = "0x59354C0", VA = "0x1859368C0")] [MethodImpl(4096)] set; }

		// Token: 0x170000C6 RID: 198
		// (set) Token: 0x0600034B RID: 843
		[Token(Token = "0x170000C6")]
		[NativeProperty("ShadowResolution")]
		public static extern ShadowResolution shadowResolution { [Token(Token = "0x600034B")] [Address(RVA = "0x5936880", Offset = "0x5935480", VA = "0x185936880")] [MethodImpl(4096)] set; }

		// Token: 0x170000C7 RID: 199
		// (set) Token: 0x0600034C RID: 844
		[Token(Token = "0x170000C7")]
		public static extern int vSyncCount { [Token(Token = "0x600034C")] [Address(RVA = "0x5936900", Offset = "0x5935500", VA = "0x185936900")] [MethodImpl(4096)] set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600034D RID: 845
		[Token(Token = "0x170000C8")]
		public static extern int antiAliasing { [Token(Token = "0x600034D")] [Address(RVA = "0x5936820", Offset = "0x5935420", VA = "0x185936820")] [MethodImpl(4096)] get; }

		// Token: 0x0600034E RID: 846
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x59367B0", Offset = "0x59353B0", VA = "0x1859367B0")]
		[NativeName("SetCurrentIndex")]
		[MethodImpl(4096)]
		public static extern void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges);

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600034F RID: 847
		[Token(Token = "0x170000C9")]
		public static extern ColorSpace activeColorSpace { [Token(Token = "0x600034F")] [Address(RVA = "0x59367F0", Offset = "0x59353F0", VA = "0x1859367F0")] [NativeName("GetColorSpace")] [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)] [MethodImpl(4096)] get; }
	}
}
