using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	public abstract class PostProcessingComponentCommandBuffer<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x060003CE RID: 974
		[Token(Token = "0x60003CE")]
		public abstract CameraEvent GetCameraEvent();

		// Token: 0x060003CF RID: 975
		[Token(Token = "0x60003CF")]
		public abstract string GetName();

		// Token: 0x060003D0 RID: 976
		[Token(Token = "0x60003D0")]
		public abstract void PopulateCommandBuffer(CommandBuffer cb);

		// Token: 0x060003D1 RID: 977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D1")]
		protected PostProcessingComponentCommandBuffer()
		{
		}
	}
}
