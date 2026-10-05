using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	public abstract class PostProcessingComponent<T> : PostProcessingComponentBase where T : PostProcessingModel
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000078")]
		public T model
		{
			[Token(Token = "0x60003C9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CB")]
		public virtual void Init(PostProcessingContext pcontext, T pmodel)
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CC")]
		public override PostProcessingModel GetModel()
		{
			return null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CD")]
		protected PostProcessingComponent()
		{
		}
	}
}
