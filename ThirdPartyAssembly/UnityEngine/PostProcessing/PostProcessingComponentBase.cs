using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	public abstract class PostProcessingComponentBase
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
		public virtual DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060003C4 RID: 964
		[Token(Token = "0x17000077")]
		public abstract bool active { [Token(Token = "0x60003C4")] get; }

		// Token: 0x060003C5 RID: 965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public virtual void OnEnable()
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public virtual void OnDisable()
		{
		}

		// Token: 0x060003C7 RID: 967
		[Token(Token = "0x60003C7")]
		public abstract PostProcessingModel GetModel();

		// Token: 0x060003C8 RID: 968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected PostProcessingComponentBase()
		{
		}

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x10")]
		public PostProcessingContext context;
	}
}
