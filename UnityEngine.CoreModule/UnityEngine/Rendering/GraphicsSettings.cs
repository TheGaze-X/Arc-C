using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x0200026A RID: 618
	[Token(Token = "0x200026A")]
	[StaticAccessor("GetGraphicsSettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
	public sealed class GraphicsSettings : Object
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000D93 RID: 3475
		[Token(Token = "0x170002AF")]
		public static extern bool lightsUseLinearIntensity { [Token(Token = "0x6000D93")] [Address(RVA = "0x595BF60", Offset = "0x595AB60", VA = "0x18595BF60")] [MethodImpl(4096)] get; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000D94 RID: 3476
		[Token(Token = "0x170002B0")]
		public static extern bool useScriptableRenderPipelineBatching { [Token(Token = "0x6000D94")] [Address(RVA = "0x595C060", Offset = "0x595AC60", VA = "0x18595C060")] [MethodImpl(4096)] get; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002B1")]
		public static RenderPipelineAsset renderPipelineAsset
		{
			[Token(Token = "0x6000D95")]
			[Address(RVA = "0x595BF90", Offset = "0x595AB90", VA = "0x18595BF90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000D96 RID: 3478
		[Token(Token = "0x170002B2")]
		[NativeName("DefaultRenderPipeline")]
		private static extern ScriptableObject INTERNAL_defaultRenderPipeline { [Token(Token = "0x6000D96")] [Address(RVA = "0x595BE60", Offset = "0x595AA60", VA = "0x18595BE60")] [MethodImpl(4096)] get; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002B3")]
		public static RenderPipelineAsset defaultRenderPipeline
		{
			[Token(Token = "0x6000D97")]
			[Address(RVA = "0x595BE90", Offset = "0x595AA90", VA = "0x18595BE90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D98 RID: 3480
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x595BE20", Offset = "0x595AA20", VA = "0x18595BE20")]
		[NativeName("GetShaderModeScript")]
		[MethodImpl(4096)]
		public static extern BuiltinShaderMode GetShaderMode(BuiltinShaderType type);
	}
}
